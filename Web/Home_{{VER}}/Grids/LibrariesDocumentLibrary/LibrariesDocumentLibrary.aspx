<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/Grids/GridMasterPage.master" CodeBehind="LibrariesDocumentLibrary.aspx.vb" Inherits="GRC.Connect.Web.Grids_LibrariesDocumentLibrary" %>
<%@ Register TagPrefix="grcRSC" TagName="Loader" Src="~/Home_{{VER}}/Controls/Loader.ascx" %>
<%--<asp:Content ID="CustomConversionContent" runat="server" ContentPlaceHolderID="CustomConversionContent">
</asp:Content>--%>

<asp:Content ID="GridHeadContent" ContentPlaceHolderID="GridHeadContent" runat="server">
    <script src="../../../Lib_{{VER}}/Grids/LibrariesDocumentLibrary.js"></script>
    <script>
        var ServerSide_GridId = "<%=ServerSide_GridId%>";

        $(window).on('load', function () {
            var documentdate = global.getQueryVariable("documentdate");
            if (documentdate != null)
                $("#RecentDocs").prop("checked", true);
            else
                $("#AllDocs").prop("checked", true);
            $('#gridNavHldr').removeClass('noShow');
        })

        function doFiltering(shouldFilter) {
            if (shouldFilter) 
                __doPostBack('CustomPostBack', 1);
            else
                __doPostBack('CustomPostBack', 0);
            
            return false;
        }

    </script>
</asp:Content>
<asp:Content ID="GridBodyContent" ContentPlaceHolderID="GridBodyContent" runat="server">
    <grcRSC:Loader runat="server" id="loader" />
    <div class="radioHldr">
        <input type="radio" name="FilterType" id="AllDocs" class="" onclick="doFiltering(0)">
        <label class="" for="AllDocs">Show all documents</label>
        <input type="radio" name="FilterType" id="RecentDocs" class="" onclick="doFiltering(1)">
        <label class="" for="RecentDocs">Show recently uploaded documents</label>
    </div>
    <div id="viewGrid" class="pgBodyContent">


        <!-- CONTENT -->
        <div class="containerContent">

            <div class="containerFormStretch">
                <div id="txtMessage" style="text-align: left;"><%--<span>Message Center:</span>&nbsp;--%><label data-bind="text: txtMessage"></label>&nbsp;</div>
                <div class="section gridTopInfoContainer" style="">
                    <div class="col span2of2" style="margin-top: 3px;">
                        <div><label>Sorted:</label>&nbsp;&nbsp;&nbsp;&nbsp;<span data-bind="text: txtSortedBy" id="txtSortedBy"></span></div>
                        <div><label>Filtered:</label>&nbsp;&nbsp;<span data-bind="text: txtFilteredBy" id="txtFilteredBy"></span></div>
                        <div><label>Pinned:</label>&nbsp;&nbsp;&nbsp;<span data-bind="text: txtPinnedBy" id="txtPinnedBy"></span></div>
                    </div>
                    <div class="col span2of2" style="margin-top: 6px; margin-bottom: 4px;">
                        <div><label data-bind="text: txtTotalRecords" id="txtTotalRecords"></label><label> Records</label></div>
                    </div>
                </div>
                <div>
                    <!-- THE GRID -->
                    <div id="gridStandardContainer">
                        <div id="gridStandard"></div>
                    </div>
                </div>
                <br style="clear: both;" />
            </div>
        </div>


        <!-- HIDDEN DOMS -->
        <div id="windowFavorite" class="windowFavorite" style="display: none; none; margin: 0; padding: 0;">
            <div class="windowFavoriteHeader">To save your Favorite, type in a name in the name box and click Save.</div>
            <div class="windowFavoriteList" data-bind="foreach: { data: favoriteList, includeDestroyed: false }">
                <div class="windowFavoriteListItem"><label data-bind="text: $data.title"></label></div>
            </div>
            <div class="windowFavoriteFooter">
                <div style="float: left;">Name: <input type="text" data-bind="value: favoriteName" maxlength="249" class="k-autocomplete" style="width: 350px; height: 28px;" /></div>
                <div style="float: right;"><button class="k-button pickListButton" data-bind="click: onFavoriteSave">Save</button>&nbsp;<button class="k-button pickListButton" data-bind="    click: onFavoriteCancel">Cancel</button></div>
            </div>
        </div>


        <div id="windowPicklistStandard" class="pickListWindow" style="display: none;">
            <div class="pickListHeader"><label>Check the items to show.</label></div>
            <div class="pickListContent">
                <div id="windowPicklistStandard_Loading" class="pickListLoading"> <!-- MUST USE Name_Loading NAMING FORMAT FOR ID -->
                    <img src="../../Images/loading/loading_2x.gif" class="pickListLoadingImage" />
                </div>
                <div id="windowPicklistStandard_Table" class="pickListTable"></div> <!-- MUST USE Name_Table NAMING FORMAT FOR ID -->
            </div>
            <div class="pickListFooter">
                <button class="k-button pickListButton" data-bind="click: pickListCheckAll">All</button>&nbsp;
                <button class="k-button pickListButton" data-bind="click: pickListCheckNone">None</button>&nbsp;
                <button class="k-button pickListButton" data-bind="click: pickListCheckReverse">Reverse</button>&nbsp;
                <div style="height: 4px;">&nbsp;</div>
                <button class="k-button pickListButton" data-bind="click: pickListApplyFilter">Apply</button>&nbsp;
                <button class="k-button pickListButton" data-bind="click: pickListCancel">Cancel</button>
            </div>
        </div>

    </div>
</asp:Content>



