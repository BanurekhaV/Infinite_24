<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomForm.aspx.cs" Inherits="ValidationsPrj.CustomForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" lang="javascript">
        function IsEven(source, args) {
            if (args.Value == "") {
                args.IsValid = false;
            } else {
                if ((args.Value > 0) && (args.Value % 2 == 0)) {
                    args.IsValid = true;
                    //Btnsave.Enabled = true;
                   // var i = document.getElementById('<%= Btnsave.ClientID %>');//.Enabled = true;
                    var i = document.getElementById('Btnsave');
                    alert(i);
                    i.Enabled = true;
                }
                else {
                    args.IsValid = false;
                }
            }
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
            <input type="button" runat="server" onclick="IsEven(s,e)" value="Validate"/>
            <asp:Button ID="Btnsave" runat="server" ClientIDMode="Static" Text="Save" OnClick="Btnsave_Click"  Enabled="false" />
            <br />
            <br />
            <asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label>
            
            <br />
            
        </div>
    </form>
</body>
</html>
