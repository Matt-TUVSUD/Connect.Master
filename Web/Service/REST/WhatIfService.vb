Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.ServiceModel
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Description
Imports System.ServiceModel.Web
Imports System.ServiceModel.Channels
Imports GRC.Connect.Libraries.WhatIfLib
Imports GRC.Connect.Libraries.WhatIfInterfaceLib
Imports Newtonsoft.Json
Imports System.Reflection
Imports System.Xml

<ServiceModel.ServiceContract>
<AspNetCompatibilityRequirements(RequirementsMode:=AspNetCompatibilityRequirementsMode.Allowed)>
Public Class WhatIfService

    Public Shared Sub InitService()
        Dim zMe As New WhatIfService
        System.Web.Routing.RouteTable.Routes.Add(New System.ServiceModel.Activation.ServiceRoute("service/wi", New WebServiceHostFactory(), zMe.GetType))
    End Sub

#Region "Form Methods"

    <OperationContract> _
    <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="GET", UriTemplate:="form/init/{pSid}")> _
    <ServiceReturnTypeAttribute("FormInitRestResponse")>
    Public Function InitForm(pSid As String) As IO.Stream

        Dim zReturn As New FormInitRestResponse

        Try

            Dim zUtil As New UtilWhatIf(pSid)
            Dim zMeta As FormMeta = zUtil.InitForm()

            zReturn.GridMeta = zMeta.GridMeta
            zReturn.RecSorts = zMeta.RecSorts
            zReturn.HumanElementSelected = 0
            zReturn.HumanElementSelectedScoreChange = 0
            zReturn.TotalSelected = 0
            zReturn.TotalSelectedScoreChange = 0
            zReturn.Client = zMeta.Client
            zReturn.IsSuccess = True

            Return Serialize(zReturn)

        Catch ex As Exception
            ex.Data.Add("Name", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.userFullName))
            ex.Data.Add("Email", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.UserEmail))
            ex.Data.Add("FilePrefix", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.FilePreFix))
            zReturn.IsSuccess = False
            zReturn.Message = GetExceptionMessage(ex)
            Return Serialize(zReturn)
        End Try

    End Function

    <OperationContract> _
    <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="GET", UriTemplate:="form/{pSid}")> _
    <ServiceReturnTypeAttribute("FormDataRestResponse")>
    Public Function GetFormData(pSid As String) As IO.Stream
        Return GetFormDataByFilter(pSid, False, Client.LocationDescriptor.None, "")
    End Function

    <OperationContract> _
   <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="GET", UriTemplate:="form/{pSid}?val={pValue}&desc={pDescriptor}&name={pName}")> _
   <ServiceReturnTypeAttribute("FormDataRestResponse")>
    Public Function GetFormDataByFilter(pSid As String, pValue As Boolean, pDescriptor As String, pName As String) As IO.Stream

        Dim zReturn As New FormDataRestResponse

        Try
            Dim zFilter As New LocationNameFilter(pValue, pDescriptor, pName)
            Dim zUtil As New UtilWhatIf(pSid)
            Dim zData As FormData = zUtil.GetFormData(zFilter)

            With zReturn
                .ChartData = zData.Charts.GetDataPoints()
                .Filter = zData.Filter
                .HumanElementSelected = zData.HumanElementSelected
                .HumanElementSelectedScoreChange = zData.HumanElementSelectedScoreChange
                .TotalSelected = zData.TotalSelected
                .TotalSelectedScoreChange = zData.TotalSelectedScoreChange
                .EstCost = zData.EstCost
            End With

            zReturn.IsSuccess = True
            zReturn.Message = ""
            Return Serialize(zReturn)

        Catch ex As Exception
            ex.Data.Add("Name", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.userFullName))
            ex.Data.Add("Email", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.UserEmail))
            ex.Data.Add("FilePrefix", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.FilePreFix))
            zReturn.IsSuccess = False
            zReturn.Message = GetExceptionMessage(ex)
            Return Serialize(zReturn)
        End Try

    End Function

    <OperationContract> _
    <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="GET", UriTemplate:="LocationRating/{pSid}?pFileNo={pFileNo}")> _
    <ServiceReturnTypeAttribute("LocationRatingRestResponse")>
    Public Function GetLocationRatingSummary(pSid As String, pFileNo As String) As IO.Stream

        Dim zReturn As New LocationRatingRestResponse

        Try
            Dim zUtil As New UtilWhatIf(pSid)
            Dim zData As LocationRating = zUtil.GetLocationRating(pFileNo)
            With zReturn
                zReturn.IsSuccess = True
                zReturn.Message = ""
                .AchievableRatingPercentBackColorHex = zData.AchievableRatingPercentBackColorHex
                .AchievableRatingPercentForeColorHex = zData.AchievableRatingPercentForeColorHex
                .AchievableRatingPercentString = zData.AchievableRatingPercentString
                .Address = zData.Address
                .FileNo = zData.FileNo
                .TotalScoreBackColorHex = zData.TotalScoreBackColorHex
                .TotalScoreForeColorHex = zData.TotalScoreForeColorHex
                .TotalScoreRecsAllRecsCompBackColorHex = zData.TotalScoreRecsAllRecsCompBackColorHex
                .TotalScoreRecsAllRecsCompForeColorHex = zData.TotalScoreRecsAllRecsCompForeColorHex
                .TotalScoreRecsAllRecsCompString = zData.TotalScoreRecsAllRecsCompString
                .TotalScoreString = zData.TotalScoreString
                .WhatIfAchievableRatingPercentBackColorHex = zData.WhatIfAchievableRatingPercentBackColorHex
                .WhatIfAchievableRatingPercentForeColorHex = zData.WhatIfAchievableRatingPercentForeColorHex
                .WhatIfAchievableRatingPercentString = zData.WhatIfAchievableRatingPercentString
                .WhatIfScoreBackColorHex = zData.WhatIfScoreBackColorHex
                .WhatIfScoreForeColorHex = zData.WhatIfScoreForeColorHex
                .WhatIfScoreString = zData.WhatIfScoreString
                .AllRecsCompAchievableRatingPercentBackColorHex = zData.AllRecsCompAchievableRatingPercentBackColorHex
                .AllRecsCompAchievableRatingPercentForeColorHex = zData.AllRecsCompAchievableRatingPercentForeColorHex
                .AllRecsCompAchievableRatingPercentString = zData.AllRecsCompAchievableRatingPercentString
            End With
            Return Serialize(zReturn)

        Catch ex As Exception
            ex.Data.Add("Name", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.userFullName))
            ex.Data.Add("Email", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.UserEmail))
            ex.Data.Add("FilePrefix", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.FilePreFix))
            zReturn.IsSuccess = False
            zReturn.Message = GetExceptionMessage(ex)
            Return Serialize(zReturn)
        End Try

    End Function

#End Region

#Region "Recs"

    <OperationContract> _
    <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="POST", UriTemplate:="/recs/select/filter")> _
    <ServiceReturnTypeAttribute("RestResponse")>
    Public Function SelectRecs(pSid As String, pFilter As String) As IO.Stream

        Dim zReturn As New RestResponse

        Try
            Dim zUtil As New UtilWhatIf(pSid)
            zUtil.SelectRecs(pFilter)
            zReturn.IsSuccess = True
            Return Serialize(zReturn)

        Catch ex As Exception
            ex.Data.Add("Name", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.userFullName))
            ex.Data.Add("Email", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.UserEmail))
            ex.Data.Add("FilePrefix", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.FilePreFix))
            zReturn.IsSuccess = False
            zReturn.Message = GetExceptionMessage(ex)
            Return Serialize(zReturn)
        End Try

    End Function

    <OperationContract> _
    <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="POST", UriTemplate:="/recs/select/id")> _
     <ServiceReturnTypeAttribute("RestResponse")>
    Public Function SelectRec(pSid As String, pRecID As String) As IO.Stream

        Dim zReturn As New RestResponse

        Try
            Dim zUtil As New UtilWhatIf(pSid)
            zUtil.SelectRec(pRecID)
            zReturn.IsSuccess = True
            Return Serialize(zReturn)

        Catch ex As Exception
            ex.Data.Add("Name", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.userFullName))
            ex.Data.Add("Email", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.UserEmail))
            ex.Data.Add("FilePrefix", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.FilePreFix))
            zReturn.IsSuccess = False
            zReturn.Message = GetExceptionMessage(ex)
            Return Serialize(zReturn)
        End Try

    End Function

    <OperationContract> _
    <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="POST", UriTemplate:="/recs/deselect/filter")> _
     <ServiceReturnTypeAttribute("RestResponse")>
    Public Function DeselectRecs(pSid As String, pFilter As String) As IO.Stream

        Dim zReturn As New RestResponse

        Try
            Dim zUtil As New UtilWhatIf(pSid)
            zUtil.DeselectRecs(pFilter)
            zReturn.IsSuccess = True
            Return Serialize(zReturn)

        Catch ex As Exception
            ex.Data.Add("Name", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.userFullName))
            ex.Data.Add("Email", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.UserEmail))
            ex.Data.Add("FilePrefix", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.FilePreFix))
            zReturn.IsSuccess = False
            zReturn.Message = GetExceptionMessage(ex)
            Return Serialize(zReturn)
        End Try

    End Function

    <OperationContract> _
    <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="POST", UriTemplate:="/recs/deselect/id")> _
     <ServiceReturnTypeAttribute("RestResponse")>
    Public Function DeselectRec(pSid As String, pRecID As String) As IO.Stream

        Dim zReturn As New RestResponse

        Try
            Dim zUtil As New UtilWhatIf(pSid)
            zUtil.DeselectRec(pRecID)
            zReturn.IsSuccess = True
            Return Serialize(zReturn)

        Catch ex As Exception
            ex.Data.Add("Name", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.userFullName))
            ex.Data.Add("Email", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.UserEmail))
            ex.Data.Add("FilePrefix", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.FilePreFix))
            zReturn.IsSuccess = False
            zReturn.Message = GetExceptionMessage(ex)
            Return Serialize(zReturn)
        End Try

    End Function

    ' <OperationContract> _
    '<WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="GET", UriTemplate:="/recs/{pSid}/picklist/?filter={pFilter}&sort={pSort}")> _
    '<ServiceReturnTypeAttribute("GridDataRestResponse")>
    ' Public Function GetRecsByPicklist(pSid As String, pFilter As String, pSort As String) As IO.Stream

    '     Dim zReturn As New GridDataRestResponse

    '     Try
    '         Dim zUtil As New UtilWhatIf(pSid)

    '         'whenever we get recs by the picklist filter, we are alwasy going to return the 1st page of data
    '         Dim zGD As IGridData = zUtil.GetGridData(1, 100, pSort, pFilter)
    '         With zReturn
    '             .Currency = zGD.Currency
    '             .Data = zGD.Data
    '             .EndRow = zGD.EndRow
    '             .Filter = zGD.Filter
    '             .Sort = zGD.Sort
    '             .Total = zGD.Total
    '             .StartRow = zGD.StartRow
    '         End With

    '         zReturn.IsSuccess = True
    '         Return Serialize(zReturn)

    '     Catch ex As Exception
    '         ex.Data.Add("Name", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.userFullName))
    '         ex.Data.Add("Email", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.UserEmail))
    '         ex.Data.Add("FilePrefix", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.FilePreFix))
    '         zReturn.IsSuccess = False
    '         zReturn.Message = GetExceptionMessage(ex)
    '         Return Serialize(zReturn)
    '     End Try

    ' End Function

    <OperationContract> _
   <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="GET", UriTemplate:="/recs/{pSid}/?filter={pFilter}&sort={pSort}&take={pTake}&skip={pSkip}&page={pPage}&pageSize={pPageSize}&sortIndex={pSortIndex}&selected={pSelected}")> _
   <ServiceReturnTypeAttribute("GridDataRestResponse")>
    Public Function GetRecs(pSid As String, pFilter As String, pSort As String, pPage As String, pPageSize As String, pTake As String, pSkip As String, pSortIndex As String, pSelected As String) As IO.Stream

        Dim zReturn As New GridDataRestResponse

        Try
            Dim zUtil As New UtilWhatIf(pSid)

            Dim zGD As IGridData = Nothing

            ''if there is no filter/sort and no recs selected, then page is first time load, sort by sort index
            If String.IsNullOrEmpty(pFilter) And String.IsNullOrEmpty(pSort) And CBool(pSelected) = False Then
                zGD = zUtil.GetGridData(pPage, pPageSize, pSortIndex)

                ''if the user clicked the filter by selection buttion
            ElseIf CBool(pSelected) = True Then
                zGD = zUtil.GetRecsSelected(pSort)
            Else
                ''Else get rec data using supplied sort and filter strings
                zGD = zUtil.GetGridData(pPage, pPageSize, UrlDecode(pSort), UrlDecode(pFilter))
            End If

            With zReturn
                .Currency = zGD.Currency
                .Data = zGD.Data
                .EndRow = zGD.EndRow
                .Filter = zGD.Filter
                .Sort = zGD.Sort
                .Total = zGD.Total
                .StartRow = zGD.StartRow
            End With

            zReturn.IsSuccess = True
            Return Serialize(zReturn)

        Catch ex As Exception
            ex.Data.Add("Name", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.userFullName))
            ex.Data.Add("Email", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.UserEmail))
            ex.Data.Add("FilePrefix", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.FilePreFix))
            zReturn.IsSuccess = False
            zReturn.Message = GetExceptionMessage(ex)
            Return Serialize(zReturn)
        End Try

    End Function

    '<OperationContract> _
    ' <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="GET", UriTemplate:="/recs/{pSid}/{pRecSortId}")> _
    '  <ServiceReturnTypeAttribute("GridDataRestResponse")>
    'Public Function GetRecs(pSid As String, pRecSortId As String) As IO.Stream

    '    Dim zReturn As New GridDataRestResponse

    '    Try

    '        Dim zUtil As New UtilWhatIf(pSid)
    '        Dim zGD As IGridData = zUtil.GetGridData(pRecSortId)
    '        With zReturn
    '            .Currency = zGD.Currency
    '            .Data = zGD.Data
    '            .EndRow = zGD.EndRow
    '            .Filter = zGD.Filter
    '            .Sort = zGD.Sort
    '            .Total = zGD.Total
    '            .StartRow = zGD.StartRow
    '        End With

    '        zReturn.IsSuccess = True
    '        Return Serialize(zReturn)

    '    Catch ex As Exception
    '        ex.Data.Add("Name", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.userFullName))
    '        ex.Data.Add("Email", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.UserEmail))
    '        ex.Data.Add("FilePrefix", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.FilePreFix))
    '        zReturn.IsSuccess = False
    '        zReturn.Message = GetExceptionMessage(ex)
    '        Return Serialize(zReturn)
    '    End Try

    'End Function

    '<OperationContract> _
    ' <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="GET", UriTemplate:="/recs/getselected/{pSid}")> _
    '  <ServiceReturnTypeAttribute("GridDataRestResponse")>
    'Public Function GetRecsSelected(pSid As String) As IO.Stream

    '    Dim zReturn As New GridDataRestResponse

    '    Try

    '        Dim zUtil As New UtilWhatIf(pSid)
    '        Dim zGD As IGridData = zUtil.GetRecsSelected()
    '        With zReturn
    '            .Currency = zGD.Currency
    '            .Data = zGD.Data
    '            .EndRow = zGD.EndRow
    '            .Filter = zGD.Filter
    '            .Sort = zGD.Sort
    '            .Total = zGD.Total
    '            .StartRow = zGD.StartRow
    '        End With

    '        zReturn.IsSuccess = True
    '        Return Serialize(zReturn)

    '    Catch ex As Exception
    '        ex.Data.Add("Name", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.userFullName))
    '        ex.Data.Add("Email", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.UserEmail))
    '        ex.Data.Add("FilePrefix", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.FilePreFix))
    '        zReturn.IsSuccess = False
    '        zReturn.Message = GetExceptionMessage(ex)
    '        Return Serialize(zReturn)
    '    End Try

    'End Function

    '   <OperationContract> _
    '<WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="GET", UriTemplate:="/recs/{pSid}/?filter={pFilter}&sort={pSort}")> _
    '<ServiceReturnTypeAttribute("GridDataRestResponse")>
    '   Public Function GetRecsByFilter(pSid As String, pFilter As String, pSort As String) As IO.Stream
    '       Dim zReturn As New GridDataRestResponse

    '       Try
    '           Dim zUtil As New UtilWhatIf(pSid)
    '           Dim zGD As IGridData = zUtil.GetGridData(pSort, pFilter)

    '           With zReturn
    '               .Currency = zGD.Currency
    '               .Data = zGD.Data
    '               .EndRow = zGD.EndRow
    '               .Filter = zGD.Filter
    '               .Sort = zGD.Sort
    '               .Total = zGD.Total
    '               .StartRow = zGD.StartRow
    '           End With

    '           zReturn.IsSuccess = True
    '           Return Serialize(zReturn)

    '       Catch ex As Exception
    '           ex.Data.Add("Name", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.userFullName))
    '           ex.Data.Add("Email", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.UserEmail))
    '           ex.Data.Add("FilePrefix", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.FilePreFix))
    '           zReturn.IsSuccess = False
    '           zReturn.Message = GetExceptionMessage(ex)
    '           Return Serialize(zReturn)
    '       End Try

    '   End Function

    <OperationContract> _
    <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="GET", UriTemplate:="/recpicklist/{pSid}?field={pfield}&filter={pFilter}")>
    <ServiceReturnTypeAttribute("PickListDataRestResponse")>
    Public Function GetRecPickListData(pSid As String, pField As String, pFilter As String) As IO.Stream

        Dim zReturn As New PickListDataRestResponse

        Try

            Dim zUtil As New UtilWhatIf(pSid)
            Dim zPK As PickListData = zUtil.GetPickListData(pField, pFilter)
            zReturn.ColumnName = zPK.ColumnName
            zReturn.Data = zPK.Data
            zReturn.DataType = zPK.DataType
            zReturn.IsSuccess = True
            Return Serialize(zReturn)

        Catch ex As Exception
            ex.Data.Add("Name", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.userFullName))
            ex.Data.Add("Email", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.UserEmail))
            ex.Data.Add("FilePrefix", UtilGSafe.GetValue(pSid, UtilGSafe.KeyName.FilePreFix))
            zReturn.IsSuccess = False
            zReturn.Message = GetExceptionMessage(ex)
            Return Serialize(zReturn)
        End Try

    End Function

#End Region

#Region "Outputs"

    <OperationContract>
    <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="POST", UriTemplate:="/output/extracts/recs")>
    <ServiceReturnTypeAttribute("HandlerPropertiesRestReponse")>
    Public Function SetExtractParms(pSid As String, pSort As String, pFilter As String) As IO.Stream
        Return SetParms(pSid, DownloadHandler.ReportTypes.RecExtract, "", pSort, pFilter, "", "", "")
    End Function

    <OperationContract>
    <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="POST", UriTemplate:="/output/reports/facility")>
    <ServiceReturnTypeAttribute("HandlerPropertiesRestReponse")>
    Public Function SetFacilityReportParms(pSid As String, pFileNo As String) As IO.Stream
        Return SetParms(pSid, DownloadHandler.ReportTypes.RatingReport, pFileNo, "", "", "", "", "")
    End Function

    <OperationContract>
    <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Wrapped, Method:="POST", UriTemplate:="/output/reports/whatif")>
    <ServiceReturnTypeAttribute("HandlerPropertiesRestReponse")>
    Public Function SetReportParms(pSid As String, pSort As String, pFilter As String, pEstBudget As String, pEstCostToComplete As String, pRemainBudget As String) As IO.Stream
        Return SetParms(pSid, DownloadHandler.ReportTypes.WhatIfReport, "", pSort, pFilter, pEstBudget, pEstCostToComplete, pRemainBudget)
    End Function

    Private Function SetParms(pSid As String, pReportTypeID As WhatIfLib.DownloadHandler.ReportTypes, pFileNo As String, pSort As String, pFilter As String, pEstBudget As String, pEstCostToComplete As String, pRemainBudget As String) As IO.Stream
        Dim zReturn As New HandlerPropertiesRestReponse
        Try
            Dim zUtil As New UtilWhatIf(pSid)
            zReturn.HandlerGUID = zUtil.SetOutputParameters(pReportTypeID, pFileNo, pSort, pFilter, pEstBudget, pEstCostToComplete, pRemainBudget)
            zReturn.IsSuccess = True
            Return Serialize(zReturn)
        Catch ex As Exception
            zReturn.IsSuccess = False
            zReturn.Message = GetExceptionMessage(ex)
            Return Serialize(zReturn)
        End Try
    End Function

#End Region

#Region "Helpers"


    Private Function Serialize(pValue As Object) As IO.Stream
        Dim zReturn As String = ""
        zReturn = Newtonsoft.Json.JsonConvert.SerializeObject(pValue)
        ServiceModel.Web.WebOperationContext.Current.OutgoingResponse.ContentType = "application/javascript"
        Return New System.IO.MemoryStream(Encoding.UTF8.GetBytes(zReturn))
    End Function

    Private Function GetExceptionMessage(pEx As Exception) As String
        If Debugger.IsAttached Then
            Return pEx.Message
        Else
            Dim zErrorLog As New UtilErrorLog
            zErrorLog.ApplicationPage = "What If"
            zErrorLog.DateOccured = Now()
            zErrorLog.UserEmail = pEx.Data("Email")
            zErrorLog.MessageOuter = pEx.Message
            zErrorLog.MessageInner = pEx.GetBaseException.Message
            zErrorLog.StackTraceInner = pEx.StackTrace
            zErrorLog.ErrorType = pEx.GetType.ToString
            Dim zID As Integer = zErrorLog.CreateErrorLogRecord()
            zErrorLog.ReportErrorViaEmail(zID)
            Return "An error occurred within the application."
        End If
    End Function

    <OperationContract> _
    <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare, Method:="*", UriTemplate:="/help2")> _
    Public Function Help(ByVal m As Message) As Message
        Dim zMyMessage As New MyMessage
        WebHttpHelpPageGenerator.GenerateHelpPage(zMyMessage)
        WebOperationContext.Current.OutgoingResponse.ContentType = "text/html; charset=utf-8"
        Return zMyMessage
    End Function

    Private Function Base64ToString(pBase64 As String) As String
        If pBase64 <> "null" Then
            Return Text.UTF8Encoding.UTF8.GetString(Convert.FromBase64String(pBase64))
        Else
            Return ""
        End If
    End Function

    Private Function UrlDecode(pValue As String) As String
        Return System.Web.HttpUtility.UrlDecode(pValue)
    End Function

#End Region

End Class

Public Class MyMessage
    Inherits Message

    Public ServiceUri As String
    Public Operations As New List(Of OperationInfo)
    Private _Headers As New MessageHeaders(Version)
    Private _Properties As New MessageProperties()

    Public Overrides ReadOnly Property Headers As MessageHeaders
        Get
            Return _Headers
        End Get
    End Property

    Protected Overrides Sub OnWriteBodyContents(writer As System.Xml.XmlDictionaryWriter)

        writer.WriteStartElement("html")
        writer.WriteStartElement("head")

        writer.WriteElementString("title", "Better help page, presented by")
        writer.WriteElementString("style", ".titleDiv{background-image: linear-gradient(#a080ba, #dfd5e8); color:white; width:100%; height:50px; font-family:Arial;}")
        writer.WriteElementString("style", "table {font-family: arial; font-size:12px;}")
        writer.WriteElementString("style", "tr {border-bottom:1px black solid;}")
        writer.WriteElementString("style", "th {text-align:left;}")
        writer.WriteElementString("style", "td {padding:5px; border:.5px gray solid;}")

        writer.WriteEndElement() 'header

        writer.WriteStartElement("body")

        writer.WriteStartElement("div")
        writer.WriteAttributeString("class", "titleDiv")
        writer.WriteElementString("h2", "Operations at: " & ServiceUri)
        writer.WriteEndElement() 'div

        writer.WriteStartElement("table")
        writer.WriteStartElement("tr")
        writer.WriteElementString("th", "Operation Name")
        writer.WriteElementString("th", "Method")
        writer.WriteElementString("th", "Uri Template")
        writer.WriteElementString("th", "Parameters")
        writer.WriteElementString("th", "Return")
        writer.WriteElementString("th", "Req. Fmt")
        writer.WriteElementString("th", "Rsp. Fmt")
        writer.WriteElementString("th", "Body Style")
        writer.WriteEndElement()

        For Each o As OperationInfo In Me.Operations
            writer.WriteStartElement("tr")

            writer.WriteElementString("td", o.OperationName)
            writer.WriteElementString("td", o.Method)
            writer.WriteElementString("td", o.UriTemplate)
            writer.WriteElementString("td", o.Parameters)
            writer.WriteElementString("td", o.ReturnProperties)
            writer.WriteElementString("td", o.RequestFormat)
            writer.WriteElementString("td", o.ResponseFormat)
            writer.WriteElementString("td", o.BodyStyle)

            writer.WriteEndElement()
        Next

        writer.WriteEndElement()
        writer.WriteEndElement() 'BODY
        writer.WriteEndElement() 'HTML
    End Sub

    Public Overrides ReadOnly Property Properties As MessageProperties
        Get
            Return _Properties
        End Get
    End Property

    Public Overrides ReadOnly Property Version As MessageVersion
        Get
            Return MessageVersion.None
        End Get
    End Property
End Class

Public Class WebHttpHelpPageGenerator

    Public Shared Sub GenerateHelpPage(message As MyMessage)
        Dim endpoints As ServiceEndpointCollection = OperationContext.Current.Host.Description.Endpoints
        Dim operations As OperationDescriptionCollection = Nothing
        Dim contract As Type = Nothing
        Dim ep As ServiceEndpoint = Nothing

        For Each endpoint As ServiceEndpoint In endpoints
            If endpoint.Contract.Name = OperationContext.Current.EndpointDispatcher.ContractName Then
                ep = endpoint
                contract = endpoint.Contract.ContractType
                operations = endpoint.Contract.Operations
                Exit For
            End If
        Next

        message.ServiceUri = ep.ListenUri.ToString

        For Each operation As OperationDescription In operations
            If operation.Name.ToLower <> "help" Then
                Dim [get] As WebGetAttribute = operation.Behaviors.Find(Of WebGetAttribute)()
                Dim invoke As WebInvokeAttribute = operation.Behaviors.Find(Of WebInvokeAttribute)()
                Dim ServiceAttr As ServiceReturnTypeAttribute = operation.SyncMethod.GetCustomAttribute(Of ServiceReturnTypeAttribute)()

                If [get] Is Nothing AndAlso invoke Is Nothing Then Continue For
                Dim method As MethodInfo = contract.GetMethod(operation.Name)
                Dim info As OperationInfo = New OperationInfo
                With info
                    .OperationName = operation.Name
                    .Method = If([get] IsNot Nothing, "GET", invoke.Method)
                    .BodyStyle = If([get] IsNot Nothing, [get].BodyStyle.ToString(), invoke.BodyStyle.ToString())
                    .UriTemplate = If([get] IsNot Nothing, [get].UriTemplate, invoke.UriTemplate)
                    .ReturnType = method.ReturnType.ToString()
                    .Parameters = GetFormattedParameters(method.GetParameters())
                    .RequestFormat = If([get] IsNot Nothing, [get].RequestFormat.ToString(), invoke.ResponseFormat.ToString())
                    .ResponseFormat = If([get] IsNot Nothing, [get].ResponseFormat.ToString(), invoke.ResponseFormat.ToString())

                    If Not IsNothing(ServiceAttr) Then .ReturnProperties = GetFormattedProperties(ServiceAttr.GetReturnType.GetProperties)
                End With
                info.OperationName = operation.Name

                message.Operations.Add(info)
            End If

        Next

    End Sub

    Private Shared Function GetFormattedParameters(pParms As ParameterInfo()) As String
        Dim zSB As New StringBuilder
        For Each pParm As ParameterInfo In pParms
            If zSB.Length > 0 Then zSB.Append(", ")
            zSB.Append(pParm.Name)
        Next
        Return zSB.ToString
    End Function

    Private Shared Function GetFormattedProperties(pProps As PropertyInfo()) As String
        Dim zSB As New StringBuilder
        For Each pParm As PropertyInfo In pProps
            If zSB.Length > 0 Then zSB.Append(", ")
            zSB.Append(pParm.Name)
        Next
        Return zSB.ToString
    End Function

End Class

Public Class OperationInfo
    Public OperationName As String
    Public Method As String
    Public BodyStyle As String
    Public UriTemplate As String
    Public ReturnType As String
    Public Parameters As String
    Public ReturnProperties As String
    Public RequestFormat As String
    Public ResponseFormat As String

End Class

<AttributeUsage(AttributeTargets.Method)>
Public Class ServiceReturnTypeAttribute
    Inherits System.Attribute

    Private _TypeAssembly As Assembly
    Private _TypeName As String
    Private _Type As System.Type

    Public Sub New(pTypeName As String)

        Dim zAssemblyNames As List(Of AssemblyName) = Assembly.GetExecutingAssembly.GetReferencedAssemblies().ToList().Where(Function(x) Not x.Name.StartsWith("Microsoft")).ToList.Where(Function(x) Not x.Name.StartsWith("System")).ToList
        For Each zName As AssemblyName In zAssemblyNames
            _TypeAssembly = Assembly.Load(zName.FullName)
            _Type = _TypeAssembly.GetTypes().ToList.Find(Function(x) x.Name = pTypeName)

            If IsNothing(_Type) Then
                _TypeAssembly = Nothing
                _Type = Nothing
            Else
                Exit For
            End If

        Next
    End Sub

    Public Function GetReturnType() As System.Type
        Return _Type
    End Function

End Class

