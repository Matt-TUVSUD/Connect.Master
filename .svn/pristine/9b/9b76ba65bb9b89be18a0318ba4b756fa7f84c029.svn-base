Imports GRC.Connect.Libraries.DataLib.razor

Partial Class UtilBatchProcess
    Public Class ReportProperties
        Implements IBatchSetReportProperties

        Public Shared Function GetProperties(pSetItem As BatchSetItem) As UtilBatchProcess.ReportProperties

            Dim zGDC As New UtilGDC
            zGDC.PropReportId = pSetItem.colFldMetaObjectId
            zGDC.PropReportSetId = pSetItem.colFldSetId
            zGDC.PropBatchSetId = pSetItem.colFldSetId
            zGDC.PropFilter = pSetItem.Parent.colFldLOFilterJSON '"{'logic':'and','filters':[{'logic':'or','filters':[{'field':'fileno','operator':'eq','value':'1001.0001'}]}]}"
            zGDC.PropSort = pSetItem.Parent.colFldLOSortJSON '"[{'field':'Engineer_Target','dir':'asc'}]"
            zGDC.PropCriteria = pSetItem.Parent.colFldLOCriteriaJSON
            zGDC.PropParameters = pSetItem.Parent.SetParameters

            Dim zProps As New UtilBatchProcess.ReportProperties
            zProps.SQL = zGDC.GetReportSQL
            zProps.FilterString = zGDC.PropFilterText
            zProps.SortString = zGDC.PropSortText
            zProps.MyFilterString = zGDC.PropCriteriaText
            zProps.Disclaimer = "This document is PROPRIETARY and CONFIDENTIAL.  If you are not the intended recipient, you are notified that any review, dissemination or distribution is prohibited. "
            zProps.Currency = TblMetaCurrency.LoadByPrimaryKey(pSetItem.Parent.SetParameters.Currency)
            zProps.Language = TblMetaLanguage.LoadByPrimaryKey(pSetItem.Parent.SetParameters.Language)
            zProps.ConnectionString = UtilSQLServer.ConnectionString
            zProps.MetaReport = pSetItem.MetaObject
            zProps.LossEstimates = TblMetaLossEstimate.LoadAll
            zProps.Colors = TblMetaColor.LoadAll()
            zProps.ClientRatingCategoryColors = TblClientMetaRatingCategoryColor.LoadData
            zProps.Practice = TblMetaPractice.LoadByPrimaryKey(zProps.MetaReport.colFldMetaPracticeId)
            zProps.ReportSourceJoin = tblMetaSourceJoin.LoadByPrimaryKey(tblMetaSourceJoin.Joins.ReportFileNo)
            zProps.GDC = zGDC
            SetClientSpecificValues(zProps, pSetItem.Parent.colFldFilePrefix)
            SetUnit(zProps, zGDC)

            Return zProps

        End Function

        Private Shared Sub SetClientSpecificValues(ByRef props As ReportProperties, pFilePrefix As String)

            Dim zClient As List(Of rowTblClients) = TblClients.LoadByIDX_PK_clients(pFilePrefix)
            If zClient.Count > 0 Then
                props.ClientName = zClient(0).colClientname
                props.BMRatingRange = VwMetaRatingKeyRange.LoadByKey(zClient(0).colBMRatingKeyID)
                props.FireRatingRange = VwMetaRatingKeyRange.LoadByKey(zClient(0).colFireRatingKeyID)
                props.FilePrefix = zClient(0).colFileprefix
                props.ClientSpecialFeatures = IIf(IsNothing(zClient(0).colFeatures), "", zClient(0).colFeatures)

                Dim zRecResponse As New RecResponseInfo
                If Not IsNothing(zClient(0).colRecfollowup1) Then zRecResponse.FirstFollowUpDays = zClient(0).colRecfollowup1
                If Not IsNothing(zClient(0).colRecfollowup2) Then zRecResponse.SecondFollowUpDays = zClient(0).colRecfollowup2
                If Not IsNothing(zClient(0).colRecfollowup3) Then zRecResponse.ThirdFollowUpDays = zClient(0).colRecfollowup3
                props.RecResponse = zRecResponse
            End If

        End Sub

        Private Shared Sub SetUnit(ByRef props As ReportProperties, gdc As UtilGDC)
            Dim zUnit As New UnitInfo
            zUnit.System = TblMetaUnitSystem.LoadByPrimaryKey(gdc.PropParameters.Unit)
            zUnit.Measurements = TblMetaUnitMeasurement.LoadData
            zUnit.Lookups = TblMetaUnitMeasurementLookup.LoadData
            props.Unit = zUnit

        End Sub


        Public Property BMRatingRange As List(Of rowVwMetaRatingKeyRange) Implements IBatchSetReportProperties.BMRatingRange

        Public Property ClientName As String Implements IBatchSetReportProperties.ClientName

        Public Property ClientSpecialFeatures As String Implements IBatchSetReportProperties.ClientSpecialFeatures

        Public Property Colors As List(Of rowTblMetaColor) Implements IBatchSetReportProperties.Colors

        Public Property ConnectionString As String Implements IBatchSetReportProperties.ConnectionString

        Public Property Currency As rowTblMetaCurrency Implements IBatchSetReportProperties.Currency

        Public Property Disclaimer As String Implements IBatchSetReportProperties.Disclaimer

        Public Property FilePrefix As String Implements IBatchSetReportProperties.FilePrefix

        Public Property FilterString As String Implements IBatchSetReportProperties.FilterString

        Public Property FireRatingRange As List(Of rowVwMetaRatingKeyRange) Implements IBatchSetReportProperties.FireRatingRange

        Public Property Language As rowTblMetaLanguage Implements IBatchSetReportProperties.Language

        Public Property LossEstimates As List(Of rowTblMetaLossEstimate) Implements IBatchSetReportProperties.LossEstimates

        Public Property MyFilterString As String Implements IBatchSetReportProperties.MyFilterString

        Public Property Practice As rowTblMetaPractice Implements IBatchSetReportProperties.Practice

        Public Property ReportSourceJoin As rowTblMetaSourceJoin Implements IBatchSetReportProperties.ReportSourceJoin

        Public Property SortString As String Implements IBatchSetReportProperties.SortString

        Public Property SQL As String Implements IBatchSetReportProperties.SQL

        Public Property MetaReport As rowTblMetaReport Implements IBatchSetReportProperties.MetaReport

        Public Property RecResponse As IBatchReportPropertiesRecResponse Implements IBatchSetReportProperties.RecResponse

        Public Property Unit As IBatchReportPropertiesUnit Implements IBatchSetReportProperties.Unit

        Public Property ClientRatingCategoryColors As List(Of rowTblClientMetaRatingCategoryColor) Implements IBatchSetReportProperties.ClientRatingCategoryColors

        Public Property GDC As UtilGDC Implements IBatchSetReportProperties.GDC
    End Class

End Class
