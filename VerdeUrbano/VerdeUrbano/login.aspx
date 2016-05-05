<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="login.aspx.vb" Inherits="VerdeUrbano.login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
    <br />
    <div class="container-fluid">
        <br />
        <br />
        <div class="row">
            <div class="well well-lg col-md-12 msj-error" runat="server" visible="false" id="error">
                <asp:Label ID="lbl_TituloError" runat="server" CssClass="labelError"></asp:Label>
            </div>
        </div>
        <div class="col-md-8 col-md-offset-2">
            <div class="panel panel-verdeClaro">
                <div class="panel-heading">Autenticación</div>
                <div class="panel-body">
                    <br />
                    <br />

                    <div class="row">
                        <div class="col-md-1  col-md-offset-2">
                            <asp:Image ID="img_user" runat="server" ImageUrl="~/Imagenes/user-32.png" />
                        </div>
                        <div class="col-md-2">
                            <asp:Label ID="lbl_Usuario" runat="server" CssClass="label">Usuario</asp:Label>
                        </div>
                        <div class="col-md-4 col-md-offset-1">
                            <asp:TextBox ID="txt_usuario" runat="server" CssClass="caja-texto" MaxLength="100"></asp:TextBox>
                        </div>
                        <div class="col-md-1 col-md-offset-1">
                            <asp:RequiredFieldValidator ID="requerido_txt_usuario" runat="server"
                                ControlToValidate="txt_usuario" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-1  col-md-offset-2">
                            <asp:Image ID="img_pass" runat="server" ImageUrl="~/Imagenes/Key-32.png" />
                        </div>
                        <div class="col-md-2">
                            <asp:Label ID="lbl_password" runat="server" CssClass="label">Contraseña</asp:Label>
                        </div>
                        <div class="col-md-4 col-md-offset-1">
                            <asp:TextBox ID="txt_password" runat="server" CssClass="caja-texto" TextMode="Password" MaxLength="100"></asp:TextBox>
                        </div>
                        <div class="col-md-1 col-md-offset-1">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidatortxt_password" runat="server"
                                ControlToValidate="txt_password" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-3 col-md-offset-8">
                            <asp:LinkButton ID="lb_OlvidoClave" PostBackUrl="~/recuperarClave.aspx" runat="server">¿Olvidó su clave?</asp:LinkButton>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-2 col-md-offset-5">
                            <asp:Button ID="btn_login" runat="server" Text="Aceptar" CssClass="btn btn-success btn-block" />
                        </div>
                    </div>
                </div>

            </div>
                    <br />
        <br />
        </div>

    </div>
</asp:Content>
