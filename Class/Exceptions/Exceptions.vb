Imports System.Runtime.Serialization


Namespace ShanXingTech.Exception2
    Public Class H5SearcherBaseUnInitializeException
        Inherits Exception

        Public Sub New(message As String)
            MyBase.New(message)
        End Sub

        Public Overrides Sub GetObjectData(info As SerializationInfo, context As StreamingContext)
            MyBase.GetObjectData(info, context)
        End Sub
    End Class
End Namespace
