<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="calcularPresupuesto.aspx.vb" Inherits="VerdeUrbano.calcularPresupuesto" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
    <br />
    <br />
    <div class="container">
        <div class="row">
            <div class="col-md-10 col-md-offset-1">
                <div class="panel panel-verdeClaro">
                    <div class="panel-heading">Calcular Presupuesto</div>
                    <div class="panel-body">
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-8 col-md-offset-1">
                                <label class="label">Ingrese las medidas de la Superficie (en Metros)</label>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-1 col-md-offset-3">
                                <img src="Imagenes/Size-height-32.png" class="img img-responsive" />
                            </div>
                            <div class="col-md-2">
                                <label class="label">Alto:</label>
                            </div>
                            <div class="col-md-2">
                                <asp:TextBox ID="metrosAltos" runat="server" class="caja-texto"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <div class="row">
                            <div class="col-md-1 col-md-offset-3">
                                <img src="Imagenes/Size-width-32.png" class="img img-responsive" />
                            </div>
                            <div class="col-md-2">
                                <label class="label">Ancho:</label>
                            </div>
                            <div class="col-md-2">
                                <asp:TextBox ID="metros" runat="server" class="caja-texto"></asp:TextBox>
                            </div>
                        </div>
                        <br />
                        <br />
                        <div class="row">
                            <div class="col-md-6 col-md-offset-4">
                                <div class="form-group">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label class="label">Precio de Instalación:</label>
                                        </div>
                                        <div class="col-md-4 col-md-offset-1">
                                            <label class="label">$ 1580</label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6 col-md-offset-4">
                                <div class="form-group">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label class="label">Precio de Mantenimiento Mensual:</label>
                                        </div>

                                        <div class="col-md-4 col-md-offset-1">
                                            <label class="label">$ 320</label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-6 col-md-offset-4">
                                <div class="form-group">
                                    <div class="row">
                                        <div class="col-md-6">
                                            <label class="label">Capacitacion:</label>
                                        </div>

                                        <div class="col-md-4 col-md-offset-1">
                                            <label class="label">Bonificada</label>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <br />
    <br />
</asp:Content>
