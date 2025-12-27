Imports System.Net

Namespace ShanXingTech.Alibaba
#Disable Warning BC40031 ' 名称不符合 CLS
    Public Class H5Shop
        Inherits H5Client
#Region "枚举区"
        Enum SearchSort

            ''' <summary>
            ''' 综合
            ''' </summary>
            _coefp

            ''' <summary>
            ''' 新品
            ''' </summary>
            first_new
            ''' <summary>
            ''' 销量
            ''' </summary>
            _sale
            ''' <summary>
            ''' 价格低到高
            ''' </summary>
            bid
            ''' <summary>
            ''' 价格高到低
            ''' </summary>
            _bid
        End Enum
#End Region

#Region "字段区"


#End Region
#Region "常量区"
        Private Const m_UA As String = "Mozilla/5.0 (iPhone; CPU iPhone OS 9_1 like Mac OS X) AppleWebKit/601.1.46 (KHTML, like Gecko) Version/9.0 Mobile/13B143 Safari/601.1"
#End Region

#Region "属性 区"
        'Private m_ShopId As String
        'Public Property ShopId As String
        '    Get
        '        Return m_ShopId
        '    End Get
        '    Set
        '        m_ShopId = Value
        '    End Set
        'End Property

        'Private m_SellerId As String
        'Public Property SellerId As String
        '    Get
        '        Return m_SellerId
        '    End Get
        '    Set
        '        m_SellerId = Value
        '    End Set
        'End Property
#End Region

#Region "构造函数 区"
        ''' <summary>
        ''' 类构造函数
        ''' 类之内的任意一个静态方法第一次调用时调用此构造函数
        ''' 而且程序生命周期内仅调用一次
        ''' </summary>
        Shared Sub New()
            '
        End Sub

        ''' <summary>
        ''' 构造函数
        ''' </summary>
        ''' <param name="cookies">可以是PC端登录成功后的cookies，如果没有操作淘宝 H5 端的cookies，那么工具会自动获取</param>
        Public Sub New(ByVal cookies As CookieContainer)
            MyBase.New(cookies, m_UA)
        End Sub

#End Region

#Region "函数区"
        ''' <summary>
        ''' H5端所有宝贝页（店内搜索）
        ''' </summary>
        ''' <param name="page"></param>
        ''' <param name="keyword">要搜索的关键词，如果不需要传入关键词可以为 <see langword="Nothing"/> 或者 <see cref="String.Empty"/></param>
        ''' ''' <param name="shopId"></param>
        ''' <param name="sort">排序方式</param>
        ''' <param name="sellerId"></param>
        ''' <returns></returns>
        Public Async Function NavigateSearchPageInShopAsync(ByVal page As Integer, ByVal keyword As String, ByVal sort As SearchSort, ByVal shopId As String, ByVal sellerId As String) As Task(Of (Success As Boolean, Message As String))
            Dim data As New Dictionary(Of String, String) From {
                {"m", "shopitemsearch"},
                {"vm", "nw"},
                {"sversion", "4.6"},
                {"shopId", shopId},
                {"sellerId", sellerId},
                {"style", "wf"},
                {"page", page.ToStringOfCulture},
                {"sort", sort.ToString},
                {"q", If(keyword, String.Empty)},
                {"catmap", ""},
                {"wirelessShopCategoryList", ""}
            }
            Dim dataSerialization = data.Serialize
            Dim signInfo = Await GetSignAsync(dataSerialization)
            Dim url = $"https://h5api.m.taobao.com/h5/mtop.taobao.wsearch.appsearch/1.0/?jsv=2.4.2&appKey={AppKey}&t={signInfo.TimeStamp}&sign={signInfo.Sign}&api=mtop.taobao.wsearch.appSearch&v=1.0&H5Request=true&AntiCreep=true&type=jsonp&timeout=3000&dataType=jsonp&data={dataSerialization}"

            Dim referer = $"https://market.m.taobao.com/app/tb-source-app/shop-auction/pages/auction?from=category&sellerId={sellerId}&shopId={shopId}&spm=a2141.7631565.index_product_all_18787639852.0"
            Dim getRst = Await DoGetAsync(url, referer)

            'Dim httpHeaders As New Dictionary(Of String, String) From {
            '    {"User-Agent", "Mozilla/5.0 (Linux; Android 5.0; SM-G900P Build/LRX21T) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.79 Mobile Safari/537.36"},
            '    {"accept", "*/*"},
            '    {"accept-language", "zh-CN,zh;q=0.9,en;q=0.8,en-GB;q=0.7,en-US;q=0.6"},
            '    {"sec-fetch-mode", "no-cors"},
            '    {"sec-fetch-site", "same-site"},
            '    {"Cache-Control", "no-cache"},
            '    {"Accept-Encoding", "gzip, deflate"},
            '    {"Referer", referer}
            '}
            'Dim ccc = Await HttpAsync.Instance.TryGetAsync(url, httpHeaders, 1)
            Return (getRst.Success, getRst.Message)
        End Function

        ''' <summary>
        ''' 浏览H5端 按日期分组排序新品页(非店内搜索按新品排序)
        ''' </summary>
        ''' <param name="page"></param>
        ''' <param name="preItemId">上一页最后一个商品的ItemId</param>
        ''' <param name="prePublishTime">上一页最后一个商品的Timestamp</param>
        ''' <returns></returns>
        Public Async Function NavigateNewArrivalPageAsync(ByVal page As Integer, ByVal preItemId As String, ByVal prePublishTime As Date, ByVal shopId As String, ByVal sellerId As String) As Task(Of (Success As Boolean, Message As String))
            Dim data As New H5NewArrivalData With {
                .direction = 1,
                .userId = sellerId,
                .pageSize = 10,
                .needPreNew = True,
                .id = preItemId,
                .curPage = page
            }
            If page > 1 Then
                data.timestamp = prePublishTime.ToTimeStampString(TimePrecision.Millisecond)
            End If

            Dim dataSerialization = data.Serialize
            Dim signInfo = Await GetSignAsync(dataSerialization)
            Dim url = $"https://h5api.m.taobao.com/h5/mtop.shop.newarrival.list.get/1.1/?jsv=2.4.5&appKey={AppKey}&t={signInfo.TimeStamp}&sign={signInfo.Sign}&api=mtop.shop.newarrival.list.get&v=1.1&type=jsonp&H5Request=true&preventFallback=true&dataType=jsonp&data={dataSerialization}"

            Dim referer = $"https://market.m.taobao.com/apps/market/shop/newarrival.html?userId={sellerId}&_w&shopId={shopId}&sellerId={sellerId}&shop_navi=newitems&displayShopHeader=true"
            Dim getRst = Await DoGetAsync(url, referer)
            Return (getRst.Success, getRst.Message)
        End Function

        ''' <summary>
        ''' 浏览H5端 商品（某商品）页
        ''' </summary>
        ''' <param name="itemId">商品的ItemId</param>
        ''' <returns></returns>
        Public Async Function NavigateProductAsync(ByVal itemId As String) As Task(Of (Success As Boolean, Message As String))
            Dim spm = "a2141.7631671.content.6"
            Dim exParams = New H5ProductPage.exParamsCl With {
                .id = itemId,
                .spm = spm
            }
            Dim data As New H5ProductPage With {
                .id = itemId,
                .spm = spm,
                .itemNumId = itemId,
                .itemId = itemId,
                .exParams = exParams.Serialize,
                .detail_v = "8.0.0",
                .utdid = "1"
            }

            Dim dataSerialization = data.Serialize
            Dim signInfo = Await GetSignAsync(dataSerialization)
            ' 必须得把data编码为大写的形式，否则会返回 FAIL_SYS_TRAFFIC_LIMIT::哎哟喂,被挤爆啦,请稍后重试!
            ' 经过反复测试，itemId%22%3A%22 这里的 3a 必须为 3A,否则就会出现上述错误，其他地方无所谓
            Dim url = $"https://h5api.m.taobao.com/h5/mtop.taobao.detail.getdetail/6.0/?jsv=2.5.6&appKey={AppKey}&t={signInfo.TimeStamp}&sign={signInfo.Sign}&api=mtop.taobao.detail.getdetail&v=6.0&isSec=0&ecode=0&AntiFlood=true&AntiCreep=true&H5Request=true&ttid=2018%40taobao_h5_9.9.9&type=jsonp&dataType=jsonp&data={dataSerialization.UrlEncode(UpperLowerCase.Upper)}"

            Dim referer = $"https://h5.m.taobao.com/awp/core/detail.htm?id={itemId}&spm={spm}"
            Dim getRst = Await DoGetAsync(url, referer)
            Return (getRst.Success, getRst.Message)
        End Function

        ''' <summary>
        ''' 获取店铺印象——介绍（掌柜名、服务电话、所在地、资质、开店时间等）,有反爬限制
        ''' </summary>
        ''' <param name="shopId"></param>
        ''' <param name="sellerId"></param>
        ''' <returns></returns>
        Public Async Function GetImpressionIntroAsync(ByVal shopId As String, ByVal sellerId As String) As Task(Of (Success As Boolean, Message As String))
            Dim data As New With {
                sellerId,
                shopId
            }

            Dim dataSerialization = data.Serialize
            Dim signInfo = Await GetSignAsync(dataSerialization)
            Dim url = $"https://h5api.m.taobao.com/h5/mtop.taobao.shop.impression.intro.get/1.0/?jsv=2.4.2&appKey={AppKey}&t={signInfo.TimeStamp}&sign={signInfo.Sign}&api=mtop.taobao.shop.impression.intro.get&v=1.0&type=originaljson&secType=1&timeout=3000&AntiCreep=true&dataType=json&data={dataSerialization.UrlEncode(UpperLowerCase.Upper)}"

            Dim referer = $"https://market.m.taobao.com/app/tb-source-app/wz111/pages/impression?pathInfo=shop/impression&userId={sellerId}&shopId={shopId}&wh_weex=true&pageId=0&alisite=true"
            Dim getRst = Await DoGetAsync(url, referer)
            Return (getRst.Success, getRst.Message)
        End Function
#End Region
    End Class
#Enable Warning BC40031 ' 名称不符合 CLS
End Namespace

