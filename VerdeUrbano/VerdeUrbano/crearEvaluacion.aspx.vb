Public Class crearEvaluacion1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If validaciones.validarPagina(Me) = False Then
            'Response.Redirect("error.aspx")
        End If
        If Not Session("EvaluacionCreada") Is Nothing Then
            Dim _eval As EE.Evaluacion = DirectCast(Session("EvaluacionCreada"), EE.Evaluacion)
            Me.txtTitulo.Text = _eval.Titulo
            Me.txtSubtitulo.Text = _eval.Subtitulo
            Me.gv_Preguntas.Visible = True
            Me.CargarGrilla()
        End If
        ocultarDivs()
    End Sub

    Private Sub btnAgregarPregunta_Click(sender As Object, e As EventArgs) Handles btnAgregarPregunta.Click
        Try
            validaciones.validarSubmit(Me, Me.error, Me.lbl_TituloError)
            Dim _eval As New EE.Evaluacion
            _eval.Titulo = Me.txtTitulo.Text
            _eval.Subtitulo = Me.txtSubtitulo.Text
            Session("EvaluacionCreada") = _eval
            Response.Redirect("agregarPreguntaEvaluacion.aspx")
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

    Private Sub btnFinalizarEdicion_Click(sender As Object, e As EventArgs) Handles btnFinalizarEdicion.Click
        Try
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
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try

    End Sub
    Public Sub CargarGrilla()
        Try
            Dim oEval As New EE.Evaluacion
            oEval = Session("Evaluacion")
            Me.gv_Preguntas.DataSource = oEval.Preguntas
            Me.gv_Preguntas.DataBind()
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub
    Public Sub ocultarDivs()
        Me.correcto.Visible = False
        Me.error.Visible = False
    End Sub
End Class