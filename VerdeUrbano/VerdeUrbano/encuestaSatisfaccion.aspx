<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="encuestaSatisfaccion.aspx.vb" Inherits="VerdeUrbano.encuestaSatisfaccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="JS/jquery-1.9.1.min.js"></script>
    <script src="JS/jquery-ui.js"></script>
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
                        <asp:Label ID="lbl_EncuestaSatisfaccion" runat="server" Text="Encuesta de Satisfaccion"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <asp:Panel ID="panelPreguntas" runat="server">
                                    <div id="pregunta1" runat="server">
                                        <asp:Label ID="lbl_pregunta1" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_1" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:DropDownList ID="ddl_preg1" runat="server"></asp:DropDownList>
                                        <br />
                                        <br />
                                    </div>
                                    <div id="pregunta2" runat="server">
                                        <asp:Label ID="lbl_pregunta2" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_2" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:DropDownList ID="ddl_preg2" runat="server"></asp:DropDownList>
                                        <br />
                                        <br />
                                    </div>

                                    <div id="pregunta3" runat="server">
                                        <asp:Label ID="lbl_pregunta3" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_3" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:RadioButtonList ID="rb_pregunta3" runat="server"></asp:RadioButtonList>
                                        <br />
                                        <br />
                                    </div>

                                    <div id="pregunta4" runat="server">
                                        <asp:Label ID="lbl_pregunta4" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_4" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:RadioButtonList ID="rb_pregunta4" runat="server"></asp:RadioButtonList>
                                        <br />
                                        <br />
                                    </div>

                                    <div id="pregunta5" runat="server">
                                        <asp:Label ID="lbl_pregunta5" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_5" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:RadioButtonList ID="rb_pregunta5" runat="server"></asp:RadioButtonList>
                                        <br />
                                        <br />
                                    </div>

                                    <div id="pregunta6" runat="server">
                                        <asp:Label ID="lbl_pregunta6" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_6" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:RadioButtonList ID="rb_pregunta6" runat="server"></asp:RadioButtonList>
                                        <br />
                                        <br />
                                    </div>
                                    <div id="pregunta7" runat="server">
                                        <asp:Label ID="lbl_pregunta7" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_7" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:RadioButtonList ID="rb_pregunta7" runat="server"></asp:RadioButtonList>
                                        <br />
                                        <br />
                                    </div>

                          
                                </asp:Panel>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-2 col-md-offset-5">
                                <asp:Button ID="btnFinalizar" runat="server" Text="Finalizar" CssClass="btn btn-block btn-danger" />
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>

