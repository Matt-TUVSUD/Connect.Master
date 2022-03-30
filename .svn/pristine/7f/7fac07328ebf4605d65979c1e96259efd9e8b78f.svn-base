Imports System.Data.SqlClient

Namespace razor

    Partial Public Class TblMetaInspectionProgramYear

        Public Shared Function GetProgramRangeDate(pFilePrefix As String, pProgramYears As InspectionProgramYears) As ProgramRangeDate

            Dim zSQL As String = "Select InspProgramYearFROM FROM [sv].[vwInspProgramYear] WHERE FilePrefix=@FilePrefix"

            Dim zCmd As New SqlCommand
            Dim zFpParm As New SqlClient.SqlParameter("@FilePrefix", pFilePrefix)
            zCmd.CommandText = zSQL
            zCmd.CommandType = CommandType.Text
            zCmd.Parameters.Add(zFpParm)

            Dim zReturn As New ProgramRangeDate
            zReturn.ProgramYear = pProgramYears

            Select Case pProgramYears

                Case InspectionProgramYears.All, InspectionProgramYears.Latest

                    zReturn.StartDate = Now.AddYears(-100)
                    zReturn.EndDate = Now.AddYears(100)

                    If pProgramYears = InspectionProgramYears.Latest Then zReturn.GetLatest = True

                Case Else

                    zReturn.StartDate = razor.UtilSQLServer.ExecuteScalar(zCmd)  'GETS CURRENT
                    zReturn.EndDate = zReturn.StartDate.AddYears(1)

                    Select Case pProgramYears

                        Case InspectionProgramYears.Previous
                            zReturn.StartDate = zReturn.StartDate.AddYears(-1)
                            zReturn.EndDate = zReturn.StartDate.AddYears(1)

                        Case InspectionProgramYears.TwoPrevious
                            zReturn.StartDate = zReturn.StartDate.AddYears(-2)
                            zReturn.EndDate = zReturn.StartDate.AddYears(1)

                    End Select

            End Select

            Return zReturn

        End Function

        Public Enum InspectionProgramYears
            All = 1
            Latest = 2
            Current = 3
            Previous = 4
            TwoPrevious = 5
        End Enum

        Public Class ProgramRangeDate
            Public ProgramYear As InspectionProgramYears
            Public StartDate As DateTime
            Public EndDate As DateTime
            Public GetLatest As Boolean = False
        End Class

    End Class

    Partial Public Class rowTblMetaInspectionProgramYear

    End Class

End Namespace
