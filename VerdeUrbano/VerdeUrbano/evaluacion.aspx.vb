
Public Class evaluacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If validaciones.validarPagina(Me) = False Then
        '    Response.Redirect("error.aspx")
        'End If
        If Not IsPostBack Then
            Dim oCuAs As New EE.CursoAsignado
            oCuAs = DirectCast(Session("CursoAsignado"), EE.CursoAsignado)

            Dim eva As New EE.Evaluacion
            Dim oBLL As New BLL.Evaluacion

            eva = oBLL.Consultar(oCuAs.Curso)
            Me.generarPreguntas(eva.Preguntas)
        End If

    End Sub

    Private Sub generarPreguntas(ByVal paramListadoPreguntas As List(Of EE.Pregunta))
        Try
            Dim _contador As Integer = 1
            For Each MiPregunta As EE.Pregunta In paramListadoPreguntas
                Dim label As Label = Me.panelPreguntas.FindControl("lbl_pregunta" & _contador)
                Dim labelID As Label = Me.panelPreguntas.FindControl("id_" & _contador)
                label.Text = _contador & ")" & MiPregunta.Pregunta
                labelID.Text = MiPregunta.ID
                For Each _opcion As EE.Opcion_PregCurso In Me.Desordenar(MiPregunta.Opciones)
                    Dim radio As RadioButtonList = Me.panelPreguntas.FindControl("rb_pregunta" & _contador)
                    Dim item As New ListItem
                    item.Text = _opcion.Texto
                    item.Value = _opcion.ID
                    radio.Items.Add(item)
                Next
                _contador += 1
            Next
            ocultarRestantes(_contador)
        Catch ex As Exception
            '    Me.Error.Visible = True
            '    Me.lbl_TituloError.Text = ex.Message
        End Try

    End Sub

    Private Sub ocultarRestantes(ByVal cant As Integer)
        If cant < 10 Then
            For i = cant To 10
                Dim div As HtmlControl = Me.panelPreguntas.FindControl("pregunta" & i)
                div.Visible = False
            Next
        End If

    End Sub

    Protected Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Dim oRespBLL As New BLL.RespuestaCurso
        Dim oCuAs As New EE.CursoAsignado
        Dim oBLL As New BLL.CursoAsignado
        Dim oRespuestas As New List(Of EE.Respuesta_Curso)
        oCuAs = DirectCast(Session("CursoAsignado"), EE.CursoAsignado)
        Try
            Dim _contador As Integer = 1
            For Each _pregunta As EE.Pregunta In oCuAs.Curso.Evaluacion.Preguntas
                Dim radio As RadioButtonList = Me.panelPreguntas.FindControl("rb_pregunta" & _contador)
                Dim oRespuesta As New EE.Respuesta_Curso
                oRespuesta.Pregunta = _pregunta
                Dim oOpcion As New EE.Opcion_PregCurso
                oOpcion.ID = CInt(radio.SelectedValue)
                oRespuesta.OpcionElegida = oOpcion
                oRespuestas.Add(oRespuesta)
                _contador += 1
            Next
            oCuAs.Respuestas = oRespuestas
            If oBLL.GuardarRespuestas(oCuAs) = True Then
                oCuAs = oBLL.Consutar(oCuAs)
                oCuAs = oBLL.Corregir(oCuAs)
                If oBLL.Modificar(oCuAs) = True Then
                    oCuAs = oBLL.Consutar(oCuAs)
                    Session("CursoAsignado") = oCuAs
                    Response.Redirect("examenFinalizado.aspx")
                Else
                    Throw New Servicios.clsExcepcionErrorBBDD
                End If
            Else
                Throw New Servicios.clsExcepcionErrorBBDD
            End If

        Catch ex As Exception

        End Try

    End Sub

    Public Function Desordenar(ByVal _ListOpciones As List(Of EE.Opcion_PregCurso)) As List(Of EE.Opcion_PregCurso)
        Dim listaDesordenada As New List(Of EE.Opcion_PregCurso)
        Dim rand As New Random()
        Dim temp As EE.Opcion_PregCurso
        Dim indexRand As Integer
        Dim indexLast As Integer = _ListOpciones.Count - 1
        For index As Integer = 0 To indexLast
            temp = New EE.Opcion_PregCurso
            indexRand = rand.Next(index, indexLast)
            temp = _ListOpciones(indexRand)
            _ListOpciones(indexRand) = _ListOpciones(index)
            _ListOpciones(index) = temp
        Next index
        Return _ListOpciones
    End Function

End Class