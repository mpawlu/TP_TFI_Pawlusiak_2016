<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="agregarSlide.aspx.vb" Inherits="VerdeUrbano.agregarSlide" %>

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
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-8 col-md-offset-2">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">
                        <asp:Label ID="lbl_agregarSlide" runat="server" Text="Agregar Slide"></asp:Label>
                    </div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-6 col-md-offset-1">
                                <asp:Label ID="tipoSlide" runat="server" Text="Tipo de Slide:" CssClass="label"></asp:Label>
                            </div>
                        </div>

                        <br />
                        <div class="row">
                            <div class="col-md-6 col-md-offset-1">
                                <asp:RadioButton ID="slideA" runat="server" Text="Slide A (Texto)" GroupName="slide" CssClass="label" AutoPostBack="true" OnCheckedChanged="slideA_CheckedChanged" />
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6 col-md-offset-1">
                                <asp:RadioButton ID="slideB" runat="server" Text="Slide B (Imagen)" GroupName="slide" CssClass="label" AutoPostBack="true" OnCheckedChanged="slideB_CheckedChanged" />
                            </div>
                        </div>



                        <div class="row">
                            <div class="col-md-6 col-md-offset-1">
                                <asp:RadioButton ID="slideC" runat="server" Text="Slide C (Video)" GroupName="slide" CssClass="label" AutoPostBack="true" OnCheckedChanged="slideC_CheckedChanged" />
                            </div>
                        </div>

                        <div id="titulo" runat="server" visible="false">
                            <br />
                            <div class="row">
                                <div class="col-md-3 col-md-offset-1">
                                    <asp:Label ID="lbl_tituloSeccion" runat="server" Text="Titulo de la Seccion: " CssClass="label"></asp:Label>
                                </div>

                                <div class="col-md-6 col-md-offset-1">
                                    <asp:TextBox ID="txtTitulo" runat="server" CssClass="caja-texto"></asp:TextBox>
                                </div>
                                <div class="col-md-1">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
                                        ControlToValidate="txtTitulo" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                                </div>
                            </div>

                            <div id="subtitulo" runat="server" visible="false">
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
                        </div>
                        <br />

                        <div id="texto" runat="server" visible="false">
                            <br />
                            <div class="row">
                                <div class="col-md-3 col-md-offset-1">
                                    <asp:Label ID="lblTexto" runat="server" Text="Texto: " CssClass="label"></asp:Label>
                                </div>

                                <div class="col-md-6 col-md-offset-1">
                                    <asp:TextBox ID="txtTexto" runat="server" CssClass="textarea" TextMode="MultiLine" Height="200px"></asp:TextBox>
                                </div>
                                <div class="col-md-1">
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                                        ControlToValidate="txtTexto" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                        </div>

                        <div id="imagen" runat="server" visible="false">
                            <br />
                            <div class="row">
                                <div class="col-md-3 col-md-offset-1">
                                    <asp:Label ID="lbl_URLImagen" runat="server" Text="URL Imagen: " CssClass="label"></asp:Label>
                                </div>

                                <div class="col-md-6 col-md-offset-1">
                                    <asp:FileUpload ID="fu_imagenUsuario" runat="server" />
                                </div>
                                <div class="col-md-1">
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="*" ControlToValidate="fu_imagenUsuario" ValidationExpression="(.*).(.jpg|.JPG|.gif|.GIF|.jpeg|.JPEG|.bmp|.BMP|.png|.PNG)$" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RegularExpressionValidator>
                                    <asp:CustomValidator ID="validadorSize" runat="server" ErrorMessage="*" EnableClientScript="false" Display="Dynamic" CssClass="validador" ControlToValidate="fu_imagenUsuario" OnServerValidate="validadorSize_ServerValidate"></asp:CustomValidator>
                                </div>
                            </div>
                        </div>

                        <div id="pieImagen" runat="server" visible="false">
                            <br />
                            <div class="row">
                                <div class="col-md-3 col-md-offset-1">
                                    <asp:Label ID="lblPie" runat="server" Text="Pie de imagen (opcional): " CssClass="label"></asp:Label>
                                </div>

                                <div class="col-md-6 col-md-offset-1">
                                    <asp:TextBox ID="txtPie" runat="server" CssClass="caja-texto"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div id="video" runat="server" visible="false">
                            <br />
                            <div class="row">
                                <div class="col-md-3 col-md-offset-1">
                                    <asp:Label ID="lblURLVideo" runat="server" Text="URL Video: " CssClass="label"></asp:Label>
                                </div>

                                <div class="col-md-6 col-md-offset-1">
                                    <asp:TextBox ID="txtURLVideo" runat="server" CssClass="caja-texto"></asp:TextBox>
                                </div>
                                <div class="col-md-1 col-md-offset-1">
                                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtURLVideo" ValidationExpression="(?:https?:\/\/)?(?:www\.)?youtu(?:\.be|be\.com)\/(?:watch\?v=)?([\w-]{10,})" EnableClientScript="false" Display="Dynamic" CssClass="validador"></asp:RegularExpressionValidator>

                                </div>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-3 col-md-offset-2">
                                <asp:Button ID="btnFinalizarEdicion" runat="server" Text="Finalizar Edicion" CssClass="btn btn-block btn-success" />
                            </div>
                            <div class="col-md-3 col-md-offset-2">
                                <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="btn btn-block btn-warning" />
                            </div>
                        </div>
                        <br />

                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
