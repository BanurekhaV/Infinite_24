﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuerySource.aspx.cs" Inherits="StateManagement.QuerySource" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbluname" runat="server" Text="User Name"></asp:Label>
            &nbsp; <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
            &nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnRedirect" runat="server" Text="Redirect" OnClick="btnRedirect_Click"  />
        </div>
    </form>
</body>
</html>
