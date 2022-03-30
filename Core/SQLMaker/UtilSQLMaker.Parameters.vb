Imports GRC.Connect.Libraries.DataLib.razor

Partial Class UtilSQLMaker
    Public Class ParameterInfo
        Implements IUtilSQLMakerParameterInfo

        Public Property AutoRequest As String Implements IUtilSQLMakerParameterInfo.AutoRequest

        Public Property Country As String Implements IUtilSQLMakerParameterInfo.Country

        Public Property Currency As TblMetaCurrency.Currencies Implements IUtilSQLMakerParameterInfo.Currency

        Public Property CustomAccess As String Implements IUtilSQLMakerParameterInfo.CustomAccess

        Public Property Division As String Implements IUtilSQLMakerParameterInfo.Division

        Public Property FileNo As String Implements IUtilSQLMakerParameterInfo.FileNo

        Public Property FilePrefix As String Implements IUtilSQLMakerParameterInfo.FilePrefix

        Public Property Hazard As String Implements IUtilSQLMakerParameterInfo.Hazard

        Public Property ImpairmentEndDate As String Implements IUtilSQLMakerParameterInfo.ImpairmentEndDate

        Public Property ImpairmentStartDate As String Implements IUtilSQLMakerParameterInfo.ImpairmentStartDate

        Public Property InspectionProgramYear As TblMetaInspectionProgramYear.InspectionProgramYears Implements IUtilSQLMakerParameterInfo.InspectionProgramYear

        Public Property Language As TblMetaLanguage.Languages Implements IUtilSQLMakerParameterInfo.Language

        Public Property RecStatus As String Implements IUtilSQLMakerParameterInfo.RecStatus

        Public Property TIV As String Implements IUtilSQLMakerParameterInfo.TIV

        Public Property TIVValue As TblMetaTIV.TIVRanges Implements IUtilSQLMakerParameterInfo.TIVValue

        Public Property Unit As TblMetaUnitSystem.Systems Implements IUtilSQLMakerParameterInfo.Unit

        Public Property RequiredFlag As Integer Implements IUtilSQLMakerParameterInfo.RequiredFlag

        Public Sub New()
            'Init
            Me.Currency = TblMetaCurrency.Currencies.UsDollar
            Me.Language = TblMetaLanguage.Languages.English
            Me.Unit = TblMetaUnitSystem.Systems.English
            Me.Division = "%"
            Me.Country = "%"
            Me.FileNo = "%"
            Me.FilePrefix = ""
            Me.Hazard = "%"
            Me.ImpairmentStartDate = Today.AddYears(-100)
            Me.ImpairmentEndDate = Today.AddYears(100)
            Me.InspectionProgramYear = TblMetaInspectionProgramYear.InspectionProgramYears.Latest
            Me.RecStatus = "%"
            Me.TIV = "%"
            Me.TIVValue = TblMetaTIV.TIVRanges.All
            Me.AutoRequest = "%"
            Me.CustomAccess = "%"
        End Sub

        Private Function GetProperty(pMetaParameter As tblMetaParameter.ParameterFlags) As Reflection.PropertyInfo
            Dim zPropInfo As Reflection.PropertyInfo = Me.GetType.GetProperty(pMetaParameter.ToString)
            If IsNothing(zPropInfo) Then
                Throw New ApplicationException("System could not find property info [" & pMetaParameter.ToString & "] in the UtilSQLMaker.Parameters object.")
            Else
                Return zPropInfo
            End If
        End Function

        Public Function GetValue(pParameterFlag As tblMetaParameter.ParameterFlags) As Object Implements IUtilSQLMakerParameterInfo.GetValue
            Dim zPropInfo As Reflection.PropertyInfo = GetProperty(pParameterFlag)
            Return zPropInfo.GetValue(Me)
        End Function

        Public Sub SetValue(pParameterFlag As tblMetaParameter.ParameterFlags, pValue As Object) Implements IUtilSQLMakerParameterInfo.SetValue
            Dim zPropInfo As Reflection.PropertyInfo = GetProperty(pParameterFlag)
            zPropInfo.SetValue(Me, pValue)
        End Sub

        Public Sub ApplyLO(pLargeObject As String) Implements IUtilSQLMakerParameterInfo.ApplyLO
            If Not String.IsNullOrEmpty(pLargeObject) Then
                Dim zObj As Newtonsoft.Json.Linq.JObject = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Object)(pLargeObject)
                Dim zSettingParms As List(Of rowTblMetaParameter) = tblMetaParameter.LoadData
                For Each zSettingParm As rowTblMetaParameter In zSettingParms
                    Dim zToken As Newtonsoft.Json.Linq.JToken = Nothing
                    If zObj.TryGetValue(zSettingParm.colFldName, zToken) Then
                        Dim zTokenValue As Integer = zToken.ToString
                        Me.SetValue(zSettingParm.colFldFlagId, zTokenValue)
                    End If
                Next
            End If
        End Sub
    End Class
End Class
