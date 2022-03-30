Imports System.ComponentModel
Imports System.Drawing
Imports Telerik.Reporting
Imports Telerik.Reporting.Drawing

Partial Public Class QorReport
	Inherits BaseReportPortrait
    Implements ITelerikReport
    Implements IUtilReport

    Public Sub New()
        MyBase.New()
        InitializeComponent()
        UtilReport.TelerikReport.FixBaseGroups(Me)
    End Sub

    Public SubReportDS As DataSet

    Public Function IsStandardHeader() As Boolean Implements ITelerikReport.IsStandardHeader
        Return True
    End Function

    Public Function ReportSubSubTitle() As String Implements ITelerikReport.ReportSubSubTitle
        Return ""
    End Function

    Public Function ReportSubTitle() As String Implements ITelerikReport.ReportSubTitle
        Return ""
    End Function

    Public Function ReportTitle() As String Implements ITelerikReport.ReportTitle
        Return "Quality of Risk Scorecard"
    End Function

    Public Function AppendPracticeToTitle() As Boolean Implements ITelerikReport.AppendPracticeToTitle
        Return True
    End Function

    Public Property rptProperties As IBatchSetReportProperties Implements IUtilReport.rptProperties

    Private Sub QorReport_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        SubReportDS = GetDataSource()

        RSBPFacilitySubReport.rptProperties = rptProperties
        RSBPFacilitySubReport.rptDS = SubReportDS
        RSBPFacilitySubReport.rptQorFilter = QorFilter.BMRSBP

        RSBPFireRecommendations.rptProperties = rptProperties
        RSBPFireRecommendations.rptDS = SubReportDS
        RSBPFireRecommendations.rptQorFilter = QorFilter.FIRERSBP

        CIMSubReport.rptProperties = rptProperties
        CIMSubReport.rptDS = SubReportDS
        CIMSubReport.rptQorFilter = QorFilter.FIRECIM

        OOASubReport.rptProperties = rptProperties
        OOASubReport.rptDS = SubReportDS
        OOASubReport.rptQorFilter = QorFilter.FIREOOA

        EcroSubReport.rptProperties = rptProperties
        EcroSubReport.rptDS = SubReportDS
        EcroSubReport.rptQorFilter = QorFilter.FIREECRO

        ISCSubReport.rptProperties = rptProperties
        ISCSubReport.rptDS = SubReportDS
        ISCSubReport.rptQorFilter = QorFilter.FIREISC

        ITPSubReport.rptProperties = rptProperties
        ITPSubReport.rptDS = SubReportDS
        ITPSubReport.rptQorFilter = QorFilter.FIREITP

        NPR10SubReport.rptProperties = rptProperties
        NPR10SubReport.rptDS = SubReportDS
        NPR10SubReport.rptQorFilter = QorFilter.FIRENPR10

        NPR5SubReport.rptProperties = rptProperties
        NPR5SubReport.rptDS = SubReportDS
        NPR5SubReport.rptQorFilter = QorFilter.FIRENPR5

        NPR0SubReport.rptProperties = rptProperties
        NPR0SubReport.rptDS = SubReportDS
        NPR0SubReport.rptQorFilter = QorFilter.FIRENPR0

        NSR0SubReport.rptProperties = rptProperties
        NSR0SubReport.rptDS = SubReportDS
        NSR0SubReport.rptQorFilter = QorFilter.BMNSR0

        NSR5SubReport.rptProperties = rptProperties
        NSR5SubReport.rptDS = SubReportDS
        NSR5SubReport.rptQorFilter = QorFilter.BMNSR5

        NSR10SubReport.rptProperties = rptProperties
        NSR10SubReport.rptDS = SubReportDS
        NSR10SubReport.rptQorFilter = QorFilter.BMNSR10

        OTOSubReport.rptProperties = rptProperties
        OTOSubReport.rptDS = SubReportDS
        OTOSubReport.rptQorFilter = QorFilter.BMOTO

        MEMSubReport.rptProperties = rptProperties
        MEMSubReport.rptDS = SubReportDS
        MEMSubReport.rptQorFilter = QorFilter.BMMEM

        EEMSubReport.rptProperties = rptProperties
        EEMSubReport.rptDS = SubReportDS
        EEMSubReport.rptQorFilter = QorFilter.BMEEM

        BPVMSubReport.rptProperties = rptProperties
        BPVMSubReport.rptDS = SubReportDS
        BPVMSubReport.rptQorFilter = QorFilter.BMBVPM

    End Sub

    Private Sub Me_ItemDataBinding(sender As Object, e As EventArgs) Handles Me.ItemDataBinding
        UtilReport.TelerikReport.SetFilterText(sender, rptProperties)
        UtilReport.TelerikReport.SetDisclaimerText(sender, rptProperties)
        UtilReport.TelerikReport.SetSortText(sender, rptProperties)
    End Sub

    Private Function GetDataSource() As DataSet
        Dim zCon As New SqlClient.SqlConnection(rptProperties.ConnectionString)
        Dim zCmd As New SqlClient.SqlCommand(BuildSQL, zCon)
        Dim zDS As New DataSet
        zCon.Open()
        Using zCon
            Using zCmd
                zDS.Load(zCmd.ExecuteReader, LoadOption.OverwriteChanges, [Enum].GetNames(GetType(QorFilter)))
            End Using
        End Using
        Return zDS
    End Function

    Public Enum QorFilter
        BMRSBP = 10
        BMOTO = 11
        BMNSR5 = 12
        BMNSR10 = 13
        BMNSR0 = 14
        BMMEM = 15
        BMEEM = 16
        BMBVPM = 17
        FIREOOA = 50
        FIRERSBP = 51
        FIRENPR0 = 52
        FIRENPR5 = 53
        FIRENPR10 = 54
        FIREITP = 55
        FIREISC = 56
        FIREECRO = 57
        FIRECIM = 58
    End Enum

    Private Function GetSQL(dataType As QorFilter) As String
        Dim zSB As New System.Text.StringBuilder

        Select Case dataType
            Case QorFilter.BMBVPM
                With zSB
                    .Append(GetSelectStatement() & ", 'BVPM' FROM [BM-RECOMMENDATIONS] WHERE ")
                    .Append("RecStatus IN ('Outstanding','In Progress') ")
                    .Append("AND PrimaryRecType = 'Boilers/Pressure Vessels/Tanks' ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND LEFT (LossExpectancyBefore, 2) =14 ")
                    .Append("AND FILENO LIKE '2061.%' ")
                    .Append("UNION ")
                    .Append(GetSelectStatement() & ", 'BVPM' FROM [BM-RECOMMENDATIONS] WHERE ")
                    .Append("RecStatus IN ('Outstanding','In Progress') ")
                    .Append("AND PrimaryRecType = 'Production/Process Equipment' ")
                    .Append("AND SecondaryRecType IN ('Furnaces','Kilns/Dryers','Proc. Piping (Not Steam)') ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND LEFT (LossExpectancyBefore, 2) =14 ")
                    .Append("AND FILENO LIKE '2061.%' ")
                End With

                Return zSB.ToString

            Case QorFilter.BMEEM
                With zSB
                    .Append(GetSelectStatement() & ", 'EEM' FROM [BM-RECOMMENDATIONS] WHERE ")
                    .Append("RecStatus IN ('Outstanding','In Progress') ")
                    .Append("AND PrimaryRecType = 'Elec. Prevent/Predict Maint.' ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND FILENO LIKE '2061.%' ")
                    .Append("UNION ")
                    .Append(GetSelectStatement() & ", 'EEM' FROM [BM-RECOMMENDATIONS] WHERE ")
                    .Append("RecStatus IN ('Outstanding','In Progress') ")
                    .Append("AND PrimaryRecType = 'Electrical Systems' ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND LEFT (LossExpectancyBefore, 2) =14 ")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With

                Return zSB.ToString

            Case QorFilter.BMMEM
                With zSB
                    .Append(GetSelectStatement() & ", 'MEM' FROM [BM-RECOMMENDATIONS] WHERE ")
                    .Append("RecStatus IN ('Outstanding','In Progress') ")
                    .Append("AND PrimaryRecType IN ('Mech. Prevent/Predict Maint.','Mechanical Systems') ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND LEFT (LossExpectancyBefore, 2) =14 ")
                    .Append("AND FILENO LIKE '2061.%' ")
                    .Append("UNION ")
                    .Append(GetSelectStatement() & ", 'MEM' FROM [BM-RECOMMENDATIONS] WHERE ")
                    .Append("RecStatus IN ('Outstanding','In Progress') ")
                    .Append("AND PrimaryRecType = 'Production/Process Equipment' ")
                    .Append("AND SecondaryRecType NOT IN ('Furnaces','Kilns/Dryers','Proc. Piping (Not Steam)') ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND LEFT (LossExpectancyBefore, 2) =14 ")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With

                Return zSB.ToString

            Case QorFilter.BMNSR0
                With zSB
                    .Append(GetSelectStatement() & ", 'NSR0' FROM [BM-RECOMMENDATIONS] WHERE ")
                    .Append("(RecStatus IN ('Outstanding','In Progress') OR (RecStatus='Rptd Completed' AND (MgmtRespAction NOT LIKE '%QoR Credit Approved%' OR MgmtRespAction IS NULL))) ")
                    .Append("AND PrimaryRecType IN ('Business Continuity Planning','Critical Spares') ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND FILENO LIKE '2061.%' ")
                    .Append("UNION ")
                    .Append(GetSelectStatement() & ", 'NSR0' FROM [BM-RECOMMENDATIONS] WHERE ")
                    .Append("(RecStatus IN ('Outstanding','In Progress') OR (RecStatus='Rptd Completed' AND (MgmtRespAction NOT LIKE '%QoR Credit Approved%' OR MgmtRespAction IS NULL))) ")
                    .Append("AND PrimaryRecType IN ('Boilers/Pressure Vessels/Tanks','Computer Systems','Electrical Systems','Mech. Prevent/Predict Maint.','Mechanical Systems','Production/Process Equipment') ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND LEFT (LossExpectancyBefore, 2) IN ('01', '02', '03', '04', '05')")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With

                Return zSB.ToString

            Case QorFilter.BMNSR10
                With zSB
                    .Append(GetSelectStatement() & ", 'NSR10' FROM [BM-RECOMMENDATIONS] WHERE ")
                    .Append("(RecStatus IN ('Outstanding','In Progress') OR (RecStatus='Rptd Completed' AND (MgmtRespAction NOT LIKE '%QoR Credit Approved%' OR MgmtRespAction IS NULL))) ")
                    .Append("AND PrimaryRecType IN ('Boilers/Pressure Vessels/Tanks','Computer Systems','Electrical Systems','Mech. Prevent/Predict Maint.','Mechanical Systems','Production/Process Equipment') ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND LEFT (LossExpectancyBefore, 2) IN ('07', '08', '09', '10', '11','12','13')")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With
                Return zSB.ToString

            Case QorFilter.BMNSR5
                With zSB
                    .Append(GetSelectStatement() & ", 'NSR5' FROM [BM-RECOMMENDATIONS] WHERE ")
                    .Append("(RecStatus IN ('Outstanding','In Progress') OR (RecStatus='Rptd Completed' AND (MgmtRespAction NOT LIKE '%QoR Credit Approved%' OR MgmtRespAction IS NULL))) ")
                    .Append("AND PrimaryRecType IN ('Boilers/Pressure Vessels/Tanks','Computer Systems','Electrical Systems','Mech. Prevent/Predict Maint.','Mechanical Systems','Production/Process Equipment') ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND LEFT (LossExpectancyBefore, 2) IN ('06') ")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With

                Return zSB.ToString


            Case QorFilter.BMOTO
                With zSB
                    .Append(GetSelectStatement() & ", 'OTO' FROM [BM-RECOMMENDATIONS] WHERE ")
                    .Append("RecStatus IN ('Outstanding','In Progress') ")
                    .Append("AND PrimaryRecType IN ('Human Element') ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With

                Return zSB.ToString

            Case QorFilter.BMRSBP
                With zSB
                    .Append(GetSelectStatement() & ", 'RSBP' FROM [BM-RECOMMENDATIONS] WHERE ")
                    .Append("RecStatus IN ('Outstanding','In Progress') ")
                    .Append("AND RecKeyWords LIKE ('%RSBP%') ")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With

                Return zSB.ToString


            Case QorFilter.FIRECIM

                With zSB
                    .Append(GetSelectStatement() & ", 'CIM' FROM [FIRE-RECOMMENDATIONS] WHERE ")
                    .Append("RecStatus IN ('Outstanding','In Progress') ")
                    .Append("AND PrimaryRecType IN ('Human Element') ")
                    .Append("AND SecondaryRecType IN ('Impairments', 'Mgmt. of Change') ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND LEFT(LossExpectancyBefore,2)  IN ('01', '02', '03', '04', '05', '14') ")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With

                Return zSB.ToString

            Case QorFilter.FIREECRO

                With zSB
                    .Append(GetSelectStatement() & ", 'ECRO' FROM [FIRE-RECOMMENDATIONS] WHERE ")
                    .Append("RecStatus IN ('Outstanding','In Progress') ")
                    .Append("AND PrimaryRecType = 'BCP' ")
                    .Append("AND SecondaryRecType IN ('BCP/DRP') ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND LEFT(LossExpectancyBefore,2) IN ('01','02','03','04','05','14') ")
                    .Append("AND FILENO LIKE '2061.%' ")
                    .Append("UNION ")
                    .Append(GetSelectStatement() & ", 'ECRO' FROM [FIRE-RECOMMENDATIONS] WHERE ")
                    .Append("RecStatus IN ('Outstanding','In Progress') ")
                    .Append("AND PrimaryRecType IN ('Human Element') ")
                    .Append("AND SecondaryRecType IN ('Emerg. Response') ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND LEFT(LossExpectancyBefore,2)  IN ('01', '02', '03', '04', '05','14')")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With

                Return zSB.ToString

            Case QorFilter.FIREISC

                With zSB
                    .Append(GetSelectStatement() & ", 'ISC' FROM [FIRE-RECOMMENDATIONS] WHERE ")
                    .Append("RecStatus IN ('Outstanding','In Progress') ")
                    .Append("AND PrimaryRecType = 'Human Element' ")
                    .Append("AND SecondaryRecType IN ('Hot Work','IR Testing','Smoking Controls') ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND LEFT(LossExpectancyBefore,2)  IN ('01','02','03','04','05','14') ")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With

                Return zSB.ToString

            Case QorFilter.FIREITP
                With zSB
                    .Append(GetSelectStatement() & ", 'ITP' FROM [FIRE-RECOMMENDATIONS] WHERE ")
                    .Append("RecStatus IN ('Outstanding','In Progress') ")
                    .Append("AND PrimaryRecType = 'Human Element' ")
                    .Append("AND SecondaryRecType IN ('Comb. Safety Testing', 'Other HE', 'Other Maint/Testing', 'Self-Inspections', 'Sprink/Supply Testing') ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND LEFT(LossExpectancyBefore,2)  IN ('01','02','03','04','05','14') ")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With

                Return zSB.ToString

            Case QorFilter.FIRENPR0

                With zSB
                    .Append(GetSelectStatement() & ", 'NPR0' FROM [FIRE-RECOMMENDATIONS] WHERE ")
                    .Append("(RecStatus IN ('Outstanding','In Progress') OR (RecStatus='Rptd Completed' AND (MgmtRespAction NOT LIKE '%QoR Credit Approved%' OR MgmtRespAction IS NULL))) ")
                    .Append("AND PrimaryRecType = 'Human Element' ")
                    .Append("AND SecondaryRecType IN ('Watch Service') ")
                    .Append("AND RecKeyWords NOT LIKE ('%RSBP%') ")
                    .Append("AND LEFT(LossExpectancyBefore,2) IN ('01','02','03','04','05','14') ")
                    .Append("AND FILENO LIKE '2061.%' ")
                    .Append("UNION ")
                    .Append(GetSelectStatement() & ", 'NPR0' FROM [FIRE-RECOMMENDATIONS] WHERE ")
                    .Append("(RecStatus IN ('Outstanding','In Progress') OR (RecStatus='Rptd Completed' AND (MgmtRespAction NOT LIKE '%QoR Credit Approved%' OR MgmtRespAction IS NULL))) ")
                    .Append("AND PrimaryRecType IN ('Surveillance') ")
                    .Append("AND RecKeyWords Not Like('%RSBP%') ")
                    .Append("AND FILENO LIKE '2061.%' ")
                    .Append("UNION ")
                    .Append(GetSelectStatement() & ", 'NPR0' FROM [FIRE-RECOMMENDATIONS] WHERE ")
                    .Append("(RecStatus IN ('Outstanding','In Progress') OR (RecStatus='Rptd Completed' AND (MgmtRespAction NOT LIKE '%QoR Credit Approved%' OR MgmtRespAction IS NULL))) ")
                    .Append("AND PrimaryRecType IN ('Water Supply', 'Manual Prot.', 'Nat. Haz/Exp.', 'Spec. Hazards', 'Sprinklers') ")
                    .Append("AND RecKeyWords Not Like('%RSBP%') ")
                    .Append("AND LEFT(LossExpectancyBefore,2)  IN ('01', '02', '03', '04', '05','14') ")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With

                Return zSB.ToString

            Case QorFilter.FIRENPR10
                With zSB
                    .Append(GetSelectStatement() & ", 'NPR10' FROM [FIRE-RECOMMENDATIONS] WHERE ")
                    .Append("(RecStatus IN ('Outstanding','In Progress') OR (RecStatus='Rptd Completed' AND (MgmtRespAction NOT LIKE '%QoR Credit Approved%' OR MgmtRespAction IS NULL))) ")
                    .Append("AND PrimaryRecType IN('Manual Prot.', 'Nat. Haz/Exp.', 'Spec. Hazards', 'Sprinklers', 'Water Supply', 'Human Element') ")
                    .Append("AND RecKeyWords Not Like('%RSBP%') ")
                    .Append("AND LEFT(LossExpectancyBefore,2)  IN ('07', '08', '09', '10', '11', '12', '13') ")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With

                Return zSB.ToString

            Case QorFilter.FIRENPR5

                With zSB
                    .Append(GetSelectStatement() & ", 'NPR5' FROM [FIRE-RECOMMENDATIONS] WHERE ")
                    .Append("(RecStatus IN ('Outstanding','In Progress') OR (RecStatus='Rptd Completed' AND (MgmtRespAction NOT LIKE '%QoR Credit Approved%' OR MgmtRespAction IS NULL))) ")
                    .Append("AND PrimaryRecType IN ('Manual Prot.', 'Nat. Haz/Exp.', 'Spec. Hazards', 'Sprinklers', 'Water Supply', 'Human Element', 'Surveillance') ")
                    .Append("AND RecKeyWords Not Like('%RSBP%') ")
                    .Append("AND LEFT(LossExpectancyBefore,2)  IN ('06') ")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With

                Return zSB.ToString

            Case QorFilter.FIREOOA

                With zSB
                    .Append(GetSelectStatement() & ", 'OOA' FROM [FIRE-RECOMMENDATIONS] WHERE ")
                    .Append("RecStatus IN ('Outstanding','In Progress') ")
                    .Append("AND PrimaryRecType In('Human Element') ")
                    .Append("AND SecondaryRecType IN('Housekeeping', 'Storage Configuration') ")
                    .Append("AND RecKeyWords Not Like('%RSBP%') ")
                    .Append("AND LEFT(LossExpectancyBefore,2) IN ('01', '02', '03', '04', '05', '14') ")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With

                Return zSB.ToString

            Case QorFilter.FIRERSBP

                With zSB
                    .Append(GetSelectStatement() & ", 'RSBP' FROM [FIRE-RECOMMENDATIONS] WHERE ")
                    .Append("RecStatus IN ('Outstanding','In Progress') ")
                    .Append("AND RecKeyWords Like('%RSBP%') ")
                    .Append("AND FILENO LIKE '2061.%' ")

                End With

                Return zSB.ToString

        End Select

        Return ""

    End Function

    Private Function GetSelectStatement() As String
        Dim zSB As New System.Text.StringBuilder
        zSB.Append("SELECT FILENO, (COALESCE(CAST(RecYear as NVARCHAR(50)),'') + ' -' + ")
        zSB.Append("COALESCE(RecMonth,'') + ' -'  + ")
        zSB.Append("COALESCE(CAST(RecNumber AS NVARCHAR(50)),'') + ' -'  + ")
        zSB.Append("COALESCE(RecSubletter,'') + ")
        zSB.Append("(PrimaryRecType + '\' + SecondaryRecType) + ")
        zSB.Append("RecKeywords) as Rec")
        Return zSB.ToString
    End Function


    Private Function BuildSQL() As String
        Dim zSB As New System.Text.StringBuilder
        Dim zEnumValues() As QorFilter = [Enum].GetValues(GetType(QorFilter))
        For Each zSubReport As QorFilter In zEnumValues
            zSB.Append(GetSQL(zSubReport) & " ")
        Next

        Return zSB.ToString

    End Function



End Class