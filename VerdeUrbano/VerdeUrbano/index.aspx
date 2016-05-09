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
    <br />
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4">
                <br />
                <div class="panelBoton-titulo"><asp:Label ID="lbl_Bienvenido" runat="server" Text="Bienvenido al Sitio Web de Verde Urbano"></asp:Label></asp:Label> </div>
                <div class="panelBoton-texto"><asp:Label ID="lbl_DescripcionEmpresa" runat="server" Text="Somos la emnpresa lider en instalación y mantenimiento de jardines verticales y terrazas verdes de Buenos Aires. Mas de 200 empresas ya nos han contratado y abalan la calidad de nuestros trabajos."></asp:Label></div>
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
                    <div class="panelBoton-texto"><asp:Label ID="lbl_fb" runat="server" Text="Seguí a VerdeUrbano en nuestro Facebook Oficial."></asp:Label></div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="panelBoton">
                    <img src="Imagenes/RedesSociales/Twitter_64x64.png" class="img-responsive panelBoton-imagen" />
                    <div class="panelBoton-titulo">Twitter</div>
                    <div class="panelBoton-texto"><asp:Label ID="lbl_tw" runat="server" Text="Seguí todas las novedades de VerdeUrbano en nuestro Twitter Oficial."></asp:Label></div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="panelBoton">
                    <img src="Imagenes/RedesSociales/Instagram-64.png" class="img-responsive panelBoton-imagen" />
                    <div class="panelBoton-titulo">Instagram</div>
                    <div class="panelBoton-texto"><asp:Label ID="lbl_insta" runat="server" Text="Visualiza todas las fotos de nuestros proyectos en el Instagram Oficial de VerdeUrbano."></asp:Label></div>
                </div>
            </div>
            <div class="col-md-3">
                <div class="panelBoton">
                    <img src="Imagenes/RedesSociales/youtube_64.png" class="img-responsive panelBoton-imagen" />
                    <div class="panelBoton-titulo">YouTube</div>
                    <div class="panelBoton-texto"><asp:Label ID="lbl_youtube" runat="server" Text="Seguí a VerdeUrbano en nuestro canal oficial de YouTube con los mejores videos de nuestros proyectos."></asp:Label></div>

                </div>
            </div>
        </div>
    </div>
    <br />

</asp:Content>
