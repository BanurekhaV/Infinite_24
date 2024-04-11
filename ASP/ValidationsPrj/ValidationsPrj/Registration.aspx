<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="ValidationsPrj.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="color:blue;font-size:20px;text-align:center;">Registration Form </h1>
            <br />
            Name &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtname" runat="server" ></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="txtname" ErrorMessage="Name Cannot Be Blank" ForeColor="Red" ValidationGroup="regngrp">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Password : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtpass" ErrorMessage="Password is a Must" ForeColor="Red" ValidationGroup="regngrp">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Confirm Password : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtconfpass" runat="server"></asp:TextBox>

            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
          ControlToValidate="txtconfpass" ErrorMessage="Please enter confirm password" ForeColor="Red" Display="Dynamic" ValidationGroup="regngrp">*</asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" 
       ControlToCompare="txtpass" ControlToValidate="txtconfpass" ErrorMessage="Password and confirm password does not match" ForeColor="Red" Display="Dynamic" ValidationGroup="regngrp">*</asp:CompareValidator>
            <br />

            <br />
            Age  : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtage" runat="server" TextMode="Number"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtage" ErrorMessage="Please enter your Age" ForeColor="Red" Display="Dynamic" ValidationGroup="regngrp">*</asp:RequiredFieldValidator>
            
            &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtage" Display="Dynamic" ErrorMessage="Age has to be between 20 and 30 only" ForeColor="Red" MaximumValue="30" MinimumValue="20" Type="Integer" ValidationGroup="regngrp">*</asp:RangeValidator>
            
            <br />
            <br />
            Email : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtemail" runat= "server" ></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtemail" ErrorMessage="You have to give Email Id" ForeColor="Red" Display="Dynamic" ValidationGroup="regngrp">*</asp:RequiredFieldValidator>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" Display="Dynamic" ErrorMessage="Email Id is invalid" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="regngrp">*</asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="btnregister" runat="server" Text="Register" OnClick="btnregister_Click" ValidationGroup="regngrp" />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" ValidationGroup="regngrp" />
        </div>
        <hr />
        <div>
            <h1 style="color:red;font-size:20px;text-align:center">Login Form</h1>
            <br />
            Login name : &nbsp;&nbsp;<asp:TextBox ID="txtlogin" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtlogin" ErrorMessage="Login name must" ForeColor="Red" ValidationGroup="login">*</asp:RequiredFieldValidator>
            <br />
            <br />
            Password :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtpwd" runat="server" ></asp:TextBox> 
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtpwd" ErrorMessage="Please enter Password" ForeColor="Red" ValidationGroup="login">*</asp:RequiredFieldValidator>
            <br />
            <br/>
            <asp:Button ID="btnlogin" runat="server" Text="Login" OnClick="btnlogin_Click" ValidationGroup="login" />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary2" runat="server" ForeColor="Red" ValidationGroup="login" />
        </div>
    </form>
</body>
</html>
