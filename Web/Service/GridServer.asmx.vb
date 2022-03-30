Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Imports Newtonsoft.Json
Imports EntitySpaces

<System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<System.Web.Services.WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class GridServer
    Inherits System.Web.Services.WebService

    <WebMethod()> _
    Public Function HelloWorld() As String
        Return "Hello World"
    End Function

    <WebMethod()> _
    Public Sub SaveClient()
        System.Diagnostics.Debug.Print("Query String")
        For zNdx = 0 To Context.Request.QueryString.Count - 1
            System.Diagnostics.Debug.Print(Context.Request.QueryString.Keys(zNdx) & " = " & Context.Request.QueryString.Item(zNdx))
        Next

        System.Diagnostics.Debug.Print("Form Data")
        For zNdx = 0 To Context.Request.Form.Count - 1
            System.Diagnostics.Debug.Print(Context.Request.Form.Keys(zNdx) & " = " & Context.Request.Form.Item(zNdx))
        Next

        Dim zClient As New BusinessObjects.Clients
        Dim zCldbname As String = Context.Request("Cldbname")

        zClient.LoadByPrimaryKey(zCldbname)  'LoadPrimaryKey used to lookup record for edit, un-needed for add new
        zClient.Clientname = Context.Request("Clientname")
        zClient.Features = Context.Request("Features")
        zClient.Fileprefix = Context.Request("Fileprefix")
        zClient.Clientdesigneename = Context.Request("Clientdesigneename")
        zClient.Save()
    End Sub

    <WebMethod(Description:="Return pure JSON")> _
    Public Sub LoadAllClients()
        'Context.Response.AppendHeader("Access-Control-Allow-Origin", "*")
        Dim zQuery As New BusinessObjects.ClientsQuery("t1")
        Dim zData As New BusinessObjects.ClientsCollection
        Dim zTable As New List(Of RowClient)
        Dim zRow As RowClient
        Dim zDataValues As String = ""

        Dim zPage As Integer = 0
        Dim zPageSize As Integer = 0
        Dim zSkip As Integer = 0
        Dim zTake As Integer = 0
        Dim zSortDirection As String = ""
        Dim zSortField As String = ""

        Dim zFilterField As String = ""
        Dim zFilterOperator As String = ""
        Dim zFilterValue As String = ""

        Dim zNdx As Integer = 0
        For zNdx = 0 To Context.Request.Form.Count - 1
            System.Diagnostics.Debug.Print(Context.Request.Form.Keys(zNdx) & " = " & Context.Request.Form.Item(zNdx))
        Next

        zPage = Val(Context.Request("page"))
        zPageSize = Val(Context.Request("pageSize"))
        zSkip = Val(Context.Request("skip"))
        zTake = Val(Context.Request("take"))

        zSortDirection = Context.Request("sort[0][dir]")
        zSortField = Context.Request("sort[0][field]")

        zFilterField = Context.Request("filter[filters][0][field]")
        zFilterOperator = Context.Request("filter[filters][0][operator]")
        zFilterValue = Context.Request("filter[filters][0][value]")
        'filter[filters][0][field] = sys_id
        'filter[filters][0][operator] = eq
        'filter[filters][0][value] = sa
        'filter[logic] = and

        'zData.Query.es.Top = 250

        'Dim zWhereField As Object
        'zWhereField = zQuery.SysId

        'If Not zFilterField Is Nothing Then
        '    Select Case zFilterField
        '        Case "sys_id"
        '            Select Case zFilterOperator
        '                Case "eq"
        '                    zQuery.Where(zQuery.SysId.Equal(zFilterValue))
        '                Case "neq"
        '                    zQuery.Where(zQuery.SysId.NotEqual(zFilterValue))
        '                Case "contains"
        '                    zQuery.Where(zQuery.SysId.Like("%" & zFilterValue & "%"))
        '                Case "startswith"
        '                    zQuery.Where(zQuery.SysId.Like(zFilterValue & "%"))
        '                Case "endswith"
        '                    zQuery.Where(zQuery.SysId.Like("%" & zFilterValue))
        '            End Select
        '            'zQuery.Where(zQuery("SysId") = zFilterValue)

        '    End Select
        'End If
        'zQuery.Where(zQuery.LEmployeeID.Equal("10160 "))
        zQuery.es.WithNoLock = True

        zQuery.es.CountAll = True
        Dim zTotalRowCount As Long = CLng(zQuery.ExecuteScalar)

        zQuery.es.CountAll = False
        zQuery.es.PageSize = zPageSize
        zQuery.es.PageNumber = zPage
        If Not zSortField Is Nothing Then
            If zSortDirection = "desc" Then
                zQuery.OrderBy(zSortField, DynamicQuery.esOrderByDirection.Descending)
            Else
                zQuery.OrderBy(zSortField, DynamicQuery.esOrderByDirection.Ascending)
            End If
        Else
            zQuery.OrderBy(zQuery.Cldbname, DynamicQuery.esOrderByDirection.Ascending)
        End If

        If zData.Load(zQuery) Then
            For Each zItem As BusinessObjects.Clients In zData
                zRow = New RowClient
                If Not zItem.Cldbname Is Nothing Then zRow.Cldbname = zItem.Cldbname
                If Not zItem.Clientname Is Nothing Then zRow.Clientname = zItem.Clientname
                If Not zItem.Fileprefix Is Nothing Then zRow.Fileprefix = zItem.Fileprefix
                If Not zItem.Features Is Nothing Then zRow.Features = zItem.Features
                If Not zItem.Clientdesigneename Is Nothing Then zRow.Clientdesigneename = zItem.Clientdesigneename
                zTable.Add(zRow)
                zRow = Nothing
            Next
        End If

        Dim zSetting As New JsonSerializerSettings
        zSetting.ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        zDataValues = JsonConvert.SerializeObject(zTable, Formatting.None, zSetting)

        Dim sb As New StringBuilder()
        Dim sw As New System.IO.StringWriter(sb)

        Using jsonWriter As JsonWriter = New JsonTextWriter(sw)
            jsonWriter.Formatting = Formatting.None

            jsonWriter.WriteStartObject()
            jsonWriter.WritePropertyName("DataSet") : jsonWriter.WriteValue("Clients")
            jsonWriter.WritePropertyName("Filter") : jsonWriter.WriteValue("All Rows")
            jsonWriter.WritePropertyName("TotalRowCount") : jsonWriter.WriteValue(zTotalRowCount)
            jsonWriter.WritePropertyName("DataValues")
            jsonWriter.WriteRaw(zDataValues)
            jsonWriter.WriteEndObject()
        End Using

        Context.Response.Write(sb)
    End Sub

End Class