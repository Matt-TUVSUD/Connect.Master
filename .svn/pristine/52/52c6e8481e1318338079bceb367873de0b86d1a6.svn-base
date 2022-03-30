<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectUserAccountForm.Master" CodeBehind="UserAccountForm.aspx.vb" Inherits="GRC.Connect.Web.UserAccountForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!--Link files here CSS/JS for example-->
    <script>
        gPageName = "UserAccount"
    </script>
</asp:Content>

<asp:Content ID="ContentFindCriteria" ContentPlaceHolderID="ContentFindCriteria" runat="server">
    <%--<div class="headerFindCriteria" id="viewFindCriteria" data-bind="with: viewFindCriteria">
        <label data-bind="text: $parent.findCriteria" id="findCriteria"></label>&nbsp;
    </div>--%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <style>
        .infoHolder{
            width:100%;
        }
        .infoLabel{
            float:left;
            width:35% !important;
            min-width:35%;
            text-align:left;
        }
        .infoLabelContent{
            float:left;
            min-width:65%;
            width:65% !important;
        }
        .infoLabelRight{
            float:left;
            width:35%;
            text-align:left;
        }
        .infoLabelContentRight{
            float:left;
            min-width:60%;
            width:60%;
        }
        .yAxis {
            height:30px;
            width:55px;
            float:left;
        }
        .lb_yAxis {
            border-right: 1px solid #eee;
            width: 55px;
            display: block;
            text-align: center;
            padding-top: 10px;
            height: 22px;
        }
        .xAxis {
            width:615px;
            background:#d9d9d9;
        }
        .alt{
            background:#f3f3f3;
        }
        .gridLines {
            width:615px;
            border-top:3px solid #eee;
            border-left:3px solid #eee;
        }
        .gridLines:last-child {
            border-bottom:3px solid #eee;
        }
        .chkBoxCell {
            float: left;
            height: 22px;
            width: 55px;
            text-align: center;
            padding-top: 5px;
            border-right: 1px solid #eee;
        }
        .chkBoxCell:last-child{
            border-right: 3px solid #eee;
        }
        .k-window-titlebar {
            text-align: center;
        }
        div.k-window {
            height:460px;
            overflow:hidden;
        }
        div.k-window-content {
            padding:0px;
            overflow:hidden;
        }
        .defRow {
            border: 1px solid #000;
        }
        .defRow:last-child {
            /*border-bottom: none;*/
        }
        .defLbl {
            float: left;
            width: 20%;
            text-align:left;
            padding: 5px;
        }
        .pastDue {
            padding-top:16px;
        }
        .def {
            float: left;
            padding:5px;
            width: 70%;
            border-left:1px solid #000;
        }
        .pending {
            color:#ff0000;
            font-weight:700;
            font-size:14px;
        }
        .confirmed {
            color:#008000;
            font-weight:700;
            font-size:14px;
        }
        .nav_comments {
            top:80px;
        }
        #lblEmail {
            float:left; 
            margin-right:30px;
        }
         .btnBack {
            background:#abc7e7; 
            color:#000; 
            border:1px solid #5b9bd5; 
            position:absolute; 
            bottom:35px; 
            left:230px;
        }
        .btnNext {
            background:#abc7e7; 
            color:#000; 
            border:1px solid #5b9bd5; 
            position:absolute; 
            bottom:35px; 
            right:265px;
        }
        .btnDisable {
            color:#999;
            background:#eee;
            border:1px solid #d9d9d9;
        }
        @media all and (-ms-high-contrast: none), (-ms-high-contrast: active) {
            /* IE10+ CSS styles go here */
            textarea {
                width:610px;
            }
            #lblRadActivate, #lblRadInactivate, #lblRadDelete, #lblRadConfirm {
                margin-right:5px;
            }
            #RadioHldr {
                margin-left:15px;
            }
            #lblEmail {
            float:left; 
            margin-right:28px;
            }
            .nav_Comments {
                top:112px;
            }
            .k-widget.k-window {
                height:336px !important;
            }
            .pastDue {
                padding-top:10px;
            }
        }
    </style>
<div id="view">
    <div id="divContainerLoading" class="containerLoading" style=""></div>
    <div id="errorHldr" style="text-align:center; margin-bottom:15px;">
        <label id="txtMessage" data-bind="text: txtMessage"></label>
    </div>
    <div class="ui-helper-clearfix" style="width:800px; min-height:64px;">
        <div class="ui-helper-clearfix" style="width: 50%; float: left;" id="leftSide">
            <div class="ui-helper-clearfix infoHolder">
                <label style="text-align: left; float:left;">
                    <strong>Full Name:&nbsp;&nbsp;</strong>
                </label>
                <label style="float:left; font-size:12px; font-weight:bold; width:80% !important; min-width:80%;" data-bind="text: colFullName"></label>
            </div>
            <div class="ui-helper-clearfix infoHolder">
                <label style="float:left; margin-right:28px;">
                    <strong>Email:&nbsp;&nbsp;</strong>
                </label>
                <a data-bind="attr: { href: 'mailto:' + colEmail }">
                    <label style="float:left; width:80%; font-size:12px; font-weight:bold; text-decoration:underline; cursor:pointer;" data-bind="text: colEmail"></label>
                </a>
            </div>
            <div class="ui-helper-clearfix infoHolder">
                <label class="infoLabel">
                    <strong>Access Level:</strong>
                </label>
                <label class="infoLabelContent" data-bind="text: colAccessLevel"></label>
            </div>
            <div class="ui-helper-clearfix infoHolder">
                <label class="infoLabel">
                    <strong>Access Level Details:</strong>
                </label>
                <label class="infoLabelContent" style="font-size:10px;" data-bind="text: colAccessLevelDetails"></label>
            </div>
        </div>
        <div class="ui-helper-clearfix" id="rightSide" style="width: 50%; float: left;">
            <div class="ui-helper-clearfix infoHolder">
                <label class="infoLabel">
                    <strong>Status:</strong>
                </label>
                <label class="infoLabelContent" data-bind="text: colActiveUser"></label>
            </div>
            
            <div class="ui-helper-clearfix infoHolder">
                <label class="infoLabelRight">
                    <strong>CC Only:</strong>
                </label>
                <label class="infoLabelContentRight" data-bind="text: colCCOnly"></label>
            </div>
            <div class="ui-helper-clearfix infoHolder">
                <label class="infoLabelRight">
                    <strong>User Creation Date:</strong>
                </label>
                <label class="infoLabelContentRight" data-bind="text: colDateTimeStamp"></label>
            </div>
            <div class="ui-helper-clearfix infoHolder">
                <label class="infoLabelRight">
                    <strong>Last Login Date:</strong>
                </label>
                <label class="infoLabelContentRight" data-bind="text: colLastLogin"></label>
            </div>
        </div>
    </div>
    <div id="CommentHldr">
        <label><strong>Internal Comment:</strong></label>
        <br />
        <textarea data-bind="value: colComments" aria-multiline="true" cols="99" style="border:2px solid #999; font-family:arial; font-size:11px;" readonly="readonly"></textarea>
        <br />
        <label><strong>Client Comment:</strong></label>
        <br />
        <textarea class="editRequired" data-bind="value: colClientComments" aria-multiline="true" cols="99" style="border:2px solid #999; font-size:11px; font-family:Arial;"></textarea>
    </div>
    <div style="text-align:center; margin-bottom:5px; width:650px;">
        <a id="AutoRec" href="#" style="color:#0563c1; font-size:18px;" data-bind="click: onOpenDefinitions"><strong>Auto-Rec Distribution</strong></a>
        <div id="windowDefinitions" style="display:none;">
            <div class="ui-helper-clearfix defRow" style="border-top:none;">
                <span class="defLbl"><strong>Initial Request</strong></span><span class="def">Initial email sent out to the auto-rec recipient.</span>
            </div>
            <div class="ui-helper-clearfix defRow">
                <span style="padding-top:10px;" class="defLbl"><strong>Report Email</strong></span><span class="def">Email confirmation once the auto-rec recipient makes any changes.</span>
            </div>
            <div class="ui-helper-clearfix defRow">
                <span class="defLbl"><strong>1st Follow-Up</strong></span><span class="def">1st follow-up email sent to remind auto-rec recipient to complete responses.</span>
            </div>
            <div class="ui-helper-clearfix defRow">
                <span class="defLbl"><strong>2nd Follow-Up</strong></span><span class="def">2nd follow-up email sent to remind auto-rec recipient to complete responses.</span>
            </div>
            <div class="ui-helper-clearfix defRow">
                <span class="defLbl"><strong>3rd Follow-Up</strong></span><span class="def">3rd and final follow-up email sent to remind auto-rec recipient to complete responses.</span>
            </div>
            <div class="ui-helper-clearfix defRow">
                <span style="padding-top:12px;" class="defLbl"><strong>Exp'd Follow-Up</strong></span><span class="def">Email to auto-rec recipient identifying that there are recomendations where the Expected Complete Data is about to expire, has expired, or is blank.</span>
            </div>
            <div class="ui-helper-clearfix defRow">
                <span style="padding-top:15px;" class="defLbl"><strong>1st Overdue</strong></span><span class="def">Monthly management email identifying all facilities who have received the 1st follow-up and responses are still outstanding.</span>
            </div>
            <div class="ui-helper-clearfix defRow">
                <span style="padding-top:10px;" class="defLbl"><strong>2nd Overdue</strong></span><span class="def">Monthly management email identifying all facilities who have received the 2nd follow-up and responses are still outstanding.</span>
            </div>
            <div class="ui-helper-clearfix defRow">
                <span class="defLbl"><strong>3rd Overdue</strong></span><span class="def">Monthly management email identifying all facilities who have received the 3rd and final follow-up and responses are still outstanding.</span>
            </div>
            <div class="ui-helper-clearfix defRow">
                <span style="padding-top:20px;" class="defLbl"><strong>Exp'd Over- due</strong></span><span class="def">Monthly management email identifying all facilities where there is at least one recommendation with an expected completion date that is now overdue.</span>
            </div>
        </div>
    </div>
    <div id="gridHldr" style="margin-bottom:15px;">
        <div class="xAxis ui-helper-clearfix">
            <label style="float:left; width:59px; text-align:center; padding-top:12px;">Practice</label>
            <label style="float:left; width:55px; text-align:center; padding-top:6px;">Initial<br />Request</label>
            <label style="float:left; width:55px; text-align:center; padding-top:6px;">Report<br />Email</label>
            <label style="float:left; width:55px; text-align:center;">1st<br />Follow-<br />Up</label>
            <label style="float:left; width:55px; text-align:center;">2nd<br />Follow-<br />Up</label>
            <label style="float:left; width:55px; text-align:center;">3rd<br />Follow-<br />Up</label>
            <label style="float:left; width:55px; text-align:center;">Exp'd<br />Follow-<br />Up</label>
            <label style="float:left; width:55px; text-align:center;">1st<br />Over-<br />due</label>
            <label style="float:left; width:55px; text-align:center;">2nd<br />Over-<br />due</label>
            <label style="float:left; width:55px; text-align:center;">3rd<br />Over-<br />due</label>
            <label style="float:left; width:55px; text-align:center;">Exp'd<br />Over-<br />due</label>
        </div>
       <div class="ui-helper-clearfix" data-bind="foreach: { data: arrayPractices }">
           <div class="yAxis">
               <label class="lb_yAxis" data-bind="text: $data.colFldShortName, css: { alt: $index() % 2 }"></label>
           </div>
           <div class="ui-helper-clearfix gridLines">
               <div class="chkBoxCell" data-bind="css: { alt: $index() % 2 }">
                   <input type="checkbox" class="chkRInit editRequired" data-bind="attr: { id: 'init_' + $data.colFldPracticeLetter }, click: function () { $parent.onCheckboxClick($data, $element); }" />
               </div>
               <div class="chkBoxCell" data-bind="css: { alt: $index() % 2 }">
                   <input type="checkbox" class="chkRReport editRequired" data-bind="attr: { id: 'rpt_' + $data.colFldPracticeLetter }, click: function () { $parent.onCheckboxClick($data, $element); }" />
               </div>
               <div class="chkBoxCell" data-bind="css: { alt: $index() % 2 }">
                   <input type="checkbox" class="chkRfu1 editRequired" data-bind="attr: { id: 'FirstFU_' + $data.colFldPracticeLetter }, click: function () { $parent.onCheckboxClick($data, $element); }" />
               </div>
               <div class="chkBoxCell" data-bind="css: { alt: $index() % 2 }">
                   <input type="checkbox" class="chkRfu2 editRequired" data-bind="attr: { id: 'SecondFU_' + $data.colFldPracticeLetter }, click: function () { $parent.onCheckboxClick($data, $element); }" />
               </div>
               <div class="chkBoxCell" data-bind="css: { alt: $index() % 2 }">
                   <input type="checkbox" class="chkRfu3 editRequired" data-bind="attr: { id: 'ThirdFU_' + $data.colFldPracticeLetter }, click: function () { $parent.onCheckboxClick($data, $element); }" />
               </div>
               <div class="chkBoxCell" data-bind="css: { alt: $index() % 2 }">
                   <input type="checkbox" class="chkRExpd editRequired" data-bind="attr: { id: 'ExpdFU_' + $data.colFldPracticeLetter }, click: function () { $parent.onCheckboxClick($data, $element); }" />
               </div>
               <div class="chkBoxCell" data-bind="css: { alt: $index() % 2 }">
                   <input type="checkbox" class="chkROverdue1 editRequired" data-bind="attr: { id: 'FirstOD_' + $data.colFldPracticeLetter }, click: function () { $parent.onCheckboxClick($data, $element); }" />
               </div>
               <div class="chkBoxCell" data-bind="css: { alt: $index() % 2 }">
                   <input type="checkbox" class="chkROverdue2 editRequired" data-bind="attr: { id: 'SecondOD_' + $data.colFldPracticeLetter }, click: function () { $parent.onCheckboxClick($data, $element); }" />
               </div>
               <div class="chkBoxCell" data-bind="css: { alt: $index() % 2 }">
                   <input type="checkbox" class="chkROverdue3 editRequired" data-bind="attr: { id: 'ThirdOD_' + $data.colFldPracticeLetter }, click: function () { $parent.onCheckboxClick($data, $element); }" />
               </div>
               <div class="chkBoxCell" data-bind="css: { alt: $index() % 2 }"> 
                   <input type="checkbox" class="chkRPastDue editRequired" data-bind="attr: { id: 'PastDue_' + $data.colFldPracticeLetter }, click: function () { $parent.onCheckboxClick($data, $element); }" />
               </div>
           </div>
       </div>
    </div>
    <div id="RadioHldr" class="ui-helper-clearfix" style="text-align:center; margin-bottom:10px; width:650px;">
        <input type="radio" id="inactivate" data-bind="    checked: colActionId, attr: { value: radValueInactivate }, click: onActionClick" /><label id="lblRadInactivate" for="inactivate" data-bind="    visible: visibleActionInavtivate">Inactivate User</label>
        <input type="radio" id="activate" data-bind="    checked: colActionId, attr: { value: radValueActivate }, click: onActionClick" /><label id="lblRadActivate" for="activate">Activate User</label>
        <input type="radio" id="delete" data-bind="checked: colActionId, attr: { value: radValueDelete }, click: onActionClick"/><label id="lblRadDelete" for="delete">Delete User</label>
        <a href="#" data-bind="click: function () { onClearSelection(true); }">Clear Selection</a>
    </div>
    <div class="ui-helper-clearfix">
        <div id="actionLinkHldr" style="float:left; width:30%; margin-top:25px;">
            <a href="#" style="float:left; width:100%; text-decoration:underline; cursor:pointer;" data-bind="click: onExtract">Extract User Listing</a>
        </div>
    </div>
    <div id="btnHldr" style="text-align:center; width:650px; height:40px; position:relative;">
        <button id="btnBack" class="btnBack" data-bind="click: onBack, enable: enableButtonPrevious">Back</button>
        <button id="btnNext" class="btnNext" data-bind="click: onNext, enable: enableButtonNext, text: txtButtonNext">Next</button>
    </div>
</div>

<script type="text/javascript">
    $(document).ready(function () {
        $("#windowDefinitions").blur(function () {
            if ($(document.activeElement).closest(".k-window").length == 0) {
                $("#windowDefinitions").data("kendoWindow").close();
            }
        });
    });
</script>

</asp:Content>