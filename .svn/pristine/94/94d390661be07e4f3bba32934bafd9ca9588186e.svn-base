Public Class UtilJSON

    Private _JSON As String = ""
    Private _Data As Dictionary(Of String, Object)

    Public Sub New(pJSON As String)
        _JSON = pJSON
        _Data = JSONtoDictionary(_JSON)
    End Sub

    Public Function ReadDictionary(pKey As String) As String
        Dim zReturn As String = ""

        If _Data.ContainsKey(pKey.ToLower) Then
            zReturn = _Data(pKey.ToLower)
        Else
            Throw New ArgumentException("Requested key does not exist in data packet.  " & pKey)
        End If

        Return zReturn
    End Function

    Public Function [Count](pKey As String) As Integer
        If _Data.ContainsKey(pKey.ToLower) Then
            Return 1
        ElseIf pKey.Contains("[]") Then
            Dim zCount As Integer = 0
            For Each zKey As String In _Data.Keys
                Dim zArrayKey As String = pKey.ToLower.Replace("[]", "[" & zCount & "]")
                If Left(zKey.ToLower, zArrayKey.Length) = zArrayKey Then
                    'Found a match - See if there is one higher
                    zCount = zCount + 1
                End If
            Next
            Return zCount
        Else
            Return 0
        End If
    End Function

    Public Function ReadDictionary2(pKey As String) As String
        Dim zReturn As String = ""

        If _Data.ContainsKey(pKey.ToLower) Then
            If Not _Data(pKey.ToLower) Is Nothing Then
                If _Data(pKey.ToLower).ToString.Length > 0 Then
                    zReturn = _Data(pKey.ToLower)
                Else
                    Throw New ArgumentException("Required data value missing in data packet.  " & pKey)
                End If
            Else
                Throw New ArgumentException("Required data value missing in data packet.  " & pKey)
            End If
        Else
            Throw New ArgumentException("Required data attribute missing in data packet.  " & pKey)
        End If

        Return zReturn
    End Function

    Public Function JSONtoDictionary(pJSON As String) As Dictionary(Of String, Object)
        Dim zReturn As New Dictionary(Of String, Object)
        Dim zJReader As Newtonsoft.Json.JsonTextReader

        zJReader = New Newtonsoft.Json.JsonTextReader(New System.IO.StringReader(pJSON))
        While zJReader.Read()

            'If zJReader.Path.ToLower = "packet.body.ScheduleSystemID".ToLower Then
            '    Stop
            'End If

            Select Case zJReader.TokenType
                Case Newtonsoft.Json.JsonToken.String, Newtonsoft.Json.JsonToken.Date, Newtonsoft.Json.JsonToken.Integer, Newtonsoft.Json.JsonToken.Float, Newtonsoft.Json.JsonToken.Null, Newtonsoft.Json.JsonToken.None
                    zReturn.Add(zJReader.Path.ToLower, zJReader.Value)
                Case Newtonsoft.Json.JsonToken.Boolean
                    zReturn.Add(zJReader.Path.ToLower, zJReader.Value)
                    'If zJReader.Value = True Then
                    '    zReturn.Add(zJReader.Path.ToLower, "yes")
                    'Else
                    '    zReturn.Add(zJReader.Path.ToLower, "no")
                    'End If
            End Select
        End While

        Return zReturn
    End Function

End Class
