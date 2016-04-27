<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="visualizarBitacora.aspx.vb" Inherits="VerdeUrbano.visualizarBitacora" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-10 col-md-offset-1">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">
                        <asp:Label ID="lblVisualizarBitacora" runat="server">Visualizar Bitacora</asp:Label>
                    </div>
                    <div class="panel-body">
                        <div class="fila">
                            <div class="col-md-4">
                                <div class="col-md-2 col-md-offset-2">
                                    <asp:ImageButton ID="imgfiltroUsuario" runat="server" ImageUrl="~/Imagenes/User-32.png" CssClass="IconoImagen center" />
                                </div>
                                <div class="col-md-6 margenFiltro">
                                    <asp:Label ID="lblUsuario" runat="server" CssClass="label">Usuario</asp:Label>
                                </div>
                            </div>

                            <div class="col-md-4">
                                <div class="col-md-2 col-md-offset-2">
                                    <asp:ImageButton ID="imgfiltroFecha" runat="server" ImageUrl="~/Imagenes/Calendar-32.png" CssClass="IconoImagen center" />
                                </div>
                                <div class="col-md-6 margenFiltro">
                                    <asp:Label ID="lblFecha" runat="server" CssClass="label">Fecha</asp:Label>
                                </div>

                            </div>
                            <div class="col-md-4">
                                <div class="col-md-2 col-md-offset-2">
                                    <asp:ImageButton ID="imgTipoPrioridad" runat="server" ImageUrl="~/Imagenes/Question-type-one-correct-32.png" CssClass="IconoImagen center" />
                                </div>
                                <div class="col-md-6 margenFiltro">
                                    <asp:Label ID="lblTipoOperacion" runat="server" CssClass="label">Tipo de Operacion</asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="fila">
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
                        <div class="fila">
                            <div class="col-md-2 col-md-offset-5">
                                <asp:Button ID="btn_buscar" runat="server" Text="Buscar" CssClass="btn btn-info btn-block" />
                            </div>
                        </div>
                    </div>

                    <div class="panel-cuerpo">
                        <div class="fila">
                            <asp:GridView ID="gv_Bitacora" runat="server" CssClass="Grid-verde" AutoGenerateColumns="False">
                                <Columns>
                                    <asp:BoundField DataField="ID_Evento" HeaderText="ID_Bitacora" Visible="False" />
                                    <asp:BoundField DataField="Usuario.NombreUsuario" HeaderText="Usuario" />
                                    <asp:BoundField DataField="TipoOperacion" HeaderText="Tipo de Operacion" />
                                    <asp:BoundField DataField="FechaHora" HeaderText="Fecha y Hora" />
                                    <asp:BoundField DataField="DescripcionEvento" HeaderText="Descripcion" />
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
