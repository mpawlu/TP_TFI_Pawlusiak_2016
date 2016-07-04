Public Class crearEvaluacion1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Session("Evaluacion") Is Nothing Then
            Me.gv_Preguntas.Visible = True
            Me.cargarGrilla()
        End If
    End Sub

    Private Sub btnAgregarPregunta_Click(sender As Object, e As EventArgs) Handles btnAgregarPregunta.Click
        Response.Redirect("agregarPreguntaEvaluacion.aspx")
    End Sub

    Private Sub btnFinalizarEdicion_Click(sender As Object, e As EventArgs) Handles btnFinalizarEdicion.Click
        Dim oCurso As New EE.Curso
        oCurso = DirectCast(Session("Curso"), EE.Curso)
        Dim oEval As New EE.Evaluacion
        oEval = DirectCast(Session("Evaluacion"), EE.Evaluacion)
        oEval.Titulo = Me.txtTitulo.Text
        oEval.Subtitulo = Me.txtSubtitulo.Text
        oCurso.Evaluacion = oEval
        Dim oEvalBLL As New BLL.Evaluacion
        oEvalBLL.Guardar(oCurso)
        Session("Curso") = oCurso
        Response.Redirect("ResumenCreacionCurso.aspx")
    End Sub
    Public Sub CargarGrilla()
        Dim oEval As New EE.Evaluacion
        oEval = Session("Evaluacion")
        Me.gv_Preguntas.DataSource = oEval.Preguntas
        Me.gv_Preguntas.DataBind()

    End Sub
End Class