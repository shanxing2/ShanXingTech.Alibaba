Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Web
Imports ShanXingTech
Imports ShanXingTech.Net2

Namespace ShanXingTech.Alibaba
    ''' <summary>
    ''' 淘宝H5
    ''' </summary>
    Public MustInherit Class H5Client

#Region "常量区"

#End Region

#Region "属性区"
        Public ReadOnly Property Cookies As CookieContainer
        Public ReadOnly Property UserAgent As String

        Private _m_h5_tk As String
        Public ReadOnly Property m_h5_tk As String
            Get
                Return _m_h5_tk
            End Get
        End Property

        Private m_ExpireTime As Date
        ''' <summary>
        ''' <see cref="m_h5_tk"/> 的过期时间
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property ExpireTime As Date
            Get
                Return m_ExpireTime
            End Get
        End Property

        Private m_AppKey As String
        ''' <summary>
        ''' AppKey，默认为H5端公用AppKey 12574478
        ''' </summary>
        ''' <returns></returns>
        Public Property AppKey() As String
            Get
                Return If(m_AppKey, "12574478")
            End Get
            Set(ByVal value As String)
                m_AppKey = value
            End Set
        End Property


#End Region

#Region "字段区"

        Private ReadOnly m_Http As HttpAsync
        ' 完整的应为 https://h5api.m.taobao.com/h5/mtop.taobao.baichuan.smb.get/1.0/?jsv=2.4.11&appKey=12574478&t=1524934501134&sign=ed5c50cd3b335ba7b61b8de9ebd8f0d6&api=mtop.taobao.baichuan.smb.get&v=1.0&type=originaljson&dataType=jsonp&timeout=10000
        ''' <summary>
        ''' 用于获取第一个Sign
        ''' </summary>
        Private ReadOnly m_DefaultApiUrl As String
        Private m_ReGetBase_m_h5_tk As Boolean
        Private m_m_h5_tkGetting As Integer
#End Region

#Region "构造函数 区"
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="cookies">可以是PC端登录成功后的cookies，如果没有操作淘宝 H5 端的cookies，那么工具会自动获取</param>
        ''' <param name="userAgent">需要模拟的浏览器的UserAgent</param>
        Protected Sub New(ByVal cookies As CookieContainer, ByVal userAgent As String)
            Me.Cookies = cookies
            Me.UserAgent = userAgent
            m_Http = New HttpAsync(cookies)
            m_DefaultApiUrl = $"https://h5api.m.taobao.com/h5/mtop.taobao.baichuan.smb.get/1.0/?jsv=2.4.11&appKey={AppKey}&api=mtop.taobao.baichuan.smb.get&v=1.0&type=originaljson&dataType=jsonp&timeout=10000"
        End Sub

#End Region

#Region "函数区"
        ''' <summary>
        ''' 重新设置cookie以初始化
        ''' </summary>
        ''' <param name="cookies"></param>
        Public Sub ResetCookie(ByRef cookies As CookieContainer)
            m_Http.ReInit(cookies)
        End Sub

        ''' <summary>
        ''' 执行Post请求
        ''' </summary>
        ''' <param name="url"></param>
        ''' <param name="postData">请求主体，不需要编码，直接原字符串传入。如果传入有包含编码的数据，可能会导致乱码或者数据丢失</param>
        ''' <param name="referer"></param>
        ''' <param name="encoding">请求主体的编码方式，必须跟抓包的一致，否则可能会导致乱码</param>
        ''' <returns></returns>
        Public Async Function DoPostAsync(ByVal url As String, ByVal postData As String, ByVal referer As String, ByVal encoding As Text.Encoding) As Task(Of HttpResponse)
            Dim httpHeadersParam As New Dictionary(Of String, String) From {
            {"User-Agent", UserAgent},
            {"Connection", "keep-alive"},
            {"Cache-Control", "no-cache"},
            {"Accept-Encoding", "gzip, deflate"},
            {"Referer", referer}
        }

            Return Await m_Http.TryPostAsync(url, httpHeadersParam, postData, encoding, 3)
        End Function

        ''' <summary>
        ''' 执行Get请求
        ''' </summary>
        ''' <param name="url"></param>
        ''' <param name="referer"></param>
        ''' <returns></returns>
        Public Async Function DoGetAsync(ByVal url As String, ByVal referer As String) As Task(Of HttpResponse)
            Dim httpHeadersParam As New Dictionary(Of String, String) From {
                {"User-Agent", UserAgent},
                {"Connection", "keep-alive"},
                {"Cache-Control", "no-cache"},
                {"Accept-Encoding", "gzip, deflate"},
                {"Referer", referer}
            }
            Dim getRst = Await m_Http.TryGetAsync(url, httpHeadersParam, 3)
            ' "ret":["SUCCESS::调用成功"],"v":"1.0"}
            ' "ret":["FAIL_SYS_ILLEGAL_ACCESS::非法请求"],"v":"1.0"}
            ' 新版手机淘宝要求一定要先登录才能搜索，否则会返回 ret: ["RGV587_ERROR::SM" 20190104
            While Not getRst.Success OrElse getRst.Message.Length = 0
                getRst = Await m_Http.TryGetAsync(url, httpHeadersParam, 3)
            End While

            Return getRst
        End Function

        ''' <summary>
        ''' 执行Get请求
        ''' </summary>
        ''' <param name="url"></param>
        ''' <returns></returns>
        Public Async Function DoGetAsync(ByVal url As String) As Task(Of HttpResponse)
            Return Await DoGetAsync(url, "https://s.m.taobao.com/h5")
        End Function

        ''' <summary>
        ''' 获取淘宝H5端API操作需要的Sign
        ''' </summary>
        ''' <param name="data">get方式使用Url参数data键的值,post方式使用请求文本body里data的值</param>
        ''' <returns>返回生成的Sign跟生成Sign时用的TimeStamp，执行API操作时需要用这个TimeStamp，否则有可能会返回 '非法请求'</returns>
        Public Async Function GetSignAsync(ByVal data As String) As Task(Of (Sign As String, TimeStamp As String))
            If _m_h5_tk.IsNullOrEmpty Then
                _m_h5_tk = Await Getm_h5_tkAsync()
            End If

            Dim timeStamp = Date.Now.ToTimeStampString(TimePrecision.Millisecond)
            Dim sign = $"{_m_h5_tk}&{timeStamp}&{AppKey}&{data}"
            sign = sign.GetMD5Value

            Return (sign, timeStamp)
        End Function

        ''' <summary>
        ''' 重新获取基础令牌。如果请求返回 类似 ‘FAIL_SYS_TOKEN_EXOIRED::令牌过期’或‘FAIL_SYS_ILLEGAL_ACCESS::非法请求’，可以尝试执行一次这个函数
        ''' </summary>
        ''' <returns></returns>
        Public Async Function ReGetBaseTokenAsync() As Task
            _m_h5_tk = String.Empty
            m_ReGetBase_m_h5_tk = True
            Await Getm_h5_tkAsync()
        End Function

        Private Async Function Getm_h5_tkAsync() As Task(Of String)
            ' Exchange 不能用 Boolean类型的参数，所以只能定义成支持的类型
            ' 1 表示获取中，0相反
            While 1 = m_m_h5_tkGetting
                Await Task.Delay(100)
            End While
            Threading.Interlocked.Exchange(m_m_h5_tkGetting, 1)
            Try
                ' 如果已经获取到那就不需要再获取
                If Not _m_h5_tk.IsNullOrEmpty Then
                    Exit Try
                End If

                ' 47799a06b574c2de203cd4f3f914d7c2_1524864155383
                ' 只取 _ 前面部分
                Dim pattern = "_m_h5_tk=([a-z0-9]+)_(\d+)"
                For i = 0 To 2
                    ' 需要重新获取Base_m_h5_tk的时候，cookie里面的已经失效了，不能再从cookies获取
                    If Not m_ReGetBase_m_h5_tk Then
                        Dim match = Regex.Match(Cookies.ToKeyValuePairs, pattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
                        _m_h5_tk = match.Groups(1).Value
                        Dim expireTime = match.Groups(2).Value
                        If Not expireTime.IsNullOrEmpty Then
                            m_ExpireTime = CLng(expireTime).ToTimeStampTime(TimePrecision.Millisecond)
                        End If
                    End If
                    m_ReGetBase_m_h5_tk = False

                    Dim expired = m_ExpireTime < Now
                    ' 如果token已经过期，那么得把相应的cookie设置为失效状态，否则m_Http不会自动更新对应Cookie   20191225
                    If expired Then
                        Cookies.TryExpire({"t", "_m_h5_tk", "_m_h5_tk_enc"})
                    End If

                    ' 如果传入的是PC端的cookies，可能没有 _m_h5_tk 这个cookies
                    ' 需要向淘宝H5端提交任意一个请求，才会返回 _m_h5_tk 
                    ' 如果已经获取到了，那就返回
                    If Not expired AndAlso _m_h5_tk.Length > 0 Then
                        Debug.Print(Logger.MakeDebugString("获取_m_h5_tk请求完成   " & _m_h5_tk))
                        Exit For
                    End If

                    ' 如果还没有 _m_h5_tk 那就从cookies中获取
                    Dim data As New Data With {
                        .pageCode = "mainIndex",
                        .ua = UserAgent,
                        .params = New Params With {
                            .url = "https://h5.m.taobao.com",
                            .referrer = ""
                        }
                    }
                    Dim serialData = MSJsSerializer.Serialize(data)
                    Dim url = $"{m_DefaultApiUrl}&t={Date.Now.ToTimeStampString(TimePrecision.Millisecond)}&sign={GetFirstSign(serialData)}"
                    Await m_Http.TryGetThreeTimeIfErrorAsync(url)
                Next
            Catch ex As Exception
                Logger.WriteLine(ex)
            Finally
                Threading.Interlocked.Exchange(m_m_h5_tkGetting, 0)
            End Try

            Return _m_h5_tk
        End Function

        ''' <summary>
        ''' 仅限于用于内部获取第一个用于API请求的 m_h5_tk
        ''' </summary>
        ''' <param name="data"></param>
        ''' <returns></returns>
        Private Function GetFirstSign(ByVal data As String) As String
            ' 此处获取到的m_h5_tk貌似是有时效或者是请求个数限制，达到限制之后，得重新获取才能继续请求，不然会导致返回
            '  {"api":"mtop.taobao.wsearch.h5search","data":{},"ret":["FAIL_SYS_ILLEGAL_ACCESS::非法请求"],"v":"1.0"}
            ' 20181218

            ' 传递空字符串
            Dim tempm_h5_tk = " "
            ' 如果传入的是PC端的cookies，可能没有 _m_h5_tk 这个cookies
            ' 需要向淘宝H5端提交任意一个请求，才会返回 _m_h5_tk 
            ' 所以第一次请求的时候 m_h5_tk 阔以为 一个空
            Dim sign = $"{tempm_h5_tk}&{Date.Now.ToTimeStampString(TimePrecision.Millisecond)}&{AppKey}&{data}"
            sign = sign.GetMD5Value

            Return sign
        End Function

#End Region



#Region "内部类"

#Disable Warning IDE1006 ' 命名样式
        Private Class Data
            ''' <summary>
            ''' 默认为mainIndex即可
            ''' </summary>
            ''' <returns></returns>
            Public Property pageCode As String
            ''' <summary>
            ''' 需要模拟的浏览器的UserAgent
            ''' </summary>
            ''' <returns></returns>
            Public Property ua As String
            Public Property params As Params
        End Class


        Private Class Params
            ''' <summary>
            ''' 默认为 https://h5.m.taobao.com 即可
            ''' </summary>
            ''' <returns></returns>
            Public Property url As String
            ''' <summary>
            ''' 默认为空即可 
            ''' </summary>
            ''' <returns></returns>
            Public Property referrer As String
        End Class
#Enable Warning IDE1006 ' 命名样式
#End Region

    End Class
End Namespace

