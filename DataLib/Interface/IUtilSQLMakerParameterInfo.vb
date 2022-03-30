Public Interface IUtilSQLMakerParameterInfo

    Property Currency As TblMetaCurrency.Currencies
    Property Unit As TblMetaUnitSystem.Systems
    Property FileNo As String
    Property FilePrefix As String
    Property Country As String
    Property Division As String
    Property CustomAccess As String
    Property Language As TblMetaLanguage.Languages
    Property ImpairmentStartDate As String
    Property ImpairmentEndDate As String
    Property InspectionProgramYear As String
    Property TIV As String
    Property RecStatus As String
    Property Hazard As String
    Property TIVValue As TblMetaTIV.TIVRanges
    Property AutoRequest As String
    Property RequiredFlag As Int32
    Sub SetValue(zParameterFlag As TblMetaParameter.ParameterFlags, pValue As Object)
    Function GetValue(zParameterFlag As TblMetaParameter.ParameterFlags) As Object
End Interface
