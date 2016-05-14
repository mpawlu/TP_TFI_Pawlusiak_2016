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
        Dim _flag As Boolean = False
        If BLL.Singleton.InstanciaSing.oUsuarioSesion.NombreUsuario Is Nothing Then
            Return _flag
        Else
            Dim _perfilUsuario As Servicios.PermisoCompuesto = DirectCast(BLL.Singleton.InstanciaSing.oUsuarioSesion.Perfil, Servicios.PermisoBase)
            validaciones.comprobarPermiso(_flag, _perfilUsuario.ListaPermisos, paramPage)
            Return _flag
        End If
    End Function

    Private Shared Sub comprobarPermiso(ByRef _flag As Boolean, ByVal misPermisos As List(Of Servicios.PermisoBase), ByVal paramPage As Page)
        For Each MiPermiso As Servicios.PermisoBase In misPermisos
            If Not MiPermiso.Url Is Nothing Then
                If MiPermiso.Url.ToUpper = paramPage.AppRelativeVirtualPath.ToString.ToUpper Then
                    _flag = True
                End If
            End If
         
            If MiPermiso.TieneHijos = True Then
                comprobarPermiso(_flag, MiPermiso.ObtenerHijos, paramPage)
            End If
        Next
    End Sub
End Class
