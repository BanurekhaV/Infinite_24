<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="CrossPagePostbacks.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Name :<br />
                    </td>
                    <asp:TextBox ID="txtname" runat="server" />
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="btnsubmit" Text="Move to Next Page" runat="server" PostBackUrl="~/Display.aspx" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
