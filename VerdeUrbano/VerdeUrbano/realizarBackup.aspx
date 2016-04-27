<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="realizarBackup.aspx.vb" Inherits="VerdeUrbano.realizarBackup" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
    <br />
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-8 col-md-offset-2">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">Realizar Backup</div>
                    <div class="panel-body">
                        <br />
                        <div class="row">
                            <div class="col-md-2 col-md-offset-1">
                                <asp:Label ID="lblNombre" runat="server" CssClass="label">Nombre</asp:Label>

                            </div>
                            <div class="col-md-5 col-md-offset-2">
                                <asp:TextBox ID="txtnombre" runat="server" CssClass="caja-texto" MaxLength="100"></asp:TextBox>
                            </div>
                            <div class="col-md-1 col-md-offset-1">
                                <asp:RequiredFieldValidator ID="requerido_txt_nombre" runat="server"
                                    ControlToValidate="txtnombre" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>

                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-2 col-md-offset-1">
                                <asp:Label ID="lblDirectorio" runat="server" CssClass="label">Directorio</asp:Label>
                            </div>
                            <div class="col-md-5 col-md-offset-2">
                                <asp:TextBox ID="txtDirectorio" runat="server" CssClass="caja-texto" MaxLength="200"></asp:TextBox>
                            </div>
                            <div class="col-md-1 col-md-offset-1">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatortxt_Directorio" runat="server"
                                    ControlToValidate="txtDirectorio" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>

                            </div>
                        </div>

                        <br />
                        <br />

                        <div class="fila">
                            <div class="col-md-2 col-md-offset-3">
                                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-success btn-block" />
                            </div>
                            <div class="col-md-2 col-md-offset-2">
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-warning btn-block" />
                            </div>
                        </div>
                                                                        <br />
                        <br />

                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
