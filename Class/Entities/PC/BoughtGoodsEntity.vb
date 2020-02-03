Namespace ShanXingTech.Alibaba
    ''' <summary>
    ''' 已买到的宝贝页详细信息Json实体
    ''' </summary>
    Public Class PCBoughtGoodsEntity
        Public Class Extra
            Public Property batch As Boolean
            ''' <summary>
            ''' 0
            ''' </summary>
            Public Property batchGroup() As String
            ''' <summary>
            ''' 预售商品和普通商品不支持合并付款
            ''' </summary>
            Public Property batchGroupTips() As String
            ''' <summary>
            ''' BatchMaxCount
            ''' </summary>
            Public Property batchMaxCount() As Integer
            ''' <summary>
            ''' BizType
            ''' </summary>
            Public Property bizType() As Integer
            ''' <summary>
            ''' Closed
            ''' </summary>
            Public Property closed() As Boolean
            ''' <summary>
            ''' CNY
            ''' </summary>
            Public Property currency() As String
            ''' <summary>
            ''' ￥
            ''' </summary>
            Public Property currencySymbol() As String
            Public Property finish As Boolean
            Public Property hiddenOrder As Boolean
            ''' <summary>
            ''' Id
            ''' </summary>
            Public Property id() As Long
            ''' <summary>
            ''' InHold
            ''' </summary>
            Public Property inHold() As Boolean
            ''' <summary>
            ''' IsShowSellerService
            ''' </summary>
            Public Property isShowSellerService() As Boolean
            ''' <summary>
            ''' NeedDisplay
            ''' </summary>
            Public Property needDisplay() As Boolean
            ''' <summary>
            ''' CREATE_CLOSED_OF_TAOBAO
            ''' </summary>
            Public Property tradeStatus() As String
            ''' <summary>
            ''' Visibility
            ''' </summary>
            Public Property visibility() As Boolean
        End Class

        Public Class OrderInfo
            ''' <summary>
            ''' Archive
            ''' </summary>
            Public Property archive() As Boolean
            ''' <summary>
            ''' B2C
            ''' </summary>
            Public Property b2C() As Boolean
            ''' <summary>
            ''' 2018-02-06
            ''' </summary>
            Public Property createDay() As Date
            ''' <summary>
            ''' 2018-02-06 18:33:50
            ''' </summary>
            Public Property createTime() As Date
            ''' <summary>
            ''' 123758723099428072
            ''' </summary>
            Public Property id() As String
        End Class

        Public Class PostFees
            ''' <summary>
            ''' (含运费
            ''' </summary>
            Public Property prefix() As String
            ''' <summary>
            ''' )
            ''' </summary>
            Public Property suffix() As String
            ''' <summary>
            ''' ￥10.00
            ''' </summary>
            Public Property value() As String
        End Class

        Public Class PayInfo
            ''' <summary>
            ''' 59.00
            ''' </summary>
            Public Property actualFee() As String
            ''' <summary>
            ''' PostFees
            ''' </summary>
            Public Property postFees() As List(Of PostFees)
        End Class

        Public Class Seller
            ''' <summary>
            ''' AlertStyle
            ''' </summary>
            Public Property alertStyle() As Integer
            ''' <summary>
            ''' GuestUser
            ''' </summary>
            Public Property guestUser() As Boolean
            ''' <summary>
            ''' Id
            ''' </summary>
            Public Property id() As Long
            ''' <summary>
            ''' 小米官方旗舰店
            ''' </summary>
            Public Property nick() As String
            ''' <summary>
            ''' NotShowSellerInfo
            ''' </summary>
            Public Property notShowSellerInfo() As Boolean
            ''' <summary>
            ''' OpeanSearch
            ''' </summary>
            Public Property opeanSearch() As Boolean
            ''' <summary>
            ''' ShopDisable
            ''' </summary>
            Public Property shopDisable() As Boolean
            ''' <summary>
            ''' //gtd.alicdn.com/tps/i2/TB1aJQKFVXXXXamXFXXEDhGGXXX-32-32.png
            ''' </summary>
            Public Property shopImg() As String
            ''' <summary>
            ''' 小米官方旗舰店
            ''' </summary>
            Public Property shopName() As String
            ''' <summary>
            ''' //store.taobao.com/shop/view_shop.htm?user_number_id=1714128138
            ''' </summary>
            Public Property shopUrl() As String
            ''' <summary>
            ''' nonAlipay
            ''' </summary>
            Public Property wangwangType() As String
        End Class

        Public Class Operations
            Public Property action As String
            Public Property dataUrl As String
            ''' <summary>
            ''' viewDetail
            ''' </summary>
            Public Property id() As String
            ''' <summary>
            ''' t0
            ''' </summary>
            Public Property style() As String
            ''' <summary>
            ''' 订单详情
            ''' </summary>
            Public Property text() As String
            ''' <summary>
            ''' operation
            ''' </summary>
            Public Property type() As String
            ''' <summary>
            ''' //tradearchive.taobao.com/trade/detail/trade_item_detail.htm?bizOrderId=123758723099428072
            ''' </summary>
            Public Property url() As String
        End Class

        Public Class StatusInfo
            ''' <summary>
            ''' Operations
            ''' </summary>
            Public Property operations() As List(Of Operations)
            ''' <summary>
            ''' 交易关闭
            ''' </summary>
            Public Property text() As String
            ''' <summary>
            ''' t0
            ''' </summary>
            Public Property type() As String
            ''' <summary>
            ''' //tradearchive.taobao.com/trade/detail/trade_item_detail.htm?bizOrderId=123758723099428072
            ''' </summary>
            Public Property url() As String
        End Class

        Public Class ServiceIcons
            ''' <summary>
            ''' 七天退换
            ''' </summary>
            Public Property linkTitle() As String
            ''' <summary>
            ''' //pages.tmall.com/wow/seller/act/seven-day
            ''' </summary>
            Public Property linkUrl() As String
            ''' <summary>
            ''' 七天退换
            ''' </summary>
            Public Property name() As String
            ''' <summary>
            ''' 七天退换
            ''' </summary>
            Public Property title() As String
            ''' <summary>
            ''' Type
            ''' </summary>
            Public Property type() As Integer
            ''' <summary>
            ''' //img.alicdn.com/tps/i3/T1Vyl6FCBlXXaSQP_X-16-16.png
            ''' </summary>
            Public Property url() As String
        End Class

        Public Class SkuText
            ''' <summary>
            ''' 颜色分类
            ''' </summary>
            Public Property name() As String
            ''' <summary>
            ''' 银色
            ''' </summary>
            Public Property value() As String
        End Class

        Public Class ItemInfo
            ''' <summary>
            ''' Id
            ''' </summary>
            Public Property id() As Long
            ''' <summary>
            ''' //item.taobao.com/item.htm?id=42609964540&amp;_u=mh9h7gg138c
            ''' </summary>
            Public Property itemUrl() As String
            ''' <summary>
            ''' //img.alicdn.com/imgextra/i1/1714128138/TB221KjetLO8KJjSZPcXXaV0FXa_!!1714128138.jpg_80x80.jpg
            ''' </summary>
            Public Property pic() As String
            ''' <summary>
            ''' ServiceIcons
            ''' </summary>
            Public Property serviceIcons() As List(Of ServiceIcons)
            ''' <summary>
            ''' SkuId
            ''' </summary>
            Public Property skuId() As Long
            ''' <summary>
            ''' SkuText
            ''' </summary>
            Public Property skuText() As List(Of SkuText)
            ''' <summary>
            ''' //buyertrade.taobao.com/trade/detail/tradeSnap.htm?tradeID=123758723099428072&amp;snapShot=true
            ''' </summary>
            Public Property snapUrl() As String
            ''' <summary>
            ''' 【新品】小米移动电源2 5000毫安充电宝手机超薄便携大容量快充
            ''' </summary>
            Public Property title() As String
            ''' <summary>
            ''' XtCurrent
            ''' </summary>
            Public Property xtCurrent() As Boolean
        End Class

        Public Class PriceInfo
            ''' <summary>
            ''' 49.00
            ''' </summary>
            Public Property realTotal() As String
        End Class

        Public Class SubOrders
            ''' <summary>
            ''' Id
            ''' </summary>
            Public Property id() As Long
            ''' <summary>
            ''' ItemInfo
            ''' </summary>
            Public Property itemInfo() As ItemInfo
            ''' <summary>
            ''' Operations
            ''' </summary>
            Public Property operations() As List(Of Operations)
            ''' <summary>
            ''' PriceInfo
            ''' </summary>
            Public Property priceInfo() As PriceInfo
            ''' <summary>
            ''' 1
            ''' </summary>
            Public Property quantity() As String
        End Class

        Public Class MainOrders
            ''' <summary>
            ''' Extra
            ''' </summary>
            Public Property extra() As Extra
            ''' <summary>
            ''' 123758723099428072
            ''' </summary>
            Public Property id() As String
            ''' <summary>
            ''' Operations
            ''' </summary>
            Public Property operations() As List(Of Operations)
            ''' <summary>
            ''' OrderInfo
            ''' </summary>
            Public Property orderInfo() As OrderInfo
            ''' <summary>
            ''' PayInfo
            ''' </summary>
            Public Property payInfo() As PayInfo
            ''' <summary>
            ''' Seller
            ''' </summary>
            Public Property seller() As Seller
            ''' <summary>
            ''' StatusInfo
            ''' </summary>
            Public Property statusInfo() As StatusInfo
            ''' <summary>
            ''' SubOrders
            ''' </summary>
            Public Property subOrders() As List(Of SubOrders)
        End Class

        Public Class Page
            ''' <summary>
            ''' CurrentPage
            ''' </summary>
            Public Property currentPage() As Integer
            ''' <summary>
            ''' PageSize
            ''' </summary>
            Public Property pageSize() As Integer
            ''' <summary>
            ''' PrefetchCount
            ''' </summary>
            Public Property prefetchCount() As Integer
            ''' <summary>
            ''' QueryForTitle
            ''' </summary>
            Public Property queryForTitle() As Boolean
            ''' <summary>
            ''' TotalNumber
            ''' </summary>
            Public Property totalNumber() As Integer
            ''' <summary>
            ''' TotalPage
            ''' </summary>
            Public Property totalPage() As Integer
        End Class

        Public Class Query
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property buyerNick() As String
            ''' <summary>
            ''' CartItemDOList
            ''' </summary>
            Public Property cartItemDOList() As List(Of String)
            ''' <summary>
            ''' DateBegin
            ''' </summary>
            Public Property dateBegin() As Integer
            ''' <summary>
            ''' DateEnd
            ''' </summary>
            Public Property dateEnd() As Integer
            ''' <summary>
            ''' Extra
            ''' </summary>
            Public Property extra() As Extra
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property lastStartRow() As String
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property logisticsService() As String
            ''' <summary>
            ''' Options
            ''' </summary>
            Public Property options() As Integer
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property orderStatus() As String
            ''' <summary>
            ''' PageNum
            ''' </summary>
            Public Property pageNum() As Integer
            ''' <summary>
            ''' PageSize
            ''' </summary>
            Public Property pageSize() As Integer
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property queryBizType() As String
            ''' <summary>
            ''' desc
            ''' </summary>
            Public Property queryOrder() As String
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property rateStatus() As String
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property refund() As String
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property sellerNick() As String
            Public Property tabCode As String
        End Class

        Public Class Tabs
            ''' <summary>
            ''' all
            ''' </summary>
            Public Property code() As String
            ''' <summary>
            ''' /trade/itemlist/list_bought_items.htm
            ''' </summary>
            Public Property herf() As String
            ''' <summary>
            ''' Selected
            ''' </summary>
            Public Property selected() As Boolean
            ''' <summary>
            ''' 所有订单
            ''' </summary>
            Public Property text() As String
            ''' <summary>
            ''' t1
            ''' </summary>
            Public Property type() As String
        End Class

        ''' <summary>
        ''' 入口
        ''' </summary>
        Public Class Root
            ''' <summary>
            ''' 
            ''' </summary>
            Public Property [error]() As String
            ''' <summary>
            ''' Extra
            ''' </summary>
            Public Property extra() As Extra
            ''' <summary>
            ''' MainOrders
            ''' </summary>
            Public Property mainOrders() As List(Of MainOrders)
            ''' <summary>
            ''' Page
            ''' </summary>
            Public Property page() As Page
            ''' <summary>
            ''' Query
            ''' </summary>
            Public Property query() As Query
            ''' <summary>
            ''' Tabs
            ''' </summary>
            Public Property tabs() As List(Of Tabs)
        End Class
    End Class


End Namespace
