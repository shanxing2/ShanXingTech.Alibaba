Imports System.Net
Imports System.Text.RegularExpressions
Imports System.Threading.Tasks
Imports ShanXingTech
Imports ShanXingTech.Net2

Namespace ShanXingTech.Alibaba
    Public Class ShengEJingHelper
#Region "字段区"
        'Private m_HttpHeadersParam As Dictionary(Of String, String)
        Private m_UserAgent As String
        Private m_Domain As String
#End Region

#Region "属性"
        Private m_IsLogin As Boolean
        Public ReadOnly Property IsLogin() As Boolean
            Get
                Return m_IsLogin
            End Get
        End Property

        Private m_ModifyBaobeiIdBag As Concurrent.ConcurrentBag(Of String)
        Public ReadOnly Property ModifyBaobeiIdBc() As Concurrent.ConcurrentBag(Of String)
            Get
                Return m_ModifyBaobeiIdBag
            End Get
        End Property

#End Region

#Region "构造函数"
        ''' <summary>
        ''' 构造函数
        ''' </summary>
        ''' <param name="domain">登录成功生e经后的domain（会变动）</param>
        ''' <param name="userAgent">模拟浏览器UA</param>
        ''' <param name="modifyBaobeiIds">可以用于修改的宝贝Id</param>
        Public Sub New(ByVal domain As String, ByVal userAgent As String, ByVal modifyBaobeiIds As String())
            m_ModifyBaobeiIdBag = New Concurrent.ConcurrentBag(Of String)
            For Each id In modifyBaobeiIds
                m_ModifyBaobeiIdBag.Add(id)
            Next
            m_UserAgent = userAgent
            m_Domain = domain
        End Sub
#End Region

#Region "函数区"
        ''' <summary>
        ''' 
        ''' </summary>
        ''' <param name="url"></param>
        ''' <returns></returns>
        Private Async Function TryDoGet(ByVal url As String, ByVal httpHeadersParam As Dictionary(Of String, String)) As Task(Of String)
            ' 更新店内宝贝的标题为搜索的标题（只能分析自己店铺的宝贝）
            Dim getRst = Await HttpAsync.GetAsync(url, httpHeadersParam)
            Do While getRst.StatusCode <> HttpStatusCode.OK OrElse getRst.Message.Length = 0
                getRst = Await HttpAsync.GetAsync(url, httpHeadersParam)
            Loop

            If HttpStatusCode.BadRequest = getRst.StatusCode Then
                Return Await TryDoGet(url, httpHeadersParam)
            End If

            If HttpStatusCode.OK = getRst.StatusCode Then
                Return getRst.Message
            Else
                Return getRst.StatusCode.ToString
            End If
        End Function

        ''' <summary>
        ''' 搜索关键词，获得包含词根的搜索结果
        ''' </summary>
        ''' <param name="keyword"></param>
        ''' <returns></returns>
        Public Async Function SearchAsync(ByVal keyword As String) As Task(Of (Success As Boolean, Message As String))
            ' 生e经只能分词自己店铺的宝贝，所以需要在自己店铺发布一个专用的宝贝
            ' 把这个宝贝的标题修改为需要搜索的 keyword ,然后分析即可得到这个 keyword 的词根
            Dim modifyBaobeiId = String.Empty
            Dim message = String.Empty
            Dim succeed As Boolean

            Try
                modifyBaobeiId = GetBaobeiId()
                Dim baobeiUrl = $"{m_Domain}/baobei_modify_do.php?iid={modifyBaobeiId}"
                Dim httpHeadersParam = New Dictionary(Of String, String) From {
                    {"dnt", "1"},
                    {"cache-control", "no-cache"},
                    {"pragma", "no-cache"},
                    {"Accept-Encoding", "gzip, deflate"},
                    {"User-Agent", m_UserAgent},
                    {"referer", baobeiUrl}
                }
                succeed = Await UpdateTitle(keyword, baobeiUrl， httpHeadersParam)
                If succeed Then
                    message = Await AnalysisAsync(modifyBaobeiId, httpHeadersParam)
                Else
                    message = $"更新标题失败 关键词:{keyword} 宝贝Id:{modifyBaobeiId}"
                End If
            Catch ex As Exception
                Logger.WriteLine(ex)
            Finally
                ' 用完了及时还回
                m_ModifyBaobeiIdBag.Add(modifyBaobeiId)
            End Try

            Return (succeed, message)
        End Function

        Private Function GetBaobeiId() As String
            Dim id = String.Empty
            'Await Task.Run(
            '    Sub()
            Do
                m_ModifyBaobeiIdBag.TryTake(id)
                Windows2.Delay(100)
            Loop Until Not id.IsNullOrEmpty
            'End Sub)
            Return id
        End Function

        Private Async Function UpdateTitle(ByVal keyword As String, ByVal baobeiUrl As String, ByVal httpHeadersParam As Dictionary(Of String, String)) As Task(Of Boolean)
            Dim url = $"{baobeiUrl}&title={keyword.UrlEncode(Text.Encoding.UTF8)}"
            Dim rst = Await TryDoGet(url, httpHeadersParam)
            ' 更新成功只返回一个 0
            Return "0".Equals(rst, StringComparison.OrdinalIgnoreCase)
        End Function

        ''' <summary>
        ''' 分析宝贝
        ''' </summary>
        ''' <returns></returns>
        Private Async Function AnalysisAsync(ByVal baobeiId As String, ByVal httpHeadersParam As Dictionary(Of String, String)) As Task(Of String)
            Dim url = $"{m_Domain}/index.php?tab=4&func=bbtitleanalysis&iid={baobeiId}"
            Return Await TryDoGet(url, httpHeadersParam)
        End Function

        ''' <summary>
        ''' 获取词根
        ''' </summary>
        ''' <param name="html"><see cref="SearchAsync(String)"/>的搜索结果</param>
        ''' <returns></returns>
        Public Iterator Function GetWordRoot(ByVal html As String) As IEnumerable(Of String)
            Dim pattern = "宝贝无线APP搜索分词.*?PC端直通车词分析"
            Dim match = Regex.Match(html, pattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
            If Not match.Success Then
                Logger.WriteLine( "获取分词div失败")
                Return
            End If

            pattern = "<div>(\w+)<br>"
            Dim matches = Regex.Matches(match.Value, pattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
            For Each match2 As Match In matches
                Yield match2.Groups(1).Value
            Next
        End Function
#End Region
    End Class

End Namespace
