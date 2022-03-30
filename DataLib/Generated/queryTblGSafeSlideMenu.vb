'/===============================================================\
'| razor query (experimental) - rev 4.2.272                      |
'|---------------------------------------------------------------|
'|  Template: gen.vb.sqlserver (experimental version)            |
'|   Website: http://www.pigford.net/razor                       |
'|                                                               |
'| Known Issues:                                                 |
'\===============================================================/

Namespace razor
    Public Class queryTblGSafeSlideMenu
        Inherits razor.UtilSQLServer.Query

        Private _Members As New Dictionary(Of String, Object)

        Public colGSafeId As New razor.UtilSQLServer.IntegerDataColumn
        Public colSlideMenuJSON As New razor.UtilSQLServer.StringDataColumn
        Public colSlideType As New razor.UtilSQLServer.StringDataColumn
        Public colGSafeSlideMenuId As New razor.UtilSQLServer.IntegerDataColumn

        Public Sub New()
            MyBase.FirstColumn = _FirstColumn()
            MyBase.TableName = _TableName()
            colGSafeId.ColumnName = "[GSafeId]"
            colSlideMenuJSON.ColumnName = "[SlideMenuJSON]"
            colSlideType.ColumnName = "[SlideType]"
            colGSafeSlideMenuId.ColumnName = "[GSafeSlideMenuId]"

            _Members.Add("colGSafeId", colGSafeId)
            _Members.Add("colSlideMenuJSON", colSlideMenuJSON)
            _Members.Add("colSlideType", colSlideType)
            _Members.Add("colGSafeSlideMenuId", colGSafeSlideMenuId)
        End Sub

        Public Function Member(pObjectName As String) As Object
            Dim zReturn As Object = Nothing
            If _Members.ContainsKey(pObjectName) Then
                zReturn = _Members.Item(pObjectName)
            Else
                Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in member dictionary.")
            End If
            Return zReturn
        End Function

        Public Function MemberColumn(pObjectName As String) As String
            Select Case pObjectName
                Case "colGSafeId"
                    Return "[GSafeId]"
                Case "colSlideMenuJSON"
                    Return "[SlideMenuJSON]"
                Case "colSlideType"
                    Return "[SlideType]"
                Case "colGSafeSlideMenuId"
                    Return "[GSafeSlideMenuId]"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Public Function Column2Member(pColumnName As String) As String
            Select Case pColumnName
                Case "[GSafeId]", "GSafeId", "GSafeId", "colGSafeId"  
                    Return "colGSafeId"
                Case "[SlideMenuJSON]", "SlideMenuJSON", "SlideMenuJSON", "colSlideMenuJSON"  
                    Return "colSlideMenuJSON"
                Case "[SlideType]", "SlideType", "SlideType", "colSlideType"  
                    Return "colSlideType"
                Case "[GSafeSlideMenuId]", "GSafeSlideMenuId", "GSafeSlideMenuId", "colGSafeSlideMenuId"  
                    Return "colGSafeSlideMenuId"
                Case Else
                    Throw New System.Exception("pColumnName=[" & pColumnName & "] does not exist in column list.")
            End Select
        End Function

        Public Function MemberLangType(pObjectName As String) As String
            Select Case pObjectName
                Case "colGSafeId"
                    Return "Integer"
                Case "colSlideMenuJSON"
                    Return "String"
                Case "colSlideType"
                    Return "String"
                Case "colGSafeSlideMenuId"
                    Return "Integer"
                Case Else
                    Throw New System.Exception("pObjectName=[" & pObjectName & "] does not exist in column list.")
            End Select
        End Function

        Private Function _TableName() As String
            Return "[dbo].[GSafeSlideMenu]"
        End Function

        Private Function _FirstColumn() As String
            Return "[GSafeId]"
        End Function

    End Class
End namespace

