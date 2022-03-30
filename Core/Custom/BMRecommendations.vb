'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0319.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/4/2012 3:44:45 PM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	Partial Public Class BMRecommendations 
		Inherits esBMRecommendations

		Public Sub New()

		End Sub

        Public Overrides Sub Save()
            ' ADDED CODE TO REMOVE TIME DATA FROM DATE OBJECTS
            Dim zDate As Date

               If Me.StatusDate IsNot Nothing Then   'Added by DB - Made conditional. Not all imports have status date filled in.
                    zDate = Me.StatusDate
                    zDate = zDate.Date.ToString("d")
                    Me.StatusDate = zDate
               End If

               If Me.ExpectedCompletionDate IsNot Nothing Then   'Added by DB - Made conditional. Not all imports have status date filled in.
                    zDate = Me.ExpectedCompletionDate
                    zDate = zDate.Date.ToString("d")
                    Me.ExpectedCompletionDate = zDate
               End If

               If Me.ResponseDate IsNot Nothing Then   'Added by DB - Made conditional. Not all imports have status date filled in.
                    zDate = Me.ResponseDate
                    zDate = zDate.Date.ToString("d")
                    Me.ResponseDate = zDate
               End If

               ' BELOW FOR FUTURE TO BE ADDED FIELDS
               'zDate = Me.ManagerResponseDate
               'zDate = zDate.Date.ToString("d")
               'Me.ManagerResponseDate = zDate

               ' PROCEED WITH SAVE
               MyBase.Save()

        End Sub

	End Class

End Namespace
