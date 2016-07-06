Public Class ResumenCreacionCurso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If validaciones.validarPagina(Me) = False Then
            'Response.Redirect("error.aspx")
        End If
        If Not IsPostBack Then
            Dim oCurso As New EE.Curso
            Dim oCursoBLL As New BLL.Curso
            Dim oSol As New EE.SolicitudCurso
            oSol = DirectCast(Session("Solicitud"), EE.SolicitudCurso)
            oCurso = oCursoBLL.Consultar(oSol)
            Me.lblValorNombre.Text = oCurso.Nombre
            Me.lblValordescripcion.Text = oCurso.Descripcion
            CargarGrilla()
            Session("Curso") = oCurso
        End If
    End Sub

    Private Sub btnFinalizarCurso_Click(sender As Object, e As EventArgs) Handles btnFinalizarCurso.Click
        Try
            Dim oCurso As New EE.Curso
            Dim oCursoBLL As New BLL.Curso
            Dim oSol As New EE.SolicitudCurso
            Dim oEvalBLL As New BLL.Evaluacion
            oSol = DirectCast(Session("Solicitud"), EE.SolicitudCurso)
            oCurso = oCursoBLL.Consultar(oSol)
            oCursoBLL.FinalizarCreacion(oCurso)
            oCurso.Evaluacion = oEvalBLL.ConsultarUltima()
            oCurso.FechaCreacion = Now
            If oCursoBLL.Modificar(oCurso) = True Then
                Dim oSolBLL As New BLL.SolicitudCurso
                If oSolBLL.Modificar(oCurso.SolicitudCurso) = True Then
                    Me.correcto.Visible = True
                Else
                    Me.error.Visible = True
                End If
            Else
                Me.error.Visible = True
            End If
            Me.Finalizado.Visible = True
            Me.cursoNormal.Visible = False
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message

        End Try

    End Sub
    Public Sub CargarGrilla()
        Try
            Dim oCurso As New EE.Curso
            Dim oCursoBLL As New BLL.Curso
            Dim oSol As New EE.SolicitudCurso
            oSol = DirectCast(Session("Solicitud"), EE.SolicitudCurso)
            oCurso = oCursoBLL.Consultar(oSol)
            Me.gv_Secciones.DataSource = oCurso.Secciones
            Me.gv_Secciones.DataBind()
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message

        End Try

    End Sub

    Private Sub btnCrearEvaluacion_Click(sender As Object, e As EventArgs) Handles btnCrearEvaluacion.Click
        Try
            If gv_Secciones.Rows.Count > 0 Then
                Response.Redirect("crearEvaluacion.aspx")
            Else
                Throw New Servicios.clsExcepcionCamposIncompletos
            End If

        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message

        End Try


    End Sub

    Private Sub btnAgregarSeccion_Click(sender As Object, e As EventArgs) Handles btnAgregarSeccion.Click
        Response.Redirect("agregarSeccion.aspx")
    End Sub

    Public Function RecuperarUsuario() As Servicios.Usuario
        Dim resultado As New Servicios.Usuario
        resultado = DirectCast(Session("Usuario"), Servicios.Usuario)
        Return resultado
    End Function

    Protected Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Response.Redirect("index.aspx")
    End Sub
End Class