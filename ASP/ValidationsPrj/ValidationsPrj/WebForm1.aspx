<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ValidationsPrj.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   
    <script type="text/javascript">
        function TextChange() {
            var t = document.getElementById("Text1");
            var b = document.getElementById("Button1");
            if (t.value > 0 && t.value %2==0 ) {
                b.disabled = false;
            }
            else {
                b.disabled = true; 
            }


        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input id="Text1" type="text"  onkeyup="TextChange();" />
        <asp:Button ID="Button1"   runat="server" Text="Button" Enabled="False" OnClick="Button1_Click" />
    </div>
    </form>

</body>
</html>
