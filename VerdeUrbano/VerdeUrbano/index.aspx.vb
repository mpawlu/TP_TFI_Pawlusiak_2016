Public Class index
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim NuevoUsuario As New Servicios.Usuario
        NuevoUsuario.NombreUsuario = txtNombre.Text
        NuevoUsuario.Password = txtPass.Text
        NuevoUsuario.DNI = txtDNI.Text
        NuevoUsuario.Activo = Activo.Checked
        Dim p As New Servicios.PermisoCompuesto
        p.ID = txtPerfil.Text
        NuevoUsuario.Perfil = p
        NuevoUsuario.Bloqueado = bloqueado.Checked
        NuevoUsuario.FechaAlta = CDate(txtFechaAlta.Text)
        NuevoUsuario.Editable = Editable.Checked
        Dim I As New Servicios.clsIdioma
        I.ID = txtIdioma.Text
        NuevoUsuario.Idioma = I
        Dim usuBLL As New BLL.clsUsuario
        MsgBox(Convert.ToString(usuBLL.CrearUsuario(NuevoUsuario)))
    End Sub
End Class