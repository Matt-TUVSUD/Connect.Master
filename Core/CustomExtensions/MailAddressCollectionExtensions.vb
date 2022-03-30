Imports System.Runtime.CompilerServices

Namespace CustomExtensions
    Public Module MailAddressCollectionExtensions

        <Extension()>
        Function ExtractAddresses(ByVal pData As System.Net.Mail.MailAddressCollection) As String
            Dim zSB As New StringBuilder
            For Each pAddress As System.Net.Mail.MailAddress In pData
                If zSB.ToString <> "" Then
                    zSB.Append(", ")
                End If

                If pAddress.DisplayName = pAddress.Address Then
                    zSB.Append(pAddress.Address)
                Else
                    zSB.Append(pAddress.DisplayName & " (" & pAddress.Address & ")")
                End If
            Next

            Return zSB.ToString

        End Function

    End Module
End Namespace


