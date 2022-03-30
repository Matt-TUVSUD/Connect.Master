<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServer.Master" CodeBehind="NoPreferences.aspx.vb" Inherits="GRC.Connect.Web.NoPreferences" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div id="imageHldr">
            <video class="video-background" autoplay="autoplay" muted="muted" loop="loop" src="../../Home_{{VER}}/Images/Home_{{VER}}/LoginVideo.mp4"></video>
        </div>
        <div id="loginHldr">
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
                <div class="divTable">
                    <%--MAIN TABLE--%>
                    <br />
                    &nbsp;
            <div class="divTable" style="width: 455px; padding: 10px;">
                <label data-bind="text: $parent.objLanguageLabels().lblBody" style="color: Red; font-weight: bold;">At your Risk Management's request, you are unable to change your password.  Please contact your Risk Manager if you have any questions.</label>
                <div>
                    <span class="messageError" style="width: 435px; line-height: 18px; padding-top: 4px; float: left; text-align: center;">
                        <label data-bind="text: $parent.messageErrorPassword"></label>
                    </span>
                </div>
            </div>
                    <br style="clear: both;" />
                    &nbsp;
            <div style="text-align: center">
                <div style="width: 455px; text-align: center;">
                    <button id="btnContinue" data-bind="text: $parent.objLanguageLabels().lblContinue, click: $parent.onContinue, enable: $parent.enableButtons" class="loginBtn">Continue</button>
                </div>
            </div>
                </div>
                <div>
                    <asp:Label ID="lblMessage" runat="server" CssClass="messageErrorLogin"></asp:Label>
                </div>
            </div>

        </div>

    <div style="text-align: center;" id="view" data-bind="with: view">
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            ///////////////////////////////////////////
            //// LOAD SESSION VARIABLES
            var dsLanguageLabels = {
                lblTitle: "Password and Preferences Locked",
                lblBody: "At your Risk Management's request, you are unable to change your password.  Please contact your Risk Manager if you have any questions.",
                lblContinue: "Continue",
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
                //collEzyUsers: new es.objects.EzyUsersCollection(),
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
                },


                onContinue: function () {
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

        });
    </script>



</asp:Content>
