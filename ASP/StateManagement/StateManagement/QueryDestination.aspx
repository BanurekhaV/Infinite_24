﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QueryDestination.aspx.cs" Inherits="StateManagement.QueryDestination" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnget" runat="server" Text="Get Data" OnClick="btnget_Click" />
            <br />
            <br />
            <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
