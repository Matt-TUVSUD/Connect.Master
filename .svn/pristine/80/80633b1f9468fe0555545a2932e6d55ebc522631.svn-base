<%@ Page Language="vb" AutoEventWireup="false"  MasterPageFile="~/Home_{{VER}}/MasterWithMenu.Master" CodeBehind="videos.aspx.vb" Inherits="GRC.Connect.Web.videos" %>

<%@ Register TagPrefix="grcRSC" TagName="Loader" Src="~/Home_{{VER}}/Controls/Loader.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="../../css/KnowledgeBase/videos.css" rel="stylesheet"  type="text/css"/>
    <script src="../../Lib_{{VER}}/KnowledgeBase/videos.js" type="text/javascript"></script>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="viewVideos" class="pgBodyContent" style="">
        <ul id="VideosPanel">
            <li>
                <span>English</span>
                <div class="panelGroup">
                    <div class="videoPanelItem">
                        <div id="mediaplayer" class="videoItem"></div>
                        <div class="playlistHldr">
                            <ul id="listView" class="k-list"></ul>
                        </div>
                    </div>
                </div>
            </li>

            <%--<li>
                <span>Español</span>
                <div class="panelGroup">
                    <div class="videoPanelItem">
                        <div id="mediaplayer2" class="videoItem"></div>
                        <div class="playlistHldr">
                            <ul id="listView2" class="k-list"></ul>
                        </div>
                    </div>
                </div>
            </li>--%>
        </ul>
</div>

    <script type="text/x-kendo-template" id="template">
        <li class="k-item k-state-default" onmouseover="$(this).addClass('k-state-hover')"
            onmouseout="$(this).removeClass('k-state-hover')">
            <span class="playListItemHldr">
                <img class="playListThumbNail" src="#:poster#" />
                <h5>#:title#</h5>
            </span>
        </li>
    </script>
    <style>
    </style>

</asp:Content>
