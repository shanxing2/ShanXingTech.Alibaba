Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Imports ShanXingTech
Imports ShanXingTech.Alibaba.H5SearchResultEntity
Imports ShanXingTech.Exception2
Imports ShanXingTech.Net2
Imports ShanXingTech.Text2


Namespace ShanXingTech.Alibaba
    Public Class H5SearcherBaseOld

#Region "字段区"
        Private m_BaseUrlTemplete As String
        Private m_IsInit As Boolean
        Private m_JsSerializer As Web.Script.Serialization.JavaScriptSerializer
#End Region

#Region "属性 区"
        ''' <summary>
        ''' 类的实例化窗体
        ''' </summary>
        ''' <returns></returns>
        Private Property instanceForm As Form
        Private Property httpHeadersParam As Dictionary(Of String, String)
        Public Property TryTimesIfError As Integer
#End Region

#Region "构造函数 区"

        ''' <summary>
        ''' 构造函数
        ''' </summary>
        Public Sub New()
            TryTimesIfError = 3

            m_JsSerializer = New Web.Script.Serialization.JavaScriptSerializer
            ' 获取实例化这个类的窗体,窗体已经show之后才能获取到实例化这个类的窗体
            instanceForm = TryCast(Control.FromHandle(Process.GetCurrentProcess().MainWindowHandle), Form)
        End Sub
#End Region

#Region "函数区"
        Public Async Function InitAsync() As Task(Of Boolean)
            If m_IsInit Then Return True

            httpHeadersParam = New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
            {"User-Agent", "Mozilla/5.0 (iPhone; CPU iPhone OS 9_1 like Mac OS X) AppleWebKit/601.1.46 (KHTML, like Gecko) Version/9.0 Mobile/13B143 Safari/601.1"},
            {"dnt", "1"},
            {"cache-control", "no-cache"},
            {"Accept-Encoding", "gzip, deflate, sdch, br"}，
            {"connection", "keep-alive"}
        }

            m_IsInit = Await MakeBaseUrlTempleteAsync()

            Return m_IsInit
        End Function

        Private Async Function MakeBaseUrlTempleteAsync() As Task(Of Boolean)
            Dim funRst As Boolean

            Dim h5HomePage = "https://h5.m.taobao.com/"
            Dim html = Await SearchInternal(h5HomePage)

            Dim searchUrl = "https://s.m.taobao.com/h5?search-btn=&event_submit_do_new_search_auction=1&_input_charset=utf-8&topSearch=1&atype=b&searchfrom=1&action=home%3Aredirect_app_action&from=1"
            html = Await SearchInternal(searchUrl)

            Dim pattern = "<script type=""text/javascript"">(?:\r\n|\r|\n)\s*window\.(SearchH5[\s\S]*?)</script>"
            Dim match = Regex.Match(html, pattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
            If Not match.Success Then Return funRst
            Dim jsCode = match.Groups(1).Value
            m_BaseUrlTemplete = MakeBaseUrlTempleteInternalAsync(jsCode)

            Return Not m_BaseUrlTemplete.IsNullOrEmpty
        End Function

        Private Function MakeBaseUrlTempleteInternalAsync(ByVal js As String) As String
            Dim funcRst As String
            ' https://s.m.taobao.com/search?event_submit_do_new_search_auction=1&_input_charset=utf-8&topSearch=1&atype=b&searchfrom=1&action=home%3Aredirect_app_action&from=1&q=%E9%A9%AC%E4%BA%91&sst=1&n=20&buying=buyitnow&m=api4h5&abtest=22&wlsort=22&style=list&closeModues=nav%2Cselecthot%2Conesearch&sort=_sale&page=1

            Dim pattern = "listApi:{(?:\r\n|\r|\n)\s*url:""(.*?)"""
            Dim match = Regex.Match(js, pattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
#Disable Warning BC42104 ' 在为变量赋值之前，变量已被使用
            If Not match.Success Then Return funcRst
#Enable Warning BC42104 ' 在为变量赋值之前，变量已被使用

            Dim sb = StringBuilderCache.Acquire(360)
            If match.Groups(1).Value.StartsWith("https:") Then
                sb.Append(match.Groups(1).Value)
            Else
                sb.Append("https:").Append(match.Groups(1).Value)
            End If

            pattern = "apiConfig:{[\s\S]*?params:{([\s\S]*?)}"
            match = Regex.Match(js, pattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
            If Not match.Success Then Return funcRst

            ' 不提取 'n':20, 
            pattern = "'(\w+)'\s?:\s?'(.*?)'"
            Dim matches = Regex.Matches(match.Groups(1).Value, pattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
            For Each match2 As Match In matches
                sb.Append(match2.Groups(1).Value).Append("="c).Append(match2.Groups(2).Value).Append("&"c)
            Next

            pattern = "listApi:{[\s\S]*?params:{([\s\S]*?)}"
            match = Regex.Match(js, pattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
            If Not match.Success Then Return funcRst

            pattern = "(\w+)\s?:\s?'(.*?)'"
            matches = Regex.Matches(match.Groups(1).Value, pattern, RegexOptions.IgnoreCase Or RegexOptions.Compiled)
            For Each match2 As Match In matches
                If "n" = match2.Groups(1).Value Then Continue For
                sb.Append(match2.Groups(1).Value).Append("="c).Append(match2.Groups(2).Value).Append("&"c)
            Next

            sb.Remove(sb.Length - 1, 1)
            funcRst = StringBuilderCache.GetStringAndReleaseBuilder(sb)

            Dim n = funcRst.GetQueryParamValue("n"c)
            If n.Length = 0 Then
                funcRst = funcRst & "&n=40"
            End If

            funcRst = funcRst & "&q={0}"

            Dim page = funcRst.GetQueryParamValue("page")
            If page.Length = 0 Then
                funcRst = funcRst & "&page={1}"
            End If

            Return funcRst
        End Function


        Private Async Function SearchInternal(ByVal url As String) As Task(Of String)
            Dim getRst = Await HttpAsync.Instance.TryGetAsync(url, httpHeadersParam, 0)
            If getRst.StatusCode <> Net.HttpStatusCode.OK OrElse
             Not CheckSearchResult(getRst.Message) Then
                For i = 1 To TryTimesIfError
                    Windows2.RandDelay(1000, 2000, TimePrecision.Millisecond)
                    getRst = Await HttpAsync.Instance.TryGetAsync(url, httpHeadersParam, 0)
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

        ''' <summary>
        ''' H5搜索
        ''' </summary>
        ''' <param name="keyword">关键词</param>
        ''' <param name="saleSort">按照销量排序</param>
        ''' <param name="page">页数</param>
        ''' <returns></returns>
        Public Async Function SearchAsync(ByVal keyword As String, ByVal saleSort As Boolean, ByVal page As Integer) As Task(Of Root)
            If m_BaseUrlTemplete Is Nothing Then
                Throw New H5SearcherBaseUnInitializeException(String.Format(My.Resources.NullReference, NameOf(m_BaseUrlTemplete)))
            End If

            Dim searchUrl = String.Format(m_BaseUrlTemplete, keyword, page)
            If saleSort Then
                searchUrl = searchUrl & "&style=list&closeModues=nav%2Cselecthot%2Conesearch&sort=_sale"
            End If

            Dim json = Await SearchInternal(searchUrl)
            If json.IsNullOrEmpty Then Return Nothing

            Dim root As Root
            Try
                root = m_JsSerializer.Deserialize(Of Root)(json)
            Catch ex As ArgumentNullException
                Logger.WriteLine( $"{ex.Message}   Keyword:{keyword}   SaleSort:{saleSort} Page:{page.ToStringOfCulture}")
            Catch ex As ArgumentException
                Logger.WriteLine( $"{ex.Message}   Keyword:{keyword}   SaleSort:{saleSort} Page:{page.ToStringOfCulture}")
            Catch ex As InvalidOperationException
                Logger.WriteLine( $"{ex.Message}   Keyword:{keyword}   SaleSort:{saleSort} Page:{page.ToStringOfCulture}")
            Catch ex As Exception
                Logger.WriteLine(ex, $"Keyword:{keyword}  SaleSort:{saleSort}  Page:{page.ToStringOfCulture}",,,)
            End Try

#Disable Warning bc42104
            Return root
#Enable Warning bc42104
        End Function

#End Region


    End Class

End Namespace
