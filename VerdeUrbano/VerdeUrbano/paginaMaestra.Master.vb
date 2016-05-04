Imports System.Xml

Public Class paginaMaestra
    Inherits System.Web.UI.MasterPage


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            cargarMenuEstatico()
            If Not IsNothing(Session("Usuario")) Then
                '      Me.menuVertical.Items.Clear()
                '      ArmarMenuUsuario()
                '      cargarMenuOpciones()
                '      miMenuVertical.Attributes.Add("class", "col-md-2")
                '      miContenidoPagina.Attributes.Add("class", "col-md-10")
                obtenerIdioma()
            Else
                '      Me.opcionesUsuario.Visible = False
                '      miContenidoPagina.Attributes.Add("class", "col-md-12")
            End If
        End If
    End Sub


    Private Sub obtenerIdioma()
        If Not IsNothing(Session("Usuario")) Then
            traducirMenuPrincipal()
            Dim mpContentPlaceHolder As New ContentPlaceHolder
            mpContentPlaceHolder = Me.FindControl("contenidoPagina")
            traducirControl(mpContentPlaceHolder.Controls)
        End If
    End Sub


    Private Sub traducirMenuPrincipal()
        Dim MiMenuP As Menu
        MiMenuP = Me.FindControl("menuPrincipal")
        For Each MiMenuItem As MenuItem In MiMenuP.Items
            traducir(MiMenuItem)
            If MiMenuItem.ChildItems.Count > 0 Then
                For Each MiMenuItemHijo As MenuItem In MiMenuItem.ChildItems
                    traducir(MiMenuItemHijo)
                Next
            End If
        Next
    End Sub

    Private Sub traducirControl(ByVal paramListaControl As ControlCollection)
        For Each miControl As Control In paramListaControl
            If TypeOf miControl Is Button Then
                traducir(DirectCast(miControl, Button))
            ElseIf TypeOf miControl Is CheckBox Then
                traducir(DirectCast(miControl, CheckBox))
            ElseIf TypeOf miControl Is RadioButton Then
                traducir(DirectCast(miControl, RadioButton))
            ElseIf TypeOf miControl Is Label Then
                traducir(DirectCast(miControl, Label))
            ElseIf TypeOf miControl Is HtmlGenericControl Then
                traducirControl(miControl.Controls)
            End If
        Next
    End Sub

#Region "Traductor"

    Private Sub traducir(ByVal _menuitem As MenuItem)
        Dim _idioma As Servicios.clsIdioma
        _idioma = CType(Session("Usuario"), Servicios.Usuario).Idioma
        Dim _bllTraduccion As New BLL.ClsTraduccion
        Dim _listaTraducciones As New List(Of Servicios.ClsTraduccion)
        _listaTraducciones = _bllTraduccion.ListarTraducciones(_idioma)
        For Each MiPalabra As Servicios.ClsTraduccion In _listaTraducciones
            If UCase(MiPalabra.Leyenda.ID) = UCase(_menuitem.Value) Then
                _menuitem.Text = MiPalabra.Traduccion
            End If
        Next
    End Sub

    Private Sub traducir(ByVal _radio As RadioButton)
        Dim _idioma As Servicios.clsIdioma
        _idioma = CType(Session("Usuario"), Servicios.Usuario).Idioma
        Dim _bllTraduccion As New BLL.ClsTraduccion
        Dim _listaTraducciones As New List(Of Servicios.ClsTraduccion)
        _listaTraducciones = _bllTraduccion.ListarTraducciones(_idioma)
        For Each MiPalabra As Servicios.ClsTraduccion In _listaTraducciones
            If UCase(MiPalabra.Leyenda.ID) = UCase(_radio.ID) Then
                _radio.Text = MiPalabra.Traduccion
            End If
        Next
    End Sub
    Private Sub traducir(ByVal _label As Label)
        Dim _idioma As Servicios.clsIdioma
        _idioma = CType(Session("Usuario"), Servicios.Usuario).Idioma
        Dim _bllTraduccion As New BLL.ClsTraduccion
        Dim _listaTraducciones As New List(Of Servicios.ClsTraduccion)
        _listaTraducciones = _bllTraduccion.ListarTraducciones(_idioma)
        For Each MiPalabra As Servicios.ClsTraduccion In _listaTraducciones
            If UCase(MiPalabra.Leyenda.ID) = UCase(_label.ID) Then
                _label.Text = MiPalabra.Traduccion
            End If
        Next

    End Sub
    Private Sub traducir(ByVal _button As Button)
        Dim _idioma As Servicios.clsIdioma
        _idioma = CType(Session("Usuario"), Servicios.Usuario).Idioma
        Dim _bllTraduccion As New BLL.ClsTraduccion
        Dim _listaTraducciones As New List(Of Servicios.ClsTraduccion)
        _listaTraducciones = _bllTraduccion.ListarTraducciones(_idioma)
        For Each MiPalabra As Servicios.ClsTraduccion In _listaTraducciones
            If UCase(MiPalabra.Leyenda.ID) = UCase(_button.ID) Then
                _button.Text = MiPalabra.Traduccion
            End If
        Next
    End Sub
    Private Sub traducir(ByVal _checkbox As CheckBox)
        Dim _idioma As Servicios.clsIdioma
        _idioma = CType(Session("Usuario"), Servicios.Usuario).Idioma
        Dim _bllTraduccion As New BLL.ClsTraduccion
        Dim _listaTraducciones As New List(Of Servicios.ClsTraduccion)
        _listaTraducciones = _bllTraduccion.ListarTraducciones(_idioma)
        For Each MiPalabra As Servicios.ClsTraduccion In _listaTraducciones
            If UCase(MiPalabra.Leyenda.ID) = UCase(_checkbox.ID) Then
                _checkbox.Text = MiPalabra.Traduccion
            End If
        Next
    End Sub
#End Region
#Region "Menus"
    Private Sub cargarMenuEstatico()
        Dim MiMenuInicio As New MenuItem
        MiMenuInicio.NavigateUrl = "~/index.aspx"
        MiMenuInicio.Text = "Inicio"
        MiMenuInicio.Value = "Inicio"

        Dim MiMenuInstitucional As New MenuItem
        MiMenuInstitucional.NavigateUrl = "~/institucional.aspx"
        MiMenuInstitucional.Text = "Institucional"
        MiMenuInstitucional.Value = "Institucional"

        Dim MiMenuServicios As New MenuItem
        MiMenuServicios.NavigateUrl = "~/quienesSomos.aspx"
        MiMenuServicios.Text = "Quienes Somos"
        MiMenuServicios.Value = "Quienes Somos"

        Dim miMenuProductos As New MenuItem
        miMenuProductos.NavigateUrl = "~/nuestrosProductos.aspx"
        miMenuProductos.Text = "Nuestros Productos"
        miMenuProductos.Value = "Nuestros Productos"

        Dim Ingresar As New MenuItem
        Ingresar.NavigateUrl = "~/login.aspx"
        Ingresar.Text = "Ingresar"
        Ingresar.Value = "Nuestros Productos"

        menuPrincipal.Items.Add(MiMenuInicio)
        menuPrincipal.Items.Add(MiMenuInstitucional)
        menuPrincipal.Items.Add(MiMenuServicios)
        menuPrincipal.Items.Add(miMenuProductos)
        menuPrincipal.Items.Add(Ingresar)
    End Sub

    Private Sub ArmarMenuUsuario()
        If Session("Usuario") IsNot Nothing Then
            Dim _usu As Servicios.Usuario = RecuperarUsuario()
            '     Me.NombreUsuario.Text = _usu.NombreUsuario
            'Hago el Load para el Menu.xml
            Dim archivo As New XmlDocument
            archivo.Load(Server.MapPath("Menu.xml"))
            'Recorro Todo el Menu en XML
            For i As Integer = 0 To archivo.SelectNodes("menu/submenu").Count - 1
                Dim NodoPadre As XmlNode = archivo.SelectNodes("menu/submenu").Item(i)
                'Recorro los Items dentro del Nodo Sub Menu
                For j As Integer = 0 To NodoPadre.ChildNodes.Count - 1
                    Dim Nodohijo As XmlNode = NodoPadre.ChildNodes(j)
                    '     chequearPermisos(_usu.Perfil.ListaPermisosSimple, NodoPadre.Attributes("nombre").Value.ToString(), Nodohijo.Attributes("nombre").Value.ToString)
                Next
            Next
        End If
    End Sub
    Private Sub chequearPermisos(ByVal listaPermisos As List(Of Servicios.PermisoBase), ByVal paramNombrePadre As String, ByVal paramNombreHijo As String)
        For Each per As Servicios.PermisoBase In listaPermisos
            If per.TieneHijos = False Then ' Si tiene hijos va a ser un Permiso Compuesto
                If per.Descripcion = paramNombreHijo Then
                    crearItemMenu(paramNombrePadre, per)
                End If
            Else
                'RECURSIVIDAD
                Me.chequearPermisos(per.ObtenerHijos, paramNombrePadre, paramNombreHijo)
            End If
        Next
    End Sub
    Private Sub crearItemMenu(ByVal paramNombrePadre As String, ByVal paramPermiso As Servicios.PermisoBase)
        'Creo el MenuItemPadre
        Dim MenuItemPadre As New MenuItem
        MenuItemPadre.Text = paramNombrePadre
        MenuItemPadre.NavigateUrl = "#"

        If MenuExiste(paramNombrePadre) = False Then
            'Si no existe el MenuItem Padre
            menuPrincipal.Items.Add(MenuItemPadre)
        Else
            'si no existe devolveme el que se llama asi
            MenuItemPadre = BuscarMenu(MenuItemPadre.Text)
        End If

        Dim MenuItemHijo As New MenuItem
        MenuItemHijo.Text = paramPermiso.Descripcion
        MenuItemHijo.NavigateUrl = paramPermiso.URL
        menuPrincipal.Items(menuPrincipal.Items.IndexOf(MenuItemPadre)).ChildItems.Add(MenuItemHijo)

    End Sub
    Private Function MenuExiste(ByVal paramNombrePadre As String) As Boolean
        For Each MiItem As MenuItem In menuPrincipal.Items
            If MiItem.Text = paramNombrePadre Then Return True
        Next
        Return False
    End Function
    Private Function BuscarMenu(ByVal paramNombrePadre As String) As MenuItem
        For Each MiItem As MenuItem In menuPrincipal.Items
            If MiItem.Text = paramNombrePadre Then Return MiItem
        Next
        Return Nothing
    End Function
#End Region

#Region "Manejo de Usuario"
    Public Sub InicializarUsuario()
        Dim UsuarioActual As New Servicios.Usuario
        Dim usuarioBLL As New BLL.clsUsuario
        'Le pongo el ID = 2 para traer un usuario de prueba
        UsuarioActual.ID = 2
        UsuarioActual = usuarioBLL.ListarUsuario(UsuarioActual)
        UsuarioActual.AgregarObservador(Me)
        Me.GuardarUsuario(UsuarioActual)
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
#End Region


End Class