Imports Newtonsoft.Json
Imports System.Net.HttpWebResponse


Public Class Dashboard1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub





    'Public client As HttpClient = New HttpClient()
    'protected Sub UploadJSON()

    '    Dim JSONstring As String
    '    Dim userGUID As String = "abcd12345678jkkl"
    '    Dim fileNo As String = "1001.0003"
    '    Dim numRows As Integer = 1

    '    '        For Each row In DataSet

    '    JSONstring = "[{""UserGUID"":" & userGUID
    '    JSONstring = JSONstring + ",""FileNo"":""" & fileNo
    '    JSONstring = JSONstring & """}]"
    '    '            Dim content As HttpContent = New StringContent(JSONstring)
    '    Dim url As New Uri("https://api.powerbi.com/v1.0/myorg/datasets/cfafbeb1-8037-4d0c-896e-a46fb27ff229/tables/UserFileNo/rows")
    '    '           Dim response As HttpResponseMessage
    '    '          response = client.PostAsync(url, content).Result
    '    '         System.Threading.Thread.Sleep(1000)
    '    Console.WriteLine(JSONstring)

    '    'Next

    'End Sub



End Class