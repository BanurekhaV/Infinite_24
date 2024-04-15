<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheForm.aspx.cs" Inherits="CachingPrj.CacheForm" %>
<%@ OutputCache Duration="30" VaryByParam="None" Location="ServerAndClient" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select a Product : &nbsp;&nbsp;<asp:DropDownList ID="dplist1" runat="server" AutoPostBack="true"
          OnSelectedIndexChanged="dplist1_SelectedIndexChanged">
                <asp:ListItem Text="All" Value="All"></asp:ListItem>
                  <asp:ListItem Text="Laptops" Value="Laptops"></asp:ListItem>
                  <asp:ListItem Text="Desktops" Value="Desktops"></asp:ListItem>
                  <asp:ListItem Text="Tablets" Value="Tablets"></asp:ListItem>
                  <asp:ListItem Text="Smart Phones" Value="SmartPhones"></asp:ListItem>
                  <asp:ListItem Text="Smart Watches" Value="SmartWatches"></asp:ListItem>
                  <asp:ListItem Text="USBs" Value="USB"></asp:ListItem>
                               </asp:DropDownList>
            <br /><br />

            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
            <p>&nbsp;</p>
            <p>
                Server Time :
                <asp:Label ID="lbldata" runat="server" Text="Label"></asp:Label>
            </p>
            <br />
            Client Time :
            <script>
                document.write(Date());
            </script>
        </div>
    </form>
</body>
</html>
