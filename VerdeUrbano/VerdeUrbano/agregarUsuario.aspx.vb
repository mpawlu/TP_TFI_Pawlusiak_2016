Public Class agregarUsuario
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarDDLIdioma()
        CargarDDLPerfil()
    End Sub

    Protected Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim NuevoUsuario As New Servicios.Usuario
        NuevoUsuario.NombreUsuario = txtNombre.Text
        NuevoUsuario.Password = txtPass.Text
        NuevoUsuario.DNI = CInt(txtDNI.Text)
        Dim p As New Servicios.PermisoCompuesto
        p.ID = ddl_Perfil.SelectedValue
        NuevoUsuario.Perfil = p
        'NuevoUsuario.Bloqueado = bloqueado.Checked
        NuevoUsuario.FechaAlta = Today
        NuevoUsuario.Editable = True
        Dim I As New Servicios.clsIdioma
        I.ID = ddl_idioma.SelectedValue
        NuevoUsuario.Idioma = I
        Dim usuBLL As New BLL.clsUsuario
        MsgBox(Convert.ToString(usuBLL.CrearUsuario(NuevoUsuario)))
    End Sub

    Public Sub CargarDDLIdioma()
        Dim oIdioma As New List(Of Servicios.clsIdioma)
        Dim oIdiomaBLL As New BLL.clsIdioma
        oIdioma = oIdiomaBLL.ListarIdiomas()
        Me.ddl_idioma.DataSource = oIdioma
        Me.ddl_idioma.DataTextField = "Descripcion"
        Me.ddl_idioma.DataValueField = "ID"
        Me.ddl_idioma.DataBind()
    End Sub
    Public Sub CargarDDLPerfil()
        Dim oPerfil As New List(Of Servicios.PermisoCompuesto)
        Dim oPerfilBLL As New BLL.clsPermiso
        oPerfil = oPerfilBLL.ListarPerfiles()
        Me.ddl_Perfil.DataSource = oPerfil
        Me.ddl_Perfil.DataTextField = "Descripcion"
        Me.ddl_Perfil.DataValueField = "ID"
        Me.ddl_Perfil.DataBind()
    End Sub
End Class