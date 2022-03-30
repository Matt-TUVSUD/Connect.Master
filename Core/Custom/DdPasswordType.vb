'===============================================================================
'                   EntitySpaces Studio by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2012.1.0930.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/23/2013 4:33:02 PM
'===============================================================================

Imports System

Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces
Imports EntitySpaces.DynamicQuery

Namespace BusinessObjects

	Partial Public Class DdPasswordType 
		Inherits esDdPasswordType

		Public Sub New()

		End Sub

        Public Enum PasswordTypes
            None = 1
            Alphanumeric = 2
            AlphanumericWithCaps = 3
            AlphanumericAndSpecialChars = 4
            AlphanumericAndSpecialCharsWithCaps = 5
        End Enum

	End Class

End Namespace
