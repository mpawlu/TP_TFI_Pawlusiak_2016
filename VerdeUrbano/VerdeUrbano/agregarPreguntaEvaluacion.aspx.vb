Public Class crearEvaluacion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
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
    End Sub
End Class