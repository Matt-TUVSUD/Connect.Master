'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/27/2013 10:56:49 PM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	Partial Public Class ViewCCTranslationSecondaryRec 
		Inherits esViewCCTranslationSecondaryRec
        Implements ITranslatable

        Public Sub New()

        End Sub

        Public Function Translate(pValue As String, pFromLanguage As UtilTranslation.Language, pToLanguage As UtilTranslation.Language) As String Implements ITranslatable.Translate
            Dim zLanguageColumn As String = UtilTranslation.GetTranslationColumn(pToLanguage)
            Dim zWhereLanguageColumn As String = UtilTranslation.GetTranslationColumn(pFromLanguage)

            Dim zObj As New ViewCCTranslationSecondaryRecQuery
            zObj.Select("<" & zLanguageColumn & ">")
            zObj.Where("<" & zWhereLanguageColumn & "='" & pValue & "'>")

            Dim zRet As String = zObj.ExecuteScalar
            If zRet IsNot Nothing Then
                Return zRet
            Else
                Return pValue
            End If

        End Function
    End Class

End Namespace
