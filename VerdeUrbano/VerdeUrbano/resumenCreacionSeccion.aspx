<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="resumenCreacionSeccion.aspx.vb" Inherits="VerdeUrbano.resumenCreacionSeccion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="JS/jquery-1.9.1.min.js"></script>
    <script src="JS/jquery-ui.js"></script>
    <link href="CSS/DateTimePicker.css" rel="stylesheet" type="text/css" />
    <script>
        $(function () {
            $("#contenidoPagina_txtFechaCreacion").datepicker();
        });
    </script>
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
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-8 col-md-offset-2">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">
                        <asp:Label ID="lbl_CrearCurso" runat="server" Text="Crear Curso"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbltituloSeccion" runat="server" Text="Seccion:" CssClass="label subrayado"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lblValortitulo" runat="server" Text="Titulo de la seccion" CssClass="label"></asp:Label>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbldescripcion" runat="server" Text="Descripcion:" CssClass="label subrayado"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lblValorDesc" runat="server" Text="Descripcion de la seccion" CssClass="label"></asp:Label>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lblslides" runat="server" Text="Slides:" CssClass="label subrayado"></asp:Label>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-8 col-md-offset-2">
                                <asp:GridView ID="gv_slides" runat="server" CssClass="Grid-verde" AutoGenerateColumns="False" HorizontalAlign="Center">
                                    <Columns>
                                        <asp:BoundField DataField="Titulo" HeaderText="Titulo" HtmlEncode="False" ControlStyle-CssClass="col-md-3" />
                                        <asp:BoundField DataField="Tipo" HeaderText="Tipo" HtmlEncode="False" ControlStyle-CssClass="col-md-4" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                            <br />
                            <br />
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-2">
                                <asp:Button ID="btnAgregarSlide" runat="server" Text="Agregar Slide" CssClass="btn btn-block btn-success" />
                            </div>
                            <div class="col-md-3 col-md-offset-2">
                                <asp:Button ID="btnFinalizarSeccion" runat="server" Text="Finalizar Seccion" CssClass="btn btn-block btn-danger" />
                            </div>
                        </div>
                        <br />
                    </div>
                    <br />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
