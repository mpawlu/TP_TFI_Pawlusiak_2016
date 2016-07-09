Public Class cambiarPassword
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If BLL.Singleton.InstanciaSing.oUsuarioSesion Is Nothing Then
            Response.Redirect("error.aspx")
        End If
        ocultarDivs()
    End Sub

    Protected Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        Try
            validaciones.validarSubmit(Me, Me.error, Me.lbl_TituloError)
            Dim oUsuario As Servicios.Usuario = Me.RecuperarUsuario
            If clsEncriptadora.EncriptarPass(Me.txtPassword.Text) = oUsuario.Password Then
                If Me.txtnuevoPassword.Text.Length >= 6 Then
                    If Me.txtnuevoPassword.Text = Me.txtRepetirPassword.Text Then
                        Dim _usuariobll As New BLL.clsUsuario
                        oUsuario.Password = clsEncriptadora.EncriptarPass(Me.txtnuevoPassword.Text)
                        _usuariobll.cambiarPassword(oUsuario)
                        Me.correcto.Visible = True
                    Else
                        'Dim ex As New Servicios.clsExcepcionPasswordDiferentes
                        'ex. = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
                        Throw New Servicios.clsExcepcionPasswordDiferentes
                    End If
                Else
                    Throw New Servicios.clsExcepcionPasswordCorto
                End If
            Else
                Throw New Servicios.clsExcepcionPasswordIncorrecto
            End If
        Catch ex As Servicios.clsExcepcionPasswordDiferentes
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Servicios.clsExcepcionPasswordCorto
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Servicios.clsExcepcionPasswordIncorrecto
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub

    Public Function RecuperarUsuario() As Servicios.Usuario
        Dim resultado As New Servicios.Usuario
        resultado = DirectCast(Session("Usuario"), Servicios.Usuario)
        Return resultado
    End Function


    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Response.Redirect("index.aspx")
    End Sub
    Public Sub ocultarDivs()
        Me.correcto.Visible = False
        Me.error.Visible = False
    End Sub
End Class