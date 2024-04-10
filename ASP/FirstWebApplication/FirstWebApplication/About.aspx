<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="FirstWebApplication.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.</h3>
    <p>Use this area to provide additional information.</p>
    <p>Hello All !!! Welcome to ASP.Net</p>

    <input type="button"  />&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Button" />
</asp:Content>

