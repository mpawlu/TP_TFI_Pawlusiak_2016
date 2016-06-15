<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="detalleSatisfaccion.aspx.vb" Inherits="VerdeUrbano.detalleSatisfaccion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
            <div class="col-md-8 col-md-offset-2">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">
                        <asp:Label ID="lbl_SatisfaccionCliente" runat="server" Text="Satisfaccion de Cliente"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
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
                            </div>
                            <br />
                            <br />
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-2 col-md-offset-5">
                                <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="btn btn-block btn-warning" />

                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
