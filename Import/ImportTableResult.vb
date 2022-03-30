Public Class ImportTableResult
    Inherits Result

    Private _Errors As New List(Of ValidationError)
	Private _ImportTableInfo As ImportTableInfo
	Private _Notes As New List(Of ImportNote)
    Private _InsertCount As Integer = 0
	Private _DeleteCount As Integer = 0
	Private _UpdateCount As Integer = 0

    Public Sub New(ByVal pImportTableInfo As ImportTableInfo)
        _ImportTableInfo = pImportTableInfo
    End Sub


    Public Overrides ReadOnly Property IsSuccessful As Boolean
        Get
            If _Errors.Count = 0 Then
                Return True
            End If

            Return False

        End Get
    End Property

    Public ReadOnly Property ImportTableInfo As ImportTableInfo
        Get
            Return _ImportTableInfo
        End Get
    End Property
       
    Public Overrides ReadOnly Property Text As String
        Get
            Dim zTextStringBuilder As New Text.StringBuilder

            'BECAUSE RECCOMMENDATION CAN SPAN MULTIPLE SHEETS WE NEED TO INCLUDE THE NAME OF THE SHEET IN THE FINAL RESULT
            If _ImportTableInfo.ImportTableEnum = ImportEnum.ImportTable.FireRecommendation Or _ImportTableInfo.ImportTableEnum = ImportEnum.ImportTable.BmRecommendation Or _ImportTableInfo.ImportTableEnum = ImportEnum.ImportTable.PSRecommendation Then
                If _ImportTableInfo.SheetName.Contains("2") Or _ImportTableInfo.SheetName.Contains("3") Or _ImportTableInfo.SheetName.Contains("4") Then
                    zTextStringBuilder.AppendLine("Sheet: " & Chr(34) & _ImportTableInfo.SheetName & Chr(34) & "\n\r")
                End If
            End If

            zTextStringBuilder.Append("Table: " & Chr(34) & _ImportTableInfo.ImportTableSqlName & Chr(34) & " - ")

            If IsSuccessful Then
                zTextStringBuilder.AppendLine("Success \n\r")
                zTextStringBuilder.AppendLine(Space(5) & "Insert Count: " & _InsertCount & "\n\r")
                zTextStringBuilder.AppendLine(Space(5) & "Update Count: " & _UpdateCount & "\n\r")
                zTextStringBuilder.AppendLine(Space(5) & "Delete Count: " & _DeleteCount & "\n\r")

				For Each zNote As ImportNote In _Notes
                    zTextStringBuilder.AppendLine(Space(5) & zNote.Message & "\n\r")
				Next
            Else
                zTextStringBuilder.AppendLine("Failed \n\r")
                For Each zError As ValidationError In _Errors
                    zTextStringBuilder.AppendLine(Space(5) & zError.Message & "\n\r")
                Next
            End If

            Return zTextStringBuilder.ToString

        End Get
    End Property

    Friend Property InsertCount As Integer
        Get
            Return _InsertCount
        End Get
        Set(value As Integer)
            _InsertCount = value
        End Set
    End Property
	Friend Property UpdateCount As Integer
		Get
			Return _UpdateCount
		End Get
		Set(value As Integer)
			_UpdateCount = value
		End Set
	End Property

    Friend Property DeleteCount As Integer
        Get
            Return _DeleteCount
        End Get
        Set(value As Integer)
            _DeleteCount = value
        End Set
    End Property

    Public ReadOnly Property ErrorList As List(Of ValidationError)
        Get
            Return _Errors
        End Get
    End Property

	Public ReadOnly Property ImportNote As List(Of ImportNote)
		Get
			Return _Notes
		End Get
	End Property

End Class
