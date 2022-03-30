Imports Telerik.Web.UI

Public Class Columns
    Inherits System.Web.UI.Page

    Private Sub RadTabStrip1_TabClick(sender As Object, e As Telerik.Web.UI.RadTabStripEventArgs) Handles RadTabStrip1.TabClick
        Me.RadMultiPage1.FindPageViewByID(e.Tab.PageViewID).Selected = True
        If e.Tab.Tabs.Count > 0 Then
            For Each ztab As RadTab In e.Tab.Tabs
                If ztab.PageViewID = e.Tab.PageViewID Then
                    ztab.Selected = True
                End If
            Next
        End If
    End Sub

    Private Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim IsMetaAuth As Boolean = IIf(Session("IsMetaAuth") Is Nothing, False, Session("IsMetaAuth"))

        For Each pageview As Telerik.Web.UI.RadPageView In Me.RadMultiPage1.PageViews
            If pageview.Index = 0 Then
                pageview.Visible = Not IsMetaAuth
            Else
                pageview.Visible = IsMetaAuth
            End If
        Next

        For Each tab As Telerik.Web.UI.RadTab In Me.RadTabStrip1.Tabs
            If tab.Index = 0 Then
                tab.Visible = Not IsMetaAuth
            Else
                tab.Visible = IsMetaAuth
            End If
        Next

        If IsMetaAuth Then
            If Me.RadTabStrip1.SelectedTab Is Nothing Then
                Me.RadTabStrip1.Tabs(1).Selected = True
                Me.RadMultiPage1.PageViews(Me.RadTabStrip1.SelectedIndex).Selected = True
            End If
        Else
            Me.RadTabStrip1.Tabs(0).Selected = True
            Me.RadPageView1.Selected = True
        End If

    End Sub

    Protected Overrides Function OnBubbleEvent(source As Object, args As EventArgs) As Boolean

        If TypeOf args Is GridCommandEventArgs Then
            Dim arg As GridCommandEventArgs = DirectCast(args, GridCommandEventArgs)
            If arg.CommandName = "NavigateToGrid" Then
                Dim dataItem As GridDataItem = DirectCast(arg.Item, GridDataItem)
                Dim gridId As Integer = dataItem.GetDataKeyValue("fldId")
                Me.RadTabStrip1.Tabs(2).Selected = True
                Me.RadPageView3.Selected = True

                Dim gridMeta As GridMeta = Me.RadPageView3.FindControl("GridMeta")
                Dim grid As RadGrid = gridMeta.FindControl("RadGridByGrid")
                grid.MasterTableView.Columns.FindByDataField("fldId").CurrentFilterFunction = GridKnownFunction.EqualTo
                grid.MasterTableView.Columns.FindByDataField("fldId").CurrentFilterValue = gridId
                grid.MasterTableView.FilterExpression = "([fldId]='" & gridId & "')"
                grid.Rebind()
                grid.MasterTableView.FindItemByKeyValue("fldId", gridId).Expanded = True
            End If

        End If

        Return True
    End Function

End Class