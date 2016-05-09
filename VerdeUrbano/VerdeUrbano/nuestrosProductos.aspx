<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="nuestrosProductos.aspx.vb" Inherits="VerdeUrbano.nuestrosProductos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/jquery-ui.css"/>
    <script src="js/jquery-1.10.2.js"></script>
    <script src="js/jquery-ui.js"></script>
    <script>
        $(function () {
            $("#accordion").accordion();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
    <br />
    <div class="container">
        <!--        <div class="row">
            <div class="col-md-4 col-md-offset-7">
                <a href="calcularPresupuesto.aspx" class="btn btn-success btn-block" role="button" style="text-decoration: none;">CALCULA TU PRESUPUESTO!!!</a>
            </div>
        </div>-->
        <br />
        <div class="row">
            <div class="col-md-10 col-md-offset-1">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading"><asp:Label ID="lbl_ConoceNuestrosProductos" runat="server" Text="Conoce Nuestros Productos"></asp:Label></div>
                    <div class="panel-body">
                        <br />
                        <div id="accordion">
                            <h3><asp:Label ID="lbl_TitJardin" runat="server" Text="Jardín Vertical"></asp:Label></h3>
                            <div class="row">
                                <div class="col-md-5">
                                    <img src="Imagenes/jardin.jpg" class="img img-responsive" style="padding-left: 5%" />
                                </div>
                                <div class="col-md-5 col-md-offset-1">
                                    <p><asp:Label ID="lbl_DetalleJardin" runat="server" Text="Cultivar plantas en una superficie vertical ha sido posible gracias a estudios de locaciones verticales naturales (rocas, acantilados y troncos de árboles), lugares sin suelo y con abundancia de especies vegetales. Las técnicas imitan estas condiciones y se adaptan a cualquier geometría."></asp:Label></p>
                                </div>
                            </div>
                            <h3><asp:Label ID="lbl_TitTerraza" runat="server" Text="Terrazas Verdes"></asp:Label></h3>

                            <div class="row">
                                <div class="col-md-5">
                                    <img src="Imagenes/terraza.jpg" class="img img-responsive" style="padding-left: 5%" />
                                </div>
                                <div class="col-md-5 col-md-offset-1">
                                    <p>
                                    <asp:Label ID="lbl_DetalleTerraza" runat="server" Text="Una cubierta verde es un sistema de ingeniería que permite el crecimiento de vegetación en la parte superior de los edificios (ya sea en techos o azoteas) manteniendo protegida su estructura. En general, tienen un impacto neto positivo sobre el ambiente: capturan agua de lluvia, reduciendo inundaciones y niveles de contaminación; mejoran el aislamiento térmico de los edificios y enfrían el aire; representan un hábitat para especies nativas o migratorias; y ayudan a mejorar la calidad de vida."></asp:Label>
                                </div>
                            </div>
                            <h3><asp:Label ID="lbl_TitMacetas" runat="server" Text="Macetas"></asp:Label></h3>
                            <div class="row">
                                <div class="col-md-5">
                                    <img src="Imagenes/maceta.jpg" class="img img-responsive" style="padding-left: 5%" />
                                </div>
                                <div class="col-md-5 col-md-offset-1">
                                    <p><asp:Label ID="lbl_DetalleMacetas" runat="server" Text="Puede utilizarse tanto en interiores como en exteriores. Fácil de implementar, impermeabilizada, ayuda a la respiración de las raíces, y mantiene regadas las plantas."></asp:Label></p>
                                </div>
                            </div>
                            <h3><asp:Label ID="lbl_TitSobres" runat="server" Text="Sobres"></asp:Label></h3>
                            <div class="row">
                                <div class="col-md-5">
                                    <img src="Imagenes/sobre.jpg" class="img img-responsive" style="padding-left: 5%" />
                                </div>
                                <div class="col-md-5 col-md-offset-1">
                                    <p><asp:Label ID="lbl_DetalleSobres" runat="server" Text="Diseñado para interiores, de material hidrófugo, fácil de implementar y mantener. No mancha ni humedece las paredes."></asp:Label></p>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
    <br />
</asp:Content>
