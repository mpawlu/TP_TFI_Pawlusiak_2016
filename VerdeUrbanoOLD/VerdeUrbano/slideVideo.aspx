<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="slideVideo.aspx.vb" Inherits="VerdeUrbano.slideVideo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
    <br />
    <br />

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
                        <asp:Label ID="lblVisualizarSlide" runat="server" Text="Visualizar Slide"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <asp:Label ID="lblTitulo" runat="server" Text="" CssClass="label"></asp:Label>
                            </div>
                        </div>
                        <div id="subtitulo" runat="server">
                            <br />
                            <div class="row">
                                <div class="col-md-10 col-md-offset-1">
                                    <asp:Label ID="lblSubTitulo" runat="server" Text="" CssClass="label"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <iframe id="videoMaterial" width="100%" height="400" runat="server" allowfullscreen></iframe>
                            </div>
                        </div>
                        <br />
                                                <div id="siguiente" runat="server" visible="false">
                            <br />
                            <div class="row">
                                <div class="col-md-10 col-md-offset-1">
                                    <asp:Button ID="btnSiguiente" runat="server" Text="Siguiente" CssClass="btn btn-block btn-info" />

                                </div>
                            </div>
                        </div>
                        <br />
                        <div id="final" runat="server" visible="false">
                            <br />
                            <div class="row">
                                <div class="col-md-10 col-md-offset-1">
                                    <asp:Button ID="btnEvaluacion" runat="server" Text="Evaluar" CssClass="btn btn-block btn-danger" />

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
