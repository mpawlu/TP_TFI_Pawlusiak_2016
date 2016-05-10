Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'MsgBox(BLL.DigitoVerificador.Integridad())
    End Sub

    Protected Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            validaciones.validarsubmit(Me, Me.error, Me.lbl_TituloError)
            Dim _usu As Servicios.Usuario = (New BLL.clsUsuario).Login(Me.txt_usuario.Text, Me.txt_password.Text)
            If Not _usu Is Nothing Then
                Me.GuardarUsuario(_usu)
                Dim nuevaBitacora As New Servicios.clsBitacora(_usu, Servicios.clsBitacora.tipoOperacionBitacora.Login, "Se ha logueado Correctamente")
                Dim Context As HttpContext = HttpContext.Current
                If Context.Items.Contains("loginCorrecto") = True Then
                    Context.Items.Remove("loginCorrecto")
                End If
                Context.Items.Add("loginCorrecto", True)
                Server.Transfer("index.aspx", False)
            End If
        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Servicios.clsExcepcionUsuarioInexistente
            Me.error.Visible = True
            'Me.lbl_TituloError.Text = ex.Mensaje
        Catch ex As Servicios.clsExcepcionPasswordIncorrecto
            Me.error.Visible = True
            'Me.lbl_TituloError.Text = ex.Mensaje
        Catch ex As Servicios.clsExcepcionUsuarioBloqueado
            Me.error.Visible = True
            'Me.lbl_TituloError.Text = ex.Mensaje
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub
    Public Sub GuardarUsuario(ByVal usuario As Servicios.Usuario)
        Dim UsuarioSesion As New Servicios.Usuario
        UsuarioSesion = usuario
        Session("Usuario") = UsuarioSesion
    End Sub
    Public Function RecuperarUsuario() As Servicios.Usuario
        Dim resultado As New Servicios.Usuario
        resultado = DirectCast(Session("Usuario"), Servicios.Usuario)
        Return resultado
    End Function
End Class