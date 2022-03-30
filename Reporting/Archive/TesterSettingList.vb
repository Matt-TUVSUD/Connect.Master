<Serializable()>
Public Class TesterSettingList
     Inherits List(Of TesterSetting)

     Public Function GetSetting(ByVal pEmailAddress As String) As TesterSetting
          For Each zSetting In Me
               If zSetting.Email.ToLower = pEmailAddress Then Return zSetting
          Next

          Return Nothing

     End Function

     Overloads Sub Add(ByVal pSetting As TesterSetting)
          Dim zCurrentSetting As TesterSetting = GetSetting(pSetting.Email)
          If zCurrentSetting Is Nothing Then
               MyBase.Add(pSetting)
          Else
               zCurrentSetting.Client = pSetting.Client
               zCurrentSetting.Email = pSetting.Email
               zCurrentSetting.Report = pSetting.Report
          End If
     End Sub

End Class
