Imports GRC.Connect.Libraries.DataLib.razor

Namespace razor
    Partial Class rowTblEzyUsers
        ''' <summary>
        ''' Checks to see if this user has at least 1 active ezy_user record.
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsActive() As Boolean
            Dim zCol As List(Of rowTblEzyUsers) = TblEzyUsers.LoadByIDX_IX_LoginId(Me.colLoginId.Value)
            For Each zUser As rowTblEzyUsers In zCol
                If zUser.colActiveUser Then
                    Return True
                End If
            Next
            Return False
        End Function
        ''' <summary>
        ''' Checks to see if all ezy_user records are set to be deleted
        ''' </summary>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Function IsDeleted() As Boolean
            Dim zCol As List(Of rowTblEzyUsers) = TblEzyUsers.LoadByIDX_IX_LoginId(Me.colLoginId.Value)
            For Each zUser As rowTblEzyUsers In zCol
                If Not IsDate(zUser.colMarkedForDeletionDate) Then
                    Return False
                End If
            Next
            Return True
        End Function

        ''' <summary>
        ''' Sets the parent ezy_login record ActiveFlag
        ''' </summary>
        ''' <param name="pStatus"></param>
        ''' <remarks></remarks>
        Public Sub SetLoginActiveFlag(ByVal pStatus As Boolean)
            Dim zLogin As rowTblEzyLogin = TblEzyLogin.LoadByPrimaryKey(Me.colLoginId.Value)
            zLogin.colActiveFlag = pStatus
            TblEzyLogin.Save(zLogin)
        End Sub

        ''' <summary>
        ''' Sets the parent ezy_login record MarkedForDeletion date.
        ''' </summary>
        ''' <param name="pDeletionDate"></param>
        ''' <remarks></remarks>
        Public Sub SetLoginMarkForDeletion(ByVal pDeletionDate As DateTime)
            Dim zLogin As rowTblEzyLogin = TblEzyLogin.LoadByPrimaryKey(Me.colLoginId.Value)
            zLogin.colMarkForDeletionDate = pDeletionDate
            zLogin.colActiveFlag = False
            TblEzyLogin.Save(zLogin)
        End Sub

        Public Sub ClearLoginMarkForDeletion()
            Dim zLogin As rowTblEzyLogin = TblEzyLogin.LoadByPrimaryKey(Me.colLoginId.Value)
            zLogin.colMarkForDeletionDate = Nothing
            zLogin.colActiveFlag = IsActive()
            TblEzyLogin.Save(zLogin)
        End Sub

    End Class
End Namespace
