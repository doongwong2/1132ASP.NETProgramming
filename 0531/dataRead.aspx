<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="dataRead.aspx.vb" Inherits="WebApplication4.dataRead" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Instructors" GroupName="G1" AutoPostBack="True" OnCheckedChanged="Change"/>
            <asp:RadioButton ID="RadioButton2" runat="server"  Text="Courses" GroupName="G1" AutoPostBack="True" OnCheckedChanged="Change"/>
            <br />
            <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        </div>
    </form>
</body>
</html>
