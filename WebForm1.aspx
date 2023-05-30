<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SepetUygulamasi.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        ürün seçiniz:<asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem>seçiniz</asp:ListItem>
            <asp:ListItem Value="1">gigabyte anakart</asp:ListItem>
            <asp:ListItem Value="2">msi anakart</asp:ListItem>
            <asp:ListItem Value="3">kingston ram</asp:ListItem>
            <asp:ListItem Value="4">oem ram</asp:ListItem>
            <asp:ListItem Value="5">samsung hdd</asp:ListItem>
            <asp:ListItem Value="6">western hdd</asp:ListItem>
        </asp:DropDownList>
        <div>
        </div>
    </form>
</body>
</html>
