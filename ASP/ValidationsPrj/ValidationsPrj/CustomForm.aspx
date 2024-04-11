<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomForm.aspx.cs" Inherits="ValidationsPrj.CustomForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" lang="javascript">
        function IsEven(source, args) {

        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please Enter a Positive Even Number &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtnum" runat="server"></asp:TextBox>
            
        &nbsp;
            <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtnum" 
            ErrorMessage="Not a Positive or Even Number" ForeColor="Red" OnServerValidate="CustomValidator1_ServerValidate"
            ValidateEmptyText="True" ClientValidationFunction="IsEven"></asp:CustomValidator>
            <br />
            <br />
            <asp:Button ID="Btnsave" runat="server" Text="Save" OnClick="Btnsave_Click" />
            <br />
            <br />
            <asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label>
            
            <br />
            
        </div>
    </form>
</body>
</html>
