
Public Class LossEstimateValidationResult
    Private _Data As Libraries.CoreLib.BusinessObjects.ViewCCCopeMainFire
    Private _Client As Libraries.CoreLib.BusinessObjects.Clients
    Private _Message As String
    Private _MessageGroup As String

    Public Sub New(pData As ViewCCCopeMainFire, pClient As Clients, pMessage As String, pMessageGroup As String)
        _Data = pData
        _Client = pClient
        _Message = pMessage
        _MessageGroup = pMessageGroup
    End Sub

    Public ReadOnly Property Data As Libraries.CoreLib.BusinessObjects.ViewCCCopeMainFire
        Get
            Return _Data
        End Get
    End Property

    Public ReadOnly Property Client As Libraries.CoreLib.BusinessObjects.Clients
        Get
            Return _Client
        End Get
    End Property

    Public ReadOnly Property Message As String
        Get
            Return _Message
        End Get
    End Property

    Public ReadOnly Property MessageGroup As String
        Get
            Return _MessageGroup
        End Get
    End Property

End Class


Public Class LossEstimateValidation
    Public Property AsText As String
    Public Property AsHtml As String

    Public Sub New(pHtml As String, pText As String)
        AsText = pText
        AsHtml = pHtml
    End Sub
End Class
