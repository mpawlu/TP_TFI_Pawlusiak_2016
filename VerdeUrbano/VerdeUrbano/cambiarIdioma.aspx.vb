Public Class cambiarIdiomar
    Inherits System.Web.UI.Page
    Dim Usuario As New Servicios.Usuario
    Dim Idiomas As New List(Of Servicios.clsIdioma)


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Usuario = Me.RecuperarUsuario()
            Dim oIdBLL As New BLL.clsIdioma
            CargarDDL()
        End If
    End Sub

    Private Sub CargarDDL()
        Dim oIdBLL As New BLL.clsIdioma
        Idiomas = oIdBLL.ListarIdiomas
        Me.DropDownList1.DataSource = Idiomas
        Me.DropDownList1.DataTextField = "Descripcion"
        Me.DropDownList1.DataValueField = "ID"
        Me.DropDownList1.DataBind()
        Me.DropDownList1.SelectedValue = Me.RecuperarUsuario.Idioma.ID

    End Sub


    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub

    Public Function RecuperarUsuario() As Servicios.Usuario
        Dim resultado As New Servicios.Usuario
        resultado = DirectCast(Session("Usuario"), Servicios.Usuario)
        Return resultado
    End Function
    Public Sub GuardarUsuario(ByVal usuario As Servicios.Usuario)
        Dim UsuarioSesion As New Servicios.Usuario
        UsuarioSesion = usuario
        Session("Usuario") = UsuarioSesion
    End Sub

    Protected Sub btnActualizarIdioma_Click(sender As Object, e As EventArgs) Handles btnActualizarIdioma.Click
        Dim oUsuBLL As New BLL.clsUsuario
        Dim NuevoIdioma As New Servicios.clsIdioma
        Usuario = Me.RecuperarUsuario()
        NuevoIdioma.ID = Me.DropDownList1.SelectedValue
        Usuario.Idioma = NuevoIdioma
        oUsuBLL.ModificarUsuario(Usuario)
        Me.GuardarUsuario(Usuario)
        Response.Redirect("index.aspx")
    End Sub
End Class