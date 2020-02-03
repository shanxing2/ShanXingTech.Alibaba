'【注意:默认的default 改名为default2 了】

Imports ShanXingTech.Alibaba.PCBaoeiSearchResultEntities.PCBaoeiSearchResultEntity


Namespace ShanXingTech.Alibaba.PCBaoeiSearchResultEntities

    Namespace ItemlistData
        Public Class Data
            ''' <summary>
            ''' 运费
            ''' </summary>
            Public Property PostFeeText() As String
                Get
                    Return m_postFeeText
                End Get
                Set
                    m_postFeeText = Value
                End Set
            End Property
            Private m_postFeeText As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Trace() As String
                Get
                    Return m_trace
                End Get
                Set
                    m_trace = Value
                End Set
            End Property
            Private m_trace As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Auctions() As List(Of AuctionsItem)
                Get
                    Return m_auctions
                End Get
                Set
                    m_auctions = Value
                End Set
            End Property
            Private m_auctions As List(Of AuctionsItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property RecommendAuctions() As List(Of String)
                Get
                    Return m_recommendAuctions
                End Get
                Set
                    m_recommendAuctions = Value
                End Set
            End Property
            Private m_recommendAuctions As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsSameStyleView() As String
                Get
                    Return m_isSameStyleView
                End Get
                Set
                    m_isSameStyleView = Value
                End Set
            End Property
            Private m_isSameStyleView As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Sellers() As List(Of String)
                Get
                    Return m_sellers
                End Get
                Set
                    m_sellers = Value
                End Set
            End Property
            Private m_sellers As List(Of String)

            ''' <summary>
            ''' 冰丝袖套
            ''' </summary>
            Public Property Query() As String
                Get
                    Return m_query
                End Get
                Set
                    m_query = Value
                End Set
            End Property
            Private m_query As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property SpmModId() As String
                Get
                    Return m_spmModId
                End Get
                Set
                    m_spmModId = Value
                End Set
            End Property
            Private m_spmModId As String

            ''' <summary>
            ''' Customizedconfig
            ''' </summary>
            Public Property CustomizedConfig() As CustomizedConfig
                Get
                    Return m_CustomizedConfig
                End Get
                Set
                    m_CustomizedConfig = Value
                End Set
            End Property
            Private m_CustomizedConfig As CustomizedConfig
        End Class

    End Namespace

    Namespace BottomsearchData
        Public Class Data
            ''' <summary>
            ''' 冰丝袖套
            ''' </summary>
            Public Property Query() As String
                Get
                    Return m_query
                End Get
                Set
                    m_query = Value
                End Set
            End Property
            Private m_query As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ShowSearchBox() As String
                Get
                    Return m_showSearchBox
                End Get
                Set
                    m_showSearchBox = Value
                End Set
            End Property
            Private m_showSearchBox As String

        End Class
    End Namespace

    Namespace NavtabtagsData
        Public Class Data
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Tags() As List(Of TagsItem)
                Get
                    Return m_tags
                End Get
                Set
                    m_tags = Value
                End Set
            End Property
            Private m_tags As List(Of TagsItem)

        End Class

    End Namespace

    Namespace FeedbackData
        Public Class Data
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Render() As String
                Get
                    Return m_render
                End Get
                Set
                    m_render = Value
                End Set
            End Property
            Private m_render As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property UseOld() As String
                Get
                    Return m_useOld
                End Get
                Set
                    m_useOld = Value
                End Set
            End Property
            Private m_useOld As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ShowType() As String
                Get
                    Return m_showType
                End Get
                Set
                    m_showType = Value
                End Set
            End Property
            Private m_showType As String
        End Class
    End Namespace

    Namespace RelatedData
        Public Class Data
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Words() As List(Of WordsItem)
                Get
                    Return m_words
                End Get
                Set
                    m_words = Value
                End Set
            End Property
            Private m_words As List(Of WordsItem)

        End Class
    End Namespace

    Namespace TabData
        Public Class Data
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Tabs() As List(Of TabsItem)
                Get
                    Return m_tabs
                End Get
                Set
                    m_tabs = Value
                End Set
            End Property
            Private m_tabs As List(Of TabsItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property SpmModId() As String
                Get
                    Return m_spmModId
                End Get
                Set
                    m_spmModId = Value
                End Set
            End Property
            Private m_spmModId As String

        End Class
    End Namespace

    Namespace PagerData
        Public Class Data
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property PageSize() As Integer
                Get
                    Return m_pageSize
                End Get
                Set
                    m_pageSize = Value
                End Set
            End Property
            Private m_pageSize As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TotalPage() As Integer
                Get
                    Return m_totalPage
                End Get
                Set
                    m_totalPage = Value
                End Set
            End Property
            Private m_totalPage As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property CurrentPage() As Integer
                Get
                    Return m_currentPage
                End Get
                Set
                    m_currentPage = Value
                End Set
            End Property
            Private m_currentPage As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TotalCount() As Integer
                Get
                    Return m_totalCount
                End Get
                Set
                    m_totalCount = Value
                End Set
            End Property
            Private m_totalCount As Integer

        End Class

    End Namespace

    Namespace NavData
        Public Class Data
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Common() As List(Of CommonItem)
                Get
                    Return m_common
                End Get
                Set
                    m_common = Value
                End Set
            End Property
            Private m_common As List(Of CommonItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Adv() As List(Of AdvItem)
                Get
                    Return m_adv
                End Get
                Set
                    m_adv = Value
                End Set
            End Property
            Private m_adv As List(Of AdvItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Breadcrumbs() As Breadcrumbs
                Get
                    Return m_breadcrumbs
                End Get
                Set
                    m_breadcrumbs = Value
                End Set
            End Property
            Private m_breadcrumbs As Breadcrumbs

        End Class

    End Namespace

    Namespace SortbarData
        Public Class Data
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property SortList() As List(Of SortListItem)
                Get
                    Return m_sortList
                End Get
                Set
                    m_sortList = Value
                End Set
            End Property
            Private m_sortList As List(Of SortListItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Pager() As SortbarDataPager.Pager
                Get
                    Return m_pager
                End Get
                Set
                    m_pager = Value
                End Set
            End Property
            Private m_pager As SortbarDataPager.Pager

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Price() As Price
                Get
                    Return m_price
                End Get
                Set
                    m_price = Value
                End Set
            End Property
            Private m_price As Price

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Filter() As List(Of FilterItem)
                Get
                    Return m_filter
                End Get
                Set
                    m_filter = Value
                End Set
            End Property
            Private m_filter As List(Of FilterItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Location() As Location
                Get
                    Return m_location
                End Get
                Set
                    m_location = Value
                End Set
            End Property
            Private m_location As Location

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Style() As String
                Get
                    Return m_style
                End Get
                Set
                    m_style = Value
                End Set
            End Property
            Private m_style As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property SameSeller() As SameSeller
                Get
                    Return m_sameSeller
                End Get
                Set
                    m_sameSeller = Value
                End Set
            End Property
            Private m_sameSeller As SameSeller

        End Class

    End Namespace

    Namespace PersonalbarData
        Public Class Data
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property MetisData() As MetisData
                Get
                    Return m_metisData
                End Get
                Set
                    m_metisData = Value
                End Set
            End Property
            Private m_metisData As MetisData

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property SortList() As List(Of String)
                Get
                    Return m_sortList
                End Get
                Set
                    m_sortList = Value
                End Set
            End Property
            Private m_sortList As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Tpl() As String
                Get
                    Return m_tpl
                End Get
                Set
                    m_tpl = Value
                End Set
            End Property
            Private m_tpl As String

        End Class

    End Namespace

    Namespace P4pData
        Public Class Data
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property BaobeiExtraClass() As String
                Get
                    Return m_baobeiExtraClass
                End Get
                Set
                    m_baobeiExtraClass = Value
                End Set
            End Property
            Private m_baobeiExtraClass As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property EtaoAds() As String
                Get
                    Return m_etaoAds
                End Get
                Set
                    m_etaoAds = Value
                End Set
            End Property
            Private m_etaoAds As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property P4pconfig() As P4pconfig
                Get
                    Return m_p4pconfig
                End Get
                Set
                    m_p4pconfig = Value
                End Set
            End Property
            Private m_p4pconfig As P4pconfig

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property P4pdata() As String
                Get
                    Return m_p4pdata
                End Get
                Set
                    m_p4pdata = Value
                End Set
            End Property
            Private m_p4pdata As String

        End Class

    End Namespace

    Namespace HeaderData
        Public Class Data
            ''' <summary>
            ''' 冰丝袖套
            ''' </summary>
            Public Property Q() As String
                Get
                    Return m_q
                End Get
                Set
                    m_q = Value
                End Set
            End Property
            Private m_q As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TabParams() As TabParams
                Get
                    Return m_tabParams
                End Get
                Set
                    m_tabParams = Value
                End Set
            End Property
            Private m_tabParams As TabParams

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Dropdown() As List(Of DropdownItem)
                Get
                    Return m_dropdown
                End Get
                Set
                    m_dropdown = Value
                End Set
            End Property
            Private m_dropdown As List(Of DropdownItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ImgBtn() As String
                Get
                    Return m_imgBtn
                End Get
                Set
                    m_imgBtn = Value
                End Set
            End Property
            Private m_imgBtn As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property UploadUrl() As String
                Get
                    Return m_uploadUrl
                End Get
                Set
                    m_uploadUrl = Value
                End Set
            End Property
            Private m_uploadUrl As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Hb() As String
                Get
                    Return m_hb
                End Get
                Set
                    m_hb = Value
                End Set
            End Property
            Private m_hb As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Hb_v() As String
                Get
                    Return m_hb_v
                End Get
                Set
                    m_hb_v = Value
                End Set
            End Property
            Private m_hb_v As String

        End Class

    End Namespace

    Namespace NavtablinkData
        Public Class Data
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Df() As Df
                Get
                    Return m_df
                End Get
                Set
                    m_df = Value
                End Set
            End Property
            Private m_df As Df

        End Class


    End Namespace

    Namespace SortbarDataPager
        Public Class Pager
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property PageSize() As Integer
                Get
                    Return m_pageSize
                End Get
                Set
                    m_pageSize = Value
                End Set
            End Property
            Private m_pageSize As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TotalPage() As Integer
                Get
                    Return m_totalPage
                End Get
                Set
                    m_totalPage = Value
                End Set
            End Property
            Private m_totalPage As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property CurrentPage() As Integer
                Get
                    Return m_currentPage
                End Get
                Set
                    m_currentPage = Value
                End Set
            End Property
            Private m_currentPage As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TotalCount() As Integer
                Get
                    Return m_totalCount
                End Get
                Set
                    m_totalCount = Value
                End Set
            End Property
            Private m_totalCount As Integer

        End Class
    End Namespace


    Namespace ClickTraceData
        Public Class TraceData
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Click() As String
                Get
                    Return m_click
                End Get
                Set
                    m_click = Value
                End Set
            End Property
            Private m_click As String

        End Class

    End Namespace


    Namespace TraceInfoTraceData
        Public Class TraceData
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Catdirect() As String
                Get
                    Return m_catdirect
                End Get
                Set
                    m_catdirect = Value
                End Set
            End Property
            Private m_catdirect As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Remoteip() As String
                Get
                    Return m_remoteip
                End Get
                Set
                    m_remoteip = Value
                End Set
            End Property
            Private m_remoteip As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property RewriteStatus() As String
                Get
                    Return m_rewriteStatus
                End Get
                Set
                    m_rewriteStatus = Value
                End Set
            End Property
            Private m_rewriteStatus As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TabType() As String
                Get
                    Return m_tabType
                End Get
                Set
                    m_tabType = Value
                End Set
            End Property
            Private m_tabType As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Is_rs() As String
                Get
                    Return m_is_rs
                End Get
                Set
                    m_is_rs = Value
                End Set
            End Property
            Private m_is_rs As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Catpredict_bury() As String
                Get
                    Return m_catpredict_bury
                End Get
                Set
                    m_catpredict_bury = Value
                End Set
            End Property
            Private m_catpredict_bury As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Hostname() As String
                Get
                    Return m_hostname
                End Get
                Set
                    m_hostname = Value
                End Set
            End Property
            Private m_hostname As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ActivityClick() As List(Of String)
                Get
                    Return m_activityClick
                End Get
                Set
                    m_activityClick = Value
                End Set
            End Property
            Private m_activityClick As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property LastAlitrackid() As String
                Get
                    Return m_lastAlitrackid
                End Get
                Set
                    m_lastAlitrackid = Value
                End Set
            End Property
            Private m_lastAlitrackid As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property At_lflog() As String
                Get
                    Return m_at_lflog
                End Get
                Set
                    m_at_lflog = Value
                End Set
            End Property
            Private m_at_lflog As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property List_model() As String
                Get
                    Return m_list_model
                End Get
                Set
                    m_list_model = Value
                End Set
            End Property
            Private m_list_model As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Page_size() As String
                Get
                    Return m_page_size
                End Get
                Set
                    m_page_size = Value
                End Set
            End Property
            Private m_page_size As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property RsPositions() As List(Of String)
                Get
                    Return m_rsPositions
                End Get
                Set
                    m_rsPositions = Value
                End Set
            End Property
            Private m_rsPositions As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property If_tank() As String
                Get
                    Return m_if_tank
                End Get
                Set
                    m_if_tank = Value
                End Set
            End Property
            Private m_if_tank As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Rsshop() As String
                Get
                    Return m_rsshop
                End Get
                Set
                    m_rsshop = Value
                End Set
            End Property
            Private m_rsshop As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Alitrackid() As String
                Get
                    Return m_alitrackid
                End Get
                Set
                    m_alitrackid = Value
                End Set
            End Property
            Private m_alitrackid As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Query() As String
                Get
                    Return m_query
                End Get
                Set
                    m_query = Value
                End Set
            End Property
            Private m_query As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Price_rank() As String
                Get
                    Return m_price_rank
                End Get
                Set
                    m_price_rank = Value
                End Set
            End Property
            Private m_price_rank As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Sort() As String
                Get
                    Return m_sort
                End Get
                Set
                    m_sort = Value
                End Set
            End Property
            Private m_sort As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property CatLevelOne() As String
                Get
                    Return m_catLevelOne
                End Get
                Set
                    m_catLevelOne = Value
                End Set
            End Property
            Private m_catLevelOne As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property AuctionNids() As List(Of String)
                Get
                    Return m_auctionNids
                End Get
                Set
                    m_auctionNids = Value
                End Set
            End Property
            Private m_auctionNids As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IfDoufuAuction() As List(Of String)
                Get
                    Return m_ifDoufuAuction
                End Get
                Set
                    m_ifDoufuAuction = Value
                End Set
            End Property
            Private m_ifDoufuAuction As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property AllOldBiz30Day() As List(Of String)
                Get
                    Return m_allOldBiz30Day
                End Get
                Set
                    m_allOldBiz30Day = Value
                End Set
            End Property
            Private m_allOldBiz30Day As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property At_host() As String
                Get
                    Return m_at_host
                End Get
                Set
                    m_at_host = Value
                End Set
            End Property
            Private m_at_host As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Querytype_bury() As String
                Get
                    Return m_querytype_bury
                End Get
                Set
                    m_querytype_bury = Value
                End Set
            End Property
            Private m_querytype_bury As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TdTags() As String
                Get
                    Return m_tdTags
                End Get
                Set
                    m_tdTags = Value
                End Set
            End Property
            Private m_tdTags As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property RelateHotTrace() As List(Of String)
                Get
                    Return m_relateHotTrace
                End Get
                Set
                    m_relateHotTrace = Value
                End Set
            End Property
            Private m_relateHotTrace As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TotalHits() As String
                Get
                    Return m_totalHits
                End Get
                Set
                    m_totalHits = Value
                End Set
            End Property
            Private m_totalHits As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property AllCategories() As List(Of String)
                Get
                    Return m_allCategories
                End Get
                Set
                    m_allCategories = Value
                End Set
            End Property
            Private m_allCategories As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property AuctionIconServices() As List(Of String)
                Get
                    Return m_auctionIconServices
                End Get
                Set
                    m_auctionIconServices = Value
                End Set
            End Property
            Private m_auctionIconServices As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property RewriteQuery() As String
                Get
                    Return m_rewriteQuery
                End Get
                Set
                    m_rewriteQuery = Value
                End Set
            End Property
            Private m_rewriteQuery As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property NavPopup() As String
                Get
                    Return m_navPopup
                End Get
                Set
                    m_navPopup = Value
                End Set
            End Property
            Private m_navPopup As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Rn() As String
                Get
                    Return m_rn
                End Get
                Set
                    m_rn = Value
                End Set
            End Property
            Private m_rn As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Isp4p() As List(Of String)
                Get
                    Return m_isp4p
                End Get
                Set
                    m_isp4p = Value
                End Set
            End Property
            Private m_isp4p As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Rs() As String
                Get
                    Return m_rs
                End Get
                Set
                    m_rs = Value
                End Set
            End Property
            Private m_rs As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property NavCategory() As String
                Get
                    Return m_navCategory
                End Get
                Set
                    m_navCategory = Value
                End Set
            End Property
            Private m_navCategory As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Colo() As String
                Get
                    Return m_colo
                End Get
                Set
                    m_colo = Value
                End Set
            End Property
            Private m_colo As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property AllPrices() As List(Of String)
                Get
                    Return m_allPrices
                End Get
                Set
                    m_allPrices = Value
                End Set
            End Property
            Private m_allPrices As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Show_compass() As String
                Get
                    Return m_show_compass
                End Get
                Set
                    m_show_compass = Value
                End Set
            End Property
            Private m_show_compass As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property AuctionPrices() As List(Of String)
                Get
                    Return m_auctionPrices
                End Get
                Set
                    m_auctionPrices = Value
                End Set
            End Property
            Private m_auctionPrices As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property AuctionReturnNum() As String
                Get
                    Return m_auctionReturnNum
                End Get
                Set
                    m_auctionReturnNum = Value
                End Set
            End Property
            Private m_auctionReturnNum As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Multivariate() As String
                Get
                    Return m_multivariate
                End Get
                Set
                    m_multivariate = Value
                End Set
            End Property
            Private m_multivariate As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property P4pDelTraceInfo() As List(Of String)
                Get
                    Return m_p4pDelTraceInfo
                End Get
                Set
                    m_p4pDelTraceInfo = Value
                End Set
            End Property
            Private m_p4pDelTraceInfo As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property BucketId() As String
                Get
                    Return m_bucketId
                End Get
                Set
                    m_bucketId = Value
                End Set
            End Property
            Private m_bucketId As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Rewrite_bury() As String
                Get
                    Return m_rewrite_bury
                End Get
                Set
                    m_rewrite_bury = Value
                End Set
            End Property
            Private m_rewrite_bury As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property NavEntries() As String
                Get
                    Return m_navEntries
                End Get
                Set
                    m_navEntries = Value
                End Set
            End Property
            Private m_navEntries As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property AllPersonalUpReason() As List(Of String)
                Get
                    Return m_allPersonalUpReason
                End Get
                Set
                    m_allPersonalUpReason = Value
                End Set
            End Property
            Private m_allPersonalUpReason As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Nick() As String
                Get
                    Return m_nick
                End Get
                Set
                    m_nick = Value
                End Set
            End Property
            Private m_nick As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property AllDoufuNids() As List(Of String)
                Get
                    Return m_allDoufuNids
                End Get
                Set
                    m_allDoufuNids = Value
                End Set
            End Property
            Private m_allDoufuNids As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property PriceSorts() As List(Of String)
                Get
                    Return m_priceSorts
                End Get
                Set
                    m_priceSorts = Value
                End Set
            End Property
            Private m_priceSorts As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property At_bucketid() As String
                Get
                    Return m_at_bucketid
                End Get
                Set
                    m_at_bucketid = Value
                End Set
            End Property
            Private m_at_bucketid As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Srppage() As String
                Get
                    Return m_srppage
                End Get
                Set
                    m_srppage = Value
                End Set
            End Property
            Private m_srppage As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property If_rs() As String
                Get
                    Return m_if_rs
                End Get
                Set
                    m_if_rs = Value
                End Set
            End Property
            Private m_if_rs As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property AllNids() As List(Of String)
                Get
                    Return m_allNids
                End Get
                Set
                    m_allNids = Value
                End Set
            End Property
            Private m_allNids As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Cat() As String
                Get
                    Return m_cat
                End Get
                Set
                    m_cat = Value
                End Set
            End Property
            Private m_cat As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Nav_category_type() As String
                Get
                    Return m_nav_category_type
                End Get
                Set
                    m_nav_category_type = Value
                End Set
            End Property
            Private m_nav_category_type As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Sort2() As String
                Get
                    Return m_sort2
                End Get
                Set
                    m_sort2 = Value
                End Set
            End Property
            Private m_sort2 As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Qp_bury() As String
                Get
                    Return m_qp_bury
                End Get
                Set
                    m_qp_bury = Value
                End Set
            End Property
            Private m_qp_bury As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property DoufuAuctionNum() As String
                Get
                    Return m_doufuAuctionNum
                End Get
                Set
                    m_doufuAuctionNum = Value
                End Set
            End Property
            Private m_doufuAuctionNum As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property At_colo() As String
                Get
                    Return m_at_colo
                End Get
                Set
                    m_at_colo = Value
                End Set
            End Property
            Private m_at_colo As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Rs_count() As String
                Get
                    Return m_rs_count
                End Get
                Set
                    m_rs_count = Value
                End Set
            End Property
            Private m_rs_count As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property NavType() As String
                Get
                    Return m_navType
                End Get
                Set
                    m_navType = Value
                End Set
            End Property
            Private m_navType As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Has_sku_pic() As String
                Get
                    Return m_has_sku_pic
                End Get
                Set
                    m_has_sku_pic = Value
                End Set
            End Property
            Private m_has_sku_pic As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property From_pos() As String
                Get
                    Return m_from_pos
                End Get
                Set
                    m_from_pos = Value
                End Set
            End Property
            Private m_from_pos As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property StatsClick() As String
                Get
                    Return m_statsClick
                End Get
                Set
                    m_statsClick = Value
                End Set
            End Property
            Private m_statsClick As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property NavHasRanked() As String
                Get
                    Return m_navHasRanked
                End Get
                Set
                    m_navHasRanked = Value
                End Set
            End Property
            Private m_navHasRanked As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property AllDoufuPrices() As List(Of String)
                Get
                    Return m_allDoufuPrices
                End Get
                Set
                    m_allDoufuPrices = Value
                End Set
            End Property
            Private m_allDoufuPrices As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property RsKeywords() As List(Of String)
                Get
                    Return m_rsKeywords
                End Get
                Set
                    m_rsKeywords = Value
                End Set
            End Property
            Private m_rsKeywords As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TagList() As List(Of String)
                Get
                    Return m_tagList
                End Get
                Set
                    m_tagList = Value
                End Set
            End Property
            Private m_tagList As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property AuctionNicks() As List(Of String)
                Get
                    Return m_auctionNicks
                End Get
                Set
                    m_auctionNicks = Value
                End Set
            End Property
            Private m_auctionNicks As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Sp_seller_types() As List(Of String)
                Get
                    Return m_sp_seller_types
                End Get
                Set
                    m_sp_seller_types = Value
                End Set
            End Property
            Private m_sp_seller_types As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property CatdirectForMaidian() As String
                Get
                    Return m_catdirectForMaidian
                End Get
                Set
                    m_catdirectForMaidian = Value
                End Set
            End Property
            Private m_catdirectForMaidian As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Qinfo() As String
                Get
                    Return m_qinfo
                End Get
                Set
                    m_qinfo = Value
                End Set
            End Property
            Private m_qinfo As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property NoResultCode() As String
                Get
                    Return m_noResultCode
                End Get
                Set
                    m_noResultCode = Value
                End Set
            End Property
            Private m_noResultCode As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Apass() As String
                Get
                    Return m_apass
                End Get
                Set
                    m_apass = Value
                End Set
            End Property
            Private m_apass As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Spu_combo() As String
                Get
                    Return m_spu_combo
                End Get
                Set
                    m_spu_combo = Value
                End Set
            End Property
            Private m_spu_combo As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property AllTags() As List(Of String)
                Get
                    Return m_allTags
                End Get
                Set
                    m_allTags = Value
                End Set
            End Property
            Private m_allTags As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Multi_bucket() As String
                Get
                    Return m_multi_bucket
                End Get
                Set
                    m_multi_bucket = Value
                End Set
            End Property
            Private m_multi_bucket As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property NavStatus() As String
                Get
                    Return m_navStatus
                End Get
                Set
                    m_navStatus = Value
                End Set
            End Property
            Private m_navStatus As String

        End Class
    End Namespace

    Namespace FilteridTraceData
        Public Class TraceData
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Filterid() As String
                Get
                    Return m_filterid
                End Get
                Set
                    m_filterid = Value
                End Set
            End Property
            Private m_filterid As String

        End Class
    End Namespace

    ''' <summary>
    ''' 淘宝宝贝搜索返回结果json实体类
    ''' </summary>
    Public Class PCBaoeiSearchResultEntity

        Public Class Shopcombotip
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Phonenav
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Debugbar
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Shopcombo
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Samestyle
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Url() As String
                Get
                    Return m_url
                End Get
                Set
                    m_url = Value
                End Set
            End Property
            Private m_url As String

        End Class



        Public Class Similar
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Url() As String
                Get
                    Return m_url
                End Get
                Set
                    m_url = Value
                End Set
            End Property
            Private m_url As String

        End Class



        Public Class I2iTags
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Samestyle() As Samestyle
                Get
                    Return m_samestyle
                End Get
                Set
                    m_samestyle = Value
                End Set
            End Property
            Private m_samestyle As Samestyle

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Similar() As Similar
                Get
                    Return m_similar
                End Get
                Set
                    m_similar = Value
                End Set
            End Property
            Private m_similar As Similar

        End Class



        Public Class LevelClassesItem
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property LevelClass() As String
                Get
                    Return m_levelClass
                End Get
                Set
                    m_levelClass = Value
                End Set
            End Property
            Private m_levelClass As String

        End Class



        Public Class Shopcard
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property LevelClasses() As List(Of LevelClassesItem)
                Get
                    Return m_levelClasses
                End Get
                Set
                    m_levelClasses = Value
                End Set
            End Property
            Private m_levelClasses As List(Of LevelClassesItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsTmall() As String
                Get
                    Return m_isTmall
                End Get
                Set
                    m_isTmall = Value
                End Set
            End Property
            Private m_isTmall As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Delivery() As List(Of Integer)
                Get
                    Return m_delivery
                End Get
                Set
                    m_delivery = Value
                End Set
            End Property
            Private m_delivery As List(Of Integer)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Description() As List(Of Integer)
                Get
                    Return m_description
                End Get
                Set
                    m_description = Value
                End Set
            End Property
            Private m_description As List(Of Integer)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Service() As List(Of Integer)
                Get
                    Return m_service
                End Get
                Set
                    m_service = Value
                End Set
            End Property
            Private m_service As List(Of Integer)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property EncryptedUserId() As String
                Get
                    Return m_encryptedUserId
                End Get
                Set
                    m_encryptedUserId = Value
                End Set
            End Property
            Private m_encryptedUserId As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property SellerCredit() As Integer
                Get
                    Return m_sellerCredit
                End Get
                Set
                    m_sellerCredit = Value
                End Set
            End Property
            Private m_sellerCredit As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TotalRate() As Integer
                Get
                    Return m_totalRate
                End Get
                Set
                    m_totalRate = Value
                End Set
            End Property
            Private m_totalRate As Integer

        End Class



        Public Class IconItem
            ''' <summary>
            ''' 尚天猫，就购了
            ''' </summary>
            Public Property Title() As String
                Get
                    Return m_title
                End Get
                Set
                    m_title = Value
                End Set
            End Property
            Private m_title As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Dom_class() As String
                Get
                    Return m_dom_class
                End Get
                Set
                    m_dom_class = Value
                End Set
            End Property
            Private m_dom_class As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Position() As String
                Get
                    Return m_position
                End Get
                Set
                    m_position = Value
                End Set
            End Property
            Private m_position As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Show_type() As String
                Get
                    Return m_show_type
                End Get
                Set
                    m_show_type = Value
                End Set
            End Property
            Private m_show_type As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Icon_category() As String
                Get
                    Return m_icon_category
                End Get
                Set
                    m_icon_category = Value
                End Set
            End Property
            Private m_icon_category As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Outer_text() As String
                Get
                    Return m_outer_text
                End Get
                Set
                    m_outer_text = Value
                End Set
            End Property
            Private m_outer_text As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Html() As String
                Get
                    Return m_html
                End Get
                Set
                    m_html = Value
                End Set
            End Property
            Private m_html As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Icon_key() As String
                Get
                    Return m_icon_key
                End Get
                Set
                    m_icon_key = Value
                End Set
            End Property
            Private m_icon_key As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Trace() As String
                Get
                    Return m_trace
                End Get
                Set
                    m_trace = Value
                End Set
            End Property
            Private m_trace As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TraceIdx() As Integer
                Get
                    Return m_traceIdx
                End Get
                Set
                    m_traceIdx = Value
                End Set
            End Property
            Private m_traceIdx As Integer

            ''' <summary>
            ''' 天猫宝贝
            ''' </summary>
            Public Property InnerText() As String
                Get
                    Return m_innerText
                End Get
                Set
                    m_innerText = Value
                End Set
            End Property
            Private m_innerText As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Url() As String
                Get
                    Return m_url
                End Get
                Set
                    m_url = Value
                End Set
            End Property
            Private m_url As String

        End Class



        Public Class AuctionsItem
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property I2iTags() As I2iTags
                Get
                    Return m_i2iTags
                End Get
                Set
                    m_i2iTags = Value
                End Set
            End Property
            Private m_i2iTags As I2iTags

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property P4pTags() As List(Of String)
                Get
                    Return m_p4pTags
                End Get
                Set
                    m_p4pTags = Value
                End Set
            End Property
            Private m_p4pTags As List(Of String)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Nid() As String
                Get
                    Return m_nid
                End Get
                Set
                    m_nid = Value
                End Set
            End Property
            Private m_nid As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Category() As String
                Get
                    Return m_category
                End Get
                Set
                    m_category = Value
                End Set
            End Property
            Private m_category As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Pid() As String
                Get
                    Return m_pid
                End Get
                Set
                    m_pid = Value
                End Set
            End Property
            Private m_pid As String

            ''' <summary>
            ''' 韩国冰丝防晒袖套军训男女户外 防紫外线开车手套冰袖臂套袖长款
            ''' </summary>
            Public Property Title() As String
                Get
                    Return m_title
                End Get
                Set
                    m_title = Value
                End Set
            End Property
            Private m_title As String

            ''' <summary>
            ''' 韩国冰丝防晒袖套军训男女户外 防紫外线开车手套冰袖臂套袖长款
            ''' </summary>
            Public Property Raw_title() As String
                Get
                    Return m_raw_title
                End Get
                Set
                    m_raw_title = Value
                End Set
            End Property
            Private m_raw_title As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Pic_url() As String
                Get
                    Return m_pic_url
                End Get
                Set
                    m_pic_url = Value
                End Set
            End Property
            Private m_pic_url As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Detail_url() As String
                Get
                    Return m_detail_url
                End Get
                Set
                    m_detail_url = Value
                End Set
            End Property
            Private m_detail_url As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property View_price() As String
                Get
                    Return m_view_price
                End Get
                Set
                    m_view_price = Value
                End Set
            End Property
            Private m_view_price As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property View_fee() As String
                Get
                    Return m_view_fee
                End Get
                Set
                    m_view_fee = Value
                End Set
            End Property
            Private m_view_fee As String

            ''' <summary>
            ''' 江苏 徐州
            ''' </summary>
            Public Property Item_loc() As String
                Get
                    Return m_item_loc
                End Get
                Set
                    m_item_loc = Value
                End Set
            End Property
            Private m_item_loc As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Reserve_price() As String
                Get
                    Return m_reserve_price
                End Get
                Set
                    m_reserve_price = Value
                End Set
            End Property
            Private m_reserve_price As String

            ''' <summary>
            ''' 32320人收货
            ''' </summary>
            Public Property View_sales() As String
                Get
                    Return m_view_sales
                End Get
                Set
                    m_view_sales = Value
                End Set
            End Property
            Private m_view_sales As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Comment_count() As String
                Get
                    Return m_comment_count
                End Get
                Set
                    m_comment_count = Value
                End Set
            End Property
            Private m_comment_count As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property User_id() As String
                Get
                    Return m_user_id
                End Get
                Set
                    m_user_id = Value
                End Set
            End Property
            Private m_user_id As String

            ''' <summary>
            ''' namshou典尚专卖店
            ''' </summary>
            Public Property Nick() As String
                Get
                    Return m_nick
                End Get
                Set
                    m_nick = Value
                End Set
            End Property
            Private m_nick As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Shopcard() As Shopcard
                Get
                    Return m_shopcard
                End Get
                Set
                    m_shopcard = Value
                End Set
            End Property
            Private m_shopcard As Shopcard

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Icon() As List(Of IconItem)
                Get
                    Return m_icon
                End Get
                Set
                    m_icon = Value
                End Set
            End Property
            Private m_icon As List(Of IconItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Comment_url() As String
                Get
                    Return m_comment_url
                End Get
                Set
                    m_comment_url = Value
                End Set
            End Property
            Private m_comment_url As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ShopLink() As String
                Get
                    Return m_shopLink
                End Get
                Set
                    m_shopLink = Value
                End Set
            End Property
            Private m_shopLink As String

        End Class

        Public Class Itemlist
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Data() As ItemlistData.Data
                Get
                    Return m_data
                End Get
                Set
                    m_data = Value
                End Set
            End Property
            Private m_data As ItemlistData.Data

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class

        Public Class CustomizedConfig
            ''' <summary>
            ''' /api?ajax=true&amp;m=customized&amp;rn=383b67c2089a6217435f7badba6e7357&amp;q=%E8%A1%A3%E6%9C%8D&amp;imgfile=&amp;js=1&amp;stats_click=search_radio_all%3A1&amp;initiative_id=staobaoz_20170203&amp;ie=utf8&amp;s=36&amp;bcoffset=-4
            ''' </summary>
            Public Property Url() As String
                Get
                    Return m_url
                End Get
                Set
                    m_url = Value
                End Set
            End Property
            Private m_url As String
            ''' <summary>
            ''' Status
            ''' </summary>
            Public Property Status() As Boolean
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As Boolean
        End Class


        Public Class Bottomsearch
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Data() As BottomsearchData.Data
                Get
                    Return m_data
                End Get
                Set
                    m_data = Value
                End Set
            End Property
            Private m_data As BottomsearchData.Data

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Tips
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class TagsItem
            ''' <summary>
            ''' 夏季
            ''' </summary>
            Public Property Name() As String
                Get
                    Return m_name
                End Get
                Set
                    m_name = Value
                End Set
            End Property
            Private m_name As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Url() As String
                Get
                    Return m_url
                End Get
                Set
                    m_url = Value
                End Set
            End Property
            Private m_url As String

        End Class

        Public Class Navtabtags
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Data() As NavtabtagsData.Data
                Get
                    Return m_data
                End Get
                Set
                    m_data = Value
                End Set
            End Property
            Private m_data As NavtabtagsData.Data

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class

        Public Class Feedback
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Data() As FeedbackData.Data
                Get
                    Return m_data
                End Get
                Set
                    m_data = Value
                End Set
            End Property
            Private m_data As FeedbackData.Data

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Sc
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Spuseries
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class WordsItem
            ''' <summary>
            ''' 防晒袖套
            ''' </summary>
            Public Property Text() As String
                Get
                    Return m_text
                End Get
                Set
                    m_text = Value
                End Set
            End Property
            Private m_text As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsHighlight() As String
                Get
                    Return m_isHighlight
                End Get
                Set
                    m_isHighlight = Value
                End Set
            End Property
            Private m_isHighlight As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Href() As String
                Get
                    Return m_href
                End Get
                Set
                    m_href = Value
                End Set
            End Property
            Private m_href As String

        End Class



        Public Class Related
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Data() As RelatedData.Data
                Get
                    Return m_data
                End Get
                Set
                    m_data = Value
                End Set
            End Property
            Private m_data As RelatedData.Data

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class TabsItem
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Type() As String
                Get
                    Return m_type
                End Get
                Set
                    m_type = Value
                End Set
            End Property
            Private m_type As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Weight() As Integer
                Get
                    Return m_weight
                End Get
                Set
                    m_weight = Value
                End Set
            End Property
            Private m_weight As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Name() As String
                Get
                    Return m_name
                End Get
                Set
                    m_name = Value
                End Set
            End Property
            Private m_name As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Id() As String
                Get
                    Return m_id
                End Get
                Set
                    m_id = Value
                End Set
            End Property
            Private m_id As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Trace() As String
                Get
                    Return m_trace
                End Get
                Set
                    m_trace = Value
                End Set
            End Property
            Private m_trace As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Href() As String
                Get
                    Return m_href
                End Get
                Set
                    m_href = Value
                End Set
            End Property
            Private m_href As String

            ''' <summary>
            ''' 所有宝贝
            ''' </summary>
            Public Property Text() As String
                Get
                    Return m_text
                End Get
                Set
                    m_text = Value
                End Set
            End Property
            Private m_text As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsActive() As String
                Get
                    Return m_isActive
                End Get
                Set
                    m_isActive = Value
                End Set
            End Property
            Private m_isActive As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property SpmId() As String
                Get
                    Return m_spmId
                End Get
                Set
                    m_spmId = Value
                End Set
            End Property
            Private m_spmId As String

        End Class

        Public Class Tab
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Data() As TabData.Data
                Get
                    Return m_data
                End Get
                Set
                    m_data = Value
                End Set
            End Property
            Private m_data As TabData.Data

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class

        Public Class Pager
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Data() As PagerData.Data
                Get
                    Return m_data
                End Get
                Set
                    m_data = Value
                End Set
            End Property
            Private m_data As PagerData.Data

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Apasstips
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Tbcode
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Vbaby
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class

        Public Class SubItem
            ''' <summary>
            ''' 麦版
            ''' </summary>
            Public Property Text() As String
                Get
                    Return m_text
                End Get
                Set
                    m_text = Value
                End Set
            End Property
            Private m_text As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Desc() As String
                Get
                    Return m_desc
                End Get
                Set
                    m_desc = Value
                End Set
            End Property
            Private m_desc As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsExpandShow() As String
                Get
                    Return m_isExpandShow
                End Get
                Set
                    m_isExpandShow = Value
                End Set
            End Property
            Private m_isExpandShow As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Key() As String
                Get
                    Return m_key
                End Get
                Set
                    m_key = Value
                End Set
            End Property
            Private m_key As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Value() As String
                Get
                    Return m_value
                End Get
                Set
                    m_value = Value
                End Set
            End Property
            Private m_value As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Trace() As String
                Get
                    Return m_trace
                End Get
                Set
                    m_trace = Value
                End Set
            End Property
            Private m_trace As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TraceData() As ClickTraceData.TraceData
                Get
                    Return m_traceData
                End Get
                Set
                    m_traceData = Value
                End Set
            End Property
            Private m_traceData As ClickTraceData.TraceData

        End Class



        Public Class CommonItem
            ''' <summary>
            ''' 品牌
            ''' </summary>
            Public Property Text() As String
                Get
                    Return m_text
                End Get
                Set
                    m_text = Value
                End Set
            End Property
            Private m_text As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Type() As String
                Get
                    Return m_type
                End Get
                Set
                    m_type = Value
                End Set
            End Property
            Private m_type As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsMulti() As String
                Get
                    Return m_isMulti
                End Get
                Set
                    m_isMulti = Value
                End Set
            End Property
            Private m_isMulti As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property [Sub]() As List(Of SubItem)
                Get
                    Return m_sub
                End Get
                Set
                    m_sub = Value
                End Set
            End Property
            Private m_sub As List(Of SubItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ForceShowMore() As String
                Get
                    Return m_forceShowMore
                End Get
                Set
                    m_forceShowMore = Value
                End Set
            End Property
            Private m_forceShowMore As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Key() As String
                Get
                    Return m_key
                End Get
                Set
                    m_key = Value
                End Set
            End Property
            Private m_key As String

            ''' <summary>
            ''' 一级类目名称 
            ''' 如果宝贝直接属于一级类目
            ''' 则搜索结果中没有此项
            ''' </summary>
            Public Property Value() As String
                Get
                    Return m_value
                End Get
                Set
                    m_value = Value
                End Set
            End Property
            Private m_value As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Trace() As String
                Get
                    Return m_trace
                End Get
                Set
                    m_trace = Value
                End Set
            End Property
            Private m_trace As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Show2line() As String
                Get
                    Return m_show2line
                End Get
                Set
                    m_show2line = Value
                End Set
            End Property
            Private m_show2line As String

        End Class

        Public Class AdvItem
            ''' <summary>
            ''' 选购热点
            ''' </summary>
            Public Property Text() As String
                Get
                    Return m_text
                End Get
                Set
                    m_text = Value
                End Set
            End Property
            Private m_text As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Type() As String
                Get
                    Return m_type
                End Get
                Set
                    m_type = Value
                End Set
            End Property
            Private m_type As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsMulti() As String
                Get
                    Return m_isMulti
                End Get
                Set
                    m_isMulti = Value
                End Set
            End Property
            Private m_isMulti As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property [Sub]() As List(Of SubItem)
                Get
                    Return m_sub
                End Get
                Set
                    m_sub = Value
                End Set
            End Property
            Private m_sub As List(Of SubItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ForceShowMore() As String
                Get
                    Return m_forceShowMore
                End Get
                Set
                    m_forceShowMore = Value
                End Set
            End Property
            Private m_forceShowMore As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Trace() As String
                Get
                    Return m_trace
                End Get
                Set
                    m_trace = Value
                End Set
            End Property
            Private m_trace As String

        End Class



        Public Class CatpathItem
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Catid() As String
                Get
                    Return m_catid
                End Get
                Set
                    m_catid = Value
                End Set
            End Property
            Private m_catid As String

            ''' <summary>
            ''' 所有分类
            ''' </summary>
            Public Property Name() As String
                Get
                    Return m_name
                End Get
                Set
                    m_name = Value
                End Set
            End Property
            Private m_name As String

        End Class



        Public Class Breadcrumbs
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Catpath() As List(Of CatpathItem)
                Get
                    Return m_catpath
                End Get
                Set
                    m_catpath = Value
                End Set
            End Property
            Private m_catpath As List(Of CatpathItem)

        End Class

        Public Class Nav
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Data() As NavData.Data
                Get
                    Return m_data
                End Get
                Set
                    m_data = Value
                End Set
            End Property
            Private m_data As NavData.Data

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class SortListItem
            ''' <summary>
            ''' 综合
            ''' </summary>
            Public Property Name() As String
                Get
                    Return m_name
                End Get
                Set
                    m_name = Value
                End Set
            End Property
            Private m_name As String

            ''' <summary>
            ''' 综合排序
            ''' </summary>
            Public Property Tip() As String
                Get
                    Return m_tip
                End Get
                Set
                    m_tip = Value
                End Set
            End Property
            Private m_tip As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Trace() As String
                Get
                    Return m_trace
                End Get
                Set
                    m_trace = Value
                End Set
            End Property
            Private m_trace As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsActive() As String
                Get
                    Return m_isActive
                End Get
                Set
                    m_isActive = Value
                End Set
            End Property
            Private m_isActive As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Value() As String
                Get
                    Return m_value
                End Get
                Set
                    m_value = Value
                End Set
            End Property
            Private m_value As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Key() As String
                Get
                    Return m_key
                End Get
                Set
                    m_key = Value
                End Set
            End Property
            Private m_key As String

        End Class

        Public Class Price
        End Class

        Public Class FilterItem
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsActive() As String
                Get
                    Return m_isActive
                End Get
                Set
                    m_isActive = Value
                End Set
            End Property
            Private m_isActive As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Value() As String
                Get
                    Return m_value
                End Get
                Set
                    m_value = Value
                End Set
            End Property
            Private m_value As String

            ''' <summary>
            ''' 包邮
            ''' </summary>
            Public Property Title() As String
                Get
                    Return m_title
                End Get
                Set
                    m_title = Value
                End Set
            End Property
            Private m_title As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Key() As String
                Get
                    Return m_key
                End Get
                Set
                    m_key = Value
                End Set
            End Property
            Private m_key As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Trace() As String
                Get
                    Return m_trace
                End Get
                Set
                    m_trace = Value
                End Set
            End Property
            Private m_trace As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TraceData() As FilteridTraceData.TraceData
                Get
                    Return m_traceData
                End Get
                Set
                    m_traceData = Value
                End Set
            End Property
            Private m_traceData As FilteridTraceData.TraceData

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsHighlight() As String
                Get
                    Return m_isHighlight
                End Get
                Set
                    m_isHighlight = Value
                End Set
            End Property
            Private m_isHighlight As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Pos() As Integer
                Get
                    Return m_pos
                End Get
                Set
                    m_pos = Value
                End Set
            End Property
            Private m_pos As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Dom_id() As String
                Get
                    Return m_dom_id
                End Get
                Set
                    m_dom_id = Value
                End Set
            End Property
            Private m_dom_id As String

        End Class



        Public Class Location
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Active() As String
                Get
                    Return m_active
                End Get
                Set
                    m_active = Value
                End Set
            End Property
            Private m_active As String

            ''' <summary>
            ''' 深圳
            ''' </summary>
            Public Property GuessLoc() As String
                Get
                    Return m_guessLoc
                End Get
                Set
                    m_guessLoc = Value
                End Set
            End Property
            Private m_guessLoc As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property UsualLoc() As List(Of String)
                Get
                    Return m_usualLoc
                End Get
                Set
                    m_usualLoc = Value
                End Set
            End Property
            Private m_usualLoc As List(Of String)

        End Class



        Public Class SameSeller
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsActive() As String
                Get
                    Return m_isActive
                End Get
                Set
                    m_isActive = Value
                End Set
            End Property
            Private m_isActive As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Key() As String
                Get
                    Return m_key
                End Get
                Set
                    m_key = Value
                End Set
            End Property
            Private m_key As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Value() As String
                Get
                    Return m_value
                End Get
                Set
                    m_value = Value
                End Set
            End Property
            Private m_value As String

        End Class

        Public Class Sortbar
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Data() As SortbarData.Data
                Get
                    Return m_data
                End Get
                Set
                    m_data = Value
                End Set
            End Property
            Private m_data As SortbarData.Data

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class D11filterbar
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class ShopItemsItem
            ''' <summary>
            ''' 黄钻爱买店铺
            ''' </summary>
            Public Property Text() As String
                Get
                    Return m_text
                End Get
                Set
                    m_text = Value
                End Set
            End Property
            Private m_text As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Count() As String
                Get
                    Return m_count
                End Get
                Set
                    m_count = Value
                End Set
            End Property
            Private m_count As String

            ''' <summary>
            ''' /search?q=冰丝袖套&amp;tab=mysearch&amp;filter_rectype=44&amp;stats_click=ms_from:44
            ''' </summary>
            Public Property Url() As String
                Get
                    Return m_url
                End Get
                Set
                    m_url = Value
                End Set
            End Property
            Private m_url As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Trace() As String
                Get
                    Return m_trace
                End Get
                Set
                    m_trace = Value
                End Set
            End Property
            Private m_trace As String

        End Class



        Public Class MetisData
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Nickname() As String
                Get
                    Return m_nickname
                End Get
                Set
                    m_nickname = Value
                End Set
            End Property
            Private m_nickname As String

            ''' <summary>
            ''' 冰丝袖套
            ''' </summary>
            Public Property Query() As String
                Get
                    Return m_query
                End Get
                Set
                    m_query = Value
                End Set
            End Property
            Private m_query As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ShopItems() As List(Of ShopItemsItem)
                Get
                    Return m_shopItems
                End Get
                Set
                    m_shopItems = Value
                End Set
            End Property
            Private m_shopItems As List(Of ShopItemsItem)

        End Class

        Public Class Personalbar
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Data() As PersonalbarData.Data
                Get
                    Return m_data
                End Get
                Set
                    m_data = Value
                End Set
            End Property
            Private m_data As PersonalbarData.Data

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Auction_num
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Search() As Integer
                Get
                    Return m_search
                End Get
                Set
                    m_search = Value
                End Set
            End Property
            Private m_search As Integer

        End Class



        Public Class P4pconfig
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Keyword() As String
                Get
                    Return m_keyword
                End Get
                Set
                    m_keyword = Value
                End Set
            End Property
            Private m_keyword As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property KeywordGBK() As String
                Get
                    Return m_keywordGBK
                End Get
                Set
                    m_keywordGBK = Value
                End Set
            End Property
            Private m_keywordGBK As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Catid() As String
                Get
                    Return m_catid
                End Get
                Set
                    m_catid = Value
                End Set
            End Property
            Private m_catid As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Propertyid() As String
                Get
                    Return m_propertyid
                End Get
                Set
                    m_propertyid = Value
                End Set
            End Property
            Private m_propertyid As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Ip() As String
                Get
                    Return m_ip
                End Get
                Set
                    m_ip = Value
                End Set
            End Property
            Private m_ip As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Loc() As String
                Get
                    Return m_loc
                End Get
                Set
                    m_loc = Value
                End Set
            End Property
            Private m_loc As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Gprice() As String
                Get
                    Return m_gprice
                End Get
                Set
                    m_gprice = Value
                End Set
            End Property
            Private m_gprice As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Sort() As String
                Get
                    Return m_sort
                End Get
                Set
                    m_sort = Value
                End Set
            End Property
            Private m_sort As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Sbid() As String
                Get
                    Return m_sbid
                End Get
                Set
                    m_sbid = Value
                End Set
            End Property
            Private m_sbid As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Q2cused() As Integer
                Get
                    Return m_q2cused
                End Get
                Set
                    m_q2cused = Value
                End Set
            End Property
            Private m_q2cused As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property PageNum() As Integer
                Get
                    Return m_pageNum
                End Get
                Set
                    m_pageNum = Value
                End Set
            End Property
            Private m_pageNum As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property P4pbottom_up() As String
                Get
                    Return m_p4pbottom_up
                End Get
                Set
                    m_p4pbottom_up = Value
                End Set
            End Property
            Private m_p4pbottom_up As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property B2b_show() As String
                Get
                    Return m_b2b_show
                End Get
                Set
                    m_b2b_show = Value
                End Set
            End Property
            Private m_b2b_show As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Etao_wanke() As String
                Get
                    Return m_etao_wanke
                End Get
                Set
                    m_etao_wanke = Value
                End Set
            End Property
            Private m_etao_wanke As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Etao_effect() As String
                Get
                    Return m_etao_effect
                End Get
                Set
                    m_etao_effect = Value
                End Set
            End Property
            Private m_etao_effect As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Offset() As Integer
                Get
                    Return m_offset
                End Get
                Set
                    m_offset = Value
                End Set
            End Property
            Private m_offset As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Refpid() As String
                Get
                    Return m_refpid
                End Get
                Set
                    m_refpid = Value
                End Set
            End Property
            Private m_refpid As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Source() As String
                Get
                    Return m_source
                End Get
                Set
                    m_source = Value
                End Set
            End Property
            Private m_source As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Xmatch() As Integer
                Get
                    Return m_xmatch
                End Get
                Set
                    m_xmatch = Value
                End Set
            End Property
            Private m_xmatch As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Rn() As String
                Get
                    Return m_rn
                End Get
                Set
                    m_rn = Value
                End Set
            End Property
            Private m_rn As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Ismall() As String
                Get
                    Return m_ismall
                End Get
                Set
                    m_ismall = Value
                End Set
            End Property
            Private m_ismall As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Srp() As String
                Get
                    Return m_srp
                End Get
                Set
                    m_srp = Value
                End Set
            End Property
            Private m_srp As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Tags() As String
                Get
                    Return m_tags
                End Get
                Set
                    m_tags = Value
                End Set
            End Property
            Private m_tags As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property P4p_btsinfo() As String
                Get
                    Return m_p4p_btsinfo
                End Get
                Set
                    m_p4p_btsinfo = Value
                End Set
            End Property
            Private m_p4p_btsinfo As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Auction_tag() As String
                Get
                    Return m_auction_tag
                End Get
                Set
                    m_auction_tag = Value
                End Set
            End Property
            Private m_auction_tag As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Has_sku_pic() As String
                Get
                    Return m_has_sku_pic
                End Get
                Set
                    m_has_sku_pic = Value
                End Set
            End Property
            Private m_has_sku_pic As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Firstpage_auction_num() As String
                Get
                    Return m_firstpage_auction_num
                End Get
                Set
                    m_firstpage_auction_num = Value
                End Set
            End Property
            Private m_firstpage_auction_num As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Auction_num() As Auction_num
                Get
                    Return m_auction_num
                End Get
                Set
                    m_auction_num = Value
                End Set
            End Property
            Private m_auction_num As Auction_num

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Time() As String
                Get
                    Return m_time
                End Get
                Set
                    m_time = Value
                End Set
            End Property
            Private m_time As String

        End Class

        Public Class P4p
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Data() As P4pData.Data
                Get
                    Return m_data
                End Get
                Set
                    m_data = Value
                End Set
            End Property
            Private m_data As P4pData.Data

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Choosecar
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Shopstar
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class TabParams
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Js() As String
                Get
                    Return m_js
                End Get
                Set
                    m_js = Value
                End Set
            End Property
            Private m_js As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Stats_click() As String
                Get
                    Return m_stats_click
                End Get
                Set
                    m_stats_click = Value
                End Set
            End Property
            Private m_stats_click As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Initiative_id() As String
                Get
                    Return m_initiative_id
                End Get
                Set
                    m_initiative_id = Value
                End Set
            End Property
            Private m_initiative_id As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Ie() As String
                Get
                    Return m_ie
                End Get
                Set
                    m_ie = Value
                End Set
            End Property
            Private m_ie As String

        End Class



        Public Class DropdownItem
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Url() As String
                Get
                    Return m_url
                End Get
                Set
                    m_url = Value
                End Set
            End Property
            Private m_url As String

            ''' <summary>
            ''' 宝贝
            ''' </summary>
            Public Property Text() As String
                Get
                    Return m_text
                End Get
                Set
                    m_text = Value
                End Set
            End Property
            Private m_text As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Type() As String
                Get
                    Return m_type
                End Get
                Set
                    m_type = Value
                End Set
            End Property
            Private m_type As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsActive() As String
                Get
                    Return m_isActive
                End Get
                Set
                    m_isActive = Value
                End Set
            End Property
            Private m_isActive As String

        End Class

        Public Class Header
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Data() As HeaderData.Data
                Get
                    Return m_data
                End Get
                Set
                    m_data = Value
                End Set
            End Property
            Private m_data As HeaderData.Data

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Spucombo
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Supertab
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Df
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Active() As String
                Get
                    Return m_active
                End Get
                Set
                    m_active = Value
                End Set
            End Property
            Private m_active As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property PbUrl() As String
                Get
                    Return m_pbUrl
                End Get
                Set
                    m_pbUrl = Value
                End Set
            End Property
            Private m_pbUrl As String

        End Class

        Public Class Navtablink
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Data() As NavtablinkData.Data
                Get
                    Return m_data
                End Get
                Set
                    m_data = Value
                End Set
            End Property
            Private m_data As NavtablinkData.Data

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Noresult
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Status() As String
                Get
                    Return m_status
                End Get
                Set
                    m_status = Value
                End Set
            End Property
            Private m_status As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Export() As String
                Get
                    Return m_export
                End Get
                Set
                    m_export = Value
                End Set
            End Property
            Private m_export As String

        End Class



        Public Class Mods
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Shopcombotip() As Shopcombotip
                Get
                    Return m_shopcombotip
                End Get
                Set
                    m_shopcombotip = Value
                End Set
            End Property
            Private m_shopcombotip As Shopcombotip

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Phonenav() As Phonenav
                Get
                    Return m_phonenav
                End Get
                Set
                    m_phonenav = Value
                End Set
            End Property
            Private m_phonenav As Phonenav

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Debugbar() As Debugbar
                Get
                    Return m_debugbar
                End Get
                Set
                    m_debugbar = Value
                End Set
            End Property
            Private m_debugbar As Debugbar

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Shopcombo() As Shopcombo
                Get
                    Return m_shopcombo
                End Get
                Set
                    m_shopcombo = Value
                End Set
            End Property
            Private m_shopcombo As Shopcombo

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Itemlist() As Itemlist
                Get
                    Return m_itemlist
                End Get
                Set
                    m_itemlist = Value
                End Set
            End Property
            Private m_itemlist As Itemlist

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Bottomsearch() As Bottomsearch
                Get
                    Return m_bottomsearch
                End Get
                Set
                    m_bottomsearch = Value
                End Set
            End Property
            Private m_bottomsearch As Bottomsearch

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Tips() As Tips
                Get
                    Return m_tips
                End Get
                Set
                    m_tips = Value
                End Set
            End Property
            Private m_tips As Tips

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Navtabtags() As Navtabtags
                Get
                    Return m_navtabtags
                End Get
                Set
                    m_navtabtags = Value
                End Set
            End Property
            Private m_navtabtags As Navtabtags

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Feedback() As Feedback
                Get
                    Return m_feedback
                End Get
                Set
                    m_feedback = Value
                End Set
            End Property
            Private m_feedback As Feedback

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Sc() As Sc
                Get
                    Return m_sc
                End Get
                Set
                    m_sc = Value
                End Set
            End Property
            Private m_sc As Sc

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Spuseries() As Spuseries
                Get
                    Return m_spuseries
                End Get
                Set
                    m_spuseries = Value
                End Set
            End Property
            Private m_spuseries As Spuseries

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Related() As Related
                Get
                    Return m_related
                End Get
                Set
                    m_related = Value
                End Set
            End Property
            Private m_related As Related

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Tab() As Tab
                Get
                    Return m_tab
                End Get
                Set
                    m_tab = Value
                End Set
            End Property
            Private m_tab As Tab

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Pager() As Pager
                Get
                    Return m_pager
                End Get
                Set
                    m_pager = Value
                End Set
            End Property
            Private m_pager As Pager

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Apasstips() As Apasstips
                Get
                    Return m_apasstips
                End Get
                Set
                    m_apasstips = Value
                End Set
            End Property
            Private m_apasstips As Apasstips

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Tbcode() As Tbcode
                Get
                    Return m_tbcode
                End Get
                Set
                    m_tbcode = Value
                End Set
            End Property
            Private m_tbcode As Tbcode

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Vbaby() As Vbaby
                Get
                    Return m_vbaby
                End Get
                Set
                    m_vbaby = Value
                End Set
            End Property
            Private m_vbaby As Vbaby

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Nav() As Nav
                Get
                    Return m_nav
                End Get
                Set
                    m_nav = Value
                End Set
            End Property
            Private m_nav As Nav

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Sortbar() As Sortbar
                Get
                    Return m_sortbar
                End Get
                Set
                    m_sortbar = Value
                End Set
            End Property
            Private m_sortbar As Sortbar

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property D11filterbar() As D11filterbar
                Get
                    Return m_d11filterbar
                End Get
                Set
                    m_d11filterbar = Value
                End Set
            End Property
            Private m_d11filterbar As D11filterbar

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Personalbar() As Personalbar
                Get
                    Return m_personalbar
                End Get
                Set
                    m_personalbar = Value
                End Set
            End Property
            Private m_personalbar As Personalbar

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property P4p() As P4p
                Get
                    Return m_p4p
                End Get
                Set
                    m_p4p = Value
                End Set
            End Property
            Private m_p4p As P4p

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Choosecar() As Choosecar
                Get
                    Return m_choosecar
                End Get
                Set
                    m_choosecar = Value
                End Set
            End Property
            Private m_choosecar As Choosecar

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Shopstar() As Shopstar
                Get
                    Return m_shopstar
                End Get
                Set
                    m_shopstar = Value
                End Set
            End Property
            Private m_shopstar As Shopstar

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Header() As Header
                Get
                    Return m_header
                End Get
                Set
                    m_header = Value
                End Set
            End Property
            Private m_header As Header

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Spucombo() As Spucombo
                Get
                    Return m_spucombo
                End Get
                Set
                    m_spucombo = Value
                End Set
            End Property
            Private m_spucombo As Spucombo

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Supertab() As Supertab
                Get
                    Return m_supertab
                End Get
                Set
                    m_supertab = Value
                End Set
            End Property
            Private m_supertab As Supertab

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Navtablink() As Navtablink
                Get
                    Return m_navtablink
                End Get
                Set
                    m_navtablink = Value
                End Set
            End Property
            Private m_navtablink As Navtablink

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Noresult() As Noresult
                Get
                    Return m_noresult
                End Get
                Set
                    m_noresult = Value
                End Set
            End Property
            Private m_noresult As Noresult

        End Class



        Public Class ModLinks
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Filter() As String
                Get
                    Return m_filter
                End Get
                Set
                    m_filter = Value
                End Set
            End Property
            Private m_filter As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Default2() As String
                Get
                    Return m_default
                End Get
                Set
                    m_default = Value
                End Set
            End Property
            Private m_default As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Nav() As String
                Get
                    Return m_nav
                End Get
                Set
                    m_nav = Value
                End Set
            End Property
            Private m_nav As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Breadcrumb() As String
                Get
                    Return m_breadcrumb
                End Get
                Set
                    m_breadcrumb = Value
                End Set
            End Property
            Private m_breadcrumb As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Pager() As String
                Get
                    Return m_pager
                End Get
                Set
                    m_pager = Value
                End Set
            End Property
            Private m_pager As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Tab() As String
                Get
                    Return m_tab
                End Get
                Set
                    m_tab = Value
                End Set
            End Property
            Private m_tab As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Sortbar() As String
                Get
                    Return m_sortbar
                End Get
                Set
                    m_sortbar = Value
                End Set
            End Property
            Private m_sortbar As String

        End Class



        Public Class SrpGlobal
            ''' <summary>
            ''' 冰丝袖套
            ''' </summary>
            Public Property Q() As String
                Get
                    Return m_q
                End Get
                Set
                    m_q = Value
                End Set
            End Property
            Private m_q As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Encode_q() As String
                Get
                    Return m_encode_q
                End Get
                Set
                    m_encode_q = Value
                End Set
            End Property
            Private m_encode_q As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Utf8_q() As String
                Get
                    Return m_utf8_q
                End Get
                Set
                    m_utf8_q = Value
                End Set
            End Property
            Private m_utf8_q As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Cat() As String
                Get
                    Return m_cat
                End Get
                Set
                    m_cat = Value
                End Set
            End Property
            Private m_cat As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property CatLevelOne() As String
                Get
                    Return m_catLevelOne
                End Get
                Set
                    m_catLevelOne = Value
                End Set
            End Property
            Private m_catLevelOne As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property S() As Integer
                Get
                    Return m_s
                End Get
                Set
                    m_s = Value
                End Set
            End Property
            Private m_s As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Tnk() As String
                Get
                    Return m_tnk
                End Get
                Set
                    m_tnk = Value
                End Set
            End Property
            Private m_tnk As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Bucketid() As Integer
                Get
                    Return m_bucketid
                End Get
                Set
                    m_bucketid = Value
                End Set
            End Property
            Private m_bucketid As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Multi_bucket() As String
                Get
                    Return m_multi_bucket
                End Get
                Set
                    m_multi_bucket = Value
                End Set
            End Property
            Private m_multi_bucket As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Style() As String
                Get
                    Return m_style
                End Get
                Set
                    m_style = Value
                End Set
            End Property
            Private m_style As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Initiative_id() As String
                Get
                    Return m_initiative_id
                End Get
                Set
                    m_initiative_id = Value
                End Set
            End Property
            Private m_initiative_id As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Machine() As String
                Get
                    Return m_machine
                End Get
                Set
                    m_machine = Value
                End Set
            End Property
            Private m_machine As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Buckets() As String
                Get
                    Return m_buckets
                End Get
                Set
                    m_buckets = Value
                End Set
            End Property
            Private m_buckets As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Sp_url() As String
                Get
                    Return m_sp_url
                End Get
                Set
                    m_sp_url = Value
                End Set
            End Property
            Private m_sp_url As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property SrpName() As String
                Get
                    Return m_srpName
                End Get
                Set
                    m_srpName = Value
                End Set
            End Property
            Private m_srpName As String

        End Class

        Public Class TraceInfo
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property PvStat() As String
                Get
                    Return m_pvStat
                End Get
                Set
                    m_pvStat = Value
                End Set
            End Property
            Private m_pvStat As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TraceData() As TraceInfoTraceData.TraceData
                Get
                    Return m_traceData
                End Get
                Set
                    m_traceData = Value
                End Set
            End Property
            Private m_traceData As TraceInfoTraceData.TraceData

        End Class



        Public Class MainInfo
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property CurrentUrl() As String
                Get
                    Return m_currentUrl
                End Get
                Set
                    m_currentUrl = Value
                End Set
            End Property
            Private m_currentUrl As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ModLinks() As ModLinks
                Get
                    Return m_modLinks
                End Get
                Set
                    m_modLinks = Value
                End Set
            End Property
            Private m_modLinks As ModLinks

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property SrpGlobal() As SrpGlobal
                Get
                    Return m_srpGlobal
                End Get
                Set
                    m_srpGlobal = Value
                End Set
            End Property
            Private m_srpGlobal As SrpGlobal

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TraceInfo() As TraceInfo
                Get
                    Return m_traceInfo
                End Get
                Set
                    m_traceInfo = Value
                End Set
            End Property
            Private m_traceInfo As TraceInfo

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property RemainMods() As List(Of String)
                Get
                    Return m_remainMods
                End Get
                Set
                    m_remainMods = Value
                End Set
            End Property
            Private m_remainMods As List(Of String)

        End Class



        Public Class Feature
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property WebpOff() As String
                Get
                    Return m_webpOff
                End Get
                Set
                    m_webpOff = Value
                End Set
            End Property
            Private m_webpOff As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property RetinaOff() As String
                Get
                    Return m_retinaOff
                End Get
                Set
                    m_retinaOff = Value
                End Set
            End Property
            Private m_retinaOff As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ShopcardOff() As String
                Get
                    Return m_shopcardOff
                End Get
                Set
                    m_shopcardOff = Value
                End Set
            End Property
            Private m_shopcardOff As String

        End Class



        Public Class Map
        End Class



        Public Class Root
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property PageName() As String
                Get
                    Return m_pageName
                End Get
                Set
                    m_pageName = Value
                End Set
            End Property
            Private m_pageName As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Mods() As Mods
                Get
                    Return m_mods
                End Get
                Set
                    m_mods = Value
                End Set
            End Property
            Private m_mods As Mods

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property MainInfo() As MainInfo
                Get
                    Return m_mainInfo
                End Get
                Set
                    m_mainInfo = Value
                End Set
            End Property
            Private m_mainInfo As MainInfo

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Feature() As Feature
                Get
                    Return m_feature
                End Get
                Set
                    m_feature = Value
                End Set
            End Property
            Private m_feature As Feature

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Map() As Map
                Get
                    Return m_map
                End Get
                Set
                    m_map = Value
                End Set
            End Property
            Private m_map As Map

        End Class

    End Class


End Namespace