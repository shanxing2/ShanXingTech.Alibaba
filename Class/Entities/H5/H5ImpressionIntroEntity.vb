' 闪星网络信息科技 Q2287190283
' 神即道, 道法自然, 如来
Namespace ShanXingTech.Alibaba
	''' <summary>
	''' 店铺印象——介绍实体（掌柜名、服务电话、所在地、资质、开店时间等）
	''' </summary>
	Public Class H5ImpressionIntroEntity
		Public Class Result
			''' <summary>
			''' 
			''' </summary>
			Public Property sellerId() As Integer
			''' <summary>
			''' 
			''' </summary>
			Public Property shopId() As Integer
			''' <summary>
			''' 开店时间戳
			''' </summary>
			Public Property starts() As Long
			''' <summary>
			''' 
			''' </summary>
			Public Property xid() As String
			''' <summary>
			''' 掌柜名
			''' </summary>
			Public Property nick() As String
			''' <summary>
			''' 手机号
			''' </summary>
			Public Property phone() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property phoneIcon() As String
			''' <summary>
			''' 所在地
			''' </summary>
			Public Property city() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property licenseUrl() As String
			''' <summary>
			''' 资质
			''' </summary>
			Public Property aptitude() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property industryLicenseUrl() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property industryLicenseIcon() As List(Of String)
			''' <summary>
			''' 
			''' </summary>
			Public Property wangwangLink() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property wangwangIcon() As String
		End Class

		Public Class Extension
		End Class

		Public Class Data
			''' <summary>
			''' 
			''' </summary>
			Public Property result() As Result
			''' <summary>
			''' 
			''' </summary>
			Public Property resultCode() As String
			''' <summary>
			''' 成功
			''' </summary>
			Public Property message() As String
			''' <summary>
			''' 
			''' </summary>
			Public Property extension() As Extension
			''' <summary>
			''' 
			''' </summary>
			Public Property failure() As Boolean
			''' <summary>
			''' 
			''' </summary>
			Public Property success() As Boolean
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
