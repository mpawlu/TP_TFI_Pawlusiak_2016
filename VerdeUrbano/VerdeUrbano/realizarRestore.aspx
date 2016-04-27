<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="realizarRestore.aspx.vb" Inherits="VerdeUrbano.realizarRestore" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
    <br />
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-10 col-md-offset-1">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">Realizar Restore</div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <br />

                        <div class="row">
                            <div class="col-md-2 col-md-offset-1">
                                <asp:Label ID="lblNombre" runat="server" CssClass="label">Nombre</asp:Label>

                            </div>
                            <div class="col-md-5 col-md-offset-2">
                                <asp:FileUpload ID="fuRestore" runat="server" CssClass="caja-texto" />
                            </div>
                        </div>
                        <br />
                        <br />
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-2 col-md-offset-3">
                                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="btn btn-success btn-block" />
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
    </div>
</asp:Content>
