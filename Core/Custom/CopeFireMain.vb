'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0319.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/9/2012 10:48:05 AM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	Partial Public Class CopeFireMain 
		Inherits esCopeFireMain

		Public Sub New()

		End Sub

        Public Shared Function Top10MFLValues(ByVal zFilePrefix As String, Optional pDivision As String = "", Optional pCustomAccess As String = "") As List(Of Int64)

            Dim zList As New List(Of Int64)
            Dim zQryGwl As New GRIPSSWorkloadQuery("gwl")
            Dim zQry As New CopeFireMainQuery("main")
            zQry.Select(zQry.MFLTotal)
            zQry.InnerJoin(zQryGwl).On(zQry.FileNo = zQryGwl.FileNo)
            zQry.Where(zQryGwl.FilePrefix = zFilePrefix)
            If pDivision <> "" And pDivision.ToUpper <> "ALL" Then zQry.Where(zQryGwl.Division = pDivision)
            If pCustomAccess <> "" And pCustomAccess.ToUpper <> "ALL" Then zQry.Where(zQryGwl.CustomAccess = pCustomAccess)


            zQry.GroupBy(zQry.MFLTotal)
            zQry.OrderBy(zQry.MFLTotal.Descending)

            Dim zQryCol As New CopeFireMainCollection
            If zQryCol.Load(zQry) Then
                For Each zObj As CopeFireMain In zQryCol
                    If IsNothing(zObj.MFLTotal) Then
                        zList.Add(0)
                    Else
                        zList.Add(zObj.MFLTotal)
                    End If

                    If zList.Count = 10 Then
                        Return zList
                    End If
                Next
            End If
            Return zList
        End Function
    End Class

End Namespace
