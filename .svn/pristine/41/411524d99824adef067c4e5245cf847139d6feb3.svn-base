Imports System.Data.SqlClient
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Web
Imports System.Web.Script.Services
Imports System.ServiceModel.Activation
Imports GRC.Connect.Web.Contracts
Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports GRC.Connect.Libraries.DataLib.razor
Imports EntitySpaces.js
Imports EntitySpaces.DynamicQuery

Namespace Service

    <AspNetCompatibilityRequirements(RequirementsMode:=AspNetCompatibilityRequirementsMode.Allowed)> _
    Partial Public Class RESTServer
        Implements IRESTServer

        ' JET PROCEDURE
        Public Function JetStream(pJetProc As String, pJetData As String) As IO.Stream Implements IRESTServer.JetStream
            Dim zReturn As System.IO.Stream = Nothing

            Select Case pJetProc

                Case "PullGridMeta"
                    'Try
                    '    Dim zGridId As Integer = Integer.Parse(pJetData & "")
                    '    zReturn = JsonWrap(GRC.Connect.Libraries.CoreLib.UtilMeta.PullGridMeta(zGridId))
                    'Catch ex As Exception
                    '    zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject("Error - " & ex.Message))
                    'End Try
            End Select

            Return zReturn

        End Function


        ' META PROCEDURE
        Public Function GetGridMeta(gSafeGuid As String, pIsRebuildRequired As Boolean, pUserCurrencyId As String) As IO.Stream Implements IRESTServer.GetGridMeta
            Dim zReturn As System.IO.Stream
            Dim zMeta As New GRC.Connect.Libraries.CoreLib.UtilMeta

            ' GATHER DATA
            Dim zGridId As Integer = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentGridId) & ".0")
            Dim zFilePrefix As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)
            Dim zSafeId As Integer = UtilGSafe.GetId(gSafeGuid)

            ' FIND IF THERE IS A FAVORITE APPLIED
            If pIsRebuildRequired Then
                UtilGSafe.SetValue(gSafeGuid, UtilGSafe.KeyName.currentFavId, String.Empty, UtilGSafe.KeyNameGroup.Navigation)
                UtilSafe.ResetLargeObjectData(zSafeId)
            Else
                Dim zFavId As Integer = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentFavId) & ".0")
                If zFavId > 0 Then
                    Dim zObj As rowTblGridFavorite = TblGridFavorite.LoadByPrimaryKey(zFavId)
                    If zObj.colFldGridId = zGridId Then
                        zMeta.PropFavoriteId = zFavId
                    End If
                End If
            End If

            ' IS THERE A CHART OVERRIDE CURRENCY ID?
            Dim zUserCurrencyId As Integer = CInt(Val(pUserCurrencyId & ""))
            If zUserCurrencyId > 0 Then
                zMeta.PropOverrideCurrency = zUserCurrencyId
            End If

            ' GET META DATA
            zMeta.PropGridId = zGridId
            zMeta.PropFilePrefix = zFilePrefix
            zMeta.PropSafeGUID = gSafeGuid
            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zMeta.GetGridMeta()))
            Return zReturn
        End Function


        ' GRID PROCEDURE
        Public Function GetGridData(skip As Integer, take As Integer, page As Integer, pageSize As Integer, sort As String, filter As String, criteria As String, gSafeGuid As String, pUserCurrencyId As String) As IO.Stream Implements IRESTServer.GetGridData
            Dim zReturn As System.IO.Stream
            Dim zGrid As New GRC.Connect.Libraries.CoreLib.UtilGDC
            Dim zGridId As String = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentGridId) & ".0")
            Dim zSafeId As String = UtilGSafe.GetId(gSafeGuid) & ""
            Dim zFilePrefix As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)

            ' FIND IF THERE IS A FAVORITE APPLIED
            Dim zFavId As Integer = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentFavId) & ".0")
            If zFavId > 0 Then
                Dim zObj As rowTblGridFavorite = TblGridFavorite.LoadByPrimaryKey(zFavId)
                If zObj.colFldGridId = zGridId Then
                    zGrid.PropFavoriteId = zFavId
                End If
            End If

            zGrid.PropPageNumber = page
            zGrid.PropPageSize = pageSize
            'zGrid.PropSort = sort  ' DELETE ME = OLD WAY OF SETTING SORT.
            'zGrid.PropFilter = filter ' DELETE ME = OLD WAY OF SETTING FILTER.
            If Not filter Is Nothing Then
                ' USE THE SUPPLIED FILTER FROM CLIENT
                zGrid.PropFilter = filter
                UtilSafe.SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.filter, Nothing, zGridId)
            Else
                ' USE ANY FILTER IN GSAFE LARGE OBJECTS
                Dim zFilter As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.filter, zGridId)
                zGrid.PropFilter = zFilter
            End If
            If Not criteria Is Nothing Then
                ' USE THE SUPPLIED CRITERIA FROM CLIENT
                zGrid.PropCriteria = criteria
                UtilSafe.SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.criteria, Nothing, zGridId)
            Else
                ' USE ANY CRITERIA IN GSAFE LARGE OBJECTS
                Dim zCriteria As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.criteria, zGridId)
                zGrid.PropCriteria = zCriteria
            End If
            If Not sort Is Nothing Then
                ' USE THE SUPPLIED SORT FROM CLIENT
                zGrid.PropSort = sort
                UtilSafe.SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.sort, Nothing, zGridId)
            Else
                ' USE ANY SORT IN GSAFE LARGE OBJECTS
                Dim zSort As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.sort, zGridId)
                zGrid.PropSort = zSort
            End If

            zGrid.PropGridId = CInt(zGridId)
            zGrid.PropSafeGUID = gSafeGuid
            zGrid.PropParameters.FilePrefix = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)

            'IF THERE IS A CURRENCY OR UNIT PREFERENCE APPLY IT
            Dim zCurrencyPref As String = UtilGSafe.GetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyPreference)
            Dim zUnitPref As String = UtilGSafe.GetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitPreference)
            Dim zCurrency As TblMetaCurrency.Currencies = Nothing
            Dim zUnit As TblMetaUnitSystem.Systems = Nothing
            If IsNumeric(zCurrencyPref) Then zCurrency = [Enum].Parse(GetType(TblMetaCurrency.Currencies), zCurrencyPref) : zGrid.PropParameters.Currency = zCurrency
            If IsNumeric(zUnitPref) Then zUnit = [Enum].Parse(GetType(TblMetaUnitSystem.Systems), zUnitPref) : zGrid.PropParameters.Unit = zUnit

            ' IS THERE A CHART OVERRIDE CURRENCY ID?
            Dim zUserCurrencyId As Integer = CInt(Val(pUserCurrencyId & ""))
            If zUserCurrencyId > 0 Then
                'zGrid.PropCurrency = zUserCurrencyId
                zGrid.PropParameters.Currency = zUserCurrencyId
            End If

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zGrid.GetGridData()))
            Return zReturn
        End Function

        ' FORM PROCEDURE
        Public Function GetFormData(gSafeGuid As String, pUserCurrencyId As String, pFormFileNo As String, pUniqueId As String) As IO.Stream Implements IRESTServer.GetFormData

            Dim zReturn As System.IO.Stream
            Dim zGrid As New GRC.Connect.Libraries.CoreLib.UtilGDC
            Dim zGridId As String = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentGridId) & ".0")
            Dim zSafeId As String = UtilGSafe.GetId(gSafeGuid) & ""
            Dim zFilePrefix As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)

            Dim zMetaGrid As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(zGridId)
            UtilGSafe.SetValue(gSafeGuid, UtilGSafe.KeyName.FormFileNo, pFormFileNo, UtilGSafe.KeyNameGroup.GridFormInfo)
            UtilGSafe.SetValue(gSafeGuid, UtilGSafe.KeyName.FormUniqueId, pUniqueId, UtilGSafe.KeyNameGroup.GridFormInfo)

            If Not IsNothing(zMetaGrid.colFldFormViewReportId) Then
                UtilGSafe.SetValue(gSafeGuid, UtilGSafe.KeyName.FormReportId, zMetaGrid.colFldFormViewReportId, UtilGSafe.KeyNameGroup.GridFormInfo)
            End If

            ' USE THE SUPPLIED FILTER FROM CLIENT
            zGrid.PropFilter = UtilSafe.LoadLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.filterMap, zGridId)
            zGrid.PropCriteria = UtilSafe.LoadLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.criteriaMap, zGridId)

            zGrid.PropGridId = CInt(zGridId)
            zGrid.PropSafeGUID = gSafeGuid
            zGrid.PropParameters.FilePrefix = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)

            'IF THERE IS A CURRENCY OR UNIT PREFERENCE APPLY IT
            Dim zCurrencyPref As String = UtilGSafe.GetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyPreference)
            Dim zUnitPref As String = UtilGSafe.GetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitPreference)
            Dim zCurrency As TblMetaCurrency.Currencies = Nothing
            Dim zUnit As TblMetaUnitSystem.Systems = Nothing
            If IsNumeric(zCurrencyPref) Then zCurrency = [Enum].Parse(GetType(TblMetaCurrency.Currencies), zCurrencyPref) : zGrid.PropParameters.Currency = zCurrency
            If IsNumeric(zUnitPref) Then zUnit = [Enum].Parse(GetType(TblMetaUnitSystem.Systems), zUnitPref) : zGrid.PropParameters.Unit = zUnit

            ' IS THERE A CHART OVERRIDE CURRENCY ID?
            Dim zUserCurrencyId As Integer = CInt(Val(pUserCurrencyId & ""))
            If zUserCurrencyId > 0 Then
                'zGrid.PropCurrency = zUserCurrencyId
                zGrid.PropParameters.Currency = zUserCurrencyId
            End If

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zGrid.GetFormData()))
            Return zReturn
        End Function
        Public Function SetFormReportData(gSafeGuid As String, pUserCurrencyId As String, pFormFileNo As String, pUniqueId As String) As IO.Stream Implements IRESTServer.SetFormReportData

            Dim zReturn As System.IO.Stream
            Dim zGrid As New GRC.Connect.Libraries.CoreLib.UtilGDC
            Dim zGridId As String = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentGridId) & ".0")
            Dim zSafeId As String = UtilGSafe.GetId(gSafeGuid) & ""
            Dim zFilePrefix As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)

            UtilGSafe.SetValue(gSafeGuid, UtilGSafe.KeyName.FormFileNo, pFormFileNo, UtilGSafe.KeyNameGroup.GridFormInfo)
            UtilGSafe.SetValue(gSafeGuid, UtilGSafe.KeyName.FormUniqueId, pUniqueId, UtilGSafe.KeyNameGroup.GridFormInfo)

            Dim zMetaGrid As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(zGridId)
            If Not IsNothing(zMetaGrid.colFldFormViewReportId) Then
                UtilGSafe.SetValue(gSafeGuid, UtilGSafe.KeyName.FormReportId, zMetaGrid.colFldFormViewReportId, UtilGSafe.KeyNameGroup.GridFormInfo)
            End If

            zReturn = JsonWrap("Success")

            Return zReturn

        End Function

        ' MAP PROCEDURE
        Public Function GetMapData(sort As String, filter As String, criteria As String, gSafeGuid As String, pDepictedByColumnName As String) As IO.Stream Implements IRESTServer.GetMapData

            Dim zReturn As System.IO.Stream
            Dim zGrid As New GRC.Connect.Libraries.CoreLib.UtilGDC
            Dim zGridId As String = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentGridId) & ".0")
            Dim zSafeId As String = UtilGSafe.GetId(gSafeGuid) & ""
            Dim zFilePrefix As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)

            If Not String.IsNullOrEmpty(filter) Then
                ' USE THE SUPPLIED FILTER FROM CLIENT
                zGrid.PropFilter = filter
                UtilSafe.SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.filterMap, filter, zGridId)
            Else
                ' USE ANY FILTER IN GSAFE LARGE OBJECTS
                UtilSafe.SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.filterMap, Nothing, zGridId)
                zGrid.PropFilter = ""
            End If

            If Not String.IsNullOrEmpty(criteria) Then
                ' USE THE SUPPLIED CRITERIA FROM CLIENT
                zGrid.PropCriteria = criteria
                UtilSafe.SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.criteriaMap, criteria, zGridId)
            Else
                ' USE ANY CRITERIA IN GSAFE LARGE OBJECTS
                UtilSafe.SaveLargeObjectData_ByDataGroup(zSafeId, UtilSafe.LargeObjectName.criteriaMap, Nothing, zGridId)
                zGrid.PropCriteria = ""
            End If

            zGrid.PropGridId = CInt(zGridId)
            zGrid.PropSafeGUID = gSafeGuid
            zGrid.PropParameters.FilePrefix = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)
            zGrid.PropDepictedByColumnName = pDepictedByColumnName & ""

            'IF THERE IS A CURRENCY OR UNIT PREFERENCE APPLY IT
            Dim zCurrencyPref As String = UtilGSafe.GetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyPreference)
            Dim zUnitPref As String = UtilGSafe.GetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitPreference)
            Dim zCurrency As TblMetaCurrency.Currencies = Nothing
            Dim zUnit As TblMetaUnitSystem.Systems = Nothing
            If IsNumeric(zCurrencyPref) Then zCurrency = [Enum].Parse(GetType(TblMetaCurrency.Currencies), zCurrencyPref) : zGrid.PropParameters.Currency = zCurrency
            If IsNumeric(zUnitPref) Then zUnit = [Enum].Parse(GetType(TblMetaUnitSystem.Systems), zUnitPref) : zGrid.PropParameters.Unit = zUnit

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zGrid.GetMapData()))
            Return zReturn
        End Function

        ' MAP PROCEDURE
        Public Function GetMapShapeData(gSafeGuid As String) As IO.Stream Implements IRESTServer.GetMapShapeData

            Dim zReturn As System.IO.Stream
            Dim zGrid As New GRC.Connect.Libraries.CoreLib.UtilGDC

            zGrid.PropSafeGUID = gSafeGuid
            zGrid.PropParameters.FilePrefix = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zGrid.GetMapShapeData()))
            Return zReturn
        End Function


        ' GRID PICK LIST PROCEDURE
        Public Function GetPickListData(gSafeGuid As String, columnName As String, filter As String, criteria As String, pUserCurrencyId As String) As IO.Stream Implements IRESTServer.GetPickListData
            Dim zReturn As System.IO.Stream
            Dim zList As New GRC.Connect.Libraries.CoreLib.UtilGDC
            zList.PropGridId = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentGridId))
            zList.PropColumnName = columnName
            zList.PropCriteria = criteria
            zList.PropSafeGUID = gSafeGuid

            ' IS THERE A CHART OVERRIDE CURRENCY ID?
            Dim zUserCurrencyId As Integer = CInt(Val(pUserCurrencyId & ""))
            If zUserCurrencyId > 0 Then
                'zList.PropCurrency = zUserCurrencyId
                zList.PropParameters.Currency = zUserCurrencyId
            End If

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zList.GetPickListData()))
            Return zReturn
        End Function


        ' GRID FAVORITES PROCEDURE
        Public Function RenameGridFavorite(gSafeGuid As String, pId As Integer, pName As String) As IO.Stream Implements IRESTServer.RenameGridFavorite
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            Try
                UtilGridFavorite.RenameFavorite(pId, pName)
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        Public Function DeleteGridFavorite(gSafeGuid As String, pId As Integer) As IO.Stream Implements IRESTServer.DeleteGridFavorite
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            Try
                UtilGridFavorite.DeleteFavorite(pId)
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        Public Function SaveGridFavorite(gSafeGuid As String, pTitle As String, pColumnOrderSetting As String, pSort As String, pFilter As String, pCriteria As String) As IO.Stream Implements IRESTServer.SaveGridFavorite
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            Try
                ' GET GENERAL PARMS
                Dim zFilePrefix As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix) & ""
                Dim zGridId As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentGridId) & ""
                Dim zEzyUserId As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.EzyUserId) & ""
                Dim zCurrency As Integer = CInt(UtilGSafe.GetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyPreference) & ".0")
                Dim zUnit As Integer = CInt(UtilGSafe.GetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitPreference) & ".0")
                Dim zPractice As String = ""
                ' GET THE GRID RELATED PARMS
                Dim zObjGrid As rowTblMetaGrid
                zObjGrid = TblMetaGrid.LoadByPrimaryKey(zGridId)
                zPractice = zObjGrid.colFldGridPractice & ""
                If zPractice.Length < 1 Then zPractice = "All"
                ' SAVE FAVORITE AND GET ID
                Dim zFavId As Integer = UtilGridFavorite.SaveFavorite(pTitle, zFilePrefix, zGridId, zEzyUserId, zPractice, zCurrency, zUnit, pColumnOrderSetting, pSort, pFilter, pCriteria)
                ' RETURN THE DATA
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", zFavId)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        Public Function GetGridFavoriteListByGrid(gSafeGuid As String) As IO.Stream Implements IRESTServer.GetGridFavoriteListByGrid
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            Try
                ' GATHER NEEDED DATA
                Dim zGridId As Integer = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentGridId) & ".0")
                Dim zFilePrefix As Integer = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix) & ".0")
                Dim zEzyUserId As Integer = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.EzyUserId) & ".0")

                ' GET THE FAVORITE INFORMATION
                Dim zFavorites As New List(Of rowTblGridFavorite)
                zFavorites = UtilGridFavorite.LoadFavoriteListByGrid(zGridId, zEzyUserId, zFilePrefix)

                ' RETURN THE DATA
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", zFavorites)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        ' LARGE OBJECTS FOR EXTRACT PROCEDURE
        Public Function SaveLargeObjectData(gSafeGuid As String, gridId As Integer, sort As String, filter As String, criteria As String, meta As String, columnOrder As String) As IO.Stream Implements IRESTServer.SaveLargeObjectData
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            Try
                Dim zGridId As Integer = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentGridId)
                Dim zGSafeId As Integer = UtilGSafe.GetId(gSafeGuid)
                GRC.Connect.Libraries.CoreLib.UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filter, filter, CStr(zGridId))
                GRC.Connect.Libraries.CoreLib.UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.criteria, criteria, CStr(zGridId))
                GRC.Connect.Libraries.CoreLib.UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.sort, sort, CStr(zGridId))
                GRC.Connect.Libraries.CoreLib.UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.meta, meta, CStr(zGridId))
                GRC.Connect.Libraries.CoreLib.UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.columnOrder, columnOrder, CStr(zGridId))
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        ' LARGE OBJECT GET PROCEDURE FOR GRIDS
        Public Function GetLargeObjectDataGrid(gSafeGuid As String) As IO.Stream Implements IRESTServer.GetLargeObjectDataGrid
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            Try
                Dim zGridId As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentGridId)
                Dim zGSafeId As Integer = UtilGSafe.GetId(gSafeGuid)
                Dim zFilter As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filter, zGridId)
                Dim zCriteria As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.criteria, zGridId)
                Dim zSort As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.sort, zGridId)
                Dim zMeta As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.meta, zGridId)
                Dim zData As New Dictionary(Of String, Object)
                zData.Add(UtilSafe.LargeObjectName.filter, zFilter)
                zData.Add(UtilSafe.LargeObjectName.criteria, zCriteria)
                zData.Add(UtilSafe.LargeObjectName.sort, zSort)
                zData.Add(UtilSafe.LargeObjectName.meta, zMeta)
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", zData)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function

        ' LARGE OBJECT GET PROCEDURE FOR GRIDS
        Public Function ClearLocationNavigationInformation(gSafeGuid As String) As IO.Stream Implements IRESTServer.ClearLocationNavigationInformation
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            Try
                UtilGSafe.ClearLocationNavigationInformation(gSafeGuid)
                Dim zData As New Dictionary(Of String, Object)
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", "")
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            End Try
            Return zReturn
        End Function


        ' LARGE OBJECT GET PROCEDURE FOR CHARTS
        Public Function GetLargeObjectDataChart(gSafeGuid As String) As IO.Stream Implements IRESTServer.GetLargeObjectDataChart
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            Try
                Dim zChartId As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentChartId)
                Dim zGSafeId As Integer = UtilGSafe.GetId(gSafeGuid)
                Dim zFilter As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filterChart, zChartId)
                Dim zCriteria As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.criteriaChart, zChartId)
                Dim zSetting As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.settingChart, zChartId)
                Dim zData As New Dictionary(Of String, Object)
                zData.Add(UtilSafe.LargeObjectName.filterChart, zFilter)
                zData.Add(UtilSafe.LargeObjectName.criteriaChart, zCriteria)
                zData.Add(UtilSafe.LargeObjectName.settingChart, zSetting)
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", zData)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        ' APPLY MY PREFERENCES FILTER
        Public Function ApplyMyPreference(gSafeGuid As String, pFileNoList As List(Of String), pFilterString As String, pCurrencyPreference As String, pUnitPreference As String) As IO.Stream Implements IRESTServer.ApplyMyPreference
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            Try
                Dim zGSafeId As Integer = UtilGSafe.GetId(gSafeGuid)
                Dim zFilePrefix As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)
                If pFileNoList.Count < 1 Then
                    ' IF FILE NO LIST IS EMPTY, THEN RESET THE FILE NO TABLE
                    UtilGSafe.SetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.IsMyPreferenceActive, "", UtilGSafe.PreferenceKeyNameGroup.MyPreference)
                    UtilGSafe.SetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.MyPreferenceFilter, "", UtilGSafe.PreferenceKeyNameGroup.MyPreference)
                    UtilGSafe.SetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.MyPreferenceFilterDescText, "", UtilGSafe.PreferenceKeyNameGroup.MyPreference)
                    UtilGSafe.SetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyPreference, TblMetaCurrency.Currencies.UsDollar, UtilGSafe.PreferenceKeyNameGroup.FPPref)
                    UtilGSafe.SetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyDefaultText, "USD", UtilGSafe.PreferenceKeyNameGroup.FPPref)
                    UtilGSafe.SetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitPreference, TblMetaUnitSystem.Systems.English, UtilGSafe.PreferenceKeyNameGroup.FPPref)
                    UtilGSafe.SetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitDefaultText, "English", UtilGSafe.PreferenceKeyNameGroup.FPPref)
                    UtilLogin2.BuildSafeFileNo3(gSafeGuid)
                Else

                    ' PREFERENCES FILTER STRING
                    If Not pFilterString Is Nothing Then
                        If pFilterString.Length > 0 Then
                            If pFilterString.ToLower() <> "null" And pFilterString.ToLower() <> "undefined" Then

                                'GET EXISTING FILTER IF ONE EXISTS, THEN MERGE
                                Dim zExistingJSONFilter As String = UtilGSafe.GetValue(gSafeGuid, zFilePrefix, UtilGSafe.KeyName.MyPreferenceFilter)
                                If Not String.IsNullOrEmpty(zExistingJSONFilter) Then
                                    pFilterString = CoreLib.JSONFilter.Merge(zExistingJSONFilter, pFilterString)
                                End If

                                UtilGSafe.SetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.MyPreferenceFilter, pFilterString, UtilGSafe.PreferenceKeyNameGroup.MyPreference)

                                ' BUILD THE FILTER TEXT
                                Dim zQ1 As New queryViewCCGRIPSSLocationsV3
                                Dim zFilter As New UtilFilterSort
                                zFilter.SetFilter(pFilterString, zQ1)

                                ' SAVE THE ENGLISH TEXT VERSION OF THE FILTER STRING
                                UtilGSafe.SetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.MyPreferenceFilterDescText, zFilter.FilterText, UtilGSafe.PreferenceKeyNameGroup.MyPreference)
                            End If
                        End If
                    End If

                    'Rebuild the list
                    UtilLogin2.BuildSafeFileNo3(gSafeGuid)

                    ' CURRENCY
                    Dim zCurrencyText As String = "USD"
                    Dim zCollCurrency As New List(Of rowTblMetaCurrency)
                    Dim zCmdCurrency As New SqlClient.SqlCommand("SELECT TOP 1 * FROM [dbo].[tblMetaCurrency] WHERE [fldId] = @Id")
                    zCmdCurrency.Parameters.AddWithValue("@Id", pCurrencyPreference)
                    zCollCurrency = TblMetaCurrency.LoadData(zCmdCurrency)
                    If zCollCurrency.Count > 0 Then
                        zCurrencyText = zCollCurrency(0).colFldCode
                    End If
                    UtilGSafe.SetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyPreference, pCurrencyPreference, UtilGSafe.PreferenceKeyNameGroup.FPPref)
                    UtilGSafe.SetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.CurrencyDefaultText, zCurrencyText, UtilGSafe.PreferenceKeyNameGroup.FPPref)
                    ' UNITS
                    Dim zUnitsText As String = "English"
                    Dim zCollUnits As New List(Of rowTblMetaUnitSystem)
                    Dim zCmdUnit As New SqlClient.SqlCommand("SELECT TOP 1 * FROM [dbo].[tblMetaUnitSystem] WHERE [fldId] = @Id")
                    zCmdUnit.Parameters.AddWithValue("@Id", pUnitPreference)
                    zCollUnits = TblMetaUnitSystem.LoadData(zCmdUnit)
                    If zCollUnits.Count > 0 Then
                        zUnitsText = zCollUnits(0).colFldName
                    End If
                    UtilGSafe.SetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitPreference, pUnitPreference, UtilGSafe.PreferenceKeyNameGroup.FPPref)
                    UtilGSafe.SetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.UnitDefaultText, zUnitsText, UtilGSafe.PreferenceKeyNameGroup.FPPref)
                    ' SET THE PREFERNCE ON FLAG TO TRUE
                    UtilGSafe.SetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.IsMyPreferenceActive, "true", UtilGSafe.PreferenceKeyNameGroup.MyPreference)

                End If

                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        ' BATCH REPORTS PROCEDURES
        Public Function SetBatchReportNavLink(gSafeGuid As String, pNavLinkList As List(Of String)) As IO.Stream Implements IRESTServer.SetBatchReportNavLink
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            Try
                Dim zGSafeId As Integer = UtilGSafe.GetId(gSafeGuid)
                Dim zUserEmail As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.UserEmail)
                Dim zFilePrefix As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)
                Dim zMyPreferenceFilter As String = UtilGSafe.GetValue(gSafeGuid, zFilePrefix, UtilGSafe.PreferenceKeyName.MyPreferenceFilter)

                ' ADD CODE TO SAVE NAVLINK LIST AND SETTINGS TO THE BATCH SET
                Dim zBatchSet As New BatchSet
                With zBatchSet
                    .colFldFilePrefix = "0000"   ' SET THE FILEPREFIX TO QUAD ZERO WHILE CREATING BATCHSET
                    .colFldIsMyBatchReport = True
                    .colFldLOMyPreferenceJSON = zMyPreferenceFilter
                    .colFldCreateDate = Now
                    .colFldCreatedByGsafeId = zGSafeId
                    .colFldCreatedByGsafeUserEmail = zUserEmail
                    .SetParameters.FilePrefix = zFilePrefix
                    .Type = BatchSet.BatchType.Report
                    .ConnectionString = UtilDB.ConnectionString
                    .colFldFileName = "BatchReport - Reports Selected"
                    pNavLinkList.ForEach(Sub(x) zBatchSet.AddNavLinkItem(Int(x)))
                End With

                zBatchSet.Save(True) 'VERY IMPORTANT TO ELAY PROCESSING MAKE SURE THE SERVICE DOES PROCESS THIE REQUEST.

                ' ADD CODE TO SAVE THE GSAFE VARIABLE BatchReportBatchSetId (UtilGSafe.KeyName.BatchReportBatchSetId)
                UtilGSafe.SetValue(gSafeGuid, UtilGSafe.KeyName.BatchReportBatchSetId, zBatchSet.colFldId, UtilGSafe.KeyNameGroup.Preference)

                ' RETURN SUCCESS
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", Nothing) ' NO NEED TO RETURN DATA
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                ' RETURN ERROR
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        Public Function SetBatchReportSettings(gSafeGuid As String, pFileName As String, pCurrencyPreference As String, pUnitPreference As String, pFilterString As String, pSortString As String) As IO.Stream Implements IRESTServer.SetBatchReportSettings
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            Try
                Dim zGSafeId As Integer = UtilGSafe.GetId(gSafeGuid)
                Dim zFilePrefix As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)

                ' ADD CODE TO SAVE FILE NO LIST AND SETTINGS TO THE BATCH SET
                Dim zBatchSetId As Integer = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.BatchReportBatchSetId)
                Dim zBatchSet As BatchSet = BatchSet.Load(zBatchSetId)
                Dim zJSONSetting As New JSONSetting
                Dim zJSONCurrency As New JSONSettingItem("Currency", pCurrencyPreference)
                Dim zJSONUnit As New JSONSettingItem("Unit", pUnitPreference)
                zJSONSetting.Settings.Add(zJSONCurrency)
                zJSONSetting.Settings.Add(zJSONUnit)

                Dim zMyPrefFileNoList As New List(Of String)
                Dim zMyBatchFilterFileNoList As New List(Of String)
                Dim zGSafeFileNoList As New List(Of String)

                'BUILD FILENOS FROM GSAFEFILENO
                zGSafeFileNoList = UtilFileNo.BuildListFromGsafe(zGSafeId)

                'BUILD FILENOS FROM MYPREFERENCE FILTER IF PREFERENCE FILTER IS NOT NULL
                If Not String.IsNullOrEmpty(zBatchSet.colFldLOMyPreferenceJSON) Then zMyPrefFileNoList.AddRange(UtilFileNo.BuildList(zFilePrefix, zBatchSet.colFldLOMyPreferenceJSON).ToArray)

                'BUILD FILENOS FROM MYBATCH FILTER IF FILTER IS NOT EMPTY
                If pFilterString = "null" Then pFilterString = ""
                If pFilterString <> "" Then zMyBatchFilterFileNoList.AddRange(UtilFileNo.BuildList(zFilePrefix, pFilterString).ToArray)

                'WE NEED TO USE THE GSAFE FILENO AS THE BASE LIST
                For Each zGsafeFileNo As String In zGSafeFileNoList

                    'IF A FILTER HAS BEEN SET VIA MYBATCH OR MYPREF THEN WE NEED TO USE THE LIST TO DETERMINE IF IT SHOULD BE ADDED TO THE BATCHSET, IF NOT THEN JUST ADD TO THE BATCHSET
                    If zMyBatchFilterFileNoList.Count > 0 Or zMyPrefFileNoList.Count > 0 Then

                        If zMyBatchFilterFileNoList.Count > 0 And zMyPrefFileNoList.Count > 0 Then

                            'IF THE MYBATCHFILTER LIST AND MY PREF LIST BOTH HAVE FILENOS, THEN THE GSAFEFILE NEEDS TO BE IN BOTH LIST TO BE INCLUDED.
                            If zMyPrefFileNoList.Contains(zGsafeFileNo) And zMyBatchFilterFileNoList.Contains(zGsafeFileNo) Then
                                zBatchSet.AddFileNo(zGsafeFileNo)
                            End If

                        ElseIf zMyBatchFilterFileNoList.Count > 0 And zMyPrefFileNoList.Count = 0 Then
                            'MYBATCH FILTER ONLY HAS FILENOS, CHECK AGAINST THAT LIST ONLY
                            If zMyBatchFilterFileNoList.Contains(zGsafeFileNo) Then
                                zBatchSet.AddFileNo(zGsafeFileNo)
                            End If

                        ElseIf zMyBatchFilterFileNoList.Count = 0 And zMyPrefFileNoList.Count > 0 Then
                            'MYPREF FILTER ONLY HAS FILENOS, CHECK AGAINST THAT LIST ONLY
                            If zMyPrefFileNoList.Contains(zGsafeFileNo) Then
                                zBatchSet.AddFileNo(zGsafeFileNo)
                            End If

                        End If

                    Else
                        'IF NO FILTERS, THEN ADD TO BATCHSET
                        zBatchSet.AddFileNo(zGsafeFileNo)
                    End If

                Next

                If zBatchSet.BatchSetFileNos.Count > 0 Then
                    zBatchSet.colFldLOSettingJSON = zJSONSetting.ToJSON
                    zBatchSet.colFldFileName = pFileName
                    zBatchSet.colFldLOSortJSON = pSortString
                    zBatchSet.colFldLOFilterJSON = pFilterString
                    zBatchSet.colFldFilePrefix = Int(zBatchSet.BatchSetFileNos(0))
                    zBatchSet.Save()
                Else
                    Dim zEx As New ApplicationException("Application cannot create batchset. No locations were selected.")
                    zEx.Data.Add("User", UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.userFullName))
                    zEx.Data.Add("BatchSetId", zBatchSet.colFldId)
                    zEx.Data.Add("FilePrefix", zFilePrefix)
                    zEx.Data.Add("Guid", gSafeGuid)
                    Throw zEx
                End If

                'CREATE EMAIL 
                Dim zEmailProcessing As New BatchEmail
                Dim zUserName As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.userFullName)
                Dim zClientName As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ClientName)
                Dim zTemplate As rowTblEmailTemplate = UtilEmailTemplate.GetBatchReportTemplate(zUserName, zClientName, pFileName, zFilePrefix)
                Dim zBatchBCCAddress As String = UtilSetting.GetValue(UtilSetting.Keys.BatchProcessingBCCAddress)
                With zEmailProcessing
                    .AddTo(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.UserEmail))
                    If Not String.IsNullOrEmpty(zBatchBCCAddress) Then .AddBcc(zBatchBCCAddress)
                    .colFldSubject = zTemplate.colFldSubject
                    .colFldBody = zTemplate.colFldBody
                    .BatchSets.Add(zBatchSet)
                End With
                TblBatchProcessingEmail.Save(zEmailProcessing)

                ' RETURN SUCCESS
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", Nothing) ' NO NEED TO RETURN DATA
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                ' RETURN ERROR
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                System.Diagnostics.EventLog.WriteEntry("Client Connect", GRC.Resources.ExceptionUtility.ExtractMessages(ex))
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        ' EXTRACT PROCEDURE
        Public Function GetRatingLegendChart(gSafeGuid As String) As IO.Stream Implements IRESTServer.GetRatingLegendChart
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            Dim zData As New List(Of Object) 'New Dictionary(Of String, Object)
            Try
                ' GET THE LISTING OF THE FIRE KEYS
                Dim zGridId As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentGridId)
                Dim zRatingKeyId As String = ""
                Dim zFilePrefix As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)
                Dim zSQL = ""
                Dim zCmd As New SqlCommand
                Dim zReader As SqlDataReader
                zCmd.CommandType = CommandType.StoredProcedure
                Select Case zGridId
                    Case "25"
                        Dim zList As List(Of FireRatingAveragesByTivAndLocItem) = UtilRating.GetFireSummaryRatingAveragesByTivAndLoc(gSafeGuid, Nothing, zFilePrefix)
                        For Each zItem As FireRatingAveragesByTivAndLocItem In zList
                            Dim zObj As New Dictionary(Of Object, String)
                            zObj.Add("RatingId", zItem.RatingId)
                            zObj.Add("RatingText", zItem.RatingText)
                            zObj.Add("RatingDesc", zItem.RatingDesc)
                            zObj.Add("RatingHexColor", zItem.RatingHexColor)
                            zObj.Add("PercentByTIV", zItem.PercentByTIV)
                            zObj.Add("PercentByLocations", zItem.PercentByLocations)
                            zData.Add(zObj)
                        Next

                    Case "24"
                        zSQL = "spLegendBMFacilityRatingSummarySelect"
                        zRatingKeyId = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.BMRatingKeyID)
                        zCmd.CommandText = zSQL
                        zCmd.Parameters.Add(New SqlParameter("@GSafeGUID", gSafeGuid))
                        zCmd.Parameters.Add(New SqlParameter("@RatingKeyID", zRatingKeyId))
                        zReader = UtilSQLServer.ExecuteReader(zCmd)
                        While zReader.Read
                            Dim zObj As New Dictionary(Of Object, String)
                            If Not zReader.IsDBNull(zReader.GetOrdinal("RatingId")) Then zObj.Add("RatingId", zReader.GetValue(zReader.GetOrdinal("RatingId")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("RatingText")) Then zObj.Add("RatingText", zReader.GetValue(zReader.GetOrdinal("RatingText")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("RatingDesc")) Then zObj.Add("RatingDesc", zReader.GetValue(zReader.GetOrdinal("RatingDesc")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("RatingHexColor")) Then zObj.Add("RatingHexColor", zReader.GetValue(zReader.GetOrdinal("RatingHexColor")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("PercentByTIV")) Then zObj.Add("PercentByTIV", zReader.GetValue(zReader.GetOrdinal("PercentByTIV")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("PercentByLocations")) Then zObj.Add("PercentByLocations", zReader.GetValue(zReader.GetOrdinal("PercentByLocations")))
                            zData.Add(zObj)
                        End While
                        zReader.Close()
                    Case "23"

                        Dim zList As List(Of FireRatingWeightItem) = UtilRating.GetFireDetailRatingWeights(zFilePrefix)
                        Dim zGRCWeight As FireRatingWeightItem = zList.Find(Function(x) x.Type = "GRC")
                        Dim zClientWeight As FireRatingWeightItem = zList.Find(Function(x) x.Type = "Client")

                        Dim zObj As New Dictionary(Of Object, String)
                        zObj.Add("FilePrefix", zGRCWeight.FilePrefix)
                        zObj.Add("PhysicalProtectionWeightGRC", zGRCWeight.PhysicalProt)
                        zObj.Add("HumanElementWeightGRC", zGRCWeight.HumanElement)
                        zObj.Add("NaturalHazardsProtectionWeightGRC", zGRCWeight.NatHaz)
                        zObj.Add("BusinessContinuityWeightGRC", zGRCWeight.BCP)
                        zObj.Add("FloodWeightGRC", zGRCWeight.Flood)
                        zObj.Add("EarthquakeWeightGRC", zGRCWeight.Earthquake)
                        zObj.Add("WindstormWeightGRC", zGRCWeight.Windstorm)
                        zObj.Add("ConstructionWeightGRC", zGRCWeight.Construction)
                        zObj.Add("OccupancyWeightGRC", zGRCWeight.Occupancy)
                        zObj.Add("OtherWeightGRC", zGRCWeight.Other)
                        zObj.Add("PhysicalProtectionWeight", zClientWeight.PhysicalProt)
                        zObj.Add("HumanElementWeight", zClientWeight.HumanElement)
                        zObj.Add("NaturalHazardsProtectionWeight", zClientWeight.NatHaz)
                        zObj.Add("BusinessContinuityWeight", zClientWeight.BCP)
                        zObj.Add("FloodWeight", zClientWeight.Flood)
                        zObj.Add("EarthquakeWeight", zClientWeight.Earthquake)
                        zObj.Add("WindstormWeight", zClientWeight.Windstorm)
                        zObj.Add("ConstructionWeight", zClientWeight.Construction)
                        zObj.Add("OccupancyWeight", zClientWeight.Occupancy)
                        zObj.Add("OtherWeight", zClientWeight.Other)
                        zData.Add(zObj)

                    Case "22"
                        zSQL = "spLegendBMFacilityRatingDetailSelect"
                        zRatingKeyId = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FireRatingKeyID)
                        zCmd.CommandText = zSQL
                        zCmd.Parameters.Add(New SqlParameter("@FilePrefix", zFilePrefix))
                        zReader = UtilSQLServer.ExecuteReader(zCmd)
                        While zReader.Read
                            Dim zObj As New Dictionary(Of Object, String)
                            If Not zReader.IsDBNull(zReader.GetOrdinal("BmWeightID")) Then zObj.Add("BmWeightID", zReader.GetValue(zReader.GetOrdinal("BmWeightID")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("FilePrefix")) Then zObj.Add("FilePrefix", zReader.GetValue(zReader.GetOrdinal("FilePrefix")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("MechMaintWeightGRC")) Then zObj.Add("MechMaintWeightGRC", zReader.GetValue(zReader.GetOrdinal("MechMaintWeightGRC")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("ElecMaintWeightGRC")) Then zObj.Add("ElecMaintWeightGRC", zReader.GetValue(zReader.GetOrdinal("ElecMaintWeightGRC")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("SparesWeightGRC")) Then zObj.Add("SparesWeightGRC", zReader.GetValue(zReader.GetOrdinal("SparesWeightGRC")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("HumanElementWeightGRC")) Then zObj.Add("HumanElementWeightGRC", zReader.GetValue(zReader.GetOrdinal("HumanElementWeightGRC")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("BCPWeightGRC")) Then zObj.Add("BCPWeightGRC", zReader.GetValue(zReader.GetOrdinal("BCPWeightGRC")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("MechEquipWeightGRC")) Then zObj.Add("MechEquipWeightGRC", zReader.GetValue(zReader.GetOrdinal("MechEquipWeightGRC")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("ElecEquipWeightGRC")) Then zObj.Add("ElecEquipWeightGRC", zReader.GetValue(zReader.GetOrdinal("ElecEquipWeightGRC")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("BoilersWeightGRC")) Then zObj.Add("BoilersWeightGRC", zReader.GetValue(zReader.GetOrdinal("BoilersWeightGRC")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("OccupancyWeightGRC")) Then zObj.Add("OccupancyWeightGRC", zReader.GetValue(zReader.GetOrdinal("OccupancyWeightGRC")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("ProcEquipWeightGRC")) Then zObj.Add("ProcEquipWeightGRC", zReader.GetValue(zReader.GetOrdinal("ProcEquipWeightGRC")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("CompSysWeightGRC")) Then zObj.Add("CompSysWeightGRC", zReader.GetValue(zReader.GetOrdinal("CompSysWeightGRC")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("MechMaintWeight")) Then zObj.Add("MechMaintWeight", zReader.GetValue(zReader.GetOrdinal("MechMaintWeight")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("ElecMaintWeight")) Then zObj.Add("ElecMaintWeight", zReader.GetValue(zReader.GetOrdinal("ElecMaintWeight")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("SparesWeight")) Then zObj.Add("SparesWeight", zReader.GetValue(zReader.GetOrdinal("SparesWeight")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("HumanElementWeight")) Then zObj.Add("HumanElementWeight", zReader.GetValue(zReader.GetOrdinal("HumanElementWeight")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("OccupancyWeight")) Then zObj.Add("OccupancyWeight", zReader.GetValue(zReader.GetOrdinal("OccupancyWeight")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("BCPWeight")) Then zObj.Add("BCPWeight", zReader.GetValue(zReader.GetOrdinal("BCPWeight")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("MechEquipWeight")) Then zObj.Add("MechEquipWeight", zReader.GetValue(zReader.GetOrdinal("MechEquipWeight")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("ElecEquipWeight")) Then zObj.Add("ElecEquipWeight", zReader.GetValue(zReader.GetOrdinal("ElecEquipWeight")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("BoilersWeight")) Then zObj.Add("BoilersWeight", zReader.GetValue(zReader.GetOrdinal("BoilersWeight")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("ProcEquipWeight")) Then zObj.Add("ProcEquipWeight", zReader.GetValue(zReader.GetOrdinal("ProcEquipWeight")))
                            If Not zReader.IsDBNull(zReader.GetOrdinal("CompSysWeight")) Then zObj.Add("CompSysWeight", zReader.GetValue(zReader.GetOrdinal("CompSysWeight")))
                            zData.Add(zObj)
                        End While
                        zReader.Close()
                    Case Else
                        Throw New Exception("Grid ID supplied is not valid for a legend chart.")
                End Select

                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("gridId", zGridId)
                zJSON.Add("data", zData)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("gridId", Nothing)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        ' CHART PROCEDURES
        Public Function GetChartData(gSafeGuid As String, pIsDrillDown As Boolean) As IO.Stream Implements IRESTServer.GetChartData
            Dim zReturn As System.IO.Stream
            Dim zGSafeId As Integer = UtilGSafe.GetId(gSafeGuid)
            Dim zChart As New GRC.Connect.Libraries.CoreLib.UtilGDC
            ' SET THE FILTER AND CRITERIA PROPERTIES
            If pIsDrillDown = True Then
                zChart.PropChartId = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentChartDrillDownId))
            Else
                zChart.PropChartId = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentChartId))
            End If
            zChart.PropSafeGUID = gSafeGuid
            zChart.PropFilter = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filterChart, zChart.PropChartId)
            zChart.PropCriteria = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.criteriaChart, zChart.PropChartId)
            ' SAVE TO INDIVIDUAL PROPS HERE
            Dim zPropCountry As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_Country)
            Dim zPropDivision As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_Division)
            Dim zPropCustomAccess As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_CustomAccess)
            Dim zPropTIV As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_TIV)
            Dim zPropHazard As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_Hazard)
            Dim zPropTIVValue As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_TIVValue)
            Dim zPropFilePrefix As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)
            zChart.PropParameters.FilePrefix = zPropFilePrefix
            zChart.PropParameters.Country = zPropCountry
            zChart.PropParameters.Division = zPropDivision
            zChart.PropParameters.CustomAccess = zPropCustomAccess
            zChart.PropParameters.TIV = zPropTIV
            zChart.PropParameters.Hazard = zPropHazard
            zChart.PropParameters.TIVValue = zPropTIVValue
            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zChart.GetChartData()))
            Return zReturn
        End Function


        Public Function GetChartPagedData(gSafeGuid As String, pPage As Integer, pPageSize As String, pSort As String) As IO.Stream Implements IRESTServer.GetChartPagedData
            Dim zReturn As System.IO.Stream
            Dim zGSafeId As Integer = UtilGSafe.GetId(gSafeGuid)
            Dim zChart As New GRC.Connect.Libraries.CoreLib.UtilGDC
            zChart.PropChartId = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentChartId))
            zChart.PropSafeGUID = gSafeGuid
            zChart.PropFilter = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filterChart, zChart.PropChartId)
            zChart.PropCriteria = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.criteriaChart, zChart.PropChartId)
            zChart.PropPageNumber = pPage
            zChart.PropPageSize = pPageSize
            zChart.PropSort = pSort
            ' SAVE TO INDIVIDUAL PROPS HERE
            Dim zPropCountry As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_Country)
            Dim zPropDivision As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_Division)
            Dim zPropCustomAccess As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_CustomAccess)
            Dim zPropTIV As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_TIV)
            Dim zPropHazard As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_Hazard)
            Dim zPropTIVValue As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_TIVValue)
            zChart.PropParameters.FilePrefix = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)
            zChart.PropParameters.Country = zPropCountry
            zChart.PropParameters.Division = zPropDivision
            zChart.PropParameters.CustomAccess = zPropCustomAccess
            zChart.PropParameters.TIV = zPropTIV
            zChart.PropParameters.Hazard = zPropHazard
            zChart.PropParameters.TIVValue = CInt(zPropTIVValue & ".0")
            zChart.PropParameters.ApplyLO(UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.settingChart, zChart.PropChartId))
            zChart.PropParameters.ApplyLO(UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.virtualFilterChart, zChart.PropChartId))
            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zChart.GetChartData()))
            Return zReturn
        End Function


        Public Function GetChartTrendingPagedData(gSafeGuid As String, pPage As Integer, pPageSize As String, pSort As String) As IO.Stream Implements IRESTServer.GetChartTrendingPagedData
            Dim zJSON As Dictionary(Of String, Object)
            Dim zReturn As System.IO.Stream
            Try
                ' GATHER INFO
                Dim zGSafeId As Integer = UtilGSafe.GetId(gSafeGuid)
                Dim zChart As New GRC.Connect.Libraries.CoreLib.UtilGDC
                zChart.PropChartId = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentChartId))
                zChart.PropSafeGUID = gSafeGuid
                zChart.PropFilter = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.filterChart, zChart.PropChartId)
                zChart.PropCriteria = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.criteriaChart, zChart.PropChartId)
                zChart.PropPageNumber = pPage
                zChart.PropPageSize = pPageSize
                zChart.PropSort = pSort

                ' SET SORT TO LARGE OBJECT DATA
                UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.sort, pSort, zChart.PropChartId)

                ' SAVE TO INDIVIDUAL PROPS HERE
                Dim zPropCustomAccess As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_CustomAccess)
                Dim zPropDivision As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_Division)
                Dim zPropCurrency As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_Currency)
                Dim zPropTIVValue As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ChartPreFilter_TIVValue)
                ' PROTECT VALUES
                If Not zPropCurrency Is Nothing Or zPropCurrency.Length < 1 Then zPropCurrency = "1"
                ' SET VALUES
                zChart.PropParameters.FilePrefix = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FilePreFix)
                zChart.PropParameters.Currency = zPropCurrency
                zChart.PropParameters.Division = zPropDivision
                zChart.PropParameters.CustomAccess = zPropCustomAccess
                zChart.PropParameters.TIVValue = CInt(zPropTIVValue & ".0")
                zChart.PropParameters.ApplyLO(UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.settingChart, zChart.PropChartId))
                zChart.PropParameters.ApplyLO(UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.virtualFilterChart, zChart.PropChartId))

                ' RETURN DATA
                zJSON = New Dictionary(Of String, Object)
                zJSON.Add("data", zChart.GetFacilityRatingTrendDict(False))
                zJSON.Add("isSuccess", True)
                If zChart.PropDriverCount < 1 Then
                    zJSON.Add("message", "Your selection does not match any location ratings data, or there are no active locations to present. Thank You.")
                Else
                    zJSON.Add("message", Nothing)
                End If

                'My.Computer.FileSystem.WriteAllText("c:\temp\FacilityRatingTrend-Data.json", Newtonsoft.Json.JsonConvert.SerializeObject(zJSON), False) ' TEST TO SEE JSON DATA IN A FILE
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Catch ex As Exception
                zJSON = New Dictionary(Of String, Object)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.GetBaseException.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            End Try
            Return zReturn
        End Function


        Public Function SetChartFacilityPageData(gSafeGuid As String, pIsResetRequired As Boolean, pHTML As String, pCSS As String) As IO.Stream Implements IRESTServer.SetChartFacilityPageData
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            Try
                Dim zGSafeId As Integer = UtilGSafe.GetId(gSafeGuid)
                Dim zChartId As Integer = CInt(UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentChartId))

                ' RESET IF REQUIRED, FIRST TIME THROUGH THE PROCESS
                Dim zPageBreak As String = ""
                If pIsResetRequired Then
                    UtilSafe.ResetLargeObjectData_ByObjectName(zGSafeId, UtilSafe.LargeObjectName.chartHTML)
                Else
                    zPageBreak = "<div style='page-break-after: always;'></div>"
                End If

                ' LOAD THE ORIGINAL
                Dim zDocument As String = UtilSafe.LoadLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.chartHTML, zChartId) & ""

                ' BUILD FILE NAME
                Dim zDateStamp As String = "_" & Format(Now(), "yyyyMMddhhmm")
                Dim zFileName As String = "PrintedChart_" & zDateStamp & ".pdf"
                ' PUT TOGETHER THE CSS AND HTML AND CONVERT FROM SAFE MODE
                Dim zHTML As String = pHTML & ""
                Dim zCSS As String = pCSS & ""
                ' REBUILD ILLEGAL CHARACTERS
                zHTML = Replace(zHTML, "||OPEN||", "<")
                zHTML = Replace(zHTML, "||CLOSE||", ">")
                zHTML = Replace(zHTML, "  ", "")
                ' BUILD DOCUMENT STRING
                zDocument = zDocument & zPageBreak & "<!DOCTYPE html><html><head><title>" & zFileName & "</title><style>"
                zDocument = zDocument & zCSS
                zDocument = zDocument & "</style></head><body><div id='pdf'>"
                zDocument = zDocument & zHTML
                zDocument = zDocument & "</div></body></html>"
                ' SAVE TO THE LARGE OBJECTS TABLE
                UtilSafe.SaveLargeObjectData_ByDataGroup(zGSafeId, UtilSafe.LargeObjectName.chartHTML, zDocument, zChartId)

                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", Nothing)

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zJSON.Add("settings", Nothing)

            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn
        End Function


        ' PROGRAM STATUS 
        Public Function GetProgramStatusData(gSafeGuid As String) As IO.Stream Implements IRESTServer.GetProgramStatusData
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)

            Try
                Dim zGSafeId As Integer = UtilGSafe.GetId(gSafeGuid)
                Dim zCustomAccess As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ReportPreFilter_CustomAccess) & ""
                Dim zDivision As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ReportPreFilter_Division) & ""
                Dim zCustomAccessLabel As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.CustomAccessLabel) & ""
                Dim zPS As New UtilProgramStatusProc
                Dim zDT As DataTable
                'CORRECT THE 'ALL' AND '%' CASES
                If Not zCustomAccess Is Nothing Then
                    If zCustomAccess = "%" Or zCustomAccess.ToLower() = "all" Then
                        zCustomAccess = ""
                    End If
                End If
                If Not zDivision Is Nothing Then
                    If zDivision = "%" Or zDivision.ToLower() = "all" Then
                        zDivision = ""
                    End If
                End If
                zPS.PropSafeGUID = gSafeGuid
                zPS.PropDivision = zDivision
                zPS.PropCustomAccess = zCustomAccess
                zDT = zPS.GetProgramStatusData
                'Dim zData As New Dictionary(Of String, Object)
                Dim zSettings As New Dictionary(Of String, Object)
                zSettings.Add("CustomAccessLabel", zCustomAccessLabel)
                zSettings.Add("CustomAccess", zCustomAccess)
                zSettings.Add("Division", zDivision)
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", zDT)
                zJSON.Add("settings", zSettings)

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zJSON.Add("settings", Nothing)

            End Try

            'Dim zDebug As String = Newtonsoft.Json.JsonConvert.SerializeObject(zJSON)
            'My.Computer.FileSystem.WriteAllText("c:\temp\GetProgramStatusData.json", zDebug, False)

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn
        End Function


        ' AUTO REC FOLLOW UP RESPONSE
        Public Function GetAutoRecStatusData(gSafeGuid As String) As IO.Stream Implements IRESTServer.GetAutoRecStatusData

            ' DATABASE CHANGE NOTES
            ' 1) ADD tblMetaSource RECORD FOR sproc_CalcRecFollowUpStatus (fldId 319)
            ' 2) ADD tblMetaReport RECORD FOR SOURCE ADDED IN STEP 1 (fldId 231)
            ' 3) UPDATE NAVLINK TABLE FOR AUTO REC LINK TO USE REPORT ADDED IN STEP 2 (NavLinkId 20)
            '        SET NAVTARGET TO "recfollowupstatus"
            '        SET NAVREPORTCODE TO 231
            '        SET NAVCONSTANT TO "PageId_RecFollowUpStatusForm"
            '        REMOVE THE WORD "charts" FROM NAVURL

            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)

            Try
                Dim zGSafeId As Integer = UtilGSafe.GetId(gSafeGuid)
                Dim zCustomAccess As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ReportPreFilter_CustomAccess) & ""
                Dim zDivision As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ReportPreFilter_Division) & ""
                Dim zCustomAccessLabel As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.CustomAccessLabel) & ""
                Dim zStartDate As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ReportPreFilter_DateFrom) & ""
                Dim zEndDate As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.ReportPreFilter_DateTo) & ""
                Dim zAR As New UtilRecFollowUpStatus
                Dim zDT As DataTable
                'CORRECT THE 'ALL' AND '%' CASES
                If Not zCustomAccess Is Nothing Then
                    If zCustomAccess = "%" Or zCustomAccess.ToLower() = "all" Then
                        zCustomAccess = ""
                    End If
                End If
                If Not zDivision Is Nothing Then
                    If zDivision = "%" Or zDivision.ToLower() = "all" Then
                        zDivision = ""
                    End If
                End If
                zAR.PropSafeGUID = gSafeGuid
                zAR.PropDivision = zDivision
                zAR.PropCustomAccess = zCustomAccess
                zAR.PropStartDate = zStartDate
                zAR.PropEndDate = zEndDate
                zDT = zAR.GetRecFollowUpStatusData
                Dim zSettings As New Dictionary(Of String, Object)
                zSettings.Add("CustomAccessLabel", zCustomAccessLabel)
                zSettings.Add("CustomAccess", zCustomAccess)
                zSettings.Add("Division", zDivision)
                zSettings.Add("StartDate", zDivision)
                zSettings.Add("EndDate", zDivision)
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", zDT)
                zJSON.Add("settings", zSettings)

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zJSON.Add("settings", Nothing)

            End Try

            'Dim zDebug As String = Newtonsoft.Json.JsonConvert.SerializeObject(zJSON)
            'My.Computer.FileSystem.WriteAllText("c:\temp\RecFollowUpStatus.json", zDebug, False)

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn
        End Function


        ' GET ADMIN GRID DATA
        Public Function GetAdminUserGridData(gSafeGuid As String) As IO.Stream Implements IRESTServer.GetAdminUserGridData
            Dim zReturn As System.IO.Stream
            Dim zData As New Dictionary(Of String, Object)
            Dim zJSON As New Dictionary(Of String, Object)
            'Dim zUsers As New Dictionary(Of String, Object)
            Dim zDropdowns As New Dictionary(Of String, Object)
            Try
                Dim util As New UtilLogin2
                zDropdowns = util.getAdminDropdowns(gSafeGuid)
                'zUsers.Add("users", util.BrowseCCUserActivityGrid_BySafeGuid(gSafeGuid))
                'zJSON.Add("dropdowns", zDropdowns)
                zData.Add("dropdown", zDropdowns)
                zData.Add("users", util.BrowseCCUserActivityGrid_BySafeGuid(gSafeGuid))
                zJSON.Add("data", zData)
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                'zJSON.Add("data", util.BrowseCCUserActivityGrid_BySafeGuid(gSafeGuid))
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        ' GET ADMIN FORM DATA
        Public Function GetAdminUserFormData(pEzyUserId As String) As IO.Stream Implements IRESTServer.GetAdminUserFormData
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            Dim zUsers As New Dictionary(Of String, Object)
            Try
                Dim util As New UtilLogin2
                zUsers.Add("users", util.BrowseCCUserActivityForm_ByEzyUserId(Convert.ToInt32(pEzyUserId)))
                zJSON.Add("data", zUsers)
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                'zJSON.Add("data", util.BrowseCCUserActivityGrid_BySafeGuid(gSafeGuid))
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        ' REMOVE RECORD FROM EZY USER
        Public Function RemoveEzyUser(pEzyUserId As String) As IO.Stream Implements IRESTServer.RemoveEzyUser
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            'Dim zUsers As New Dictionary(Of String, Object)
            Try
                Dim util As New UtilLogin2
                'zUsers.Add("users", util.BrowseCCUserActivityGrid_BySafeGuid(gSafeGuid))
                'zJSON.Add("data", zUsers)
                If util.RemoveEzyUser_ByEzyUserID(Convert.ToInt32(pEzyUserId)) Then
                    'Delete Succeeded
                Else
                    'Delete Unsuccessful
                End If
                zJSON.Add("data", "")
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        ' REMOVE RECORD FROM EZY LOGIN
        Public Function RemoveEzyLogin(pLoginId As String) As IO.Stream Implements IRESTServer.RemoveEzyLogin
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            'Dim zUsers As New Dictionary(Of String, Object)
            Try
                Dim util As New UtilLogin2
                'zUsers.Add("users", util.BrowseCCUserActivityGrid_BySafeGuid(gSafeGuid))
                'zJSON.Add("data", zUsers)
                If util.RemoveEzyLogin_ByLoginID(Convert.ToInt32(pLoginId)) Then
                    'Delete Succeeded
                Else
                    'Delete Unsuccessful
                End If
                zJSON.Add("data", "")
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        ' SAVE USER
        Public Function SaveUser(pJSON As String) As IO.Stream Implements IRESTServer.SaveUser
            Dim zReturn As System.IO.Stream
            Dim uJSON As New UtilJSON(pJSON)
            Dim zJsonDictionary As New Dictionary(Of String, Object)
            zJsonDictionary = uJSON.JSONtoDictionary(pJSON)

            Dim zJSON As New Dictionary(Of String, Object)

            Try
                Dim util As New UtilLogin2

                'zJSON.Add("data", util.BrowseCCUserActivityGrid_BySafeGuid(gSafeGuid))
                'zUsers.Add("users", util.BrowseCCUserActivityGrid_BySafeGuid(pJSON))

                zJSON.Add("data", util.SaveUser(zJsonDictionary))
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        'GET USERS BY EMAIL
        Public Function GetUserByEmail(pEmail As String) As IO.Stream Implements IRESTServer.GetUserByEmail
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)

            Try
                Dim util As New UtilLogin2
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", util.getUsers_ByEmail(pEmail))
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        'VALIDATE IF EMAIL IS VALID
        Public Function ValidateAdminUserForm(pEmail As String, pFilePrefix As String) As IO.Stream Implements IRESTServer.ValidateAdminUserForm
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)

            Try
                Dim zMailRecipient As New System.Net.Mail.MailAddress(pEmail)

                zJSON.Add("isSuccess", True)
                zJSON.Add("isValid", True)
                zJSON.Add("message", "") 'ADD MESSAGE FOR VALIDATION HERE
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", pEmail & " is not a valid formatted email address.")
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            End Try
            Return zReturn
        End Function


        ' GET USER RECLASSIFICATION PRACTICE META DATA
        Public Function GetUserReclassPractices(pGSafeGuid As String) As IO.Stream Implements IRESTServer.GetUserReclassPractices
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)

            Try
                zJSON.Add("data", UtilMetaPractice.GetClientMetaPracticeList(UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.FilePreFix)))
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        ' GET USER DATA
        Public Function GetUserForm(pGSafeGuid As String, pNavigateAction As String, pEzyUserGuid As String) As IO.Stream Implements IRESTServer.GetUserForm
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)

            Try
                Dim zFilePrefix As String = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.FilePreFix)
                zJSON.Add("data", UtilUserReclassification.GetUser(zFilePrefix, pEzyUserGuid, pNavigateAction))
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        ' GET USER RECLASSIFICATION USER DATA
        Public Function GetUserReclassForm(pGSafeGuid As String, pNavigateAction As String, pEzyUserGuid As String, Optional pIsPendingOnly As String = "false", Optional pCurrentIndex As Integer = 1) As IO.Stream Implements IRESTServer.GetUserReclassForm
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)

            Try
                Dim zReclassGUID As String = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.Reclass_ClientReclassificationLinkGUID)
                If pIsPendingOnly.ToLower = "false" Then zJSON.Add("data", UtilUserReclassification.GetReclassUser(zReclassGUID, pEzyUserGuid, pNavigateAction))
                If pIsPendingOnly.ToLower = "true" Then zJSON.Add("data", UtilUserReclassification.GetReclassUserPending(zReclassGUID, pEzyUserGuid, pNavigateAction, pCurrentIndex))
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        ' SAVE USER ACOUNT FORM
        Public Function SaveUserAccountForm(pGSafeGuid As String, pJSON As String) As IO.Stream Implements IRESTServer.SaveUserAccountForm
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            'Dim uJSON As New UtilJSON(pJSON)
            'Dim zJsonDictionary As New Dictionary(Of String, Object)
            'zJsonDictionary = uJSON.JSONtoDictionary(pJSON)
            Try
                'Dim util As New UtilLogin2
                Dim zUser As rowVwClientUsers = Newtonsoft.Json.JsonConvert.DeserializeObject(Of rowVwClientUsers)(pJSON)
                Dim zFilePrefix As String = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.FilePreFix)
                UtilUser.SaveEzyUser(zUser)
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        ' SAVE USER RECLASSIFICATION DATA
        Public Function SaveUserReclassForm(pGSafeGuid As String, pJSON As String) As IO.Stream Implements IRESTServer.SaveUserReclassForm
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            'Dim uJSON As New UtilJSON(pJSON)
            'Dim zJsonDictionary As New Dictionary(Of String, Object)
            'zJsonDictionary = uJSON.JSONtoDictionary(pJSON)
            Try
                'Dim util As New UtilLogin2
                Dim zUserReclass As rowVwClientUsers = Newtonsoft.Json.JsonConvert.DeserializeObject(Of rowVwClientUsers)(pJSON)
                Dim zFilePrefix As String = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.FilePreFix)
                UtilUserReclassification.CertifyUser(UtilGSafe.GetLoginId(pGSafeGuid), zUserReclass, zFilePrefix)
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        ' WHEN ALL CLIENT'S USER RECORDS COMPLETED, RESET RECLASSIFICATION GUID AND SET COMPLETION DATE
        Public Function MarkClientAsCompleted(pGSafeGuid As String) As IO.Stream Implements IRESTServer.MarkClientAsCompleted
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)
            Try
                Dim zFilePrefix As String = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.FilePreFix)
                UtilUserReclassification.MarkAsCompleted(zFilePrefix)
                UtilUserReclassification.SendConfirmationEmail(pGSafeGuid)
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            End Try
            Return zReturn
        End Function


        'RESET PASSWORD
        Public Function ResetPassword(pEmail As String, pPassword As String) As IO.Stream Implements IRESTServer.ResetPassword
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)

            Try
                Dim util As New UtilLogin2
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("passwordReplaced", util.ReplacePassword(pEmail, pPassword))
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            End Try
            Return zReturn
        End Function

        'Get Latitude Longitude Grid
        Public Function GetLatLongGrid(pLatitude As String, pLongitude As String, pUnit As String, pRadius As String, pNameYourSearch As String, pSid As String) As IO.Stream Implements IRESTServer.GetLatLongGrid
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)

            Try
                'Add parms to the parmTable
                UtilMapRadius.AddParms(pLatitude, pLongitude, pUnit, pRadius, pNameYourSearch, pSid)
                'Run StoredProc
                UtilMapRadius.Execute_spGeoLocateRadius(pSid)
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                'zJSON.Add("passwordReplaced", util.ReplacePassword(pEmail, pPassword))
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            End Try
            Return zReturn
        End Function


        'AUTHENTICATE LOGIN
        Public Function AuthenticateLogin(pEmail As String, pPassword As String) As IO.Stream Implements IRESTServer.AuthenticateLogin
            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)

            Try
                Dim util As New UtilLogin2
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", "")
                zJSON.Add("userLoggedIn", util.AuthenticateLogin(pEmail, pPassword))
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
                zJSON.Add("data", Nothing)
                zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            End Try
            Return zReturn
        End Function


        Public Function GetAllMenuItems(pGSafeGuid As String, pPageType As String) As IO.Stream Implements IRESTServer.GetAllMenuItems
            Dim zReturn As System.IO.Stream
            Dim zGSafeId As Integer = UtilGSafe.GetId(pGSafeGuid)
            Dim zJSON As New Dictionary(Of String, Object)

            Try
                'Dim zColl As New GSafeSlideMenuCollection
                'Dim zQry As New GSafeSlideMenuQuery
                'zQry.es.Top = 1
                'zQry.SelectAll()
                'zQry.Where(zQry.GSafeId = zGSafeId)
                'If zColl.Load(zQry) Then

                Dim menu As New UtilMenu()
                Dim menuList As List(Of Object) = menu.GetMenu(pGSafeGuid, UtilSetting.GetAppMode)

                If menuList.Count = 0 Then
                    ' IF NO RECORDS REPORT NOT FOUND
                    zJSON.Add("data", Nothing)
                    zJSON.Add("dataPage", Nothing)
                    zJSON.Add("isSuccess", False)
                    zJSON.Add("message", "No menu JSON records found.")
                Else
                    ' ADD THE PRE-COMPILED JSON DATA
                    zJSON.Add("data", menuList)

                    ' IF THE PAGE TYPE IS TOP, ADD PAGE AND PRACTICE SPECIFIC DATA
                    If pPageType.ToLower() = NavLink.SlideMenuTypes.Top.ToLower() Then
                        zJSON.Add("dataPage", UtilNav.GetPageMenuItems(pGSafeGuid))
                    Else
                        zJSON.Add("dataPage", New List(Of Object))
                    End If

                    'ADD THE UPDATES COUNTERS TO THE JSON OBJECT AND SET THE TRUE/FALSE VALUES
                    Dim zUpdates As UtilUpdates.UpdateResult = UtilUpdates.GetCounts(pGSafeGuid)
                    zJSON.Add(UtilUpdates.UpdateCounterType.MyBatchReportNewCount.ToString, zUpdates.BatchReportNewCount)
                    zJSON.Add(UtilUpdates.UpdateCounterType.RecentUpdateNewCount.ToString, zUpdates.DocLibNewCount)
                    zJSON.Add(UtilUpdates.UpdateCounterType.WhatsNewCount.ToString, zUpdates.WhatsNewCount)

                    'ADD RED BOLD IDENTIFIERS
                    zJSON.Add("isRedRecentUpdates", CBool(zUpdates.DocLibNewCount))
                    zJSON.Add("isRedWhatsNew", CBool(zUpdates.WhatsNewCount))
                    zJSON.Add("isRedMyBatchReports", CBool(zUpdates.BatchReportNewCount))

                    ' ADD NAV LINK ID
                    zJSON.Add("CONST_NavId_RecentUpdates", CoreLib.UtilConstants.PageId_RecentUpdates)
                    zJSON.Add("CONST_NavId_WhatsNew", CoreLib.UtilConstants.PageId_WhatsNew)
                    zJSON.Add("CONST_NavId_MyBatchReports", CoreLib.UtilConstants.PageId_myBatchReports)

                    ' GET THE PLAIN TEXT OF THE LINKS THAT NEED CLIENT SIDE REPLACEMENTS
                    zJSON.Add("textRecentUpdates", CoreLib.UtilNavLink.GetNavLinkText(CoreLib.UtilConstants.PageId_RecentUpdates))
                    zJSON.Add("textWhatsNew", CoreLib.UtilNavLink.GetNavLinkText(CoreLib.UtilConstants.PageId_WhatsNew))
                    zJSON.Add("textMyBatchReports", CoreLib.UtilNavLink.GetNavLinkText(CoreLib.UtilConstants.PageId_myBatchReports))

                    zJSON.Add("isSuccess", True)
                    zJSON.Add("message", Nothing)
    
                End If

            Catch ex As Exception
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn

        End Function

        Public Function GetPageMenuItems(pGSafeGuid As String) As IO.Stream Implements IRESTServer.GetPageMenuItems
            Dim zReturn As System.IO.Stream
            Dim zGSafeId As Integer = UtilGSafe.GetId(pGSafeGuid)
            Dim zJSON As New Dictionary(Of String, Object)

            Try
                zJSON.Add("data", UtilNav.GetPageMenuItems(pGSafeGuid))
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", Nothing)

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn

        End Function


        'Public Function GetPracticeMenuItems(pGSafeGuid As String) As IO.Stream Implements IRESTServer.GetPracticeMenuItems
        '    Dim zReturn As System.IO.Stream
        '    Dim zJSON As New Dictionary(Of String, Object)

        '    ' DEBUGGING MENU ITEMS
        '    Dim zDebugMode As Boolean = Diagnostics.Debugger.IsAttached
        '    'If GRC.Connect.Libraries.CoreLib.UtilSetting.GetAppMode() = GRC.Connect.Libraries.CoreLib.UtilSetting.AppMode.Dev Then ' Or GRC.Connect.Libraries.CoreLib.UtilSetting.GetAppMode() = GRC.Connect.Libraries.CoreLib.UtilSetting.AppMode.Test Then
        '    '    zDebugMode = True
        '    'End If

        '    ' GET THE LIST OF PRACTICES AVAILABLE FROM THE tblMetaPractice TABLE
        '    Try
        '        Dim zList As New List(Of Object)
        '        Dim zColl As List(Of rowTblMetaPractice)
        '        Dim zCmd As New SqlClient.SqlCommand("SELECT * FROM [dbo].[tblMetaPractice] WHERE [fldPracticeCode] <> 0 AND [fldName] NOT LIKE '%Flood%' AND [fldName] NOT LIKE '%Wind%' AND [fldName] NOT LIKE '%Seismic%' ORDER BY [fldSortOrder]")
        '        zColl = TblMetaPractice.LoadData(zCmd)
        '        For Each zRow As rowTblMetaPractice In zColl
        '            ' FOR DEBUGGING AND TESTING
        '            Dim zTitle As String = ""
        '            Dim zDebugText As String = ""
        '            If zDebugMode Then
        '                zTitle = ""
        '                zTitle = zTitle & "NavLink Id: " & zRow.colFldNavLinkId & "&#10;"
        '                'zTitle = zTitle & "Slide Menu Id: " & zRow..colFldSlideMenuId & "&#10;"
        '                'zTitle = zTitle & "Slide Group Id: " & zRow.colFldSlideGroupId & "&#10;"
        '                'zTitle = zTitle & "Slide Parent Id: " & zRow.colFldSlideParentId & "&#10;"
        '                'zTitle = zTitle & "Slide Order: " & zRow.colFldSlideOrder & "&#10;"
        '                'zTitle = zTitle & "Nav Target: " & zRow.colFldNavTarget & "&#10;"
        '                'zTitle = zTitle & "Nav Chart Id: " & zRow.colFldNavChartId & "&#10;"
        '                'zTitle = zTitle & "Nav Grid Id: " & zRow.colFldNavGridId & "&#10;"
        '                'zTitle = zTitle & "Nav Extract Id: " & zRow.colFldNavExtractId & "&#10;"
        '                zTitle = " title='" & zTitle & "' "
        '                zDebugText = "<label style='font-size:6pt;'>"
        '                zDebugText = zDebugText & " NavId: " & zRow.colFldNavLinkId
        '                'zDebugText = zDebugText & " SlideId: " & zRow.colFldSlideMenuId
        '                zDebugText = zDebugText & "</label>"
        '            End If
        '            ' BUILD THE ITEM
        '            Dim zData As New Dictionary(Of String, Object)
        '            zData.Add("fldId", zRow.colFldId)
        '            zData.Add("fldPracticeCode", zRow.colFldPracticeCode)
        '            zData.Add("pageId", zRow.colFldNavLinkId)
        '            zData.Add("locListId", zRow.colFldLocListId)
        '            zData.Add("gridId", zRow.colFldGridId)
        '            zData.Add("textLabel", zRow.colFldPracticeNameText)
        '            zData.Add("text", "<span class='menuItem' " & zTitle & "><span class='menuIcon' style='background-image: url(""../../../Home_{{VER}}/Images/carousel/" & zRow.colFldIconName & """);'></span>" & zRow.colFldPracticeNameText & "</span>" & zDebugText & "</span>") 'zRow.colFldPracticeNameText) '
        '            zData.Add("encoded", False)
        '            zData.Add("cssClass", Nothing)
        '            zData.Add("url", Nothing)
        '            zData.Add("items", Nothing)
        '            zList.Add(zData)
        '        Next
        '        zJSON.Add("isSuccess", True)
        '        zJSON.Add("message", Nothing)
        '        zJSON.Add("data", zList)

        '    Catch ex As Exception
        '        zJSON.Add("isSuccess", False)
        '        zJSON.Add("message", ex.Message)
        '        zJSON.Add("data", Nothing)
        '    End Try

        '    zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
        '    Return zReturn
        'End Function


        Public Function GetAllCarouselStats(pGSafeGuid As String) As IO.Stream Implements IRESTServer.GetAllCarouselStats
            Throw New NotImplementedException()
            'Dim zReturn As System.IO.Stream
            'Dim zJSON As New Dictionary(Of String, Object)
            'Dim zData As New List(Of Object)

            'Try
            '    zData = CoreLib.UtilCarousel.GetAllCarouselStats2(pGSafeGuid)
            '    zJSON.Add("isSuccess", True)
            '    zJSON.Add("message", Nothing)
            '    zJSON.Add("data", zData)

            'Catch ex As Exception
            '    zJSON.Add("isSuccess", False)
            '    zJSON.Add("message", ex.Message)
            '    zJSON.Add("data", Nothing)
            'End Try

            'zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            'Return zReturn
        End Function


        Public Function GetBatchNavLinks(pGSafeGuid As String) As IO.Stream Implements IRESTServer.GetBatchNavLinks
            Dim zReturn As System.IO.Stream
            Dim zGSafeId As Integer = UtilGSafe.GetId(pGSafeGuid)
            Dim zJSON As New Dictionary(Of String, Object)

            Try
                Dim zUtilNavLink As New UtilNavLink(pGSafeGuid)
                zJSON.Add("data", zUtilNavLink.GetBatchReportLinks2) ' ADD CALL TO FUNCTION HERE
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", Nothing)

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn

        End Function


        Public Function GetTestForm(pGSafeGuid As String) As IO.Stream Implements IRESTServer.GetTestForm
            Dim zReturn As System.IO.Stream
            Dim zGSafeId As Integer = UtilGSafe.GetId(pGSafeGuid)
            Dim zJSON As New Dictionary(Of String, Object)

            Try
                ' SAMPLE TEST FORM DIRECT FROM DATABASE
                Dim zTestForm As String = "<div id='divDetailForm_#= uid #' class='divDetailForm'><div id='RecFVInfo'><div><span id='lblRecNo'>Rec No.</span><input id='RecYear' readonly='readonly' type='text' value='#= RecYear #' /><input id='RecMonth' readonly='readonly' type='text' value='#= RecMonth #' /><input id='RecNumber' readonly='readonly' type='text' value='#= RecNumber #' /><input id='RecSubletter' readonly='readonly' type='text' value='#= RecSubletter #' /><span id='lblCode'>Code</span><input id='RecCode' readonly='readonly' type='text' value='#= RecCode #' /><span id='lblRecCategory'>Rec. Impact</span><input id='RecCategory' readonly='readonly' type='text' value='#= RecCategory #' /><span id='lblRecStatus'>Rec. Status</span><input id='RecStatus' readonly='readonly' type='text' value='#= RecStatus #' /><span id='lblStatusDate'>Status Date</span><input id='StatusDate' readonly='readonly' type='text' value='#= StatusDate #' /></div><div><span id='lblHazard'>Hazard</span><input id='Hazard' readonly='readonly' type='text' value='#= Hazard #' /><span id='lblPrimaryRecType'>Primary Rec. Type</span><input id='PrimaryRecType' readonly='readonly' type='text' value='#= PrimaryRecType #' /><span id='lblSecondaryRecType'>Secondary Rec. Type</span><input id='SecondaryRecType' readonly='readonly' type='text' value='#= SecondaryRecType #' /></div><div><span id='lblRecKeyWords'>Rec. Key Words</span><input id='RecKeyWords' readonly='readonly' type='text' value='#= RecKeyWords #' /></div><div style='margin-bottom: 0px; padding-bottom: 0px;'><span id='lblCurrentLossEst'>Current Loss Est.</span><span id='lblCompletedLossEst'>Completed Loss Est.</span><span id='lblEstCostToComplete'>Est. Cost to Complete</span><span id='lblSavingsRatioNoLE'>Savings Ratio</span></div><div style='padding-top: 0px; display: none;' id='ActualLEValues'><span id='lblActualLEBefore'>USD</span><input id='LossExpectancyBeforeActual' class='ActualLEBefore' readonly='readonly' type='text' value='#= LossExpectancyBeforeActual #' /><span id='lblActualLEAfter'>USD</span><input id='LossExpectancyAfterActual' class='ActualLEAfter' readonly='readonly' type='text' value='#= LossExpectancyAfterActual #' /><span id='lblActualLECost'>USD</span><input id='ActualCostToComplete' class='ActualLECost' readonly='readonly' type='text' value='#= ActualCostToComplete #' /><span id='lblSavingsRatio'>Savings Ratio</span></div><div><span id='lblLEBefore'>(Range)</span><input id='LEBefore' class='LEBefore' readonly='readonly' type='text' value='#= LossExpectancyBefore #' /><span id='lblLEAfter'>(Range)</span><input id='LEAfter' class='LEAfter' readonly='readonly' type='text' value='#= LossExpectancyAfter #' /><span id='lblLECost'>(Range)</span><input id='CostToComplete' class='LECost' readonly='readonly' type='text' value='#= CostToComplete #' /><input id='SavingsRatio' readonly='readonly' type='text' value='#= SavingsRatio #' /></div><div><span id='lblResponseDate'>Resp. Date</span><input id='ResponseDate' readonly='readonly' type='text' value='#= ResponseDate #' /><span id='lblResponseFrom'>Resp. From</span><input id='ResponseFrom' readonly='readonly' type='text' value='#= ResponseFrom #' /><span id='lblActualCost'>Actual Cost To Complete</span></div><div><span id='lblExpectedCompletionDate'>Exp'd Compl. Date</span><input id='ExpectedCompletionDate' readonly='readonly' type='text' value='#= ExpectedCompletionDate #' /><span id='lblIntendedAction'>Rec. Intended Action</span><input id='IntendedAction' readonly='readonly' type='text' value='#= IntendedAction #' /><input id='Text1' readonly='readonly' type='text' /></div><div><span id='lblPlantComment'>Facility Comment</span><input id='PlantComment' readonly='readonly' type='text' value='#= PlantComment #' /></div></div><br /><div class='tableDiv'><div style='margin: auto; width: 100%; text-align: center;'><span style='margin: auto; width: 100%; text-align: center;'><button class='k-button' onclick='globalCloseFormView(); return false;'>Close</button></span></div></div></div><script> var zLink = ""<link rel='stylesheet' type='text/css' href='../../../css/FormView/FormViewFireRecommendations.css'>""; $(zLink).appendTo('head'); setTimeout(function () { var zUID = '#= uid #'; if (globalClientFeatures.toLowerCase().indexOf('l') > -1) { $('\\#divDetailForm_' + zUID + ' \\#ActualLEValues').show(1); } else { $('\\#divDetailForm_' + zUID + ' \\#ActualLEValues').hide(1); } var colorItems = [ 'RecCategory' ]; for (i = 0; i < colorItems.length; i++){ var zColor = 'transparent'; zColor = $('[data-uid=' + zUID + '] .' + colorItems[i] + 'Color').css('background-color'); $('\\#divDetailForm_' + zUID + ' \\#' + colorItems[i] + '').css('background-color', zColor); } $('\\#divDetailForm_' + zUID + ' input').each(function(){ if( $(this).attr('id').toLowerCase().indexOf('date') > -1 ){ $(this).val(global.formatShortDateWithMonth($(this).val())); } }); $('\\#divDetailForm_' + zUID + ' input').each(function(){ if( ($(this).val() == 'null') || ($(this).val() == 'undefined') ){ $(this).val(''); } }); }, 50); </script>"

                ' SAMPLE REPLACERS AND CLEAN UP FOR ESCAPED CARACTERS
                zTestForm = zTestForm.Replace("#= ", "")
                zTestForm = zTestForm.Replace(" #", "")
                zTestForm = zTestForm.Replace("\\#", "#")

                zJSON.Add("data", zTestForm)
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", Nothing)

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn

        End Function


        ''CREATE LOGIN
        'Public Function CreateLogin(pEmail As String, pPassword As String, pInternal As Boolean, pPasswordReminderSentFlag As Boolean) As IO.Stream Implements IRESTServer.CreateLogin
        '    Dim zReturn As System.IO.Stream
        '    Dim zJSON As New Dictionary(Of String, Object)

        '    Try
        '        Dim util As New UtilLogin2
        '        zJSON.Add("isSuccess", True)
        '        zJSON.Add("message", "")
        '        zJSON.Add("userCreated", util.CreateLogin(pEmail, pPassword, pInternal, pPasswordReminderSentFlag))
        '        zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))

        '    Catch ex As Exception
        '        zJSON.Add("isSuccess", False)
        '        zJSON.Add("message", ex.Message)
        '        zJSON.Add("data", Nothing)
        '        zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
        '    End Try
        '    Return zReturn
        'End Function


        ' HELPER FUNCTION FOR RETURNING JSON
        Private Function JsonpWrap(pCallback As String, pIn As String) As System.IO.Stream
            Dim zReturn As String = ""
            zReturn = pCallback & "(" & pIn & ");"
            ServiceModel.Web.WebOperationContext.Current.OutgoingResponse.ContentType = "application/javascript"
            Return New System.IO.MemoryStream(Encoding.UTF8.GetBytes(zReturn))
        End Function


        Private Function JsonWrap(pIn As String) As System.IO.Stream
            Dim zReturn As String = ""
            zReturn = pIn
            ServiceModel.Web.WebOperationContext.Current.OutgoingResponse.ContentType = "application/javascript"
            Return New System.IO.MemoryStream(Encoding.UTF8.GetBytes(zReturn))
        End Function

        'Private Function GetChildRecords(MenuId As Integer, pGSafeId As String) As List(Of Integer)
        '    Dim zReturn As New List(Of Integer)

        '    Dim zColl As New ViewCCGSafeSitemapItemsCollection
        '    Dim zQry As New ViewCCGSafeSitemapItemsQuery

        '    zQry.SelectAll()
        '    zQry.Where(zQry.NavVisible <> False, zQry.GSafeId = pGSafeId, zQry.SlideParentId = MenuId)
        '    zQry.OrderBy(zQry.NavSiteMapKeyWord.Ascending, zQry.NavParentLinkId.Ascending, zQry.NavOrder.Ascending)
        '    zColl.Load(zQry)
        '    For Each zItem In zColl
        '        zReturn.Add(zItem.SlideMenuId)
        '    Next
        '    Return zReturn
        'End Function

        'Private Sub CreateChain(record As Dictionary(Of String, Object), ByRef zAllData As List(Of Object))
        '    'For Each record In zAllData
        '    '    If rootId = record("slideMenuId") Then
        '    If record("slideParentId") = 0 Then
        '        'Top level container
        '        '(REMOVE)	Save the Top level record (that has the concatenated items) to zReturnList
        '        'Exit the loop	-->		
        '        Exit Sub
        '    Else
        '        For Each parentRecord In zAllData
        '            If record("slideParentId") = parentRecord("slideMenuId") Then
        '                If parentRecord("items") Is Nothing Then
        '                    Dim zNewList As New List(Of Object)
        '                    parentRecord("items") = zNewList
        '                End If
        '                If parentRecord("items").Contains(record) Then
        '                    'Don't do anything since the record does not exist

        '                Else
        '                    'Add the record
        '                    parentRecord("items").Add(record)
        '                    If parentRecord("items").Count <> 0 Then
        '                        'Sort the List
        '                        bubbleSort(parentRecord("items"), parentRecord("items").Count)
        '                    End If
        '                End If

        '                CreateChain(parentRecord("slideMenuId"), zAllData)   'Recurrsive function
        '            End If
        '        Next
        '    End If
        '    '    End If
        '    'Next
        'End Sub

        'Private Sub bubbleSort(ByRef dataset As List(Of Object), ByVal n As Integer)

        '    Dim i, j As Integer
        '    For i = 0 To n Step 1
        '        For j = n - 1 To i + 1 Step -1
        '            If (dataset(j)("slideOrder") < dataset(j - 1)("slideOrder")) Then
        '                Dim temp As Object = dataset(j)
        '                dataset(j) = dataset(j - 1)
        '                dataset(j - 1) = temp
        '                'Dim temp As Integer = dataset(j)("slideOrder")
        '                'dataset(j)("slideOrder") = dataset(j - 1)("slideOrder")
        '                'dataset(j - 1)("slideOrder") = temp
        '            End If
        '        Next
        '    Next
        'End Sub

        ''' <summary>
        ''' Checks to see if the Print report on the various form views have parameters
        ''' </summary>
        ''' <param name="gSafeGuid"></param>
        ''' <returns>Boolean</returns>
        ''' <remarks></remarks>
        Public Function FormReportHasParameters(gSafeGuid As String) As IO.Stream Implements IRESTServer.FormReportHasParameters

            Dim zReturn As System.IO.Stream
            Dim zJSON As New Dictionary(Of String, Object)

            Try
                Dim zReportId As String = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.FormReportId)
                Dim zHasParameters As Boolean = False
                If IsNumeric(zReportId) Then zHasParameters = UtilReporting.ReportHasParameters(CInt(zReportId))
                zJSON.Add("data", zHasParameters) ' ADD CALL TO FUNCTION HERE
                zJSON.Add("url", IIf(zHasParameters, "../../Reports/?sid=" & gSafeGuid & "&action=PrintFormReport", Nothing))
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", Nothing)

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("url", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn

        End Function

        Public Function IsEngineerReportAvailable(gSafeGuid As String, pFileNo As String, pPracticeId As Integer) As IO.Stream Implements IRESTServer.IsEngineerReportAvailable

            Dim zFileNo As String = pFileNo
            Dim zGridId As Integer = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentGridId)
            Dim zGrid As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(zGridId)
            Dim zServiceId As Integer = pPracticeId

            Dim zJSON As New Dictionary(Of String, Object)
            Dim zReturn As System.IO.Stream

            Try
                Dim zData As Boolean
                If pPracticeId > 0 OrElse zGrid.colFldMetaPracticeId Then
                    If IsNumeric(zGrid.colFldMetaPracticeId) Then
                        zData = UtilDocLib.IsEngineeringReportAvailable(zFileNo, zGrid.colFldMetaPracticeId)
                    Else
                        zData = UtilDocLib.IsEngineeringReportAvailable(zFileNo, pPracticeId)
                    End If
                End If

                zJSON.Add("data", zData) ' ADD CALL TO FUNCTION HERE
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", Nothing)

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("url", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn

        End Function


        Public Function IsDiagramReportAvailable(gSafeGuid As String, pFileNo As String) As IO.Stream Implements IRESTServer.IsDiagramReportAvailable

            Dim zFileNo As String = pFileNo
            Dim zGridId As Integer = UtilGSafe.GetValue(gSafeGuid, UtilGSafe.KeyName.currentGridId)
            Dim zGrid As rowTblMetaGrid = TblMetaGrid.LoadByPrimaryKey(zGridId)

            Dim zJSON As New Dictionary(Of String, Object)
            Dim zReturn As System.IO.Stream

            Try
                Dim zData As Boolean
                zData = UtilDocLib.IsDiagramReportAvailable(zFileNo)

                zJSON.Add("data", zData) ' ADD CALL TO FUNCTION HERE
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", Nothing)

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("url", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn

        End Function

        Public Function SaveLocationLevelFireRecommendation(entity As VwFireRecommendationsBaseView) As jsResponse(Of VwFireRecommendationsBaseViewCollection, VwFireRecommendationsBaseView) Implements IRESTServer.SaveLocationLevelFireRecommendation

            Dim zReturn As New jsResponse(Of VwFireRecommendationsBaseViewCollection, VwFireRecommendationsBaseView)
            If entity.es.IsModified Then
                Dim zRec As New GRC.Connect.Libraries.CoreLib.BusinessObjects.FireRecommendations
                zRec.LoadByPrimaryKey(entity.RecUniqueID)

                For Each modCol As String In entity.es.ModifiedColumns
                    zRec.GetType.GetProperty(entity.es.Meta.Columns(modCol).PropertyName).SetValue(zRec, entity.GetType.GetProperty(modCol).GetValue(entity))
                Next

                Dim id As String = HttpContext.Current.Request.Cookies(UtilCookieUser.COOKIE_USER_COOKIENAME)(UtilCookieUser.COOKIE_USER_APPENTRYID)
                zRec.UpdateBy = UtilAppEntry.GetAppEntry(id).colFldUserName
                zRec.Save()

            End If

            zReturn.entity = entity

            Return zReturn

        End Function

        Public Function GetLocationLevelFireRecommendations(pParms As String) As jsResponse(Of VwFireRecommendationsBaseViewCollection, VwFireRecommendationsBaseView) Implements IRESTServer.GetLocationLevelFireRecommendations

            Dim zResponse As New jsResponse(Of VwFireRecommendationsBaseViewCollection, VwFireRecommendationsBaseView)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zSafeGuidOrFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)
            Dim zLimit As String = zParms(2)  'All or One
            Dim zIsAutoRec As Boolean = zParms(3)

            '***GRC.Connect.Ed - replace with class properties to get GSafeDetail DataName 7/31/2015
            'Dim zFileNo As String = Libraries.CoreLib.UtilGSafe.GetValue(zSafeGUID, "FileNo")

            Dim zFileNo As String = ""
            If zIsAutoRec Then
                zFileNo = zSafeGuidOrFileNo
            Else
                zFileNo = UtilGSafe.GetValue(zSafeGuidOrFileNo, UtilGSafe.KeyName.FileNo)
            End If

            Try
                Dim zColl As New VwFireRecommendationsBaseViewCollection
                Dim zQry As New VwFireRecommendationsBaseViewQuery()
                zQry.Where(zQry.FileNo = zFileNo)
                zQry.SelectAll()
                If UBound(zParms) > 1 Then
                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                'auto recs should show active recs only
                If zIsAutoRec Then
                    zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                End If

                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecMonth, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecSubletter, esOrderByDirection.Ascending)

                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .RecUniqueID = 0
                        .FileNo = "Not Found"
                        .RecYear = 0
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecSubletter = ""
                        .RecCategory = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecCode = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeyWords = ""
                        .LossExpectancyBefore = ""
                        .LossExpectancyAfter = ""
                        .CostToComplete = ""
                        .SavingsRatio = 0
                        .ResponseDate = "1/1/1900"
                        .ResponseFrom = ""
                        .PlantComment = ""
                        .ExpectedCompletionDate = "1/1/1900"
                        .IntendedAction = ""
                        .LossExpectancyBeforeActual = 0
                        .LossExpectancyAfterActual = 0
                        .CostToCompleteActual = 0
                        .Hazard = ""
                        .ActualCostToComplete = 0
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As VwFireRecommendationsBaseView In zColl
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                    If Not zItem.ThirdLevelRespDate Is Nothing Then
                        zItem.ThirdLevelRespDate = zTime.ServerToUTC(zItem.ThirdLevelRespDate, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse

        End Function

        Public Function GetLocationLevelFireRatingAverages(pGSafeGuid As String) As IO.Stream Implements IRESTServer.GetLocationLevelFireRatingAverages

            Dim zFileNo As String = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.FileNo)

            Dim zJSON As New Dictionary(Of String, Object)
            Dim zReturn As System.IO.Stream

            Try
                Dim zData As List(Of RatingAchievableAverage)
                zData = UtilRating.GetFireFacilityRatingAverages(zFileNo)

                zJSON.Add("data", zData) ' ADD CALL TO FUNCTION HERE
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", Nothing)

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("url", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn

        End Function

        Public Function GetLocationLevelFireRecByFileNo(pParms As String) As jsResponse(Of VwFireRecommendationsBaseViewCollection, VwFireRecommendationsBaseView) Implements IRESTServer.GetLocationLevelFireRecByFileNo

            Dim zResponse As New jsResponse(Of VwFireRecommendationsBaseViewCollection, VwFireRecommendationsBaseView)()
            Dim zParms() As String = Split(pParms, "|")
            Dim zFileNo As String = zParms(0)
            Dim zHemisphere As String = zParms(1)

            Try
                Dim zColl As New VwFireRecommendationsBaseViewCollection
                Dim zQry As New VwFireRecommendationsBaseViewQuery()

                zQry.SelectAll()

                If UBound(zParms) > 1 Then
                    Dim zLimit As String = zParms(2)  'All or One

                    If zLimit.ToLower = "One".ToLower Then
                        zQry.es.Top = 1
                    End If
                End If

                zQry.Where(zQry.FileNo = zFileNo)
                zQry.Where(zQry.RecStatus.ToLower() <> "conf completed" And zQry.RecStatus.ToLower() <> "advisory" And zQry.RecStatus.ToLower() <> "removed")
                'zQry.Where(zQry.ResponseDate.IsNull Or zQry.ResponseDate < zQry.StatusDate)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecYear, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecMonth, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecNumber, esOrderByDirection.Ascending)
                zQry.OrderBy(FireRecommendationsMetadata.ColumnNames.RecSubletter, esOrderByDirection.Ascending)

                zColl.Load(zQry)

                If zColl.Count = 0 Then
                    zColl.AddNew() 'create a blank record when no matching records existing
                    With zColl(0)
                        .RecUniqueID = 0
                        .FileNo = "Not Found"
                        .RecYear = 0
                        .RecMonth = ""
                        .RecNumber = 0
                        .RecSubletter = ""
                        .RecCategory = ""
                        .RecStatus = ""
                        .StatusDate = "1/1/1900"
                        .RecCode = ""
                        .PrimaryRecType = ""
                        .SecondaryRecType = ""
                        .RecKeyWords = ""
                        .LossExpectancyBefore = ""
                        .LossExpectancyAfter = ""
                        .CostToComplete = ""
                        .SavingsRatio = 0
                        .ResponseDate = "1/1/1900"
                        .ResponseFrom = ""
                        .PlantComment = ""
                        .ExpectedCompletionDate = "1/1/1900"
                        .IntendedAction = ""
                        .LossExpectancyBeforeActual = 0
                        .LossExpectancyAfterActual = 0
                        .CostToCompleteActual = 0
                        .Hazard = ""
                        .ActualCostToComplete = 0
                    End With
                End If

                'CONVERT DATE TIME TO PREVENT BROWSER TIMEZONE CONVERSION
                Dim zTime As New UtilTime
                For Each zItem As VwFireRecommendationsBaseView In zColl
                    'Dim zColumn As TemplateColumn
                    If Not zItem.ExpectedCompletionDate Is Nothing Then
                        zItem.ExpectedCompletionDate = zTime.ServerToUTC(zItem.ExpectedCompletionDate, zHemisphere)
                    End If
                    'If Not zItem.FollowupDate Is Nothing Then
                    '    zItem.FollowupDate = zTime.ServerToUTC(zItem.FollowupDate, zHemisphere)
                    'End If
                    If Not zItem.MgmtRespDate Is Nothing Then
                        zItem.MgmtRespDate = zTime.ServerToUTC(zItem.MgmtRespDate, zHemisphere)
                    End If
                    'If Not zItem.OriginationDate Is Nothing Then
                    '    zItem.OriginationDate = zTime.ServerToUTC(zItem.OriginationDate, zHemisphere)
                    'End If
                    'If Not zItem.PreviousInspectionDate Is Nothing Then
                    '    zItem.PreviousInspectionDate = zTime.ServerToUTC(zItem.PreviousInspectionDate, zHemisphere)
                    'End If
                    'If Not zItem.RecConfirmedDate Is Nothing Then
                    '    zItem.RecConfirmedDate = zTime.ServerToUTC(zItem.RecConfirmedDate, zHemisphere)
                    'End If
                    If Not zItem.ResponseDate Is Nothing Then
                        zItem.ResponseDate = zTime.ServerToUTC(zItem.ResponseDate, zHemisphere)
                    End If
                    If Not zItem.StatusDate Is Nothing Then
                        zItem.StatusDate = zTime.ServerToUTC(zItem.StatusDate, zHemisphere)
                    End If
                Next

                zResponse.collection = zColl

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

        Public Function GetClientRatingRanges(pGSafeGuid As String) As IO.Stream Implements IRESTServer.GetClientRatingRanges
            Dim id As Integer = UtilGSafe.GetId(pGSafeGuid)
            Dim metaPracticeId As String = UtilGSafe.GetValue(id, UtilGSafe.KeyName.MetaPracticeId)
            Dim ratingKeyId As String = UtilGSafe.GetValue(id, UtilGSafe.KeyName.FireRatingKeyID)

            Dim zJSON As New Dictionary(Of String, Object)
            Dim zReturn As System.IO.Stream

            Try
                Dim zData As List(Of rowVwMetaRatingKeyRange)
                zData = razor.VwMetaRatingKeyRange.LoadByKey(ratingKeyId)

                zJSON.Add("data", zData) ' ADD CALL TO FUNCTION HERE
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", Nothing)

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("url", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn
        End Function

        Public Function GetRatingByRecLeData(pGSafeGuid As String, pGridFilterGuid As String, pMetaPracticeID As Integer) As IO.Stream Implements IRESTServer.GetRatingByRecLeData

            Dim zJSON As New Dictionary(Of String, Object)
            Dim zReturn As System.IO.Stream
            Dim zMetaPractice As UtilMetaPractice.Practices = [Enum].Parse(GetType(UtilMetaPractice.Practices), pMetaPracticeID)
            Dim id As Integer = UtilGSafe.GetId(pGSafeGuid)
            Dim filter As String = UtilGSafe.GetValue(pGSafeGuid, pGridFilterGuid)

            Try
                Dim zData As List(Of UtilBubbleChart.RatingByRecLeItem) = Nothing

                If zMetaPractice = UtilMetaPractice.Practices.Fire Then
                    zData = UtilBubbleChart.GetRatingByRecLeData(id, UtilMetaPractice.Practices.Fire, filter)
                Else
                    zData = UtilBubbleChart.GetRatingByRecLeData(id, UtilMetaPractice.Practices.BoilerAndMachinery, filter)
                End If

                zJSON.Add("data", zData) ' ADD CALL TO FUNCTION HERE
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", Nothing)

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("url", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn

        End Function

        Public Function GetMetaMenu(pGSafeGuid As String, pNode As String) As IO.Stream Implements IRESTServer.GetMetaMenu
            Dim zFileNo As String = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.FileNo)

            Dim zJSON As New Dictionary(Of String, Object)
            Dim zReturn As System.IO.Stream

            Try
                Dim UtilMenu As New UtilMetaMenu(pGSafeGuid)
                Dim zData As List(Of UtilMetaMenu.MetaMenuItem) = UtilMenu.GetMenu(pNode, pGSafeGuid).OrderBy(Function(x) x.SortOrder).ToList()

                zJSON.Add("data", zData) ' ADD CALL TO FUNCTION HERE
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", Nothing)

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("url", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn

        End Function

        Public Function GetCustomAccessLabel(pGSafeGuid As String) As IO.Stream Implements IRESTServer.GetCustomAccessLabel
            Dim zJSON As New Dictionary(Of String, Object)
            Dim zReturn As System.IO.Stream
            Try
                Dim customAccessLabel As String = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.CustomAccessLabel)
                zJSON.Add("data", customAccessLabel) ' ADD CALL TO FUNCTION HERE
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", Nothing)
            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("url", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn
        End Function

        Public Function SaveGridFilter(pGSafeGuid As String, pFilter As String) As IO.Stream Implements IRESTServer.SaveGridFilter

            Dim zJSON As New Dictionary(Of String, Object)
            Dim zReturn As System.IO.Stream

            Try
                Dim zData As String = Guid.NewGuid.ToString()
                UtilGSafe.SetValue(pGSafeGuid, zData, pFilter, "Grid Filter")

                zJSON.Add("data", zData) ' ADD CALL TO FUNCTION HERE
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", Nothing)

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("url", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn
        End Function

        Public Function GetActiveAccountServices(pGSafeGuid As String) As IO.Stream Implements IRESTServer.GetActiveAccountServices
            Dim zJSON As New Dictionary(Of String, Object)
            Dim zReturn As System.IO.Stream

            Try
                Dim zFp As String = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.FilePreFix)
                zJSON.Add("data", UtilAccount.GetServices(zFp)) ' ADD CALL TO FUNCTION HERE
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", Nothing)

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("url", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn
        End Function

        Public Function GetActiveAccountServiceContacts(pGSafeGuid As String) As IO.Stream Implements IRESTServer.GetActiveAccountServiceContacts
            Dim zJSON As New Dictionary(Of String, Object)
            Dim zReturn As System.IO.Stream

            Try
                Dim zFp As String = UtilGSafe.GetValue(pGSafeGuid, UtilGSafe.KeyName.FilePreFix)
                zJSON.Add("data", UtilAccount.GetContacts(zFp)) ' ADD CALL TO FUNCTION HERE
                zJSON.Add("isSuccess", True)
                zJSON.Add("message", Nothing)

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("url", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn
        End Function

        Public Function GetTrainingVideos(pGSafeGuid As String) As IO.Stream Implements IRESTServer.GetTrainingVideos
            Dim zJSON As New Dictionary(Of String, Object)
            Dim zReturn As System.IO.Stream

            Try
                If IsNumeric(UtilGSafe.GetId(pGSafeGuid)) Then
                    Dim zDT As New DataTable
                    Dim zCmd As New SqlClient.SqlCommand("spTrainingVideos", UtilSQLServer.GetConnectionObject())
                    zCmd.CommandType = CommandType.StoredProcedure

                    Using zCmd.Connection
                        Using zCmd
                            zDT.Load(zCmd.ExecuteReader)
                        End Using
                    End Using

                    '                    zJSON.Add("data", zDT.AsEnumerable.Cast(Of DataRow).ToList()) ' ADD CALL TO FUNCTION HERE
                    zJSON.Add("data", zDT) ' ADD CALL TO FUNCTION HERE
                    zJSON.Add("isSuccess", True)
                    zJSON.Add("message", Nothing)

                Else
                    zJSON.Add("data", Nothing) ' ADD CALL TO FUNCTION HERE
                    zJSON.Add("isSuccess", False)
                    zJSON.Add("message", "Invalid Sid Identifier")
                End If

            Catch ex As Exception
                zJSON.Add("data", Nothing)
                zJSON.Add("url", Nothing)
                zJSON.Add("isSuccess", False)
                zJSON.Add("message", ex.Message)
            End Try

            zReturn = JsonWrap(Newtonsoft.Json.JsonConvert.SerializeObject(zJSON))
            Return zReturn
        End Function
    End Class



End Namespace