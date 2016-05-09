<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="agregarPerfil.aspx.vb" Inherits="VerdeUrbano.agregarPerfil" %>

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
            <div class="col-md-8 col-md-offset-2">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">
                        <asp:Label ID="lbl_AgregarUsuario" runat="server" Text="Agregar Usuario"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_Nombre" runat="server" Text="Nombre" CssClass="label"></asp:Label>
                            </div>

                            <div class="col-md-6 col-md-offset-1">
                                <asp:TextBox ID="txtNombre" runat="server" CssClass="caja-texto"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-6 col-md-offset-1">
                                <asp:TreeView ID="treeviewPermisos" runat="server" ExpandDepth="0" ForeColor="Black" CssClass="label" ShowCheckBoxes="all"></asp:TreeView>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-2 col-md-offset-3">
                                <asp:Button ID="btn_Guardar" runat="server" Text="Guardar" CssClass="btn btn-block btn-success" />
                            </div>
                            <div class="col-md-2 col-md-offset-2">
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-block btn-warning" />
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
