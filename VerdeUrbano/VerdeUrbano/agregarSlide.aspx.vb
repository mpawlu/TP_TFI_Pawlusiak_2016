Public Class agregarSlide
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btnFinalizarEdicion_Click(sender As Object, e As EventArgs) Handles btnFinalizarEdicion.Click
        Try
            validaciones.validarSubmit(Me, Me.error, Me.lbl_TituloError)
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
        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try

    End Sub

    Public Function RecuperarUsuario() As Servicios.Usuario
        Dim resultado As New Servicios.Usuario
        resultado = DirectCast(Session("Usuario"), Servicios.Usuario)
        Return resultado
    End Function

    Public Function DameSlide() As EE.Slide
        If slideA.Checked = True Then
            Dim tipoA As New EE.TipoA
            tipoA.Titulo = txtTitulo.Text
            tipoA.Subtitulo = txtSubtitulo.Text
            tipoA.Texto = txtTexto.Text
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

    Protected Sub slideA_CheckedChanged(sender As Object, e As EventArgs)
        Me.titulo.Visible = True
        Me.subtitulo.Visible = True
        Me.texto.Visible = True
        Me.imagen.Visible = False
        Me.pieImagen.Visible = False
        Me.video.Visible = False
    End Sub

    Protected Sub slideB_CheckedChanged(sender As Object, e As EventArgs)
        Me.titulo.Visible = True
        Me.subtitulo.Visible = True
        Me.texto.Visible = False
        Me.imagen.Visible = True
        Me.pieImagen.Visible = True
        Me.video.Visible = False
    End Sub

    Protected Sub slideC_CheckedChanged(sender As Object, e As EventArgs)
        Me.titulo.Visible = True
        Me.subtitulo.Visible = True
        Me.texto.Visible = False
        Me.imagen.Visible = False
        Me.pieImagen.Visible = False
        Me.video.Visible = True
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Response.Redirect("index.aspx")
    End Sub
End Class