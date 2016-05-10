﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="agregarUsuario.aspx.vb" Inherits="VerdeUrbano.agregarUsuario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
    <br />
    <br />
    <div class="row">
        <div class="well well-lg col-md-12 msj-error" runat="server" visible="false" id="correcto">
            <asp:Label ID="lbl_AccionCorrecta" runat="server" CssClass="labelError"></asp:Label>
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
                        <asp:Label ID="lbl_AgregarUsuario" runat="server" Text="Agregar Usuario"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_NombreUsuario" runat="server" Text="Nombre de Usuario" CssClass="label"></asp:Label>
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
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_password" runat="server" Text="Contraseña" CssClass="label"></asp:Label>
                            </div>
                            <div class="col-md-6 col-md-offset-1">
                                <asp:TextBox ID="txtPass" runat="server" CssClass="caja-texto" TextMode="Password"></asp:TextBox>
                            </div>
                            <div class="col-md-1">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                    ControlToValidate="txtPass" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_repetirPassword" runat="server" Text="Repetir Contraseña" CssClass="label"></asp:Label>
                            </div>
                            <div class="col-md-6 col-md-offset-1">
                                <asp:TextBox ID="txtRepetirPass" runat="server" CssClass="caja-texto" TextMode="Password"></asp:TextBox>
                            </div>
                            <div class="col-md-1">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                                    ControlToValidate="txtRepetirPass" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_dni" runat="server" Text="DNI" CssClass="label"></asp:Label>
                            </div>
                            <div class="col-md-6 col-md-offset-1">
                                <asp:TextBox ID="txtDNI" runat="server" CssClass="caja-texto"></asp:TextBox>
                            </div>
                            <div class="col-md-1">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                    ControlToValidate="txtDNI" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_Perfil" runat="server" Text="Perfil" CssClass="label"></asp:Label>
                            </div>
                            <div class="col-md-6 col-md-offset-1">
                                <asp:DropDownList ID="ddl_Perfil" runat="server" CssClass="combo"></asp:DropDownList>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
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
