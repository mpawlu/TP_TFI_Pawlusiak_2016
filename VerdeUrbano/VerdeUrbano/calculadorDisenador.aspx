﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="calculadorDisenador.aspx.vb" Inherits="VerdeUrbano.calculadorDisenador" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="//netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.min.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">

    <br />
    <br />
    <div class="row">
        <div class="well well-lg col-md-12 msj-ok" runat="server" visible="false" id="correcto">
            <asp:Label ID="lbl_AccionCorrecta" runat="server" CssClass="labelOK"></asp:Label>
        </div>
    </div>
    <div class="row">
        <div class="well well-lg col-md-12 msj-error" runat="server" visible="false" id="error">
            <asp:Label ID="lbl_TituloError" runat="server" CssClass="labelError"></asp:Label>
        </div>
    </div>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-10 col-md-offset-1">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">
                        <asp:Label ID="lbl_AgregarUsuario" runat="server" Text="Agregar Usuario"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <div class="well profile">
                                    <div class="col-md-2">
                                        <figure>
                                            <img src="Imagenes/maceta.jpg" class="img-circle profile-img img-responsive" />
                                        </figure>
                                    </div>
                                    <div class="col-md-8">
                                        <br />
                                        <asp:Label ID="lbl_NombreDisenador1" runat="server" Text="Pantenne" CssClass="profile-nombre"></asp:Label>
                                        <br />
                                        <asp:Label ID="lbl_CursosRealizados1" runat="server" Text="Cursos Realizados:" CssClass="profile-titulo"></asp:Label>
                                        <asp:Label ID="lbl_CantidadCursosRealizado1" runat="server" Text="18" CssClass="profile-texto"></asp:Label>
                                        <br />
                                        <asp:Label ID="lbl_UltimoCurso1" runat="server" Text="Último Curso Dictado:" CssClass="profile-titulo"></asp:Label>
                                        <asp:Label ID="lbl_DetalleUltimoCurso1" runat="server" Text="Un pase de faja para un Try." CssClass="profile-texto"></asp:Label>
                                    </div>
                                    <div class="col-md-2 text-center">
                                        <br />
                                        <asp:Label ID="lbl_rating1" runat="server" Text="78" CssClass="profile-rating"></asp:Label>
                                        <asp:Button ID="btn_Seleccionar1" runat="server" Text="Seleccionar" class="btn btn-success btn-block" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <div class="well profile">
                                    <div class="col-md-2">
                                        <figure>
                                            <img src="Imagenes/maceta.jpg" class="img-circle profile-img img-responsive" />
                                        </figure>
                                    </div>
                                    <div class="col-md-8">
                                        <br />
                                        <asp:Label ID="lbl_NombreDisenador2" runat="server" Text="Pantenne" CssClass="profile-nombre"></asp:Label>
                                        <br />
                                        <asp:Label ID="lbl_CursosRealizados2" runat="server" Text="Cursos Realizados:" CssClass="profile-titulo"></asp:Label>
                                        <asp:Label ID="lbl_CantidadCursosRealizado2" runat="server" Text="18" CssClass="profile-texto"></asp:Label>
                                        <br />
                                        <asp:Label ID="lbl_UltimoCurso2" runat="server" Text="Último Curso Dictado:" CssClass="profile-titulo"></asp:Label>
                                        <asp:Label ID="lbl_DetalleUltimoCurso2" runat="server" Text="Un pase de faja para un Try." CssClass="profile-texto"></asp:Label>
                                    </div>
                                    <div class="col-md-2 text-center">
                                        <br />
                                        <asp:Label ID="lbl_rating2" runat="server" Text="78" CssClass="profile-rating"></asp:Label>
                                        <asp:Button ID="btn_Seleccionar2" runat="server" Text="Seleccionar" class="btn btn-success btn-block" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <div class="well profile">
                                    <div class="col-md-2">
                                        <figure>
                                            <img src="Imagenes/maceta.jpg" class="img-circle profile-img img-responsive" />
                                        </figure>
                                    </div>
                                    <div class="col-md-8">
                                        <br />
                                        <asp:Label ID="lbl_NombreDisenador3" runat="server" Text="Pantenne" CssClass="profile-nombre"></asp:Label>
                                        <br />
                                        <asp:Label ID="lbl_CursosRealizados3" runat="server" Text="Cursos Realizados:" CssClass="profile-titulo"></asp:Label>
                                        <asp:Label ID="lbl_CantidadCursosRealizado3" runat="server" Text="18" CssClass="profile-texto"></asp:Label>
                                        <br />
                                        <asp:Label ID="lbl_UltimoCurso3" runat="server" Text="Último Curso Dictado:" CssClass="profile-titulo"></asp:Label>
                                        <asp:Label ID="lbl_DetalleUltimoCurso3" runat="server" Text="Un pase de faja para un Try." CssClass="profile-texto"></asp:Label>
                                    </div>
                                    <div class="col-md-2 text-center">
                                        <br />
                                        <asp:Label ID="lbl_rating3" runat="server" Text="78" CssClass="profile-rating"></asp:Label>
                                        <asp:Button ID="btn_Seleccionar3" runat="server" Text="Seleccionar" class="btn btn-success btn-block" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <div class="well profile">
                                    <div class="col-md-2">
                                        <figure>
                                            <img src="Imagenes/maceta.jpg" class="img-circle profile-img img-responsive" />
                                        </figure>
                                    </div>
                                    <div class="col-md-8">
                                        <br />
                                        <asp:Label ID="lbl_NombreDisenador4" runat="server" Text="Pantenne" CssClass="profile-nombre"></asp:Label>
                                        <br />
                                        <asp:Label ID="lbl_CursosRealizados4" runat="server" Text="Cursos Realizados:" CssClass="profile-titulo"></asp:Label>
                                        <asp:Label ID="lbl_CantidadCursosRealizado4" runat="server" Text="18" CssClass="profile-texto"></asp:Label>
                                        <br />
                                        <asp:Label ID="lbl_UltimoCurso4" runat="server" Text="Último Curso Dictado:" CssClass="profile-titulo"></asp:Label>
                                        <asp:Label ID="lbl_DetalleUltimoCurso4" runat="server" Text="Un pase de faja para un Try." CssClass="profile-texto"></asp:Label>
                                    </div>
                                    <div class="col-md-2 text-center">
                                        <br />
                                        <asp:Label ID="lbl_rating4" runat="server" Text="78" CssClass="profile-rating"></asp:Label>
                                        <asp:Button ID="btn_Seleccionar4" runat="server" Text="Seleccionar" class="btn btn-success btn-block" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <div class="well profile">
                                    <div class="col-md-2">
                                        <figure>
                                            <img src="Imagenes/maceta.jpg" class="img-circle profile-img img-responsive" />
                                        </figure>
                                    </div>
                                    <div class="col-md-8">
                                        <br />
                                        <asp:Label ID="lbl_NombreDisenador5" runat="server" Text="Pantenne" CssClass="profile-nombre"></asp:Label>
                                        <br />
                                        <asp:Label ID="lbl_CursosRealizados5" runat="server" Text="Cursos Realizados:" CssClass="profile-titulo"></asp:Label>
                                        <asp:Label ID="lbl_CantidadCursosRealizado5" runat="server" Text="18" CssClass="profile-texto"></asp:Label>
                                        <br />
                                        <asp:Label ID="lbl_UltimoCurso5" runat="server" Text="Último Curso Dictado:" CssClass="profile-titulo"></asp:Label>
                                        <asp:Label ID="lbl_DetalleUltimoCurso5" runat="server" Text="Un pase de faja para un Try." CssClass="profile-texto"></asp:Label>
                                    </div>
                                    <div class="col-md-2 text-center">
                                        <br />
                                        <asp:Label ID="lbl_rating5" runat="server" Text="78" CssClass="profile-rating"></asp:Label>
                                        <asp:Button ID="btn_Seleccionar5" runat="server" Text="Seleccionar" class="btn btn-success btn-block" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-2 col-md-offset-5">
                                <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="btn btn-block btn-warning" />
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
