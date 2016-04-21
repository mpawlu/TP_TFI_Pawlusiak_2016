<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="agregarUsuario.aspx.vb" Inherits="VerdeUrbano.agregarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
    <br />
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-8 col-md-offset-2">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">Agregar Usuario</div>
                    <div class="panel-body">
                        <br />
                        <div class="form-group">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_NombreUsuario" runat="server" Text="Nombre de Usuario" CssClass="label"></asp:Label>
                            </div>

                            <div class="col-md-6 col-md-offset-1">
                                <asp:TextBox ID="txtNombre" runat="server" CssClass="caja-texto"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_password" runat="server" Text="Contraseña" CssClass="label"></asp:Label>
                            </div>
                            <div class="col-md-6 col-md-offset-1">
                                <asp:TextBox ID="txtPass" runat="server" CssClass="caja-texto"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_dni" runat="server" Text="DNI" CssClass="label"></asp:Label>
                            </div>
                            <div class="col-md-6 col-md-offset-1">
                                <asp:TextBox ID="txtDNI" runat="server" CssClass="caja-texto"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:RadioButton ID="bloqueado" runat="server" Text="Bloqueado" CssClass="label" TextAlign="left" />
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_Perfil" runat="server" Text="Perfil" CssClass="label"></asp:Label>
                            </div>
                            <div class="col-md-6 col-md-offset-1">
                                <asp:DropDownList ID="ddl_Perfil" runat="server" CssClass="combo"></asp:DropDownList>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="form-group">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_Idioma" runat="server" Text="Idioma" CssClass="label"></asp:Label>
                            </div>
                            <div class="col-md-6 col-md-offset-1">
                                <asp:DropDownList ID="ddl_idioma" runat="server" CssClass="combo"></asp:DropDownList>
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-2 col-md-offset-3">
                                <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="btn btn-block btn-success" />
                            </div>
                            <div class="col-md-2 col-md-offset-2">
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-block btn-warning" />
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
