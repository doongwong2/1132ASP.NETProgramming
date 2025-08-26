<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Quiz_Q4.aspx.vb" Inherits="Quiz_Q4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 478px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="ComputerPanel" runat="server" GroupingText="Computer Accessories" Width="826px">
                <asp:CheckBoxList ID="Options" runat="server" RepeatColumns="6" RepeatDirection="Horizontal">
                    <asp:ListItem Value="9500">CPU $9500</asp:ListItem>
                    <asp:ListItem Value="5000">Motherboard $5000</asp:ListItem>
                    <asp:ListItem Value="4500">Harddrive $4500</asp:ListItem>
                    <asp:ListItem Value="8000">Monitor $8000</asp:ListItem>
                    <asp:ListItem Value="500">Keyboard $500</asp:ListItem>
                    <asp:ListItem Value="300">Mouse $300</asp:ListItem>
                    <asp:ListItem Value="2000">Memory $2000</asp:ListItem>
                    <asp:ListItem Value="6000">Display Card $6000</asp:ListItem>
                </asp:CheckBoxList>
            </asp:Panel>
            <asp:Panel ID="Panel2" runat="server" GroupingText="Delivery Fee" Width="543px">
                <asp:RadioButtonList ID="DeliveryOptions" runat="server" RepeatDirection="Horizontal">
                    <asp:ListItem Selected="True" Value="10">Express 10%</asp:ListItem>
                    <asp:ListItem Value="12">Convenience Store 12%</asp:ListItem>
                    <asp:ListItem Value="20">Cash on Delivery 20%</asp:ListItem>
                </asp:RadioButtonList>
            </asp:Panel>
            <table>
                <td class="auto-style1">
                    <asp:Label ID="Output" runat="server" Text="Total Cost : $0 - Total 0 Item"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="Calculate" runat="server" Text="Calculate" />
                </td>
            </table>
        </div>
    </form>
</body>
</html>
