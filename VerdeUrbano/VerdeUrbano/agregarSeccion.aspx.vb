Public Class agregarSeccion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oCurso As New EE.Curso
        oCurso = DirectCast(Session("Curso"), EE.Curso)
        Me.lbl_nombreCurso.Text = oCurso.Nombre
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim oCurso As New EE.Curso
        oCurso = DirectCast(Session("Curso"), EE.Curso)
        Dim oSeccion As New EE.Informativa(Me.txtTitulo.Text, Me.txtDescripcion.Text)
        Dim oSecBLL As New BLL.Informativa
        If oSecBLL.GuardarSeccion(oSeccion, oCurso) = True Then
            Me.correcto.Visible = True
            'Response.Redirect("agregarSlide.aspx")
        End If
    End Sub
End Class