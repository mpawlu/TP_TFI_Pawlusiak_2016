<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="iniciarCurso.aspx.vb" Inherits="VerdeUrbano.iniciarCurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lblNombreCurso" runat="server" Text="Curso:" CssClass="label subrayado"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lblValorNombre" runat="server" Text="Titulo del Curso" CssClass="label"></asp:Label>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbldescripcion" runat="server" Text="Descripcion:" CssClass="label subrayado"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <asp:TextBox ID="descripcion" runat="server" CssClass="textareaSinBorde" TextMode="MultiLine" Enabled="false" Height="150px"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lblDuracion" runat="server" Text="Duracion:" CssClass="label subrayado"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lblValorDuracion" runat="server" Text="80" CssClass="label"></asp:Label>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lblsecciones" runat="server" Text="Secciones:" CssClass="label subrayado"></asp:Label>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <asp:GridView ID="gv_Secciones" runat="server" CssClass="Grid-verde" AutoGenerateColumns="False" HorizontalAlign="Center">
                                    <Columns>
                                        <asp:BoundField DataField="Titulo" HeaderText="Titulo" HtmlEncode="False" ControlStyle-CssClass="col-md-3" />
                                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" HtmlEncode="False" ControlStyle-CssClass="col-md-4" />
                                        <asp:BoundField DataField="Slides.count" HeaderText="Cantidad de slides" HtmlEncode="False" ControlStyle-CssClass="col-md-4" />
                                    </Columns>
                                </asp:GridView>
                            </div>
                            <br />
                            <br />
                        </div>

                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-4 col-md-offset-4">
                                <asp:Button ID="btnComenzar" runat="server" Text="Comenzar" CssClass="btn btn-block btn-info" />
                            </div>
                        </div>

                        <br />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
