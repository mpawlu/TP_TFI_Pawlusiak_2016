<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="administrarUsuarios.aspx.vb" Inherits="VerdeUrbano.administrarUsuarios" EnableEventValidation="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function confirmDel() {
            var myValue = "<%=mensajeConfirmacion%>";
            var agree = confirm(myValue);
            if (agree) return true;
            else return false;
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
    <br />
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-10 col-md-offset-1">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">Adminstración de Usuarios</div>
                    <div class="panel-body">
                        <br />
                        <asp:GridView ID="gv_Usuarios" runat="server" CssClass="Grid-verde" AutoGenerateColumns="False" HorizontalAlign="Center" AutoPostBack="true">
                            <Columns>
                                <asp:BoundField DataField="ID" HeaderText="ID Usuario" Visible="false" />
                                <asp:BoundField DataField="NombreUsuario" HeaderText="Nombre de Usuario" />
                                <asp:BoundField DataField="DNI" HeaderText="DNI" />
                                <asp:BoundField DataField="Bloqueado" HeaderText="Estado" />
                                <asp:BoundField DataField="FechaAlta" HeaderText="Fecha de Alta" DataFormatString="{0:d}" />
                                <asp:BoundField DataField="Editable" HeaderText="Editable"/>
                                <asp:TemplateField HeaderText="Acciones" HeaderStyle-Width="150px">
                                    <ItemTemplate>
                                        <div class="col-md-1">
                                            <asp:ImageButton ID="btn_Bloqueo" runat="server" OnCommand="btn_Bloqueo_Command" ImageUrl="~/Imagenes/lock2-32.png" CommandArgument='<%#Eval("ID")%>' Height="25px"/>
                                            <asp:ImageButton ID="btn_desBloqueo" runat="server" OnCommand="btn_desBloqueo_Command" ImageUrl="~/Imagenes/unlock2-32.png" CommandArgument='<%#Eval("ID")%>' Height="25px"/>
                                        </div>
                                        <div class="col-md-1 col-md-offset-1">
                                            <asp:ImageButton ID="btn_Editar" runat="server" OnCommand="btn_Editar_Command" ImageUrl="~/Imagenes/edit-32.png" CommandArgument='<%#Eval("ID")%>' Height="25px"/>
                                        </div>
                                        <div class="col-md-1 col-md-offset-1">
                                            <asp:ImageButton ID="btn_Eliminar" runat="server" OnClick="btn_Eliminar_Click" OnClientClick="return confirmDel();" ImageUrl="~/Imagenes/delete-32.png" CommandArgument='<%#Eval("ID")%>' Height="25px"/>
                                        </div>
                                    </ItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </div>
                </div>
            </div>

        </div>
    </div>
</asp:Content>
