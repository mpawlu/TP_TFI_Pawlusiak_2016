Public Class encuestaSatisfaccion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim oCuAs As New EE.CursoAsignado
            oCuAs = DirectCast(Session("CursoAsignado"), EE.CursoAsignado)

            Dim enc As New EE.Encuesta
            Dim oBLL As New BLL.PreguntaEncuesta

            enc.Preguntas = oBLL.ConsultarPreguntas
            enc.Curso = oCuAs.Curso
            Dim encAs As New EE.EncuestaAsignada
            encAs.Empleado = oCuAs.Empleado
            encAs.Encuesta = enc
            Session("EncuestaAsignada") = encAs

            Me.generarPreguntas(enc.Preguntas)
            Me.CargarDDL()
        End If
    End Sub
    Private Sub generarPreguntas(ByVal paramListadoPreguntas As List(Of EE.PreguntaEncuesta))
        Try
            Dim _contador As Integer = 1
            For Each MiPregunta As EE.PreguntaEncuesta In paramListadoPreguntas
                Dim label As Label = Me.panelPreguntas.FindControl("lbl_pregunta" & _contador)
                Dim labelID As Label = Me.panelPreguntas.FindControl("id_" & _contador)
                label.Text = _contador & ")" & MiPregunta.Pregunta
                labelID.Text = MiPregunta.ID_Pregunta
                If MiPregunta.ID_Pregunta >= 3 And MiPregunta.ID_Pregunta <= 8 Then
                    Dim radio As RadioButtonList = Me.panelPreguntas.FindControl("rb_pregunta" & _contador)
                    Dim item1 As New ListItem
                    item1.Text = "Pesimo"
                    item1.Value = 0
                    radio.Items.Add(item1)
                    Dim item2 As New ListItem
                    item2.Text = "Malo"
                    item2.Value = 1
                    radio.Items.Add(item2)
                    Dim item3 As New ListItem
                    item3.Text = "Regular"
                    item3.Value = 2
                    radio.Items.Add(item3)
                    Dim item4 As New ListItem
                    item4.Text = "Bueno"
                    item4.Value = 3
                    radio.Items.Add(item4)
                    Dim item5 As New ListItem
                    item5.Text = "Excelente"
                    item5.Value = 4
                    radio.Items.Add(item5)
                End If
                _contador += 1
            Next
            'ocultarRestantes(_contador)
        Catch ex As Exception
            '    Me.Error.Visible = True
            '    Me.lbl_TituloError.Text = ex.Message
        End Try

    End Sub
    Public Sub CargarDDL()

        For i As Integer = 1 To 10
            Me.ddl_preg1.Items.Add(i.ToString)
            Me.ddl_preg2.Items.Add(i.ToString)
        Next
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Dim oEncAs As New EE.EncuestaAsignada
        oEncAs = DirectCast(Session("EncuestaAsignada"), EE.EncuestaAsignada)
        Dim oRespuestas As New List(Of EE.Respuesta)
        oEncAs.Utilidad = CInt(ddl_preg1.SelectedItem.Text)
        oEncAs.Dificultad = CInt(ddl_preg2.SelectedItem.Text)
        Try
            Dim _contador As Integer = 1
            For Each _pregunta As EE.PreguntaEncuesta In oEncAs.Encuesta.Preguntas
                Dim radio As RadioButtonList = Me.panelPreguntas.FindControl("rb_pregunta" & _contador)
                Dim oRespuesta As New EE.Respuesta
                oRespuesta.PreguntaEncuesta = _pregunta

                If _pregunta.ID_Pregunta > 2 Then
                    oRespuesta.OpcionElegida = CInt(radio.SelectedValue)
                    oRespuestas.Add(oRespuesta)
                End If
                _contador += 1
            Next
            oEncAs.Respuestas = oRespuestas
            Dim oCuAs As New EE.CursoAsignado
            oCuAs = DirectCast(Session("CursoAsignado"), EE.CursoAsignado)
            oCuAs.EncuestaAsignada = oEncAs
            Dim oCurAsBLL As New BLL.CursoAsignado
            oCurAsBLL.FinalizarCurso(oCuAs)
            'Dim oEncAsBLL As New BLL.EncuestaAsignada
            'oEncAsBLL.GuradarEncuestaRealizada(oEncAs)
        Catch ex As Exception
        End Try

    End Sub
End Class