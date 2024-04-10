<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HiddenFields.aspx.cs" Inherits="StateManagement.HiddenFields" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lbllogin" runat="server" Text="Login"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtlogin" runat="server"></asp:TextBox>
            <asp:HiddenField ID="HiddenField1" runat="server" />
            <br />
            <br />
            <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
            &nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            <asp:HiddenField ID="HiddenField2" runat="server" />
            <br />
            <br />
            <br />
            <asp:Button ID="btnstore" runat="server" Text="Store" OnClick="btnstore_Click" />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="btnload" runat="server" Text="Load" OnClick="btnload_Click" />
            <br />
            <br />
            <asp:Label ID="lblmsg" runat="server" Text=" "></asp:Label>
        </div>
    </form>
</body>
</html>
