<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PageEvents.aspx.cs" Inherits="First_EmptyPrj.PageEvents" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtwish" runat="server"></asp:TextBox><br />
            <asp:Button ID="Btn_Welcome" runat="server" BackColor="#CC0099" ForeColor="White" Text="Welcome Button" OnClick="Btn_Welcome_Click" />
        </div>
    </form>
</body>
</html>
