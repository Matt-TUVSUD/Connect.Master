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

	Partial Public Class GSafeHeader 
		Inherits esGSafeHeader

		Public Sub New()

		End Sub
        'Public Sub setLastUpdated(pGUID As String)
        '    Me.setLastUpdated(GUID2Id(pGUID))
        'End Sub

        'Public Sub setLastAccessed(pGUID As String)
        '    Me.setLastAccessed(GUID2Id(pGUID))
        'End Sub

        'Private Function GUID2Id(pGUID As String) As Integer
        '    Dim zColl As New GOCSafeHeaderCollection
        '    Dim zQry As New GOCSafeHeaderQuery("t1")
        '    Dim zGOCSafeId As Integer = 0

        '    zQry.Select(zQry.GOCSafeId)
        '    zQry.Where(zQry.GOCSafeGUID = pGUID)

        '    If zColl.Load(zQry) Then
        '        zGOCSafeId = zColl(0).GOCSafeId
        '    End If
        '    zColl = Nothing
        '    zQry = Nothing

        '    Return zGOCSafeId
        'End Function

        'Public Sub setLastUpdated()

        '    Me.LastUpdated = Date.Now
        '    Me.Save()

        '    'Dim obj As New GOCSafeHeader

        '    'If obj.LoadByPrimaryKey(id) Then
        '    '    obj.LastUpdated = Date.Now()
        '    '    obj.Save()
        '    'End If

        'End Sub

        Public Sub setLastAccessed()

            Me.LastAccessed = Date.Now
            Me.Save()

            UtilUserActivity.Update(Me.GSafeId)

        End Sub

        'Public Sub setLastUpdated(pGSafeId As Integer)

        '    Dim obj As New GSafeHeader

        '    If obj.LoadByPrimaryKey(pGSafeId) Then
        '        obj.LastUpdated = Date.Now()
        '        obj.Save()
        '    End If

        'End Sub

        'Public Sub setLastAccessed(pGSafeId As Integer)

        '    'Dim obj As New GSafeHeader

        '    'If obj.LoadByPrimaryKey(pGSafeId) Then
        '    '    obj.LastAccessed = Date.Now()
        '    '    obj.Save()
        '    'End If

        'End Sub

        Public Function LoadByGUID(pGSafeGUID As String) As Boolean
            Dim zReturn As Boolean = False

            Dim zQry As New GSafeHeaderQuery("t1")
            zQry.SelectAll()
            zQry.es.Top = 1
            zQry.Where(zQry.GSafeGUID = pGSafeGUID)

            If Me.Load(zQry) Then
                zReturn = True
            End If

            Return zReturn
        End Function

	End Class

End Namespace
