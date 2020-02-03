
' 闪星网络信息科技 Q2287190283
' 神即道, 道法自然, 如来
Imports ShanXingTech.Alibaba.PCShopSearchResultEntities.PCShopSearchResultEntity

Namespace ShanXingTech.Alibaba.PCShopSearchResultEntities

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

    Namespace P4pData
        Public Class Data
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
            Public Property Frontcatid() As String
                Get
                    Return m_frontcatid
                End Get
                Set
                    m_frontcatid = Value
                End Set
            End Property
            Private m_frontcatid As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Total() As Integer
                Get
                    Return m_total
                End Get
                Set
                    m_total = Value
                End Set
            End Property
            Private m_total As Integer

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

        End Class

    End Namespace

    Namespace ShopListData
        Public Class Data
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ShopItems() As List(Of PCShopSearchResultEntity.ShopItemsItem)
                Get
                    Return m_shopItems
                End Get
                Set
                    m_shopItems = Value
                End Set
            End Property
            Private m_shopItems As List(Of PCShopSearchResultEntity.ShopItemsItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ApiUrl() As String
                Get
                    Return m_apiUrl
                End Get
                Set
                    m_apiUrl = Value
                End Set
            End Property
            Private m_apiUrl As String

            ''' <summary>
            ''' 关键词充值
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

        End Class

    End Namespace

    Namespace TabData
        Public Class Data
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TotalHits() As Integer
                Get
                    Return m_totalHits
                End Get
                Set
                    m_totalHits = Value
                End Set
            End Property
            Private m_totalHits As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsSimilar() As String
                Get
                    Return m_isSimilar
                End Get
                Set
                    m_isSimilar = Value
                End Set
            End Property
            Private m_isSimilar As String

        End Class

    End Namespace

    Namespace HeaderData
        Public Class Data
            ''' <summary>
            ''' 关键词充值
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
            Public Property TabParams() As PCShopSearchResultEntity.TabParams
                Get
                    Return m_tabParams
                End Get
                Set
                    m_tabParams = Value
                End Set
            End Property
            Private m_tabParams As PCShopSearchResultEntity.TabParams

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Dropdown() As List(Of PCShopSearchResultEntity.DropdownItem)
                Get
                    Return m_dropdown
                End Get
                Set
                    m_dropdown = Value
                End Set
            End Property
            Private m_dropdown As List(Of PCShopSearchResultEntity.DropdownItem)

        End Class

    End Namespace

    Namespace SortbarData
        Public Class Data
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property SortList() As List(Of PCShopSearchResultEntity.SortListItem)
                Get
                    Return m_sortList
                End Get
                Set
                    m_sortList = Value
                End Set
            End Property
            Private m_sortList As List(Of PCShopSearchResultEntity.SortListItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ShopType() As ShopType
                Get
                    Return m_shopType
                End Get
                Set
                    m_shopType = Value
                End Set
            End Property
            Private m_shopType As ShopType

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
            Public Property ReleFields() As ReleFields
                Get
                    Return m_releFields
                End Get
                Set
                    m_releFields = Value
                End Set
            End Property
            Private m_releFields As ReleFields

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
            Public Property Filters() As List(Of PCShopSearchResultEntity.FiltersItem)
                Get
                    Return m_filters
                End Get
                Set
                    m_filters = Value
                End Set
            End Property
            Private m_filters As List(Of PCShopSearchResultEntity.FiltersItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Goodrates() As Goodrates
                Get
                    Return m_goodrates
                End Get
                Set
                    m_goodrates = Value
                End Set
            End Property
            Private m_goodrates As Goodrates

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
    Public Class PCShopSearchResultEntity
        ' 私有构造器，防止编译器生成默认的构造器
        Private Sub New()
            '
        End Sub

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



        Public Class Updatebar
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



        Public Class Handpick
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



        Public Class SortListItem
            ''' <summary>
            ''' 默认
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
            ''' 默认排序
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



        Public Class SubTypeItem
            ''' <summary>
            ''' 金冠店
            ''' </summary>
            Public Property Level() As String
                Get
                    Return m_level
                End Get
                Set
                    m_level = Value
                End Set
            End Property
            Private m_level As String

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



        Public Class TypeListItem
            ''' <summary>
            ''' 淘宝店
            ''' </summary>
            Public Property ShopType() As String
                Get
                    Return m_shopType
                End Get
                Set
                    m_shopType = Value
                End Set
            End Property
            Private m_shopType As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property SubType() As List(Of SubTypeItem)
                Get
                    Return m_subType
                End Get
                Set
                    m_subType = Value
                End Set
            End Property
            Private m_subType As List(Of SubTypeItem)

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



        Public Class ShopType
            ''' <summary>
            ''' 店铺类型
            ''' </summary>
            Public Property Show() As String
                Get
                    Return m_show
                End Get
                Set
                    m_show = Value
                End Set
            End Property
            Private m_show As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property TypeList() As List(Of TypeListItem)
                Get
                    Return m_typeList
                End Get
                Set
                    m_typeList = Value
                End Set
            End Property
            Private m_typeList As List(Of TypeListItem)

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



        Public Class ReleFieldItem
            ''' <summary>
            ''' 店铺名称
            ''' </summary>
            Public Property [Type]() As String
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



        Public Class ReleFields
            ''' <summary>
            ''' 指定筛选
            ''' </summary>
            Public Property Show() As String
                Get
                    Return m_show
                End Get
                Set
                    m_show = Value
                End Set
            End Property
            Private m_show As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ReleField() As List(Of ReleFieldItem)
                Get
                    Return m_releField
                End Get
                Set
                    m_releField = Value
                End Set
            End Property
            Private m_releField As List(Of ReleFieldItem)

        End Class



        Public Class FiltersItem
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
            ''' 旺旺在线
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

        End Class



        Public Class GoodrateListItem
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Rate() As String
                Get
                    Return m_rate
                End Get
                Set
                    m_rate = Value
                End Set
            End Property
            Private m_rate As String

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



        Public Class Goodrates
            ''' <summary>
            ''' 好评率
            ''' </summary>
            Public Property Show() As String
                Get
                    Return m_show
                End Get
                Set
                    m_show = Value
                End Set
            End Property
            Private m_show As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property GoodrateList() As List(Of GoodrateListItem)
                Get
                    Return m_goodrateList
                End Get
                Set
                    m_goodrateList = Value
                End Set
            End Property
            Private m_goodrateList As List(Of GoodrateListItem)

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


        Public Class AuctionsInshopItem
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
            Public Property PicUrl() As String
                Get
                    Return m_picUrl
                End Get
                Set
                    m_picUrl = Value
                End Set
            End Property
            Private m_picUrl As String

            ''' <summary>
            ''' 捷.易通第.五代店宝自动充开店软件vip代理供货商城财富版 送豪礼
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
            Public Property Price() As String
                Get
                    Return m_price
                End Get
                Set
                    m_price = Value
                End Set
            End Property
            Private m_price As String

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
            ''' 
            ''' </summary>
            Public Property Uid() As String
                Get
                    Return m_uid
                End Get
                Set
                    m_uid = Value
                End Set
            End Property
            Private m_uid As String

        End Class



        Public Class ShopIcon
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
            Public Property IconClass() As String
                Get
                    Return m_iconClass
                End Get
                Set
                    m_iconClass = Value
                End Set
            End Property
            Private m_iconClass As String

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



        Public Class IconsItem
            ''' <summary>
            ''' 卖家承诺消费者保障服务
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
            Public Property DomClass() As String
                Get
                    Return m_domClass
                End Get
                Set
                    m_domClass = Value
                End Set
            End Property
            Private m_domClass As String

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
            ''' 消费者保障
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

        End Class



        Public Class DsrInfo
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property MgDomClass() As String
                Get
                    Return m_mgDomClass
                End Get
                Set
                    m_mgDomClass = Value
                End Set
            End Property
            Private m_mgDomClass As String

            ''' <summary>
            ''' {"srn":"115607","sgr":"99.93%","ind":"游戏/话费","mas":"4.96","mg":"74.30%","sas":"4.97","sg":"79.14%","cas":"4.98","cg":"82.93%","encryptedUserId":"UMm84MGQuvFg0"}
            ''' </summary>
            Public Property DsrStr() As String
                Get
                    Return m_dsrStr
                End Get
                Set
                    m_dsrStr = Value
                End Set
            End Property
            Private m_dsrStr As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property CgDomClass() As String
                Get
                    Return m_cgDomClass
                End Get
                Set
                    m_cgDomClass = Value
                End Set
            End Property
            Private m_cgDomClass As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property SgDomClass() As String
                Get
                    Return m_sgDomClass
                End Get
                Set
                    m_sgDomClass = Value
                End Set
            End Property
            Private m_sgDomClass As String

        End Class



        Public Class ShopItemsItem
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Uid() As String
                Get
                    Return m_uid
                End Get
                Set
                    m_uid = Value
                End Set
            End Property
            Private m_uid As String

            ''' <summary>
            ''' 充值软件店宝宝全国总销售部
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
            ''' 嗳友商城
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
            ''' 四川 成都
            ''' </summary>
            Public Property Provcity() As String
                Get
                    Return m_provcity
                End Get
                Set
                    m_provcity = Value
                End Set
            End Property
            Private m_provcity As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Totalsold() As Integer
                Get
                    Return m_totalsold
                End Get
                Set
                    m_totalsold = Value
                End Set
            End Property
            Private m_totalsold As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Procnt() As Integer
                Get
                    Return m_procnt
                End Get
                Set
                    m_procnt = Value
                End Set
            End Property
            Private m_procnt As Integer

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property EncodeNick() As String
                Get
                    Return m_encodeNick
                End Get
                Set
                    m_encodeNick = Value
                End Set
            End Property
            Private m_encodeNick As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property GoodratePercent() As String
                Get
                    Return m_goodratePercent
                End Get
                Set
                    m_goodratePercent = Value
                End Set
            End Property
            Private m_goodratePercent As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Dynamic() As String
                Get
                    Return m_dynamic
                End Get
                Set
                    m_dynamic = Value
                End Set
            End Property
            Private m_dynamic As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ShopUrl() As String
                Get
                    Return m_shopUrl
                End Get
                Set
                    m_shopUrl = Value
                End Set
            End Property
            Private m_shopUrl As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property SimilarUrl() As String
                Get
                    Return m_similarUrl
                End Get
                Set
                    m_similarUrl = Value
                End Set
            End Property
            Private m_similarUrl As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property PicUrl() As String
                Get
                    Return m_picUrl
                End Get
                Set
                    m_picUrl = Value
                End Set
            End Property
            Private m_picUrl As String

            ''' <summary>
            ''' 充值软件店宝宝全国总销售部
            ''' </summary>
            Public Property RawTitle() As String
                Get
                    Return m_rawTitle
                End Get
                Set
                    m_rawTitle = Value
                End Set
            End Property
            Private m_rawTitle As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property HasMoreAuctions() As String
                Get
                    Return m_hasMoreAuctions
                End Get
                Set
                    m_hasMoreAuctions = Value
                End Set
            End Property
            Private m_hasMoreAuctions As String

            ''' <summary>
            ''' . 软件 代理 店 自动 捷 商城 供货 版 开店 软 vip 第 加盟 开网店 易通 宝 充 充值 财富 捷易通 实物 宝宝 虚拟 免费 第五代 分销 话费 件 快 货源 支 付 铺货 键 礼 豪 一 代 独家 易赛 系统 代发 值 第5 为 VIP 商 ！ 旗舰版 易 网店 淘宝 平台 商品 买 一件 活动 套 限时 选 推广 装修 第五 高级 、 友 手机 千 嗳 模版 统计 使用 词 官方 优化 供销 分析 教 本 客户 最新 专家 冠 信 抢购 元 网络 店招 宝贝 全套 的 包 店铺 高速 300 女装 豪华 网站 退款 各 卡 】 支付 终身 王者 行业 营销 原价 视频 视 终极 开 加 团购 频 震撼 爆料 旺铺 价值 ： 标题 助手 : 男 快捷 宣传 用 揭秘 关键词 之 黄 盟 第10 数 【 达 无效 捷易通贝 程
            ''' </summary>
            Public Property MainAuction() As String
                Get
                    Return m_mainAuction
                End Get
                Set
                    m_mainAuction = Value
                End Set
            End Property
            Private m_mainAuction As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property UserRateUrl() As String
                Get
                    Return m_userRateUrl
                End Get
                Set
                    m_userRateUrl = Value
                End Set
            End Property
            Private m_userRateUrl As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsManjian() As String
                Get
                    Return m_isManjian
                End Get
                Set
                    m_isManjian = Value
                End Set
            End Property
            Private m_isManjian As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsSongli() As String
                Get
                    Return m_isSongli
                End Get
                Set
                    m_isSongli = Value
                End Set
            End Property
            Private m_isSongli As String

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
            Public Property HasSimilar() As String
                Get
                    Return m_hasSimilar
                End Get
                Set
                    m_hasSimilar = Value
                End Set
            End Property
            Private m_hasSimilar As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property AuctionsInshop() As List(Of AuctionsInshopItem)
                Get
                    Return m_auctionsInshop
                End Get
                Set
                    m_auctionsInshop = Value
                End Set
            End Property
            Private m_auctionsInshop As List(Of AuctionsInshopItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property ShopIcon() As ShopIcon
                Get
                    Return m_shopIcon
                End Get
                Set
                    m_shopIcon = Value
                End Set
            End Property
            Private m_shopIcon As ShopIcon

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
            Public Property IsMianyou() As String
                Get
                    Return m_isMianyou
                End Get
                Set
                    m_isMianyou = Value
                End Set
            End Property
            Private m_isMianyou As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property StartFee() As String
                Get
                    Return m_startFee
                End Get
                Set
                    m_startFee = Value
                End Set
            End Property
            Private m_startFee As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property DiscountCash() As String
                Get
                    Return m_discountCash
                End Get
                Set
                    m_discountCash = Value
                End Set
            End Property
            Private m_discountCash As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property GiftName() As String
                Get
                    Return m_giftName
                End Get
                Set
                    m_giftName = Value
                End Set
            End Property
            Private m_giftName As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property IsHideSale() As String
                Get
                    Return m_isHideSale
                End Get
                Set
                    m_isHideSale = Value
                End Set
            End Property
            Private m_isHideSale As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Icons() As List(Of IconsItem)
                Get
                    Return m_icons
                End Get
                Set
                    m_icons = Value
                End Set
            End Property
            Private m_icons As List(Of IconsItem)

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property DsrInfo() As DsrInfo
                Get
                    Return m_dsrInfo
                End Get
                Set
                    m_dsrInfo = Value
                End Set
            End Property
            Private m_dsrInfo As DsrInfo

        End Class






        Public Class Shoplist
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
            Public Property Data() As ShopListData.Data
                Get
                    Return m_data
                End Get
                Set
                    m_data = Value
                End Set
            End Property
            Private m_data As ShopListData.Data

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
            Public Property Initiative_Id() As String
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
            ''' 店铺
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
            Public Property [Type]() As String
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



        Public Class Mods
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
            Public Property Noresult() As Noresult
                Get
                    Return m_noresult
                End Get
                Set
                    m_noresult = Value
                End Set
            End Property
            Private m_noresult As Noresult

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Updatebar() As Updatebar
                Get
                    Return m_updatebar
                End Get
                Set
                    m_updatebar = Value
                End Set
            End Property
            Private m_updatebar As Updatebar

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Handpick() As Handpick
                Get
                    Return m_handpick
                End Get
                Set
                    m_handpick = Value
                End Set
            End Property
            Private m_handpick As Handpick

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
            Public Property Shoplist() As Shoplist
                Get
                    Return m_shoplist
                End Get
                Set
                    m_shoplist = Value
                End Set
            End Property
            Private m_shoplist As Shoplist

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
            Public Property Header() As Header
                Get
                    Return m_header
                End Get
                Set
                    m_header = Value
                End Set
            End Property
            Private m_header As Header

        End Class



        Public Class ModLinks
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
            Public Property Default2() As String
                Get
                    Return m_default2
                End Get
                Set
                    m_default2 = Value
                End Set
            End Property
            Private m_default2 As String

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
            Public Property Breadcrumb() As String
                Get
                    Return m_breadcrumb
                End Get
                Set
                    m_breadcrumb = Value
                End Set
            End Property
            Private m_breadcrumb As String

        End Class



        Public Class SrpGlobal
            ''' <summary>
            ''' 关键词充值
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
            Public Property Initiative_Id() As String
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

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Alg_bts() As String
                Get
                    Return m_alg_bts
                End Get
                Set
                    m_alg_bts = Value
                End Set
            End Property
            Private m_alg_bts As String

        End Class



        Public Class TraceData
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
            Public Property Alg_bts() As String
                Get
                    Return m_alg_bts
                End Get
                Set
                    m_alg_bts = Value
                End Set
            End Property
            Private m_alg_bts As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Uids() As List(Of String)
                Get
                    Return m_uids
                End Get
                Set
                    m_uids = Value
                End Set
            End Property
            Private m_uids As List(Of String)

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
            Public Property Goodrate() As String
                Get
                    Return m_goodrate
                End Get
                Set
                    m_goodrate = Value
                End Set
            End Property
            Private m_goodrate As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Pre() As String
                Get
                    Return m_pre
                End Get
                Set
                    m_pre = Value
                End Set
            End Property
            Private m_pre As String

            ''' <summary>
            ''' 
            ''' </summary>
            Public Property Stype() As String
                Get
                    Return m_stype
                End Get
                Set
                    m_stype = Value
                End Set
            End Property
            Private m_stype As String

            ''' <summary>
            ''' 
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
            Public Property Srppage() As String
                Get
                    Return m_srppage
                End Get
                Set
                    m_srppage = Value
                End Set
            End Property
            Private m_srppage As String

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
            Public Property TraceData() As TraceData
                Get
                    Return m_traceData
                End Get
                Set
                    m_traceData = Value
                End Set
            End Property
            Private m_traceData As TraceData

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