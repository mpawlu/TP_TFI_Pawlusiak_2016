<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="crearCurso.aspx.vb" Inherits="VerdeUrbano.crearCurso" %>
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
                        <asp:Label ID="lbl_SolicitudAsociaada" runat="server" Text="Solicitud Asociada"></asp:Label>
                                                    <div class="col-md-10 col-md-offset-1">
                                <asp:GridView ID="gv_solicitudes" runat="server" CssClass="Grid-verde" AutoGenerateColumns="False" HorizontalAlign="Center">

                                    <Columns>
                                        <asp:BoundField DataField="ID" HeaderText="Código" HtmlEncode="False" />
                                        <asp:BoundField DataField="Titulo" HeaderText="Titulo" HtmlEncode="False" ControlStyle-CssClass="col-md-3" />
                                        <asp:BoundField DataField="Detalle" HeaderText="Detalle" HtmlEncode="False" ControlStyle-CssClass="col-md-4" />
                                        <asp:BoundField DataField="Estado.Descripcion" HeaderText="Estado" HtmlEncode="False" ControlStyle-CssClass="col-md-1" />
                                        <asp:BoundField DataField="FechaLimiteDeCreacion" HeaderText="Fecha de vencimiento" HtmlEncode="False" ControlStyle-CssClass="col-md-1" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_nombre" runat="server" Text="Nombre" CssClass="label"></asp:Label>
                            </div>

                            <div class="col-md-6 col-md-offset-1">
                                <asp:TextBox ID="txtNombre" runat="server" CssClass="caja-texto"></asp:TextBox>
                            </div>
                            <div class="col-md-1">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                    ControlToValidate="txtNombre" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_descripcion" runat="server" Text="Descripcion" CssClass="label"></asp:Label>
                            </div>

                            <div class="col-md-6 col-md-offset-1">
                                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="caja-texto"></asp:TextBox>
                            </div>
                            <div class="col-md-1">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                    ControlToValidate="txtDescripcion" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                            </div>
                        </div>
          
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_Duracion" runat="server" Text="Duracion" CssClass="label"></asp:Label>
                            </div>

                            <div class="col-md-6 col-md-offset-1">
                                <asp:TextBox ID="txtDuracion" runat="server" CssClass="caja-texto" MaxLength="12"></asp:TextBox>

                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-2 col-md-offset-2">
                                <asp:Button ID="btnAgregarSeccion" runat="server" Text="Agregar Seccion >>" CssClass="btn btn-block btn-info" />
                            </div>
                        </div>
                                                <div class="row">
                            <div class="col-md-2 col-md-offset-4">
                                <asp:Button ID="btnFinalizarCurso" runat="server" Text="Finalizar Curso" CssClass="btn btn-block btn-info" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
