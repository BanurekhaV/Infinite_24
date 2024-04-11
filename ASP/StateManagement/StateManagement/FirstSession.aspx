<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FirstSession.aspx.cs" Inherits="StateManagement.FirstSession" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           Name : <asp:TextBox ID="txtbox1" runat="server">
            </asp:TextBox> 
            <br />
            <br />
           City :&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtbox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnsession" runat="server" Text="store Session" OnClick="btnsession_Click" />
        </div>
    </form>
</body>
</html>
