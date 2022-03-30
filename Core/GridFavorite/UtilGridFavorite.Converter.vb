Imports System.Runtime.Serialization.Formatters
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports GRC.Connect.Libraries.DataLib.razor

Partial Public Class UtilGridFavorite
    Public Shared Sub Convert()
        'Dim zLog As New List(Of String)
        'Dim zGrids As List(Of rowTblMetaGrid) = TblMetaGrid.LoadData
        'Dim zGridsWithNoLegacyId As List(Of rowTblMetaGrid) = zGrids.FindAll(Function(x) x.colFldLegacyFavoritesGridID IsNot Nothing)
        'Dim zGridColumns As List(Of rowTblMetaGridColumn) = TblMetaGridColumn.LoadData
        'Dim zUsers As List(Of rowTblEzyUsers) = TblEzyUsers.LoadData
        'Dim zFavs As List(Of rowTblFavMeta) = TblFavMeta.LoadData
        'Dim zFavWithPinAndFT As Integer = 0

        ''Dim zMyFav As rowFavMeta = zFavs.Find(Function(x) x.colFavId = 2562)
        ''zFavs.Clear()
        ''zFavs.Add(zMyFav)

        'For Each zFav As rowTblFavMeta In zFavs
        '    Dim zObject As Fav = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Fav)(zFav.colJson)
        '    Dim zLegacyGridId As Integer = zObject.LegacyGridId
        '    'If zLegacyGridId = 61 Then Stop : zLegacyGridId = 469
        '    'If zLegacyGridId = 147 Then Stop : zLegacyGridId = 145
        '    'If zLegacyGridId = 146 Then Stop : zLegacyGridId = 144

        '    zObject.Grid = zGridsWithNoLegacyId.Find(Function(x) x.colFldLegacyFavoritesGridID = zLegacyGridId)
        '    If Not IsNothing(zObject.Grid) Then
        '        Dim zUser As rowTblEzyUsers = zUsers.Find(Function(x) x.colEmail.ToLower.Contains(zObject.UserId.ToLower))

        '        If Not IsNothing(zUser) Then
        '            zObject.EzyUserId = zUser.colEzyUserID



        '            'GET GRID COLUMN META
        '            Dim zMeta As New UtilMeta
        '            zMeta.PropGridId = zObject.Grid.colFldId
        '            Dim zColumnsList As List(Of Object) = zMeta.GetGridMeta().Item("columns")

        '            'BUILD SORT 
        '            Dim zSBSort As New StringBuilder("")
        '            If zObject.HasSorts Then
        '                zSBSort.Append("[")
        '                Dim zIdx As Integer = 0
        '                For Each zSort As KeyValuePair(Of String, String) In zObject.Sorts
        '                    Dim zMetaFieldName As String = GetGridMetaFieldName(zGridColumns, zSort.Key, zObject.Grid)
        '                    If zIdx > 0 Then zSBSort.Append(",")
        '                    zSBSort.Append("{#DQ#field#DQ#:#DQ#" & zMetaFieldName & "#DQ#,#DQ#dir#DQ#:#DQ#" & zSort.Value.ToString.ToLower & "#DQ#}")
        '                    zIdx += 1
        '                Next
        '                zSBSort.Append("]")
        '            End If

        '            'BUILD FILTER
        '            Dim zSBFilter As New StringBuilder("")
        '            If zObject.HasFilters Then
        '                Dim zListFilterNoPick As List(Of FavFilterDef) = zObject.Filters.FindAll(Function(x) x.IsPickList = False)
        '                Dim zListFilterPick As List(Of FavFilterDef) = zObject.Filters.FindAll(Function(x) x.IsPickList = True)
        '                Dim zJsonFilter As New JSONFilter
        '                zJsonFilter.Logic = JSONFilterLogic.Operators.And

        '                Dim zNoPickFilters As New JSONFilter
        '                zNoPickFilters.Logic = JSONFilterLogic.Operators.And
        '                For Each zFilter As FavFilterDef In zListFilterNoPick
        '                    Dim zMetaFieldName As String = GetGridMetaFieldName(zGridColumns, zFilter.Field, zObject.Grid)
        '                    zNoPickFilters.Filters.Add(New JSONFilterItem(zMetaFieldName, ConvertLegacyOperator(zFilter.Operator), zFilter.Value1))
        '                Next

        '                Dim zPickFilters As New JSONFilter
        '                zPickFilters.Logic = JSONFilterLogic.Operators.And
        '                For Each zFilter As FavFilterDef In zListFilterPick
        '                    Dim zMetaFieldName As String = GetGridMetaFieldName(zGridColumns, zFilter.Field, zObject.Grid)
        '                    zPickFilters.Filters.Add(New JSONFilterItem(zMetaFieldName, ConvertLegacyOperator(zFilter.Operator), zFilter.Value1))
        '                Next

        '                zJsonFilter.Filters.Add(zNoPickFilters)
        '                zJsonFilter.Filters.Add(zPickFilters)
        '                zSBFilter.Append(zJsonFilter.ToJSON)
        '            End If

        '            ' SET PINS
        '            Dim zSBPin As New StringBuilder("")
        '            Dim zPinnedColumns As New List(Of String)

        '            If zObject.HasPins Then

        '                'LOG IF FAVORITE HAS PIN COLUMNS AND GRID IS HAS FORM TEMPLATE
        '                If Not String.IsNullOrWhiteSpace(zObject.Grid.colFldFormViewTemplateName) Then Stop : zFavWithPinAndFT = zFavWithPinAndFT + 1 : zLog.Add("Favorite w/ pin and FormViewTemplate: FAVID [" & zObject.FavId & "]".PadRight(10) & "  FilePrefix [" & zObject.FilePrefix & "]".PadRight(15) & "USERID: [" & zObject.UserId & "]") Else Stop

        '                zSBPin.Append("[")
        '                Dim zIdx As Integer = 0
        '                Dim zUsePinColumns As Boolean = String.IsNullOrEmpty(zObject.Grid.colFldFormViewTemplateName)
        '                For Each zKey As Integer In zObject.Pins.Keys
        '                    Dim zPinFieldName As String = zObject.Pins(zKey)
        '                    If zIdx > 0 Then zSBPin.Append(",")
        '                    Dim zMetaFieldName As String = GetGridMetaFieldName(zGridColumns, zPinFieldName, zObject.Grid)
        '                    zPinnedColumns.Add(zMetaFieldName)
        '                    zSBPin.Append("{#DQ#locked#DQ#:" & zUsePinColumns.ToString.ToLower & ",#DQ#field#DQ#:#DQ#" & zMetaFieldName & "#DQ#}")
        '                    zIdx += 1
        '                Next
        '                For Each zFieldAttr As Dictionary(Of String, Object) In zColumnsList
        '                    If Not zPinnedColumns.Contains(zFieldAttr("field")) Then
        '                        zSBPin.Append(",")
        '                        zSBPin.Append("{#DQ#locked#DQ#:false,#DQ#field#DQ#:#DQ#" & zFieldAttr("field") & "#DQ#}")
        '                    End If
        '                Next
        '                zSBPin.Append("]")
        '            End If

        '            '    UtilGridFavorite.SaveFavorite(zObject.Name, zObject.FilePrefix, zObject.Grid.colFldId, zObject.EzyUserId, zObject.Grid.colFldGridPractice, ConvertCurrency(zObject.Currency), ConvertUnit(zObject.Unit), Replace(zSBPin.ToString, "#DQ#", Chr(34)) & "", Replace(zSBSort.ToString, "#DQ#", Chr(34)) & "", zSBFilter.ToString & "", "")
        '        Else
        '            ' zLog.Add("Skipped Favorite [" & zObject.FavId & "].  Could not locate ezyuser [" & zObject.UserId & "].")
        '        End If

        '    Else
        '        '   zLog.Add("Skipped Favorite [" & zObject.FavId & "].  Could not locate grid for legacy id [ " & zObject.LegacyGridId & "] ")
        '    End If

        '    Trace.WriteLine("Converted Favorite ID [" & zFav.colFavId & "] " & zFavs.IndexOf(zFav) & " of  " & zFavs.Count)

        'Next

        'zLog.ForEach(Sub(x) Trace.WriteLine(x))



        'Stop

    End Sub

    Private Shared Function GetGridMetaFieldName(pList As List(Of rowTblMetaGridColumn), pFieldToFind As String, pGrid As rowTblMetaGrid) As String
        Dim zGridColumns As List(Of rowTblMetaGridColumn) = pList.FindAll(Function(x) x.colFldMetaGridId = pGrid.colFldId)

        'OVERRIDES
        If pFieldToFind.ToLower = "lebeforeus" Then pFieldToFind = "LossExpectancyBefore"
        If pFieldToFind.ToLower = "apleuro" Then pFieldToFind = "APL"
        If pFieldToFind.ToLower = "tiveuro" Then pFieldToFind = "TIV"
        If pFieldToFind.ToLower = "tivus" Then pFieldToFind = "TIV"
        If pFieldToFind.ToLower = "actuallebeforeus" Then pFieldToFind = "LossExpectancyBeforeActual"
        If pFieldToFind.ToLower = "tivusd" Then pFieldToFind = "TIV"
        If pFieldToFind.ToLower = "leafterus" Then pFieldToFind = "LossExpectancyAfter"
        If pFieldToFind.ToLower = "lecostus" Then pFieldToFind = "CostToComplete"
        If pFieldToFind.ToLower = "inspection_date" Then pFieldToFind = "InspectionDate"
        If pFieldToFind.ToLower = "apltotalusd" Then pFieldToFind = "APL"
        If pFieldToFind.ToLower = "tiv_usd" Then pFieldToFind = "TIV"

        Dim zReturn As rowTblMetaGridColumn = zGridColumns.Find(Function(x) (Trim(x.colTitle).ToLower = pFieldToFind.ToLower) Or (Trim(x.colField).ToLower = pFieldToFind.ToLower))

        If IsNothing(zReturn) Then
            Trace.WriteLine("Grid:" & pGrid.colFldGridName & "[ " & pGrid.colFldId & "]")
            Trace.WriteLine("Find:" & pFieldToFind)
            Trace.WriteLine(New String("-", 80))
            zGridColumns.ForEach(Sub(X) Trace.WriteLine("Field:" & X.colField.PadRight(25) & "Title:" & X.colTitle))
            Throw New ArgumentException("Could not locate field [" & pFieldToFind & "] within Grid [" & pGrid.colFldGridName & "] Id [" & pGrid.colFldId & "]", "pFieldToFind")
        Else
            Return zReturn.colField
        End If
    End Function

    Private Shared Sub SetLock(ByRef pObject As Object, pColumnName As String)
        If TypeOf pObject Is Dictionary(Of String, Object) Then
            Dim zDict As Dictionary(Of String, Object) = pObject
            If zDict("field").ToLower = pColumnName.ToLower Then
                pObject("locked") = True
            End If
        End If

    End Sub

    Private Shared Function ConvertLegacyOperator(pLegacyOperator As String) As JSONFilterOperator.Operators
        If pLegacyOperator = "equals" Then Return JSONFilterOperator.Operators.Equal
        If pLegacyOperator = "doesNotEqual" Then Return JSONFilterOperator.Operators.NotEqual
        If pLegacyOperator = "beginsWith" Then Return JSONFilterOperator.Operators.StartsWith
        If pLegacyOperator = "doesNotBeginWith" Then Stop : Throw New Exception("Cannot convert doesNotBeginWith")
        If pLegacyOperator = "endsWith" Then Return JSONFilterOperator.Operators.EndsWith
        If pLegacyOperator = "doesNotEndWith" Then Stop : Throw New Exception("Cannot convert doesNotEndWith")
        If pLegacyOperator = "contains" Then Return JSONFilterOperator.Operators.Contains
        If pLegacyOperator = "doesNotContain" Then Return JSONFilterOperator.Operators.DoesNotContain
        If pLegacyOperator = "isAfter" Then Return JSONFilterOperator.Operators.GreaterThan
        If pLegacyOperator = "isAfterorOn" Then Return JSONFilterOperator.Operators.GreaterThanEqualTo
        If pLegacyOperator = "isBefore" Then Return JSONFilterOperator.Operators.LessThan
        If pLegacyOperator = "isBeforeorOn" Then Return JSONFilterOperator.Operators.LessThanEqualTo
        If pLegacyOperator = "isGreaterThan" Then Return JSONFilterOperator.Operators.GreaterThan
        If pLegacyOperator = "isGreaterThanOrEqualTo" Then Return JSONFilterOperator.Operators.GreaterThanEqualTo
        If pLegacyOperator = "isLessThan" Then Return JSONFilterOperator.Operators.LessThan
        If pLegacyOperator = "isLessThanOrEqualTo" Then Return JSONFilterOperator.Operators.LessThanEqualTo
        If pLegacyOperator = "_isNot" Then Return JSONFilterOperator.Operators.IsNot
        If pLegacyOperator = "_is" Then Return JSONFilterOperator.Operators.Is
        Throw New Exception("Undefined Convert Operator")

    End Function

    Private Shared Function ConvertCurrency(pLegacyCurrency As String) As TblMetaCurrency.Currencies
        Select Case pLegacyCurrency
            Case "Australian Dollar"
                Return TblMetaCurrency.Currencies.AustrailianDollar
            Case "British Pound"
                Return TblMetaCurrency.Currencies.BritishPound
            Case "Canadian Dollar"
                Return TblMetaCurrency.Currencies.CanadianDollar
            Case "Euro"
                Return TblMetaCurrency.Currencies.Euro
            Case "Japanese Yen"
                Return TblMetaCurrency.Currencies.JapaneseYen
            Case "Mexican Peso"
                Return TblMetaCurrency.Currencies.MexicanPeso
            Case "New Zealand Dollar"
                Return TblMetaCurrency.Currencies.NewZealandDollar
            Case "US Dollar"
                Return TblMetaCurrency.Currencies.UsDollar
            Case Else
                Throw New Exception("Undefined Currency")
        End Select
    End Function

    Private Shared Function ConvertUnit(pLegacyUnit As String) As TblMetaUnitSystem.Systems
         Select pLegacyUnit
            Case "English"
                Return TblMetaUnitSystem.Systems.English
            Case "Metric"
                Return TblMetaUnitSystem.Systems.Metric
            Case Else
                Throw New Exception("Undefined Unit")
        End Select
    End Function

    Private Shared Function GridHasFormTemplate(pGridId As Integer, pGrids As List(Of rowTblMetaGrid)) As Boolean
        Dim zFV As Boolean = CBool(pGrids.Find(Function(x) x.colFldId = pGridId).colFldFormViewTemplateName & "".Length)
        Return zFV
    End Function

End Class





Public Class Fav
    Public FavId As Integer
    Public FilePrefix As String
    Public UserId As String
    Public Name As String
    Public LegacyGridId As Integer
    Public Grid As rowTblMetaGrid = Nothing
    Public EzyUserId As Integer = 0
    Public Currency As String
    Public Unit As String
    Public IPY As String
    Public HasPickListFilter As Boolean = False
    Public Pins As New Dictionary(Of Integer, String)
    Public Sorts As New Dictionary(Of String, String)
    Public Filters As New List(Of FavFilterDef)

    Public Sub AddSort(pField As String, pDirection As String)
        Sorts.Add(pField, pDirection)
    End Sub

    Public Sub AddPin(pIndex As Integer, pField As String)
        Pins.Add(pIndex, pField)
    End Sub

    Public ReadOnly Property HasFilters As Boolean
        Get
            Return CBool(Filters.Count)
        End Get
    End Property

    Public ReadOnly Property HasSorts As Boolean
        Get
            Return CBool(Sorts.Count)
        End Get
    End Property

    Public ReadOnly Property HasPins As Boolean
        Get
            Return CBool(Pins.Count)
        End Get
    End Property

End Class

Public Class FavFilterDef
    Public IsPickList As Boolean
    Public Field As String
    Public [Operator] As String
    Public [Value1] As String
    Public [Value2] As String
    Public Sub New(pField As String, pOperator As String, pValue1 As String, pValue2 As String, pIsPickList As Boolean)
        Me.Field = pField
        Me.Operator = pOperator
        Me.Value1 = pValue1
        Me.Value2 = pValue2
        IsPickList = pIsPickList
    End Sub
End Class