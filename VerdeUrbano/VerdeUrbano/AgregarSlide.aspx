<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="AgregarSlide.aspx.vb" Inherits="VerdeUrbano.AgregarSlide" %>
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
    <br />
    <br />
    <asp:RadioButton ID="slideA" Runat="server" Text="Slide A (Texto)" />
    <asp:RadioButton ID="slideB" Runat="server" Text="Slide B (Texto)" />
    <asp:RadioButton ID="slideC" Runat="server" Text="Slide C (Texto)" />
    <br />
 <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_tituloSeccion" runat="server" Text="Titulo de la seccion: " CssClass="label"></asp:Label>
                            </div>

                            <div class="col-md-6 col-md-offset-1">
                                <asp:TextBox ID="txtTitulo" runat="server" CssClass="caja-texto"></asp:TextBox>
                            </div>
                            <div class="col-md-1">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                    ControlToValidate="txtTitulo" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                            </div>
                        </div>
    <br />
     <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_subtitulo" runat="server" Text="Subtitulo (Opcional): " CssClass="label"></asp:Label>
                            </div>

                            <div class="col-md-6 col-md-offset-1">
                                <asp:TextBox ID="txtSubtitulo" runat="server" CssClass="caja-texto"></asp:TextBox>
                            </div>
                        </div>
        <br />
        <br />
     <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lblTexto" runat="server" Text="Texto: " CssClass="label"></asp:Label>
                            </div>

                            <div class="col-md-6 col-md-offset-1">
                                <asp:textBox ID="TxtTexto" runat="server" CssClass="caja-texto" TextMode="MultiLine" rows="5"></asp:textBox>
                            </div>
                                     <div class="col-md-1">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                    ControlToValidate="txtTexto" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                            </div>
                        </div>
        <br />
         <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lbl_URLImagen" runat="server" Text="URL Imagen: " CssClass="label"></asp:Label>
                            </div>

                            <div class="col-md-6 col-md-offset-1">
                                <asp:textBox ID="txtURLImagen" runat="server" CssClass="caja-texto"></asp:textBox>
                            </div>
                        </div>
        <br />
             <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lblPie" runat="server" Text="Pie de imagen (opcional): " CssClass="label"></asp:Label>
                            </div>

                            <div class="col-md-6 col-md-offset-1">
                                <asp:textBox ID="txtPie" runat="server" CssClass="caja-texto"></asp:textBox>
                            </div>
                        </div>
        <br />
     <div class="row">
                            <div class="col-md-3 col-md-offset-1">
                                <asp:Label ID="lblURLVideo" runat="server" Text="URL Video: " CssClass="label"></asp:Label>
                            </div>

                            <div class="col-md-6 col-md-offset-1">
                                <asp:textBox ID="txtURLVideo" runat="server" CssClass="caja-texto"></asp:textBox>
                            </div>
                        </div>
        <br />
        <br />
                            <div class="row">
                            <div class="col-md-2 col-md-offset-2">
                                <asp:Button ID="btnFinalizarEdicion" runat="server" Text="Finalizar Edicion" CssClass="btn btn-block btn-info" />
                            </div>
                        </div>
                                <div class="row">
                            <div class="col-md-2 col-md-offset-2">
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-block btn-info" />
                            </div>
                        </div>
</asp:Content>
