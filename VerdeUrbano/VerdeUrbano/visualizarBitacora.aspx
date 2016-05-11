<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="visualizarBitacora.aspx.vb" Inherits="VerdeUrbano.visualizarBitacora" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="JS/jquery-1.9.1.min.js"></script>
    <script src="JS/jquery-ui.js"></script>
    <link href="CSS/DateTimePicker.css" rel="stylesheet" type="text/css" />
    <script>
        $(function () {
            $("#contenidoPagina_datepicker").datepicker();
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
            <div class="col-md-10 col-md-offset-1">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">
                        <asp:Label ID="lbl_VisualizarBitacora" runat="server" Text="Visualizar Bitacora"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />
                        <div class="row">
                            <div class="col-md-4">
                                <div class="col-md-2 col-md-offset-1">
                                    <asp:ImageButton ID="imgfiltroUsuario" runat="server" ImageUrl="~/Imagenes/User-32.png" CssClass="IconoImagen center" />
                                </div>
                                <div class="col-md-6 margenFiltro">
                                    <asp:Label ID="lbl_Usuario" runat="server" CssClass="label" Text="Usuario"></asp:Label>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <div class="col-md-2 col-md-offset-1">
                                    <asp:ImageButton ID="imgfiltroFecha" runat="server" ImageUrl="~/Imagenes/Calendar-32.png" CssClass="IconoImagen center" />
                                </div>
                                <div class="col-md-6 margenFiltro">
                                    <asp:Label ID="lbl_Fecha" runat="server" CssClass="label" Text="Fecha"></asp:Label>
                                </div>

                            </div>
                            <div class="col-md-4">
                                <div class="col-md-2 col-md-offset-1">
                                    <asp:ImageButton ID="imgTipoPrioridad" runat="server" ImageUrl="~/Imagenes/Question-type-one-correct-32.png" CssClass="IconoImagen center" />
                                </div>
                                <div class="col-md-6 margenFiltro">
                                    <asp:Label ID="lbl_TipoOperacion" runat="server" CssClass="label" Text="Tipo de Operacion"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <div class="col-md-10 col-md-offset-1">
                                    <asp:DropDownList ID="ddlUsuario" runat="server" CssClass="combo"></asp:DropDownList>
                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="col-md-10 col-md-offset-1">
                                    <asp:TextBox ID="datepicker" runat="server" CssClass="caja-texto"></asp:TextBox>
                                </div>
                                <div class="col-md-2 col-md-offset-1">
                                    <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToValidate="datepicker" Type="Date" Operator="DataTypeCheck" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador" />

                                </div>
                            </div>
                            <div class="col-md-4">
                                <div class="col-md-10 col-md-offset-1">
                                    <asp:DropDownList ID="ddlOperacion" runat="server" CssClass="combo">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-2 col-md-offset-5">
                                <asp:Button ID="btn_buscar" runat="server" Text="Buscar" CssClass="btn btn-info btn-block" />
                            </div>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-10 col-md-offset-1">
                            <asp:GridView ID="gv_Bitacora" runat="server" CssClass="Grid-verde" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField DataField="ID_Evento" HeaderText="ID_Bitacora" Visible="true" />
                                    <asp:BoundField DataField="Usuario.NombreUsuario" HeaderText="Usuario" />
                                    <asp:BoundField DataField="TipoOperacion" HeaderText="Tipo de Operacion" />
                                    <asp:BoundField DataField="FechaHora" HeaderText="Fecha y Hora" />
                                    <asp:BoundField DataField="DescripcionEvento" HeaderText="Descripcion" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                    <br />
                    <div class="col-md-6  col-md-offset-10">
                    <asp:Button ID ="btnAnterior" runat= "server"  Text="<" />

                    <asp:Button ID ="btnSiguiente" runat= "server"  Text=">" />
                        </div>
                    <br />
                    <br />
                </div>

            </div>
        </div>
    </div>
</asp:Content>
