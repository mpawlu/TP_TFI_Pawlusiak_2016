Public Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim empresa As New EE.Empresa
        empresa.ID = 1
        Dim obll As New BLL.SatisfaccionCliente
        obll.CalcularSatisfaccion(empresa)
        'If BLL.DigitoVerificador.Integridad() = False Then
        '    Response.Redirect("errorIntegridad.aspx")
        'End If

        Dim Context As HttpContext = HttpContext.Current
        If Context.Items.Contains("loginCorrecto") Then
            If CBool(Context.Items("loginCorrecto")) = True Then
                Context.Items.Remove("loginCorrecto")
                Response.Redirect("index.aspx", False)
            End If
        End If
        If Context.Items.Contains("logoutCorrecto") Then
            If CBool(Context.Items("logoutCorrecto")) = True Then
                Context.Items.Remove("logoutCorrecto")
                Response.Redirect("index.aspx", False)
            End If
        End If
    End Sub

End Class