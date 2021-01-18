Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Windows.Forms

Imports ShanXingTech
Imports ShanXingTech.Alibaba.H5ApiSearchResultEntity
Imports ShanXingTech.Exception2
Imports ShanXingTech.Net2
Imports ShanXingTech.Text2

Namespace ShanXingTech.Alibaba
    Public Class H5SearcherBase
        Inherits H5Client
        Implements IDisposable


#Region "字段区"
        Private m_BaseUrlTemplete As String
        Private m_BaseRefererTemplete As String
        Private m_IsInit As Boolean
        Private m_SearchDataDic As Dictionary(Of String, Object)
        Private m_Cts As Threading.CancellationTokenSource
#End Region

#Region "属性 区"
        ''' <summary>
        ''' 类的实例化窗体
        ''' </summary>
        ''' <returns></returns>
        Private Property instanceForm As Form
        Public Property TryTimesIfError As Integer
#End Region

#Region "构造函数 区"
        Public Sub New(cookies As CookieContainer, userAgent As String)
            MyBase.New(cookies, userAgent)

            TryTimesIfError = 3

            ' 获取实例化这个类的窗体,窗体已经show之后才能获取到实例化这个类的窗体
            instanceForm = TryCast(Control.FromHandle(Process.GetCurrentProcess().MainWindowHandle), Form)

            m_Cts = New Threading.CancellationTokenSource
        End Sub
#End Region

#Region "IDisposable Support"
        Private disposedValue As Boolean ' 要检测冗余调用

        ' IDisposable
        Protected Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    ' TODO: 释放托管资源(托管对象)。
                    m_Cts?.Dispose()
                End If

                ' TODO: 释放未托管资源(未托管对象)并在以下内容中替代 Finalize()。
                ' TODO: 将大型字段设置为 null。
            End If
            disposedValue = True
        End Sub

        ' TODO: 仅当以上 Dispose(disposing As Boolean)拥有用于释放未托管资源的代码时才替代 Finalize()。
        'Protected Overrides Sub Finalize()
        '    ' 请勿更改此代码。将清理代码放入以上 Dispose(disposing As Boolean)中。
        '    Dispose(False)
        '    MyBase.Finalize()
        'End Sub

        ' Visual Basic 添加此代码以正确实现可释放模式。
        Public Sub Dispose() Implements IDisposable.Dispose
            ' 请勿更改此代码。将清理代码放入以上 Dispose(disposing As Boolean)中。
            Dispose(True)
            ' TODO: 如果在以上内容中替代了 Finalize()，则取消注释以下行。
            ' GC.SuppressFinalize(Me)
        End Sub
#End Region


#Region "函数区"
        Public Async Function InitAsync() As Task(Of Boolean)
            If m_IsInit Then Return True

            m_SearchDataDic = New Dictionary(Of String, Object)

            m_IsInit = Await MakeBaseUrlTempleteAsync()

            Return m_IsInit
        End Function

        Private Async Function MakeBaseUrlTempleteAsync() As Task(Of Boolean)
            Dim h5HomePage = "https://h5.m.taobao.com/"
            Await SearchAsync(h5HomePage)

            Dim searchUrl = "https://s.m.taobao.com/h5?search-btn=&event_submit_do_new_search_auction=1&_input_charset=utf-8&topSearch=1&atype=b&searchfrom=1&action=home%3Aredirect_app_action&from=1"
            Dim html = Await SearchAsync(searchUrl)
            Dim rst = InternalMakeBaseTempleteAsync(html)
            m_BaseUrlTemplete = rst.Url
            m_BaseRefererTemplete = rst.Referer

            Return Not m_BaseUrlTemplete.IsNullOrEmpty
        End Function

        Private Function InternalMakeBaseTempleteAsync(ByVal html As String) As (Url As String， Referer As String)
            Dim url As String
            Dim referer As String

            ' 无搜索排序 https://acs.m.taobao.com/h5/mtop.taobao.wsearch.h5search/1.0/?jsv=2.3.16&appKey=12574478&t=1544846542207&sign=7e5aeeac1f51f9df4526f20f642be0bc&api=mtop.taobao.wsearch.h5search&v=1.0&H5Request=true&ecode=1&type=jsonp&dataType=jsonp&callback=mtopjsonp3&data={"event_submit_do_new_search_auction":"1","_input_charset":"utf-8","topSearch":"1","atype":"b","searchfrom":"1","action":"home:redirect_app_action","from":"1","q":"aaa","sst":"1","n":20,"buying":"buyitnow","m":"api4h5","token4h5":"","abtest":"6","wlsort":"6","style":"list","closeModues":"nav,selecthot,onesearch","page":1}
            ' 有搜索排序 _sale——销量高到低，_bid——价格高到低，bid——价格低到高，_ratesum——信用排序，https://acs.m.taobao.com/h5/mtop.taobao.wsearch.h5search/1.0/?jsv=2.3.16&appKey=12574478&t=1544846521735&sign=692b91cf710f91d143553637ac1aa2e7&api=mtop.taobao.wsearch.h5search&v=1.0&H5Request=true&ecode=1&type=jsonp&dataType=jsonp&callback=mtopjsonp2&data={"event_submit_do_new_search_auction":"1","_input_charset":"utf-8","topSearch":"1","atype":"b","searchfrom":"1","action":"home:redirect_app_action","from":"1","q":"aaa","sst":"1","n":20,"buying":"buyitnow","m":"api4h5","token4h5":"","abtest":"6","wlsort":"6","style":"list","closeModues":"nav,selecthot,onesearch","sort":"_sale","page":1}
            Dim pattern = "lib-mtop/(.*?)/mtop\.js"
            Dim match = Regex.Match(html, pattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
            If Not match.Success Then Return (String.Empty, String.Empty)
            Dim jsv = match.Groups(1).Value

            Dim sb = StringBuilderCache.Acquire(360)
            sb.Append("https://acs.m.taobao.com/h5/mtop.taobao.wsearch.h5search/1.0/?jsv=").Append(jsv).Append("&appKey=12574478&t={0}&sign={1}&api=mtop.taobao.wsearch.h5search&v=1.0&H5Request=true&ecode=1&AntiCreep=true&AntiFlool=true&data=")
            pattern = "<script type=""text/javascript"">(?:\r\n|\r|\n)\s*window\.(SearchH5[\s\S]*?)</script>"
            match = Regex.Match(html, pattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
            If Not match.Success Then Return (String.Empty, String.Empty)
            Dim js = match.Groups(1).Value

            pattern = "apiConfig:{[\s\S]*?params:{([\s\S]*?)}"
            match = Regex.Match(js, pattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
            If Not match.Success Then Return (String.Empty, String.Empty)

            ' 不提取 'n':20, 
            pattern = "'(\w+)'\s?:\s?'(.*?)'"
            Dim matches = Regex.Matches(match.Groups(1).Value, pattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)

            For Each match2 As Match In matches
                m_SearchDataDic.Add(match2.Groups(1).Value， match2.Groups(2).Value)
                'sb.Append(match2.Groups(1).Value).Append("="c).Append(match2.Groups(2).Value).Append("&"c)
            Next
            m_SearchDataDic.Add("n", 20)

            pattern = "listApi:{[\s\S]*?params:{([\s\S]*?)}"
            match = Regex.Match(js, pattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
            If Not match.Success Then Return (String.Empty, String.Empty)

            pattern = "(\w+)\s?:\s?'(.*?)'"
            matches = Regex.Matches(match.Groups(1).Value, pattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
            For Each match2 As Match In matches
                'If "n" = match2.Groups(1).Value Then Continue For
                m_SearchDataDic.Add(match2.Groups(1).Value， match2.Groups(2).Value)
                'sb.Append(match2.Groups(1).Value).Append("="c).Append(match2.Groups(2).Value).Append("&"c)
            Next

            m_SearchDataDic.Add("style", "list")
            m_SearchDataDic.Add("closeModues", "nav,selecthot,onesearch")

            url = StringBuilderCache.GetStringAndReleaseBuilder(sb)
            referer = $"https://s.m.taobao.com/h5?event_submit_do_new_search_auction={m_SearchDataDic("event_submit_do_new_search_auction")}&_input_charset={m_SearchDataDic("_input_charset")}&topSearch={m_SearchDataDic("topSearch")}&atype={m_SearchDataDic("atype")}&searchfrom={m_SearchDataDic("searchfrom")}&action={m_SearchDataDic("action")}&from={m_SearchDataDic("from")}&sst={m_SearchDataDic("sst")}&n={m_SearchDataDic("n")}&buying={m_SearchDataDic("buying")}&q={{0}}"

            Return (url, referer)
        End Function


        Private Async Function SearchAsync(ByVal url As String) As Task(Of String)
            Dim getRst = Await DoGetAsync(url)
            If getRst.StatusCode <> Net.HttpStatusCode.OK OrElse
             Not CheckSearchResult(getRst.Message) Then
                For i = 1 To TryTimesIfError
                    Windows2.RandDelay(1000, 2000, TimePrecision.Millisecond)
                    getRst = Await DoGetAsync(url)
                    If getRst.StatusCode <> Net.HttpStatusCode.OK OrElse
                        Not CheckSearchResult(getRst.Message) Then
                        Continue For
                    Else
                        Exit For
                    End If
                Next
            End If

            Return If(getRst.StatusCode = Net.HttpStatusCode.OK, getRst.Message, String.Empty)
        End Function

        Private Function CheckSearchResult(ByVal json As String) As Boolean
            ' 对不起，您访问的页面不存在
            Dim succesed = json.Length > 0 AndAlso json.IndexOf("对不起，您访问的页面不存在") = -1

            Return succesed
        End Function

        Private Async Function GetSearchUrlAsync(ByVal keyword As String, ByVal saleSort As Boolean, ByVal page As Integer) As Task(Of String)
            If m_BaseUrlTemplete Is Nothing Then
                Throw New H5SearcherBaseUnInitializeException(String.Format(My.Resources.NullReference, NameOf(m_BaseUrlTemplete)))
            End If

            If m_SearchDataDic.ContainsKey("q") Then
                m_SearchDataDic("q") = keyword
            Else
                m_SearchDataDic.Add("q", keyword)
            End If
            If m_SearchDataDic.ContainsKey("page") Then
                m_SearchDataDic("page") = page
            Else
                m_SearchDataDic.Add("page", page)
            End If
            If saleSort Then
                If m_SearchDataDic.ContainsKey("sort") Then
                    m_SearchDataDic("sort") = "_sale"
                Else
                    m_SearchDataDic.Add("sort", "_sale")
                End If
            End If
            Dim data = m_SearchDataDic.Serialize
            Dim getSignRst = Await GetSignAsync(data)

            Return String.Format(m_BaseUrlTemplete, getSignRst.TimeStamp, getSignRst.Sign) & data
        End Function

        Private Function GetReferer(ByVal keyword As String) As String
            Return String.Format(m_BaseRefererTemplete, keyword)
        End Function

        ''' <summary>
        ''' H5搜索
        ''' </summary>
        ''' <param name="keyword">关键词</param>
        ''' <param name="saleSort">按照销量排序</param>
        ''' <param name="page">页数</param>
        ''' <returns></returns>
        Public Async Function SearchAsync(ByVal keyword As String, ByVal saleSort As Boolean, ByVal page As Integer) As Task(Of Root)
            If m_Cts.IsCancellationRequested Then
                m_Cts = New Threading.CancellationTokenSource
                Return Nothing
            End If

            Dim getRst = Await DoGetAsync(Await GetSearchUrlAsync(keyword, saleSort, page), GetReferer(keyword))
            If Not getRst.Success Then Return Nothing
            Dim json = getRst.Message

            If json.IsNullOrEmpty Then Return Nothing

            Dim root As Root
            Try
                root = MSJsSerializer.Deserialize(Of Root)(json)
                If root?.ret?.Count = 0 Then
                    Return Nothing
                Else
                    ' FAIL_SYS_ILLEGAL_ACCESS::非法请求
                    If root.ret(0).IndexOf("非法请求") > -1 Then
                        Await MyBase.ReGetBaseTokenAsync()
                        Await SearchAsync(keyword, saleSort, page)
                    End If
                End If
            Catch ex As ArgumentNullException
                Logger.WriteLine($"{ex.Message}   Keyword:{keyword}   SaleSort:{saleSort} Page:{page.ToStringOfCulture}   Json:{json}")
            Catch ex As ArgumentException
                Logger.WriteLine($"{ex.Message}   Keyword:{keyword}   SaleSort:{saleSort} Page:{page.ToStringOfCulture}   Json:{json}")
            Catch ex As InvalidOperationException
                Logger.WriteLine($"{ex.Message}   Keyword:{keyword}   SaleSort:{saleSort} Page:{page.ToStringOfCulture}   Json:{json}")
            Catch ex As Exception
                Logger.WriteLine(ex, $"Keyword:{keyword}  SaleSort:{saleSort}  Page:{page.ToStringOfCulture}   Json:{json}",,,)
            End Try

#Disable Warning bc42104
            Return root
#Enable Warning bc42104
        End Function

        ''' <summary>
        ''' 通知以取消搜索任务
        ''' </summary>
        Public Sub CancelSearch()
            m_Cts?.Cancel()
        End Sub

        Public Sub PauseSearch()

        End Sub

        Public Sub ResumeSearch()

        End Sub
#End Region
    End Class
End Namespace
