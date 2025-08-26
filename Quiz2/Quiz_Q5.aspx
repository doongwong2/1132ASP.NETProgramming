<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Quiz_Q5.aspx.vb" Inherits="Quiz_Q5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Please choose location :
            <asp:DropDownList ID="SchoolArea" runat="server" AutoPostBack="True">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem Value="School">School Area</asp:ListItem>
                <asp:ListItem Value="Binhai">Binhai Area</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:RadioButtonList ID="Faculty" runat="server" AutoPostBack="True" CssClass="auto-style1" RepeatDirection="Horizontal">
            </asp:RadioButtonList>

            <asp:Label ID="Chosen" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
