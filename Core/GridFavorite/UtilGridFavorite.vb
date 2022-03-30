Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilGridFavorite
    Public Shared Function SaveFavorite(pTitle As String, pFilePrefix As String, pGridId As Integer, pEzyUserId As Integer, _
                                        pPractice As String, pCurrencyId As Integer, pUnitId As Integer, pColumnOrderJSON As String, _
                                        pSortJSON As String, pFilterJSON As String, pCriteriaJSON As String) As Integer
        Dim zFav As New rowTblGridFavorite
        zFav.colFldTitle = pTitle
        zFav.colFldFilePrefix = pFilePrefix
        zFav.colFldGridId = pGridId
        zFav.colFldEzyUserId = pEzyUserId
        zFav.colFldPractice = pPractice
        zFav.colFldCurrencyId = pCurrencyId
        zFav.colFldUnitId = pUnitId
        zFav.colFldColumnOrderJSON = pColumnOrderJSON
        zFav.colFldSortJSON = pSortJSON
        zFav.colFldFilterJSON = pFilterJSON
        zFav.colFldCriteriaJSON = pCriteriaJSON
        zFav.colFldUpdateDate = Now
        TblGridFavorite.Save(zFav)
        Return zFav.colId
    End Function

    Public Shared Function LoadFavorite(pFavorateId As Integer) As rowTblGridFavorite
        Dim zFav As rowTblGridFavorite = TblGridFavorite.LoadByPrimaryKey(pFavorateId)
        If zFav.colId > 0 Then   'Did we get a record?
            Return zFav
        Else
            Return Nothing
        End If
    End Function

    ''' <summary>
    ''' A function to get a list of favorites by grid id, file prefix, and user id.
    ''' </summary>
    ''' <param name="pGridId"></param>
    ''' <param name="pEzyUserId"></param>
    ''' <param name="pFilePrefix"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function LoadFavoriteListByGrid(pGridId As Integer, pEzyUserId As Integer, pFilePrefix As String) As List(Of rowTblGridFavorite)
        Dim zColl As List(Of rowTblGridFavorite)
        Dim zCmd As New SqlClient.SqlCommand("SELECT * FROM [dbo].[tblGridFavorite] WHERE [fldGridId] = @GridId AND [fldEzyUserId] = @EzyUserId AND [fldFilePrefix] = @FilePrefix")
        zCmd.Parameters.AddWithValue("@GridId", pGridId)
        zCmd.Parameters.AddWithValue("@EzyUserId", pEzyUserId)
        zCmd.Parameters.AddWithValue("@FilePrefix", pFilePrefix)
        zColl = TblGridFavorite.LoadData(zCmd)
        If zColl.Count > 0 Then
            Return zColl
        Else
            Return Nothing
        End If
    End Function


    Public Shared Sub RenameFavorite(pFavorateId As Integer, pTitle As String)
        Dim zFav As rowTblGridFavorite = TblGridFavorite.LoadByPrimaryKey(pFavorateId)
        If zFav.colId > 0 Then   'Did we get a record?
            zFav.colFldTitle = pTitle
            zFav.colFldUpdateDate = Now
            TblGridFavorite.Save(zFav)
        End If
    End Sub

    Public Shared Sub DeleteFavorite(pFavoriteId As Integer)
        Dim zFav As New rowTblGridFavorite
        zFav.colId = pFavoriteId
        TblGridFavorite.Delete(zFav)
    End Sub
End Class
