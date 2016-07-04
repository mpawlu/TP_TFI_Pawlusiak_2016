<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="ResumenCreacionCurso.aspx.vb" Inherits="VerdeUrbano.ResumenCreacionCurso" %>

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
    <div class="container-fluid">
        <div class="row" id="cursoNormal" runat="server">
            <div class="col-md-8 col-md-offset-2">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">
                        <asp:Label ID="lbl_ResumenCurso" runat="server" Text="Resumen de Curso"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lblNombreCurso" runat="server" Text="Curso:" CssClass="label subrayado"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lblValorNombre" runat="server" Text="Titulo del Curso" CssClass="label"></asp:Label>
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
                                <asp:Label ID="lblValordescripcion" runat="server" Text="Descripcion del curso" CssClass="label"></asp:Label>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lblsecciones" runat="server" Text="Secciones:" CssClass="label subrayado"></asp:Label>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <asp:GridView ID="gv_Secciones" runat="server" CssClass="Grid-verde" AutoGenerateColumns="False" HorizontalAlign="Center">
                                    <Columns>
                                        <asp:BoundField DataField="Titulo" HeaderText="Titulo" HtmlEncode="False" ControlStyle-CssClass="col-md-3" />
                                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" HtmlEncode="False" ControlStyle-CssClass="col-md-4" />
                                        <asp:BoundField DataField="Slides.count" HeaderText="Cantidad de slides" HtmlEncode="False" ControlStyle-CssClass="col-md-4" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                            <br />
                            <br />
                        </div>

                        <br />
                        <div class="row">
                            <div class="col-md-2 col-md-offset-2">
                                <asp:Button ID="btnAgregarSeccion" runat="server" Text="Agregar Seccion" CssClass="btn btn-block btn-info" />
                            </div>
                            <div class="col-md-2 col-md-offset-1">
                                <asp:Button ID="btnCrearEvaluacion" runat="server" Text="Crear Evaluacion" CssClass="btn btn-block btn-success" />
                            </div>
                            <div class="col-md-2 col-md-offset-1">
                                <asp:Button ID="btnFinalizarCurso" runat="server" Text="Finalizar Curso" CssClass="btn btn-block btn-danger" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div id="Finalizado" runat="server" visible="false">
            <br />

            <div class="row">
                <div class="col-md-2 col-md-offset-5">
                    <asp:Button ID="btnVolver" runat="server" Text="Volver" CssClass="btn btn-block btn-warning" />
                </div>
            </div>
            <br />
            <br />
            <br />
        </div>
    </div>
</asp:Content>
