<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="error.aspx.vb" Inherits="VerdeUrbano._error" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
    <div class="container-fluid">
        <br />
        <br />
        <div class="row">
            <div class="col-md-2 col-md-offset-5">
                <asp:Image ID="img_error" runat="server" CssClass="center-block img-responsive" ImageUrl="~/Imagenes/panneau_attention.png" />
            </div>

        </div>
        <br />
        <br />
        <div class="row">
            <div class="well well-lg col-md-12 msj-error" runat="server">
                <asp:Label ID="lbl_TituloError" runat="server" CssClass="labelError">Se ha producido un error. Se lo direccionará a la pagina de Inicio.</asp:Label>
            </div>
        </div>
    </div>
            <br />
        <br />
</asp:Content>
