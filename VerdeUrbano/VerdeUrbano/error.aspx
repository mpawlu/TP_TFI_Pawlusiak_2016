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
        <br />
        <div class="row">
            <div class="col-md-10 col-md-offset-1">
                <div id="error" class="msj-error col-md-12" runat="server">
                    <asp:Label ID="lbl_TituloErrorGenerico" runat="server" CssClass="label">Se ha producido un error al ejecutar al acción. Se lo redireccionará al Inicio.</asp:Label>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
