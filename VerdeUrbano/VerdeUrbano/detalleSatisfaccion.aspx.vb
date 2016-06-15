Public Class detalleSatisfaccion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            cargarDatos()
        End If
    End Sub

    Private Sub cargarDatos()
        Dim oSatClie As New EE.SatisfaccionCliente
        oSatClie = DirectCast(Session("Satisfaccion"), EE.SatisfaccionCliente)
        If oSatClie.SatisfaccionCalculada >= 10 Then
            aprobado.Visible = True
            Me.lbl_ANombreEmpresa.Text = oSatClie.Empresa.Nombre
            Me.lbl_Acuit.Text = oSatClie.Empresa.CUIT
            Me.lbl_Arating.Text = Math.Round(oSatClie.SatisfaccionCalculada)
        Else
            desaprobado.Visible = True
            Me.lbl_DNombreEmpresa.Text = oSatClie.Empresa.Nombre
            Me.lbl_Dcuit.Text = oSatClie.Empresa.CUIT
            Me.lbl_Drating.Text = Math.Round(oSatClie.SatisfaccionCalculada)
        End If
    End Sub


    Protected Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Response.Redirect("index.aspx")
    End Sub



End Class