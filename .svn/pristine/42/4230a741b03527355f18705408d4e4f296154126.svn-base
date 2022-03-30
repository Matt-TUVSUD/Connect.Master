Public Class PMPolicyValueSubReport_NewProject
    Inherits PMPolicyValueSubReport

    Public Sub New()
        MyBase.New()

        'RESET BINDINGS FROM INSPECTIONREQUEST OBJECT
        Me.uxFileNo.Value = "=fldFileNo"
        Me.uxClient.Value = "=fldClientName"
        Me.uxClientLocNo.Value = "=FldClientLocNo"
        Me.uxDivision.Value = "=FldDivision"
        Me.uxFacility.Value = "=FldFacility"
        Me.uxCustomAccess.Value = ""
        Me.uxAddress1.Value = "=FldAddress"
        Me.uxAddress2.Value = "=FldAddress1"
        Me.uxAddress3.Value = "=FldAddress2"
        Me.uxCity.Value = "=fldCity"
        Me.uxStProv.Value = "=FldStProv"
        Me.uxCountry.Value = "=FldCountry"
        Me.uxZip.Value = "=FldZip"
        Me.uxEffectiveDate.Value = "=FldValEffectDate"
        Me.uxCurrencyCode.Value = "=FldValCurrencyCode"
        Me.uxPDBldg.Value = "=FldValPdBldg"
        Me.uxPDEquip.Value = "=FldValPdMachineEq"
        Me.uxPDStock.Value = "=FldValPdStock"
        Me.uxPDRawStock.Value = "=FldValPdRawStock"
        Me.uxPDBldgRisk.Value = "=FldValPdBldgRisk"
        Me.uxPDMisc.Value = "=FldValPdMisc"
        Me.uxPDTotalLocalValue.Value = "=FldValPdTotal"
        Me.uxBIProfit.Value = "=FldValBiGrossProfit"
        Me.uxBIWage.Value = "=FldValBiWage"
        Me.uxBIMisc.Value = "=FldValBiMisc"
        Me.uxBIOther.Value = "=FldValBiOther"
        Me.uxBITotalLocalValue.Value = "=FldValBiTotal"

        Me.uxLocationPolicyHeadingPanel.Visible = True

        'Me.Groups(0).Groupings(0).Expression = "=FldFileNo"
        'Me.ReportParameters(0).Name = "FileNo"
        'Me.ReportParameters(0).Value = "=fldFileNo"
        'Me.Filters(0).Expression = "FldFileNo"
        'Me.Filters(0).Value = "=FldFileNo"

        Me.Groups.Clear()
        Me.Filters.Clear()
        Me.ReportParameters.Clear()

    End Sub

    Private Sub PMPolicyValueSuppliedSubReport_NeedDataSource(sender As Object, e As EventArgs) Handles Me.NeedDataSource
        Dim zParentReport As PMReport = DirectCast(DirectCast(sender, Telerik.Reporting.Processing.Report).ParentElement, Telerik.Reporting.Processing.SubReport).Report.ItemDefinition
        Me.DataSource = zParentReport.ReportDataSource.PolicyValuesNewProject
    End Sub

End Class
