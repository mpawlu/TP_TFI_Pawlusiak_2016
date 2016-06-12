Public Class agregarSolicitudCurso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            obtenerUsuarios()
            obtenerCategorias()
        End If
    End Sub

    Private Sub obtenerUsuarios()
        Try
            Dim _bllUsuario As New BLL.clsUsuario
            Dim _listaUsuarios As New List(Of Servicios.Usuario)
            _listaUsuarios = _bllUsuario.ObtenerDisenadores
            Me.gv_Profesores.DataSource = _listaUsuarios
            Me.gv_Profesores.DataBind()
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub
    Private Sub obtenerCategorias()
        Dim oCatBLL As New BLL.Categoria

        Dim oCategoria As New List(Of EE.Categoria)
        oCategoria = oCatBLL.ListarCategorias()
        Me.ddlCategoria.DataSource = oCategoria
        Me.ddlCategoria.DataTextField = "Descripcion"
        Me.ddlCategoria.DataValueField = "ID"
        Me.ddlCategoria.DataBind()

    End Sub

    Protected Sub btnCalculador_Click(sender As Object, e As EventArgs) Handles btnCalculador.Click
        Response.Redirect("calculadorDisenador.aspx")
    End Sub
End Class