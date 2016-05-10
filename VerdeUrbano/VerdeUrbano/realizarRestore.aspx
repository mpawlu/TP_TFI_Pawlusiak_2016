<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="realizarRestore.aspx.vb" Inherits="VerdeUrbano.realizarRestore" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
                        <asp:Label ID="lbl_RealizarRestore" runat="server" Text="Realizar Restore"></asp:Label></div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <br />

                        <div class="row">
                            <div class="col-md-2 col-md-offset-1">
                                <asp:Label ID="lbl_Nombre" runat="server" CssClass="label" Text="Nombre"></asp:Label>

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
    </div>
</asp:Content>
