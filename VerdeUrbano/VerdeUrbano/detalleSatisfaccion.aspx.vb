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
        If oSatClie.SatisfaccionCalculada >= 5 Then
            aprobado.Visible = True
            Me.lbl_ANombreEmpresa.Text = oSatClie.Empresa.Nombre
            Me.lbl_Acuit.Text = oSatClie.Empresa.CUIT
            Me.lbl_Arating.Text = Math.Round(oSatClie.SatisfaccionCalculada, 2)
            Me.lbl_AratingDetalle.Text = calcularSatisfaccionTexto(oSatClie.SatisfaccionCalculada)
        Else
            desaprobado.Visible = True
            Me.lbl_DNombreEmpresa.Text = oSatClie.Empresa.Nombre
            Me.lbl_Dcuit.Text = oSatClie.Empresa.CUIT
            Me.lbl_Drating.Text = Math.Round(oSatClie.SatisfaccionCalculada, 2)
            Me.lbl_DratingDetalle.Text = calcularSatisfaccionTexto(oSatClie.SatisfaccionCalculada)
        End If
    End Sub



    Private Function calcularSatisfaccionTexto(ByVal _valor As Double) As String
        If _valor <= 3 Then
            Return "Insatisfecho"
        End If
        If _valor > 3 And _valor <= 5 Then
            Return "Poco Satisfecho"
        End If
        If _valor > 5 And _valor <= 8 Then
            Return "Satisfecho"
        End If
        If _valor > 8 And _valor <= 10 Then
            Return "Muy Satisfecho"
        End If
    End Function

    Protected Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Response.Redirect("index.aspx")
    End Sub



End Class