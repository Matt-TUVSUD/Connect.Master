Imports Microsoft.Office.Interop


Public MustInherit Class ImportTableInfo

    Protected Property _SheetName As String
    Protected Property _Range As String()
    Protected Property _Description As String
    Protected Property _Practice As UtilPractice.PracticeEnum
    Protected Overridable Property _MetaPractice As UtilMetaPractice.Practices
    Protected Property _ImportTableEnum As ImportEnum.ImportTable
    Protected Property _RecordsInserted As Integer
    Protected Property _RecordsDeleted As Integer
    Protected Property _Errors As New ValidationErrorCollection
    Protected Property _ExcelErrorAddresses As List(Of CellAddress)
    Protected Property _Meta As Meta
	Protected Property _ImportType As ImportEnum.ImportType
	Protected Property _ImportSheetEnum As ImportEnum.ImportSheet
    Protected Property _MapCollection As MapCollection

	Public ReadOnly Property SheetName As String
		Get
			Return _SheetName
		End Get
	End Property

    Friend ReadOnly Property Range As String()
        Get
            Return _Range
        End Get
    End Property

    Friend ReadOnly Property Description As String
        Get
            Return _Description
        End Get
    End Property

    Friend ReadOnly Property Practice As UtilPractice.PracticeEnum
        Get
            Return _Practice
        End Get
    End Property

    Friend Property MetaPractice As UtilMetaPractice.Practices
        Get
            Return _MetaPractice
        End Get
        Set(value As UtilMetaPractice.Practices)
            _MetaPractice = value
        End Set
    End Property

    Friend ReadOnly Property ImportTableEnum As ImportEnum.ImportTable
        Get
            Return _ImportTableEnum
        End Get
	End Property

	Friend ReadOnly Property ImportSheetEnum As ImportEnum.ImportSheet
		Get
			Return _ImportSheetEnum
		End Get
	End Property

    Friend ReadOnly Property HeaderRow As Integer
        Get
            Dim zStartingCell As String = Split(_Range.First, ":")(0)
            Return Convert.ToInt16(Mid(zStartingCell, GetFirstNumericPosition(zStartingCell)))

        End Get
    End Property

    Friend ReadOnly Property Meta As Meta
        Get
            Return _Meta
        End Get
    End Property

    Friend ReadOnly Property HeaderRange As String
        Get
            Return FirstColumn & HeaderRow & ":" & LastColumn & HeaderRow
        End Get
    End Property

    Public ReadOnly Property ImportRange As String
        Get
            Return FirstColumn & FirstRow & ":" & LastColumn & LastRow
        End Get
    End Property

    Friend ReadOnly Property FirstRow As Integer
        Get
            If _ImportTableEnum = ImportEnum.ImportTable.FireNatHazModeling Then
                Return HeaderRow + 2  'The modeling data import section has a row in between the header and import rows.
            Else
                Return HeaderRow + 1
            End If

        End Get
    End Property

    Friend ReadOnly Property LastRow As Integer
        Get
            Dim zStartingCell As String = Split(_Range.Last, ":")(1)
            Return Convert.ToInt16(Mid(zStartingCell, GetFirstNumericPosition(zStartingCell)))

        End Get
    End Property

    Friend ReadOnly Property FirstColumn As String
        Get
            Dim zStartingCell As String = Split(_Range.First, ":")(0)
            Return Left(zStartingCell, GetFirstNumericPosition(zStartingCell) - 1)

        End Get
    End Property

    Friend ReadOnly Property LastColumn As String
        Get
            Dim zEndingCell As String = Split(_Range.Last, ":")(1)
            Return Left(zEndingCell, GetFirstNumericPosition(zEndingCell) - 1)

        End Get
    End Property

    Friend ReadOnly Property ExcelErrorAddresses As List(Of CellAddress)
        Get
            Return _ExcelErrorAddresses
        End Get
    End Property


    Public ReadOnly Property ImportTableSqlName() As String
        Get
            Return EsHelper.GetEsTableName(ImportTableType)
        End Get
    End Property

    Public ReadOnly Property ImportTableType() As System.Type
        Get
            Return Meta.GetImportTableEntityType(_ImportTableEnum)
        End Get
    End Property

    Public ReadOnly Property ImportTableObject() As Object
        Get
            Return Activator.CreateInstance(Me.ImportTableType, True)
        End Get
    End Property

    Public ReadOnly Property ImportType As ImportEnum.ImportType
        Get
            Return _ImportType
        End Get
    End Property


    Private Function GetFirstNumericPosition(ByVal pCell As String) As Integer

        For Each zChar As Char In pCell
            If IsNumeric(zChar) Then
                Return InStr(pCell, zChar)
            End If
        Next

        Return 0

    End Function

    Public ReadOnly Property MapCollection As MapCollection
        Get
            Return _MapCollection
        End Get
    End Property

    Public ReadOnly Property FullRangeAddress As String
        Get
            Dim RangeStart As String = Range.First
            Dim zRangeStartCol As String = RangeStart.Split(":").First
            Dim RangeEnd As String = Range.Last
            Dim zRangeEndRow As String = RangeStart.Split(":").Last

            Return SheetName & "!" & zRangeStartCol & ":" & zRangeEndRow
        End Get
    End Property

End Class


