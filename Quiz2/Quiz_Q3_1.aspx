<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Quiz_Q3_1.aspx.vb" Inherits="Quiz_Q3_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Erase" runat="server" Text="Delete Cookie" />
&nbsp;
            <asp:Button ID="Back" runat="server" Text="Return Page" PostBackUrl="~/Quiz_Q3.aspx" />
            <br />
            <asp:Label ID="Output" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
