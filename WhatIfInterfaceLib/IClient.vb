Public Interface IClient
    Property ClientName As String
    Property FilePrefix As String
    Property FireRatingKeyID As Integer
    Property CustomAccessLabel As String
    Property ShowCustomAccess As Boolean
    Property Divisions As List(Of ILocationName)
    Property FileNos As List(Of ILocationName)
    Property CustomAccess As List(Of ILocationName)
    Property ClientLocIDs As List(Of ILocationName)
    Property Facilities As List(Of ILocationName)
End Interface

Public Interface ILocationName
    Property ID As String
    Property Name As String
End Interface

