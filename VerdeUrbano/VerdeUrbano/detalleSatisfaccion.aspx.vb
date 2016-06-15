Public Class detalleSatisfaccion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oSatClie As New EE.SatisfaccionCliente
        oSatClie = Session("Satisfaccion")
    End Sub

    Protected Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Response.Redirect("index.aspx")
    End Sub



End Class