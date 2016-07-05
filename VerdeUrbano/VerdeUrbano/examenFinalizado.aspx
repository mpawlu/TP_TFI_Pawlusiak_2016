<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="examenFinalizado.aspx.vb" Inherits="VerdeUrbano.examenFinalizado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="//netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
    <br />
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-8 col-md-offset-2">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">
                        <asp:Label ID="lblresultadoExamen" runat="server" Text="Resultado del Examen"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <div id="aprobado" runat="server" visible="false">
                            <div class="row">
                                <div class="col-md-10 col-md-offset-1">
                                    <div class="well notaResumen">
                                        <div class="col-md-2">
                                            <figure>
                                                <div class="circle-tile-heading"><i class="fa fa-thumbs-o-up fa-fw fa-3x"></i></div>
                                            </figure>
                                        </div>
                                        <div class="col-md-8">
                                            <asp:Label ID="lbl_Atitulo" runat="server" Text="Aprobado" CssClass="notaResumen-titulo"></asp:Label>
                                            <br />
                                            <asp:Label ID="lbl_Acorrectas" runat="server" CssClass="notaResumen-texto"></asp:Label>

                                        </div>
                                        <div class="col-md-2 text-center">
                                            <p>
                                                <asp:Label ID="lbl_Arating" runat="server" CssClass="notaResumen-rating"></asp:Label>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div id="desaprobado" runat="server" visible="false">
                            <div class="row">
                                <div class="col-md-10 col-md-offset-1">
                                    <div class="well notaResumendes">
                                        <div class="col-md-2">
                                            <figure>
                                                <div class="circle-tile-heading"><i class="fa fa-thumbs-o-down fa-fw fa-3x"></i></div>
                                            </figure>
                                        </div>
                                        <div class="col-md-8">
                                            <asp:Label ID="lbl_Dtitulo" runat="server" Text="Desaprobado" CssClass="notaResumen-titulo"></asp:Label>
                                            <br />
                                            <asp:Label ID="lbl_Dcorrectas" runat="server" Text="Preguntas Correctas: 2/10" CssClass="notaResumen-texto"></asp:Label>

                                        </div>
                                        <div class="col-md-2 text-center">
                                            <p>
                                                <asp:Label ID="lbl_Drating" runat="server" Text="2" CssClass="notaResumen-rating"></asp:Label>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <br />
                        <br />
                        <div class="col-md-2 col-md-offset-5">
                            <asp:Button ID="btnSiguiente" runat="server" Text="Siguiente" CssClass="btn btn-block btn-primary" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
