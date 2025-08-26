<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Quiz_Q7.aspx.vb" Inherits="Quiz_Q7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please choose :
            <asp:DropDownList ID="First" runat="server" AutoPostBack="True">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>Sunny</asp:ListItem>
                <asp:ListItem>Rainy</asp:ListItem>
            </asp:DropDownList>
            &nbsp;<asp:DropDownList ID="Second" runat="server" AutoPostBack="True">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            &nbsp;<asp:DropDownList ID="Third" runat="server" AutoPostBack="True">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
