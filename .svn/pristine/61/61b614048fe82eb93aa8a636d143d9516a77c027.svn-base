Imports GRC.Connect.Libraries.WhatIfInterfaceLib

Public Class GridData
    Implements IGridData

    Public Property Currency As String Implements IGridData.Currency

    Public Property Data As List(Of Dictionary(Of String, Object)) Implements IGridData.Data

    Public Property EndRow As Integer Implements IGridData.EndRow

    Public Property Filter As String Implements IGridData.Filter

    Public Property Sort As String Implements IGridData.Sort

    Public Property StartRow As Integer Implements IGridData.StartRow

    Public Property Total As Integer Implements IGridData.Total

End Class

Public Class FormMeta
    Implements IFormMeta

    Public Property GridMeta As IDictionary(Of String, Object) Implements IFormMeta.GridMeta

    Public Property RecSorts As IList(Of IRecSort) Implements IFormMeta.RecSorts

    Public Property Client As IClient = New Client Implements IFormMeta.Client
End Class

Public Class FormData
    Implements IFormData

    Public Property HumanElementSelected As Integer = 0 Implements IFormData.HumanElementSelected

    Public Property HumanElementSelectedScoreChange As Single = 0.0 Implements IFormData.HumanElementSelectedScoreChange

    Public Property TotalSelected As Integer = 0 Implements IFormData.TotalSelected

    Public Property TotalSelectedScoreChange As Single = 0 Implements IFormData.TotalSelectedScoreChange

    Public Property Filter As String = "" Implements IFormData.Filter

    Public Property Charts As ChartingLib.ColumnChartList = New ChartingLib.ColumnChartList Implements IFormData.Charts

    Public Property EstCost As Integer = 0 Implements IFormData.EstCost
End Class

Public Class LocationRating
    Implements ILocationRating

    Public Property AchievableRatingPercentBackColorHex As String Implements ILocationRating.AchievableRatingPercentBackColorHex

    Public Property AchievableRatingPercentForeColorHex As String Implements ILocationRating.AchievableRatingPercentForeColorHex

    Public Property AchievableRatingPercentString As String Implements ILocationRating.AchievableRatingPercentString

    Public Property Address As String Implements ILocationRating.Address

    Public Property FileNo As String Implements ILocationRating.FileNo

    Public Property TotalScoreBackColorHex As String Implements ILocationRating.TotalScoreBackColorHex

    Public Property TotalScoreForeColorHex As String Implements ILocationRating.TotalScoreForeColorHex

    Public Property TotalScoreRecsAllRecsCompBackColorHex As String Implements ILocationRating.TotalScoreRecsAllRecsCompBackColorHex

    Public Property TotalScoreRecsAllRecsCompForeColorHex As String Implements ILocationRating.TotalScoreRecsAllRecsCompForeColorHex

    Public Property TotalScoreRecsAllRecsCompString As String Implements ILocationRating.TotalScoreRecsAllRecsCompString

    Public Property TotalScoreString As String Implements ILocationRating.TotalScoreString

    Public Property WhatIfAchievableRatingPercentBackColorHex As String Implements ILocationRating.WhatIfAchievableRatingPercentBackColorHex

    Public Property WhatIfAchievableRatingPercentForeColorHex As String Implements ILocationRating.WhatIfAchievableRatingPercentForeColorHex

    Public Property WhatIfAchievableRatingPercentString As String Implements ILocationRating.WhatIfAchievableRatingPercentString

    Public Property WhatIfScoreBackColorHex As String Implements ILocationRating.WhatIfScoreBackColorHex

    Public Property WhatIfScoreForeColorHex As String Implements ILocationRating.WhatIfScoreForeColorHex

    Public Property WhatIfScoreString As String Implements ILocationRating.WhatIfScoreString

    Public Property AllRecsCompAchievableRatingPercentBackColorHex As String Implements ILocationRating.AllRecsCompAchievableRatingPercentBackColorHex

    Public Property AllRecsCompAchievableRatingPercentForeColorHex As String Implements ILocationRating.AllRecsCompAchievableRatingPercentForeColorHex

    Public Property AllRecsCompAchievableRatingPercentString As String Implements ILocationRating.AllRecsCompAchievableRatingPercentString
End Class

Public Class PickListData
    Implements IPickListData

    Public Property ColumnName As String Implements IPickListData.ColumnName

    Public Property Data As IList(Of String) = New List(Of String) Implements IPickListData.Data

    Public Property DataType As String Implements IPickListData.DataType

End Class

Public Class RecSort
    Implements IRecSort

    Public Property ID As Integer Implements IRecSort.ID

    Public Property Text As String Implements IRecSort.Text

    Public Sub New(pID As Integer, pText As String)
        Me.ID = pID
        Me.Text = pText
    End Sub

    Public Shared Function ConvertList(pList As List(Of GRC.Connect.Libraries.DataLib.razor.rowVwWhatIfRecSort)) As List(Of IRecSort)
        Dim zList As New List(Of IRecSort)
        pList.ForEach(Sub(x) zList.Add(New RecSort(x.colFldID, x.colFldText)))
        Return zList
    End Function
End Class

Public Class RatingReportData
    Implements IRatingReportData

    Public Property Averages As List(Of IRatingAverage) Implements IRatingReportData.Averages

    Public Property Fields As DataLib.razor.IrowVwWhatIfFireFacilityRating Implements IRatingReportData.Fields

    Public Property RatingKeys As IList(Of DataLib.razor.IrowVwMetaRatingKeyRange) Implements IRatingReportData.RatingKeys

    Public Property Client As IClient = New Client Implements IRatingReportData.Client
End Class

Public Class WhatIfReportData
    Implements IWhatIfReportData

    Public Property FormData As IFormData = New FormData Implements IWhatIfReportData.FormData

    Public Property GridData As IGridData = New GridData Implements IWhatIfReportData.GridData

    Public Property Client As IClient = New Client Implements IWhatIfReportData.Client

    Public Property Budget As Single Implements IWhatIfReportData.Budget

    Public Property RemainBudget As String Implements IWhatIfReportData.RemainBudget
End Class

Public Class Client
    Implements IClient

    Public Enum LocationDescriptor
        None = 0
        Division = 1
        FileNo = 2
        CustomAccess = 3
        ClientLocID = 4
        Facility = 5
    End Enum

    Public Property ClientName As String Implements IClient.ClientName

    Public Property CustomAccessLabel As String Implements IClient.CustomAccessLabel

    Public Property ShowCustomAccess As Boolean = False Implements IClient.ShowCustomAccess

    Public Property ClientLocIDs As List(Of ILocationName) = New List(Of ILocationName) Implements IClient.ClientLocIDs

    Public Property CustomAccess As List(Of ILocationName) = New List(Of ILocationName) Implements IClient.CustomAccess

    Public Property Divisions As List(Of ILocationName) = New List(Of ILocationName) Implements IClient.Divisions

    Public Property FileNos As List(Of ILocationName) = New List(Of ILocationName) Implements IClient.FileNos

    Public Property Facilities As List(Of ILocationName) = New List(Of ILocationName) Implements IClient.Facilities

    Public Property FilePrefix As String Implements IClient.FilePrefix

    Public Property FireRatingKeyID As Integer Implements IClient.FireRatingKeyID
End Class

Public Class LocationName
    Implements ILocationName

    Public Property ID As String Implements ILocationName.ID

    Public Property Name As String Implements ILocationName.Name

    Public Property DescriptorID As Client.LocationDescriptor

    Public Sub New(pID As String, pName As String, pIdentifier As Client.LocationDescriptor)
        Me.ID = pID
        Me.Name = pName
        Me.DescriptorID = CInt(pIdentifier)
    End Sub

End Class

Public Class LocationNameFilter
    Public Add As Boolean
    Public Descriptor As Client.LocationDescriptor
    Public Name As String

    Public Sub New(pAdd As Boolean, pDescriptor As Client.LocationDescriptor, pName As String)
        Me.Add = pAdd
        Me.Descriptor = pDescriptor
        Me.Name = pName
    End Sub
End Class



