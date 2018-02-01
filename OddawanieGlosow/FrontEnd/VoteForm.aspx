<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VoteForm.aspx.cs" Inherits="OddawanieGlosow.FrontEnd.VoteForm" %>

<!DOCTYPE html>

<script type="text/javascript" language="javascript">

    function UserAction() {
        var options = document.getElementsByName('option');
        var rateValue = 0;
        for (var i = 0; i < options.length; i++) {
            if (options[i].checked) {
                rateValue = options[i].value;
            }
        }
        //var peselValue = document.getElementById("pesel").value;
        var json = "{ \"Pesel\": \"2324456315\", \"PollOptionNumber\": " + rateValue + ", \"PollId\": 1 }";
        var request = new XMLHttpRequest();
        request.open("POST", "http://localhost:30718/api/user/vote", true);
        request.setRequestHeader("Content-type", "application/json");
        request.onreadystatechange = function () {
            if (request.readyState == 4 && request.status == 200) {
                //document.getElementById("header").innerHTML = "OK";
                var response = JSON.parse(request.responseText);
                if (response.StatusCode == 200) {
                    window.location.href = "SuccessVote.html";
                } else {
                    window.location.href = "DeniedVote.html";
                }
            }
        }
        request.send(json);
        
    }

    function onLoadFunctions() {
        var json = "{ \"PollId\": 1 }";
        var request = new XMLHttpRequest();
        request.open("GET", "http://localhost:30718/api/user?pollId=1", true);
        request.setRequestHeader("Content-type", "application/json");
        request.send(json);
        request.onreadystatechange = processRequest;

        function processRequest(e) {
            if (request.readyState == 4) {
                var pollChoices = JSON.parse(request.responseText);
                //document.getElementById("response").innerHTML = request.statusText + ":" + request.status + "<br>" + request.responseText;
                var headerHtml = "<h1>" + pollChoices.Name + "</h1>";
                var descriptionHtml = "<h4>" + pollChoices.Description + "</h4>";
                var listHtml = "<form>";
                for (var key in pollChoices.PollOptions) {
                    listHtml += "<input type=\"radio\" name=\"option\" value=\"" + pollChoices.PollOptions[key].PollOptionNumber + "\">" + pollChoices.PollOptions[key].Name + "<br>";
                }
                listHtml += "</form>";
                document.getElementById("header").innerHTML = headerHtml;
                document.getElementById("description").innerHTML = descriptionHtml;
                document.getElementById("list").innerHTML = listHtml;
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
    <form id="form1" runat="server">
        <div>
        </div>
        <div>
            <div id="header"></div>
            <br />
            <div id="description"></div>
            <br />
            <div id="list"></div>
            <br />
            <button type="submit" onclick="UserAction()">Zagłosuj</button>
            <br />
        </div>
    </form>
</body>
</html>
