Imports System.Reflection
Imports System.Runtime
Imports EntitySpaces.Core
Imports EntitySpaces.Interfaces

Public Class EsHelper

    Public Shared Function GetEsType(ByVal pType As System.Type, ByVal pOption As EntitySpaceClassType) As System.Type

		Dim zSuffix = ""
		Dim zBaseTypeName As String = pType.Name
		zBaseTypeName = Replace(zBaseTypeName, "Collection", "")
		zBaseTypeName = Replace(zBaseTypeName, "Query", "")
		zBaseTypeName = Replace(zBaseTypeName, "Metadata", "")
		Dim zNewType As System.Type = Nothing

        Select Case pOption
            Case EntitySpaceClassType.Entity
                zSuffix = ""
            Case EntitySpaceClassType.Collection
                zSuffix = "Collection"
            Case EntitySpaceClassType.Query
                zSuffix = "Query"
            Case EntitySpaceClassType.MetaData
                zSuffix = "Metadata"

        End Select

		Dim zNewTypeName As String = Replace(pType.AssemblyQualifiedName, zBaseTypeName, zBaseTypeName & zSuffix)
        zNewType = Type.GetType(zNewTypeName, False, True)

		If zNewType IsNot Nothing Then
			Return zNewType
		Else
			Throw New ImportException("Could not convert type " & pType.Name & " to the corresponding " & zSuffix & " type.")
		End If

	End Function

    Public Shared Function GetEsObject(ByVal pType As System.Type) As Object
        Dim zConstructorInfo As ConstructorInfo = pType.GetConstructor(New Type() {pType})
        If zConstructorInfo Is Nothing Then
            Return Activator.CreateInstance(pType, True)
        Else
            Return Activator.CreateInstance(pType)
        End If

    End Function


    Private Shared Function GetEsMeta(ByVal pEsObject As EntitySpaces.Core.esMetadata, ByVal pOption As EntitySpaceMetaOption) As String

        Dim zParm As String = ""
        Dim zValue As String = ""
        Select Case pOption
            Case EntitySpaceMetaOption.Catalog, EntitySpaceMetaOption.Schema
                zParm = pOption.ToString
            Case EntitySpaceMetaOption.Table
                zParm = "Source"
        End Select

        Dim zSpecificMetaData As EntitySpaces.Interfaces.esProviderSpecificMetadata = pEsObject.GetType.InvokeMember("GetProviderMetadata", BindingFlags.InvokeMethod, Nothing, pEsObject, New Object() {"esDefault"})
        Dim zSpecificMetaDataType As System.Type = zSpecificMetaData.GetType
        zValue = zSpecificMetaDataType.InvokeMember(zParm, BindingFlags.GetProperty, Nothing, zSpecificMetaData, Nothing).ToString
        Return zValue

    End Function

    Public Shared Function GetEsColumnMetadataCollection(ByVal pEsObject As EntitySpaces.Core.esMetadata) As EntitySpaces.Interfaces.esColumnMetadataCollection

        Dim zMetaClassType As Type = pEsObject.GetType
        Dim zMeta As Object = zMetaClassType.InvokeMember("Meta", Reflection.BindingFlags.InvokeMethod, Nothing, zMetaClassType, Nothing)
        Return DirectCast(zMetaClassType.InvokeMember("Columns", Reflection.BindingFlags.GetProperty, Nothing, zMeta, Nothing), EntitySpaces.Interfaces.esColumnMetadataCollection)

    End Function

    Public Shared Function GetEsColumnMetadataCollection(ByVal pType As System.Type) As esColumnMetadataCollection
        Dim zMetaType As System.Type = GetEsType(pType, EntitySpaceClassType.MetaData)
        Return GetEsColumnMetadataCollection(GetEsObject(zMetaType))
    End Function

    Public Shared Function GetEsColumnMetadata(ByVal pEsMetaObject As EntitySpaces.Core.esMetadata, ByVal pColumnName As String) As EntitySpaces.Interfaces.esColumnMetadata

        Dim zMetaClassType As Type = pEsMetaObject.GetType
        Dim zMeta As Object = zMetaClassType.InvokeMember("Meta", Reflection.BindingFlags.InvokeMethod, Nothing, zMetaClassType, Nothing)
        Dim zColumnMetaDataCollection = DirectCast(zMetaClassType.InvokeMember("Columns", Reflection.BindingFlags.GetProperty, Nothing, zMeta, Nothing), EntitySpaces.Interfaces.esColumnMetadataCollection)

        For Each zColumnMetadata As esColumnMetadata In zColumnMetaDataCollection
            If zColumnMetadata.PropertyName.ToLower = pColumnName.ToLower Or
             zColumnMetadata.Name.ToLower = pColumnName.ToLower Then
                Return zColumnMetadata
            End If
        Next

        Throw New ImportException(pColumnName & " does not exist in " & zMeta.GetType.ToString & ". Check the table and/or column and try again.")

    End Function

    Public Shared Function GetEsMetadataObject(ByVal pType As System.Type) As EntitySpaces.Core.esMetadata
        Dim zSysType As System.Type = GetEsType(pType, EntitySpaceClassType.MetaData)
        Dim zMetaObj As EntitySpaces.Core.esMetadata = GetEsObject(zSysType)
        Return zMetaObj
    End Function

    Public Shared Function GetEsColumnPropertyName(ByVal pEsMetaObject As EntitySpaces.Core.esMetadata, ByVal pColumnName As String) As String
        Dim pColumnMeta As esColumnMetadata = GetEsColumnMetadata(pEsMetaObject, pColumnName)
        Return pColumnMeta.PropertyName
    End Function

    Public Shared Function GetEsColumnDataType(ByVal pType As System.Type, ByVal pColumnName As String) As System.Type
        Dim zMetatype As System.Type = GetEsType(pType, EntitySpaceClassType.MetaData)
        Return GetEsColumnDataType(GetEsObject(zMetatype), pColumnName)
    End Function

    Public Shared Function GetEsColumnDataType(ByVal pEsObject As esMetadata, ByVal pColumnName As String) As System.Type
        Dim pColumnMeta As esColumnMetadata = GetEsColumnMetadata(pEsObject, pColumnName)
        Return Type.GetType(pColumnMeta.Type.FullName)
    End Function

    Public Shared Function GetEsColumnMaxLength(ByVal ptype As System.Type, ByVal pColumnName As String) As Long
        Dim zMetaObj As esMetadata = GetEsMetadataObject(ptype)
        Dim zColMeta As esColumnMetadata = GetEsColumnMetadata(zMetaObj, pColumnName)
        Return zColMeta.CharacterMaxLength
    End Function
    Public Shared Function GetEsTableName(ByVal pType As System.Type) As String
        Dim zMetaObj As esMetadata = GetEsMetadataObject(pType)
        Return GetEsMeta(zMetaObj, EntitySpaceMetaOption.Table)
    End Function

    Public Shared Function GetEsSchemaName(ByVal pType As System.Type) As String
        Dim zMetaObj As esMetadata = GetEsMetadataObject(pType)
        Return GetEsMeta(zMetaObj, EntitySpaceMetaOption.Schema)
    End Function

    Public Shared Function GetEsCatalogName(ByVal pType As System.Type) As String
        Dim zMetaObj As esMetadata = GetEsMetadataObject(pType)
        Return GetEsMeta(zMetaObj, EntitySpaceMetaOption.Catalog)
    End Function


	Public Enum EntitySpaceClassType
		Entity
		Query
		Collection
		MetaData
	End Enum
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum EntitySpaceMetaOption
        Table
        Catalog
        Schema
    End Enum

End Class
