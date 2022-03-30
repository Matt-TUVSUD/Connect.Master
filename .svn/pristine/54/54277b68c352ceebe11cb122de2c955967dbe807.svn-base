'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0319.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/9/2012 12:03:32 PM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

    Partial Public Class Rating
        Inherits esRating

        Public Sub New()

        End Sub
        ''' <summary>
        ''' Get the client facility score average
        ''' </summary>
        ''' <param name="pFileNo">FileNo or FilePrefix must be used.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Shared Function GetClientAvg(ByVal pFileNo As String) As Double

            Throw New NotImplementedException("Not Implemented")

            'Dim zObj As New BusinessObjects.ViewCCReportFireRatingCurrentQuery
            'Dim zLoc As New BusinessObjects.ViewCCReportLocationBaseQuery
            'Dim zFilePrefix As String = ""

            'If InStr(pFileNo, ".") <> 0 Then
            '    zLoc.Select(zLoc.FilePrefix)
            '    zLoc.Where(zLoc.FileNo = pFileNo)
            '    zFilePrefix = zLoc.ExecuteScalar()
            'Else
            '    zFilePrefix = pFileNo
            'End If

            'zObj.Select(zObj.TotalScore.Avg)
            'zObj.Where(zObj.FileNo.Like(zFilePrefix + "%"))
            'Dim zResult As Object = zObj.ExecuteScalar

            'If zResult Is DBNull.Value Then
            '    Return 0
            'Else
            '    Return zResult
            'End If

        End Function

        Public Shared Function GetDivisionAvg(ByVal pFileNo As String) As Double
            Throw New NotImplementedException("Not Implemented")

            'Dim zObj As New BusinessObjects.ViewCCReportFireRatingCurrentQuery
            'Dim zLoc As New BusinessObjects.ViewCCReportLocationBaseQuery

            ''Get division
            'Dim zDivision As String = ""
            'zLoc.Select(zLoc.Division)
            'zLoc.Where(zLoc.FileNo = pFileNo)
            'zDivision = zLoc.ExecuteScalar()

            ''Get FilePrefix
            'zLoc = New BusinessObjects.ViewCCReportLocationBaseQuery
            'Dim zFilePrefix As String = ""
            'zLoc.Select(zLoc.FilePrefix)
            'zLoc.Where(zLoc.FileNo = pFileNo)
            'zFilePrefix = zLoc.ExecuteScalar()

            ''Get Average
            'zObj.Select(zObj.TotalScore.Avg)
            'zObj.Where(zObj.Division = zDivision)
            'zObj.Where(zObj.FileNo.Like(zFilePrefix + "%"))
            'Dim zResult As Object = zObj.ExecuteScalar

            'If zResult Is DBNull.Value Then
            '    Return 0
            'Else
            '    Return zResult
            'End If

        End Function

        Public Shared Function GetGRCAverage() As Double

            Throw New NotImplementedException("Not Implemented")

            'Dim zObj As New Libraries.CoreLib.BusinessObjects.ViewCCReportFireRatingCurrentQuery
            'Dim zLoc As New Libraries.CoreLib.BusinessObjects.ViewCCReportLocationBaseQuery
            'Dim zFilePrefix As String = ""

            'zObj.Select(zObj.TotalScore.Avg)
            'Dim zResult As Object = zObj.ExecuteScalar

            'If zResult Is DBNull.Value Then
            '    Return 0
            'Else
            '    Return zResult
            'End If

        End Function

        Public Shared Function Top5TotalScoreValues(ByVal pPrefix As String, Optional pDivision As String = "", Optional pCustomAccess As String = "") As List(Of Single)
            Throw New NotImplementedException("Not Implemented")

            'Dim zQry As New ViewCCReportFireRatingCurrentQuery
            'zQry.Select(zQry.TotalScore).es.Distinct = True
            'zQry.es.Top = 5
            'zQry.Where(zQry.FilePrefix = pPrefix)
            'If pDivision <> "" And pDivision.ToUpper <> "ALL" Then zQry.Where(zQry.Division = pDivision)
            'If pCustomAccess <> "" And pCustomAccess.ToUpper <> "ALL" Then zQry.Where(zQry.CustomAccess = pCustomAccess)


            'zQry.OrderBy(zQry.TotalScore.Descending)

            'Dim zList As New List(Of Single)
            'Dim zQryCol As New ViewCCReportFireRatingCurrentCollection
            'If zQryCol.Load(zQry) Then
            '    For Each zObj As ViewCCReportFireRatingCurrent In zQryCol
            '        zList.Add(zObj.TotalScore)
            '    Next
            'End If
            'Return zList

        End Function

        Public Shared Function Bottom5TotalScoreValues(ByVal pPrefix As String, Optional pDivision As String = "", Optional pCustomAccess As String = "") As List(Of Single)
            Throw New NotImplementedException("Not Implemented")

            'Dim zQry As New ViewCCReportFireRatingCurrentQuery
            'zQry.Select(zQry.TotalScore).es.Distinct = True
            'zQry.es.Top = 5
            'zQry.Where(zQry.FilePrefix = pPrefix)
            'zQry.OrderBy(zQry.TotalScore.Ascending)
            'If pDivision <> "" And pDivision.ToUpper <> "ALL" Then zQry.Where(zQry.Division = pDivision)
            'If pCustomAccess <> "" And pCustomAccess.ToUpper <> "ALL" Then zQry.Where(zQry.CustomAccess = pCustomAccess)



            'Dim zList As New List(Of Single)
            'Dim zQryCol As New ViewCCReportFireRatingCurrentCollection
            'If zQryCol.Load(zQry) Then
            '    For Each zObj As ViewCCReportFireRatingCurrent In zQryCol
            '        zList.Add(zObj.TotalScore)
            '    Next
            'End If
            'Return zList

        End Function

    End Class

End Namespace
