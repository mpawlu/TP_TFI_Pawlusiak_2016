Public Class examenFinalizado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oCuAs As New EE.CursoAsignado
        oCuAs = DirectCast(Session("CursoAsignado"), EE.CursoAsignado)
        CargarDiv(oCuAs)
    End Sub
    Public Sub CargarDiv(ByVal _CursoAsignado As EE.CursoAsignado)
        Dim correctas As Integer
        correctas = 0
        For Each r As EE.Respuesta_Curso In _CursoAsignado.Respuestas
            If r.OpcionElegida.Correcta = True Then
                correctas += 1
            End If
        Next

        If _CursoAsignado.Aprobado = True Then
            aprobado.Visible = True
            Me.lbl_Acorrectas.Text = "Respuestas Correctas:    " & correctas & "/" & _CursoAsignado.Respuestas.Count
            Me.lbl_Atitulo.Text = "Aprobado"
            Me.lbl_Arating.Text = Math.Round(_CursoAsignado.ResultadoObtenido, 2)

        Else
            desaprobado.Visible = True
            Me.lbl_Dcorrectas.Text = "Respuestas Correctas:    " & correctas & "/" & _CursoAsignado.Respuestas.Count
            Me.lbl_Dtitulo.Text = "Desaprobado"
            Me.lbl_Drating.Text = Math.Round(_CursoAsignado.ResultadoObtenido, 2)
        End If
    End Sub
End Class