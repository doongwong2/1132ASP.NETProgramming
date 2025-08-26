<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Panel ID="Panel1" runat="server">
                this is a panel</asp:Panel>
        </div>
        <br />
        <br />
        name<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        password<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        weight<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        height<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        example is not using a label, but like a box?<br />
        <br />
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="Button" />
        <br />
        <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
