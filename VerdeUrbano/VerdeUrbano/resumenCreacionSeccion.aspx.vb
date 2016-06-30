Public Class resumenCreacionSeccion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim oSeccion As New EE.Informativa
            oSeccion = CType(Session("Seccion"), EE.Informativa)
            Me.lbltitulo.Text = oSeccion.Titulo
            Me.lbldesc.Text = oSeccion.Descripcion
            Me.gv_slides.DataSource = oSeccion.Slides
            Me.gv_slides.DataBind()
        End If
    End Sub

End Class