Public Class examenFinalizado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oCuAs As New EE.CursoAsignado
        oCuAs = DirectCast(Session("CursoAsignado"), EE.CursoAsignado)
        CargarDiv(oCuAs)
    End Sub
    Public Sub CargarDiv(ByVal _CursoAsignado As EE.CursoAsignado)
        Me.lbl_rating.Text = _CursoAsignado.ResultadoObtenido
        Me.Label3.Text = _CursoAsignado.ResultadoObtenido
        Dim correctas As Integer
        correctas = 0
        For Each r As EE.Respuesta_Curso In _CursoAsignado.Respuestas
            If r.OpcionElegida.Correcta = True Then
                correctas += 1
            End If
        Next
        lbl_correctas.Text = "Respuestas Correctas:    " & correctas & "/" & _CursoAsignado.Respuestas.Count
        Label2.Text = "Respuestas Correctas:    " & correctas & "/" & _CursoAsignado.Respuestas.Count
        If _CursoAsignado.Aprobado = True Then

        Else

        End If
    End Sub
End Class