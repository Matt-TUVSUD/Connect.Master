Imports GRC.Connect.Libraries.DataLib.razor

Partial Class UtilBatchProcess
    Public Class Report

        Public Function GenerateReport(pSetItem As BatchSetItem) As Byte()

            Dim zMetaReport As rowTblMetaReport = pSetItem.MetaObject
            Dim zReturn(0) As Byte  'INIT WITH EMPTY BYTE ARRAY

            Select Case zMetaReport.Vendor

                Case TblMetaReportVendor.Vendors.GrapeCity, TblMetaReportVendor.Vendors.Telerik

                    Dim zProps As ReportProperties = UtilBatchProcess.ReportProperties.GetProperties(pSetItem)

                    If zMetaReport.colFldTypeName = "" Then Throw New ArgumentException("MetaReport [" & zMetaReport.colFldName & "] is missing type name.")
                    If zMetaReport.colFldSourceId = 0 Then Throw New ArgumentException("MetaReport [" & zMetaReport.colFldName & "] is missing source id.")

                    Dim zUtilReport As New UtilReport

                    Dim zType As Type = Nothing
                    Try
                        zType = zUtilReport.GetType.Assembly.GetType(zMetaReport.colFldTypeName, False, True)
                    Catch ex As Exception
                        Throw New ApplicationException("Exception creating type in UtilBatchProcess.Report.GenerateReport. [" & zMetaReport.colFldTypeName & "]", ex)
                    End Try

                    If Not IsNothing(zType) Then

                        Dim zIReport As IUtilReport = zUtilReport.CreateReportObject(zType)
                        zIReport.rptProperties = zProps

                        UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Generating Report: " & pSetItem.MetaObject.colfldName)

                        If zMetaReport.Vendor = TblMetaReportVendor.Vendors.Telerik Then zReturn = zUtilReport.GenerateTelerikReport(zIReport)
                        If zMetaReport.Vendor = TblMetaReportVendor.Vendors.GrapeCity Then zReturn = zUtilReport.GenerateActiveReport(zIReport)

                        UtilBatchProcess.WriteLog(pSetItem.colFldSetId, "Report Generated Successfully [" & zReturn.Length & " bytes]")

                    Else
                        Dim zArgEx = New ArgumentException("Batch process could not locate report type [" & zMetaReport.colFldTypeName & "].", "tblMetaReport.fldTypeName")
                        Throw zArgEx
                    End If

                Case TblMetaReportVendor.Vendors.GRC
                    Dim IReport As IExternalReport = Activator.CreateInstance(Type.GetType(zMetaReport.colFldTypeName))
                    Return IReport.RunReport(pSetItem)

                Case TblMetaReportVendor.Vendors.Web
                    zReturn = GenerateChart(pSetItem)

                Case Else
                    Throw New ArgumentException("Missing vendor for meta report [" & zMetaReport.colFldName & "].", "TblMetaReport.fldVendor")

            End Select

            Return zReturn

        End Function

    End Class
End Class

