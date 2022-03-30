Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilAppEntry

    Public Enum EntrySource
        Main = 1
        AutoRec = 2
    End Enum

    Public Shared Function GetAppEntry(id) As rowTblSystemAppEntry
       Return TblSystemAppEntry.LoadByPrimaryKey(id)
    End Function

    Public Shared Function Save(pGuid As String, pUserName As String, pUserEmail As String, pSource As EntrySource, pForeignkeyID As Integer)

        Dim entry As New rowTblSystemAppEntry
        entry.colFldGuid = pGuid
        entry.colFldUserEmail = pUserEmail
        entry.colFldUserName = pUserName
        entry.colFldEntrySource = CInt(pSource)
        entry.colFldForeignKeyID = pForeignkeyID
        entry.colFldForeignTableName = IIf(pSource = EntrySource.Main, "Ezy_Login", "RRLog")
        entry.colFldEntryDateTime = Now
        TblSystemAppEntry.Save(entry)

        Return entry

    End Function


End Class
