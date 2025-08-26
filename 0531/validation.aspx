<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="validation.aspx.vb" Inherits="WebApplication4.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <asp:CustomValidator ID="CustomValidator1"  OnServerValidate="CustomValidator1_ServerValidate" runat="server" ErrorMessage="no admin or leading 0 in username." ControlToValidate="TextBox1" Display="Dynamic"></asp:CustomValidator>
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
