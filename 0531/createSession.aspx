<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="createSession.aspx.vb" Inherits="WebApplication4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="create session" />
            <asp:Button ID="Button3" runat="server" Text="read all sessions" />
            <asp:Button ID="Button2" runat="server" Text="clear selected sessions" />
            <asp:Button ID="Button4" runat="server" Text="clear all sessions" />
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
