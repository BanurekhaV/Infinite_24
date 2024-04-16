<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebClient.aspx.cs" Inherits="WebServicesClient.WebClient" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       Enter Your Name :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
        <br />
       Enter a Real Number : <asp:TextBox ID="txtnum" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnhello" runat="server" Text="For Hello" OnClick="btnhello_Click" />
        <asp:Button ID="btnmsg" runat="server" Text="For User Wish" OnClick="btnmsg_Click" />
        <asp:Button ID="btnsquare" runat="server" Text="For Square" OnClick="btnsquare_Click" />
        <br /><br />
        <asp:Label ID="lbl1" runat="server" ></asp:Label>

    </form>
</body>
</html>
