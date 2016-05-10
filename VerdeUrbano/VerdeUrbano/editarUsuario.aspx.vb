Public Class editarUsuario
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarDDLIdioma()
        CargarDDLPerfil()

    End Sub
    Protected Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        Try
            validaciones.validarSubmit(Me, Me.error, Me.lbl_TituloError)
            Dim EditarUsuario As New servicios.Usuario
            EditarUsuario = DirectCast(Session("editarUsuario"), servicios.Usuario)
            EditarUsuario.DNI = CInt(txtDNI.Text)
                    Dim p As New servicios.PermisoCompuesto
            p.ID = Me.ddl_Perfil.SelectedValue
            EditarUsuario.Perfil = p
                    Dim I As New servicios.clsIdioma
            I.ID = Me.ddl_idioma.SelectedValue
            EditarUsuario.Idioma = I
            Dim oUsuBLL As New BLL.clsUsuario
            If oUsuBLL.ModificarUsuario(EditarUsuario) = True Then
                MsgBox("Modificacion Exitosa")
            End If
        Catch ex As servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Mensaje
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
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

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Response.Redirect("index.aspx")
    End Sub
End Class