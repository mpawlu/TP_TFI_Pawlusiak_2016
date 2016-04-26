Public Class login
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        Dim _usu As Servicios.Usuario = (New BLL.clsUsuario).Login(Me.txt_usuario.Text, Me.txt_password.Text)
        If Not _usu Is Nothing Then
            Me.GuardarUsuario(_usu)

            Response.Redirect("index.aspx")
        Else
            MsgBox("ADFSAD")
        End If

    End Sub
    Public Sub GuardarUsuario(ByVal usuario As Servicios.Usuario)

        Dim UsuarioSesion As New Servicios.Usuario

        UsuarioSesion = usuario

        Session("Usuario") = UsuarioSesion

    End Sub
End Class