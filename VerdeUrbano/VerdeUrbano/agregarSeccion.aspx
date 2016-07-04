<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="agregarSeccion.aspx.vb" Inherits="VerdeUrbano.agregarSeccion" %>

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
                        <asp:Label ID="lbl_agregarSeccion" runat="server" Text="Agregar Seccion"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />

                        <div class="row">
                            <div class="col-md-3 col-md-offset-5">
                                <asp:Label ID="lbl_nombreCurso" runat="server" Text="Nombre del curso" CssClass="label subrayado"></asp:Label>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_tituloSeccion" runat="server" Text="Titulo de la Seccion: " CssClass="label"></asp:Label>
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
                                <asp:Label ID="lbl_descripcion" runat="server" Text="Descripcion" CssClass="label"></asp:Label>
                            </div>

                            <div class="col-md-6 col-md-offset-1">
                                <asp:TextBox ID="txtDescripcion" runat="server" CssClass="textarea" TextMode="MultiLine" Height="200px"></asp:TextBox>
                            </div>
                            <div class="col-md-1">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                    ControlToValidate="txtDescripcion" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-4 col-md-offset-1">
                                <asp:Button ID="btnAgregarSlide" runat="server" Text="Agregar Slide a Seccion >>" CssClass="btn btn-block btn-success" />
                            </div>
                                                        <div class="col-md-4 col-md-offset-2">
                                <asp:Button ID="Button1" runat="server" Text="Cancelar" CssClass="btn btn-block btn-warning" />
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
