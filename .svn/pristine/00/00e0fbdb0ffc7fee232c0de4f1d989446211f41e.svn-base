Imports GRC.Connect.Libraries.DataLib.razor

Public Class UtilAccount

    ''' <summary>
    ''' Returns a list of active services by fileprefix.  Active accounts only.
    ''' </summary>
    ''' <param name="pFilePrefix"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetServices(pFilePrefix As String) As List(Of rowVwActiveAccountService)

        Dim q As New queryVwActiveAccountService
        q.SelectAll()
        q.Where.Add(q.colFldFilePrefix.Equals(pFilePrefix))

        Dim l As New List(Of rowVwActiveAccountService)
        l = VwActiveAccountService.LoadData(q.QueryText)

        Return l

    End Function

    ''' <summary>
    ''' Returns a list of account manager and engineers by fileprefix. Active accounts only.
    ''' </summary>
    ''' <param name="pFilePrefix"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetContacts(pFilePrefix As String) As List(Of rowVwActiveAccountServiceContact)

        Dim q As New queryVwActiveAccountServiceContact
        q.SelectAll()
        q.Where.Add(q.colFilePrefix.Equals(pFilePrefix))

        Dim l As New List(Of rowVwActiveAccountServiceContact)
        l = VwActiveAccountServiceContact.LoadData(q.QueryText)

        Return l

    End Function

End Class
