<%@ Page Title="" Language="C#" MasterPageFile="~/OurLayout.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MasterPagePrj.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID ="MainContent" runat="server">
    <form runat="server">
       <h1 style="background-color:aqua;color:forestgreen">This is the First Content Page</h1>
    <asp:TextBox ID="txtname" runat="server"></asp:TextBox><br />
    <asp:Button ID="Btnclick" runat="server" Text="Button" OnClick="Btnclick_Click1" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Go To Registration" OnClick="Button1_Click" />
</form>
</asp:Content>
