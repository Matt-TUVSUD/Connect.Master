'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0319.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/21/2012 11:47:36 AM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	Partial Public Class Findings 
		Inherits esFindings

		Public Sub New()

        End Sub

        Public Overrides Sub Save()
            ' ADDED CODE TO REMOVE TIME DATA FROM DATE OBJECTS
            Dim zDate As Date

            If Me.StatusDate.HasValue() Then
                'If Me.StatusDate IsNot Nothing Then
                zDate = Me.StatusDate
                zDate = zDate.Date.ToString("d")
                Me.StatusDate = zDate
            End If

            If Me.ExpectedCompletionDate.HasValue() Then
                'If Me.ExpectedCompletionDate IsNot Nothing Then
                zDate = Me.ExpectedCompletionDate
                zDate = zDate.Date.ToString("d")
                Me.ExpectedCompletionDate = zDate
            End If

            If Me.ResponseDate.HasValue() Then
                'If Me.ResponseDate IsNot Nothing Then
                zDate = Me.ResponseDate
                zDate = zDate.Date.ToString("d")
                Me.ResponseDate = zDate
            End If

            If Me.FollowupDate.HasValue() Then
                'If Me.FollowupDate IsNot Nothing Then
                zDate = Me.FollowupDate
                zDate = zDate.Date.ToString("d")
                Me.FollowupDate = zDate
            End If

            If Me.LastUpdated.HasValue() Then
                'If Me.LastUpdated IsNot Nothing Then
                zDate = Me.LastUpdated
                zDate = zDate.Date.ToString("d")
                Me.LastUpdated = zDate
            End If

            If Me.DateOfOrigination.HasValue() Then
                'If Me.DateOfOrigination IsNot Nothing Then
                zDate = Me.DateOfOrigination
                zDate = zDate.Date.ToString("d")
                Me.DateOfOrigination = zDate
            End If

            If Me.DateOfOriginalImport.HasValue() Then
                'If Me.DateOfOriginalImport IsNot Nothing Then
                zDate = Me.DateOfOriginalImport
                zDate = zDate.Date.ToString("d")
                Me.DateOfOriginalImport = zDate
            End If

            If Me.DateOfLastImport.HasValue() Then
                'If Me.DateOfLastImport IsNot Nothing Then
                zDate = Me.DateOfLastImport
                zDate = zDate.Date.ToString("d")
                Me.DateOfLastImport = zDate
            End If

            If Me.MgmtRespDate.HasValue() Then
                'If Me.DateOfLastImport IsNot Nothing Then
                zDate = Me.MgmtRespDate
                zDate = zDate.Date.ToString("d")
                Me.MgmtRespDate = zDate
            End If

            ' PROCEED WITH SAVE
            MyBase.Save()

        End Sub

	End Class

End Namespace
