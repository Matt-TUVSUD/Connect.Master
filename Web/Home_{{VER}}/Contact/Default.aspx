<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/MasterWithMenu.Master" CodeBehind="Default.aspx.vb" Inherits="GRC.Connect.Web._Default13" %>
<%@ Register TagPrefix="StdHeader" TagName="StdHeader" Src="~/Home_{{VER}}/UserControl/PageStandardHeader.ascx" %>
<%@ Register TagPrefix="grcRSC" TagName="Loader" Src="~/Home_{{VER}}/Controls/Loader.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../css/Contact/contact.css" rel="stylesheet" />
    <script src="../../Lib_{{VER}}/Contact/Contact.js"></script>
    <script src="../../Lib_{{VER}}/pages/comments.js" type="text/javascript"></script>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="viewContacts" class="contactPg">
        <grcRSC:Loader runat="server" id="loader" />
        <div id="contactHldr">
            <div id="msgCenter">
                <span data-bind="text: viewContacts.txtMessage"></span>
            </div>
            <StdHeader:StdHeader runat="server" ID="HeaderUC" Header="Contact Us" SubHeader="" />
            <div id="emailUsHldr">
                <label>
                    Email the 
                    <a href="mailto:grc-ClientDBA@tuvsud.com">TUV SUD GRC Connect Administrators</a>
                </label>
            </div>
            <div id="contactListHldr">
                <div data-bind="foreach: accountContacts">
                    <div class="contactBox">
                        <label class="roleLbl" data-bind="text: $data.colRoleDescriptionPractice"></label>
                        <label class="nameLbl" data-bind="text: $data.colFullName"></label>
                        <label class="numLbl" data-bind="text: $data.colCell"></label>
                        <a class="emailLnk" data-bind="attr: { href: 'mailto:' + $data.colEmail }, text: $data.colEmail"></a>
                    </div>
                </div>
            </div>
            <div class="commentsHldr">
                <div class="commentBoxHeader">
                    <label id="lblCommentsUserFullName" class="windowComments_FullName">Client Connect User</label>, 
                    your feedback is very important to us. The comments you provide will help us improve our level of quality, service and help shape the overall features and functionality of the TUV SUD GRC Connect system.
                </div>
                <textarea class="windowComments_TextArea watermark_TextArea" id="txtFeedbackCommentsText" cols="35" rows="10" maxlength="500" style="margin: 0 auto;">Enter Comments Here</textarea>
                <div style="display:flex; width:100%; justify-content:center; margin-top:10px;">
                    <label id="lblCommentsPleaseWait" style="display: none;">Processing your comments, please wait...</label>
                    &nbsp;&nbsp;
                    <button class="grcBlueBtn" id="btnCommentsSubmit" onclick="onCommentsSubmit(); return false;" disabled="disabled">Submit Comment</button>
                    &nbsp;
                    <button class="grcNeutralBtn" id="btnCommentsCancel" style="width:165px;" onclick="clearCommentBox(); event.preventDefault()">Clear Comment Box</button>
                </div>
                
                <!-- SUCCESS WINDOW -->
                <div id="windowCommentsSuccess" class="windowContent">
                    <div>
                        Your comment has been submitted, thank you.<br />
                        &nbsp;<br />
                        <div style="text-align: center;">
                            <button class="k-button k-button-padding" id="btnCommentsCloseSuccess" onclick="onCommentsHide()">Close</button>
                        </div>
                    </div>
                </div>

                <!-- FAIL WINDOW -->
                <div id="windowCommentsFail" class="windowContent">
                    <div>
                        An error occured when trying to submit your comments, please try again later.<br />
                        &nbsp;<br />
                        Error message:
                        <label id="lblCommentsErrorMessage">none</label><br />
                        &nbsp;<br />
                        <%--<div style="text-align: center;">
                            <button class="k-button k-button-padding" id="btnCommentsCloseFail" onclick="onCommentsHide()">Close</button>
                        </div>--%>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        //// SUCCESS WINDOW
        var windowCommentsSuccess = $("#windowCommentsSuccess");
        windowCommentsSuccess.kendoWindow({
            width: "375px",
            height: "115px",
            title: "", // title added below with JQuery
            actions: ["Close"],
            modal: true
        });
        //$("#windowCommentsSuccess").center().open();
        $("#windowCommentsSuccess").prev().find(".k-window-title").append("<img src='../images/icons/reports/document_information_32x32.png' align='left' alt='Warning Icon' class='windowIcon'/>  Feedback Submitted");

        //// FAIL WINDOW
        var windowCommentsFail = $("#windowCommentsFail");
        windowCommentsFail.kendoWindow({
            width: "325px",
            height: "175px",
            title: "", // title added below with JQuery
            actions: ["Close"],
            modal: true
        });
        $("#windowCommentsFail").closest(".k-window").css({
            top: '45%',
            left: '50%'
        });
        $("#windowCommentsFail").prev().find(".k-window-title").append("<img src='../images/icons/warning/window_warning_16x16.png' align='left' alt='Warning Icon' class='windowIcon'/>  Error");
    </script>
</asp:Content>
