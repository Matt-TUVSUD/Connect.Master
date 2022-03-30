Imports System
Imports System.ServiceModel.Activation
Imports System.ServiceModel.Web
Imports EntitySpaces.Interfaces
Imports EntitySpaces.js
Imports EntitySpaces.Loader
Imports EntitySpaces.DynamicQuery

Imports GRC.Connect.Libraries.CoreLib.BusinessObjects
Imports System.ServiceModel
Imports System.ServiceModel.Channels
Imports System.Web
Imports System.Web.Script.Services
Imports EntitySpaces.Core

Namespace Service
    Partial Public Class ViewServer

#Region "GSafeSitemapItems Members"

        <WebInvoke(ResponseFormat:=WebMessageFormat.Json, RequestFormat:=WebMessageFormat.Json, BodyStyle:=WebMessageBodyStyle.Bare)> _
        Public Function GetAllSiteMapItems(pGSafeGuid As String) As jsResponse(Of ViewCCGSafeSitemapItemsCollection, ViewCCGSafeSitemapItems)
            Dim zResponse As New jsResponse(Of ViewCCGSafeSitemapItemsCollection, ViewCCGSafeSitemapItems)()
            Dim zGSafeId As Integer = UtilGSafe.GetId(pGSafeGuid)

            Try
                Dim zColl As New ViewCCGSafeSitemapItemsCollection
                Dim zQry As New ViewCCGSafeSitemapItemsQuery

                zQry.SelectAll()
                zQry.Where(zQry.NavVisible <> False, zQry.GSafeId = zGSafeId)
                zQry.OrderBy(zQry.NavSiteMapKeyWord.Ascending, zQry.NavParentLinkId.Ascending, zQry.NavOrder.Ascending)
                If zColl.Load(zQry) Then
                    If zColl.Count = 0 Then
                        ' IF NO RECORDS REPORT NOT FOUND
                        With zColl(0)
                            .NavSiteMapKeyWord = "Not Found"
                        End With
                    Else
                        ' REPLACE THE HOME FOLDER WITH THE VERSION STAMPED FOLDER
                        For Each zItem As ViewCCGSafeSitemapItems In zColl
                            zItem.NavUrl = zItem.NavUrl.Replace("/Home/", "/Home_{{VER}}/")
                            ' ADD RECENT UPDATE DATE PARM
                            'If zItem.NavGridId = UtilMeta.GetMetaKey("RecentUpdates", 180) Then
                            '    Dim zUpdates As UtilUpdates.UpdateResult = UtilUpdates.GetCounts(pGSafeGuid)
                            '    Dim zDate As Date = zUpdates.DocLibLastReviewedDate
                            '    zItem.NavUrl = zItem.NavUrl & "?isrecent=1" ' + zDate & "&title1=" & "2"
                            'End If
                        Next
                    End If
                    zResponse.collection = zColl
                End If

            Catch ex As Exception
                zResponse.exception = ex.Message
            End Try

            Return zResponse
        End Function

#End Region

    End Class
End Namespace
