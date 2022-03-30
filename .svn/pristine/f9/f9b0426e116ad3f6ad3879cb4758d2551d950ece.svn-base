Imports GRC.Connect.Libraries.WhatIfInterfaceLib

Public Class RestResponse
    Implements IRestResponse

    Public Property IsSuccess As Boolean = False Implements IRestResponse.IsSuccess

    Public Property Message As String = "" Implements IRestResponse.Message

End Class

Public Class FormDataRestResponse
    Inherits RestResponse
    Implements IFormData

    Public Property ChartData As List(Of ChartingLib.ColumnChartSeriesItem)

    Public Property Filter As String Implements IFormData.Filter

    Public Property HumanElementSelected As Integer Implements IFormData.HumanElementSelected

    Public Property HumanElementSelectedScoreChange As Single Implements IFormData.HumanElementSelectedScoreChange

    Public Property TotalSelected As Integer Implements IFormData.TotalSelected

    Public Property TotalSelectedScoreChange As Single Implements IFormData.TotalSelectedScoreChange

    Private Property Charts As ChartingLib.ColumnChartList Implements IFormData.Charts

    Public Property EstCost As Integer = 0 Implements IFormData.EstCost
End Class

Public Class PickListDataRestResponse
    Inherits RestResponse
    Implements IPickListData

    Public Property ColumnName As String Implements IPickListData.ColumnName

    Public Property Data As IList(Of String) Implements IPickListData.Data

    Public Property DataType As String Implements IPickListData.DataType

End Class

Public Class FormInitRestResponse
    Inherits RestResponse
    Implements IFormData
    Implements IFormMeta

    Public Property HumanElementSelected As Integer Implements IFormData.HumanElementSelected

    Public Property HumanElementSelectedScoreChange As Single Implements IFormData.HumanElementSelectedScoreChange

    Public Property TotalSelected As Integer Implements IFormData.TotalSelected

    Public Property TotalSelectedScoreChange As Single Implements IFormData.TotalSelectedScoreChange

    Public Property Filter As String Implements IFormData.Filter

    Public Property Client As IClient = New Client Implements IFormMeta.Client

    Public Property GridMeta As IDictionary(Of String, Object) Implements IFormMeta.GridMeta

    Public Property RecSorts As IList(Of IRecSort) Implements IFormMeta.RecSorts

    Public Property Charts As ChartingLib.ColumnChartList Implements IFormData.Charts

    Public Property EstCost As Integer = 0 Implements IFormData.EstCost
End Class

Public Class GridDataRestResponse
    Inherits RestResponse
    Implements IGridData

    Public Property Currency As String Implements IGridData.Currency

    Public Property Data As List(Of Dictionary(Of String, Object)) Implements IGridData.Data

    Public Property EndRow As Integer Implements IGridData.EndRow

    Public Property Filter As String Implements IGridData.Filter

    Public Property Sort As String Implements IGridData.Sort

    Public Property StartRow As Integer Implements IGridData.StartRow

    Public Property Total As Integer Implements IGridData.Total

End Class

Public Class LocationRatingRestResponse
    Inherits RestResponse
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

Public Class HandlerPropertiesRestReponse
    Inherits RestResponse

    Public Property HandlerGUID As String

End Class
