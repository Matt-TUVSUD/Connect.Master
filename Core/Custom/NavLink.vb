'===============================================================================
'                   EntitySpaces 2011 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2011.1.0627.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/30/2012 3:07:05 PM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	Partial Public Class NavLink 
		Inherits esNavLink

		Public Sub New()

		End Sub

        Public ReadOnly Property ParentLink() As NavLink
            Get
                Dim zParentLink As New NavLink
                If Me.NavParentLinkId.ToString = "" Then
                    Return Nothing
                Else
                    zParentLink.LoadByPrimaryKey(Me.NavParentLinkId)
                    Return zParentLink
                End If
            End Get

        End Property

        Public Class SlideMenuTypes
            Public Shared Property All = "all"
            Public Shared Property Side = "side"
            Public Shared Property Top = "top"
            Public Shared Property Practice = "practice"
        End Class

    End Class

End Namespace
