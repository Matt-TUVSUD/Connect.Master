<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="foreach_Test.aspx.vb" Inherits="GRC.Connect.Web.foreach_Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../../Lib_{{VER}}/JQuery/jquery-1.7.1.js"></script>
    <script src="../../Lib_{{VER}}/Knockout/knockout-2.0.0.js"></script>
    <script src="../../Lib_{{VER}}/Data/userReclass.js"></script>
</head>
<body>
    <script>
        $(document).ready(function () {
            var view = {
                name: ko.observable("Matt"),
                listOfNames: ko.observableArray([
                    {
                        first_name: "Matt",
                        last_name: "Feinstein"
                    },
                    {
                        first_name: "Scott",
                        last_name: "Baker"
                    }
                ]),
                practices: ko.observableArray(dsUserReclassPractices.data)
            }

            ko.applyBindings(view, $("#view")[0]);
        })
    </script>

    <div id="view">
        <label data-bind="text:name"></label>
        <ul data-bind="foreach: { data: listOfNames }">
            <li>
                <label data-bind="text: $data.first_name"></label>
            </li>
            <li>
                <label data-bind="text: $data.last_name"></label>
            </li>
        </ul>
        <div data-bind="foreach: {data: practices}">
            <div>
               <label data-bind="text: $data.colFldShortName"></label>
                <input data-bind="attr: { id: 'init_' + $data.colFldPracticeCode }" type="checkbox" />
                <input data-bind="attr: { id: 'rpt_' + $data.colFldPracticeCode }" type="checkbox" />
            </div>
        </div>
    </div>
</body>
</html>
