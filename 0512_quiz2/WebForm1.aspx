<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            save in session<br />
            my name:
            <asp:TextBox ID="TextBox1" runat="server" Text ="John 01057007"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <br />
            listbox<br />
            <asp:ListBox ID="ListBox1" runat="server">
                <asp:ListItem>browserType</asp:ListItem>
                <asp:ListItem>browserName</asp:ListItem>
                <asp:ListItem>browserVersion</asp:ListItem>
                <asp:ListItem>OSversion</asp:ListItem>
                <asp:ListItem>showAll</asp:ListItem>
            </asp:ListBox>
&nbsp;<br />
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="" style="background-color: black; color: white; padding: 5px;"></asp:Label>
            </p>
        <p>
            three droplists</p>
        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True">
                <asp:ListItem></asp:ListItem>
                <asp:ListItem>sunny</asp:ListItem>
                <asp:ListItem>rainy</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="True">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
        </p>
    </form>
</body>
</html>
