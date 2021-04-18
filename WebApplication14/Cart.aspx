<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="WebApplication14.cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Cart</title>
</head>
<body>
<form id="form1" runat="server">
<asp:Label ID="lblSelect" runat="server" Text="Select Product : "></asp:Label>
<asp:DropDownList ID="ddlProduct" runat="server" onselectedindexchanged="ddlProduct_SelectedIndexChanged">
<asp:ListItem Selected="True">Select Product</asp:ListItem>
<asp:ListItem Value="13500">Pineapple</asp:ListItem>
<asp:ListItem Value="500">Honey</asp:ListItem>
<asp:ListItem Value="35">Bread</asp:ListItem>
<asp:ListItem Value="430">Chocolate</asp:ListItem>
<asp:ListItem Value="1800">Apple</asp:ListItem>
<asp:ListItem Value="2500">Soap</asp:ListItem>
</asp:DropDownList>
<asp:Button ID="btnAdd" runat="server" onclick="btnAdd_Click" Text="Add to Cart" />
<asp:Button ID="btnView" runat="server" Onclick="btnView_Click" Text="View Cart" />
</form>
</body>
</html>
