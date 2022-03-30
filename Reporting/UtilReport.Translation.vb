Imports GRC.Connect.Libraries.DataLib.razor

Partial Class UtilReport
    Public Class Translation
        Public Shared Function GetTranslationDictionary(toLanguage As TblMetaLanguage.Languages) As Dictionary(Of String, String)
            Dim zCmd As New SqlClient.SqlCommand(UtilReport.SQL.GetTranslationSQL(toLanguage))
            Dim zRdr As SqlClient.SqlDataReader = UtilSQLServer.ExecuteReader(zCmd)
            Dim zDict As New Dictionary(Of String, String)(StringComparer.CurrentCultureIgnoreCase)
            Using zRdr
                zRdr.Read()
                Do
                    Dim zKey As String = IIf(IsDBNull(zRdr("LabelName")), "", zRdr("Labelname"))
                    Dim zValue As String = IIf(IsDBNull(zRdr("DestinationLanguage")), "", zRdr("DestinationLanguage"))
                    If zValue <> "" Then zDict.Add(zKey, zValue)
                Loop Until zRdr.Read = False
                zRdr.Close()
            End Using
            Return zDict
        End Function

        Public Shared Function Translate(value As String, dictionary As Dictionary(Of String, String)) As String
            Dim zTranslated As String = value
            If dictionary.TryGetValue(value, zTranslated) Then
                Return zTranslated
            End If
            Return zTranslated
        End Function
    End Class
End Class

