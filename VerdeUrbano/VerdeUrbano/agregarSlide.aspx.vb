Public Class agregarSlide
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnFinalizarEdicion_Click(sender As Object, e As EventArgs) Handles btnFinalizarEdicion.Click
        Dim oSeccion As New EE.Informativa
        oSeccion = CType(Session("Seccion"), EE.Informativa)
        Dim oInfBLL As New BLL.Informativa
        If oInfBLL.AgregarSlide(oSeccion, DameSlide) = True Then
            Dim oSecBLL As New BLL.Informativa
            Session("Seccion") = oSecBLL.ConsultarSeccion(oSeccion)
            Response.Redirect("resumenCreacionSeccion.aspx")
        Else
            Me.error.Visible = True
        End If
    End Sub
    Public Function DameSlide() As EE.Slide
        If slideA.Checked = True Then
            Dim tipoA As New EE.TipoA
            tipoA.Titulo = txtTitulo.Text
            tipoA.Subtitulo = txtSubtitulo.Text
            tipoA.Texto = TxtTexto.Text
            Return tipoA
        ElseIf slideB.Checked = True Then
            Dim tipoB As New EE.TipoB
            tipoB.Titulo = txtTitulo.Text
            tipoB.Subtitulo = txtSubtitulo.Text
            tipoB.Imagen = txtURLImagen.Text
            tipoB.Pie = txtPie.Text
            Return tipoB
        ElseIf slideC.Checked = True Then
            Dim tipoC As New EE.TipoC
            tipoC.Titulo = txtTitulo.Text
            tipoC.Subtitulo = txtSubtitulo.Text
            tipoC.Video = txtURLVideo.Text
            Return tipoC
        End If
    End Function
End Class