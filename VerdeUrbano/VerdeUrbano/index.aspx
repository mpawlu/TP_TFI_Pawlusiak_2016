<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="index.aspx.vb" Inherits="VerdeUrbano.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="CSS/EstiloSlider.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="JS/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="JS/jssor.js"></script>
    <script type="text/javascript" src="JS/jssor.slider.js"></script>
    <script type="text/javascript" src="JS/functionSlider.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">

    <br />
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <asp:Button ID="btnActualizarIdioma" runat="server" Text="Actualizar Idioma" />
    <br />
    <br />
    <div class="container-fluid">
        <div class="row">

            <div class="col-md-4">
                <br />
                <div class="panelBoton-titulo">Bienvenidos al Sitio Web de Verde Urbano</div>
                <div class="panelBoton-texto">Hola aca va el texto de introducción para agregara  la pagina como para que puedan hacer una introducción a la empresa y ver las cosas viste. Me gustaria que el texto tenga un largo bastante importante para que sea largo y probar.</div>
            </div>


            <div class="col-md-6 col-md-offset-1">

                <div id="slider1_container" class="slider-container center-block">
                    <div u="slides" class="slides">
                        <div>
                            <asp:ImageButton ID="img1" class="img-slider" src="Imagenes/Slider/01.jpg" runat="server" ImageUrl="#" />
                        </div>
                        <div>
                            <asp:ImageButton ID="img2" class="img-slider" src="Imagenes/Slider/02.jpg" runat="server" ImageUrl="#" />
                        </div>
                        <div>
                            <asp:ImageButton ID="img3" class="img-slider" src="Imagenes/Slider/03.jpg" runat="server" ImageUrl="#" />
                        </div>
                        <div>
                            <asp:ImageButton ID="img4" class="img-slider" src="Imagenes/Slider/04.jpg" runat="server" ImageUrl="#" />
                        </div>
                        <div>
                            <asp:ImageButton ID="img5" class="img-slider" src="Imagenes/Slider/05.jpg" runat="server" ImageUrl="#" />
                        </div>
                        <div>
                            <asp:ImageButton ID="img6" class="img-slider" src="Imagenes/Slider/06.jpg" runat="server" ImageUrl="#" />
                        </div>
                        <div>
                            <asp:ImageButton ID="img7" class="img-slider" src="Imagenes/Slider/07.jpg" runat="server" ImageUrl="#" />
                        </div>
                        <div>
                            <asp:ImageButton ID="img8" class="img-slider" src="Imagenes/Slider/08.jpg" runat="server" ImageUrl="#" />
                        </div>
                        <div>
                            <asp:ImageButton ID="img9" class="img-slider" src="Imagenes/Slider/09.jpg" runat="server" ImageUrl="#" />
                        </div>
                        <div>
                            <asp:ImageButton ID="img10" class="img-slider" src="Imagenes/Slider/10.jpg" runat="server" ImageUrl="#" />
                        </div>
                    </div>
                    <div u="arrowleft" class="jssora12l"></div>
                    <div u="arrowright" class="jssora12r"></div>
                </div>

            </div>


        </div>
        <br />
        <br />
        <div class="row">
            <div class="col-md-3">
                <div class="panelBoton">
                    <img src="Imagenes/RedesSociales/FaceBook_64x64.png" class="img-responsive panelBoton-imagen" />
                    <div class="panelBoton-titulo">Facebook</div>
                    <div class="panelBoton-texto">Seguí a VerdeUrbano en nuestro Facebook Oficial.</div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="panelBoton">
                    <img src="Imagenes/RedesSociales/Twitter_64x64.png" class="img-responsive panelBoton-imagen" />
                    <div class="panelBoton-titulo">Twitter</div>
                    <div class="panelBoton-texto">Seguí todas las novedades de VerdeUrbano en nuestro Twitter Oficial.</div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="panelBoton">
                    <img src="Imagenes/RedesSociales/Instagram-64.png" class="img-responsive panelBoton-imagen" />
                    <div class="panelBoton-titulo">Instagram</div>
                    <div class="panelBoton-texto">Visualiza todas las fotos de nuestros proyectos en el Instagram Oficial de VerdeUrbano.</div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="panelBoton">
                    <img src="Imagenes/RedesSociales/youtube_64.png" class="img-responsive panelBoton-imagen" />
                    <div class="panelBoton-titulo">YouTube</div>
                    <div class="panelBoton-texto">Seguí a VerdeUrbano en nuestro canal oficial de YouTube con los mejores videos de nuestros proyectos.</div>
                </div>
            </div>
        </div>
    </div>
    <br />

</asp:Content>
