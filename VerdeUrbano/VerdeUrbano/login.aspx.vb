Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        

    End Sub

    Protected Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Try
            validaciones.validarsubmit(Me, Me.error, Me.lbl_TituloError)
            Dim _usu As Servicios.Usuario = (New BLL.clsUsuario).Login(Me.txt_usuario.Text, Me.txt_password.Text)
            If Not _usu Is Nothing Then
                Me.GuardarUsuario(_usu)
                Dim nuevaBitacora As New Servicios.clsBitacora(_usu, Servicios.clsBitacora.tipoOperacionBitacora.Login, "Se ha logueado Correctamente")
                Response.Redirect("index.aspx")
            End If
        Catch ex As clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Mensaje
        Catch ex As clsExcepcionUsuarioInexistente
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Mensaje
        Catch ex As clsExcepcionPasswordIncorrecto
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Mensaje
        Catch ex As clsExcepcionUsuarioBloqueado
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Mensaje
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
End Class