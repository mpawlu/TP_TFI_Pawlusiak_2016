Imports System.Xml
Imports System.IO

Public Class paginaMaestra
    Inherits System.Web.UI.MasterPage


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            armarMenuBasico()
            If Not IsNothing(Session("Usuario")) Then
                cargarMenuOpciones()
                ArmarMenuUsuario()

                obtenerIdioma()
            Else

                Me.opcionesUsuario.Visible = False
                Me.opcionesLogin.Visible = True
            End If

        End If

    End Sub

#Region "ARMAR MENU"
    Private Sub armarMenuBasico()
        Dim MiMenuInicio As New MenuItem

        MiMenuInicio.NavigateUrl = "~/index.aspx"
        MiMenuInicio.Value = "Inicio"

        Dim MiMenuInstitucional As New MenuItem
        MiMenuInstitucional.NavigateUrl = "~/institucional.aspx"
        MiMenuInstitucional.Value = "Institucional"

        Dim MiMenuServicios As New MenuItem
        MiMenuServicios.NavigateUrl = "~/nuestrosProductos.aspx"
        MiMenuServicios.Value = "Productos"

        Dim MiMenuNewsletter As New MenuItem
        MiMenuNewsletter.NavigateUrl = "~/quienesSomos.aspx"
        MiMenuNewsletter.Value = "Quienes Somos"

        'Creo los menues principales
        Menu1.Items.Add(MiMenuInicio)
        Menu1.Items.Add(MiMenuServicios)
        Menu1.Items.Add(MiMenuNewsletter)
        Menu1.Items.Add(MiMenuInstitucional)

    End Sub

    Private Sub ArmarMenuUsuario()
        Try
            Dim _usu As Servicios.Usuario = Me.RecuperarUsuario
            Dim archivo As New XmlDocument
            archivo.Load(Server.MapPath("Menu/MenuCompleto.xml"))
            Dim listaXMLnodes As XmlNodeList = archivo.SelectNodes("menu/submenu")
            'SON TODOS LOS SUBMENUS
            recorrerSubMenu(listaXMLnodes, _usu.Perfil.ListaPermisos)
        Catch ex As Exception

        End Try

    End Sub

    Private Sub recorrerSubMenu(ByVal _xmlNodeList As XmlNodeList, ByVal _permisosUsuario As List(Of Servicios.PermisoBase))
        Try
            For Each submenu As XmlNode In _xmlNodeList
                'COMPRUEBO QUE TENGA ITEMS
                If submenu.ChildNodes.Count > 0 Then
                    Dim NodoPadre As XmlNode = submenu
                    recorrerItems(submenu.ChildNodes, _permisosUsuario, NodoPadre)
                End If
            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub recorrerItems(ByVal _xmlNodeList As XmlNodeList, ByVal _permisosUsuario As List(Of Servicios.PermisoBase), ByVal nodoPadre As XmlNode)
        'ACA SE RECORREN LOS ITEMS

        For Each item As XmlNode In _xmlNodeList
            Dim _flag As Boolean = False
            chequearPermisos(CInt(item.Attributes("id").Value.ToString), _permisosUsuario, _flag)
            If _flag = True Then
                'QUIERE DECIR QUE LO TIENE
                Dim _bllPermiso As New BLL.clsPermiso
                Dim _idPermiso As Integer = BLL.clsPermiso.obtenerIDPermiso(item.Attributes("nombre").Value.ToString)
                Dim _permisoEntidad As Servicios.PermisoBase = _bllPermiso.ConsultarPermiso(_idPermiso)
                crearItemMenu(nodoPadre.Attributes("nombre").Value.ToString, _permisoEntidad)
            End If
            If item.ChildNodes.Count > 0 Then
                recorrerItems(item.ChildNodes, _permisosUsuario, item)
            End If
        Next
    End Sub


    Private Sub chequearPermisos(ByVal idPermiso As Integer, ByVal _permisosUsuario As List(Of Servicios.PermisoBase), ByRef flag As Boolean)
        For Each _permiso As Servicios.PermisoBase In _permisosUsuario
            If _permiso.ID = idPermiso Then
                flag = True
                Exit Sub
            End If
            If _permiso.TieneHijos = True Then
                chequearPermisos(idPermiso, _permiso.ObtenerHijos(), flag)
            End If
        Next
    End Sub

    Private Sub crearItemMenu(ByVal paramNombrePadre As String, ByVal paramPermiso As Servicios.PermisoBase)
        'Creo el MenuItemPadre
        Try
            Dim MenuItemPadre As New MenuItem
            MenuItemPadre.Text = paramNombrePadre
            MenuItemPadre.Value = paramNombrePadre
            MenuItemPadre.NavigateUrl = "#"
            Dim miFlag As Boolean = False
            MenuExiste(paramNombrePadre, miFlag, Me.Menu1.Items)
            If miFlag = False Then
                Menu1.Items.Add(MenuItemPadre)
            Else
                BuscarMenu(MenuItemPadre.Text, Me.Menu1.Items, MenuItemPadre)
            End If
            Dim MenuItemHijo As New MenuItem
            MenuItemHijo.Text = paramPermiso.Descripcion
            MenuItemHijo.Value = paramPermiso.Descripcion
            MenuItemHijo.NavigateUrl = paramPermiso.Url


            Dim Indice As Integer
            Indice = CInt(Menu1.Items.IndexOf(MenuItemPadre))
            'Pregunto si lo que estoy recorriendo tiene padre
            Dim indicepapa As Integer
            If Not IsNothing(MenuItemPadre.Parent) Then ' Este es el ABUELO
                'Si tiene abuelo, entra acá
                Dim indiceabuelo As Integer
                indiceabuelo = Menu1.Items.IndexOf(MenuItemPadre.Parent)
                indicepapa = MenuItemPadre.Parent.ChildItems.IndexOf(MenuItemPadre)
                Dim _nuevoPapa As MenuItem = Menu1.Items(indiceabuelo).ChildItems(indicepapa)
                Menu1.Items(indiceabuelo).ChildItems.Remove(_nuevoPapa)
                _nuevoPapa.ChildItems.Add(MenuItemHijo)
                '   mipapa = MenuItemPadre.Parent.Value
                '  indicepapa = MenuItemPadre.Parent.ChildItems.IndexOf(MenuItemPadre)
                Menu1.Items(indiceabuelo).ChildItems.Add(_nuevoPapa)
            Else
                Menu1.Items(Indice).ChildItems.Add(MenuItemHijo)
            End If

        Catch ex As Exception
        End Try


    End Sub




    Private Sub MenuExiste(ByVal paramNombrePadre As String, ByRef flag As Boolean, ByVal menuitems As MenuItemCollection)
        Try
            For Each MiItem As MenuItem In menuitems
                If MiItem.Text = paramNombrePadre Then
                    flag = True
                End If
                If MiItem.ChildItems.Count > 0 Then
                    MenuExiste(paramNombrePadre, flag, MiItem.ChildItems)
                End If
            Next
        Catch ex As Exception

        End Try

    End Sub
    Private Sub BuscarMenu(ByVal paramNombrePadre As String, ByVal menuitems As MenuItemCollection, ByRef menuItemPadre As MenuItem)
        For Each MiItem As MenuItem In menuitems
            If MiItem.Text = paramNombrePadre Then
                menuItemPadre = MiItem
            End If
            If MiItem.ChildItems.Count > 0 Then
                BuscarMenu(paramNombrePadre, MiItem.ChildItems, menuItemPadre)
            End If
        Next
    End Sub
#End Region
#Region "MultiIdioma"
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
        MiMenuP = Me.FindControl("Menu1")
        If MiMenuP.Items.Count > 0 Then
            traducirMenuRecursivo(MiMenuP.Items)
        End If
    End Sub

    Private Sub traducirMenuRecursivo(ByVal _items As MenuItemCollection)
        For Each MiMenuItem As MenuItem In _items
            traducir(MiMenuItem)
            If MiMenuItem.ChildItems.Count > 0 Then
                traducirMenuRecursivo(MiMenuItem.ChildItems)
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

#End Region
#Region "Opciones de Usuario"
    Private Sub cargarMenuOpciones()
        Dim _usuarioLogueado As Servicios.Usuario = Me.RecuperarUsuario
        Dim _bblPersona As New BLL.Persona
        Dim _personaLogueada As EE.Persona = _bblPersona.Consultar(_usuarioLogueado.DNI)

        Me.opcionesUsuario.Visible = True
        Me.opcionesLogin.Visible = False
        Me.lbl_NombredeUsuarioLogueado.Text = _usuarioLogueado.NombreUsuario
        Me.img_usuario.Src = _personaLogueada.Imagen
        ''Agregado para img
        'If DirectCast(Session("Usuario"), Entidades.Usuario).Persona.Imagen <> "" Then
        '    Me.img_Usuario.Src = DirectCast(Session("Usuario"), Entidades.Usuario).Persona.Imagen
        'Else
        '    Me.img_Usuario.Src = "~/Imagenes/userh.png"
        'End If
    End Sub

#End Region
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
#Region "Generador Menu XML"

    'Private Sub generarXMLEstatico()
    '    Dim MiDirPath As String = Server.MapPath("~/Menu")
    '    Dim MiPathAGuardar As String = String.Format("{0}\{1}", MiDirPath, "Menu.xml")
    '    Dim writer As New XmlTextWriter(MiPathAGuardar, System.Text.Encoding.UTF8)
    '    writer.WriteStartDocument(True)
    '    writer.Formatting = Formatting.Indented
    '    writer.Indentation = 2
    '    writer.WriteStartElement("Menus")
    '    crearMenuXMLestatico(writer)
    '    writer.WriteEndElement()
    '    writer.WriteEndDocument()
    '    writer.Close()
    '    Me.menu1Bind()
    'End Sub
    'Private Sub generarXMLparaMenu()
    '    Dim MiDirPath As String = Server.MapPath("~/Menu")
    '    Dim MiPathAGuardar As String = String.Format("{0}\{1}", MiDirPath, "Menu.xml")
    '    Dim writer As New XmlTextWriter(MiPathAGuardar, System.Text.Encoding.UTF8)
    '    writer.WriteStartDocument(True)
    '    writer.Formatting = Formatting.Indented
    '    writer.Indentation = 2
    '    writer.WriteStartElement("Menus")
    '    crearMenuXMLestatico(writer)
    '    If Not Me.RecuperarUsuario Is Nothing Then
    '        Dim _perfil As Servicios.PermisoCompuesto = Me.RecuperarUsuario.Perfil
    '        recorrerCompuesto(_perfil.ListaPermisos, writer)
    '    End If
    '    writer.WriteEndElement()
    '    writer.WriteEndDocument()
    '    writer.Close()
    '    Me.menu1Bind()
    'End Sub

    'Private Sub menu1Bind()
    '    Menu1.DataSource = Nothing
    '    Menu1.DataBind()
    '    Menu1.DataSourceID = "XmlDataSource1"
    '    Menu1.DataBind()
    'End Sub
    'Private Sub crearMenuXMLestatico(ByVal writer As XmlTextWriter)
    '    writer.WriteStartElement("Menu")
    '    writer.WriteAttributeString("URL", "~/index.aspx")
    '    writer.WriteAttributeString("Text", "Inicio")
    '    writer.WriteAttributeString("Value", "Inicio")
    '    writer.WriteEndElement()
    '    writer.WriteStartElement("Menu")
    '    writer.WriteAttributeString("URL", "~/Quienessomos.aspx")
    '    writer.WriteAttributeString("Text", "Quienes Somos")
    '    writer.WriteAttributeString("Value", "Quienes Somos")
    '    writer.WriteEndElement()
    '    writer.WriteStartElement("Menu")
    '    writer.WriteAttributeString("URL", "~/Institucional.aspx")
    '    writer.WriteAttributeString("Text", "Institucional")
    '    writer.WriteAttributeString("Value", "Institucional")
    '    writer.WriteEndElement()
    '    writer.WriteStartElement("Menu")
    '    writer.WriteAttributeString("URL", "~/nuestrosProductos.aspx")
    '    writer.WriteAttributeString("Text", "Productos")
    '    writer.WriteAttributeString("Value", "Productos")
    '    writer.WriteEndElement()
    'End Sub

    'Private Sub recorrerCompuesto(ByVal _listaPermisos As List(Of Servicios.PermisoBase), ByVal writer As XmlTextWriter)
    '    For Each p As Servicios.PermisoBase In _listaPermisos
    '        If p.TieneHijos = True Then
    '            createMenu(p.Url, p.Descripcion, p.Descripcion, writer)
    '            recorrerCompuesto(p.ObtenerHijos, writer)
    '            cerrarMenu(writer)

    '        Else
    '            createSubMenu(p.Url, p.Descripcion, p.Descripcion, writer)
    '        End If
    '    Next
    'End Sub

    'Private Sub createSubMenu(ByVal url As String, ByVal text As String, ByVal value As String, ByVal writer As XmlTextWriter)
    '    writer.WriteStartElement("Submenu")
    '    writer.WriteAttributeString("URL", url)
    '    writer.WriteAttributeString("Text", text)
    '    writer.WriteAttributeString("Value", value)
    '    writer.WriteEndElement()
    'End Sub

    'Private Sub createMenu(ByVal url As String, ByVal text As String, ByVal value As String, ByVal writer As XmlTextWriter)
    '    writer.WriteStartElement("Menu")
    '    writer.WriteAttributeString("URL", url)
    '    writer.WriteAttributeString("Text", text)
    '    writer.WriteAttributeString("Value", value)
    'End Sub

    'Private Sub cerrarMenu(ByVal writer As XmlTextWriter)
    '    writer.WriteEndElement()
    'End Sub

    'Private Sub eliminarArchivoMenu()
    '    Try
    '        Dim MiDirPath As String = Server.MapPath("~/Menu")
    '        Dim MiPathAEliminar As String = String.Format("{0}\{1}", MiDirPath, "Menu.xml")
    '        File.Delete(MiPathAEliminar)

    '    Catch ex As Exception
    '    End Try

    'End Sub

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
    Public Sub FinalizarUsuario()
        Session.Remove("Usuario")
        BLL.Singleton.InstanciaSing.oUsuarioSesion = Nothing
        Me.opcionesUsuario.Visible = False
    End Sub
#End Region


    Protected Sub cambiarPassword_Click(sender As Object, e As EventArgs)
        Response.Redirect("cambiarPassword.aspx")
    End Sub

    Protected Sub cambiarIdioma_Click(sender As Object, e As EventArgs)
        Response.Redirect("cambiarIdioma.aspx")
    End Sub

    Protected Sub cerrarSesion_Click(sender As Object, e As EventArgs)
        Me.FinalizarUsuario()
        Dim Context As HttpContext = HttpContext.Current
        If Context.Items.Contains("logoutCorrecto") = True Then
            Context.Items.Remove("logoutCorrecto")
        End If
        Context.Items.Add("logoutCorrecto", True)
        Server.Transfer("index.aspx", False)
    End Sub

    Protected Sub Menu1_MenuItemDataBound(sender As Object, e As MenuEventArgs)
        Dim currentPage As String = Request.Url.Segments(Request.Url.Segments.Length - 1).Split(".")(0)
        If e.Item.Text.Equals(currentPage, StringComparison.InvariantCultureIgnoreCase) Then
            If e.Item.Parent IsNot Nothing Then
                e.Item.Parent.Selected = True
            Else
                e.Item.Selected = True
            End If
        End If

    End Sub
End Class