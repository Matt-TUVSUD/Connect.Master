<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="tab_facilityrating.aspx.vb" Inherits="GRC.Connect.Web.tab_facilityrating_fire" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/pages/facilityrating.css" />
    <script src="../../Lib_{{VER}}/Generated/ViewCCFireFacilityRating.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCLocationListingFire.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCFireFacilityRating.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCLocationListingFire.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="headerFindCriteria" id="viewFindCriteria_FacilityRating" data-bind="with: viewFindCriteria_FacilityRating">
        <label data-bind="text: $parent.findCriteria" id="findCriteria"></label>&nbsp;
    </div>
    <div id="view_FacilityRating" data-bind="with: view_FacilityRating">
        <!-- TABLE FOR COMPANY / ADDRESS INFORMATION -->
        <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
        <div class="tableDiv">
            <div class="tabRow">
                <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblGRCLocNo, css: { findOn: $parent.objFind().findFileNo, findOff: !$parent.objFind().findFileNo }">GRC Loc. No.</label></span>
                <span class="companyInputs1"><input data-bind="value: $parent.objListing().FileNo, css: { findOnInput: $parent.objFind().findFileNo, findOffInput: !$parent.objFind().findFileNo }" id="FileNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="1" /></span>
                <span class="companyLabels2"><label data-bind="text: $parent.objLanguageLabels().lblClientLocNo, css: { findOn: $parent.objFind().findClientLocNo, findOff: !$parent.objFind().findClientLocNo }">Client Loc. No.</label></span>
                <span class="companyInputs2"><input data-bind="value: $parent.objListing().ClientLocNo, css: { findOnInput: $parent.objFind().findClientLocNo, findOffInput: !$parent.objFind().findClientLocNo }" id="ClientLocNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs2" tabindex="2" /></span>
                <span class="companyLabels5"><label data-bind="text: $parent.objLanguageLabels().lblLatitude, css: { findOn: $parent.objFind().findLatitude, findOff: !$parent.objFind().findLatitude }">Latitude</label></span>
                <span class="companyInputs4"><input data-bind="value: $parent.objListing().Latitude, css: { findOnInput: $parent.objFind().findLatitude, findOffInput: !$parent.objFind().findLatitude }" id="Latitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="3"  /></span>
                <span class="companyLabels4"><label data-bind="text: $parent.objLanguageLabels().lblLongitude, css: { findOn: $parent.objFind().findLongitude, findOff: !$parent.objFind().findLongitude }">Longitude</label></span>
                <span class="companyInputs4"><input data-bind="value: $parent.objListing().Longitude, css: { findOnInput: $parent.objFind().findLongitude, findOffInput: !$parent.objFind().findLongitude }" id="Longitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="4"  /></span>
            </div>
            <div class="tabRow">
                <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblAddress1, css: { findOn: $parent.objFind().findAddress1, findOff: !$parent.objFind().findAddress1 }">Address</label></span>
                <span class="companyInputs6"><input data-bind="value: $parent.objListing().Address1, css: { findOnInput: $parent.objFind().findAddress1, findOffInput: !$parent.objFind().findAddress1 }" id="Address1" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs6" tabindex="5"  /></span>
                <span class="companyLabels3"><label data-bind="text: $parent.objLanguageLabels().lblDivisionName, css: { findOn: $parent.objFind().findDivision, findOff: !$parent.objFind().findDivision }">Division Name</label></span>
                <span class="companyInputs5"><input data-bind="value: $parent.objListing().Division, css: { findOnInput: $parent.objFind().findDivision, findOffInput: !$parent.objFind().findDivision }" id="Division" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="6"  /></span>
            </div>
            <div class="tabRow">
                <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblCity, css: { findOn: $parent.objFind().findCity, findOff: !$parent.objFind().findCity }">City</label></span>
                <span class="companyInputs1"><input data-bind="value: $parent.objListing().City, css: { findOnInput: $parent.objFind().findCity, findOffInput: !$parent.objFind().findCity }" id="City" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="7"  /></span>
                <span class="stateLabels"><label data-bind="text: $parent.objLanguageLabels().lblState, css: { findOn: $parent.objFind().findStProv, findOff: !$parent.objFind().findStProv }">State</label></span>
                <span class="stateInputs"><input data-bind="value: $parent.objListing().StProv, css: { findOnInput: $parent.objFind().findStProv, findOffInput: !$parent.objFind().findStProv }" id="StProv" class="k-autocomplete k-input inputNoEdit inputLeft stateInputs" tabindex="8"  /></span>
                <span class="countryLabels"><label data-bind="text: $parent.objLanguageLabels().lblCountry, css: { findOn: $parent.objFind().findCountry, findOff: !$parent.objFind().findCountry }">Country</label></span>
                <span class="countryInputs"><input data-bind="value: $parent.objListing().Country, css: { findOnInput: $parent.objFind().findCountry, findOffInput: !$parent.objFind().findCountry }" id="Country" class="k-autocomplete k-input inputNoEdit inputLeft countryInputs" tabindex="9"  /></span>
                <span class="postalLabels"><label data-bind="text: $parent.objLanguageLabels().lblPostalCode, css: { findOn: $parent.objFind().findZip, findOff: !$parent.objFind().findZip }">Postal</label></span>
                <span class="postalInputs"><input data-bind="value: $parent.objListing().Zip, css: { findOnInput: $parent.objFind().findZip, findOffInput: !$parent.objFind().findZip }" id="Zip" class="k-autocomplete k-input inputNoEdit inputLeft postalInputs" tabindex="10"  /></span>
                <span class="companyLabels3"><label data-bind="text: $parent.objLanguageLabels().lblFacilityName, css: { findOn: $parent.objFind().findFacility, findOff: !$parent.objFind().findFacility }">Facility Name</label></span>
                <span class="companyInputs5"><input data-bind="value: $parent.objListing().Facility, css: { findOnInput: $parent.objFind().findFacility, findOffInput: !$parent.objFind().findFacility }" id="Facility" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="11"  /></span>
            </div>
            <div class="tabRow">
                <!-- BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
                <span class="companyLabels1"></span>
                <span class="buttonContainerLocationLoading" style="display:flex;">
                    <span><button data-bind="click: $parent.onFileFirst, enable: $parent.enableFilePrev" type="button" class="grcBlueBtn pagerBtn" id="btnFileFirst" tabindex="15" style="margin-right:2px;"><i class="fas fa-step-backward"></i></button></span>
                    <span><button data-bind="click: $parent.onFilePrevious, enable: $parent.enableFilePrev" type="button" class="grcBlueBtn pagerBtn" id="btnFilePrevious" tabindex="16"><i class="fas fa-caret-left"></i></button></span>
                    <span class="buttonFileRecordLabel" style="width: 130px;">&nbsp;<label data-bind="text: $parent.objLanguageLabels().lblFileRecord">Location</label> <input data-bind="    value: $parent.txtFileRecordNumber" id="txtFileRecordNumber" class="k-autocomplete k-input inputCenter inputNoEdit buttonInput" style="width: 80px; margin-bottom: 3px;" readonly="true" />&nbsp;</span>
                    <span><button data-bind="click: $parent.onFileNext, enable: $parent.enableFileNext" type="button" class="grcBlueBtn pagerBtn" id="btnFileNext" tabindex="17" style="margin-right:2px;"><i class="fas fa-caret-right"></i></button></span>
                    <span><button data-bind="click: $parent.onFileLast, enable: $parent.enableFileNext" type="button" class="grcBlueBtn pagerBtn" id="btnFileLast" tabindex="18"><i class="fas fa-step-forward"></i></button></span>
                    <span>&nbsp;</span>
                    <span><button data-bind="click: $parent.onFindClear, css: { hidden: $parent.findEngaged }" type="button" class="k-button buttonFindClearShape hidden" tabindex="13">Clear Find</button></span>
                    <span><button data-bind="click: $parent.onFind" class="grcBlueBtn findBtn" type="submit" tabindex="14">Find</button></span>
                </span>
                <!-- END BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
                <span class="companyLabels6"><label data-bind="text: $parent.objLanguageLabels().lblCustomerAccess, css: { findOn: $parent.objFind().findCustomAccess, findOff: !$parent.objFind().findCustomAccess }">Custom Access</label></span>
                <span class="companyInputs5"><input data-bind="value: $parent.objListing().CustomAccess, css: { findOnInput: $parent.objFind().findCustomAccess, findOffInput: !$parent.objFind().findCustomAccess }" id="CustomAccess" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="12"  /></span>
            </div>
        </div>
        <!-- END TABLE FOR COMPANY / ADDRESS INFORMATION -->

        <!-- TABLE FOR PASSIVE SCORE INFORMATION -->
        <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
        <div>
            <div class="tabBannerHeader" style="font-size:12px;">
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
        <div class="tableDivAutoBorders" style="padding:10px 0;">
        <div class="tableDiv">
            <%--<div style="height:24px;">
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
            </div>--%>
            <div class="tabRow">
                <span class="bufferLeft passiveLabels"><label data-bind="text: $parent.objLanguageLabels().lblWeight">Weight</label></span>
                <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().Floodweight" id="Floodweight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().Earthquakeweight" id="Earthquakeweight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().Windstormweight" id="Windstormweight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().Constructionweight" id="Constructionweight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().Occupancyweight" id="Occupancyweight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().Otherweight" id="Otherweight" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                <span class="borderRight"></span>
                <span class="passiveTotalLabels" style="padding-left: 23px; width: 100px;">
                    <input data-bind="" id="Inspectiondate" class="k-numerictextbox inputCenter inputNoEdit inspectionDateInput" readonly="readonly" />
                </span>
                <span class="borderRight"></span>
            </div>
            <div class="tabRow">
                <span class="bufferLeft passiveLabels"><label data-bind="text: $parent.objLanguageLabels().lblRating">Rating</label></span>
                <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().Floodrating" id="Floodrating" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().Earthquakerating" id="Earthquakerating" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().Windstormrating" id="Windstormrating" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().Constructionrating" id="Constructionrating" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().Occupancyrating" id="Occupancyrating" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                <span class="passiveInputs"><input data-bind="value: $parent.objFacilityRating().Otherrating" id="Otherrating" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                <span class="borderRight"></span>
                <span class="buttonCell">
                    <div class="buttonContainer" style="display:flex;">
                        <span><button data-bind="click: $parent.onPrevious, enable: $parent.enablePrev" class="grcBlueBtn pagerBtn" id="btnPrevious" style="margin-right:2px;"><i class="fas fa-caret-left"></i></button></span>
                        <span><button data-bind="click: $parent.onNext, enable: $parent.enableNext" class="grcBlueBtn pagerBtn" id="btnNext"><i class="fas fa-caret-right"></i></button></span>
                        <span class="buttonRecordLabel"><label data-bind="text: $parent.txtRecordNumber"></label></span>
                    </div>
                </span>
                <span class="borderRight"></span>
            </div>
            <div class="tabRow">
                <span class="bufferLeft passiveDescriptionLabels" style="height: 46px;"><label data-bind="text: $parent.objLanguageLabels().lblDescription">Description</label></span>
                <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().Flooddescription, attr: { title: $parent.objFacilityRating().Flooddescription }" id="Flooddescription" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().Earthquakedescription, attr: { title: $parent.objFacilityRating().Earthquakedescription }" id="Earthquakedescription" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().Windstormdescription, attr: { title: $parent.objFacilityRating().Windstormdescription }" id="Windstormdescription" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().Constructiondescription, attr: { title: $parent.objFacilityRating().Constructiondescription }" id="Constructiondescription" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().Occupancydescription, attr: { title: $parent.objFacilityRating().Occupancydescription }" id="Occupancydescription" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                <span class="passiveDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().Otherdescription, attr: { title: $parent.objFacilityRating().Otherdescription }" id="Otherdescription" class="k-textbox inputNoEdit passiveDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                <span class="borderRight" style="height: 46px;"></span>
                <span class="passiveTotalLabels" style="height: 46px;">
                    <div>&nbsp;<label data-bind="text: $parent.objLanguageLabels().lblTotalPassiveScore">Total Passive Score</label></div>
                    <div ><input data-bind="value: $parent.objFacilityRating().Passivescore" id="Passivescore" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></div>
                </span>
                <span class="borderRightSmall" style="height: 46px;"></span>
        </div>
        <!-- END TABLE FOR PASSIVE SCORE INFORMATION -->
        </div>

        <div style="height: 5px;">&nbsp;</div>

        <!-- TABLE FOR ACTIVE SCORE INFORMATION -->
        <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
        <div>
            <div class="tabBannerHeader" style="font-size:12px;">
                <label>&nbsp;</label>
                <label style="flex-basis:105px;">Active Score:</label>
                <label style="flex-basis:120px;">Protection</label>
                <label style="flex-basis:125px;">Human Element</label>
                <label>Nat'l Hazard Protection</label>
                <label>Bus. Cont. Planning</label>
                <label style="flex-basis:150px">&nbsp;</label>
            </div>
        </div>
        <div class="tableDivAutoBorders" style="padding:10px 0;">
            <div class="tableDiv">
                <div class="tabRow">
                    <span class="bufferLeft activeLabels"><label data-bind="text: $parent.objLanguageLabels().lblWeight">Weight</label></span>
                    <span class="activeInputs"><input data-bind="value: $parent.objFacilityRating().Physicalprotectionweight" id="Physicalprotectionweight" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                    <span class="activeInputs"><input data-bind="value: $parent.objFacilityRating().Humanelementweight" id="Humanelementweight" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                    <span class="activeInputs"><input data-bind="value: $parent.objFacilityRating().Naturalhazardsprotectionweight" id="Naturalhazardsprotectionweight" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                    <span class="activeInputs"><input data-bind="value: $parent.objFacilityRating().Businesscontinuityweight" id="Businesscontinuityweight" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                    <span class="borderRight"></span>
                    <span class="activeTotalLabels"><div style="font-size: 6px;">&nbsp;<br /></div><label data-bind="text: $parent.objLanguageLabels().lblTotalActiveScore" style="margin-top: 15px;">Total Active Score</label></span>
                    <span class="borderRightSmall"></span>
                </div>
                <div class="tabRow">
                    <span class="bufferLeft activeLabels"><label data-bind="text: $parent.objLanguageLabels().lblRating">Rating</label></span>
                    <span class="activeInputs"><input data-bind="value: $parent.objFacilityRating().Physicalprotectionrating" id="Physicalprotectionrating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                    <span class="activeInputs"><input data-bind="value: $parent.objFacilityRating().Humanelementrating" id="Humanelementrating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                    <span class="activeInputs"><input data-bind="value: $parent.objFacilityRating().Naturalhazardsprotectionrating" id="Naturalhazardsprotectionrating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                    <span class="activeInputs"><input data-bind="value: $parent.objFacilityRating().Businesscontinuityrating" id="Businesscontinuityrating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                    <span class="borderRight"></span>
                    <span class="activeTotalInputsCell"><input data-bind="value: $parent.objFacilityRating().Activescore" id="Activescore" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="borderRightSmall"></span>
                </div>
                <div class="tabRow">
                    <span class="bufferLeft activeDescriptionLabels" style="height: 46px;"><label data-bind="text: $parent.objLanguageLabels().lblDescription">Description</label></span>
                    <span class="activeDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().Firedescription, attr: { title: $parent.objFacilityRating().Firedescription }" id="Firedescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="activeDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().Humandescription, attr: { title: $parent.objFacilityRating().Humandescription }" id="Humandescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="activeDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().Naturaldescription, attr: { title: $parent.objFacilityRating().Naturaldescription }" id="Naturaldescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="activeDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().Businessdescription, attr: { title: $parent.objFacilityRating().Businessdescription }" id="Businessdescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="borderRight" style="height: 46px;"></span>
                    <span class="activeTotalLabels fix" style="height: 46px;">
                        <div style="font-size: 6px;">&nbsp;<br />&nbsp;<br />&nbsp;<br /></div>
                        <label data-bind="text: $parent.objLanguageLabels().lblTotalActiveScoreRecsCompleted">Total Active Score with Recs Completed</label>
                    </span>
                    <span class="borderRightSmall" style="height: 46px;"></span>
                </div>
                <div class="tabRow">
                    <span class="bufferLeft activeLabelsLong" style="line-height: normal !important;"><label data-bind="text: $parent.objLanguageLabels().lblRatingAllRecsCompleted">Rating with All Recs Completed</label></span>
                    <span class="activeInputs"><input data-bind="value: $parent.objFacilityRating().Fireprotectionallrecscompleterating" id="Fireprotectionallrecscompleterating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                    <span class="activeInputs"><input data-bind="value: $parent.objFacilityRating().Humanelementallrecscompleterating" id="Humanelementallrecscompleterating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                    <span class="activeInputs"><input data-bind="value: $parent.objFacilityRating().Nathazprotallrecscompleterating" id="Nathazprotallrecscompleterating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                    <span class="activeInputs"><input data-bind="value: $parent.objFacilityRating().Bcpallrecscompletrating" id="Bcpallrecscompletrating" class="k-numerictextbox inputCenter inputNoEdit activeInputs" readonly="readonly" /></span>
                    <span class="borderRight"></span>
                    <span class="activeTotalInputsCell"><input data-bind="value: $parent.objFacilityRating().Activescorewithrecscomplete" id="Activescorewithrecscomplete" class="k-numerictextbox inputCenter inputNoEdit passiveInputs" readonly="readonly" /></span>
                    <span class="borderRightSmall"></span>
                </div>
                <div class="tabRow">
                    <span class="bufferLeft activeLabels" style="height: 46px;"><label data-bind="text: $parent.objLanguageLabels().lblDescription" style="line-height: 35px;">Description</label></span>
                    <span class="activeDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().Firerecdescription, attr: { title: $parent.objFacilityRating().Firerecdescription }" id="Firerecdescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="activeDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().Humanrecdescription, attr: { title: $parent.objFacilityRating().Humanrecdescription }" id="Humanrecdescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="activeDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().Naturalrecdescription, attr: { title: $parent.objFacilityRating().Naturalrecdescription }" id="Naturalrecdescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="activeDescriptionInputs" style="height: 46px;"><textarea data-bind="value: $parent.objFacilityRating().Businessrecdescription, attr: { title: $parent.objFacilityRating().Businessrecdescription }" id="Businessrecdescription" class="k-textbox inputNoEdit activeDescriptionInputsTextBox" rows="10" cols="10" readonly="readonly" ></textarea></span>
                    <span class="borderRight" style="height: 46px;"></span>
                    <span class="activeTotalLabels" style="height: 46px;"></span>
                    <span class="borderRightSmall" style="height: 46px;"></span>
                </div>
            </div>
        <!-- END TABLE FOR ACTIVE SCORE INFORMATION -->
        </div>

        <div  style="display:flex;">    
            <!-- ************************* -->
            <!-- TABLE FOR APL INFORMATION -->
            <div data-bind="visible: $parent.showAPL() && $parent.clientFeatures().search('U') < 0" class="tableDiv" style="display:flex; width:auto; flex-basis:265px; flex-direction:column; justify-content:center; align-items:flex-end; text-align:right;">
                <div>
                    <span class="summaryAPLLabels"><label data-bind="text: $parent.objLanguageLabels().lblAPLPDBI">APL (PD + BI)</label></span>
                    <span class="summaryAPLInputs"><input data-bind="value: $parent.objFacilityRating().APLString" id="Apl" class="k-textbox inputCenter inputNoEdit summaryAPLInputs" readonly="readonly" /></span>
                </div>
                <div>
                    <span class="summaryAPLLabels"><label data-bind="text: $parent.objLanguageLabels().lblAplfactor">APL Factor</label></span>
                    <span class="summaryAPLInputs"><input data-bind="value: $parent.objFacilityRating().Aplfactor" id="Aplfactor" class="k-numerictextbox k-input inputCenter inputNoEdit summaryAPLInputs" readonly="readonly" /></span>
                </div>
                <div>
                    <span class="summaryAPLLabels"><label data-bind="text: $parent.objLanguageLabels().lblAPLAllRecsComplete">APL with All Recs Completed</label></span>
                    <span class="summaryAPLInputs"><input data-bind="value: $parent.objFacilityRating().APLWITHALLRECSCOMPLETEString" id="Aplwithallrecscomplete" class="k-textbox inputCenter inputNoEdit summaryAPLInputs" readonly="readonly" /></span>
                </div>
                <div>
                    <span class="summaryAPLLabels"><label data-bind="text: $parent.objLanguageLabels().lblAplfactorAllRecsComplete">APL Factor with All Recs Completed</label></span>
                    <span class="summaryAPLInputs"><input data-bind="value: $parent.objFacilityRating().Aplfactorwithallrecscomplete" id="Aplfactorwithallrecscomplete" class="k-numerictextbox inputCenter inputNoEdit summaryAPLInputs" readonly="readonly" /></span>
                </div>
            </div>
            <div data-bind="visible: !$parent.showAPL()" style="display:flex; width:auto; flex-basis:265px; flex-direction:column; justify-content:center; align-items:flex-end; text-align:right;">&nbsp</div>
            <!-- END TABLE FOR APL INFORMATION -->
            <!-- TABLE FOR APL FACTOR KEY -->
            <div data-bind="visible: $parent.showAPL() && $parent.clientFeatures().search('U') < 0" class="tableDiv containerAPLFactorKey" style="">
                <div>
                    <span class="borderTop borderLeft factorKeyLabel" style="height: 10px; text-align: center;"><b><label data-bind="text: $parent.objLanguageLabels().lblAplfactorKey">APL Factor Key</label></b></span>
                    <span class="borderTop borderRight" style="height: 10px; width: 1px;"></span>
                </div>
                <div>
                    <span class="borderLeft factorKeyLabel" style="height: 10px;">&nbsp;&nbsp;If APL &lt; <label data-bind="text: $parent.objFacilityRating().APLKeyRange1"></label> &nbsp;&nbsp;APL F = <label data-bind="    text: $parent.objFacilityRating().APLKeyFactor1"></label></span>
                    <span class="borderRight" style="height: 10px; width: 1px;"></span>
                </div>
                <div>
                    <span class="borderLeft factorKeyLabel" style="height: 10px;">&nbsp;&nbsp;If APL &lt; <label data-bind="text: $parent.objFacilityRating().APLKeyRange2"></label> &nbsp;&nbsp;APL F = <label data-bind="    text: $parent.objFacilityRating().APLKeyFactor2"></label></span>
                    <span class="borderRight" style="height: 10px; width: 1px;"></span>
                </div>
                <div>
                    <span class="borderLeft factorKeyLabel" style="height: 10px;">&nbsp;&nbsp;If APL &lt; <label data-bind="text: $parent.objFacilityRating().APLKeyRange3"></label> APL F = <label data-bind="    text: $parent.objFacilityRating().APLKeyFactor3"></label></span>
                    <span class="borderRight" style="height: 10px; width: 1px;"></span>
                </div>
                <div>
                    <span class="borderBottom borderLeft factorKeyLabel" style="height: 10px; padding-bottom: 10px;">&nbsp;&nbsp;If APL &gt; <label data-bind="text: $parent.objFacilityRating().APLKeyRange4"></label> APL F = <label data-bind="    text: $parent.objFacilityRating().APLKeyFactor4"></label></span>
                    <span class="borderBottom borderRight" style="height: 10px; padding-bottom: 10px; width: 1px;"></span>
                </div>
            </div>
            <div data-bind="visible: !$parent.showAPL()" style="width:145px;">&nbsp</div>
            <!-- END TABLE FOR APL FACTOR KEY -->

            <div class="" style="display:flex; width:400px;">
            
            <!-- TABLE FOR SUMMARY INFORMATION -->
            <div class="tableDiv containerSummary" data-bind="visible: $parent.clientFeatures().search('U') < 0" style="">
                <div>
                    <span class="summaryLabels"><label data-bind="text: $parent.objLanguageLabels().lblTotalFacilityScore">Total Facility Score</label></span>
                    <span class="summaryInputs"><input data-bind="value: $parent.objFacilityRating().Totalscore" id="Totalscore" class="k-numerictextbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                </div>
                <div>
                    <span class="summaryLabels"><label data-bind="text: $parent.objLanguageLabels().lblOverallRatings">Overall Rating</label></span>
                    <span class="summaryInputs"><input data-bind="value: $parent.objFacilityRating().Overallplantratingdescription" id="Overallplantratingrating" class="k-textbox inputCenter inputNoEdit summaryTextInputs" readonly="readonly" /></span>
                </div>
                <div>
                    <span class="summaryLabels"><label data-bind="text: $parent.objLanguageLabels().lblOverallScoreRecsComplete">Overall Score with Recs Compl.</label></span>
                    <span class="summaryInputs"><input data-bind="value: $parent.objFacilityRating().Overallscorewithrecscomplete" id="Overallscorewithrecscomplete" class="k-numerictextbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                </div>
                <div>
                    <span class="summaryLabels"><label data-bind="text: $parent.objLanguageLabels().lblMaxPossibleScore">Max Possible Score</label></span>
                    <span class="summaryInputs"><input data-bind="value: $parent.objFacilityRating().Maxpossiblescore" id="Maxpossiblescore" class="k-numerictextbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                </div>
                <div>
                    <span class="summaryLabels"><label data-bind="text: $parent.objLanguageLabels().lblMaxpossiblerating">Max Possible Rating</label></span>
                    <span class="summaryInputsSmallFonts"><input data-bind="value: $parent.objFacilityRating().Maxpossiblescoredescription" id="Maxpossiblerating" class="k-textbox inputCenter inputNoEdit summaryTextInputs" readonly="readonly" /></span>
                </div>
            </div>
            <!-- END TABLE FOR SUMMARY INFORMATION -->
            
            <!-- ******************** -->
            <!-- TABLE FOR RATING KEY -->
            <div class="tableDiv containerRatingKey" style="">
                <div>
                    <span class="borderTop borderLeft ratingKeyBuffer"></span>
                    <span class="borderTop ratingKeyContent"><label data-bind="text: $parent.objLanguageLabels().lblRatingKey">Rating Key</label></span>
                    <span class="borderTop borderRight ratingKeyBuffer"></span>
                </div>
                <div>
                    <span class="borderLeft ratingKeyBufferContent" style="height: 80px;"></span>
                    <span class="ratingKeyContent">
              
                        <div class="ratingColorTable">
                            <div class="ratingKeyCell" id="RatingKeyColor1"  style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription1" ><label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription1"></label></div>         
                            <div class="ratingKeyCell" id="RatingKeyColor2"  style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription2" ><label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription2"></label></div>
                            <div class="ratingKeyCell" id="RatingKeyColor3"  style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription3" ><label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription3"></label></div>            
                            <div class="ratingKeyCell" id="RatingKeyColor4"  style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription4" ><label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription4"></label></div>
                            <div class="ratingKeyCell" id="RatingKeyColor5"  style="border-top: 1px solid #555555;" data-bind="visible: $parent.objFacilityRating().RatingKeyDescription5" ><label data-bind="    text: $parent.objFacilityRating().RatingKeyDescription5"></label></div>
                        </div>
                    </span>
                    <span class="borderRight ratingKeyBufferContent" style="height: 80px; width: 4px;"></span>
                </div>
                <div>
                    <span class="borderBottom borderLeft ratingKeyBuffer" style="height: 12px;"></span>
                    <span class="borderBottom ratingKeyContent" style="height: 12px;"></span>
                    <span class="borderBottom borderRight ratingKeyBuffer" style="height: 12px;"></span>
                </div>
            </div>
            <!-- END TABLE FOR RATING KEY -->
            <!-- ***************************** -->

            <!-- ***************************** -->
            <!-- TABLE FOR MAGNA SUMMARY INFORMATION -->
            <div class="tableDiv containerSummary" data-bind="visible: $parent.clientFeatures().search('U') > -1" style=""> 
                <div>
                    <span class="summaryLabels"><label data-bind="text: $parent.objLanguageLabels().lblTotalFacilityScore">Total Facility Score</label></span>
                    <span class="summaryInputs"><input data-bind="value: $parent.objFacilityRating().Totalscore" id="T_FacilityScore" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                </div>
                <div>
                    <span class="summaryLabels"><label data-bind="text: $parent.objLanguageLabels().lblOverallRatings">Overall Rating</label></span>
                    <span class="summaryInputsSmallFonts"><input data-bind="value: $parent.objFacilityRating().Overallplantratingdescription" id="OverallRatingValue" class="k-textbox inputCenter inputNoEdit summaryTextInputs" readonly="readonly" value="Poorer Risk < 50" /></span>
                </div>
                <div>
                    <span class="summaryLabels"><label data-bind="text: $parent.objLanguageLabels().lblOverallScoreRecsComplete">Overall Score with Recs Compl.</label></span>
                    <span class="summaryInputs"><input data-bind="value: $parent.objFacilityRating().Overallscorewithrecscomplete" id="OverallCompleteScore" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" value=""/></span>
                </div>
                <div>
                    <span class="summaryLabels"><label data-bind="">Overall Rating with Recs Compl.</label></span>
                    <span class="summaryInputs"><input data-bind="value: $parent.objFacilityRating().OverallScoreWithRecsCompleteRating" id="OverallRatingWRecsCompl" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly"  value=""/></span>
                </div>
                <div>
                    <span class="summaryLabels"><label data-bind="">Achievable Rating %</label></span>
                    <span class="summaryInputsSmallFonts"><input data-bind="value: $parent.objFacilityRating().AchievableScorePercentString" id="RatingPotentialPercent" class="k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" value="" /></span>
                </div>
                <div>
                    <span class="summaryLabels"><label data-bind="text: $parent.objLanguageLabels().lblAPLPDBI">APL (PD + BI)</label></span>
                    <span class="summaryInputs"><input data-bind="value: $parent.objFacilityRating().APLString" id="Text1" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                </div>
                <div>
                    <span class="summaryLabels"><label data-bind="text: $parent.objLanguageLabels().lblAPLAllRecsComplete">APL with All Recs Completed</label></span>
                    <span class="summaryInputs"><input data-bind="value: $parent.objFacilityRating().APLWITHALLRECSCOMPLETEString" id="Text2" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" /></span>
                </div>
            </div>
            <!-- END TABLE FOR MAGNA SUMMARY INFORMATION -->
            
        </div>

        </div>
        <div data-bind="visible: $parent.clientFeatures().search('U') > -1 " style="display:flex;">
            <!-- ************************* -->
            <!-- TABLE FOR ACHIEVABLE AVERAGE INFORMATION -->
            <div class="containerAPLHeaders">
                <div class="floatLeft summaryAPLLabels" style="width:235px;">&nbsp;</div>
                <div class="floatLeft centerAlign bold" style="width:82px; margin-right:11px;">Rating<br /><span style="display:block; float:left; width:35px;" title="average">AVG</span><span style="display:block; float:left; width:10px;">&nbsp;/&nbsp;</span><span style="display:block; float:left; width:35px;" title="weighted average">WAVG</span></div>
                <div class="floatLeft centerAlign bold" style="width:85px;">Achievable<br /><span style="display:block; float:left; width:35px;" title="average">AVG</span><span style="display:block; float:left; width:10px;">&nbsp;/&nbsp;</span><span style="display:block; float:left; width:35px;" title="weighted average">WAVG</span></div>
            </div>
            <div data-bind="visible: $parent.isMagna()" style="width:270px; margin:5px 0 5px 155px; font-size:10px; ">
                <label style="white-space:normal;">
                    (The weighted average (WAVG) is calculated using the TIV.)
                </label>
            </div>
            <div class="tableDiv containerAPL" style="width:auto; margin-left:55px;" data-bind="foreach: $parent.colAverageWeightedAverage()">
                <div data-bind="visible: IsVisible">
                    <span class="summaryLabels" style="width:180px; height:15px; line-height:18px;"><label data-bind="text: Label" class="inputCenter inputNoEdit summaryAPLInputs"></label></span>
                    <span class="summaryInputs" style="margin-right:2px; width:40px;"><label data-bind="text: Value1" id="" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" style="display:block; width:100%;" ></label></span>
                    <span class="summaryInputs" style="margin-right:10px; width:40px;"><label data-bind="text: Value2" id="Label4" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" style="display:block; width:100%;" ></label></span>
                    <span class="summaryInputs" style="margin-right:2px; width:40px;"><label data-bind="text: Value3 ? Value3 : '&nbsp;'" id="Label5" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" readonly="readonly" style="display:block; width:100%;" ></label></span>
                    <span class="summaryInputs" style="margin-right:0px; width:40px;"><label data-bind="text: Value4 ? Value4 : '&nbsp;'" id="Label3" class="k-numerictextbox k-textbox inputCenter inputNoEdit summaryInputs" style="display:block; width:100%;"></label></span>
                </div>
            </div>
            <!-- END TABLE FOR ACHIEVABLE AVERAGE INFORMATION -->
            <!-- TABLE FOR APL FACTOR KEY -->
        </div>
        

        <!-- NOTES -->
        <div data-bind="visible: $parent.showAPL() && $parent.clientFeatures().search('U') < 0" class="aplNote">
            <label style="white-space:normal;" data-bind="text: $parent.objLanguageLabels().lblAPLNote">(The total facility score is the sum of all Passive and Active scores multiplied by the APL Factor.  The lower the facility's APL the greater the APL Factor.)</label>
        </div>
        <div data-bind="visible: !$parent.showAPL()" class="aplNote">
            <label style="white-space:normal;">(The total facility score is the sum of all Passive and Active scores.)</label>
        </div>
        

        <!-- AREA FOR ERROR AND NOTICE MESSAGES -->
        <div style="text-align: center;"><label class="messageError" data-bind="text: $parent.messageError"></label><label class="messageNotice" data-bind="    text: $parent.messageNotice"></label><label class="messageWarning" data-bind="    text: $parent.messageWarning"></label>&nbsp;</div>

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
            // LOAD SESSION VARIABLES
            var dsLanguageLabels = {
                // COMPANY INFORMATION
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

                // PASSIVE
                lblWeight: "Weight",
                lblRating: "Rating",
                lblDescription: "Description",
                lblTotalPassiveScore: "Total Passive Score",

                // ACTIVE
                lblRatingAllRecsCompleted: "Rating with All Recs Completed",
                lblTotalActiveScore: "Total Active Score",
                lblTotalActiveScoreRecsCompleted: "Total Active Score with Recs Completed",

                // APL
                lblAPLPDBI: "APL (PD + BI)",
                lblAplfactor: "APL Factor",
                lblAPLAllRecsComplete: "APL with All Recs Completed",
                lblAplfactorAllRecsComplete: "APL Factor with All Recs Completed",
                lblAplfactorKey: "APL Factor Key",

                // SUMMARY
                lblTotalFacilityScore: "Total Facility Score",
                lblOverallRatings: "Overall Rating",
                lblOverallScoreRecsComplete: "Overall Score with Recs Compl.",
                lblMaxPossibleScore: "Max Possible Score",
                lblMaxpossiblerating: "Max Possible Rating",
                lblAPLNote: "(The total facility score is the sum of all Passive and Active scores multiplied by the APL Factor.  The lower the facility's APL the greater the APL Factor.)",

                // RATING KEY
                lblRatingKey: "Rating Key",

                // MISC
                lblInspectiondate: "Inspection Date",
                lblRecord: "Record",
                lblFileRecord: "Location",
                lblOf: "of",
                lblNoLocationFoundTitle: "No Facility Rating Found",
                lblNoLocationFoundMessage: "Warning: There was no Facility Rating record found for this location.",
                lblNoLocationFoundDescription: "Click the below button to go back to the Location Details page, or use the Location Navigation buttons to go to another location record.",
                lblGoBackToDetails: "Go Back To Location Details",
                lblNoActiveLocations: "This location is not active for this Practice.",
                lblSearchNotFound: "This location is not active for Fire.  Choose a different service."
            };


            // KEYBOARD EVENT HANDLES
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


            // VIEWMODEL
            var viewFindCriteria_FacilityRating = {
                findCriteria: ko.observable()
            };
            var view_FacilityRating = {
                // DECLARATIONS
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
                pageRequestedFrom: getQueryVariable("req"),
                colAverageWeightedAverage: ko.observableArray(),

                // COLLECTIONS / OBJECTS
                // CHANGE THE NAME OF THE ES.OBJECTS PROTOTYPE
                gSafeGuid: getGSafeGUID(), //getQueryVariable('sid'),
                clientFeatures: ko.observable(),
                isMagna: ko.observable(false),
                showAPL: ko.observable(true),
                collFacilityRating: new es.objects.ViewCCFireFacilityRatingCollection(),
                collListing: new es.objects.ViewCCLocationListingFireCollection(),
                objFind: ko.observable(),
                objListing: ko.observable(),
                objFacilityRating: ko.observable(),
                objLanguageLabels: ko.observable(dsLanguageLabels),

                // MISC
                txtRecordNumber: ko.observable(),
                txtFileRecordNumber: ko.observable(),
                txtSchedulingComments: ko.observable(),
                colorTotalscore: ko.observable(),
                colorMaxpossible: ko.observable(),
                loading: ko.observable(false),

                // BUTTONS FOR RECORD NAVIGATION
                onNext: function () {
                    if (view_FacilityRating.stateOnlyOneDetailRecordLoaded) {
                        view_FacilityRating.loadDetailsOnly();
                    }
                    if (view_FacilityRating.index < view_FacilityRating.collFacilityRating().length - 1) {
                        view_FacilityRating.index++;
                        view_FacilityRating.objFacilityRating(view_FacilityRating.collFacilityRating()[view_FacilityRating.index]);
                    }
                    view_FacilityRating.setupButtons();
                    view_FacilityRating.resetPickers();
                },

                onPrevious: function () {
                    if (view_FacilityRating.index > 0) {
                        view_FacilityRating.index--;
                        view_FacilityRating.objFacilityRating(view_FacilityRating.collFacilityRating()[view_FacilityRating.index]);
                    }
                    view_FacilityRating.setupButtons();
                    view_FacilityRating.resetPickers();
                },

                onFirst: function () {
                    if (view_FacilityRating.index > 0) {
                        view_FacilityRating.index = 0;
                        view_FacilityRating.objFacilityRating(view_FacilityRating.collFacilityRating()[view_FacilityRating.index]);
                    }
                    view_FacilityRating.setupButtons();
                    view_FacilityRating.resetPickers();
                },

                onLast: function () {
                    if (view_FacilityRating.stateOnlyOneDetailRecordLoaded) {
                        view_FacilityRating.loadDetailsOnly();
                    }
                    if (view_FacilityRating.index < view_FacilityRating.collFacilityRating().length - 1) {
                        view_FacilityRating.index = view_FacilityRating.collFacilityRating().length - 1;
                        view_FacilityRating.objFacilityRating(view_FacilityRating.collFacilityRating()[view_FacilityRating.index]);
                    }
                    view_FacilityRating.setupButtons();
                    view_FacilityRating.resetPickers();
                },

                // BUTTONS FOR FILE NUMBER / LOCATION WALK
                onFileFirst: function () {
                    view_FacilityRating.index = 0;
                    view_FacilityRating.fileDirection("first");
                    view_FacilityRating.stateDetailsLoadOneRecord = true;
                    view_FacilityRating.loadOneFileNumber(); //view_FacilityRating.loadFileNumber();
                    view_FacilityRating.fileDirection("");
                    view_FacilityRating.resetPickers();
                },

                onFilePrevious: function () {
                    view_FacilityRating.index = 0;
                    view_FacilityRating.fileDirection("previous");
                    view_FacilityRating.stateDetailsLoadOneRecord = true;
                    view_FacilityRating.loadOneFileNumber(); //view_FacilityRating.loadFileNumber();
                    view_FacilityRating.fileDirection("");
                    view_FacilityRating.resetPickers();
                },

                onFileNext: function () {
                    view_FacilityRating.index = 0;
                    view_FacilityRating.fileDirection("next");
                    view_FacilityRating.stateDetailsLoadOneRecord = true;
                    view_FacilityRating.loadOneFileNumber(); //view_FacilityRating.loadFileNumber();
                    view_FacilityRating.fileDirection("");
                    view_FacilityRating.resetPickers();
                },

                onFileLast: function () {
                    view_FacilityRating.index = 0;
                    view_FacilityRating.fileDirection("last");
                    view_FacilityRating.stateDetailsLoadOneRecord = true;
                    view_FacilityRating.loadOneFileNumber(); //view_FacilityRating.loadFileNumber();
                    view_FacilityRating.fileDirection("");
                    view_FacilityRating.resetPickers();
                },

                // FIND A RECORD FROM THE LOCATION FIELDS
                onFind: function () {
                    // SET THE GSAFE
                    setFindLocationFields(view_FacilityRating.gSafeGuid, view_FacilityRating.objFind(), view_FacilityRating.objListing());
                    // LOOKUP RECORD USING THE ON FIRST NAVIGATE
                    view_FacilityRating.onFileFirst();
                    view_FacilityRating.resetPickers();
                },

                onFindClear: function () {
                    // CLEAR THE OBJECT
                    view_FacilityRating.resetPickers();
                    // SET THE GSAFE
                    setFindLocationFields(view_FacilityRating.gSafeGuid, view_FacilityRating.objFind(), view_FacilityRating.objListing());
                    // RELOAD THE FILE NUMBER TO GET THE CORRECT LOCATION COUNT
                    view_FacilityRating.onFileFirst();
                    view_FacilityRating.resetPickers();
                },

                onLocationDetailsRedirect: function () {
                    // REDIRECT THE USER TO THE LOCATION DETAILS PAGE
                    document.location.href = "locationdetails.aspx" + "?sid=" + view_FacilityRating.gSafeGuid;
                },

                // ENABLE OR DISABLE BUTTONS AND SHOW RECORD NUMBER
                setupButtons: function () {
                    if (view_FacilityRating.index == 0) {
                        view_FacilityRating.enablePrev(false);
                        $('#btnPrevious').addClass('grcBlueDisabledBtn');
                    } else {
                        view_FacilityRating.enablePrev(true);
                        $('#btnPrevious').removeClass('grcBlueDisabledBtn');
                    }
                    if (view_FacilityRating.index == view_FacilityRating.collFacilityRating().length - 1) {
                        view_FacilityRating.enableNext(false);
                        $('#btnNext').addClass('grcBlueDisabledBtn');
                    } else {
                        view_FacilityRating.enableNext(true);
                        $('#btnNext').removeClass('grcBlueDisabledBtn');
                    }
                    if (view_FacilityRating.stateOnlyOneDetailRecordLoaded == true) {
                        view_FacilityRating.enableNext(true);
                        $('#btnNext').removeClass('grcBlueDisabledBtn');
                    }
                    if (view_FacilityRating.stateOnlyOneDetailRecordLoaded) {
                        view_FacilityRating.txtRecordNumber("1...");
                    } else {
                        view_FacilityRating.txtRecordNumber((view_FacilityRating.index + 1) + " of " + view_FacilityRating.collFacilityRating().length);
                    }
                },

                setupFileButtons: function () {
                    if (view_FacilityRating.objListing().RecNum() <= 1) {
                        view_FacilityRating.enableFilePrev(false);
                        $('#btnFileFirst').addClass('grcBlueDisabledBtn');
                        $('#btnFilePrevious').addClass('grcBlueDisabledBtn');
                    } else {
                        view_FacilityRating.enableFilePrev(true);
                        $('#btnFileFirst').removeClass('grcBlueDisabledBtn');
                        $('#btnFilePrevious').removeClass('grcBlueDisabledBtn');
                    }
                    if (view_FacilityRating.objListing().RecNum() >= view_FacilityRating.objListing().RecCount()) {
                        view_FacilityRating.enableFileNext(false);
                        $('#btnFileNext').addClass('grcBlueDisabledBtn');
                        $('#btnFileLast').addClass('grcBlueDisabledBtn');
                    } else {
                        view_FacilityRating.enableFileNext(true);
                        $('#btnFileNext').removeClass('grcBlueDisabledBtn');
                        $('#btnFileLast').removeClass('grcBlueDisabledBtn');
                    }
                    if (view_FacilityRating.objListing().RecCount() <= 1) {
                        view_FacilityRating.enableFilePrev(false);
                        view_FacilityRating.enableFilePrev(false);
                        $('#btnFileFirst').addClass('grcBlueDisabledBtn');
                        $('#btnFilePrevious').addClass('grcBlueDisabledBtn');
                    }
                    view_FacilityRating.txtFileRecordNumber(view_FacilityRating.objListing().RecNum() + " of " + view_FacilityRating.objListing().RecCount());
                },

                // SETUP FIND FIELDS FOR LOCATIONS
                setupFindFields: function () {
                    // FIND TEXT BOXES
                    view_FacilityRating.objFind().findFileNo = view_FacilityRating.objListing().FileNo();
                    view_FacilityRating.objFind().findClientLocNo = view_FacilityRating.objListing().ClientLocNo();
                    view_FacilityRating.objFind().findAddress1 = view_FacilityRating.objListing().Address1();
                    view_FacilityRating.objFind().findCity = view_FacilityRating.objListing().City();
                    view_FacilityRating.objFind().findStProv = view_FacilityRating.objListing().StProv();
                    view_FacilityRating.objFind().findCountry = view_FacilityRating.objListing().Country();
                    view_FacilityRating.objFind().findZip = view_FacilityRating.objListing().Zip();
                    view_FacilityRating.objFind().findDivision = view_FacilityRating.objListing().Division();
                    view_FacilityRating.objFind().findFacility = view_FacilityRating.objListing().Facility();
                    view_FacilityRating.objFind().findCustomAccess = view_FacilityRating.objListing().CustomAccess();
                    view_FacilityRating.objFind().findLatitude = view_FacilityRating.objListing().Latitude();
                    view_FacilityRating.objFind().findLongitude = view_FacilityRating.objListing().Longitude();
                },

                // RESET FIELDS ON LOAD RECORD
                resetPickers: function () {
                    // COPY THE FIND FIELDS
                    view_FacilityRating.setupFindFields();

                    // COLORS
                    Maxpossiblerating.wrapper.find(".k-input").css("background-color", view_FacilityRating.objFacilityRating().Maxpossiblescorecolor());
                    Maxpossiblerating.wrapper.find(".k-input").parent().css("background-color", view_FacilityRating.objFacilityRating().Maxpossiblescorecolor());
                    Overallplantratingrating.wrapper.find(".k-input").css("background-color", view_FacilityRating.objFacilityRating().Totalscorecolor());
                    Overallplantratingrating.wrapper.find(".k-input").parent().css("background-color", view_FacilityRating.objFacilityRating().Totalscorecolor());
                    OverallRatingValue.wrapper.find(".k-input").css("background-color", view_FacilityRating.objFacilityRating().Totalscorecolor());
                    OverallRatingValue.wrapper.find(".k-input").parent().css("background-color", view_FacilityRating.objFacilityRating().Totalscorecolor());

                    $('#OverallRatingWRecsCompl').css("background-color", view_FacilityRating.objFacilityRating().OverallScoreWithRecsCompleteHexBackColor());
                    $("#RatingKeyColor1").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor1());
                    $("#RatingKeyColor2").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor2());
                    $("#RatingKeyColor3").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor3());
                    $("#RatingKeyColor4").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor4());
                    $("#RatingKeyColor5").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor5());

                    // VALUES PASSIVE AND ACTIVE AND OTHER
                    Floodweight.value(view_FacilityRating.objFacilityRating().Floodweight() / 10);
                    Earthquakeweight.value(view_FacilityRating.objFacilityRating().Earthquakeweight() / 10);
                    Windstormweight.value(view_FacilityRating.objFacilityRating().Windstormweight() / 10);
                    Constructionweight.value(view_FacilityRating.objFacilityRating().Constructionweight() / 10);
                    Occupancyweight.value(view_FacilityRating.objFacilityRating().Occupancyweight() / 10);
                    Otherweight.value(view_FacilityRating.objFacilityRating().Otherweight() / 10);
                    Passivescore.value(view_FacilityRating.objFacilityRating().Passivescore());
                    Physicalprotectionweight.value(view_FacilityRating.objFacilityRating().Physicalprotectionweight() / 10);
                    Humanelementweight.value(view_FacilityRating.objFacilityRating().Humanelementweight() / 10);
                    Naturalhazardsprotectionweight.value(view_FacilityRating.objFacilityRating().Naturalhazardsprotectionweight() / 10);
                    Businesscontinuityweight.value(view_FacilityRating.objFacilityRating().Businesscontinuityweight() / 10);
                    Activescore.value(view_FacilityRating.objFacilityRating().Activescore());
                    Activescorewithrecscomplete.value(view_FacilityRating.objFacilityRating().Activescorewithrecscomplete());
                    Inspectiondate.value(view_FacilityRating.objFacilityRating().Inspectiondate());

                    // VALUES AND COLORS PASSIVE
                    Floodrating.value(view_FacilityRating.objFacilityRating().Floodrating());
                    Floodrating.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Floodratingcolor());
                    //Floodrating.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().Floodratingcolor());
                    Earthquakerating.value(view_FacilityRating.objFacilityRating().Earthquakerating());
                    Earthquakerating.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Earthquakeratingcolor());
                    //Earthquakerating.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().Earthquakeratingcolor());
                    Windstormrating.value(view_FacilityRating.objFacilityRating().Windstormrating());
                    Windstormrating.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Windstormratingcolor());
                    //Windstormrating.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().Windstormratingcolor());
                    Constructionrating.value(view_FacilityRating.objFacilityRating().Constructionrating());
                    Constructionrating.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Constructionratingcolor());
                    //Constructionrating.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().Constructionratingcolor());
                    Occupancyrating.value(view_FacilityRating.objFacilityRating().Occupancyrating());
                    Occupancyrating.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Occupancyratingcolor());
                    //Occupancyrating.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().Occupancyratingcolor());
                    Otherrating.value(view_FacilityRating.objFacilityRating().Otherrating());
                    Otherrating.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Otherratingcolor());
                    //Otherrating.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().Otherratingcolor());

                    // VALUES AND COLORS ACTIVE
                    Physicalprotectionrating.value(view_FacilityRating.objFacilityRating().Physicalprotectionrating());
                    Physicalprotectionrating.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Physicalprotectionratingcolor());
                    //Physicalprotectionrating.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().Physicalprotectionratingcolor());
                    Humanelementrating.value(view_FacilityRating.objFacilityRating().Humanelementrating());
                    Humanelementrating.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Humanelementratingcolor());
                    //Humanelementrating.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().Humanelementratingcolor());
                    Naturalhazardsprotectionrating.value(view_FacilityRating.objFacilityRating().Naturalhazardsprotectionrating());
                    Naturalhazardsprotectionrating.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Naturalhazardsprotectionratingcolor());
                    //Naturalhazardsprotectionrating.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().Naturalhazardsprotectionratingcolor());
                    Businesscontinuityrating.value(view_FacilityRating.objFacilityRating().Businesscontinuityrating());
                    Businesscontinuityrating.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Businesscontinuityratingcolor());
                    //Businesscontinuityrating.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().Businesscontinuityratingcolor());
                    Fireprotectionallrecscompleterating.value(view_FacilityRating.objFacilityRating().Fireprotectionallrecscompleterating());
                    Fireprotectionallrecscompleterating.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Fireprotectionallrecscompleteratingcolor());
                    //Fireprotectionallrecscompleterating.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().Fireprotectionallrecscompleteratingcolor());
                    Humanelementallrecscompleterating.value(view_FacilityRating.objFacilityRating().Humanelementallrecscompleterating());
                    Humanelementallrecscompleterating.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Humanelementallrecscompleteratingcolor());
                    //Humanelementallrecscompleterating.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().Humanelementallrecscompleteratingcolor());
                    Nathazprotallrecscompleterating.value(view_FacilityRating.objFacilityRating().Nathazprotallrecscompleterating());
                    Nathazprotallrecscompleterating.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Nathazprotallrecscompleteratingcolor());
                    //Nathazprotallrecscompleterating.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().Nathazprotallrecscompleteratingcolor());
                    Bcpallrecscompletrating.value(view_FacilityRating.objFacilityRating().Bcpallrecscompletrating());
                    Bcpallrecscompletrating.wrapper.find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Bcpallrecscompletratingcolor());
                    //Bcpallrecscompletrating.wrapper.find(".k-formatted-value").css("background-color", view_FacilityRating.objFacilityRating().Bcpallrecscompletratingcolor());

                    // APL VALUES
                    // EXAMPLE Passivescore.value(view_FacilityRating.objFacilityRating().Passivescore());
                    //Apl.value(view_FacilityRating.objFacilityRating().Apl());
                    Aplfactor.value(view_FacilityRating.objFacilityRating().Aplfactor());
                    // Aplwithallrecscomplete.value(view_FacilityRating.objFacilityRating().Aplwithallrecscomplete());
                    Aplfactorwithallrecscomplete.value(view_FacilityRating.objFacilityRating().Aplfactorwithallrecscomplete());

                    // SUMMARY VALUES
                    Totalscore.value(view_FacilityRating.objFacilityRating().Totalscore());
                    Overallscorewithrecscomplete.value(view_FacilityRating.objFacilityRating().Overallscorewithrecscomplete());
                    Maxpossiblescore.value(view_FacilityRating.objFacilityRating().Maxpossiblescore());
                    Overallplantratingrating.value(view_FacilityRating.objFacilityRating().Overallplantratingdescription());
                    //OverallRatingValue.value(view_FacilityRating.objFacilityRating().)

                    // DISPLAY WINDOW IF NO RECORD EXISTS OR A MESSAGE IF NO SEARCH FOUND
                    windowNoLocation.data("kendoWindow").close();
                    view_FacilityRating.messageError("");
                    if ((view_FacilityRating.objFacilityRating().Fileno() == "Not Found" && view_FacilityRating.pageRequestedFrom == "topnav") || (view_FacilityRating.objListing().FileNo() == "Not Found" && view_FacilityRating.pageRequestedFrom == "topnav")) {
                        view_FacilityRating.messageError(view_FacilityRating.objLanguageLabels().lblNoActiveLocations);
                        view_FacilityRating.clearPickers();
                        view_FacilityRating.clearAddressFields();
                    } else if (view_FacilityRating.objFacilityRating().Fileno() == "Not Found") {
                        windowNoLocation.data("kendoWindow").open();
                        $("#windowNoLocation").css("display", "block");
                        view_FacilityRating.clearPickers();
                    } else if (view_FacilityRating.objListing().FileNo() == "Not Found") {
                        view_FacilityRating.messageError(view_FacilityRating.objLanguageLabels().lblSearchNotFound);
                        view_FacilityRating.clearPickers();
                    }

                    // ALWAYS CLEAR THE REQUESTING VARIABLE FOR USE OF CLIENT SIDE BUTTON NAVIGATION
                    view_FacilityRating.pageRequestedFrom = "";
                },

                clearAddressFields: function () {
                    $("#FileNo").val("");
                    $("#ClientLocNo").val("");
                    $("#Latitude").val("");
                    $("#Longitude").val("");
                    $("#Address1").val("");
                    $("#Division").val("");
                    $("#City").val("");
                    $("#StProv").val("");
                    $("#Country").val("");
                    $("#Zip").val("");
                    $("#Facility").val("");
                    $("#CustomAccess").val("");
                    $("#txtFileRecordNumber").val("");
                },

                clearPickers: function () {
                    // KENDO WIDGETS
                    Maxpossiblerating.wrapper.find(".k-autocomplete").css("background-color", "transparent");
                    Maxpossiblerating.wrapper.find(".k-autocomplete").parent().css("background-color", "transparent");
                    Overallplantratingrating.wrapper.find(".k-autocomplete").css("background-color", "transparent");
                    Overallplantratingrating.wrapper.find(".k-autocomplete").parent().css("background-color", "transparent");
                    OverallRatingValue.wrapper.find(".k-autocomplete").css("background-color", "transparent");
                    OverallRatingValue.wrapper.find(".k-autocomplete").parent().css("background-color", "transparent");

                    // VALUES PASSIVE AND ACTIVE AND OTHER
                    Floodweight.value("");
                    Earthquakeweight.value("");
                    Windstormweight.value("");
                    Constructionweight.value("");
                    Occupancyweight.value("");
                    Otherweight.value("");
                    Passivescore.value("");
                    Physicalprotectionweight.value("");
                    Humanelementweight.value("");
                    Naturalhazardsprotectionweight.value("");
                    Businesscontinuityweight.value("");
                    Activescore.value("");
                    Activescorewithrecscomplete.value("");
                    Inspectiondate.value("");
                    // VALUES AND COLORS PASSIVE
                    Floodrating.value("");
                    Floodrating.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Floodrating.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    Earthquakerating.value("");
                    Earthquakerating.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Earthquakerating.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    Windstormrating.value("");
                    Windstormrating.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Windstormrating.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    Constructionrating.value("");
                    Constructionrating.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Constructionrating.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    Occupancyrating.value("");
                    Occupancyrating.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Occupancyrating.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    Otherrating.value("");
                    Otherrating.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Otherrating.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    // VALUES AND COLORS ACTIVE
                    Physicalprotectionrating.value("");
                    Physicalprotectionrating.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Physicalprotectionrating.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    Humanelementrating.value("");
                    Humanelementrating.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Humanelementrating.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    Naturalhazardsprotectionrating.value("");
                    Naturalhazardsprotectionrating.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Naturalhazardsprotectionrating.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    Businesscontinuityrating.value("");
                    Businesscontinuityrating.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Businesscontinuityrating.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    Fireprotectionallrecscompleterating.value("");
                    Fireprotectionallrecscompleterating.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Fireprotectionallrecscompleterating.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    Humanelementallrecscompleterating.value("");
                    Humanelementallrecscompleterating.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Humanelementallrecscompleterating.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    Nathazprotallrecscompleterating.value("");
                    Nathazprotallrecscompleterating.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Nathazprotallrecscompleterating.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    Bcpallrecscompletrating.value("");
                    Bcpallrecscompletrating.wrapper.find(".k-numeric-wrap").css("background-color", "transparent");
                    Bcpallrecscompletrating.wrapper.find(".k-formatted-value").css("background-color", "transparent");
                    // APL VALUES
                    // Apl.value("");
                    Aplfactor.value("");
                    // Aplwithallrecscomplete.value("");
                    Aplfactorwithallrecscomplete.value("");
                    // SUMMARY VALUES
                    Totalscore.value("");
                    Overallscorewithrecscomplete.value("");
                    Maxpossiblescore.value("");

                    // OTHER HTML / KNOCKOUT DOMS
                    $("#Totalscore").val("");
                    $("#Overallscorewithrecscomplete").val("");
                    $("#Maxpossiblescore").val("");
                },

                // LOAD ONLY THE LOWER DETAILS, ONE OR ALL DEPENDING ON STATE
                loadDetailsOnly: function () {
                    view_FacilityRating.stateLoadError = false;

                    var tempParm = view_FacilityRating.gSafeGuid;
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    if (view_FacilityRating.stateDetailsLoadOneRecord == true && view_FacilityRating.stateLoadError == false) {
                        if (!view_FacilityRating.collFacilityRating.ViewCCFireFacilityRatingCollection(tempParm + "|one|False")) { view_FacilityRating.stateLoadError = false } else { view_FacilityRating.stateLoadError = true }
                        view_FacilityRating.stateDetailsLoadOneRecord = false;
                        view_FacilityRating.stateOnlyOneDetailRecordLoaded = true;
                    } else {
                        if (!view_FacilityRating.collFacilityRating.ViewCCFireFacilityRatingCollection(tempParm + "|all|False")) { view_FacilityRating.stateLoadError = false } else { view_FacilityRating.stateLoadError = true }
                        view_FacilityRating.stateDetailsLoadOneRecord = false;
                        view_FacilityRating.stateOnlyOneDetailRecordLoaded = false;
                    }
                    if (!view_FacilityRating.stateLoadError) {
                        view_FacilityRating.objFacilityRating(view_FacilityRating.collFacilityRating()[view_FacilityRating.index]);
                    } else {
                        // DISPLAY ERROR MESSAGE
                        view_FacilityRating.messageError("* Error while loading record.");
                    }
                },

                // LOAD ONE FILE NUMBER AND ONE DETAIL
                loadOneFileNumber: function () {
                    view_FacilityRating.stateLoadError = false;

                    var tempParm = view_FacilityRating.gSafeGuid + "|" + view_FacilityRating.fileDirection() + "|one|False";
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    if (!view_FacilityRating.collListing.ViewCCLocationFireCollections(tempParm)) { view_FacilityRating.stateLoadError = false } else { view_FacilityRating.stateLoadError = true }
                    view_FacilityRating.stateListingLoadOneRecord = false;

                    tempParm = view_FacilityRating.gSafeGuid + "|one|False";
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    if (!view_FacilityRating.collFacilityRating.ViewCCFireFacilityRatingCollection(tempParm)) { view_FacilityRating.stateLoadError = false } else { view_FacilityRating.stateLoadError = true }
                    view_FacilityRating.stateDetailsLoadOneRecord = false;
                    view_FacilityRating.stateOnlyOneDetailRecordLoaded = true;

                    view_FacilityRating.objListing(view_FacilityRating.collListing()[0]);
                    view_FacilityRating.objFacilityRating(view_FacilityRating.collFacilityRating()[0]);
                    view_FacilityRating.objFind(getFindLocationFields(view_FacilityRating.gSafeGuid));
                    //SET BOOL TO SHOW OR HIDE APL SECTION
                    if (view_FacilityRating.clientFeatures().search('A') > -1) {
                        view_FacilityRating.showAPL(false);
                    }

                    if (view_FacilityRating.clientFeatures().search('U') > -1) {
                        view_FacilityRating.isMagna(true);
                    }
                    //LOAD MANGA DATA
                    if (view_FacilityRating.isMagna()) {
                        view_FacilityRating.loadAverageCollection();
                    }

                    if (view_FacilityRating.objFind().findCriteria == undefined || view_FacilityRating.objFind().findCriteria == "") {
                        viewFindCriteria_FacilityRating.findCriteria(" ");
                        view_FacilityRating.findEngaged(true);
                    } else {
                        viewFindCriteria_FacilityRating.findCriteria(view_FacilityRating.objFind().findCriteria);
                        view_FacilityRating.findEngaged(false);
                    }
                    view_FacilityRating.setupButtons();
                    view_FacilityRating.setupFileButtons();
                },

                // LOAD ALL RECORDS AND ALL DETAILS
                loadFileNumber: function () {
                    view_FacilityRating.stateLoadError = false;

                    // LOAD THE LOACATION LISTINGS, ONE OR ALL, WITH FILE DIRECTION
                    var tempParm = view_FacilityRating.gSafeGuid + "|" + view_FacilityRating.fileDirection() + "|one|False";
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    if (!view_FacilityRating.collListing.ViewCCLocationFireCollections(tempParm)) { view_FacilityRating.stateLoadError = false } else { view_FacilityRating.stateLoadError = true }
                    view_FacilityRating.stateListingLoadOneRecord = false;

                    // LOAD ALL DETAILS
                    tempParm = view_FacilityRating.gSafeGuid + "|all|False";
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    if (!view_FacilityRating.collFacilityRating.ViewCCFireFacilityRatingCollection(tempParm)) { view_FacilityRating.stateLoadError = false } else { view_FacilityRating.stateLoadError = true }
                    view_FacilityRating.stateDetailsLoadOneRecord = false;
                    view_FacilityRating.stateOnlyOneDetailRecordLoaded = false;

                    // DO THE REMAINING CODE TO POPUPLATE THE PAGE
                    if (!view_FacilityRating.stateLoadError) {
                        view_FacilityRating.objListing(view_FacilityRating.collListing()[0]);
                        view_FacilityRating.objFacilityRating(view_FacilityRating.collFacilityRating()[view_FacilityRating.index]);
                        view_FacilityRating.clientFeatures(getClientFeatures(view_FacilityRating.gSafeGuid));
                        //SET BOOL TO SHOW OR HIDE APL SECTION
                        if (view_FacilityRating.clientFeatures().search('A') > -1) {
                            view_FacilityRating.showAPL(false);
                        }
                        if (view_FacilityRating.clientFeatures().search('U') > -1) {
                            view_FacilityRating.isMagna(true);
                        }
                        //LOAD MANGA DATA
                        if (view_FacilityRating.isMagna()) {
                            view_FacilityRating.loadAverageCollection();
                        }
                        view_FacilityRating.objFind(getFindLocationFields(view_FacilityRating.gSafeGuid));
                        view_FacilityRating.setupButtons();
                        view_FacilityRating.setupFileButtons();
                        if (view_FacilityRating.objFind().findCriteria == undefined || view_FacilityRating.objFind().findCriteria == "") {
                            viewFindCriteria_FacilityRating.findCriteria(" ");
                            view_FacilityRating.findEngaged(true);
                        } else {
                            viewFindCriteria_FacilityRating.findCriteria(view_FacilityRating.objFind().findCriteria);
                            view_FacilityRating.findEngaged(false);
                        }
                    } else {
                        // DISPLAY ERROR MESSAGE
                        view_FacilityRating.messageError("* Error while loading record.");
                    }

                    //                var tempParm = view_FacilityRating.gSafeGuid + "|" + view_FacilityRating.fileDirection();
                    //                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    //                if (!view_FacilityRating.collListing.ViewCCLocationFireCollections(tempParm)) {
                    //                    //if (!view_FacilityRating.collListing.ViewCCLocationFireRatingCollections(tempParm)) {
                    //                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    //                    if (!view_FacilityRating.collFacilityRating.ViewCCFireFacilityRatingCollection(view_FacilityRating.gSafeGuid)) {
                    //                        view_FacilityRating.objListing(view_FacilityRating.collListing()[0]);
                    //                        view_FacilityRating.objFacilityRating(view_FacilityRating.collFacilityRating()[0]);
                    //                        view_FacilityRating.clientFeatures(getClientFeatures(view_FacilityRating.gSafeGuid));
                    //                        view_FacilityRating.objFind(getFindLocationFields(view_FacilityRating.gSafeGuid));
                    //                        view_FacilityRating.setupButtons();
                    //                        view_FacilityRating.setupFileButtons();
                    //                        if (view_FacilityRating.objFind().findCriteria == undefined || view_FacilityRating.objFind().findCriteria == "") {
                    //                            viewFindCriteria_FacilityRating.findCriteria(" ");
                    //                            view_FacilityRating.findEngaged(true);
                    //                        } else {
                    //                            viewFindCriteria_FacilityRating.findCriteria(view_FacilityRating.objFind().findCriteria);
                    //                            view_FacilityRating.findEngaged(false);
                    //                        }
                    //                    } else {
                    //                        view_FacilityRating.messageError("* Error while loading Facility Rating Details.");
                    //                    }
                    //                } else {
                    //                    view_FacilityRating.messageError("* Error while loading Location Listing.");
                    //                }
                },

                //LOAD MAGNA AVERAGE/WEIGHTED AVERAGE SECTION DATA
                loadAverageCollection: function () {
                    try {
                        //var gSafe = getGSafeGUID();
                        var zServiceName = "GetLocationLevelFireRatingAverages";
                        var zParms = ko.toJSON({
                            "pGSafeGuid": getGSafeGUID()
                        });
                        global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, view_FacilityRating.loadAverageCollectionSuccess, view_FacilityRating.loadAverageCollectionError, null);
                    } catch (pException) {
                        view_FacilityRating.processMessage("An error occurred while starting the Facility Rating Averages Section data call: " + pException.message);
                    }
                },

                loadAverageCollectionSuccess: function (pResults, pParms) {
                    try {
                        if (pResults.isSuccess) {
                            view_FacilityRating.colAverageWeightedAverage(pResults.data);
                        }
                    } catch (pException) {
                        view_FacilityRating.processMessage("An error occurred while starting the Facility Rating Averages Section data call: " + pException.message);
                    }
                },

                loadAverageCollectionError: function (pResults, pMessage, pErrorDetail, pParms) {
                    view_FacilityRating.processMessage("Error while loading Facility Rating Averages Section data. " + pMessage);
                },


                processMessage: function (pMessage) {
                    alert(pMessage);
                }
            };
            
            // SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
            view_FacilityRating.loadFileNumber();
            

            // ACTIVATE BINDINGS LAST
            ko.applyBindings(view_FacilityRating, $("#view_FacilityRating")[0]);
            ko.applyBindings(viewFindCriteria_FacilityRating, $("#viewFindCriteria_FacilityRating")[0]);

            // SETUP KENDOUI

            // ERROR WINDOW
            var windowNoLocation = $("#windowNoLocation");
            windowNoLocation.kendoWindow({
                width: "300px",
                height: "200px",
                title: "", // title added below with JQuery
                actions: ["Close"],
                animation: { open: { effects: "none" }, close: { effects: "default" } }
            });
            $("#windowNoLocation").closest(".k-window").css({
                top: 300,
                left: 375
            });
            $("#windowNoLocation").prev().find(".k-window-title").append("<img src='../images/icons/warning/window_warning_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view_FacilityRating.objLanguageLabels().lblNoLocationFoundTitle);


            // RATING COLORS
            var Maxpossiblerating = $("#Maxpossiblerating").kendoAutoComplete().data("kendoAutoComplete");
            var Overallplantratingrating = $("#Overallplantratingrating").kendoAutoComplete().data("kendoAutoComplete");
            var OverallRatingValue = $('#OverallRatingValue').kendoAutoComplete().data("kendoAutoComplete");

            // KEY COLORS
            $("#RatingKeyColor1").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor1());
            $("#RatingKeyColor2").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor2());
            $("#RatingKeyColor3").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor3());
            $("#RatingKeyColor4").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor4());
            $("#RatingKeyColor5").css("background-color", view_FacilityRating.objFacilityRating().RatingKeyColor5());

            // DATES
            var Inspectiondate = $("#Inspectiondate").kendoDatePicker({
                value: view_FacilityRating.objFacilityRating().Inspectiondate(),
                format: "dd-MMM-yy"
            }).data("kendoDatePicker");
            Inspectiondate.wrapper
                    .find(".k-picker-wrap").addClass("expand-padding inspectionDateInput").css("height", "13px").find(".k-select").hide();

            // PASSIVE NUMERIC TEXTBOXES
            var Floodweight = $("#Floodweight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Floodweight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Floodweight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            var Earthquakeweight = $("#Earthquakeweight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Earthquakeweight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Earthquakeweight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            var Windstormweight = $("#Windstormweight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Windstormweight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Windstormweight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            var Constructionweight = $("#Constructionweight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Constructionweight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Constructionweight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            var Occupancyweight = $("#Occupancyweight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Occupancyweight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Occupancyweight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            var Otherweight = $("#Otherweight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Otherweight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Otherweight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            var Floodrating = $("#Floodrating").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Floodrating(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Floodrating.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            Floodrating.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Floodratingcolor());
            var Earthquakerating = $("#Earthquakerating").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Earthquakerating(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Earthquakerating.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            Earthquakerating.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Earthquakeratingcolor());
            var Windstormrating = $("#Windstormrating").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Windstormrating(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Windstormrating.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            Windstormrating.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Windstormratingcolor());
            var Constructionrating = $("#Constructionrating").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Constructionrating(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Constructionrating.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            Constructionrating.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Constructionratingcolor());
            var Occupancyrating = $("#Occupancyrating").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Occupancyrating(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Occupancyrating.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            Occupancyrating.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Occupancyratingcolor());
            var Otherrating = $("#Otherrating").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Otherrating(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Otherrating.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            Otherrating.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Otherratingcolor());
            var Passivescore = $("#Passivescore").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Passivescore(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Passivescore.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputs").css("height", "13px").find(".k-select").hide();

            // ACTIVE NUMERIC BOXES
            var Physicalprotectionweight = $("#Physicalprotectionweight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Physicalprotectionweight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Physicalprotectionweight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            var Humanelementweight = $("#Humanelementweight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Humanelementweight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Humanelementweight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            var Naturalhazardsprotectionweight = $("#Naturalhazardsprotectionweight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Naturalhazardsprotectionweight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Naturalhazardsprotectionweight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            var Businesscontinuityweight = $("#Businesscontinuityweight").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Businesscontinuityweight() / 10,
                format: "p0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Businesscontinuityweight.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            var Physicalprotectionrating = $("#Physicalprotectionrating").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Physicalprotectionrating(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Physicalprotectionrating.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            Physicalprotectionrating.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Physicalprotectionratingcolor());
            var Humanelementrating = $("#Humanelementrating").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Humanelementrating(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Humanelementrating.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            Humanelementrating.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Humanelementratingcolor());
            var Naturalhazardsprotectionrating = $("#Naturalhazardsprotectionrating").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Naturalhazardsprotectionrating(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Naturalhazardsprotectionrating.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            Naturalhazardsprotectionrating.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Naturalhazardsprotectionratingcolor());
            var Businesscontinuityrating = $("#Businesscontinuityrating").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Businesscontinuityrating(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Businesscontinuityrating.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            Businesscontinuityrating.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Businesscontinuityratingcolor());
            var Fireprotectionallrecscompleterating = $("#Fireprotectionallrecscompleterating").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Fireprotectionallrecscompleterating(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Fireprotectionallrecscompleterating.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            Fireprotectionallrecscompleterating.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Fireprotectionallrecscompleteratingcolor());
            var Humanelementallrecscompleterating = $("#Humanelementallrecscompleterating").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Humanelementallrecscompleterating(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Humanelementallrecscompleterating.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            Humanelementallrecscompleterating.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Humanelementallrecscompleteratingcolor());
            var Nathazprotallrecscompleterating = $("#Nathazprotallrecscompleterating").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Nathazprotallrecscompleterating(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Nathazprotallrecscompleterating.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").find(".k-select").hide();
            Nathazprotallrecscompleterating.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Nathazprotallrecscompleteratingcolor());
            var Bcpallrecscompletrating = $("#Bcpallrecscompletrating").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Bcpallrecscompletrating(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Bcpallrecscompletrating.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding activeInputsNumberPicker").css("height", "13px").css("height", "14px", "important").find(".k-select").hide();
            Bcpallrecscompletrating.wrapper
                    .find(".k-numeric-wrap").css("background-color", view_FacilityRating.objFacilityRating().Bcpallrecscompletratingcolor());
            var Activescore = $("#Activescore").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Activescore(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Activescore.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputs").css("height", "13px").find(".k-select").hide();
            var Activescorewithrecscomplete = $("#Activescorewithrecscomplete").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Activescorewithrecscomplete(),
                format: "n0",
                decimals: 4
            }).data("kendoNumericTextBox");
            Activescorewithrecscomplete.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding passiveInputs").css("height", "13px").find(".k-select").hide();

            // APL NUMERIC TEXT BOXES
            var Aplfactor = $("#Aplfactor").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Aplfactor(),
                format: "n1",
                decimals: 4
            }).data("kendoNumericTextBox");
            Aplfactor.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding summaryAPLInputs").css("height", "13px").find(".k-select").hide();
            var Aplfactorwithallrecscomplete = $("#Aplfactorwithallrecscomplete").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Aplfactorwithallrecscomplete(),
                format: "n1",
                decimals: 4
            }).data("kendoNumericTextBox");
            Aplfactorwithallrecscomplete.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding summaryAPLInputs").css("height", "13px").find(".k-select").hide();

            // SUMMARY NUMERIC TEXT BOXES
            var Totalscore = $("#Totalscore").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Totalscore(),
                format: "n1",
                decimals: 4
            }).data("kendoNumericTextBox");
            Totalscore.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding summaryInputs").css("height", "13px").find(".k-select").hide();
            var Overallscorewithrecscomplete = $("#Overallscorewithrecscomplete").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Overallscorewithrecscomplete(),
                format: "n1",
                decimals: 4
            }).data("kendoNumericTextBox");
            Overallscorewithrecscomplete.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding summaryInputs").css("height", "13px").find(".k-select").hide();
            var Maxpossiblescore = $("#Maxpossiblescore").kendoNumericTextBox({
                value: view_FacilityRating.objFacilityRating().Maxpossiblescore(),
                format: "n1",
                decimals: 4
            }).data("kendoNumericTextBox");
            Maxpossiblescore.wrapper
                    .find(".k-numeric-wrap").addClass("expand-padding summaryInputs").css("height", "13px").find(".k-select").hide();

            // WHEN ALL DONE CALL THE RESET TO SYNC THE FIND AND THE PICKERS
            view_FacilityRating.setupFindFields();
            view_FacilityRating.resetPickers();
        });
    </script>
    </form>
</body>
</html>
