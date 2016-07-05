<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="comprarCurso.aspx.vb" Inherits="VerdeUrbano.comprarCurso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function confirmDel() {
            var myValue = "<%=mensajeConfirmacion2%>";
            var agree = confirm(myValue);
            if (agree) return true;
            else return false;
        }
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
        <div id="formulario" runat="server" visible="true">
        <div class="row">
            <div class="col-md-10 col-md-offset-1">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">
                        <asp:Label ID="lbl_cursosPendientes" runat="server" Text="Cursos Pendientes"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-10 col-md-offset-1">
                                <asp:GridView ID="gv_cursos" runat="server" CssClass="Grid-verde" AutoGenerateColumns="False" HorizontalAlign="Center">

                                    <Columns>
                                        <asp:BoundField DataField="ID" HeaderText="Código" HtmlEncode="False" />
                                        <asp:BoundField DataField="Nombre" HeaderText="Nombre" HtmlEncode="False" ControlStyle-CssClass="col-md-3" />
                                        <asp:BoundField DataField="Descripcion" HeaderText="Descripcion" HtmlEncode="False" ControlStyle-CssClass="col-md-4" />
                                        <asp:TemplateField HeaderText="Seleccionar" HeaderStyle-Width="20px">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="chk_sel" runat="server" />
                                            </ItemTemplate>
                                            <HeaderStyle Width="20px"></HeaderStyle>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
                            </div>
                            <br />
                            <br />
                        </div>
                        <br />
                        <div class="col-md-5 col-md-offset-7">
                            <div id="CantidadLicencias" runat="server">
                                <asp:Label ID="lbl_CantidadLicencias" Text="Cantidad de licencias a comprar:" runat="server" CssClass="label"></asp:Label>
                                <asp:DropDownList ID="ddl_lic" runat="server"></asp:DropDownList>
                                <br />
                                <br />
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-2 col-md-offset-5">
                                <asp:Button ID="btnComprar" runat="server" Text="Comprar" CssClass="btn btn-block btn-info" OnClientClick="return confirmDel();" />
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
                <br />
            </div>
        </div>
             </div>

    </div>

</asp:Content>
