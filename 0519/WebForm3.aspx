<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm3.aspx.vb" Inherits="_0519.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Height:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Weight:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Calculate BMI" PostBackUrl="~/WebForm4.aspx" />
        </div>
    </form>
</body>
</html>
