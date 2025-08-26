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
            <asp:TextBox ID="TextBox1" runat="server" EnableViewState="False"></asp:TextBox>
&nbsp;enable view state is false<br />
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            is post back</div>
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <br />
        <br />
        checkbox is true<br />
        <asp:CheckBox ID="CheckBox1" runat="server" />
        Chicken<br />
        <asp:CheckBox ID="CheckBox2" runat="server" />
        Beef<br />
        Quantity
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" Text="Calculate" />
        <br />
        Total =
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
        <br />
        <br />
        radio buttons<br />
        <asp:RadioButton ID="RadioButton1" runat="server" />
        rare<asp:RadioButton ID="RadioButton2" runat="server" />
        medium<asp:RadioButton ID="RadioButton3" runat="server" />
        well done<br />
        <asp:Button ID="Button3" runat="server" Text="choose your steak" />
    &nbsp;<asp:Label ID="Label3" runat="server" Text=""></asp:Label>
        <br />
        <br />
        drop down list<br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="transfer"></asp:ListItem>
            <asp:ListItem>Cash</asp:ListItem>
            <asp:ListItem>Credit Card</asp:ListItem>
        </asp:DropDownList>
&nbsp;<asp:Button ID="Button4" runat="server" Text="Payment methods" />
        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
        <br />
        <br />
        listbox(single)<br />
&nbsp;<br />
        <asp:ListBox ID="ListBox1" runat="server" SelectionMode ="Single">
            <asp:ListItem>screen protector</asp:ListItem>
            <asp:ListItem>phone case</asp:ListItem>
            <asp:ListItem>stylus</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="Button5" runat="server" Text="choose" />
        <br />
        <br />
        listbox(multiple)<br />
        <asp:ListBox ID="ListBox2" runat="server" SelectionMode ="Multiple">
            <asp:ListItem>screen protector</asp:ListItem>
            <asp:ListItem>phone case</asp:ListItem>
            <asp:ListItem>stylus</asp:ListItem>
        </asp:ListBox>
        <br />
        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
        <br />
        <asp:Button ID="Button11" runat="server" Text="Choose" />
        <br />
        <br />
        dynamic list, user can input list element and add/delete to the list.<br />
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Button ID="Button6" runat="server" Text="add" />
        <asp:Button ID="Button7" runat="server" Text="delete" />
        <asp:Button ID="Button8" runat="server" Text="clearAll" />
        <asp:Button ID="Button9" runat="server" Text="delete 1st" />
        <asp:Button ID="Button10" runat="server" Text="delete last" />
        <br />
        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:CheckBox ID="CheckBox3" runat="server" Text="car" />
        <asp:CheckBox ID="CheckBox4" runat="server" Text="moped" />
        <asp:CheckBox ID="CheckBox5" runat="server" Text="bicycle" />
        <asp:CheckBox ID="CheckBox6" runat="server" Text="bus" />
        <br />
        <asp:Button ID="Button12" runat="server" Text="Update list" />
        <br />
        <asp:ListBox ID="ListBox3" runat="server"></asp:ListBox>
        <br />
        <br />
        two dynamic lists<br />
        <asp:ListBox ID="ListBox4" runat="server" SelectionMode ="Multiple">
            <asp:ListItem>1</asp:ListItem>
            <asp:ListItem>2</asp:ListItem>
            <asp:ListItem>3</asp:ListItem>
            <asp:ListItem>4</asp:ListItem>
        </asp:ListBox>
&nbsp;<asp:Button ID="Button13" runat="server" Text=">" />
        <asp:Button ID="Button14" runat="server" Text="<"/>
&nbsp;<asp:ListBox ID="ListBox5" runat="server" SelectionMode ="Multiple">
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>b</asp:ListItem>
            <asp:ListItem>c</asp:ListItem>
            <asp:ListItem>d</asp:ListItem>
        </asp:ListBox>
        <br />
        <br />
    </form>
</body>
</html>
