<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
    <title>Tu IP Pública</title>
</head>
<body>
    <h2>Tu IP Pública es:</h2>
    <p><%= ViewData["IP"] %></p>
</body>
</html>
