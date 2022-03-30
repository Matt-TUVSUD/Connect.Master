 

<% @LANGUAGE="VBScript" AspCompat="true" %>
<% Response.buffer = true %>

<%



dim destURL
dim payload
dim strResponse
dim token
dim accesstokenlocation
dim refreshtokenlocation

destURL = "https://login.microsoftonline.com/common/oauth2/token"

'Construct the Post Data
payload = "grant_type=" & server.URLencode("password")   
payload = payload & "&client_id=" & server.URLencode("37730b0c-4468-422c-a18d-bd33efc88065")
payload = payload & "&resource=" & server.URLencode("https://analysis.windows.net/powerbi/api")
payload = payload & "&username=" & server.URLencode("spradhan@2tuvit.onmicrosoft.com")
payload = payload & "&password=" & server.URLencode("Zaz95953")

'Construct the useragent and send

Dim http_obj As New Object()
http_obj = server.CreateObject("MSXML2.ServerXMLHTTP")
http_obj.Open("POST", destURL , false)
http_obj.setRequestHeader("Content-Type", "application/x-www-form-urlencoded")
http_obj.send(payload)


'Grab the response
strResponse = http_obj.ResponseText
accesstokenlocation = InStr(strResponse,"access_token")
accesstokenlocation = accesstokenlocation + 15
refreshtokenlocation = InStr(strResponse,"refresh_token")

token = mid(strResponse, accesstokenlocation, refreshtokenlocation - accesstokenlocation - 3)
'response.write (accesstokenlocation)
'response.write ("<br /><br />")
'response.write (refreshtokenlocation)




http_obj=nothing
'response.write (token)
'response.write ("<br /><br />")
'Response.write(strResponse)
'Response.end


' <iframe width="1140" height="541.25" src="https://app.powerbi.com/reportEmbed?reportId=344bc039-27a9-43c5-be7d-df650b9ba3e6&autoAuth=true&ctid=a1109567-0815-4e1f-88af-e23555482aaa&config=eyJjbHVzdGVyVXJsIjoiaHR0cHM6Ly93YWJpLW5vcnRoLWV1cm9wZS1yZWRpcmVjdC5hbmFseXNpcy53aW5kb3dzLm5ldC8ifQ%3D%3D" frameborder="0" allowFullScreen="true"></iframe>



%>
<html>
<header>
<title></title>
<script src="https://microsoft.github.io/PowerBI-JavaScript/demo/node_modules/jquery/dist/jquery.js"></script>
<script src="https://microsoft.github.io/PowerBI-JavaScript/demo/node_modules/powerbi-client/dist/powerbi.js"></script>
<script type="text/javascript">

window.onload = function () {


        var basicFilter = {
                 $schema: "http://powerbi.com/product/schema#basic",
                 target: {
                         table: "DimLocation",
                         column: "FilePrefix"
                 },
                 operator: "In",
                 values: ["1001"]
         }

         var embedConfiguration = {
             type: 'report',
             accessToken: '<% =token %>',
             embedUrl: 'https://app.powerbi.com/reportEmbed?reportId=96006342-b5b3-49e2-af20-f5338ebfddfd&groupId=310ef826-18fc-45c5-b642-21c5120f9a5a',
             id:'96006342-b5b3-49e2-af20-f5338ebfddfd',
             filters: [basicFilter],
             settings: {
             filterPaneEnabled: false
         }
 };
 var $reportContainer = $('#dashboardContainer');
 var report = powerbi.embed($reportContainer.get(0), embedConfiguration);
 }




function reloadreport(){
 var element = $('#dashboardContainer');
 alert(element);
 var report = powerbi.get(element);
 report.reload().catch(error => {console.log(error) });
 };
 </script>
</header>

<body>
 <div id="dashboardContainer"></div>
</body>
</html>