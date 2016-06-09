<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="DetalleDeCompra.aspx.vb" Inherits="_0806_Practica1erParcial.DetalleDeCompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Estilos.css" rel="stylesheet" />
</head>
<body onload ="Color();">
    <form id="form1" runat="server">
    <div>
        <asp:label id="Pcia" runat="server" text="Label"></asp:label>
        <br />
        <asp:label id="PrecioFinal" runat="server" text="Label"></asp:label>
        <br />
        <asp:label id="Vendedor" runat="server" text="Label"></asp:label>

    </div>
    </form>
</body>
</html>
<script type="text/javascript">
    function Color() {
        var a = document.getElementById("Pcia");
        if (a.innerText == "Cordoba") {
            document.getElementById("form1").className = "Cordoba";
        }
        else if (a.innerText == "Tucuman") {
            document.getElementById("form1").className = "Tucuman";
        }
        else if (a.innerText == "Neuquen") {
            document.getElementById("form1").className = "Neuquen";
        }
    }
</script>
