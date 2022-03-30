Imports GRC.Connect.Libraries.DataLib.razor

Public Class BatchEmail
    Inherits rowTblBatchProcessingEmail

    Public BatchSets As New List(Of rowTblBatchProcessingSet)

    Public Sub New()
        MyBase.New()
        Me.colFldHasException = False
        ClearAllRecipients()
    End Sub

    ''' <summary>
    ''' Clears To, Cc and Bcc recipeints
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub ClearAllRecipients()
        Me.colFldTo = ""
        Me.colFldCc = ""
        Me.colFldBcc = ""

    End Sub

    Public Function ExistsInTo(ByVal pAddress As String) As Boolean
        Dim zAddresses() As String = Split(colFldTo, ",")
        For Each zAddress As String In zAddresses
            If zAddress.ToLower.Contains(pAddress.ToLower) Then Return True
        Next
        Return False
    End Function

    Public Function ExistsInCc(ByVal pAddress As String) As Boolean
        Dim zAddresses() As String = Split(colFldCc, ",")
        For Each zAddress As String In zAddresses
            If zAddress.ToLower.Contains(pAddress.ToLower) Then Return True
        Next
        Return False
    End Function

    Public Function ExistsInBcc(ByVal pAddress As String) As Boolean
        Dim zAddresses() As String = Split(colFldBcc, ",")
        For Each zAddress As String In zAddresses
            If zAddress.ToLower.Contains(pAddress.ToLower) Then Return True
        Next
        Return False
    End Function

    Public Sub AddTo(addresses As String)
        Dim zSB As New Text.StringBuilder(colFldTo)
        If zSB.Length > 0 Then zSB.Append(",")
        zSB.Append(addresses)
        colFldTo = zSB.ToString
    End Sub

    Public Sub AddTo(addresses As String())
        AddTo(Join(addresses, ","))
    End Sub

    Public Sub AddTo(address As System.Net.Mail.MailAddress)
        AddTo(address.ToString)
    End Sub

    Public Sub AddTo(address As String, displayName As String)
        If Not String.IsNullOrEmpty(address) Then
            Try
                AddTo(New System.Net.Mail.MailAddress(address, displayName))
            Catch ex As Exception
                ex.Data.Add("Email Address", address)
                ex.Data.Add("Display Name", displayName)
                Throw
            End Try
        End If
    End Sub

    Public Sub AddCc(addresses As String)
        Dim zSB As New Text.StringBuilder(colFldCc)
        If zSB.Length > 0 Then zSB.Append(",")
        zSB.Append(addresses)
        colFldCc = zSB.ToString
    End Sub

    Public Sub AddCc(addresses As String())
        AddCc(Join(addresses, ","))
    End Sub

    Public Sub AddCc(address As System.Net.Mail.MailAddress)
        AddCc(address.ToString)
    End Sub

    Public Sub AddCc(address As String, displayName As String)
        If Not String.IsNullOrEmpty(address) Then
            Try
                AddCc(New System.Net.Mail.MailAddress(address, displayName))
            Catch ex As Exception
                ex.Data.Add("Email Address", address)
                ex.Data.Add("Display Name", displayName)
                Throw
            End Try
        End If
    End Sub

    Public Sub AddBcc(addresses As String)
        Dim zSB As New Text.StringBuilder(colFldBcc)
        If zSB.Length > 0 Then zSB.Append(",")
        zSB.Append(addresses)
        colFldBcc = zSB.ToString
    End Sub

    Public Sub AddBcc(addresses As String())
        AddBcc(Join(addresses, ","))
    End Sub

    Public Sub AddBcc(address As System.Net.Mail.MailAddress)
        AddBcc(address.Address)
    End Sub

    Public Sub AddBcc(address As String, displayName As String)
        If Not String.IsNullOrEmpty(address) Then
            Try
                AddBcc(New System.Net.Mail.MailAddress(address, displayName))
            Catch ex As Exception
                ex.Data.Add("Email Address", address)
                ex.Data.Add("Display Name", displayName)
                Throw
            End Try
        End If
    End Sub

    Private Sub BatchEmail_Saved() Handles Me.Saved
        For Each zBatchSet As BatchSet In Me.BatchSets
            Dim zEmailSet As New rowTblBatchProcessingEmailSet
            zEmailSet.colFldEmailId = Me.colFldId
            zEmailSet.colFldSetId = zBatchSet.colFldId
            TblBatchProcessingEmailSet.Save(zEmailSet)
        Next
    End Sub
End Class
