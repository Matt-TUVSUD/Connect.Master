Imports System.Drawing


Public Class UtilColor
     Public Shared Function GetColorByNumber(ByVal Rating As Double) As System.Drawing.Color
          Dim zInt As Int32 = Convert.ToInt32(Rating)
          Select Case zInt
            Case 1 To 3
                Return GetDatabaseColor(4)
            Case 4 To 6
                Return GetDatabaseColor(3)
               Case 7 To 10
                    Return GetDatabaseColor(2)
               Case Else
                    Return Drawing.Color.Transparent
          End Select
    End Function


    Public Shared Function GetColorByCurrency(ByVal currency As Double) As System.Drawing.Color
        Dim zInt As Int32 = Convert.ToInt32(currency)
        Select zInt
            Case Is >= 100000
                Return GetDatabaseColor(4)
            Case 10001 To 99999
                Return GetDatabaseColor(3)
            Case Is <= 10000
                Return GetDatabaseColor(2)
            Case Else
                Return Drawing.Color.Transparent
        End Select
    End Function

    'Public Shared Function GetColorByRating(ByVal FilePrefix As String, ByVal Practice As UtilPractice.PracticeEnum, ByVal Rating As String) As System.Drawing.Color
    '     Dim zRatingID As Integer = UtilRating.GetRatingID(FilePrefix, Practice)
    '   Dim zRatingKey As New BusinessObjects.RatingKey
    '     If zRatingKey.LoadByPrimaryKey(zRatingID) Then
    '          With zRatingKey
    '               Select Case Rating.ToLower
    '                    Case .Rating1.ToLower
    '                         Return GetDatabaseColor(.Color1ID)
    '                    Case .Rating2.ToLower
    '                         Return GetDatabaseColor(.Color2ID)
    '                    Case .Rating3.ToLower
    '                         Return GetDatabaseColor(.Color3ID)
    '                    Case .Rating4.ToLower
    '                         Return GetDatabaseColor(.Color4ID)
    '                    Case .Rating5.ToLower
    '                         Return GetDatabaseColor(.Color5ID)
    '               End Select
    '          End With
    '     End If

    '     Dim zRatingList As New List(Of String)
    '     zRatingList.AddRange({zRatingKey.Rating1, zRatingKey.Rating2, zRatingKey.Rating3, zRatingKey.Rating4, zRatingKey.Rating5})

    '   If Rating.ToLower.Contains(zRatingKey.Rating1.ToLower) Then Return GetDatabaseColor(zRatingKey.Color1ID)
    '   If Rating.ToLower.Contains(zRatingKey.Rating2.ToLower) Then Return GetDatabaseColor(zRatingKey.Color2ID)
    '   If Rating.ToLower.Contains(zRatingKey.Rating3.ToLower) Then Return GetDatabaseColor(zRatingKey.Color3ID)
    '   If Rating.ToLower.Contains(zRatingKey.Rating4.ToLower) Then Return GetDatabaseColor(zRatingKey.Color4ID)
    '   If Rating.ToLower.Contains(zRatingKey.Rating5.ToLower) Then Return GetDatabaseColor(zRatingKey.Color5ID)

    '   Return Color.Transparent


    'End Function

     Public Shared Function GetColorByText(ByVal pText As String) As System.Drawing.Color

          Select Case LCase(pText)
            Case "inadequate", "severe", "poorer risk", "high", "****"
                Return GetDatabaseColor(4)
            Case "moderate", "tolerable", "typical risk", "***"
                Return GetDatabaseColor(3)
            Case "adequate", "light", "better risk", "low", "not applicable", "*", "**", "1 day"
                Return GetDatabaseColor(2)
            Case "2 days", "3 days", "4 days", "5 days", "6 days", "7 days"
                Return GetDatabaseColor(3)
               Case "yes", "n/a"
                    Return GetDatabaseColor(2)
               Case "no"
                    Return GetDatabaseColor(4)
          End Select

        If pText.ToLower.Contains("week") Then Return GetDatabaseColor(4)
        If pText.ToLower.Contains("month") Then Return GetDatabaseColor(4)

     End Function

     Public Shared Function GetColorByMajorExposure(ByVal pValue As String) As System.Drawing.Color

          Select Case pValue.ToLower
               Case "no"
                    Return GetDatabaseColor(GrcColor.Green)
               Case "yes"
                    Return GetDatabaseColor(GrcColor.Red)
               Case "n/a"
                    Return GetDatabaseColor(GrcColor.Green)
          End Select

     End Function

     Public Shared Function GetDatabaseColor(ByVal ColorID As GrcColor) As System.Drawing.Color
          Dim zColor As New BusinessObjects.Color
          If zColor.LoadByPrimaryKey(ColorID) Then
               Return System.Drawing.Color.FromArgb(zColor.R, zColor.G, zColor.B)
          End If
     End Function

    'Public Shared Function GetColorByScore(ByVal FileNo As String, ByVal Practice As UtilPractice.PracticeEnum, ByVal Score As Integer) As System.Drawing.Color
    '     Dim zRatingID As Integer = UtilRating.GetRatingID(FileNo, Practice)
    '     Dim zRatingKey As New BusinessObjects.RatingKey
    '     If zRatingKey.LoadByPrimaryKey(zRatingID) Then
    '          With zRatingKey
    '               Select Case Score
    '                    Case .ScoreLow1 To .ScoreHigh1
    '                         Return GetDatabaseColor(.Color1ID)
    '                    Case .ScoreLow2 To .ScoreHigh2
    '                         Return GetDatabaseColor(.Color2ID)
    '                    Case .ScoreLow3 To .ScoreHigh3
    '                         Return GetDatabaseColor(.Color3ID)
    '                    Case .ScoreLow4 To .ScoreHigh4
    '                         Return GetDatabaseColor(.Color4ID)
    '                    Case .ScoreLow5 To .ScoreHigh5
    '                         Return GetDatabaseColor(.Color5ID)
    '                    Case Else
    '                         Return Drawing.Color.Transparent
    '               End Select
    '          End With
    '     Else
    '          Return Drawing.Color.Transparent
    '     End If
    'End Function


     Public Enum GrcColor
          White = 1
          Green = 2
          Yellow = 3
          Red = 4
          DarkGreen = 5
          Orange = 6
     End Enum


End Class

