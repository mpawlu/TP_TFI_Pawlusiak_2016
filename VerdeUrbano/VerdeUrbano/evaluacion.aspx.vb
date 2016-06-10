Public Class evaluacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub generarPreguntas(ByVal paramListadoPreguntas As List(Of EE.Pregunta))
        Try
            'Dim _contador As Integer = 1
            'For Each MiPregunta As EE.Pregunta In paramListadoPreguntas
            '    Dim label As Label = Me.panelPreguntas.FindControl("lbl_pregunta" & _contador)
            '    Dim labelID As Label = Me.panelPreguntas.FindControl("id_" & _contador)
            '    label.Text = MiPregunta.Pregunta
            '    labelID.Text = MiPregunta.ID
            '    _contador += 1
            '    rb_pregunta1.DataSource = MiPregunta.Opciones

            'Next

            '    rb_pregunta1.DataSource =
            '    rb_pregunta1.DataBind()
            '    rb_pregunta2.DataSource = System.Enum.GetValues(GetType(Entidades.PreguntaOpinion.etipoRespuesta))
            '    rb_pregunta2.DataBind()
            '    rb_pregunta3.DataSource = System.Enum.GetValues(GetType(Entidades.PreguntaOpinion.etipoRespuesta))
            '    rb_pregunta3.DataBind()
            '    rb_pregunta4.DataSource = System.Enum.GetValues(GetType(Entidades.PreguntaOpinion.etipoRespuesta))
            '    rb_pregunta4.DataBind()
            '    rb_pregunta5.DataSource = System.Enum.GetValues(GetType(Entidades.PreguntaOpinion.etipoRespuesta))
            '    rb_pregunta5.DataBind()
            'Catch ex As BLL.excepcionGenerica
            '    Me.Error.Visible = True
            '    Me.lbl_TituloError.Text = ex.Mensaje
        Catch ex As Exception
            '    Me.Error.Visible = True
            '    Me.lbl_TituloError.Text = ex.Message
        End Try

    End Sub
End Class