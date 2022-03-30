<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/RecResponse_{{VER}}/ClientConnectRecResponseLogin.Master" CodeBehind="Default.aspx.vb" Inherits="GRC.Connect.Web._RecResponse_Logout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div id="view" data-bind="with: view">
    <div style="text-align: center; width: 600px; padding-left: 15px;">
        <h1><label data-bind="text: $parent.objLanguageLabels().lblRecResponse_Logout_ThankYouForUsing">Thank you for using</label> <span class="logoLetters_h1">GRC</span> Connect</h1>
        <br />&nbsp;<br />
        <div style="text-align: left; padding-left: 10px; font-size: 10pt;"><label data-bind="text: $parent.objLanguageLabels().lblRecResponse_Logout_Message">You have successfully logged out. The Recommendation Response Report will be sent to your email.</label></div>
    </div>
</div>

<script type="text/javascript">
    $(document).ready(function () {
        var dsLanguageLabels = {};
        var dsLanguageOptions = [
            dsLanguageLabels.lblChooseLanguage,
            "Deutsch",
            "English",
            "Español",
            "Français",
            "Italiano",
            "Português"
        ];
        var view = {
            preferenceLanguage: "<%= ServerSide_LanguagePreference %>",
            objLanguageLabels: ko.observable(),

            loadLabelTranslations: function (pLanguage) {
                dsLanguageLabels = {};
                var tempLanguage = pLanguage.toLowerCase();
                tempLabelColl = new es.objects.ViewCCTranslationCollection();
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!tempLabelColl.GetTranslationByPage("1|" + tempLanguage)) {
                    switch (tempLanguage) {
                        case "spanish":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].SpanishTranslation();
                            }
                            break;
                        case "german":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].GermanTranslation();
                            }
                            break;
                        case "italian":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].ItalianTranslation();
                            }
                            break;
                        case "portuguese":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].PortugueseTranslation();
                            }
                            break;
                        case "french":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].FrenchTranslation();
                            }
                            break;
                        default:
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].EnglishTranslation();
                            }
                            break;
                    }
                }
                view.objLanguageLabels(dsLanguageLabels);
                dsLanguageOptions[0] = dsLanguageLabels.lblChooseLanguage;
            }
        };

        //// LOAD THE LANGUAGE LABELS
        view.loadLabelTranslations(view.preferenceLanguage);
        ko.applyBindings(view, $("#view")[0]);
    });
</script>

</asp:Content>
