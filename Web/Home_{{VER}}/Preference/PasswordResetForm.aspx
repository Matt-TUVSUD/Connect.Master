<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServer.Master" CodeBehind="PasswordResetForm.aspx.vb" Inherits="GRC.Connect.Web.PasswordResetForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Lib_{{VER}}/Generated/EzyUsers.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/EzyUsers.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--<div id="imageHldr">
        <video class="video-background" autoplay="autoplay" muted="muted" loop="loop" src="../../Home_{{VER}}/Images/Home_{{VER}}/LoginVideo.mp4"></video>
    </div>--%>
    <div class="loginImgHldr">
            <img class="loginImg" src="../Images/loginSplash.png" />
        </div>
    <div id="loginHldr" style="height:700px;">
        <div class="maintenanceMsgHldr" style="">
            <asp:Label runat="server" ID="lblMessageMaintenance" CssClass="loginMessageError"></asp:Label>
        </div>
        <%--<div id="logoHldr">
            <img src="../../Home_{{VER}}/Images/logos/StackedLogo_Vertical_Clear.png" />
        </div>
        <div id="tagLine">
            <p>Stay Connected to Your<br />
                Loss Control Information.</p>
        </div>--%>
        <h1 style="text-align:center;">Reset Your Password</h1>
        <div class="userHldr">
            <%--ENTER YOUR EMAIL ADDRESS--%>
            <div ID="divEnterEmailAddress" runat="server" style="margin-bottom:10px;" class="ui-helper-clearfix">
                <div>
                    <span class="preferenceLbl" style="width:185px; color:#666;">
                        <label data-bind="text: $parent.objLanguageLabels().lblEmailAddress">Email Address</label>: 
                    </span>
                    <span class="emailHldr">
                        <asp:TextBox ID="txtEmail" runat="server" ClientIDMode="Static" CssClass="textInput" Enabled="false"></asp:TextBox>
                    </span>
                </div>
            </div>

            <%--REVISE DISPLAY NAME TABLE--%>
            <div ID="divDisplayName" runat="server" class="ui-helper-clearfix">
                <div>
                    <span class="preferenceLbl" style="width:185px; color:#666;">
                        <label data-bind="text: $parent.objLanguageLabels().lblReviseDisplayName">Revise Your Display Name</label>: 
                    </span>
                    <span>
                        <asp:TextBox ID="txtDisplayName" runat="server" ClientIDMode="Static" CssClass="textInput" Enabled="false"></asp:TextBox>
                    </span>
                </div>
            </div>

            <%--CHANGE PASSWORD TABLE--%>
            <div ID="div1" runat="server" class="ui-helper-clearfix" style="margin:10px 0;">
                <div class="ui-helper-clearfix">
                    <span style=" font-family:Arial, sans-serif; color: #000; margin:0 auto; font-size:12px; font-weight:700;">
                        <label data-bind="text: $parent.objLanguageLabels().lblPasswordDesc">Your password must be a minimum length of 8 characters and the following four conditions must be met:</label>
                        <ul style="list-style: none;">
                            <li><label data-bind="text: $parent.objLanguageLabels().lblPasswordCondition01">Upper case letters</label></li>
                            <li><label data-bind="text: $parent.objLanguageLabels().lblPasswordCondition02">Lower case letters</label></li>
                            <li><label data-bind="text: $parent.objLanguageLabels().lblPasswordCondition03">Special characters, such as !@#$%^&*()</label></li>
                            <li><label data-bind="text: $parent.objLanguageLabels().lblPasswordCondition04">Numerical digits</label></li>
                        </ul>
                    </span>
                </div>
                <div class="ui-helper-clearfix" style="margin-bottom:10px;">
                    <span class="preferenceLbl" style="width:185px; color:#666">
                        <label data-bind="text: $parent.objLanguageLabels().lblEnterNewPassword">Enter New Password</label>: 
                    </span>
                    <span class="emailHldr">
                        <asp:TextBox ID="txtPasswordNew" runat="server" autocomplete="off" TextMode="Password" ClientIDMode="Static" CssClass="textInput" Enabled="false"></asp:TextBox>
                    </span>
                </div>
                <div class="ui-helper-clearfix">
                    <span class="preferenceLbl" style="width:185px; color:#666">
                        <label data-bind="text: $parent.objLanguageLabels().lblConfirmNewPassword">Confirm New Password</label>: 
                    </span>
                    <span class="emailHldr">
                        <asp:TextBox ID="txtPasswordConfirm" runat="server" autocomplete="off" TextMode="Password" ClientIDMode="Static" CssClass="textInput" Enabled="false"></asp:TextBox>
                    </span>
                </div>
            </div>

            <%-- BUTTON AREA --%>
            <div ID="divButtons" runat="server">
                <div style="display:flex; flex-direction:column; justify-content:flex-start; align-items:flex-start; margin-top:10px;">
                    <asp:Button ID="btnAccept" runat="server" style="margin-bottom:10px;" CssClass="loginBtn" Text="Accept" />
                    <asp:Button ID="btnCancel" runat="server" CssClass="loginBtn" Text="Cancel" />
                </div>
            </div>

            <%-- MESSAGE AREA --%>
            <div ID="divMessage" runat="server" class="divTable" style="width:475px;">
                <div style="text-align: center">
                    <span class="messageError" style="width: 100%; font-family:Arial, sans-serif; color:#ff0000; line-height: 18px; padding-top: 4px; float: left; text-align: center;"><asp:Label ID="lblMessage" runat="server" Text=""></asp:Label></span>
                </div>
            </div>
        </div>
        
    </div>

    <div style="text-align: center;" id="view" data-bind="with: view">

    </div>    

    <script type="text/javascript">
        $(document).ready(function () {
            // LANGUAGE LABELS
            var dsLanguageLabels = {
                lblEmailAddress: "Email Address",
                lblEnterYourEmailAddress: "Please enter your email address.",
                lblReviseDisplayName: "Revise Your Display Name",
                lblEnterNewPassword: "Enter New Password",
                lblConfirmNewPassword: "Confirm New Password",
                lblPasswordDesc: "Your password must be a minimum length of 8 characters and the following four conditions must be met:",
                lblPasswordCondition01: "Upper case letters",
                lblPasswordCondition02: "Lower case letters",
                lblPasswordCondition03: "Special characters, such as !@#$%^&*()",
                lblPasswordCondition04: "Numerical digits"
            };

            
            // VIEWMODEL
            var view = {
                // DECLARATIONS
                objLanguageLabels: ko.observable(dsLanguageLabels),

                // LOAD DEFAULTS FROM THE GSAFE
                loadDefaults: function () {
                }
            };


            // SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
            view.loadDefaults();


            // ACTIVATE BINDINGS LAST
            ko.applyBindings(view, $("#view")[0]);

        });
    </script>



</asp:Content>
