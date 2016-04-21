Public Class administrarUsuarios
    Inherits System.Web.UI.Page
    Protected mensajeConfirmacion As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mensajeConfirmacion = "Desea Eliminarlo?"

    End Sub

    Protected Sub btn_Bloqueo_Command(sender As Object, e As CommandEventArgs)
        Dim bll As New BLL.clsUsuario
        Dim _usu As New Servicios.Usuario
        _usu.ID = CInt(e.CommandArgument)
        _usu = bll.RecuperarUsuario(_usu)
        bll.BloquearUsuario(_usu)
        Response.Redirect("administrarUsuarios.aspx")
    End Sub

    Protected Sub btn_desBloqueo_Command(sender As Object, e As CommandEventArgs)
        Dim bll As New BLL.clsUsuario
        Dim _usu As New Servicios.Usuario
        _usu.ID = CInt(e.CommandArgument)
        _usu = bll.RecuperarUsuario(_usu)
        bll.desbloquearUsuario(_usu)
        Response.Redirect("administrarUsuarios.aspx")
    End Sub

    Protected Sub btn_Editar_Command(sender As Object, e As CommandEventArgs)

    End Sub

    Protected Sub btn_Eliminar_Click(sender As Object, e As ImageClickEventArgs)
        Dim bll As New BLL.clsUsuario
        Dim _usu As New Servicios.Usuario
        _usu.ID = CInt(sender.CommandArgument)
        _usu = bll.RecuperarUsuario(_usu)
        bll.EliminarUsuario(_usu)
        Response.Redirect("administrarUsuarios.aspx")
    End Sub
End Class