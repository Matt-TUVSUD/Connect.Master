<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/MasterWithMenu.master" CodeBehind="LatLongSearch.aspx.vb" Inherits="GRC.Connect.Web.LatLongSearch" %>
<%@ Register TagPrefix="grcRSC" TagName="Loader" Src="~/Home_{{VER}}/Controls/Loader.ascx" %>
<%@ Register TagPrefix="StdHeader" TagName="StdHeader" Src="~/Home_{{VER}}/UserControl/PageStandardHeader.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Lib_{{VER}}/JQuery/jquery.cookie.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/JQuery/cache-controller_{{VER}}.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/global.js"></script>
    <script src="../../Lib_{{VER}}/json/json2.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/ES/entityspaces.XHR.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/NavLink.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Config/baseurl.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Session/sessvars.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/util_{{VER}}.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/gauge.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/topbanner.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/nav.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/export.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/searchLatLong.js" type="text/javascript"></script>

    <link rel="Stylesheet" type="text/css" href="../../css/pages/LatLongSearch.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- LOADING -->
    <grcRSC:Loader runat="server" id="loader" />

    <div id="view" class="pgBodyContent" style="align-items:center;">
        <div id="LatLongHolder">
            <StdHeader:StdHeader runat="server" ID="HeaderUC" Header="LATITUDE/LONGITUDE SEARCH" />

            <br />
            <br />
            <p>1. Enter a latitude/longitude.<br />
                2. Enter the distance in the desired measurement of miles, nautical miles, or kilometers.<br />
                3. Click <b>Search</b> to view a list of active facilities in TUV SUD GRC Connect.</p>
            <br />
            <br />

            <div id="windowLatLong_InputHeader" style="text-align: center;">
                <b>Enter the Latitude and Longitude for your Point of Interest</b>
            </div>
            <br />
            <div id="windowLatLong_LatLongContainers" style="text-align: center; margin: auto;">
                <span id="windowLatLong_LatColumn" style="width: 90px; display: inline-block;">Latitude *
                </span>
                &nbsp;<!--&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;-->
                <span id="windowLatLong_LongColumn" style="width: 90px; display: inline-block;">Longitude *
                </span>
            </div>
            <div id="windowLatLong_LatLongInputContainers" style="text-align: center;">
                <span id="windowLatLong_LatColumnInput">
                    <input id="windowLatLong_LatInput" class="k-autocomplete k-input inputNoEdit numericOnly" style="width: 90px; padding-left: 3px;" />
                </span>
                &nbsp;<!--&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;-->
                <span id="windowLatLong_LongColumnInput">
                    <input id="windowLatLong_LongInput" class="k-autocomplete k-input inputNoEdit numericOnly" style="width: 90px; padding-left: 3px;" />
                </span>
            </div>
            <br />
            <div id="windowLatLong_UnitsDistanceContainer" style="text-align: center;">
                <div id="windowLatLong_UnitsDistanceLabel">
                    Enter distance and choose units
                </div>
                <input id="windowLatLong_DistanceInput" class="k-autocomplete k-input inputNoEdit numericOnly" style="width: 75px; padding-left: 3px;" />
                <input id="windowLatLong_UnitInput" class="inputNoEdit recInputRec" style="text-align: left !important; font-size: 10.1pt !important;" />
            </div>
            <br />
            <div id="windowLatLong_NameYourSearchContainer" style="text-align: center;">
                <div id="windowLatLong_NameYourSearchLabel">
                    Name Your Search (optional)
                </div>
                <input id="windowLatLong_NameYourSearchInput" class="k-autocomplete k-input inputNoEdit" style="width: 215px; padding-left: 3px;" />
            </div>
            <br />
            <div style="display:flex; justify-content:center; flex-direction:row;">
                <button class="grcBlueBtn" style="margin-right: 15px;" id="btnCompute" onclick="onComputeClick();return false;">Search</button>
                <button class="grcNeutralBtn"  id="btnReset" onclick="onResetClick()">Reset</button>
            </div>
            <br />
            <br />
            <br />
            <div id="LLnote">
                <b>* Signed degrees format (DDD.dddd) -</b> A latitude or longitude with 4 decimal places pinpoints a location to approximately 4-12 meters, depending on the location.<br />
                Precede South latitudes and West longitudes with a minus sign.  Latitudes range from -90 to 90.  Longitudes range from -180 to 180.
            </div>
        </div>
    </div>

</asp:Content>
