<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="crearEvaluacion.aspx.vb" Inherits="VerdeUrbano.crearEvaluacion" %>
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
        <div class="fila">
            <div class="col-md-10 col-md-offset-1">
                <div class="panel panel-verde">
                    <div class="panel-cabecera">
                        <asp:Label ID="cab_agregarPregunta" runat="server">Agregar Pregunta de Examen</asp:Label>
                    </div>
                    <div class="panel-cuerpo">
                        <br />
                        <br />

                        <div class="fila">
                            <div class="col-md-4 col-md-offset-1">
                                <div class="label">
                                    <asp:Label ID="lbl_Enunciado" runat="server" CssClass="label">Enunciado</asp:Label>
                                </div>
                            </div>
                            <div class="col-md-4 col-md-offset-1">
                                <asp:TextBox ID="txt_Enunciado" runat="server" CssClass="caja-texto sinEditar" Height="150px" TextMode="MultiLine" MaxLength="400"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <div id="OpcionesPregunta" runat="server" visible="false">
                            <div class="fila">
                                <div class="col-md-3 col-md-offset-2">
                                    <asp:Label ID="lbl_Opcion1" runat="server" Text="Opcion Correcta" CssClass="label"></asp:Label>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <asp:TextBox ID="txt_Opcion1" runat="server" CssClass="caja-texto" MaxLength="100"></asp:TextBox>
                                </div>
                            </div>
                            <br />
                            <div class="fila">
                                <div class="col-md-3 col-md-offset-2">
                                    <asp:Label ID="lbl_opcion2" runat="server" Text="Opcion 1" CssClass="label"></asp:Label>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <asp:TextBox ID="txt_Opcion2" runat="server" CssClass="caja-texto" MaxLength="100"></asp:TextBox>
                                </div>
                            </div>
                            <br />
                            <div class="fila">
                                <div class="col-md-3 col-md-offset-2">
                                    <asp:Label ID="lbl_Opcion3" runat="server" Text="Opcion 2" CssClass="label"></asp:Label>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <asp:TextBox ID="txt_Opcion3" runat="server" CssClass="caja-texto" MaxLength="100"></asp:TextBox>
                                </div>
                            </div>
                            <br />
                            <div class="fila">
                                <div class="col-md-3 col-md-offset-2">
                                    <asp:Label ID="lbl_Opcion4" runat="server" Text="Opcion 3" CssClass="label"></asp:Label>
                                </div>
                                <div class="col-md-4 col-md-offset-1">
                                    <asp:TextBox ID="txt_Opcion4" runat="server" CssClass="caja-texto" MaxLength="100"></asp:TextBox>
                                </div>
                            </div>
                            <br />
                        </div>


                        <div class="fila">
                            <div class="col-md-4 col-md-offset-1">
                                <asp:Label ID="lbl_Valor" runat="server" Text="Valor" CssClass="label"></asp:Label>
                            </div>
                            <div class="col-md-4 col-md-offset-1">
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
                        <div class="fila">
                            <div class="col-md-2 col-md-offset-3">
                                <asp:Button ID="btn_agregar" runat="server" Text="Agregar" CssClass="btn btn-aceptar btn-block" />
                            </div>
                            <div class="col-md-2 col-md-offset-2">
                                <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" CssClass="btn btn-cancelar btn-block" />
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</asp:Content>
