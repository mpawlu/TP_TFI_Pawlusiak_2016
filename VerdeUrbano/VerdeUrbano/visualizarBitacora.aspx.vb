Public Class visualizarBitacora
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            obtenerUsuarios()
            obtenerTipoOperacion()
            cargarRegistros()
            Dim PagAnt As Integer = CInt(Me.gv_Bitacora.Rows(0).Cells(0).Text)
            Session("PagAnt") = PagAnt
            
        End If
    End Sub

    Private Sub cargarRegistros()
        Dim oBitBll As New BLL.clsBitacora
        Dim ListaBitacora As New List(Of Servicios.clsBitacora)
        ListaBitacora = oBitBll.ListarBitacora(oBitBll.ConsultarUltimoID)
        Me.gv_Bitacora.DataSource = ListaBitacora
        Me.gv_Bitacora.DataBind()
    End Sub

    Private Sub cargarRegistros(ByVal listaRegistros As List(Of Servicios.clsBitacora))
        Me.gv_Bitacora.DataSource = listaRegistros
        Me.gv_Bitacora.DataBind()
    End Sub

    Private Sub obtenerUsuarios()
        Try
            Dim UsuarioBLL As New BLL.clsUsuario
            Dim ListaUsuarios As New List(Of Servicios.Usuario)
            ListaUsuarios = UsuarioBLL.ListarUsuarios
            Me.ddlUsuario.DataSource = ListaUsuarios
            Me.ddlUsuario.DataTextField = "NombreUsuario"
            Me.ddlUsuario.DataValueField = "ID"
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

    Protected Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Try
            Dim _usuario As Servicios.Usuario = Nothing
            Dim UsuarioBLL As New BLL.clsUsuario
            Dim BitacoraBLL As New BLL.clsBitacora
            Dim _fecha As Date
            Dim _operacion As Integer = 0
            If Not ddlUsuario.SelectedIndex = 0 Then
                _usuario = New Servicios.Usuario
                _usuario.ID = Me.ddlUsuario.SelectedValue
                _usuario = UsuarioBLL.ListarUsuario(_usuario)

            End If
            If Not ddlOperacion.SelectedIndex = 0 Then
                _operacion = ddlOperacion.SelectedIndex
            End If
            If Not datepicker.Text = "" Then
                _fecha = CDate(datepicker.Text)
            Else
                _fecha = New Date(1, 1, 1)
            End If

            Dim paramDesde As Integer
            If Me.gv_Bitacora.Rows.Count > 0 Then
                paramDesde = CInt(Me.gv_Bitacora.TopPagerRow.Cells(0).Text)
            Else
                paramDesde = BitacoraBLL.ConsultarUltimoID
            End If

            Dim _listabitacora As List(Of Servicios.clsBitacora) = BitacoraBLL.ListarBitacora(_usuario, _fecha, _operacion, paramDesde)
            cargarRegistros(_listabitacora)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim _usuario As Servicios.Usuario = Nothing
        Dim UsuarioBLL As New BLL.clsUsuario
        Dim BitacoraBLL As New BLL.clsBitacora
        Dim _fecha As Date
        Dim _operacion As Integer = 0
        Dim PagAnt As Integer = CInt(Session("PagAnt"))
        PagAnt = PagAnt - 10
        If PagAnt <= 1 Then
            PagAnt = 1
            Session("PagAnt") = 1
        Else
            Session("PagAnt") = PagAnt
        End If
        Dim _listabitacora As List(Of Servicios.clsBitacora) = BitacoraBLL.ListarBitacora(_usuario, _fecha, _operacion, PagAnt)
        cargarRegistros(_listabitacora)
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        Dim _usuario As Servicios.Usuario = Nothing
        Dim UsuarioBLL As New BLL.clsUsuario
        Dim BitacoraBLL As New BLL.clsBitacora
        Dim _fecha As Date
        Dim _operacion As Integer = 0
        Dim PagAnt As Integer = CInt(Session("PagAnt"))
        PagAnt = PagAnt + 10
        If PagAnt > BitacoraBLL.ConsultarUltimoID Then
            PagAnt = BitacoraBLL.ConsultarUltimoID
            Session("PagAnt") = BitacoraBLL.ConsultarUltimoID

        Else
            Session("PagAnt") = PagAnt
        End If

        Dim _listabitacora As List(Of Servicios.clsBitacora) = BitacoraBLL.ListarBitacora(_usuario, _fecha, _operacion, PagAnt)
        cargarRegistros(_listabitacora)
    End Sub
End Class