Public Class agregarSolicitudCurso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            obtenerUsuarios()

        End If
    End Sub

    Private Sub obtenerUsuarios()
        Try
            Dim _bllUsuario As New BLL.clsUsuario
            Dim _listaUsuarios As New List(Of Servicios.Usuario)
            _listaUsuarios = _bllUsuario.ListarUsuarios
            Me.gv_Profesores.DataSource = _listaUsuarios
            Me.gv_Profesores.DataBind()
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub
End Class