Namespace razor
    Public Class tblMetaParameter
        'Public Enum Parameters
        '    Currency = 1
        '    Unit = 2
        '    FileNo = 4
        '    FilePrefix = 12
        '    Country = 13
        '    Division = 14
        '    CustomAccess = 15
        '    Language = 16
        '    ImpairmentStartDate = 17
        '    ImpairmentEndDate = 18
        '    InspectionProgramYear = 19
        '    TIV = 20
        '    RecStatus = 22
        '    Hazard = 23
        '    TIVValue = 24
        '    AutoRequest = 30
        'End Enum

        <Flags>
        Public Enum ParameterFlags
            None = 0
            Currency = 1
            Unit = 2
            FileNo = 4
            FilePrefix = 8
            Country = 16
            Division = 32
            CustomAccess = 64
            Language = 128
            ImpairmentStartDate = 256
            ImpairmentEndDate = 512
            InspectionProgramYear = 1024
            TIV = 2048
            RecStatus = 4096
            Hazard = 8192
            TIVValue = 16384
            AutoRequest = 32768
        End Enum

        Public Enum ParameterTypes
            Filter = 1
            Setting = 2
        End Enum

        Public Shared Function ParameterFlagDictionary() As Dictionary(Of Integer, ParameterFlags)
            Dim zParmFlags() As Integer = [Enum].GetValues(GetType(ParameterFlags))
            Dim zReturn As New Dictionary(Of Integer, ParameterFlags)
            For Each zParmFlag In zParmFlags
                zReturn.Add(zParmFlag, zParmFlag)
            Next
            Return zReturn
        End Function

        Public Shared Function GetSettingParameters() As List(Of rowTblMetaParameter)
            Dim zMetaParameters As List(Of rowTblMetaParameter) = tblMetaParameter.LoadData
            Dim zList As New List(Of rowTblMetaParameter)
            For Each zMetaParameter As rowTblMetaParameter In zMetaParameters
                If zMetaParameter.colFldParameterKindId = ParameterTypes.Setting Then
                    zList.Add(zMetaParameter)
                End If
            Next
            Return zList
        End Function

        Public Shared Function GetFilterParameters() As List(Of rowTblMetaParameter)
            Dim zMetaParameters As List(Of rowTblMetaParameter) = tblMetaParameter.LoadData
            Dim zList As New List(Of rowTblMetaParameter)
            For Each zMetaParameter As rowTblMetaParameter In zMetaParameters
                If zMetaParameter.colFldParameterKindId = ParameterTypes.Filter Then
                    zList.Add(zMetaParameter)
                End If
            Next
            Return zList
        End Function
    End Class
End Namespace

