<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VoteForm.aspx.cs" Inherits="OddawanieGlosow.FrontEnd.VoteForm" %>

<!DOCTYPE html>

<script type="text/javascript" language="javascript">
    function UserAction() {
        document.getElementById("response").innerHTML = "<br>Test";
    }

    function onLoadFunctions() {
        var json = "{ \"PollId\": 1 }";
        var request = new XMLHttpRequest();
        request.open("GET", "http://localhost:30718/api/user", true);
        request.setRequestHeader("Content-type", "application/json");
        request.send(json);
        request.onreadystatechange = processRequest;

        function processRequest(e) {
            if (request.readyState == 4) {
                var pollChoices = JSON.parse(request.responseText);
                //document.getElementById("response").innerHTML = request.statusText + ":" + request.status + "<br>" + request.responseText;

                var html = "<form>";
                for (var key in pollChoices.PollOptions) {
                    html += "<input type=\"radio\" name=\"option\" value=\"" + pollChoices.PollOptions[key].PollOptionNumber + "\">" + pollChoices.PollOptions[key].Name + "<br>";
                }
                html += "</form>";
                document.getElementById("response").innerHTML = html;
            }
        }
    }
    window.onload = onLoadFunctions;
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <%--<form>
        <input type="radio" name="option" value="male">
        Male<br>
        <input type="radio" name="option" value="female">
        Female<br>
        <input type="radio" name="option" value="other">
        Other
    </form>--%>
    <form id="form1" runat="server">
        <div>
        </div>
        <div>
            <div id="response"></div>
            <br /><button type="submit" onclick="UserAction()">Vote</button>
        </div>
    </form>
</body>
</html>
