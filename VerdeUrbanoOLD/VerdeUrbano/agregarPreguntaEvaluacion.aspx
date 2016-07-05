<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="agregarPreguntaEvaluacion.aspx.vb" Inherits="VerdeUrbano.crearEvaluacion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
    <div class="contenedor">
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
        <br />
        <div class="container-fluid">
            <div class="col-md-8 col-md-offset-2">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">
                        <asp:Label ID="lbl_CrearEvaluacion" runat="server" Text="Crear Evaluacion"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-3  col-md-offset-1">
                                <asp:Label ID="lbl_Enunciado" runat="server" CssClass="label">Enunciado</asp:Label>
                            </div>
                            <div class="col-md-6 col-md-offset-1">
                                <asp:TextBox ID="txt_Enunciado" runat="server" CssClass="textarea" Height="150px" TextMode="MultiLine" MaxLength="400"></asp:TextBox>
                            </div>
                            <div class="col-md-1">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                    ControlToValidate="txt_Enunciado" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    <br />
                    <div class="row">
                        <div class="col-md-3 col-md-offset-1">
                            <asp:Label ID="lbl_Opcion1" runat="server" Text="Opcion Correcta" CssClass="label"></asp:Label>
                        </div>
                        <div class="col-md-6 col-md-offset-1">
                            <asp:TextBox ID="txt_Opcion1" runat="server" CssClass="caja-texto" MaxLength="100"></asp:TextBox>
                        </div>
                        <div class="col-md-1">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                ControlToValidate="txt_Opcion1" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-3 col-md-offset-1">
                            <asp:Label ID="lbl_opcion2" runat="server" Text="Opcion 1" CssClass="label"></asp:Label>
                        </div>
                        <div class="col-md-6 col-md-offset-1">
                            <asp:TextBox ID="txt_Opcion2" runat="server" CssClass="caja-texto" MaxLength="100"></asp:TextBox>
                        </div>
                        <div class="col-md-1">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
                                ControlToValidate="txt_Opcion2" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-3 col-md-offset-1">
                            <asp:Label ID="lbl_Opcion3" runat="server" Text="Opcion 2" CssClass="label"></asp:Label>
                        </div>
                        <div class="col-md-6 col-md-offset-1">
                            <asp:TextBox ID="txt_Opcion3" runat="server" CssClass="caja-texto" MaxLength="100"></asp:TextBox>
                        </div>
                        <div class="col-md-1">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"
                                ControlToValidate="txt_Opcion3" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-3 col-md-offset-1">
                            <asp:Label ID="lbl_Opcion4" runat="server" Text="Opcion 3" CssClass="label"></asp:Label>
                        </div>
                        <div class="col-md-6 col-md-offset-1">
                            <asp:TextBox ID="txt_Opcion4" runat="server" CssClass="caja-texto" MaxLength="100"></asp:TextBox>
                        </div>
                        <div class="col-md-1">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server"
                                ControlToValidate="txt_Opcion4" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-3 col-md-offset-1">
                            <asp:Label ID="lbl_Valor" runat="server" Text="Valor" CssClass="label"></asp:Label>
                        </div>
                        <div class="col-md-6 col-md-offset-1">
                            <asp:DropDownList ID="ddl_Valor" runat="server" CssClass="combo">
                                <asp:ListItem Value="01"></asp:ListItem>
                                <asp:ListItem Value="02"></asp:ListItem>
                                <asp:ListItem Value="03"></asp:ListItem>
                                <asp:ListItem>04</asp:ListItem>
                                <asp:ListItem Selected="True" Value="05"></asp:ListItem>
                                <asp:ListItem>06</asp:ListItem>
                                <asp:ListItem>07</asp:ListItem>
                                <asp:ListItem>08</asp:ListItem>
                                <asp:ListItem>09</asp:ListItem>
                                <asp:ListItem>10</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <br />
                    <br />
                    <div class="row">
                        <div class="col-md-2 col-md-offset-3">
                            <asp:Button ID="btn_agregar" runat="server" Text="Agregar" CssClass="btn btn-success btn-block" />
                        </div>
                        <div class="col-md-2 col-md-offset-2">
                            <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" CssClass="btn btn-warning btn-block" />
                        </div>
                    </div>
                    <br />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
