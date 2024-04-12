<%@ Page Title="" Language="C#" MasterPageFile="~/OurLayout.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="MasterPagePrj.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form runat="server">
        <div>
            <h1 style="color:blue;font-size:20px;text-align:center;">Registration Form </h1>
            <br />
            Name &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtname" runat="server" ></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ControlToValidate="txtname" ErrorMessage="Name Cannot Be Blank" ForeColor="Red" ></asp:RequiredFieldValidator>
            <br />
            <br />
            Password : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:TextBox ID="txtpass" runat="server"></asp:TextBox>
            &nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ControlToValidate="txtpass" ErrorMessage="Password is a Must" ForeColor="Red" ></asp:RequiredFieldValidator>
            <br />
            <br />
            Confirm Password : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtconfpass" runat="server"></asp:TextBox>

            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
          ControlToValidate="txtconfpass" ErrorMessage="Please enter confirm password" ForeColor="Red" Display="Dynamic"></asp:RequiredFieldValidator>
&nbsp;<asp:CompareValidator ID="CompareValidator1" runat="server" 
       ControlToCompare="txtpass" ControlToValidate="txtconfpass" ErrorMessage="Password and confirm password does not match" ForeColor="Red" Display="Dynamic" ></asp:CompareValidator>
            <br />

            <br />
            Age  : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtage" runat="server" TextMode="Number"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtage" ErrorMessage="Please enter your Age" ForeColor="Red" Display="Dynamic" ></asp:RequiredFieldValidator>
            
            &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtage" Display="Dynamic" ErrorMessage="Age has to be between 20 and 30 only" ForeColor="Red" MaximumValue="30" MinimumValue="20" Type="Integer" ></asp:RangeValidator>
            
            <br />
            <br />
            Email : &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtemail" runat= "server" ></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtemail" ErrorMessage="You have to give Email Id" ForeColor="Red" Display="Dynamic" ></asp:RequiredFieldValidator>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" Display="Dynamic" ErrorMessage="Email Id is invalid" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ></asp:RegularExpressionValidator>
            <br />
            <br />
            <asp:Button ID="btnregister" runat="server" Text="Register" OnClick="btnregister_Click"  />
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red"  />
        </div>
    
        </form>

</asp:Content>
