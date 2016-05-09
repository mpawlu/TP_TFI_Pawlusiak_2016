Imports Microsoft.VisualBasic


Public Class validaciones

    Public Shared Sub validarSubmit(ByVal paramPage As Page, ByRef _txtError As HtmlGenericControl, ByRef _labelError As Label)
        paramPage.Validate()
        If Not paramPage.IsValid Then
            Throw New Servicios.clsExcepcionCamposIncompletos
        Else
            _txtError.Visible = False
            _labelError.Text = ""
        End If
    End Sub

    Public Shared Function validarPagina(ByVal paramPage As Page) As Boolean
        If BLL.Singleton.InstanciaSing.oUsuarioSesion Is Nothing Then
            Return False
        End If
        Dim _perfilUsuario As Servicios.PermisoCompuesto = DirectCast(BLL.Singleton.InstanciaSing.oUsuarioSesion.Perfil, Servicios.PermisoBase)
        For Each MiPermiso As Servicios.PermisoBase In _perfilUsuario.ObtenerHijos
            If MiPermiso.Url.ToUpper = paramPage.AppRelativeVirtualPath.ToString.ToUpper Then
                Return True
            End If
        Next
        Return False
    End Function



End Class
