Public Class visualizarBitacora
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            obtenerUsuarios()
            obtenerTipoOperacion()
            cargarRegistros()
        End If
    End Sub

    Private Sub cargarRegistros()
        Dim oBitBll As New BLL.clsBitacora
        Dim ListaBitacora As New List(Of Servicios.clsBitacora)
        ListaBitacora = oBitBll.ListarBitacora
        Me.gv_Bitacora.DataSource = ListaBitacora
        Me.gv_Bitacora.DataBind()

    End Sub


    Private Sub obtenerUsuarios()
        Try
            'Dim _bllUsuario As New BLL.UsuarioBLL
            'Me.ddlUsuario.DataSource = _bllUsuario.consultarUsuarios
            Me.ddlUsuario.DataBind()
            Me.ddlUsuario.Items.Insert(0, "Todos")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub obtenerTipoOperacion()
        Try
            Me.ddlOperacion.DataSource = System.Enum.GetValues(GetType(Servicios.clsBitacora.tipoOperacionBitacora))
            Me.ddlOperacion.DataBind()
            Me.ddlOperacion.Items.Insert(0, "Todos")
        Catch ex As Exception

        End Try
    End Sub

End Class