Public Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Pruebaaaa
        Dim oCat As New EE.Categoria
        oCat.ID = 2
        Dim _bllUsuario As New BLL.clsUsuario
        Dim _listaUsuarios As New List(Of Servicios.Usuario)
        _listaUsuarios = _bllUsuario.ObtenerDisenadores
        Dim ie As New BLL.CalculadoraIE
        ie.RankearDiseñadores(_listaUsuarios, oCat)

        '-----

        If BLL.DigitoVerificador.Integridad() = False Then
            Response.Redirect("errorIntegridad.aspx")
        End If

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