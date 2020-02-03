' 闪星网络信息科技 Q2287190283
' 神即道, 道法自然, 如来
Namespace ShanXingTech.Alibaba
	Public Class H5NewArrivalResutlEntity
		Public Class FirstItem
			''' <summary>
			''' 
			''' </summary>
			Public Property itemId() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property itemIdStr() As String
			''' <summary>
			''' 秋冬过年衣服女装ins圣诞车厘子新年大红色拜年裙针织毛衣连衣裙
			''' </summary>
			Public Property title() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property itemPic() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property price() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property time() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property isOnShelves() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property auctionTag() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property isBlackBoxItem() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property blackBoxItem() As String
		End Class

		Public Class List
			''' <summary>
			''' 12月17日
			''' </summary>
			Public Property publishDate() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property isShownPublishDate() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property firstItem() As FirstItem
			Public Property secondItem() As FirstItem
			''' <summary>
			''' 
			''' </summary>
			Public Property hasSecondItem() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property id() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property idStr() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property timestamp() As String
		End Class

		Public Class Data
			''' <summary>
			''' 
			''' </summary>
			Public Property list() As List(Of List)
		End Class

		Public Class Root
			''' <summary>
			''' 
			''' </summary>
			Public Property api() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property v() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property ret() As List(Of String)
			''' <summary>
			''' 
			''' </summary>
			Public Property data() As Data
		End Class
	End Class
End Namespace
