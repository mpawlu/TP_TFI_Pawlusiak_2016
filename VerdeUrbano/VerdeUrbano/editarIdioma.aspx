<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="editarIdioma.aspx.vb" Inherits="VerdeUrbano.editarIdioma" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <meta http-equiv="content-type" content="text/html"/>

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
            <div class="col-md-10 col-md-offset-1">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">
                        <asp:Label ID="lbl_EditarIdioma" runat="server" Text ="Editar Idioma"></asp:Label>
                    </div>
                    <div class="panel-body">
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
                    </div>
                    <br />
                    <div class="row">
                        <div class="col-md-10 col-md-offset-1">
                            <asp:GridView ID="gv_Palabras" runat="server" CssClass="Grid-verde" AutoGenerateColumns="False" HorizontalAlign="Center">

                                <Columns>
                                    <asp:BoundField DataField="ID" HeaderText="ID" HtmlEncode="False" />
                                    <asp:BoundField DataField="Leyenda" HeaderText="Leyenda" HtmlEncode="False"/>
                                    <asp:TemplateField HeaderText="Nuevo Texto" HeaderStyle-Width="400px">
                                        <ItemTemplate>
                                            <asp:TextBox Width="350px" runat="server" CssClass="textarea" TextMode="MultiLine" Wrap="true"></asp:TextBox>
                                        </ItemTemplate>
                                        <HeaderStyle Width="350px"></HeaderStyle>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </div>
                    <br />
                    <br />
                    <br />
                    <div class="row">
                        <div class="col-md-2 col-md-offset-3">
                            <asp:Button ID="btn_Agregar" runat="server" Text="Agregar" CssClass="btn btn-success btn-block" />
                        </div>
                        <div class="col-md-2 col-md-offset-2">
                            <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-warning btn-block" />
                        </div>
                    </div>
                    <br />
                </div>
            </div>
        </div>
    </div>
</asp:Content>
