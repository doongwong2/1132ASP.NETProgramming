<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Quiz_Q3.aspx.vb" Inherits="Quiz_Q3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:
            <asp:TextBox ID="Username" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="UsernameCheck" runat="server" Display="Dynamic" ErrorMessage="Username can't be empty!" ControlToValidate="Username"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="UsernameRegex" runat="server" Display="Dynamic" ErrorMessage="Username can't contain numbers and special characters!" ValidationExpression="[a-zA-Z]+" ControlToValidate="Username"></asp:RegularExpressionValidator>
            <br />
            Password :
            <asp:TextBox ID="Password" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="PasswordCheck" runat="server" Display="Dynamic" ErrorMessage="Password can't be empty!" ControlToValidate="Password"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="PasswordRegex" runat="server" ErrorMessage="Password must at least be 8 digits!" ControlToValidate="Password" Display="Dynamic" ValidationExpression="[^0]{8,}"></asp:RegularExpressionValidator>
            <br />
            <asp:Button ID="SignUp" runat="server" Text="Sign Up" />
            <br />
            <asp:ValidationSummary ID="Summary" runat="server" HeaderText="< Error Summary : >" />
        </div>
    </form>
</body>
</html>
