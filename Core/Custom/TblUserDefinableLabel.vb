'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/10/2013 3:43:46 PM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	Partial Public Class TblUserDefinableLabel 
		Inherits esTblUserDefinableLabel

		Public Sub New()

		End Sub

        Public Shared Function GetLabels(ByVal pFilePrefix As String, ByVal pCopeTable As UserDefinableGridTable) As Dictionary(Of String, String)

            Dim zQry As New TblUserDefinableLabelQuery
            zQry.Select(zQry.FieldName, zQry.LabelText)
            zQry.Where(zQry.GridID = pCopeTable)
            zQry.Where(zQry.FilePrefix = pFilePrefix)

            Dim zDT As DataTable = zQry.LoadDataTable()
            Dim zDict As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
            If zDT.Rows.Count > 0 Then
                For Each zRow As DataRow In zDT.Rows
                    zDict.Add(zRow("FieldName"), zRow("LabelText"))
                Next
            End If

            Return zDict
        End Function

        Public Enum UserDefinableGridTable
            FireCopeConstruction = 70
            FireCopeOccupancy = 71
            FireCopeProtection = 72
            FireCopeExposure = 73
        End Enum

	End Class

End Namespace
