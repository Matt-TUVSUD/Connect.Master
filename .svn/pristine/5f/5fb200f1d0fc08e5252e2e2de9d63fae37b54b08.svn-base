<%@ Page Title="Fire Program Facility Rating | Global Risk Consultants" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectLocationRatingFromChart.Master" CodeBehind="facilityratingfromchart.aspx.vb" Inherits="GRC.Connect.Web.FacilityRatingFromChart_fire" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="Stylesheet" type="text/css" href="../../css/pages/facilityrating.css" />
    <script src="../../Lib_{{VER}}/Generated/ViewCCFireFacilityRating.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCLocationListingFire.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCFireFacilityRating.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCLocationListingFire.js" type="text/javascript"></script>
</asp:Content>

<%--<asp:Content ID="ContentFindCriteria" ContentPlaceHolderID="ContentFindCriteria" runat="server">
    <div class="headerFindCriteria" id="viewFindCriteria" data-bind="with: viewFindCriteria">
        <label data-bind="text: $parent.findCriteria" id="findCriteria"></label>&nbsp;
    </div>
</asp:Content>--%>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="view" data-bind="with: view">
    <div id="tabLocDetailsContainer" class="tabLocDetailsContainer" style="padding-top:0px; margin-top:0px;">
         <div id="tabLocDetailsLoading" class="tabLocDetailsLoading">
            Loading ...
        </div>
        <div id="tabLocDetailsContainerInside" class="tabLocDetailsContainerInside">
            <div id="tabStrip" class="k-tabstrip-wrapper">
                <ul>
                    <li class="k-state-active">Rating From Chart</li>
                </ul>
                <div>
                    <!-- TABLE FOR COMPANY / ADDRESS INFORMATION -->
                    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
                    <div class="tableDiv">
                        <div class="tabRow">
                            <span class="companyLabels1">
                                <label data-bind="text: $parent.objLanguageLabels().lblGRCLocNo, css: { findOn: $parent.objFind().findFileNo, findOff: !$parent.objFind().findFileNo }">GRC Loc. No.</label></span>
                            <span class="companyInputs1">
                                <input data-bind="value: $parent.objListing().FileNo, css: { findOnInput: $parent.objFind().findFileNo, findOffInput: !$parent.objFind().findFileNo }" id="FileNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="1" /></span>
                            <span class="companyLabels2">
                                <label data-bind="text: $parent.objLanguageLabels().lblClientLocNo, css: { findOn: $parent.objFind().findClientLocNo, findOff: !$parent.objFind().findClientLocNo }">Client Loc. No.</label></span>
                            <span class="companyInputs2">
                                <input data-bind="value: $parent.objListing().ClientLocNo, css: { findOnInput: $parent.objFind().findClientLocNo, findOffInput: !$parent.objFind().findClientLocNo }" id="ClientLocNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs2" tabindex="2" /></span>
                            <span class="companyLabels5">
                                <label data-bind="text: $parent.objLanguageLabels().lblLatitude, css: { findOn: $parent.objFind().findLatitude, findOff: !$parent.objFind().findLatitude }">Latitude</label></span>
                            <span class="companyInputs4">
                                <input data-bind="value: $parent.objListing().Latitude, css: { findOnInput: $parent.objFind().findLatitude, findOffInput: !$parent.objFind().findLatitude }" id="Latitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="3" /></span>
                            <span class="companyLabels4">
                                <label data-bind="text: $parent.objLanguageLabels().lblLongitude, css: { findOn: $parent.objFind().findLongitude, findOff: !$parent.objFind().findLongitude }">Longitude</label></span>
                            <span class="companyInputs4">
                                <input data-bind="value: $parent.objListing().Longitude, css: { findOnInput: $parent.objFind().findLongitude, findOffInput: !$parent.objFind().findLongitude }" id="Longitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="4" /></span>
                        </div>
                        <div  class="tabRow">
                            <span class="companyLabels1">
                                <label data-bind="text: $parent.objLanguageLabels().lblAddress1, css: { findOn: $parent.objFind().findAddress1, findOff: !$parent.objFind().findAddress1 }">Address</label></span>
                            <span class="companyInputs6">
                                <input data-bind="value: $parent.objListing().Address1, css: { findOnInput: $parent.objFind().findAddress1, findOffInput: !$parent.objFind().findAddress1 }" id="Address1" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs6" tabindex="5" /></span>
                            <span class="companyLabels3">
                                <label data-bind="text: $parent.objLanguageLabels().lblDivisionName, css: { findOn: $parent.objFind().findDivision, findOff: !$parent.objFind().findDivision }">Division Name</label></span>
                            <span class="companyInputs5">
                                <input data-bind="value: $parent.objListing().Division, css: { findOnInput: $parent.objFind().findDivision, findOffInput: !$parent.objFind().findDivision }" id="Division" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="6" /></span>
                        </div>
                        <div  class="tabRow">
                            <span class="companyLabels1">
                                <label data-bind="text: $parent.objLanguageLabels().lblCity, css: { findOn: $parent.objFind().findCity, findOff: !$parent.objFind().findCity }">City</label></span>
                            <span class="companyInputs1">
                                <input data-bind="value: $parent.objListing().City, css: { findOnInput: $parent.objFind().findCity, findOffInput: !$parent.objFind().findCity }" id="City" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="7" /></span>
                            <span class="stateLabels">
                                <label data-bind="text: $parent.objLanguageLabels().lblState, css: { findOn: $parent.objFind().findStProv, findOff: !$parent.objFind().findStProv }">State</label></span>
                            <span class="stateInputs">
                                <input data-bind="value: $parent.objListing().StProv, css: { findOnInput: $parent.objFind().findStProv, findOffInput: !$parent.objFind().findStProv }" id="StProv" class="k-autocomplete k-input inputNoEdit inputLeft stateInputs" tabindex="8" /></span>
                            <span class="countryLabels">
                                <label data-bind="text: $parent.objLanguageLabels().lblCountry, css: { findOn: $parent.objFind().findCountry, findOff: !$parent.objFind().findCountry }">Country</label></span>
                            <span class="countryInputs">
                                <input data-bind="value: $parent.objListing().Country, css: { findOnInput: $parent.objFind().findCountry, findOffInput: !$parent.objFind().findCountry }" id="Country" class="k-autocomplete k-input inputNoEdit inputLeft countryInputs" tabindex="9" /></span>
                            <span class="postalLabels">
                                <label data-bind="text: $parent.objLanguageLabels().lblPostalCode, css: { findOn: $parent.objFind().findZip, findOff: !$parent.objFind().findZip }">Postal</label></span>
                            <span class="postalInputs">
                                <input data-bind="value: $parent.objListing().Zip, css: { findOnInput: $parent.objFind().findZip, findOffInput: !$parent.objFind().findZip }" id="Zip" class="k-autocomplete k-input inputNoEdit inputLeft postalInputs" tabindex="10" /></span>
                            <span class="companyLabels3">
                                <label data-bind="text: $parent.objLanguageLabels().lblFacilityName, css: { findOn: $parent.objFind().findFacility, findOff: !$parent.objFind().findFacility }">Facility Name</label></span>
                            <span class="companyInputs5">
                                <input data-bind="value: $parent.objListing().Facility, css: { findOnInput: $parent.objFind().findFacility, findOffInput: !$parent.objFind().findFacility }" id="Facility" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="11" /></span>
                        </div>
                        <div  class="tabRow">
                            <!-- BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
                            <span class="companyLabels1"><%--<img data-bind="visible: $parent.loading" src="../../Home_{{VER}}/Images/loading/loadingdetails.gif" style="height: 20px; width: 75px; border: 0px;" alt="Loading" />--%></span>
                            <span class="buttonContainerLocationLoading"></span>
                            <!-- END BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
                            <span class="companyLabels6">
                                <label data-bind="text: $parent.objLanguageLabels().lblCustomerAccess, css: { findOn: $parent.objFind().findCustomAccess, findOff: !$parent.objFind().findCustomAccess }">Custom Access</label></span>
                            <span class="companyInputs5">
                                <input data-bind="value: $parent.objListing().CustomAccess, css: { findOnInput: $parent.objFind().findCustomAccess, findOffInput: !$parent.objFind().findCustomAccess }" id="CustomAccess" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="12" /></span>
                        </div>
                    </div>
                    <!-- END TABLE FOR COMPANY / ADDRESS INFORMATION -->

                    <!-- TABLE FOR PASSIVE SCORE INFORMATION -->
                    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
                    <div>
                        <div class="tabBannerHeader" style="font-size: 12px;">
                            <label>Passive Score:</label>
                            <label>Flood</label>
                            <label>Earthquake</label>
                            <label>Windstorm</label>
                            <label>Constr.</label>
                            <label>Occup.</label>
                            <label>Other Exposure</label>
                            <label>Inspection Date</label>
                        </div>
                    </div>
                    <div class="tableDivAutoBorders">
                        <div class="tableDiv">
                            <div class="tabRow">
                                <!-- EMPTY ROW AT TOP MUST HAVE HEIGHT SPECIFIED OR IT WILL BE 23px -->
                                <span class="bufferLeft passiveLabels" style="height: 4px;"></span>
                                <span class="passiveInputs" style="height: 4px;">&nbsp;</span>
                                <span class="passiveInputs" style="height: 4px;">&nbsp;</span>
                                <span class="passiveInputs" style="height: 4px;"></span>
                                <span class="passiveInputs" style="height: 4px;">&nbsp;</span>
                                <span class="passiveInputs" style="height: 4px;">&nbsp;</span>
                                <span class="passiveInputs" style="height: 4px;"></span>
                                <span class="borderRight" style="height: 4px;">&nbsp;</span>
                                <span class="passiveTotalLabels" style="height: 4px;">&nbsp;</span>
                                <span class="borderRightSmall" style="height: 4px;"></span>
                            </div>
                            <div class="tabRow">
                                <span class="bufferLeft passiveLabels">
                                    <label data-bind="text: $parent.objLanguageLabels().lblWeight">Weight</label></span>
                                <span class="passiveInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Floodweight" id="Floodweight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                <span class="passiveInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Earthquakeweight" id="Earthquakeweight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                <span class="passiveInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Windstormweight" id="Windstormweight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                <span class="passiveInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Constructionweight" id="Constructionweight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                <span class="passiveInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Occupancyweight" id="Occupancyweight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                <span class="passiveInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Otherweight" id="Otherweight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                <span class="borderRight"></span>
                                <span class="passiveTotalLabels" style="padding-left: 23px; width: 100px;">
                                    <input data-bind="" id="Inspectiondate" class="k-numerictextbox inputCenter inputNoEdit inspectionDateInput" readonly="readonly" />
                                </span>
                                <span class="borderRight"></span>
                            </div>
                            <div class="tabRow">
                                <span class="bufferLeft passiveLabels">
                                    <label data-bind="text: $parent.objLanguageLabels().lblRating">Rating</label></span>
                                <span class="passiveInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Floodrating" id="Floodrating" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                <span class="passiveInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Earthquakerating" id="Earthquakerating" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                <span class="passiveInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Windstormrating" id="Windstormrating" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                <span class="passiveInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Constructionrating" id="Constructionrating" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                <span class="passiveInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Occupancyrating" id="Occupancyrating" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                <span class="passiveInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Otherrating" id="Otherrating" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                <span class="borderRight"></span>
            
                                <span class="borderRight"></span>
                            </div>
                            <div class="tabRow">
                                <span class="bufferLeft passiveDescriptionLabels" style="height: 46px;">
                                    <label data-bind="text: $parent.objLanguageLabels().lblDescription">Description</label></span>
                                <span class="passiveDescriptionInputs" style="height: 46px;">
                                    <textarea data-bind="value: $parent.objFacilityRating().Flooddescription, attr: { title: $parent.objFacilityRating().Flooddescription }" id="Flooddescription" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly"></textarea></span>
                                <span class="passiveDescriptionInputs" style="height: 46px;">
                                    <textarea data-bind="value: $parent.objFacilityRating().Earthquakedescription, attr: { title: $parent.objFacilityRating().Earthquakedescription }" id="Earthquakedescription" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly"></textarea></span>
                                <span class="passiveDescriptionInputs" style="height: 46px;">
                                    <textarea data-bind="value: $parent.objFacilityRating().Windstormdescription, attr: { title: $parent.objFacilityRating().Windstormdescription }" id="Windstormdescription" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly"></textarea></span>
                                <span class="passiveDescriptionInputs" style="height: 46px;">
                                    <textarea data-bind="value: $parent.objFacilityRating().Constructiondescription, attr: { title: $parent.objFacilityRating().Constructiondescription }" id="Constructiondescription" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly"></textarea></span>
                                <span class="passiveDescriptionInputs" style="height: 46px;">
                                    <textarea data-bind="value: $parent.objFacilityRating().Occupancydescription, attr: { title: $parent.objFacilityRating().Occupancydescription }" id="Occupancydescription" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly"></textarea></span>
                                <span class="passiveDescriptionInputs" style="height: 46px;">
                                    <textarea data-bind="value: $parent.objFacilityRating().Otherdescription, attr: { title: $parent.objFacilityRating().Otherdescription }" id="Otherdescription" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly"></textarea></span>
                                <span class="borderRight" style="height: 46px;"></span>
                                <span class="passiveTotalLabels" style="height: 46px;">
                                    <div>&nbsp;<label data-bind="text: $parent.objLanguageLabels().lblTotalPassiveScore">Total Passive Score</label></div>
                                    <div style="">
                                        <input data-bind="value: $parent.objFacilityRating().Passivescore" id="Passivescore" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></div>
                                </span>
                                <span class="borderRightSmall" style="height: 46px;"></span>
                            </div>
                            <div style="height: 10px;" class="tabRow">
                                <span class="bufferLeft passiveLabels" style="height: 7px;">&nbsp;</span>
                                <span class="passiveInputs" style="height: 7px;">&nbsp;</span>
                                <span class="passiveInputs" style="height: 7px;">&nbsp;</span>
                                <span class="passiveInputs" style="height: 7px;">&nbsp;</span>
                                <span class="passiveInputs" style="height: 7px;">&nbsp;</span>
                                <span class="passiveInputs" style="height: 7px;">&nbsp;</span>
                                <span class="passiveInputs" style="height: 7px;">&nbsp;</span>
                                <span class="borderRight" style="height: 7px;">&nbsp;</span>
                                <span class="passiveTotalLabels" style="height: 7px;">&nbsp;</span>
                                <span class="borderRightSmall" style="height: 7px;">&nbsp;</span>
                            </div>
                        </div>
                        <!-- END TABLE FOR PASSIVE SCORE INFORMATION -->
                    </div>

                    <div style="height: 5px;">&nbsp;</div>

                    <!-- TABLE FOR ACTIVE SCORE INFORMATION -->
                    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
                    <div>
                        <div class="tabBannerHeader" style="font-size: 12px;">
                            <label>&nbsp;</label>
                            <label style="flex-basis: 105px;">Active Score:</label>
                            <label style="flex-basis: 120px;">Protection</label>
                            <label style="flex-basis: 125px;">Human Element</label>
                            <label>Nat'l Hazard Protection</label>
                            <label>Bus. Cont. Planning</label>
                            <label style="flex-basis: 150px">&nbsp;</label>
                        </div>
                    </div>
                    <div class="tableDivAutoBorders">
                        <div class="tableDiv">
                            <div class="tabRow">
                                <!-- EMPTY ROW AT TOP MUST HAVE HEIGHT SPECIFIED OR IT WILL BE 23px -->
                                <span class="bufferLeft activeLabels" style="height: 4px;"></span>
                                <span class="activeInputs" style="height: 4px;">&nbsp;</span>
                                <span class="activeInputs" style="height: 4px;">&nbsp;</span>
                                <span class="activeInputs" style="height: 4px;"></span>
                                <span class="activeInputs" style="height: 4px;"></span>
                                <span class="borderRight" style="height: 4px;">&nbsp;</span>
                                <span class="activeTotalLabels" style="height: 4px;">&nbsp;</span>
                                <span class="borderRightSmall" style="height: 4px;"></span>
                            </div>
                            <div class="tabRow">
                                <span class="bufferLeft activeLabels">
                                    <label data-bind="text: $parent.objLanguageLabels().lblWeight">Weight</label></span>
                                <span class="activeInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Physicalprotectionweight" id="Physicalprotectionweight" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                                <span class="activeInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Humanelementweight" id="Humanelementweight" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                                <span class="activeInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Naturalhazardsprotectionweight" id="Naturalhazardsprotectionweight" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                                <span class="activeInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Businesscontinuityweight" id="Businesscontinuityweight" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                                <span class="borderRight"></span>
                                <span class="activeTotalLabels">
                                    <div style="font-size: 6px;">&nbsp;<br />
                                    </div>
                                    <label data-bind="text: $parent.objLanguageLabels().lblTotalActiveScore" style="margin-top: 15px;">Total Active Score</label></span>
                                <span class="borderRightSmall"></span>
                            </div>
                            <div class="tabRow">
                                <span class="bufferLeft activeLabels">
                                    <label data-bind="text: $parent.objLanguageLabels().lblRating">Rating</label></span>
                                <span class="activeInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Physicalprotectionrating" id="Physicalprotectionrating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                                <span class="activeInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Humanelementrating" id="Humanelementrating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                                <span class="activeInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Naturalhazardsprotectionrating" id="Naturalhazardsprotectionrating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                                <span class="activeInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Businesscontinuityrating" id="Businesscontinuityrating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                                <span class="borderRight"></span>
                                <span class="activeTotalInputsCell">
                                    <input data-bind="value: $parent.objFacilityRating().Activescore" id="Activescore" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                <span class="borderRightSmall"></span>
                            </div>
                            <div class="tabRow">
                                <span class="bufferLeft activeDescriptionLabels" style="height: 46px;">
                                    <label data-bind="text: $parent.objLanguageLabels().lblDescription">Description</label></span>
                                <span class="activeDescriptionInputs" style="height: 46px;">
                                    <textarea data-bind="value: $parent.objFacilityRating().Firedescription, attr: { title: $parent.objFacilityRating().Firedescription }" id="Firedescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly"></textarea></span>
                                <span class="activeDescriptionInputs" style="height: 46px;">
                                    <textarea data-bind="value: $parent.objFacilityRating().Humandescription, attr: { title: $parent.objFacilityRating().Humandescription }" id="Humandescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly"></textarea></span>
                                <span class="activeDescriptionInputs" style="height: 46px;">
                                    <textarea data-bind="value: $parent.objFacilityRating().Naturaldescription, attr: { title: $parent.objFacilityRating().Naturaldescription }" id="Naturaldescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly"></textarea></span>
                                <span class="activeDescriptionInputs" style="height: 46px;">
                                    <textarea data-bind="value: $parent.objFacilityRating().Businessdescription, attr: { title: $parent.objFacilityRating().Businessdescription }" id="Businessdescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly"></textarea></span>
                                <span class="borderRight" style="height: 46px;"></span>
                                <span class="activeTotalLabels" style="height: 46px;">
                                    <div style="font-size: 6px;">&nbsp;<br />
                                        &nbsp;<br />
                                        &nbsp;<br />
                                    </div>
                                    <label data-bind="text: $parent.objLanguageLabels().lblTotalActiveScoreRecsCompleted">Total Active Score with Recs Completed</label></span>
                                <span class="borderRightSmall" style="height: 46px;"></span>
                            </div>
                            <div class="tabRow">
                                <span class="bufferLeft activeLabels">
                                    <label data-bind="text: $parent.objLanguageLabels().lblRatingAllRecsCompleted" style="line-height: normal; ">Rating with All Recs Completed</label></span>
                                <span class="activeInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Fireprotectionallrecscompleterating" id="Fireprotectionallrecscompleterating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                                <span class="activeInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Humanelementallrecscompleterating" id="Humanelementallrecscompleterating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                                <span class="activeInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Nathazprotallrecscompleterating" id="Nathazprotallrecscompleterating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                                <span class="activeInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Bcpallrecscompletrating" id="Bcpallrecscompletrating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                                <span class="borderRight"></span>
                                <span class="activeTotalInputsCell">
                                    <input data-bind="value: $parent.objFacilityRating().Activescorewithrecscomplete" id="Activescorewithrecscomplete" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                                <span class="borderRightSmall"></span>
                            </div>
                            <div class="tabRow">
                                <span class="bufferLeft activeLabels" style="height: 46px;">
                                    <label data-bind="text: $parent.objLanguageLabels().lblDescription" style="line-height: 35px;">Description</label></span>
                                <span class="activeDescriptionInputs" style="height: 46px;">
                                    <textarea data-bind="value: $parent.objFacilityRating().Firerecdescription, attr: { title: $parent.objFacilityRating().Firerecdescription }" id="Firerecdescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly"></textarea></span>
                                <span class="activeDescriptionInputs" style="height: 46px;">
                                    <textarea data-bind="value: $parent.objFacilityRating().Humanrecdescription, attr: { title: $parent.objFacilityRating().Humanrecdescription }" id="Humanrecdescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly"></textarea></span>
                                <span class="activeDescriptionInputs" style="height: 46px;">
                                    <textarea data-bind="value: $parent.objFacilityRating().Naturalrecdescription, attr: { title: $parent.objFacilityRating().Naturalrecdescription }" id="Naturalrecdescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly"></textarea></span>
                                <span class="activeDescriptionInputs" style="height: 46px;">
                                    <textarea data-bind="value: $parent.objFacilityRating().Businessrecdescription, attr: { title: $parent.objFacilityRating().Businessrecdescription }" id="Businessrecdescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly"></textarea></span>
                                <span class="borderRight" style="height: 46px;"></span>
                                <span class="activeTotalLabels" style="height: 46px;"></span>
                                <span class="borderRightSmall" style="height: 46px;"></span>
                            </div>
                            <div style="height: 10px;" class="tabRow">
                                <span class="bufferLeft activeLabels" style="height: 7px;">&nbsp;</span>
                                <span class="activeInputs" style="height: 7px;">&nbsp;</span>
                                <span class="activeInputs" style="height: 7px;">&nbsp;</span>
                                <span class="activeInputs" style="height: 7px;">&nbsp;</span>
                                <span class="activeInputs" style="height: 7px;">&nbsp;</span>
                                <span class="borderRight" style="height: 7px;">&nbsp;</span>
                                <span class="activeTotalLabels" style="height: 7px;">&nbsp;</span>
                                <span class="borderRightSmall" style="height: 7px;">&nbsp;</span>
                            </div>
                        </div>
                        <!-- END TABLE FOR ACTIVE SCORE INFORMATION -->
                    </div>

                    

                    <div style="display: flex;">
                        <!-- ************************* -->
                        <!-- TABLE FOR APL INFORMATION -->
                        <div data-bind="visible: $parent.clientFeatures().search('A') < 0 && $parent.clientFeatures().search('U') < 0" class="tableDiv" style="display: flex; width: auto; flex-basis: 265px; flex-direction: column; justify-content: center; align-items: flex-end; text-align: right;">
                            <div>
                                <span class="summaryAPLLabels">
                                    <label data-bind="text: $parent.objLanguageLabels().lblAPLPDBI">APL (PD + BI)</label></span>
                                <span class="summaryAPLInputs">
                                    <input data-bind="value: $parent.objFacilityRating().APLString" id="Apl" class="k-textbox inputCenter inputNoEdit summaryAPLInputs" readonly="readonly" /></span>
                            </div>
                            <div>
                                <span class="summaryAPLLabels">
                                    <label data-bind="text: $parent.objLanguageLabels().lblAplfactor">APL Factor</label></span>
                                <span class="summaryAPLInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Aplfactor" id="Aplfactor" class="k-numerictextbox k-input inputCenter inputNoEdit summaryAPLInputs" readonly="readonly" /></span>
                            </div>
                            <div>
                                <span class="summaryAPLLabels">
                                    <label data-bind="text: $parent.objLanguageLabels().lblAPLAllRecsComplete">APL with All Recs Completed</label></span>
                                <span class="summaryAPLInputs">
                                    <input data-bind="value: $parent.objFacilityRating().APLWITHALLRECSCOMPLETEString" id="Aplwithallrecscomplete" class="k-textbox inputCenter inputNoEdit summaryAPLInputs" readonly="readonly" /></span>
                            </div>
                            <div>
                                <span class="summaryAPLLabels">
                                    <label data-bind="text: $parent.objLanguageLabels().lblAplfactorAllRecsComplete">APL Factor with All Recs Completed</label></span>
                                <span class="summaryAPLInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Aplfactorwithallrecscomplete" id="Aplfactorwithallrecscomplete" class="k-numerictextbox inputCenter inputNoEdit summaryAPLInputs" readonly="readonly" /></span>
                            </div>
                        </div>
                        <div data-bind="visible: !$parent.clientFeatures().search('A') < 0" style="display:flex; width:auto; flex-basis:265px; flex-direction:column; justify-content:center; align-items:flex-end; text-align:right;">&nbsp</div>
                        <!-- END TABLE FOR APL INFORMATION -->
                        <!-- TABLE FOR APL FACTOR KEY -->
                        <div data-bind="visible: $parent.clientFeatures().search('A') < 0 && $parent.clientFeatures().search('U') < 0" class="tableDiv containerAPLFactorKey">
                            <div>
                                <span class="borderTop borderLeft factorKeyLabel" style="height: 10px; text-align: center;"><b>
                                    <label data-bind="text: $parent.objLanguageLabels().lblAplfactorKey">APL Factor Key</label></b></span>
                                <span class="borderTop borderRight" style="height: 10px; width: 1px;"></span>
                            </div>
                            <div>
                                <span class="borderLeft factorKeyLabel" style="height: 10px;">&nbsp;&nbsp;If APL &lt;
                                        <label data-bind="text: $parent.objFacilityRating().APLKeyRange1"></label>
                                    &nbsp;&nbsp;APL F =
                                        <label data-bind="    text: $parent.objFacilityRating().APLKeyFactor1"></label>
                                </span>
                                <span class="borderRight" style="height: 10px; width: 1px;"></span>
                            </div>
                            <div>
                                <span class="borderLeft factorKeyLabel" style="height: 10px;">&nbsp;&nbsp;If APL &lt;
                                        <label data-bind="text: $parent.objFacilityRating().APLKeyRange2"></label>
                                    &nbsp;&nbsp;APL F =
                                        <label data-bind="    text: $parent.objFacilityRating().APLKeyFactor2"></label>
                                </span>
                                <span class="borderRight" style="height: 10px; width: 1px;"></span>
                            </div>
                            <div>
                                <span class="borderLeft factorKeyLabel" style="height: 10px;">&nbsp;&nbsp;If APL &lt;
                                        <label data-bind="text: $parent.objFacilityRating().APLKeyRange3"></label>
                                    APL F =
                                        <label data-bind="    text: $parent.objFacilityRating().APLKeyFactor3"></label>
                                </span>
                                <span class="borderRight" style="height: 10px; width: 1px;"></span>
                            </div>
                            <div>
                                <span class="borderBottom borderLeft factorKeyLabel" style="height: 10px; padding-bottom: 10px;">&nbsp;&nbsp;If APL &gt;
                                        <label data-bind="text: $parent.objFacilityRating().APLKeyRange4"></label>
                                    APL F =
                                        <label data-bind="    text: $parent.objFacilityRating().APLKeyFactor4"></label>
                                </span>
                                <span class="borderBottom borderRight" style="height: 10px; padding-bottom: 10px; width: 1px;"></span>
                            </div>
                        </div>
                        <div data-bind="visible: !$parent.showAPL()" style="width:145px;">&nbsp</div>
                        <!-- END TABLE FOR APL FACTOR KEY -->

                         <!-- ***************************** -->
                    <!-- TABLE FOR RATING KEY -->
                    <div style="display: flex; width:400px; justify-content:flex-end; align-items:center;">
                        <!-- TABLE FOR SUMMARY INFORMATION -->
                        <div class="tableDiv containerSummary" data-bind="visible: $parent.clientFeatures().search('U') < 0">
                            <div>
                                <span class="summaryLabels">
                                    <label data-bind="text: $parent.objLanguageLabels().lblTotalFacilityScore">Total Facility Score</label></span>
                                <span class="summaryInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Totalscore" id="Totalscore" class="k-numerictextbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                            </div>
                            <div>
                                <span class="summaryLabels">
                                    <label data-bind="text: $parent.objLanguageLabels().lblOverallRatings">Overall Rating</label></span>
                                <span class="summaryInputsSmallFonts">
                                    <input data-bind="value: $parent.objFacilityRating().Overallplantratingdescription" id="Overallplantratingrating" class="k-textbox inputCenter inputNoEdit summaryTextInputs" readonly="readonly" />
                                </span>
                            </div>
                            <div>
                                <span class="summaryLabels">
                                    <label data-bind="text: $parent.objLanguageLabels().lblOverallScoreRecsComplete">Overall Score with Recs Compl.</label></span>
                                <span class="summaryInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Overallscorewithrecscomplete" id="Overallscorewithrecscomplete" class="k-numerictextbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                            </div>
                            <div>
                                <span class="summaryLabels">
                                    <label data-bind="text: $parent.objLanguageLabels().lblMaxPossibleScore">Max Possible Score</label></span>
                                <span class="summaryInputs">
                                    <input data-bind="value: $parent.objFacilityRating().Maxpossiblescore" id="Maxpossiblescore" class="k-numerictextbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                            </div>
                            <div>
                                <span class="summaryLabels">
                                    <label data-bind="text: $parent.objLanguageLabels().lblMaxpossiblerating">Max Possible Rating</label></span>
                                <span class="summaryInputsSmallFonts">
                                    <input data-bind="value: $parent.objFacilityRating().Maxpossiblescoredescription" id="Maxpossiblerating" class="k-textbox inputCenter inputNoEdit summaryTextInputs" readonly="readonly" /></span>
                            </div>
                        </div>
                        <div class="ratingColorTable" style="float:none; margin-left:10px;">
                            <div class="ratingKeyCell" id="RatingKeyColor1" style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription1">
                                <label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription1"></label>
                            </div>
                            <div class="ratingKeyCell" id="RatingKeyColor2" style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription2">
                                <label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription2"></label>
                            </div>
                            <div class="ratingKeyCell" id="RatingKeyColor3" style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription3">
                                <label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription3"></label>
                            </div>
                            <div class="ratingKeyCell" id="RatingKeyColor4" style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription4">
                                <label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription4"></label>
                            </div>
                            <div class="ratingKeyCell" id="RatingKeyColor5" style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription5">
                                <label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription5"></label>
                            </div>
                        </div>
                        <div>
                            <span class="borderBottom borderLeft ratingKeyBuffer" style="height: 12px;"></span>
                            <span class="borderBottom ratingKeyContent" style="height: 12px;"></span>
                            <span class="borderBottom borderRight ratingKeyBuffer" style="height: 12px;"></span>
                        </div>
                    </div>
                    <!-- END TABLE FOR SUMMARY INFORMATION -->
                    </div>
                    <div data-bind="visible: $parent.clientFeatures().search('U') > -1 " style="display: flex; width: 51%;">
                        <!-- ************************* -->
                        <!-- TABLE FOR ACHIEVABLE AVERAGE INFORMATION -->
                        <div class="containerAPLHeaders">
                            <div class="floatLeft summaryAPLLabels" style="width: 235px;">&nbsp;</div>
                            <div class="floatLeft centerAlign bold" style="width: 82px; margin-right: 11px;">
                                Rating<br />
                                <span style="display: block; float: left; width: 35px;" title="average">AVG</span><span style="display: block; float: left; width: 10px;">&nbsp;/&nbsp;</span><span style="display: block; float: left; width: 35px;" title="weighted average">WAVG</span>
                            </div>
                            <div class="floatLeft centerAlign bold" style="width: 85px;">
                                Achievable<br />
                                <span style="display: block; float: left; width: 35px;" title="average">AVG</span><span style="display: block; float: left; width: 10px;">&nbsp;/&nbsp;</span><span style="display: block; float: left; width: 35px;" title="weighted average">WAVG</span>
                            </div>
                        </div>
                        <div data-bind="visible: $parent.clientFeatures().search('U') > -1" style="width: 270px; margin: 5px 0 5px 155px; font-size: 10px;">
                            <label style="white-space: normal;">
                                (The weighted average (WAVG) is calculated using the TIV.)
                            </label>
                        </div>
                        <div class="tableDiv containerAPL" style="width: auto; margin-left: 55px;" data-bind="foreach: $parent.colAverageWeightedAverage()">
                            <div data-bind="visible: IsVisible">
                                <span class="summaryLabels" style="width: 180px; height: 15px; line-height: 18px;">
                                    <label data-bind="text: Label" class="inputCenter inputNoEdit summaryAPLInputs"></label>
                                </span>
                                <span class="summaryInputs" style="margin-right: 2px; width: 40px;">
                                    <label data-bind="text: Value1" id="" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" style="display: block; width: 100%;"></label>
                                </span>
                                <span class="summaryInputs" style="margin-right: 10px; width: 40px;">
                                    <label data-bind="text: Value2" id="Label4" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" style="display: block; width: 100%;"></label>
                                </span>
                                <span class="summaryInputs" style="margin-right: 2px; width: 40px;">
                                    <label data-bind="text: Value3 ? Value3 : '&nbsp;'" id="Label5" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" style="display: block; width: 100%;"></label>
                                </span>
                                <span class="summaryInputs" style="margin-right: 0px; width: 40px;">
                                    <label data-bind="text: Value4 ? Value4 : '&nbsp;'" id="Label3" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" style="display: block; width: 100%;"></label>
                                </span>
                            </div>
                        </div>
                        <!-- END TABLE FOR ACHIEVABLE AVERAGE INFORMATION -->
                        <!-- TABLE FOR APL FACTOR KEY -->
                    </div>
                   
                    <!-- ***************************** -->
                    <!-- TABLE FOR MAGNA SUMMARY INFORMATION -->
                    <div class="tableDiv containerSummary" data-bind="visible: $parent.clientFeatures().search('U') > -1" style="float: right;">
                        <div>
                            <span class="summaryLabels">
                                <label data-bind="text: $parent.objLanguageLabels().lblTotalFacilityScore">Total Facility Score</label></span>
                            <span class="summaryInputs">
                                <input data-bind="value: $parent.objFacilityRating().Totalscore" id="T_FacilityScore" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                        </div>
                        <div>
                            <span class="summaryLabels">
                                <label data-bind="text: $parent.objLanguageLabels().lblOverallRatings">Overall Rating</label></span>
                            <span class="summaryInputs">
                                <input style="font-size: 8pt;" data-bind="value: $parent.objFacilityRating().Overallplantratingdescription" id="OverallRatingValue" class="k-textbox inputCenter inputNoEdit summaryTextInputs" readonly="readonly" value="Poorer Risk < 50" />
                            </span>
                        </div>
                        <div>
                            <span class="summaryLabels">
                                <label data-bind="text: $parent.objLanguageLabels().lblOverallScoreRecsComplete">Overall Score with Recs Compl.</label></span>
                            <span class="summaryInputs">
                                <input data-bind="value: $parent.objFacilityRating().Overallscorewithrecscomplete" id="OverallCompleteScore" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" value="" /></span>
                        </div>
                        <div>
                            <span class="summaryLabels">
                                <label data-bind="">Overall Rating with Recs Compl.</label></span>
                            <span class="summaryInputs">
                                <input data-bind="value: $parent.objFacilityRating().OverallScoreWithRecsCompleteRating" id="OverallRatingWRecsCompl" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" value="" /></span>
                        </div>
                        <div>
                            <span class="summaryLabels">
                                <label data-bind="">Achievable Rating %</label></span>
                            <span class="summaryInputsSmallFonts">
                                <input data-bind="value: $parent.objFacilityRating().AchievableScorePercentString" id="RatingPotentialPercent" class="k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" value="" /></span>
                        </div>
                        <div>
                            <span class="summaryLabels">
                                <label data-bind="text: $parent.objLanguageLabels().lblAPLPDBI">APL (PD + BI)</label></span>
                            <span class="summaryInputs">
                                <input data-bind="value: $parent.objFacilityRating().APLString" id="Text1" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                        </div>
                        <div>
                            <span class="summaryLabels">
                                <label data-bind="text: $parent.objLanguageLabels().lblAPLAllRecsComplete">APL with All Recs Completed</label></span>
                            <span class="summaryInputs">
                                <input data-bind="value: $parent.objFacilityRating().APLWITHALLRECSCOMPLETEString" id="Text2" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                        </div>
                    </div>
                    <!-- END TABLE FOR MAGNA SUMMARY INFORMATION -->
                            
                        
                    
                    <!-- END TABLE FOR RATING KEY -->


                    <!-- NOTES -->
                    <div data-bind="visible: $parent.clientFeatures().search('A') < 0 && $parent.clientFeatures().search('U') < 0" style="display:flex; justify-content:flex-end; font-size:7pt;">
                        <div style="width:375px;">
                            <label style="white-space: normal;" data-bind="text: $parent.objLanguageLabels().lblAPLNote">(The total facility score is the sum of all Passive and Active scores multiplied by the APL Factor.  The lower the facility's APL the greater the APL Factor.)</label>
                        </div>
                    </div>
                    <div data-bind="visible: !$parent.clientFeatures().search('A') < 0" class="aplNote">
                        <div style="width:375px;">
                            <label style="white-space:normal;">(The total facility score is the sum of all Passive and Active scores.)</label>
                        </div>
                    </div>
                </div>
            </div>


        </div>
    </div>

     <!-- AREA FOR ERROR AND NOTICE MESSAGES -->
    <div style=""><label class="messageError" data-bind="text: $parent.messageError"></label><label class="messageNotice" data-bind="    text: $parent.messageNotice"></label><label class="messageWarning" data-bind="    text: $parent.messageWarning"></label>&nbsp;</div>

    <!-- ERROR WINDOW FOR NO RECORD FOUND NOTIFICATION -->
    <div id="windowNoLocation" class="windowContent" style="font-size:13px;">
        <div><img src="../images/icons/warning/sign_warning_32x32.png" align="left" alt="Warning" class="windowImage" /></div>
        <div style="margin-bottom:5px;">
            <label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundMessage">Warning: There was no Facility Rating record found for this location.</label>
        </div>
        <div style="margin-bottom:5px;">
            <label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundDescription">Click the below button to go back to the Location Details page, or use the Location Navigation buttons to go to another location record.</label>
        </div>
        <div style="justify-content: center; width:100%; display:flex;">
            <button class="grcBlueBtn" data-bind="text: $parent.objLanguageLabels().lblGoBackToDetails, click: $parent.onLocationDetailsRedirect">Go Back To Location Details</button>
        </div>
    </div>
</div>

<script type="text/javascript">
    $(document).ready(function () {
        ///////////////////////////////////////////
        //// LOAD SESSION VARIABLES
        var dsLanguageLabels = {
            //// COMPANY INFORMATION
            lblGRCLocNo: "GRC Loc. No.",
            lblClientLocNo: "Client Loc. No.",
            lblAddress1: "Address",
            lblCity: "City",
            lblState: "State",
            lblPostalCode: "Postal",
            lblCountry: "Country",
            lblLatitude: "Latitude",
            lblLongitude: "Longitude",
            lblDivisionName: "Division Name",
            lblFacilityName: "Facility Name",
            lblCustomerAccess: "Custom Access",

            //// PASSIVE
            lblWeight: "Weight",
            lblRating: "Rating",
            lblDescription: "Description",
            lblTotalPassiveScore: "Total Passive Score",

            //// ACTIVE
            lblRatingAllRecsCompleted: "Rating with All Recs Completed",
            lblTotalActiveScore: "Total Active Score",
            lblTotalActiveScoreRecsCompleted: "Total Active Score with Recs Completed",

            //// APL
            lblAPLPDBI: "APL (PD + BI)",
            lblAplfactor: "APL Factor",
            lblAPLAllRecsComplete: "APL with All Recs Completed",
            lblAplfactorAllRecsComplete: "APL Factor with All Recs Completed",
            lblAplfactorKey: "APL Factor Key",

            //// SUMMARY
            lblTotalFacilityScore: "Total Facility Score",
            lblOverallRatings: "Overall Rating",
            lblOverallScoreRecsComplete: "Overall Score with Recs Compl.",
            lblMaxPossibleScore: "Max Possible Score",
            lblMaxpossiblerating: "Max Possible Rating",
            lblAPLNote: "(The total facility score is the sum of all Passive and Active scores multiplied by the APL Factor.  The lower the facility's APL the greater the APL Facotr.)",

            //// RATING KEY
            lblRatingKey: "Rating Key",

            //// MISC
            lblInspectiondate: "Inspection Date",
            lblRecord: "Record",
            lblFileRecord: "Location",
            lblOf: "of",
            lblNoLocationFoundTitle: "No Facility Rating Found",
            lblNoLocationFoundMessage: "Warning: There was no Facility Rating record found for this location.",
            lblNoLocationFoundDescription: "Click the below button to go back to the Location Details page, or use the Location Navigation buttons to go to another location record.",
            lblGoBackToDetails: "Go Back To Location Details",
            lblSearchNotFound: "This location is not active for Fire.  Choose a different service."
        };


        ///////////////////////////////////////////
        //// KEYBOARD EVENT HANDLES
        ko.bindingHandlers.enterKey = {
            init: function (element, valueAccessor, allBindings, vm) {
                ko.utils.registerEventHandler(element, "keyup", function (event) {
                    if (event.keyCode === 13) {
                        ko.utils.triggerEvent(element, "change");
                        valueAccessor().call(vm, vm);
                    }
                    return true;
                });
            }
        };


        ///////////////////////////////////////////
        //// VIEWMODEL
        var viewFindCriteria = {
            findCriteria: ko.observable()
        };
        var view = {
            //// DECLARATIONS
            index: 0,
            enablePrev: ko.observable(true),
            enableNext: ko.observable(true),
            enableFilePrev: ko.observable(true),
            enableFileNext: ko.observable(true),
            messageError: ko.observable(),
            messageWarning: ko.observable(),
            messageNotice: ko.observable(),
            fileDirection: ko.observable(""),
            findEngaged: ko.observable(true),
            stateListingLoadOneRecord: true,   // THIS WILL ONLY WORK WITH TWO STATE SERVER SIDE LOAD LOGIC
            stateDetailsLoadOneRecord: true,  // THIS WILL ONLY WORK WITH TWO STATE SERVER SIDE LOAD LOGIC
            stateOnlyOneDetailRecordLoaded: true,
            stateLoadError: false,
            stateOnlyLoadDetails: false,

            //// COLLECTIONS / OBJECTS
            //// CHANGE THE NAME OF THE ES.OBJECTS PROTOTYPE
            gSafeGuid: getGSafeGUID(), //getQueryVariable('sid'),
            clientFeatures: ko.observable(),
            collFacilityRating: new es.objects.ViewCCFireFacilityRatingCollection(),
            collListing: new es.objects.ViewCCLocationListingFireCollection(),
            objFind: ko.observable(),
            objListing: ko.observable(),
            objFacilityRating: ko.observable(),
            objLanguageLabels: ko.observable(dsLanguageLabels),
            isMagna: ko.observable(false),
            showAPL: ko.observable(true),

            //// MISC
            txtRecordNumber: ko.observable(),
            txtFileRecordNumber: ko.observable(),
            txtSchedulingComments: ko.observable(),
            colorTotalscore: ko.observable(),
            colorMaxpossible: ko.observable(),
            loading: ko.observable(false),
            colAverageWeightedAverage: ko.observableArray(),

            //// BUTTONS FOR RECORD NAVIGATION
            onNext: function () {
                if (view.stateOnlyOneDetailRecordLoaded) {
                    view.loadDetailsOnly();
                }
                if (view.index < view.collFacilityRating().length - 1) {
                    view.index++;
                    view.objFacilityRating(view.collFacilityRating()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
            },

            onPrevious: function () {
                if (view.index > 0) {
                    view.index--;
                    view.objFacilityRating(view.collFacilityRating()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
            },

            onFirst: function () {
                if (view.index > 0) {
                    view.index = 0;
                    view.objFacilityRating(view.collFacilityRating()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
            },

            onLast: function () {
                if (view.stateOnlyOneDetailRecordLoaded) {
                    view.loadDetailsOnly();
                }
                if (view.index < view.collFacilityRating().length - 1) {
                    view.index = view.collFacilityRating().length - 1;
                    view.objFacilityRating(view.collFacilityRating()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
            },

            //// BUTTONS FOR FILE NUMBER / LOCATION WALK
            onFileFirst: function () {
                view.index = 0;
                view.fileDirection("first");
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
            },

            onFilePrevious: function () {
                view.index = 0;
                view.fileDirection("previous");
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
            },

            onFileNext: function () {
                view.index = 0;
                view.fileDirection("next");
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
            },

            onFileLast: function () {
                view.index = 0;
                view.fileDirection("last");
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
            },

            //// FIND A RECORD FROM THE LOCATION FIELDS
            onFind: function () {
                //// SET THE GSAFE
                setFindLocationFields(view.gSafeGuid, view.objFind(), view.objListing());
                //// LOOKUP RECORD USING THE ON FIRST NAVIGATE
                view.onFileFirst();
                view.resetPickers();
            },

            onFindClear: function () {
                //// CLEAR THE OBJECT
                view.resetPickers();
                //// SET THE GSAFE
                setFindLocationFields(view.gSafeGuid, view.objFind(), view.objListing());
                //// RELOAD THE FILE NUMBER TO GET THE CORRECT LOCATION COUNT
                view.onFileFirst();
                view.resetPickers();
            },

            onLocationDetailsRedirect: function () {
                //// REDIRECT THE USER TO THE LOCATION DETAILS PAGE
                document.location.href = "locationdetails.aspx" + "?sid=" + view.gSafeGuid;
            },

            //// ENABLE OR DISABLE BUTTONS AND SHOW RECORD NUMBER
            setupButtons: function () {
                if (view.index == 0) { view.enablePrev(false); } else { view.enablePrev(true); }
                if (view.index == view.collFacilityRating().length - 1) { view.enableNext(false); } else { view.enableNext(true); }
                if (view.stateOnlyOneDetailRecordLoaded == true) { view.enableNext(true); }
                if (view.stateOnlyOneDetailRecordLoaded) {
                    view.txtRecordNumber("1...");
                } else {
                    view.txtRecordNumber((view.index + 1) + " of " + view.collFacilityRating().length);
                }
            },

            setupFileButtons: function () {
                if (view.objListing().RecNum() <= 1) { view.enableFilePrev(false); } else { view.enableFilePrev(true); }
                if (view.objListing().RecNum() >= view.objListing().RecCount()) { view.enableFileNext(false); } else { view.enableFileNext(true); }
                if (view.objListing().RecCount() <= 1) { view.enableFilePrev(false); view.enableFilePrev(false); }
                view.txtFileRecordNumber(view.objListing().RecNum() + " of " + view.objListing().RecCount());
            },

            //// SETUP FIND FIELDS FOR LOCATIONS
            setupFindFields: function () {
                //// FIND TEXT BOXES
                view.objFind().findFileNo = view.objListing().FileNo();
                view.objFind().findClientLocNo = view.objListing().ClientLocNo();
                view.objFind().findAddress1 = view.objListing().Address1();
                view.objFind().findCity = view.objListing().City();
                view.objFind().findStProv = view.objListing().StProv();
                view.objFind().findCountry = view.objListing().Country();
                view.objFind().findZip = view.objListing().Zip();
                view.objFind().findDivision = view.objListing().Division();
                view.objFind().findFacility = view.objListing().Facility();
                view.objFind().findCustomAccess = view.objListing().CustomAccess();
                view.objFind().findLatitude = view.objListing().Latitude();
                view.objFind().findLongitude = view.objListing().Longitude();
            },

            //// RESET FIELDS ON LOAD RECORD
            resetPickers: function () {
                //// COPY THE FIND FIELDS
                view.setupFindFields();

                //// COLORS
                Maxpossiblerating.wrapper.find(".k-input").css("background-color", view.objFacilityRating().Maxpossiblescorecolor());
                Maxpossiblerating.wrapper.find(".k-input").parent().css("background-color", view.objFacilityRating().Maxpossiblescorecolor());
                Overallplantratingrating.wrapper.find(".k-input").css("background-color", view.objFacilityRating().Totalscorecolor());
                Overallplantratingrating.wrapper.find(".k-input").parent().css("background-color", view.objFacilityRating().Totalscorecolor());
                $('#OverallRatingValue').css("background-color", view.objFacilityRating().Totalscorecolor());
                $('#OverallRatingWRecsCompl').css("background-color", view.objFacilityRating().OverallScoreWithRecsCompleteHexBackColor());
                $("#RatingKeyColor1").css("background-color", view.objFacilityRating().RatingKeyColor1());
                $("#RatingKeyColor2").css("background-color", view.objFacilityRating().RatingKeyColor2());
                $("#RatingKeyColor3").css("background-color", view.objFacilityRating().RatingKeyColor3());
                $("#RatingKeyColor4").css("background-color", view.objFacilityRating().RatingKeyColor4());
                $("#RatingKeyColor5").css("background-color", view.objFacilityRating().RatingKeyColor5());

                //// VALUES PASSIVE AND ACTIVE AND OTHER
                Floodweight.value(view.objFacilityRating().Floodweight() / 10);
                Earthquakeweight.value(view.objFacilityRating().Earthquakeweight() / 10);
                Windstormweight.value(view.objFacilityRating().Windstormweight() / 10);
                Constructionweight.value(view.objFacilityRating().Constructionweight() / 10);
                Occupancyweight.value(view.objFacilityRating().Occupancyweight() / 10);
                Otherweight.value(view.objFacilityRating().Otherweight() / 10);
                Passivescore.value(view.objFacilityRating().Passivescore());
                Physicalprotectionweight.value(view.objFacilityRating().Physicalprotectionweight() / 10);
                Humanelementweight.value(view.objFacilityRating().Humanelementweight() / 10);
                Naturalhazardsprotectionweight.value(view.objFacilityRating().Naturalhazardsprotectionweight() / 10);
                Businesscontinuityweight.value(view.objFacilityRating().Businesscontinuityweight() / 10);
                Activescore.value(view.objFacilityRating().Activescore());
                Activescorewithrecscomplete.value(view.objFacilityRating().Activescorewithrecscomplete());
                Inspectiondate.value(view.objFacilityRating().Inspectiondate());

                //// VALUES AND COLORS PASSIVE
                Floodrating.value(view.objFacilityRating().Floodrating());
                Floodrating.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Floodratingcolor());
                //Floodrating.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().Floodratingcolor());
                Earthquakerating.value(view.objFacilityRating().Earthquakerating());
                Earthquakerating.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Earthquakeratingcolor());
                //Earthquakerating.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().Earthquakeratingcolor());
                Windstormrating.value(view.objFacilityRating().Windstormrating());
                Windstormrating.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Windstormratingcolor());
                //Windstormrating.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().Windstormratingcolor());
                Constructionrating.value(view.objFacilityRating().Constructionrating());
                Constructionrating.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Constructionratingcolor());
                //Constructionrating.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().Constructionratingcolor());
                Occupancyrating.value(view.objFacilityRating().Occupancyrating());
                Occupancyrating.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Occupancyratingcolor());
                //Occupancyrating.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().Occupancyratingcolor());
                Otherrating.value(view.objFacilityRating().Otherrating());
                Otherrating.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Otherratingcolor());
                //Otherrating.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().Otherratingcolor());

                //// VALUES AND COLORS ACTIVE
                Physicalprotectionrating.value(view.objFacilityRating().Physicalprotectionrating());
                Physicalprotectionrating.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Physicalprotectionratingcolor());
                //Physicalprotectionrating.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().Physicalprotectionratingcolor());
                Humanelementrating.value(view.objFacilityRating().Humanelementrating());
                Humanelementrating.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Humanelementratingcolor());
                //Humanelementrating.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().Humanelementratingcolor());
                Naturalhazardsprotectionrating.value(view.objFacilityRating().Naturalhazardsprotectionrating());
                Naturalhazardsprotectionrating.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Naturalhazardsprotectionratingcolor());
                //Naturalhazardsprotectionrating.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().Naturalhazardsprotectionratingcolor());
                Businesscontinuityrating.value(view.objFacilityRating().Businesscontinuityrating());
                Businesscontinuityrating.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Businesscontinuityratingcolor());
                //Businesscontinuityrating.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().Businesscontinuityratingcolor());
                Fireprotectionallrecscompleterating.value(view.objFacilityRating().Fireprotectionallrecscompleterating());
                Fireprotectionallrecscompleterating.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Fireprotectionallrecscompleteratingcolor());
                //Fireprotectionallrecscompleterating.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().Fireprotectionallrecscompleteratingcolor());
                Humanelementallrecscompleterating.value(view.objFacilityRating().Humanelementallrecscompleterating());
                Humanelementallrecscompleterating.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Humanelementallrecscompleteratingcolor());
                //Humanelementallrecscompleterating.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().Humanelementallrecscompleteratingcolor());
                Nathazprotallrecscompleterating.value(view.objFacilityRating().Nathazprotallrecscompleterating());
                Nathazprotallrecscompleterating.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Nathazprotallrecscompleteratingcolor());
                //Nathazprotallrecscompleterating.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().Nathazprotallrecscompleteratingcolor());
                Bcpallrecscompletrating.value(view.objFacilityRating().Bcpallrecscompletrating());
                Bcpallrecscompletrating.wrapper.find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Bcpallrecscompletratingcolor());
                //Bcpallrecscompletrating.wrapper.find(".k-formatted-value").css("background-color", view.objFacilityRating().Bcpallrecscompletratingcolor());

                //// APL VALUES
                // EXAMPLE Passivescore.value(view.objFacilityRating().Passivescore());
                //Apl.value(view.objFacilityRating().Apl());
                Aplfactor.value(view.objFacilityRating().Aplfactor());
                //Aplwithallrecscomplete.value(view.objFacilityRating().Aplwithallrecscomplete());
                Aplfactorwithallrecscomplete.value(view.objFacilityRating().Aplfactorwithallrecscomplete());

                //// SUMMARY VALUES
                Totalscore.value(view.objFacilityRating().Totalscore());
                Overallscorewithrecscomplete.value(view.objFacilityRating().Overallscorewithrecscomplete());
                Maxpossiblescore.value(view.objFacilityRating().Maxpossiblescore());
                Overallplantratingrating.value(view.objFacilityRating().Overallplantratingdescription());

                //// DISPLAY WINDOW IF NO RECORD EXISTS OR A MESSAGE IF NO SEARCH FOUND
                windowNoLocation.data("kendoWindow").close();
                view.messageError("");
                if (view.objFacilityRating().Fileno() == "Not Found") {
                    windowNoLocation.data("kendoWindow").open();
                    $("#windowNoLocation").css("display", "block");
                } else if (view.objListing().FileNo() == "Not Found") {
                    view.messageError(view.objLanguageLabels().lblSearchNotFound);
                }
            },

            //// LOAD ONLY THE LOWER DETAILS, ONE OR ALL DEPENDING ON STATE
            loadDetailsOnly: function () {
                view.stateLoadError = false;

                var tempParm = view.gSafeGuid;
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (view.stateDetailsLoadOneRecord == true && view.stateLoadError == false) {
                    if (!view.collFacilityRating.ViewCCFireFacilityRatingCollection(tempParm + "|one|True")) { view.stateLoadError = false } else { view.stateLoadError = true }
                    view.stateDetailsLoadOneRecord = false;
                    view.stateOnlyOneDetailRecordLoaded = true;
                } else {
                    if (!view.collFacilityRating.ViewCCFireFacilityRatingCollection(tempParm + "|all|True")) { view.stateLoadError = false } else { view.stateLoadError = true }
                    view.stateDetailsLoadOneRecord = false;
                    view.stateOnlyOneDetailRecordLoaded = false;
                }
                if (!view.stateLoadError) {
                    view.objFacilityRating(view.collFacilityRating()[view.index]);
                } else {
                    //// DISPLAY ERROR MESSAGE
                    view.messageError("* Error while loading record.");
                }
            },

            //// LOAD ONE FILE NUMBER AND ONE DETAIL
            loadOneFileNumber: function () {
                view.stateLoadError = false;

                var tempParm = view.gSafeGuid + "|" + view.fileDirection() + "|one|True";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collListing.ViewCCLocationFireCollections(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateListingLoadOneRecord = false;

                tempParm = view.gSafeGuid + "|one|True";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collFacilityRating.ViewCCFireFacilityRatingCollection(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateDetailsLoadOneRecord = false;
                view.stateOnlyOneDetailRecordLoaded = true;

                view.objListing(view.collListing()[0]);
                view.objFacilityRating(view.collFacilityRating()[0]);
                view.objFind(getFindLocationFields(view.gSafeGuid));

                //SET BOOL TO SHOW OR HIDE APL SECTION
                if (view.clientFeatures().search('A') > -1) {
                    view.showAPL(false);
                }

                if (view.clientFeatures().search('U') > -1) {
                    view.isMagna(true);
                }
                //LOAD MANGA DATA
                if (view.isMagna()) {
                    view.loadAverageCollection();
                }

                if (view.objFind().findCriteria == undefined || view.objFind().findCriteria == "") {
                    viewFindCriteria.findCriteria(" ");
                    view.findEngaged(true);
                } else {
                    viewFindCriteria.findCriteria(view.objFind().findCriteria);
                    view.findEngaged(false);
                }
                view.setupButtons();
                view.setupFileButtons();
            },

            //// LOAD ALL RECORDS AND ALL DETAILS
            loadFileNumber: function () {
                view.stateLoadError = false;

                //// LOAD THE LOACATION LISTINGS, ONE OR ALL, WITH FILE DIRECTION
                var tempParm = view.gSafeGuid + "|" + view.fileDirection() + "|one|True";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collListing.ViewCCLocationFireCollections(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateListingLoadOneRecord = false;

                //// LOAD ALL DETAILS
                tempParm = view.gSafeGuid + "|all|True";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collFacilityRating.ViewCCFireFacilityRatingCollection(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateDetailsLoadOneRecord = false;
                view.stateOnlyOneDetailRecordLoaded = false;

                //// DO THE REMAINING CODE TO POPUPLATE THE PAGE
                if (!view.stateLoadError) {
                    view.objListing(view.collListing()[0]);
                    view.objFacilityRating(view.collFacilityRating()[view.index]);
                    view.clientFeatures(getClientFeatures(view.gSafeGuid));
                    //SET BOOL TO SHOW OR HIDE APL SECTION
                    if (view.clientFeatures().search('A') > -1) {
                        view.showAPL(false);
                    }
                    if (view.clientFeatures().search('U') > -1) {
                        view.isMagna(true);
                    }
                    //LOAD MANGA DATA
                    if (view.isMagna()) {
                        view.loadAverageCollection();
                    }
                    view.objFind(getFindLocationFields(view.gSafeGuid));
                    view.setupButtons();
                    view.setupFileButtons();
                    if (view.objFind().findCriteria == undefined || view.objFind().findCriteria == "") {
                        viewFindCriteria.findCriteria(" ");
                        view.findEngaged(true);
                    } else {
                        viewFindCriteria.findCriteria(view.objFind().findCriteria);
                        view.findEngaged(false);
                    }
                    // FIND CORRECT RECORD INSPECTION DATE AND NAV TO IT.
                    var zInspectionDate = global.getQueryVariable("insp");
                    if (zInspectionDate) {
                        var zCount = 0;
                        for (var x = 0; x < view.collFacilityRating().length; x++) {
                            if (view.collFacilityRating()[x].Inspectiondate()) {
                                if (zInspectionDate == global.formatShortDate(view.collFacilityRating()[x].Inspectiondate())) {
                                    zCount = x;
                                    break;
                                }
                            }
                        }
                        if (zCount > 0) {
                            setTimeout(function () {
                                for (var x = 0; x < zCount; x++) {
                                    view.onNext();
                                }
                            }, 250);
                        }
                    }
                } else {
                    //// DISPLAY ERROR MESSAGE
                    view.messageError("* Error while loading record.");
                }
            },

            //LOAD MAGNA AVERAGE/WEIGHTED AVERAGE SECTION DATA
            loadAverageCollection: function () {
                try {
                    var zServiceName = "GetLocationLevelFireRatingAverages";
                    var zParms = ko.toJSON({
                        "pGSafeGuid": getGSafeGUID()
                    });
                    global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, view.loadAverageCollectionSuccess, view.loadAverageCollectionError, null);
                } catch (pException) {
                    view.processMessage("An error occurred while starting the Facility Rating Averages Section data call: " + pException.message);
                }
            },

            loadAverageCollectionSuccess: function (pResults, pParms) {
                try {
                    if (pResults.isSuccess) {
                        view.colAverageWeightedAverage(pResults.data);
                    }
                } catch (pException) {
                    view.processMessage("An error occurred while starting the Facility Rating Averages Section data call: " + pException.message);
                }
            },

            loadAverageCollectionError: function (pResults, pMessage, pErrorDetail, pParms) {
                view.processMessage("Error while loading Facility Rating Averages Section data. " + pMessage);
            },

            processMessage: function (pMessage) {
                alert(pMessage);
            }
        };


        ///////////////////////////////////////////
        //// SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
        view.loadFileNumber();

        ///////////////////////////////////////////
        //// ACTIVATE BINDINGS LAST
        ko.applyBindings(view, $("#view")[0]);
        //ko.applyBindings(viewFindCriteria, $("#viewFindCriteria")[0]); // NOT USED IN THIS VERSION OF RATINGS FORM

        ///////////////////////////////////////////
        //// SETUP KENDOUI

        //// ERROR WINDOW
        var windowNoLocation = $("#windowNoLocation");
        windowNoLocation.kendoWindow({
            width: "300px",
            height: "200px",
            title: "", // title added below with JQuery
            actions: ["Close"],
            animation: { open: { effects: "none" }, close: { effects: "default"} }
        });
        $("#windowNoLocation").closest(".k-window").css({
            top: 300,
            left: 375
        });
        $(document).find(".k-window-title").append("<img src='../images/icons/warning/window_warning_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblNoLocationFoundTitle);

        //// TEXTBOXES
        //// most plain text inputs do not need bound in JS but need kendo widgets for styles
        //        $("#FileNo").kendoAutoComplete();
        //        $("#ClientLocNo").kendoAutoComplete();
        //        $("#Latitude").kendoAutoComplete();
        //        $("#Longitude").kendoAutoComplete();
        //        $("#Address1").kendoAutoComplete();
        //        $("#Division").kendoAutoComplete();
        //        $("#City").kendoAutoComplete();
        //        $("#StProv").kendoAutoComplete();
        //        $("#Facility").kendoAutoComplete();
        //        $("#Country").kendoAutoComplete();
        //        $("#Zip").kendoAutoComplete();
        //        $("#CustomAccess").kendoAutoComplete();

        //// RATING COLORS
        var Maxpossiblerating = $("#Maxpossiblerating").kendoAutoComplete().data("kendoAutoComplete");
        //Maxpossiblerating.wrapper.find(".k-input").css("background-color", view.objFacilityRating().Maxpossiblescorecolor());
        //Maxpossiblerating.wrapper.find(".k-input").parent().css("background-color", view.objFacilityRating().Maxpossiblescorecolor());
        var Overallplantratingrating = $("#Overallplantratingrating").kendoAutoComplete().data("kendoAutoComplete");
        //Overallplantratingrating.wrapper.find(".k-input").css("background-color", view.objFacilityRating().Totalscorecolor());
        //Overallplantratingrating.wrapper.find(".k-input").parent().css("background-color", view.objFacilityRating().Totalscorecolor());

        //// KEY COLORS
        $("#RatingKeyColor1").css("background-color", view.objFacilityRating().RatingKeyColor1());
        $("#RatingKeyColor2").css("background-color", view.objFacilityRating().RatingKeyColor2());
        $("#RatingKeyColor3").css("background-color", view.objFacilityRating().RatingKeyColor3());
        $("#RatingKeyColor4").css("background-color", view.objFacilityRating().RatingKeyColor4());
        $("#RatingKeyColor5").css("background-color", view.objFacilityRating().RatingKeyColor5());

        //// DATES
        var Inspectiondate = $("#Inspectiondate").kendoDatePicker({
            value: view.objFacilityRating().Inspectiondate(),
            format: "dd-MMM-yy"
        }).data("kendoDatePicker");
        Inspectiondate.wrapper
                .find(".k-picker-wrap").addClass("expand-padding inspectionDateInput").css("height", "13px").find(".k-select").hide();

        //// PASSIVE NUMERIC TEXTBOXES
        var Floodweight = $("#Floodweight").kendoNumericTextBox({
            value: view.objFacilityRating().Floodweight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Floodweight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        var Earthquakeweight = $("#Earthquakeweight").kendoNumericTextBox({
            value: view.objFacilityRating().Earthquakeweight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Earthquakeweight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        var Windstormweight = $("#Windstormweight").kendoNumericTextBox({
            value: view.objFacilityRating().Windstormweight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Windstormweight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        var Constructionweight = $("#Constructionweight").kendoNumericTextBox({
            value: view.objFacilityRating().Constructionweight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Constructionweight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        var Occupancyweight = $("#Occupancyweight").kendoNumericTextBox({
            value: view.objFacilityRating().Occupancyweight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Occupancyweight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        var Otherweight = $("#Otherweight").kendoNumericTextBox({
            value: view.objFacilityRating().Otherweight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Otherweight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        var Floodrating = $("#Floodrating").kendoNumericTextBox({
            value: view.objFacilityRating().Floodrating(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Floodrating.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        Floodrating.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Floodratingcolor());
        //Floodrating.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().Floodratingcolor());
        var Earthquakerating = $("#Earthquakerating").kendoNumericTextBox({
            value: view.objFacilityRating().Earthquakerating(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Earthquakerating.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        Earthquakerating.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Earthquakeratingcolor());
        //Earthquakerating.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().Earthquakeratingcolor());
        var Windstormrating = $("#Windstormrating").kendoNumericTextBox({
            value: view.objFacilityRating().Windstormrating(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Windstormrating.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        Windstormrating.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Windstormratingcolor());
        //Windstormrating.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().Windstormratingcolor());
        var Constructionrating = $("#Constructionrating").kendoNumericTextBox({
            value: view.objFacilityRating().Constructionrating(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Constructionrating.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        Constructionrating.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Constructionratingcolor());
        //Constructionrating.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().Constructionratingcolor());
        var Occupancyrating = $("#Occupancyrating").kendoNumericTextBox({
            value: view.objFacilityRating().Occupancyrating(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Occupancyrating.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        Occupancyrating.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Occupancyratingcolor());
        //Occupancyrating.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().Occupancyratingcolor());
        var Otherrating = $("#Otherrating").kendoNumericTextBox({
            value: view.objFacilityRating().Otherrating(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Otherrating.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        Otherrating.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Otherratingcolor());
        //Otherrating.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().Otherratingcolor());

        var Passivescore = $("#Passivescore").kendoNumericTextBox({
            value: view.objFacilityRating().Passivescore(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Passivescore.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputs").css("height", "13px").find(".k-select").hide();

        //// ACTIVE NUMERIC BOXES
        var Physicalprotectionweight = $("#Physicalprotectionweight").kendoNumericTextBox({
            value: view.objFacilityRating().Physicalprotectionweight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Physicalprotectionweight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        var Humanelementweight = $("#Humanelementweight").kendoNumericTextBox({
            value: view.objFacilityRating().Humanelementweight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Humanelementweight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        var Naturalhazardsprotectionweight = $("#Naturalhazardsprotectionweight").kendoNumericTextBox({
            value: view.objFacilityRating().Naturalhazardsprotectionweight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Naturalhazardsprotectionweight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        var Businesscontinuityweight = $("#Businesscontinuityweight").kendoNumericTextBox({
            value: view.objFacilityRating().Businesscontinuityweight() / 10,
            format: "p0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Businesscontinuityweight.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        var Physicalprotectionrating = $("#Physicalprotectionrating").kendoNumericTextBox({
            value: view.objFacilityRating().Physicalprotectionrating(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Physicalprotectionrating.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        Physicalprotectionrating.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Physicalprotectionratingcolor());
        Physicalprotectionrating.wrapper
                .find(".k-formatted-value").css("background-color", view.objFacilityRating().Physicalprotectionratingcolor());
        var Humanelementrating = $("#Humanelementrating").kendoNumericTextBox({
            value: view.objFacilityRating().Humanelementrating(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Humanelementrating.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        Humanelementrating.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Humanelementratingcolor());
        Humanelementrating.wrapper
                .find(".k-formatted-value").css("background-color", view.objFacilityRating().Humanelementratingcolor());
        var Naturalhazardsprotectionrating = $("#Naturalhazardsprotectionrating").kendoNumericTextBox({
            value: view.objFacilityRating().Naturalhazardsprotectionrating(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Naturalhazardsprotectionrating.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        Naturalhazardsprotectionrating.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Naturalhazardsprotectionratingcolor());
        Naturalhazardsprotectionrating.wrapper
                .find(".k-formatted-value").css("background-color", view.objFacilityRating().Naturalhazardsprotectionratingcolor());
        var Businesscontinuityrating = $("#Businesscontinuityrating").kendoNumericTextBox({
            value: view.objFacilityRating().Businesscontinuityrating(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Businesscontinuityrating.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        Businesscontinuityrating.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Businesscontinuityratingcolor());
        Businesscontinuityrating.wrapper
                .find(".k-formatted-value").css("background-color", view.objFacilityRating().Businesscontinuityratingcolor());
        var Fireprotectionallrecscompleterating = $("#Fireprotectionallrecscompleterating").kendoNumericTextBox({
            value: view.objFacilityRating().Fireprotectionallrecscompleterating(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Fireprotectionallrecscompleterating.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        Fireprotectionallrecscompleterating.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Fireprotectionallrecscompleteratingcolor());
        Fireprotectionallrecscompleterating.wrapper
                .find(".k-formatted-value").css("background-color", view.objFacilityRating().Fireprotectionallrecscompleteratingcolor());
        var Humanelementallrecscompleterating = $("#Humanelementallrecscompleterating").kendoNumericTextBox({
            value: view.objFacilityRating().Humanelementallrecscompleterating(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Humanelementallrecscompleterating.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        Humanelementallrecscompleterating.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Humanelementallrecscompleteratingcolor());
        Humanelementallrecscompleterating.wrapper
                .find(".k-formatted-value").css("background-color", view.objFacilityRating().Humanelementallrecscompleteratingcolor());
        var Nathazprotallrecscompleterating = $("#Nathazprotallrecscompleterating").kendoNumericTextBox({
            value: view.objFacilityRating().Nathazprotallrecscompleterating(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Nathazprotallrecscompleterating.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        Nathazprotallrecscompleterating.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Nathazprotallrecscompleteratingcolor());
        Nathazprotallrecscompleterating.wrapper
                .find(".k-formatted-value").css("background-color", view.objFacilityRating().Nathazprotallrecscompleteratingcolor());
        var Bcpallrecscompletrating = $("#Bcpallrecscompletrating").kendoNumericTextBox({
            value: view.objFacilityRating().Bcpallrecscompletrating(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Bcpallrecscompletrating.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
        Bcpallrecscompletrating.wrapper
                .find(".k-numeric-wrap").css("background-color", view.objFacilityRating().Bcpallrecscompletratingcolor());
        //Bcpallrecscompletrating.wrapper
        //        .find(".k-formatted-value").css("background-color", view.objFacilityRating().Bcpallrecscompletratingcolor());
        var Activescore = $("#Activescore").kendoNumericTextBox({
            value: view.objFacilityRating().Activescore(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Activescore.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputs").css("height", "13px").find(".k-select").hide();
        var Activescorewithrecscomplete = $("#Activescorewithrecscomplete").kendoNumericTextBox({
            value: view.objFacilityRating().Activescorewithrecscomplete(),
            format: "n0",
            decimals: 4
        }).data("kendoNumericTextBox");
        Activescorewithrecscomplete.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding passiveInputs").css("height", "13px").find(".k-select").hide();

        //// APL NUMERIC TEXT BOXES
        //var Apl = $("#Apl").kendoNumericTextBox({
        //    value: view.objFacilityRating().Apl(),
        //    format: "c0",
        //    decimals: 0
        //}).data("kendoNumericTextBox");
        //Apl.wrapper
        //        .find(".k-numeric-wrap").addClass("expand-padding summaryAPLInputs").css("height", "13px").find(".k-select").hide();
        var Aplfactor = $("#Aplfactor").kendoNumericTextBox({
            value: view.objFacilityRating().Aplfactor(),
            format: "n1",
            decimals: 4
        }).data("kendoNumericTextBox");
        Aplfactor.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding summaryAPLInputs").css("height", "13px").find(".k-select").hide();
        //var Aplwithallrecscomplete = $("#Aplwithallrecscomplete").kendoNumericTextBox({
        //    value: view.objFacilityRating().Aplwithallrecscomplete(),
        //    format: "c0",
        //    decimals: 0
        //}).data("kendoNumericTextBox");
        //Aplwithallrecscomplete.wrapper
        //        .find(".k-numeric-wrap").addClass("expand-padding summaryAPLInputs").css("height", "13px").find(".k-select").hide();
        var Aplfactorwithallrecscomplete = $("#Aplfactorwithallrecscomplete").kendoNumericTextBox({
            value: view.objFacilityRating().Aplfactorwithallrecscomplete(),
            format: "n1",
            decimals: 4
        }).data("kendoNumericTextBox");
        Aplfactorwithallrecscomplete.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding summaryAPLInputs").css("height", "13px").find(".k-select").hide();

        //// SUMMARY NUMERIC TEXT BOXES
        var Totalscore = $("#Totalscore").kendoNumericTextBox({
            value: view.objFacilityRating().Totalscore(),
            format: "n1",
            decimals: 4
        }).data("kendoNumericTextBox");
        Totalscore.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding summaryInputs").css("height", "13px").find(".k-select").hide();
        var Overallscorewithrecscomplete = $("#Overallscorewithrecscomplete").kendoNumericTextBox({
            value: view.objFacilityRating().Overallscorewithrecscomplete(),
            format: "n1",
            decimals: 4
        }).data("kendoNumericTextBox");
        Overallscorewithrecscomplete.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding summaryInputs").css("height", "13px").find(".k-select").hide();
        var Maxpossiblescore = $("#Maxpossiblescore").kendoNumericTextBox({
            value: view.objFacilityRating().Maxpossiblescore(),
            format: "n1",
            decimals: 4
        }).data("kendoNumericTextBox");
        Maxpossiblescore.wrapper
                .find(".k-numeric-wrap").addClass("expand-padding summaryInputs").css("height", "13px").find(".k-select").hide();

        //// WHEN ALL DONE CALL THE RESET TO SYNC THE FIND AND THE PICKERS

        $('#tabStrip').kendoTabStrip({
            open: { effects: "expand:vertical fadeIn", duration: 333 }
        });

        $("#tabLocDetailsLoading").hide(function () {
            $("#tabLocDetailsContainerInside").show();
        });
        var tabLocDetails = $("#tabStrip").data('kendoTabStrip');
        tabLocDetails.select(0);

        view.setupFindFields();
        view.resetPickers();
    });
</script>

</asp:Content>
