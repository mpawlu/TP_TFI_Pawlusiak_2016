Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim _usu As Servicios.Usuario = (New BLL.clsUsuario).Login(Me.txt_usuario.Text, Me.txt_password.Text)


    End Sub
End Class