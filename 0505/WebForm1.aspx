<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="_0505.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Range Validator<br />
            Score:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Score should be between 0 - 100" ControlToValidate="TextBox1" MaximumValue="100" MinimumValue="0"></asp:RangeValidator>
            <br />
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <br />
            Validation Summary<br />
            Name:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please input a name">Please input a name</asp:RequiredFieldValidator>
            <br />
            Password:<asp:TextBox ID="TextBox3" runat="server" type ="password"></asp:TextBox>
            <br />
            Confirm Password:<asp:TextBox ID="TextBox4" runat="server" type ="password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox4" ErrorMessage="Passwords do not match"></asp:CompareValidator>
            <br />
            <br />
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Button" />
            <br />
            <br />
            Regular Expression Validator<br />
            Email:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="email should be example@mail.com" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
            <br />
            <asp:Button ID="Button3" runat="server" Text="Button" />
            <br />
            <br />
            Custom Validator<br />
            Name:
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Incorrect name format." ClientValidationFunction="Button4_Click" ControlToValidate="TextBox6"></asp:CustomValidator>
            <br />
            <asp:Button ID="Button4" runat="server" Text="Button" />
            <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <br />
            <br />
            response redirect<br />
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button5" runat="server" Text="Button" />
            <br />
            <br />
            server request<br />
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button6" runat="server" Text="request server variables" />
            <asp:Button ID="Button7" runat="server" Text="check browser" />
            <br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            <br />
            <br />
            try catch<br />
            <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            /<asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
&nbsp;<asp:Button ID="Button8" runat="server" Text="Calculate" />
            <br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            <br />
        </div>
    </form>
</body>
</html>
