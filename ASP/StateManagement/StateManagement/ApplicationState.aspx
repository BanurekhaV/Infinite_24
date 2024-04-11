<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicationState.aspx.cs" Inherits="StateManagement.ApplicationState" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="btnapp" runat="server" Text="Get App Count" OnClick="btnapp_Click" />
            <br />
            <br />
            <asp:Label id="lbl" runat="server" ></asp:Label>
        </div>
    </form>
</body>
</html>
