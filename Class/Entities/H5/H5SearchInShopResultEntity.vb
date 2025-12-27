' 闪星网络信息科技 Q2287190283
' 神即道, 道法自然, 如来
Namespace ShanXingTech.Alibaba
#Disable Warning BC40031 ' 名称不符合 CLS
	Public Class H5SearchInShopResultEntity
		Public Class SortBar
			''' <summary>
			''' 
			''' </summary>
			Public Property trace() As String
			''' <summary>
			''' 综合
			''' </summary>
			Public Property showText() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property type() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property selected() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property paramValue() As String
		End Class

		Public Class SortMenu
			''' <summary>
			''' 
			''' </summary>
			Public Property showStyle() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property showFilter() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property sortBar() As List(Of SortBar)
		End Class

		Public Class PriceShow
			''' <summary>
			''' 
			''' </summary>
			Public Property unit() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property price() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property preText() As String
		End Class

		Public Class ItemsArray
			''' <summary>
			''' 
			''' </summary>
			Public Property clickUrl() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property priceWap() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property priceWithRate() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property clickTrace() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property type() As String
			''' <summary>
			''' 汽车密封条大D小D通用隔音条货车门后备箱防尘防水加厚加装胶条
			''' </summary>
			Public Property title() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property tItemType() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property nick() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property auctionUrl() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property isCod() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property isprepay() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property shipping() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property rateSum() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property isInLimitPromotion() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property price() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property summaryTips() As List(Of String)
			''' <summary>
			''' 金币抵2%
			''' </summary>
			Public Property coinInfo() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property ordinaryPostFee() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property sameCount() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property isP4p() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property sold() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property quantity() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property zkTime() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property item_id() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property promotedService() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property priceColor() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property auctionTag() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property fastPostFee() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property pic_path() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property userId() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property priceShow() As PriceShow
			''' <summary>
			''' 
			''' </summary>
			Public Property zkType() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property isB2c() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property userType() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property similarCount() As String
		End Class

		Public Class Data
			''' <summary>
			''' 新品
			''' </summary>
			Public Property tabName() As String

			''' <summary>
			''' 
			''' </summary>
			Public Property _cost() As Double

			''' <summary>
			''' 
			''' </summary>
			Public Property totalPage() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property pageSize() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property bucketId() As String
#Disable Warning BC40031 ' 名称不符合 CLS
			''' <summary>
			''' 
			''' </summary>
			Public Property _host() As String
#Enable Warning BC40031 ' 名称不符合 CLS
			''' <summary>
			''' 
			''' </summary>
			Public Property pageName() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property version() As Double
			''' <summary>
			''' 
			''' </summary>
			Public Property tpp_trace() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property abtest() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property totalResults() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property pvid() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property isJiaGou() As Boolean
			''' <summary>
			''' 
			''' </summary>
			Public Property sortMenu() As SortMenu
			''' <summary>
			''' 
			''' </summary>
			Public Property parameter() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property mainCategory() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property order_by() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property style() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property page() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property pageTraceName() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property RN() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property scm() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property itemsArray() As List(Of ItemsArray)
			''' <summary>
			''' 
			''' </summary>
			Public Property paramValue() As String
		End Class

		Public Class Root
			''' <summary>
			''' 
			''' </summary>
			Public Property api() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property data() As Data
			''' <summary>
			''' 
			''' </summary>
			Public Property ret() As List(Of String)
			''' <summary>
			''' 
			''' </summary>
			Public Property v() As String
		End Class
	End Class
#Enable Warning BC40031 ' 名称不符合 CLS
End Namespace

