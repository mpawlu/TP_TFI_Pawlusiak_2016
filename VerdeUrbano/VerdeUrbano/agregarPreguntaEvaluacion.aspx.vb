Public Class crearEvaluacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If validaciones.validarPagina(Me) = False Then
            Response.Redirect("error.aspx")
        End If
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click

        Try
            validaciones.validarSubmit(Me, Me.error, Me.lbl_TituloError)

            Dim oPreg As New EE.Pregunta
            oPreg.Pregunta = Me.txt_Enunciado.Text
            oPreg.Valor = Me.ddl_Valor.SelectedValue
            Dim oOpcion As New EE.Opcion_PregCurso
            oPreg.Opciones.Add(New EE.Opcion_PregCurso(Me.txt_Opcion1.Text, True))
            oPreg.Opciones.Add(New EE.Opcion_PregCurso(Me.txt_Opcion2.Text, False))
            oPreg.Opciones.Add(New EE.Opcion_PregCurso(Me.txt_Opcion3.Text, False))
            oPreg.Opciones.Add(New EE.Opcion_PregCurso(Me.txt_Opcion4.Text, False))
            Dim oEval As New EE.Evaluacion
            If Not Session("Evaluacion") Is Nothing Then
                oEval = DirectCast(Session("Evaluacion"), EE.Evaluacion)
            End If
            oEval.Preguntas.Add(oPreg)
            Session("Evaluacion") = oEval
            Response.Redirect("CrearEvaluacion.aspx")
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
End Class