<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="examenFinalizado.aspx.vb" Inherits="VerdeUrbano.examenFinalizado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="//netdna.bootstrapcdn.com/font-awesome/4.0.3/css/font-awesome.min.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
     <br />
    <br />
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
                        <div id="aprobado" runat="server" visible="false">
                            <div class="row">
                                <div class="col-md-10 col-md-offset-1">
                                    <div class="well notaResumen">
                                        <div class="col-md-2">
                                            <figure>
                                                <div class="circle-tile-heading"><i class="fa fa-thumbs-o-up fa-fw fa-3x"></i></div>
                                            </figure>
                                        </div>
                                        <div class="col-md-8">
                                            <asp:Label ID="lbl_Atitulo" runat="server" Text="Aprobado" CssClass="notaResumen-titulo"></asp:Label>
                                            <br />
                                            <asp:Label ID="lbl_Acorrectas" runat="server" CssClass="notaResumen-texto"></asp:Label>

                                        </div>
                                        <div class="col-md-2 text-center">
                                            <p>
                                                <asp:Label ID="lbl_Arating" runat="server" CssClass="notaResumen-rating"></asp:Label>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div id="desaprobado" runat="server" visible="false">
                            <div class="row">
                                <div class="col-md-10 col-md-offset-1">
                                    <div class="well notaResumendes">
                                        <div class="col-md-2">
                                            <figure>
                                                <div class="circle-tile-heading"><i class="fa fa-thumbs-o-down fa-fw fa-3x"></i></div>
                                            </figure>
                                        </div>
                                        <div class="col-md-8">
                                            <asp:Label ID="lbl_Dtitulo" runat="server" Text="Desaprobado" CssClass="notaResumen-titulo"></asp:Label>
                                            <br />
                                            <asp:Label ID="lbl_Dcorrectas" runat="server" Text="Preguntas Correctas: 2/10" CssClass="notaResumen-texto"></asp:Label>

                                        </div>
                                        <div class="col-md-2 text-center">
                                            <p>
                                                <asp:Label ID="lbl_Drating" runat="server" Text="2" CssClass="notaResumen-rating"></asp:Label>
                                            </p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
  
                        <div class="row">
                            <div class="col-md-8 col-md-offset-2">
                                <asp:Panel ID="panelPreguntas" runat="server">
                                    <div id="pregunta1" runat="server">
                                        <asp:Label ID="lbl_pregunta1" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_1" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:RadioButtonList ID="rb_pregunta1" runat="server"></asp:RadioButtonList>
                                    </div>
                                    <br />
                                    <br />
                                    <div id="pregunta2" runat="server">
                                        <asp:Label ID="lbl_pregunta2" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_2" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:RadioButtonList ID="rb_pregunta2" runat="server"></asp:RadioButtonList>
                                    </div>
                                    <br />
                                    <br />
                                    <div id="pregunta3" runat="server">
                                        <asp:Label ID="lbl_pregunta3" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_3" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:RadioButtonList ID="rb_pregunta3" runat="server"></asp:RadioButtonList>
                                    </div>
                                    <br />
                                    <br />
                                    <div id="pregunta4" runat="server">
                                        <asp:Label ID="lbl_pregunta4" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_4" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:RadioButtonList ID="rb_pregunta4" runat="server"></asp:RadioButtonList>
                                    </div>
                                    <br />
                                    <br />
                                    <div id="pregunta5" runat="server">
                                        <asp:Label ID="lbl_pregunta5" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_5" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:RadioButtonList ID="rb_pregunta5" runat="server"></asp:RadioButtonList>
                                    </div>

                                    <br />
                                    <br />
                                    <div id="pregunta6" runat="server">
                                        <asp:Label ID="lbl_pregunta6" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_6" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:RadioButtonList ID="rb_pregunta6" runat="server"></asp:RadioButtonList>
                                    </div>

                                    <br />
                                    <br />
                                    <div id="pregunta7" runat="server">
                                        <asp:Label ID="lbl_pregunta7" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_7" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:RadioButtonList ID="rb_pregunta7" runat="server"></asp:RadioButtonList>
                                    </div>

                                    <br />
                                    <br />
                                    <div id="pregunta8" runat="server">
                                        <asp:Label ID="lbl_pregunta8" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_8" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:RadioButtonList ID="rb_pregunta8" runat="server"></asp:RadioButtonList>
                                    </div>

                                    <br />
                                    <br />
                                    <div id="pregunta9" runat="server">
                                        <asp:Label ID="lbl_pregunta9" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_9" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:RadioButtonList ID="rb_pregunta9" runat="server"></asp:RadioButtonList>
                                    </div>

                                    <br />
                                    <br />
                                    <div id="pregunta10" runat="server">
                                        <asp:Label ID="lbl_pregunta10" runat="server" CssClass="label"></asp:Label>
                                        <asp:Label ID="id_10" runat="server" Visible="false"></asp:Label>
                                        <br />
                                        <br />
                                        <asp:RadioButtonList ID="rb_pregunta10" runat="server"></asp:RadioButtonList>
                                    </div>
                                </asp:Panel>
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
