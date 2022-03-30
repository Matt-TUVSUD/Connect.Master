Public Class ImportSheetResult
    Inherits Result

    Dim _SheetName As String = ""
    Dim _ImportTableResultList As New ImportTableResultList

    Public Sub New(ByVal pSheetName As String)
        _SheetName = pSheetName
    End Sub

    Public Overrides ReadOnly Property IsSuccessful As Boolean
        Get
            For Each zImportTableResult In _ImportTableResultList
                If Not zImportTableResult.IsSuccessful Then
                    Return False
                End If
            Next

            Return True

        End Get
    End Property

    Public Overrides ReadOnly Property Text As String
        Get
            Dim zTextStringBuilder As New Text.StringBuilder

            zTextStringBuilder.AppendLine("Sheet: " & Chr(34) & _SheetName & Chr(34) & "\n\r")

            For Each zImportTableResult In ImportTableResultList
                zTextStringBuilder.AppendLine(zImportTableResult.Text & "\n\r")
            Next

            zTextStringBuilder.AppendLine("\n\r")
            Return zTextStringBuilder.ToString

        End Get
    End Property

    Public ReadOnly Property ImportTableResultList As ImportTableResultList
        Get
            Return _ImportTableResultList
        End Get
    End Property

    Public Sub ResetCounters(ByVal pReasonForReset As ValidationError.ValidationErrorType)
        For Each zImportTableResult In _ImportTableResultList
            zImportTableResult.InsertCount = 0
            zImportTableResult.DeleteCount = 0

            If zImportTableResult.IsSuccessful Then
                zImportTableResult.ErrorList.Add(New ValidationError(pReasonForReset, Nothing))
            End If

        Next
    End Sub
End Class

