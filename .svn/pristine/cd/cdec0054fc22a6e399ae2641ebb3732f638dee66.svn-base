Public Class TestRedirect
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ' SAMPLE FIRE: https://grcconnecttest.globalriskconsultants.com/Connect/RecResponse/Auth/?p1=C24D08B7-F62F-4845-BFC1-7F826F736626
        ' SAMPLE BOILER: https://grcconnecttest.globalriskconsultants.com/Connect/RecResponse/Auth/?p1=f6c4abf2-2945-4b4c-800b-a0d8062ce16d
        ' SAMPLE IR: https://grcconnecttest.globalriskconsultants.com/Connect/RecResponse/Auth/?p1=94341147-6E57-448C-95F6-898220F5AF7E

        Dim p510, p515, p520, p525, p530, p535, p570 As String

        p510 = "D4833CB1-21E9-4FF4-B16E-640CCE68AD22"   'B&M            - AS OF 12/22/2016
        p515 = "60F3ACCA-2203-41C1-83D8-A176E609BFB4"   'B&M Special
        p520 = "D4833CB1-21E9-4FF4-B16E-640CCE68AD22"   'Fire           - AS OF 12/22/2016
        p520 = "EF0AE646-5FF6-4DEB-BAA6-7ED08C17A843"    'Fire -AS OF 6/7/2017
        p525 = "2DB1135D-C9F2-4882-BE59-5022EBAAFF43"   'Fire Special
        p530 = "94341147-6E57-448C-95F6-898220F5AF7E"   'IR             - AS OF 12/22/2016
        p535 = "9EC31DD9-A11A-4841-95A2-E2ED86F06D9F"   'IR Special
        p570 = "489c6922-11ed-403a-8917-51add5a16b91"   'PROCESS SAFETY

        Response.Redirect("~/RecResponse/Auth/?p1=" & p570)
    End Sub

End Class