<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Inicio.aspx.vb" Inherits="_0806_Practica1erParcial.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Bienvenido al sitio ON-Line de compras
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Provincia"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Cordoba</asp:ListItem>
            <asp:ListItem>Tucuman</asp:ListItem>
            <asp:ListItem>Neuquen</asp:ListItem>
        </asp:DropDownList>
        <br />  
        Productos
        <br />  

        <asp:CheckBox ID="CheckBox1" runat="server" text="Buzo $1000"/>
        <asp:CheckBox ID="CheckBox2" runat="server" text="Zapatillas $1500"/>
        <asp:CheckBox ID="CheckBox3" runat="server" text="Campera $2000"/>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Confirmar Compra" />

    </div>
    </form>
</body>
</html>
