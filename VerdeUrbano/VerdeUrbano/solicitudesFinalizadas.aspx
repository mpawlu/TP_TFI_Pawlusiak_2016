<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="solicitudesFinalizadas.aspx.vb" Inherits="VerdeUrbano.solicitudesFinalizadas" %>
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
                        <asp:Label ID="lbl_solicitudesFinalizadas" runat="server" Text="Solicitudes Finalizadas"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <asp:GridView ID="gv_solicitudes" runat="server" CssClass="Grid-verde" AutoGenerateColumns="False" HorizontalAlign="Center">

                                    <Columns>
                                        <asp:BoundField DataField="ID" HeaderText="Código" HtmlEncode="False" />
                                        <asp:BoundField DataField="Titulo" HeaderText="Titulo" HtmlEncode="False" ControlStyle-CssClass="col-md-3" />
                                        <asp:BoundField DataField="Detalle" HeaderText="Detalle" HtmlEncode="False" ControlStyle-CssClass="col-md-4" />
                                        <asp:BoundField DataField="Disenador.NombreUsuario" HeaderText="Diseñandor" HtmlEncode="False" ControlStyle-CssClass="col-md-4" />
                                        <asp:BoundField DataField="Estado.Descripcion" HeaderText="Estado" HtmlEncode="False" ControlStyle-CssClass="col-md-1" />
                                        <asp:BoundField DataField="FechaLimiteDeCreacion" HeaderText="Fecha de vencimiento" HtmlEncode="False" ControlStyle-CssClass="col-md-1" />
                                        <asp:TemplateField HeaderText="Seleccionar" HeaderStyle-Width="20px">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chk_sel" runat="server" />
                                            </ItemTemplate>
                                            <HeaderStyle Width="20px"></HeaderStyle>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                            <br />
                            <br />
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-2 col-md-offset-5">
                                <asp:Button ID="btnAprobar" runat="server" Text="Aprobar" CssClass="btn btn-block btn-info" />
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
                <br />
            </div>
        </div>
    </div>

</asp:Content>

