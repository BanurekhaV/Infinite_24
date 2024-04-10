<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewState.aspx.cs" Inherits="StateManagement.ViewState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbluname" runat="server" Text="User Name"></asp:Label>
            &nbsp;<asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
            &nbsp;&nbsp;<asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnstore" runat="server" Text="Store" OnClick="btnstore_Click" />
            <asp:Button ID="btnload" runat="server" Text="Load" OnClick="btnload_Click" />
            <br />
            <br />
            <asp:Label ID="lblmsg" runat="server" Text=" "></asp:Label>
        </div>
    </form>
</body>
</html>
