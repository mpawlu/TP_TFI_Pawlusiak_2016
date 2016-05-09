<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/paginaMaestra.Master" CodeBehind="institucional.aspx.vb" Inherits="VerdeUrbano.institucional" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoPagina" runat="server">
    <br />
    <br />
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-12">

                <div class="row">
                    <div class="col-md-5 col-md-offset-1">
                        <div class="thumbnail fondoGrisClaro bordeColor">
                            <img src="Imagenes/mision.png" alt="Mision" class="img img-responsive">
                            <div class="caption">
                                  <h3 class="tituloNegrita text-center"><asp:Label ID="lbl_Mision" runat="server" Text="Mision"></asp:Label></h3>
                                <br />
                                <p class="parrafo">
                                    <asp:Label ID="lbl_DetalleMision" runat="server" Text="Contribuir al desarrollo urbanístico sustentable, a través de la difusión, concientización y aplicación de tecnologías que disminuyan el impacto ambiental y que mejore la calidad de vida de la población, brindando un producto de alta calidad y duradero.
Contribuir al bienestar de los habitantes de la Ciudad autónoma de buenos aires y la zona norte del conurbano bonaerense."></asp:Label> 
                       
                                </p>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-5">
                        <div class="thumbnail fondoGrisClaro bordeColor">
                            <img src="Imagenes/vision.png" alt="Mision" class="img img-responsive">
                            <div class="caption">
                                <h3 class="tituloNegrita text-center"><asp:Label ID="lbl_Vision" runat="server" Text="Visión"></asp:Label></h3>
                                <br />
                                <p class="parrafo">
                                    <asp:Label ID="lbl_DetalleVision" runat="server" Text="Ser empresa líder en Jardines verticales y terrazas verdes, brindando las mejores tecnologías del mercado para trasformar las principales ciudades del país en color verde, mejorando la calidad de vida de las personas."></asp:Label>                        
                                </p>
                                <br />
                                <br />
                                <br />
                                <br />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <br />
</asp:Content>
