Public Class ImportFileResult
    Inherits Result

    Dim _FileName As String = ""
    Dim _ImportSheetResultList As New ImportSheetResultList

    Public Sub New(ByVal pFileName As String)
        _FileName = pFileName
    End Sub

    Public Overrides ReadOnly Property IsSuccessful As Boolean
        Get
            For Each zImportSheetResult As ImportSheetResult In _ImportSheetResultList
                If Not zImportSheetResult.IsSuccessful Then
                    Return False
                End If
            Next

                Return True
        End Get
    End Property

    Public Overrides ReadOnly Property Text As String
        Get
            Dim zTextStringBuilder As New Text.StringBuilder
           
            zTextStringBuilder.AppendLine("File: " & Chr(34) & _FileName & Chr(34) & " - " & GetOverallStatus() & "\n\r")
            zTextStringBuilder.AppendLine(New String("-"c, 80) & "\n\r")
            zTextStringBuilder.AppendLine("\n\r")

            For Each zImportSheetResult In ImportSheetResultList
                zTextStringBuilder.AppendLine(zImportSheetResult.Text & "\n\r")
            Next

            zTextStringBuilder.AppendLine("\n\r")
            Return zTextStringBuilder.ToString

        End Get
    End Property

    Public ReadOnly Property ImportSheetResultList As ImportSheetResultList
        Get
            Return _ImportSheetResultList
        End Get
    End Property

    Private Function GetOverallStatus() As String

        Dim zHasSuccess As Integer = 0
        Dim zHasFailure As Integer = 0
        Dim zStatusPlaceholder As String = ""

        'Get overall status
        For Each zImportSheetResult In ImportSheetResultList

            If zImportSheetResult.IsSuccessful Then
                zHasSuccess = 1
            Else
                zHasFailure = 2
            End If
        Next

        Select Case zHasFailure + zHasSuccess

            Case 1
                Return "Success"

            Case 2
                Return "Failed"

            Case 3
                Return "Partially Successful"

            Case Else
                Return ""

        End Select


    End Function
End Class
