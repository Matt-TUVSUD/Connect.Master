<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/Grids/GridMasterPageFavorites.master" CodeBehind="Favorites.aspx.vb" Inherits="GRC.Connect.Web.Grids_Favorites" %>
<%@ Register TagPrefix="grcRSC" TagName="Loader" Src="~/Home_{{VER}}/Controls/Loader.ascx" %>

<asp:Content ID="GridHeadContent" ContentPlaceHolderID="GridHeadContent" runat="server">
    <script src="../../../Lib_{{VER}}/Grids/Favorites.js"></script>
    <script>
        var ServerSide_GridId = "<%=ServerSide_GridId%>";
    </script>
</asp:Content>
<asp:Content ID="GridBodyContent" ContentPlaceHolderID="GridBodyContent" runat="server">
    <!-- LOADING -->
    <grcRSC:Loader runat="server" id="loader" />

    <div id="viewFavoritesGrid" class="pgBodyContent" style="align-content:center; justify-content:center;">

        <!-- CONTENT -->
        <div class="" style="max-width:1550px; width:100%;">
            <div class="">
                <div id="txtMessage" style="text-align: left;"><label data-bind="text: txtMessage"></label>&nbsp;</div>
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
                    <div id="gridFavoritesContainer">
                        <div id="gridFavorites"></div>
                    </div>
                </div>
                <br style="clear: both;" />
            </div>
        </div>

        <!-- HIDDEN DOMS -->
        <div id="windowRenameFavorite" class="windowFavorite" style="display: none; none; margin: 0; padding: 0;">
            <div class="windowFavoriteFooter">
                <br />
                <div style="float: left;">Name: <input type="text" data-bind="value: favoriteRenameName" maxlength="249" class="k-autocomplete" style="width: 350px; height: 28px;" /></div>
                <div style="float: right;"><button class="k-button pickListButton" data-bind="click: onFavoriteRenameSave">Save</button>&nbsp;<button class="k-button pickListButton" data-bind="click: onFavoriteRenameCancel">Cancel</button></div>
                <div style="clear: both; color: red; text-align: center;"><label data-bind="text: txtMessageRename"></label>&nbsp;</div>
                <br />
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
        <!-- END HIDDEN DOMS -->

    </div>
</asp:Content>

