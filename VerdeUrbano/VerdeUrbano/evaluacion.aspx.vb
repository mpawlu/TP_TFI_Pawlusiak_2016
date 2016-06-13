Public Class evaluacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub generarPreguntas(ByVal paramListadoPreguntas As List(Of EE.Pregunta))
        Try
            Dim _contador As Integer = 1
            For Each MiPregunta As EE.Pregunta In paramListadoPreguntas
                Dim label As Label = Me.panelPreguntas.FindControl("lbl_pregunta" & _contador)
                Dim labelID As Label = Me.panelPreguntas.FindControl("id_" & _contador)
                label.Text = MiPregunta.Pregunta
                labelID.Text = MiPregunta.ID
                _contador += 1
                rb_pregunta1.DataSource = MiPregunta.Opciones
                Dim radio As RadioButtonList = Me.panelPreguntas.FindControl("rb_pregunta" & _contador)
                radio.DataSource = MiPregunta.Opciones
                radio.DataBind()
            Next
        Catch ex As Exception
            '    Me.Error.Visible = True
            '    Me.lbl_TituloError.Text = ex.Message
        End Try

    End Sub

    Protected Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click

    End Sub
End Class