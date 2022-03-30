<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServer.Master" CodeBehind="Password.aspx.vb" Inherits="GRC.Connect.Web.Password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Lib_{{VER}}/Generated/EzyUsers.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/EzyUsers.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
        <div id="imageHldr">
            <video class="video-background" autoplay="autoplay" muted="muted" loop="loop" src="../../Home_{{VER}}/Images/Home_{{VER}}/LoginVideo.mp4"></video>
        </div>
        <div id="loginHldr">
            <span id="view" data-bind="with: view">
            <div class="maintenanceMsgHldr" style="">
                <asp:Label runat="server" ID="lblMessageMaintenance" CssClass="loginMessageError"></asp:Label>
            </div>
            <div id="logoHldr">
                <img src="../../Home_{{VER}}/Images/logos/StackedLogo_Vertical_Clear.png" />
            </div>
            <div id="tagLine">
                <p>
                    Stay Connected to Your<br />
                    Loss Control Information.
                </p>
            </div>
            <div class="userHldr">
                <!-- CONFIRMATION WINDOW -->
                <div id="windowPassword" class="windowContent" style="display:none;">
                    <div class="">
                        <span data-bind="html: $parent.messageWindow">Your Display Name and Password have not been changed.</span>
                    </div>
                    <br />
                    <div style="text-align: center;">
                        <button class="k-button k-button-padding" id="btnClose" data-bind="click: $parent.onClose">Close</button>
                    </div>
                </div>
                <h1>Edit Display Name and Password</h1>
                <label class="messageNotice" data-bind="text: $parent.objLanguageLabels().lblPasswordResetMessage"></label>
                <div class="divTable">
                    <%--DISPLAY NAME AND EMAIL INFORMATION TABLE--%>
                    <div class="divTable borderBottom borderLeft borderTop borderRight" style="width: 455px; padding: 10px;">
                        <b>
                            <label data-bind="text: $parent.objLanguageLabels().lblChangeAccountInformation">Change Display Name</label></b>
                        <div>
                            <span class="preferenceLbl" style="width:185px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblEmailAddress">Email Address</label>: 
                            </span>
                            <span>
                                <input data-bind="value: $parent.email" id="email" class="textInput" readonly="readonly" disabled="disabled" />
                            </span>
                        </div>
                        <div>
                            <span class="preferenceLbl" style="width:185px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblEnterYourDisplayName">Enter Your Display Name</label>: 
                            </span>
                            <span>
                                <input data-bind="value: $parent.displayName" id="displayName" class="textInput" />
                            </span>
                        </div>
                        <div>
                            <span class="messageError" style="width: 435px; line-height: 18px; padding-top: 4px; float: left; text-align: center;">
                                <label data-bind="text: $parent.messageErrorName"></label>
                            </span>
                        </div>
                    </div>
                    <%--PASSWORD TABLE--%>
                    
                    <div class="divTable borderBottom borderLeft borderTop borderRight" style="width: 455px; padding: 10px;">
                        <b>
                            <label data-bind="text: $parent.objLanguageLabels().lblChangeYourPassword">Change Your Password</label>
                        </b>
                        <div>
                            <span class="preferenceLbl" style="width:185px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblEnterNewPassword">Enter New Password</label>: 
                            </span>
                            <span>
                                <input data-bind="value: $parent.passwordNew" id="passwordNew" class="textInput" type="password" autocomplete="off" />
                            </span>
                        </div>
                        <div>
                            <span class="preferenceLbl" style="width:185px;">
                                <label data-bind="text: $parent.objLanguageLabels().lblConfirmNewPassword">Confirm New Password</label>: 
                            </span>
                            <span>
                                <input data-bind="value: $parent.passwordConfirm" id="passwordConfirm" class="textInput" autocomplete="off" type="password" />
                            </span>
                        </div>
                        <div>
                            <span class="messageError" style="width: 435px; line-height: 18px; padding-top: 4px; float: left; text-align: center;">
                                <label data-bind="text: $parent.messageErrorPassword"></label>
                            </span>
                        </div>
                    </div>
                    <div style="text-align: center">
                        <div style="width: 455px; text-align: center;">
                            <button id="btnAccept" data-bind="text: $parent.objLanguageLabels().lblAccept, click: $parent.onAccept, enable: $parent.enableButtons" class="loginBtn">Accept</button>
                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <button id="btnCancel" data-bind="text: $parent.objLanguageLabels().lblCancel, click: $parent.onCancel, enable: $parent.enableButtons" class="loginBtn">Cancel</button>
                        </div>
                    </div>
                </div>

                
            </div>
            <div>
                <asp:Label ID="lblMessage" runat="server" CssClass="messageErrorLogin"></asp:Label>
            </div>
            </span>
        </div>
    
    <%--<div id="view" data-bind="with: view">
    </div>    --%>

    <script type="text/javascript">
        $(document).ready(function () {
            ///////////////////////////////////////////
            //// LOAD SESSION VARIABLES
            var dsLanguageLabels = {
                //// LABELS
                lblChangeAccountInformation: "Change Display Name",
                lblEmailAddress: "Email Address",
                lblEnterYourDisplayName: "Enter Your Display Name",
                lblChangeYourPassword: "Change Your Password",
                lblEnterNewPassword: "Enter New Password",
                lblConfirmNewPassword: "Confirm New Password",
                //// MISC
                lblAccept: "Accept",
                lblCancel: "Cancel",
                lblInstructions: "",
                //// WINDOWS
                lblWindowTitle: "Change Account Information",
                lblYourDisplayNameHasBeenChanged: "Your Display Name has been changed",
                lblYourDisplayNameHasNotBeenChanged: "Your Display Name has NOT been changed",
                lblYourPasswordHasBeenChanged: "Your Password has been changed",
                lblYourPasswordHasNotBeenChanged: "Your Password has NOT been changed",
                lblThankYouForChangingYourDetails: "Thank you for changing your details. The following information has been updated",
                lblWindowCancelMessage: "Your Display Name and Password have not been changed and you will be returned to the login process",
                //// ERROR AND OTHER MESSAGES
                lblErrorNoDisplayName: "Please enter a display name",
                //lblErrorPasswordMatch: "The new and confirm passwords do not match, please reenter passwords and try again",
                lblErrorPasswordMatch: "The New and Confirm passwords do not match. Please re-enter your passwords and try again.",
                lblErrorLookup: "An error occured while looking up your record. Please try again later",
                lblErrorPasswordExists: "The password you are trying to save already exists for a user with the same email address. Please try a different password",
                //lblErrorNoInfoChanged: "No information has been changed. To go back please click the Cancel button",
                lblErrorNoInfoChanged: "No changes have been made. Click in the yellow highlighted fields to make a change, or click Cancel",
                lblErrorNotStrongEnough: "The password you have entered does not meet the strength requirements. Reason: ",
                lblErrorSave: "An error occured while trying to save your record. Please try again later",
                lblPasswordResetMessage: "<%= ServerSide_PasswordResetMessage %>"
            };


            ///////////////////////////////////////////
            //// VIEWMODEL
            var view = {
                //// DECLARATIONS
                messageErrorPassword: ko.observable(),
                messageErrorName: ko.observable(),
                messageWarning: ko.observable(),
                messageNotice: ko.observable(),
                messageWindow: ko.observable(),
                messagePasswordStrengthReason: "",

                //// GSAFE / CLIENT FEATURES / LANGUAGES
                gSafeGuid: getQueryVariable('sid'),
                objLanguageLabels: ko.observable(dsLanguageLabels),
                collEzyUsers: new es.objects.EzyUsersCollection(),
                objEzyUsers: ko.observable(),

                //// GSAFE FIELDS
                email: ko.observable(),
                displayName: ko.observable(),
                displayNameOriginal: "",
                passwordNew: ko.observable(),
                passwordConfirm: ko.observable(),
                passwordSave: "",

                //// MISC
                enableButtons: ko.observable(true),
                isPasswordChanged: false,
                isDisplayNameChanged: false,
                isPasswordChangeSuccess: false,
                success: false,

                //// LOAD DEFAULTS FROM THE GSAFE
                loadDefaults: function () {
                    var tempEmail = "<%= ServerSide_Email %>";
                    var tempDisplayName = "<%= ServerSide_DisplayName %>";
                    var tempDisplayNameOriginal = "<%= ServerSide_DisplayName %>";
                    view.email(tempEmail);
                    view.displayName(tempDisplayName);
                    view.displayNameOriginal = tempDisplayName;
                },

                onAccept: function () {
                    //// RESET THE MESSAGES
                    view.messageErrorName(" ");
                    view.messageErrorPassword(" ");
                    view.messagePasswordStrengthReason = "unknown";

                    //// CHECK IF THE DISPLAY NAME IS BLANK
                    if (view.displayName() != undefined && view.displayName() != "") {

                        //// CHECK IF PASSWORDS MATCH
                        if (view.passwordNew() == view.passwordConfirm()) {

                            //// CHECK IF THE PASSWORD ALREADY EXISTS
                            var tempParms = ""
                            if (view.passwordNew() == undefined) { tempParms = view.gSafeGuid + "|" + ""; } else { tempParms = view.gSafeGuid + "|" + view.passwordNew(); }
                            es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                            if (!view.collEzyUsers.isPasswordExist(tempParms)) {
                                if (view.collEzyUsers()[0].Password() != "true") {

                                    //// LOCK THE NEW PASSWORD IN AN UNEXPOSED VARIABLE AND PROTECT AGAINST UNDEFINED
                                    if (view.passwordConfirm() == undefined) { view.passwordSave = ""; } else { view.passwordSave = view.passwordConfirm(); }
                                    //// CHECK IF THE DISPLAY NAME AND PASSWORD ACTUALLY CHANGED
                                    if (view.displayName() != view.displayNameOriginal || view.passwordSave != "") {
                                        if (view.displayName() == view.displayNameOriginal) { view.isDisplayNameChanged = false; } else { view.isDisplayNameChanged = true }
                                        if (view.passwordSave == "") { view.isPasswordChanged = false; } else { view.isPasswordChanged = true; }

                                        //// SAVE THE RECORD
                                        if (view.validatePasswordStrength()) {
                                            view.saveRecord();
                                            view.success = true;

                                            //// VALIDATION EXCEPTIONS
                                        } else {
                                            view.messageErrorPassword(view.objLanguageLabels().lblErrorNotStrongEnough + view.messagePasswordStrengthReason + "");
                                        }
                                    } else {
                                        view.messageErrorPassword(view.objLanguageLabels().lblErrorNoInfoChanged + ".");
                                    }
                                } else {
                                    view.messageErrorPassword(view.objLanguageLabels().lblErrorPasswordExists + ".");
                                }
                            } else {
                                view.messageErrorPassword(view.objLanguageLabels().lblErrorLookup + ".");
                            }
                        } else {
                            view.messageErrorPassword(view.objLanguageLabels().lblErrorPasswordMatch + ".");
                        }
                    } else {
                        view.messageErrorName(view.objLanguageLabels().lblErrorNoDisplayName + ".");
                    }

                    //// DISPLAY A WINDOW AND A MESSAGE
                    if (!view.success) {
                        //// DO NOTHING, FOR FUTURE USE
                    }
                },

                validatePasswordStrength: function () {
                    var zReturn = false;

                    //// CALL THE SERVER SIDE EMAIL HANDLER, IF RESPONSE IS SUCCESS THEN OPEN SUCCESS WINDOW, ELSE OPEN FAIL WINDOW
                    var zEmail = "<%= ServerSide_Email %>";
                    var zPassword = view.passwordSave;

                    $.ajax({
                        type: "GET",
                        url: "../Preference/ValidateIt.ashx",
                        data: {
                            Email: zEmail,
                            Password: zPassword
                        },
                        contentType: "application/json; charset=utf-8",
                        dataType: "text",
                        async: false,
                        success: function (data, status) {
                            if (data.toString().toLowerCase() == "valid") {
                                zReturn = true;
                                view.messageErrorPassword("");
                                view.messagePasswordStrengthReason = "";
                                view.isPasswordChangeSuccess = true;
                            } else {
                                zReturn = false;
                                view.messagePasswordStrengthReason = data.toString();
                                view.messageErrorPassword(view.objLanguageLabels().lblErrorNotStrongEnough + "unknown");
                                view.isPasswordChangeSuccess = false;
                            }
                        },
                        error: function () {
                            zReturn = false;
                            view.isPasswordChangeSuccess = false;
                            view.messagePasswordStrengthReason = data.toString();
                            view.messageErrorPassword(view.objLanguageLabels().lblErrorNotStrongEnough + "unknown");
                        }
                    });

                    return zReturn;
                },

                saveRecord: function () {
                    //// IF NO PASSWORD ENTERED, DO NOT SAVE PASSWORD AND CONFIRM TO USER
                    //// IF DISPLAY NAME DID NOT CHANGE, CONFIRM TO USER
                    var newLine = "<br />";
                    var bullet = " &bull; ";
                    var tempParms = view.gSafeGuid + "|" + view.displayName() + "|" + view.passwordSave;
                    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                    if (!view.collEzyUsers.setEzyUserPassword(tempParms)) {
                        //// BUILD CONFIRMATION MESSAGE AND DISPLAY WINDOW
                        var msg1 = "";
                        var msg2 = "";
                        if (view.isDisplayNameChanged) { msg1 = bullet + view.objLanguageLabels().lblYourDisplayNameHasBeenChanged + "." + newLine; } else { msg1 = bullet + view.objLanguageLabels().lblYourDisplayNameHasNotBeenChanged + "." + newLine; }
                        if (view.isPasswordChanged) { msg2 = bullet + view.objLanguageLabels().lblYourPasswordHasBeenChanged + "." + newLine; } else { msg2 = bullet + view.objLanguageLabels().lblYourPasswordHasNotBeenChanged + "." + newLine; }
                        view.messageWindow(view.objLanguageLabels().lblThankYouForChangingYourDetails + ":" + newLine + newLine + msg1 + msg2);
                        view.enableButtons(false);
                        windowPassword.open();
                        //$("#windowPassword").css("display", "block");
                    } else {
                        //// DISPLAY AN ERROR MESSAGE
                        view.messageErrorPassword(view.objLanguageLabels().lblErrorSave + ".");
                    }
                },

                onCancel: function () {
                    //// RESET THE MESSAGES
                    view.messageErrorName(" ");
                    view.messageErrorPassword(" ");

                    //// DISPLAY THE WINDOW
                    view.messageWindow(view.objLanguageLabels().lblWindowCancelMessage + ".");
                    windowPassword.open();
                    //$("#windowPassword").css("display", "block");
                },

                onClose: function () {
                    //// NAVIGATE BACK TO THE SWITCH PAGE
                    var zMSG = "<%= ServerSide_PasswordResetMessage %>";
                    if (zMSG.length > 0 && view.isPasswordChangeSuccess == false) {
                        document.location.href = "../Auth/Default.aspx";
                    } else {
                        var isAdmin = "<%= ServerSide_IsAdminUser %>";
                        if (isAdmin.toLowerCase() == "false") {
                            document.location.href = "../Switch/Default.aspx?sid=" + view.gSafeGuid;
                        } else {
                            var parm = getQueryVariable("p1");
                            if (parm == "1") {
                                document.location.href = "../Switch/Default.aspx?sid=" + view.gSafeGuid;
                            } else if (parm == "2") {
                                document.location.href = "../Switch/SwitchIntegrated.aspx?sid=" + view.gSafeGuid;
                            } else {
                                document.location.href = "../Switch/Default.aspx?sid=" + view.gSafeGuid;
                            }
                        }
                    }
                }
            };


            ///////////////////////////////////////////
            //// SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
            view.loadDefaults();


            ///////////////////////////////////////////
            //// ACTIVATE BINDINGS LAST
            ko.applyBindings(view, $("#view")[0]);


            ///////////////////////////////////////////
            //// SETUP KENDOUI
            //// WINDOWS
            var windowPassword;
            $("#windowPassword").kendoWindow({
                width: "325px",
                height: "150px",
                title: "", // title added below with JQuery
                actions: false,
                modal: true,
                resizable: false
            });
            windowPassword = $('#windowPassword').data("kendoWindow");
            $("#windowPassword").closest(".k-window").css({
                top: 250,
                left: 400
            });
            $("#windowPassword").prev().find(".k-window-title").append("<img src='../images/icons/admin/businesswoman_24x24.png' align='left' alt='Account Information' class='windowIcon'/>  " + view.objLanguageLabels().lblWindowTitle);


            ///////////////////////////////////////////
            //// KEYBOARD LISTENERS TO PREVENT ENTERING OF INVALID CHARS
            $("#email").keydown(function (e) {
                // DO NOT ALLOW PIPES "|" OR CARROTS "<" ">"
                if ((e.shiftKey && e.keyCode == 220) || (e.shiftKey && e.keyCode == 190) || (e.shiftKey && e.keyCode == 188)) {
                    e.preventDefault();
                }
            });
            $("#displayName").keydown(function (e) {
                // DO NOT ALLOW PIPES "|" OR CARROTS "<" ">"
                if ((e.shiftKey && e.keyCode == 220) || (e.shiftKey && e.keyCode == 190) || (e.shiftKey && e.keyCode == 188)) {
                    e.preventDefault();
                }
            });
            $("#passwordNew").keydown(function (e) {
                // DO NOT ALLOW PIPES "|" OR CARROTS "<" ">"
                if ((e.shiftKey && e.keyCode == 220) || (e.shiftKey && e.keyCode == 190) || (e.shiftKey && e.keyCode == 188)) {
                    e.preventDefault();
                }
            });
            $("#passwordConfirm").keydown(function (e) {
                // DO NOT ALLOW PIPES "|" OR CARROTS "<" ">"
                if ((e.shiftKey && e.keyCode == 220) || (e.shiftKey && e.keyCode == 190) || (e.shiftKey && e.keyCode == 188)) {
                    e.preventDefault();
                }
            });

        });
    </script>



</asp:Content>
