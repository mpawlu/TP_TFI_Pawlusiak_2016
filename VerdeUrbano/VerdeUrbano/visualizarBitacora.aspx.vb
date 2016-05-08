Public Class visualizarBitacora
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            obtenerUsuarios()
            obtenerTipoOperacion()
            cargarRegistros()
            Dim PagAnt As Integer = CInt(Me.gv_Bitacora.Rows(0).Cells(0).Text)
            Session("PagAnt") = PagAnt
            Session("UltimoRegistro") = PagAnt
            Me.btnAnterior.Enabled = False
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
            'btnSiguiente.Enabled = True
                Me.btnAnterior.Enabled = False
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
                Dim oBitacoraBLL As New BLL.clsBitacora
                Dim PagAnt As Integer = oBitacoraBLL.ConsultarUltimoID
                Session("PagAnt") = PagAnt
                Dim _listabitacora As List(Of Servicios.clsBitacora) = BitacoraBLL.ListarBitacora(_usuario, _fecha, _operacion, PagAnt)
                cargarRegistros(_listabitacora)
                PagAnt = CInt(gv_Bitacora.Rows(0).Cells(0).Text)
                Session("PagAnt") = PagAnt
                Session("UltimoRegistro") = PagAnt
                If gv_Bitacora.Rows.Count < 10 Then
                    btnSiguiente.Enabled = False
                    btnAnterior.Enabled = False
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Session("TopPagAnt") = CInt(gv_Bitacora.Rows(0).Cells(0).Text)
        btnAnterior.Enabled = True
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
        Dim PagAnt As Integer = CInt(Session("PagAnt"))
        'PagAnt = PagAnt - 10
        PagAnt = CInt(gv_Bitacora.Rows(9).Cells(0).Text) - 1
        If PagAnt <= 1 Then
            PagAnt = CInt(gv_Bitacora.Rows(0).Cells(0).Text)
            PagAnt = CInt(gv_Bitacora.Rows(0).Cells(0).Text)
        Else
            Session("PagAnt") = PagAnt
        End If
        Dim _listabitacora As List(Of Servicios.clsBitacora) = BitacoraBLL.ListarBitacora(_usuario, _fecha, _operacion, PagAnt)
        cargarRegistros(_listabitacora)
        If gv_Bitacora.Rows.Count < 10 Then
            btnSiguiente.Enabled = False
        End If
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        btnSiguiente.Enabled = True
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
        Dim PagAnt As Integer = CInt(Session("PagAnt"))
        PagAnt = PagAnt + 10
        'PagAnt = CInt(Session("TopPagAnt"))
        If PagAnt > Session("UltimoRegistro") Then
            PagAnt = BitacoraBLL.ConsultarUltimoID
            Session("PagAnt") = CInt(gv_Bitacora.Rows(0).Cells(0).Text)
            PagAnt = CInt(gv_Bitacora.Rows(0).Cells(0).Text)
        Else
            Session("PagAnt") = PagAnt
        End If

        Dim _listabitacora As List(Of Servicios.clsBitacora) = BitacoraBLL.ListarBitacora(_usuario, _fecha, _operacion, PagAnt)
        cargarRegistros(_listabitacora)
        If gv_Bitacora.Rows.Count < 10 Then
            btnSiguiente.Enabled = False
        End If
        If CInt(gv_Bitacora.Rows(0).Cells(0).Text) = Session("UltimoRegistro") Then
            Me.btnAnterior.Enabled = False
        End If
    End Sub
End Class