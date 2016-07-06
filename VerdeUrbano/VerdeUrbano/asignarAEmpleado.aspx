<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="asignarAEmpleado.aspx.vb" Inherits="VerdeUrbano.asignarAEmpleado" %>
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
        <br />
                        <br />
        <div class="row">
            <div class="col-md-8 col-md-offset-2">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">
                        <asp:Label ID="lbl_AsignarCurso" runat="server" Text="Asignar Curso"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />
                                                            <div class="row">
                            <div class="col-md-8 col-md-offset-2">
                                <asp:GridView ID="gv_Curso" runat="server" CssClass="Grid-verde" AutoGenerateColumns="False" HorizontalAlign="Center">

                                    <Columns>
                                        <asp:BoundField DataField="Curso.Nombre" HeaderText="Nombre del curso" HtmlEncode="False" />
                                        <asp:BoundField DataField="Curso.Descripcion" HeaderText="Descripcion" HtmlEncode="False" ControlStyle-CssClass="col-md-3" />
                                        <asp:BoundField DataField="Curso.Duracion" HeaderText="Duracion" HtmlEncode="False" ControlStyle-CssClass="col-md-4" />
                                        <asp:BoundField DataField="Licencias" HeaderText="Licencias Disponibles" HtmlEncode="False" ControlStyle-CssClass="col-md-1" /> 
                                    </Columns>
                                </asp:GridView>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_Empleado" runat="server" Text="Empleado" CssClass="label"></asp:Label>
                            </div>

<div class="col-md-8 col-md-offset-2">
                                <asp:GridView ID="gv_empleados" runat="server" CssClass="Grid-verde" AutoGenerateColumns="False" HorizontalAlign="Center">

                                    <Columns>
                                        <asp:BoundField DataField="DNI" HeaderText="DNI" HtmlEncode="False" />
                                        <asp:BoundField DataField="Nombres" HeaderText="Nombre" HtmlEncode="False" ControlStyle-CssClass="col-md-3" />
                                        <asp:BoundField DataField="Apellido" HeaderText="Apellido" HtmlEncode="False" ControlStyle-CssClass="col-md-4" />
                                        <asp:BoundField DataField="Usuario.NombreUsuario" HeaderText="Usuario" HtmlEncode="False" ControlStyle-CssClass="col-md-4" />
                                                                                <asp:TemplateField HeaderText="Seleccionar" HeaderStyle-Width="400px">
                                            <ItemTemplate>
                                                <asp:CheckBox ID="cb_Empleados" runat="server" />
                                            </ItemTemplate>
                                            <HeaderStyle Width="350px"></HeaderStyle>
                                        </asp:TemplateField>
                                    </Columns>
                                </asp:GridView>
     <br />
                                <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_nota" runat="server" Text="Nota: Los empleados que no figuren en la lista, ya cuentan con el curso seleccionado." CssClass="label"></asp:Label>
                            </div>
                            </div>
                        </div>
                        <br />

                            <div class="col-md-3 col-md-offset-2">
                                <asp:Button ID="btnAsignar" runat="server" Text="Asignar" CssClass="btn btn-block btn-info" />
                            </div>
                      
                        <br />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
