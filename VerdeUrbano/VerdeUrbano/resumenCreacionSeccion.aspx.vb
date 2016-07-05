Public Class resumenCreacionSeccion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If validaciones.validarPagina(Me) = False Then
            Response.Redirect("error.aspx")
        End If
        If Not IsPostBack Then
            Me.CargarGrilla()
        End If
    End Sub

    Private Sub btnAgregarSlide_Click(sender As Object, e As EventArgs) Handles btnAgregarSlide.Click
        Response.Redirect("agregarSlide.aspx")
    End Sub

    Private Sub btnFinalizarSeccion_Click(sender As Object, e As EventArgs) Handles btnFinalizarSeccion.Click
        Response.Redirect("resumenCreacionCurso.aspx")
    End Sub
    Public Sub CargarGrilla()
        Dim oSeccion As New EE.Informativa
        oSeccion = CType(Session("Seccion"), EE.Informativa)
        Me.lblValortitulo.Text = oSeccion.Titulo
        Me.lblValorDesc.Text = oSeccion.Descripcion
        Me.gv_slides.DataSource = oSeccion.Slides
        Me.gv_slides.DataBind()
    End Sub
End Class