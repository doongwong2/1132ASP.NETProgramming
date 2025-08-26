<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Quiz_Q6.aspx.vb" Inherits="Quiz_Q6" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 66px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td rowspan ="2">
                        <asp:ListBox ID="LeftBox" runat="server" Height="165px" SelectionMode="Multiple" Width="76px">
                            <asp:ListItem>A</asp:ListItem>
                            <asp:ListItem>B</asp:ListItem>
                            <asp:ListItem>C</asp:ListItem>
                            <asp:ListItem>D</asp:ListItem>
                            <asp:ListItem>E</asp:ListItem>
                            <asp:ListItem>F</asp:ListItem>
                            <asp:ListItem>G</asp:ListItem>
                        </asp:ListBox>
                    </td>
                    <td class="auto-style1">
                        <asp:Button ID="toRight" runat="server" Text=">" Height="32px" Width="65px" />
                    </td>
                    <td rowspan ="2">
                        <asp:ListBox ID="RightBox" runat="server" Height="166px" SelectionMode="Multiple" Width="76px">
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                        </asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">
                        <asp:Button ID="toLeft" runat="server" Text="<" Height="31px" Width="66px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
