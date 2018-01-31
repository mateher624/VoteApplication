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
        //xhttp.setRequestHeader("Content-type", "application/json");
        request.send(json);
        request.onreadystatechange = processRequest;

        function processRequest(e) {
            if (request.readyState == 4) {
                //var response = JSON.parse(xhttp.responseText);
                document.getElementById("response").innerHTML = request.statusText + ":" + request.status + "<br>" + request.responseText;
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
            <form action="">
                <input type="radio" name="gender" value="male"> Male<br>
                <input type="radio" name="gender" value="female"> Female<br>
                <input type="radio" name="gender" value="other"> Other
            </form>
        </div>
        <div>
            <button type="submit" onclick="UserAction()">Vote</button>
            <div id="response"></div>

        </div>
    </form>
</body>
</html>
