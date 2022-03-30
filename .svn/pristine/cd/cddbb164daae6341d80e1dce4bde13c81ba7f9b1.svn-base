'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0319.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/30/2012 3:57:21 PM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	Partial Public Class REDocHeader 
		Inherits esREDocHeader

		Public Sub New()

		End Sub

        Public Function LoadByRptSetId(pRptSetId As Integer) As Boolean
            Dim zQry As New BusinessObjects.REDocHeaderQuery("t1")
            zQry.SelectAll()
            zQry.Where(zQry.RptSetId = pRptSetId)
            zQry.es.Top = 1
            If Me.Load(zQry) Then
                Return True
            Else
                Return False
            End If
        End Function

    End Class

End Namespace
