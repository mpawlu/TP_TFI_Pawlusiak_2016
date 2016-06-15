Public Class examenFinalizado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oCuAs As New EE.CursoAsignado
        oCuAs = DirectCast(Session("CursoAsignado"), EE.CursoAsignado)
        CargarDiv(oCuAs)
    End Sub
    Public Sub CargarDiv(ByVal _CursoAsignado As EE.CursoAsignado)

    End Sub
End Class