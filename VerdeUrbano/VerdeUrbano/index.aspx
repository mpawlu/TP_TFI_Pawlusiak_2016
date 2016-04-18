﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="index.aspx.vb" Inherits="VerdeUrbano.index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="CSS/EstiloSlider.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="JS/jquery-1.10.2.js"></script>
    <script type="text/javascript" src="JS/jssor.js"></script>
    <script type="text/javascript" src="JS/jssor.slider.js"></script>
    <script type="text/javascript" src="JS/functionSlider.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-md-1 col-md-offset-1">
                <br />
                <br />
                <br />
                <div class="row">
                    <img src="Imagenes/urbano.png" class="img img-responsive" />
                </div>
                <br />
                <br />
                <br />
                <div class="row">
                    <img src="Imagenes/economico.png" class="img img-responsive" />
                </div>
                <br />
                <br />
                <br />
                <div class="row">
                    <img src="Imagenes/integral.png" class="img img-responsive" />
                </div>

            </div>
            <div class="col-md-6 col-md-offset-1">
                <br />
                <br />
                <br />
                <br />
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
                <br />
                <br />
                <br />
                <br />
            </div>

            <div class="col-md-1 col-md-offset-1">
                <br />
                <br />
                <br />
                <div class="row">
                    <img src="Imagenes/sustentable.png" class="img img-responsive" />
                </div>
                <br />
                <br />
                <br />
                <div class="row">
                    <img src="Imagenes/natural.png" class="img img-responsive" />
                </div>
                <br />
                <br />
                <br />
                <div class="row">
                    <img src="Imagenes/saludable.png" class="img img-responsive" />
                </div>

            </div>
        </div>
    </div>
   
    <br />
    <asp:Label ID="Label1" runat="server" Text="Nombre de usuario"></asp:Label>
    <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
    <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="DNI"></asp:Label>
    <asp:TextBox ID="txtDNI" runat="server"></asp:TextBox>
    <br />
    <asp:RadioButton ID="Activo" runat="server" text="Activo" />
     <br />
    <asp:Label ID="Label4" runat="server" Text="Perfil"></asp:Label>
    <asp:TextBox ID="txtPerfil" runat="server"></asp:TextBox>
    <br />
     <asp:RadioButton ID="bloqueado" runat="server" text="Bloqueado" />
     <br />
    <asp:Label ID="Label5" runat="server" Text="Fecha Alta"></asp:Label>
    <asp:TextBox ID="txtFechaAlta" runat="server"></asp:TextBox>
     <br />
     <asp:RadioButton ID="Editable" runat="server" text="Editable" />
     <br />  
    <asp:Label ID="Label6" runat="server" Text="ID Idioma"></asp:Label>
    <asp:TextBox ID="txtIdioma" runat="server"></asp:TextBox>
     <br />
    <br />
    <asp:Button ID="btnGuardar" runat="server" Text="Guardar" />
</asp:Content>
