<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectWelcomeServer.Master" CodeBehind="WhatsNewClient.aspx.vb" Inherits="GRC.Connect.Web.WhatsNewClient" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Lib_{{VER}}/knockoutkendo/knockout-kendo.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCWhatsNew.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCWhatsNew.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="view" data-bind="with: view">
    
        <input class="" style="width: 300px;" data-bind="kendoDropDownList: {
            data: $parent.KOcollList,
            dataTextField: 'name',
            dataValueField: 'id',
            value: $parent.index,
            close: $parent.onSelect
        }"/>

        <br />&nbsp;<br />

        <div data-bind="html: $parent.notification"></div>

        <br />&nbsp;<br />

        <%--<strong>Markup:</strong><br />
        <div data-bind="text: $parent.notification"></div>--%>

    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            ///////////////////////////////////////////
            //// LOAD LANGUAGE LABELS
            var dsLanguageLabels = {
            };

            ///////////////////////////////////////////
            //// VIEWMODELS
            var viewFindCriteria = {
                findCriteria: ko.observable()
            };
            var view = {
                //// DECLARATIONS
                index: ko.observable(),
                messageError: ko.observable(),
                messageWarning: ko.observable(),
                messageNotice: ko.observable(),
                stateLoadError: false,
                gSafeGuid: getGSafeGUID(),
                collList: new es.objects.ViewCCWhatsNewCollection(),
                KOcollList: ko.observableArray(),
                KOcollDetail: ko.observableArray(),
                notification: ko.observable(),

                //// FUNCTIONS
                loadList: function () {
                    //// LOAD THE LIST OF WHAT'S NEW
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    if (!view.collList.GetWhatsNewList(view.gSafeGuid)) { view.stateLoadError = false } else { view.stateLoadError = true }

                    if (!view.stateLoadError) {
                        //// BUILD ARRAY OF DESCRIPTIONS
                        var tempArray = new Array();
                        for (i = 0; i < view.collList().length; i++) {
                            tempArray.push({
                                id: i,
                                name: view.collList()[i].Description()
                            });
                        }
                        view.KOcollList(tempArray);

                        //// BUILD ARRAY OF ARTICLES
                        tempArray = new Array();
                        for (i = 0; i < view.collList().length; i++) {
                            tempArray.push({
                                id: i,
                                name: view.collList()[i].Notification()
                            });
                        }
                        view.KOcollDetail(tempArray);

                        //// SELECT THE FIRST ARTICLE
                        view.index(0);
                        view.notification(view.KOcollDetail()[view.index()].name);

                    } else {
                        //// DISPLAY ERROR MESSAGE
                        view.messageError("* Error while loading record.");
                        view.stateLoadError = false;
                    }
                },

                onSelect: function () {
                    view.notification(view.KOcollDetail()[view.index()].name);
                }
            };


            ///////////////////////////////////////////
            //// SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
            view.loadList();


            ///////////////////////////////////////////
            //// ACTIVATE BINDINGS LAST
            ko.applyBindings(view, $("#view")[0]);
            //ko.applyBindings(viewFindCriteria, $("#viewFindCriteria")[0]);


            ///////////////////////////////////////////
            //// SETUP KENDOUI

        });
    </script>

</asp:Content>
