<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Quiz_Q2.aspx.vb" Inherits="Quiz_Q2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="Options" runat="server" AutoPostBack="True" Height="91px">
                <asp:ListItem Value="Type">Browser Type</asp:ListItem>
                <asp:ListItem Value="Name">Browser Name</asp:ListItem>
                <asp:ListItem Value="Version">Browser Version</asp:ListItem>
                <asp:ListItem Value="Platform">Operating System Platform</asp:ListItem>
                <asp:ListItem Value="Show">Show All</asp:ListItem>
            </asp:ListBox>
            <asp:Label ID="Output" runat="server" BackColor="Black" BorderColor="#CCCCCC" BorderStyle="Double" BorderWidth="2px" ForeColor="White" Text="" Visible="False"></asp:Label>
        </div>
    </form>
</body>
</html>

