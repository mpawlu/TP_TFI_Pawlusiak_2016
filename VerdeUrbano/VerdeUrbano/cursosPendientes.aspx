<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="cursosPendientes.aspx.vb" Inherits="VerdeUrbano.cursosPendientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="JS/jquery-1.9.1.min.js"></script>
    <script src="JS/jquery-ui.js"></script>
    <link href="CSS/DateTimePicker.css" rel="stylesheet" type="text/css" />
    <script>
        $(function () {
            $("#contenidoPagina_txtFechaCreacion").datepicker();
        });
    </script>
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
            <div class="col-md-8 col-md-offset-2">
                <div class="panel panel-verdeClaro">
         
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <asp:GridView ID="gv_cursos" runat="server" CssClass="Grid-verde" AutoGenerateColumns="False" HorizontalAlign="Center">

                                    <Columns>
                                        <asp:BoundField DataField="Curso.ID" HeaderText="Curso" HtmlEncode="False" />
                                        <asp:BoundField DataField="Curso.Nombre" HeaderText="Nombre" HtmlEncode="False" />
                                        <asp:BoundField DataField="Curso.Descripcion" HeaderText="Descripcion" HtmlEncode="False" />
                                        <asp:BoundField DataField="Estado.Descripcion" HeaderText="Estado" HtmlEncode="False" />
                                        <asp:TemplateField HeaderText="" HeaderStyle-Width="50px">
                                            <ItemTemplate>
                                                <asp:checkbox ID="chk_sel" runat="server" />
                                            </ItemTemplate>
                                            <HeaderStyle Width="350px"></HeaderStyle>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                            <br />
                            <br />
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-2 col-md-offset-2">
                                <asp:Button ID="btnSiguiente" runat="server" Text="Siguiente >>" CssClass="btn btn-block btn-info" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
