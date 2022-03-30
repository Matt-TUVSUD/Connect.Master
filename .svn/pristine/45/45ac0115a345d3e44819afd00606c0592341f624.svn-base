Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.CoreLib.UtilConstants
Imports GRC.Connect.Libraries.CoreLib.UtilGSafe
Imports GRC.Connect.Libraries.CoreLib.UtilSafe
Imports GRC.Connect.Libraries.CoreLib.UtilPractice
Imports GRC.Connect.Libraries.CoreLib.UtilValidate
Imports GRC.Connect.Libraries.CoreLib.UtilMeta
Imports System.Web
Imports System.Web.Services
Imports GRC.Connect.Libraries.DataLib.razor

Public Class PSDirect
    Implements System.Web.IHttpHandler

    Sub ProcessRequest(ByVal context As HttpContext) Implements IHttpHandler.ProcessRequest
        Dim zGUID As String = GetGUIDFromQueryString()
        Dim zSafeId As String = GetId(zGUID) & ""


        ' GET THE MODE OF THE DIRECTOR directMode
        Dim zDirectMode As String = "programstatus"
        If Not context.Request.QueryString("directMode") Is Nothing Then
            zDirectMode = context.Request.QueryString("directMode")
        End If

        ' GET THE DirectId INFOMRATION
        Dim zDirectId As String = "0"
        If Not context.Request.QueryString("directId") Is Nothing Then
            zDirectId = context.Request.QueryString("directId")
        End If

        ' GET THE TARGET FOLDER INFORMATION
        Dim zTargetName As String = "Standard"
        If Not context.Request.QueryString("targetPageName") Is Nothing Then
            zTargetName = context.Request.QueryString("targetPageName")
        End If

        Dim zBD As New PSDirector
        zBD.PropDirectId = zDirectId
        zBD.BuildDirector()

        ' GET OPTIONAL CURRENCY INFORMAITON
        Dim zUserCurrencyIdParm As String = ""
        If Not context.Request.QueryString("userCurrencyId") Is Nothing Then
            zBD.PropUserCurrencyId = CInt(context.Request.QueryString("userCurrencyId") & "")
            zUserCurrencyIdParm = "&userCurrencyId=" & zBD.PropUserCurrencyId
        Else
            'ResetLargeObjectData_ByObjectName(zSafeId, LargeObjectName.userCurrencyId)
            'SetValue(zGUID, KeyName.ChartPreFilter_Currency, "", KeyNameGroup.ChartPreFilter)
        End If

        Select Case zDirectMode.ToLower()
            Case "chart"
                ' GET THE EXISTING CHART CRITERIA
                Dim zChartId As String = "0"
                If Not context.Request.QueryString("chartId") Is Nothing Then
                    zChartId = context.Request.QueryString("chartId")
                End If
                zBD.PropCriteria = LoadLargeObjectData_ByDataGroup(zSafeId, LargeObjectName.filterChart, zChartId)

                Dim zGDC As New UtilGDC
                Dim zPropFilePrefix As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.FilePreFix)
                zGDC.PropParameters.FilePrefix = zPropFilePrefix
                zGDC.PropSafeGUID = zGUID
                zBD.PropFilter = zGDC.FillReplacer(zBD.PropFilter)

            Case "programstatus"
                ' Process Division and CustomAccess settings
                Dim zDivision As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSDivision)
                Dim zCustomAccess As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSCustomAccess)
                Dim zCriteriaJSON As String = "{'logic':'and','filters':[@ConditionArray]}"
                Dim zConditionArray() As String
                Dim zNdx As Integer = -1
                ReDim zConditionArray(zNdx)
                If zDivision.Length > 0 Then
                    zNdx = zNdx + 1
                    ReDim Preserve zConditionArray(zNdx)
                    Dim zDivisionCriteria As String = Replace("{'field':'Division','operator':'eq','value':'@Division'}", "@Division", zDivision)
                    zConditionArray(zNdx) = zDivisionCriteria
                End If
                If zCustomAccess.Length > 0 Then
                    zNdx = zNdx + 1
                    ReDim Preserve zConditionArray(zNdx)
                    Dim zCustomAccessCriteria As String = Replace("{'field':'CustomAccess','operator':'eq','value':'@CustomAccess'}", "@CustomAccess", zCustomAccess)
                    zConditionArray(zNdx) = zCustomAccessCriteria
                End If
                If zNdx > -1 Then
                    zCriteriaJSON = Replace(zCriteriaJSON, "@ConditionArray", Join(zConditionArray, ","))
                    zBD.PropCriteria = zCriteriaJSON
                End If

                ' Set dynamic Filter values
                Dim zGDC As New UtilGDC
                Dim zValue As String = ""
                zGDC.PropSafeGUID = zGUID

                Select Case zBD.PropGridId
                    Case UtilMeta.GetMetaKey("FireLossEstimates", 86)
                        zValue = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSFireLowMFL)
                        zBD.PropFilter = zGDC.FillReplacerWithValue(zBD.PropFilter, "{{@LowMFL}}", zValue)
                    Case UtilMeta.GetMetaKey("BMLossEstimates", 85)
                        zValue = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSBoilerLowMFL)
                        zBD.PropFilter = zGDC.FillReplacerWithValue(zBD.PropFilter, "{{@LowMFL}}", zValue)
                    Case UtilMeta.GetMetaKey("BMFacilityRatingSummary", 24)
                        Select Case zBD.PropDirectId
                            Case UtilMeta.GetMetaKey("PSBoilerFacilityRatingSumLocsTop5Rating", 94)
                                zValue = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSBoilerTop5TotalScore)
                                zBD.PropFilter = zGDC.FillReplacerWithValue(zBD.PropFilter, "{{@Top5TotalScore}}", zValue)
                            Case UtilMeta.GetMetaKey("PSBoilerFacilityRatingSumLocsBottom5Rating", 95)
                                zValue = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSBoilerBottom5TotalScore)
                                zBD.PropFilter = zGDC.FillReplacerWithValue(zBD.PropFilter, "{{@Bottom5TotalScore}}", zValue)
                        End Select
                    Case UtilMeta.GetMetaKey("FireFacilityRatingSummary", 25)
                        Select Case zBD.PropDirectId
                            Case UtilMeta.GetMetaKey("PSFireFacilityRatingSumLocsTop5Rating", 86)
                                zValue = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSFireTop5TotalScore)
                                zBD.PropFilter = zGDC.FillReplacerWithValue(zBD.PropFilter, "{{@Top5TotalScore}}", zValue)
                            Case UtilMeta.GetMetaKey("PSFireFacilityRatingSumLocsBottom5Rating", 87)
                                zValue = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSFireBottom5TotalScore)
                                zBD.PropFilter = zGDC.FillReplacerWithValue(zBD.PropFilter, "{{@Bottom5TotalScore}}", zValue)
                        End Select
                    Case UtilMeta.GetMetaKey("JurisObjectInventory", 106)
                        Select Case zBD.PropDirectId
                            Case UtilMeta.GetMetaKey("JurisNoObjectsOverdue", 106)
                                zValue = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSCurrentDate)
                                zBD.PropFilter = zGDC.FillReplacerWithValue(zBD.PropFilter, "{{@CurrentDate}}", zValue)
                            Case UtilMeta.GetMetaKey("JurisNoObjects3059", 107) '30-59 Days
                                zValue = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSCurrentDateMinus30)
                                zBD.PropFilter = zGDC.FillReplacerWithValue(zBD.PropFilter, "{{@CurrentDateMinus30}}", zValue)
                                zValue = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSCurrentDateMinus60)
                                zBD.PropFilter = zGDC.FillReplacerWithValue(zBD.PropFilter, "{{@CurrentDateMinus60}}", zValue)
                            Case UtilMeta.GetMetaKey("JurisNoObjects6089", 108) '60-89 Days
                                zValue = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSCurrentDateMinus60)
                                zBD.PropFilter = zGDC.FillReplacerWithValue(zBD.PropFilter, "{{@CurrentDateMinus60}}", zValue)
                                zValue = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSCurrentDateMinus90)
                                zBD.PropFilter = zGDC.FillReplacerWithValue(zBD.PropFilter, "{{@CurrentDateMinus90}}", zValue)
                            Case UtilMeta.GetMetaKey("JurisNoObjects90", 109) '> 90 Days
                                zValue = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSCurrentDateMinus90)
                                zBD.PropFilter = zGDC.FillReplacerWithValue(zBD.PropFilter, "{{@CurrentDateMinus90}}", zValue)
                        End Select
                End Select

            Case "autorecstatus"
                ' Process Division and CustomAccess settings
                Dim zDivision As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSDivision)
                If zDivision = "" Then zDivision = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.RFDivision)
                Dim zCustomAccess As String = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.PSCustomAccess)
                If zCustomAccess = "" Then zCustomAccess = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.RFCustomAccess)

                Dim zCriteriaJSON As String = "{'logic':'and','filters':[@ConditionArray]}"
                Dim zConditionArray() As String
                Dim zNdx As Integer = -1
                ReDim zConditionArray(zNdx)
                If zDivision.Length > 0 Then
                    zNdx = zNdx + 1
                    ReDim Preserve zConditionArray(zNdx)
                    Dim zDivisionCriteria As String = Replace("{'field':'Division','operator':'eq','value':'@Division'}", "@Division", zDivision)
                    zConditionArray(zNdx) = zDivisionCriteria
                End If
                If zCustomAccess.Length > 0 Then
                    zNdx = zNdx + 1
                    ReDim Preserve zConditionArray(zNdx)
                    Dim zCustomAccessCriteria As String = Replace("{'field':'CustomAccess','operator':'eq','value':'@CustomAccess'}", "@CustomAccess", zCustomAccess)
                    zConditionArray(zNdx) = zCustomAccessCriteria
                End If
                If zNdx > -1 Then
                    zCriteriaJSON = Replace(zCriteriaJSON, "@ConditionArray", Join(zConditionArray, ","))
                    zBD.PropCriteria = zCriteriaJSON
                End If

                ' Set dynamic Filter values
                Dim zGDC As New UtilGDC
                Dim zValue As String = ""
                zGDC.PropSafeGUID = zGUID

                Select Case zBD.PropGridId   'All Recommendation Response Follow Up
                    Case UtilMeta.GetMetaKey("BMRecommendationResponsesFollowUpAllAll", 142), _
                         UtilMeta.GetMetaKey("FireNatHazRecommendationResponsesFollowUpAll", 146), _
                         UtilMeta.GetMetaKey("IRRecommendationResponsesFollowUpAll", 148), _
                         UtilMeta.GetMetaKey("NatHazFloodRecommendationResponsesFollowUpAll", 150), _
                         UtilMeta.GetMetaKey("NatHazSeismicRecommendationResponsesFollowUpAll", 152), _
                         UtilMeta.GetMetaKey("NatHazWindRecommendationResponsesFollowUpAll", 154), _
                         UtilMeta.GetMetaKey("NHRecommendationResponsesFollowUpAll", 285), _
                         UtilMeta.GetMetaKey("PSRecommendationResponsesFollowUpAllAll", 316), _
                         UtilMeta.GetMetaKey("PSRecommendationResponsesFollowUpAll", 316)
                        zValue = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.RFStartDate)
                        zBD.PropFilter = zGDC.FillReplacerWithValue(zBD.PropFilter, "{{@StartDate}}", zValue)
                        zValue = UtilGSafe.GetValue(zGUID, UtilGSafe.KeyName.RFEndDate)
                        zBD.PropFilter = zGDC.FillReplacerWithValue(zBD.PropFilter, "{{@EndDate}}", zValue)
                End Select

        End Select

        ' STORE THE CORRECT INFORMATION TO THE GSAFE AND RESET ANY OTHER INFORMATION
        SetValue(zGUID, KeyName.currentGridId, zBD.PropGridId, KeyNameGroup.Navigation)
        SaveLargeObjectData_ByDataGroup(zSafeId, LargeObjectName.criteria, zBD.PropCriteria, zBD.PropGridId)
        SaveLargeObjectData_ByDataGroup(zSafeId, LargeObjectName.filter, zBD.PropFilter, zBD.PropGridId)
        SaveLargeObjectData_ByDataGroup(zSafeId, LargeObjectName.sort, zBD.PropSort, zBD.PropGridId)

        'If zBD.PropUserCurrencyId > 0 Then
        '    'SaveLargeObjectData_ByDataGroup(zSafeId, LargeObjectName.userCurrencyId, zBD.PropUserCurrencyId, zBD.PropGridId)
        '    'SetValue(zGUID, KeyName.ChartPreFilter_Currency, zBD.PropUserCurrencyId, KeyNameGroup.ChartPreFilter)
        'Else
        '    'ResetLargeObjectData_ByObjectName(zSafeId, LargeObjectName.userCurrencyId)
        '    'SetValue(zGUID, KeyName.ChartPreFilter_Currency, "", KeyNameGroup.ChartPreFilter)
        'End If

        ' REDIRECT TO THE GRID PAGE
        Dim zURL As String = "~/Home_{{VER}}/Grids/" & zTargetName & "/" & zTargetName & ".aspx?sid=" & GetGUIDFromQueryString() & zUserCurrencyIdParm
        context.Response.Redirect(zURL, False)
    End Sub

    Private Class PSDirector
        Public PropDirectId As Integer = 0
        Public PropCriteria As String = ""
        Public PropFilter As String = ""
        Public PropSort As String = ""
        Public PropGridId As Integer = 0
        Public PropUserCurrencyId As Integer = 0

        Public Sub BuildDirector()
            Dim zPS As List(Of rowTblMetaProgramStatus) = TblMetaProgramStatus.LoadByIDX_DirectId(PropDirectId)

            If zPS.Count > 0 Then
                PropCriteria = zPS(0).colFldCriteria
                PropFilter = zPS(0).colFldFilter
                PropSort = zPS(0).colfldSort
                PropGridId = zPS(0).colFldGridId.GetValueOrDefault(0)
            Else
                PropCriteria = Nothing
                PropFilter = Nothing
                PropSort = Nothing
                PropGridId = 0
            End If
        End Sub

    End Class

    ReadOnly Property IsReusable() As Boolean Implements IHttpHandler.IsReusable
        Get
            Return False
        End Get
    End Property

End Class