'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0319.0
' EntitySpaces Driver  : SQL
' Date Generated       : 6/4/2012 5:24:54 PM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	Partial Public Class GSafeDetail 
		Inherits esGSafeDetail

		Public Sub New()

		End Sub

        Public Overrides Function LoadByPrimaryKey(gSafeId As Integer, dataName As String) As Boolean

            'Set the LastAccessed
            'Dim zSafeHeader As New GSafeHeader
            'zSafeHeader.setLastAccessed(gSafeId)
            'zSafeHeader = Nothing

            Return MyBase.LoadByPrimaryKey(GSafeId, dataName)
        End Function

        Public Overrides Sub Save()

            'Set the LastUpdated date
            'Dim zSafeHeader As New GSafeHeader
            'zSafeHeader.setLastUpdated(Me.GSafeId.Value)
            'zSafeHeader = Nothing

            MyBase.Save()
        End Sub
    End Class

End Namespace
