<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="slideTexto.aspx.vb" Inherits="VerdeUrbano.slideTexto" %>

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
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <div class="panel panel-marron">
                                    <div class="panel-heading">
                                        <asp:Label ID="lblSeccion" runat="server" Text="Seccion" CssClass="label"></asp:Label>
                                    </div>
                                    <div class="panel-body">
                                        <asp:Label ID="lblValorSeccion" runat="server" Text="Titulo del Curso" CssClass="labelChico"></asp:Label>
                                    </div>
                                </div>
                                <div class="panel panel-marron">
                                    <div class="panel-heading">
                                        <asp:Label ID="lblSlide" runat="server" Text="Slide" CssClass="label"></asp:Label>
                                    </div>
                                    <div class="panel-body text-center">
                                        <asp:Label ID="lblTitulo" runat="server" Text="" CssClass="label"></asp:Label>
                                        <br />
                                        <div id="subtitulo" runat="server">
                                            <asp:Label ID="lblSubTitulo" runat="server" Text="" CssClass="labelchico subrayado"></asp:Label>
                                        </div>
<br />
                                        <asp:TextBox ID="descripcion" runat="server" CssClass="textareaSinBorde" TextMode="MultiLine" Enabled="false" Height="200px"></asp:TextBox>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div id="siguiente" runat="server" visible="false">
                            <br />
                            <div class="row">
                                <div class="col-md-4 col-md-offset-4">
                                    <asp:Button ID="btnSiguiente" runat="server" Text="Siguiente" CssClass="btn btn-block btn-primary" />

                                </div>
                            </div>
                        </div>
                        <br />
                        <div id="final" runat="server" visible="false">
                            <br />
                            <div class="row">
                                <div class="col-md-4 col-md-offset-4">
                                    <asp:Button ID="btnEvaluacion" runat="server" Text="Evaluar" CssClass="btn btn-block btn-danger" />

                                </div>
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </div>


</asp:Content>
