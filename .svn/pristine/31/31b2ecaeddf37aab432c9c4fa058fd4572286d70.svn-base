'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0319.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/19/2012 9:51:14 AM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	Partial Public Class FireRecommendations 
		Inherits esFireRecommendations

		Public Sub New()

		End Sub


#Region "Static Methods"

        'Public Shared Function GetLossExpectancyBeforeValue(ByVal pId As Integer) As String
        '     Dim zObj As New FireRecommendations
        '     zObj.LoadByPrimaryKey(pId)
        '     Return zObj.LossExpectancyBeforeValue()
        'End Function

        'Public Shared Function GetLossExpectancyAfterValue(ByVal pId As Integer) As String
        '     Dim zObj As New FireRecommendations
        '     zObj.LoadByPrimaryKey(pId)
        '     Return zObj.LossExpectancyBeforeValue()
        'End Function

        'Public Shared Function GetCostToCompleteValue(ByVal pId As Integer) As String
        '     Dim zObj As New FireRecommendations
        '     zObj.LoadByPrimaryKey(pId)
        '     Return zObj.CostToCompleteValue()
        'End Function

        'Public Shared Function ConvertLossExpectancyBeforeValue(ByVal pId As Integer, ByVal pCurrency As UtilCurrency.Currencies) As String
        '     Dim zObj As New FireRecommendations
        '     zObj.LoadByPrimaryKey(pId)
        '     Return zObj.LossExpectancyBeforeValueConvert(pCurrency)
        'End Function

        'Public Shared Function ConvertLossExpectancyAfterValue(ByVal pId As Integer, ByVal pCurrency As UtilCurrency.Currencies) As String
        '     Dim zObj As New FireRecommendations
        '     zObj.LoadByPrimaryKey(pId)
        '     Return zObj.LossExpectancyAfterValueConvert(pCurrency)
        'End Function

        'Public Shared Function ConvertCostToCompleteValue(ByVal pId As Integer, ByVal pCurrency As UtilCurrency.Currencies) As String
        '     Dim zObj As New FireRecommendations
        '     zObj.LoadByPrimaryKey(pId)
        '     Return zObj.CostToCompleteValueConvert(pCurrency)
        'End Function


#End Region


          Public ReadOnly Property myPropConvert() As esQueryItem
               Get
                    Return Nothing
               End Get
          End Property

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

            If Me.MgmtRespDate IsNot Nothing Then   'Added by DB - Made conditional. Not all imports have status date filled in.
                zDate = Me.MgmtRespDate
                zDate = zDate.Date.ToString("d")
                Me.MgmtRespDate = zDate
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
