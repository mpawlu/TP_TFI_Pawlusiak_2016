<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="crearEvaluacion.aspx.vb" Inherits="VerdeUrbano.crearEvaluacion1" %>
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
        <div class="row">
            <div class="col-md-8 col-md-offset-2">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">
                        <asp:Label ID="lbl_CrearCurso" runat="server" Text="Crear Curso"></asp:Label>
                    </div>
                    <div class="panel-body">
                       <br />
                            <div class="row">
                                <div class="col-md-3 col-md-offset-1">
                                    <asp:Label ID="lbl_titulo" runat="server" Text="Titulo: " CssClass="label"></asp:Label>
                                </div>

                                <div class="col-md-6 col-md-offset-1">
                                    <asp:TextBox ID="txtTitulo" runat="server" CssClass="caja-texto"></asp:TextBox>
                                </div>
                                <div class="col-md-1">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                        ControlToValidate="txtTitulo" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_subTitulo" runat="server" Text="Subtitulo(Opcional): " CssClass="label"></asp:Label>
                            </div>

                            <div class="col-md-6 col-md-offset-1">
                                <asp:TextBox ID="txtSubtitulo" runat="server" CssClass="textarea" TextMode="MultiLine" Height="200px"></asp:TextBox>
                            </div>

                        </div>
                        <br />
                                                    <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <asp:GridView ID="gv_Preguntas" runat="server" CssClass="Grid-verde" AutoGenerateColumns="False" HorizontalAlign="Center" Visible ="false">
                                    <Columns>
                                        <%--<asp:BoundField DataField="." HeaderText="Numero" HtmlEncode="False" ControlStyle-CssClass="col-md-3" />--%>
                                        <asp:BoundField DataField="Pregunta" HeaderText="Titulo" HtmlEncode="False" ControlStyle-CssClass="col-md-3" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                            <br />
                            <br />
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-2">
                                <asp:Button ID="btnAgregarPregunta" runat="server" Text="Agregar Pregunta >>" CssClass="btn btn-block btn-success" />
                            </div>
                            <div class="col-md-3 col-md-offset-2">
                                <asp:Button ID="btnFinalizarEdicion" runat="server" Text="Finalizar Edicion" CssClass="btn btn-block btn-danger" />
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
