<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SecurityPrj.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           Login name : <asp:TextBox ID="txtlogin" runat="server"></asp:TextBox>
            <br />
            <br />
           Password :&nbsp;&nbsp; <asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:button id="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click"></asp:button>
            <br />
            <br />
            <asp:Label ID="lblmsg" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
