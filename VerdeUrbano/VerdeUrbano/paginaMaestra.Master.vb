Imports System.Xml
Imports System.IO

Public Class paginaMaestra
    Inherits System.Web.UI.MasterPage


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            If Not IsNothing(Session("Usuario")) Then
                cargarMenuOpciones()
                eliminarArchivoMenu()
                generarXMLparaMenu()
                obtenerIdioma()
            Else
                generarXMLEstatico()
                Me.opcionesUsuario.Visible = False
                Me.opcionesLogin.Visible = True
            End If
            BLL.Singleton.InstanciaSing.oUsuarioSesion = RecuperarUsuario()
        End If

    End Sub


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
        Me.opcionesUsuario.Visible = True
        Me.opcionesLogin.Visible = False
        Me.lbl_NombredeUsuarioLogueado.Text = _usuarioLogueado.NombreUsuario

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

    Private Sub generarXMLEstatico()
        Dim MiDirPath As String = Server.MapPath("~/Menu")
        Dim MiPathAGuardar As String = String.Format("{0}\{1}", MiDirPath, "Menu.xml")
        Dim writer As New XmlTextWriter(MiPathAGuardar, System.Text.Encoding.UTF8)
        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("Menus")
        crearMenuXMLestatico(writer)
        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()
        Me.menu1Bind()
    End Sub
    Private Sub generarXMLparaMenu()
        Dim MiDirPath As String = Server.MapPath("~/Menu")
        Dim MiPathAGuardar As String = String.Format("{0}\{1}", MiDirPath, "Menu.xml")
        Dim writer As New XmlTextWriter(MiPathAGuardar, System.Text.Encoding.UTF8)
        writer.WriteStartDocument(True)
        writer.Formatting = Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("Menus")
        crearMenuXMLestatico(writer)
        If Not Me.RecuperarUsuario Is Nothing Then
            Dim _perfil As Servicios.PermisoCompuesto = Me.RecuperarUsuario.Perfil
            '         createMenu(_perfil.Url, _perfil.Descripcion, _perfil.Descripcion, writer)
            recorrerCompuesto(_perfil.ListaPermisos, writer)
            '     cerrarMenu(writer)
        End If
        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()
        Me.menu1Bind()
    End Sub

    Private Sub menu1Bind()
        Menu1.DataSource = Nothing
        Menu1.DataBind()
        Menu1.DataSourceID = "XmlDataSource1"
        Menu1.DataBind()
    End Sub
    Private Sub crearMenuXMLestatico(ByVal writer As XmlTextWriter)
        writer.WriteStartElement("Menu")
        writer.WriteAttributeString("URL", "~/index.aspx")
        writer.WriteAttributeString("Text", "Inicio")
        writer.WriteAttributeString("Value", "Inicio")
        writer.WriteEndElement()
        writer.WriteStartElement("Menu")
        writer.WriteAttributeString("URL", "~/Quienessomos.aspx")
        writer.WriteAttributeString("Text", "Quienes Somos")
        writer.WriteAttributeString("Value", "Quienes Somos")
        writer.WriteEndElement()
        writer.WriteStartElement("Menu")
        writer.WriteAttributeString("URL", "~/Institucional.aspx")
        writer.WriteAttributeString("Text", "Institucional")
        writer.WriteAttributeString("Value", "Institucional")
        writer.WriteEndElement()
        writer.WriteStartElement("Menu")
        writer.WriteAttributeString("URL", "~/nuestrosProductos.aspx")
        writer.WriteAttributeString("Text", "Productos")
        writer.WriteAttributeString("Value", "Productos")
        writer.WriteEndElement()
    End Sub

    Private Sub recorrerCompuesto(ByVal _listaPermisos As List(Of Servicios.PermisoBase), ByVal writer As XmlTextWriter)
        For Each p As Servicios.PermisoBase In _listaPermisos
            If p.TieneHijos = True Then
                createMenu(p.Url, p.Descripcion, p.Descripcion, writer)
                recorrerCompuesto(p.ObtenerHijos, writer)
                cerrarMenu(writer)

            Else
                createSubMenu(p.Url, p.Descripcion, p.Descripcion, writer)
            End If
        Next
    End Sub

    Private Sub createSubMenu(ByVal url As String, ByVal text As String, ByVal value As String, ByVal writer As XmlTextWriter)
        writer.WriteStartElement("Submenu")
        writer.WriteAttributeString("URL", url)
        writer.WriteAttributeString("Text", text)
        writer.WriteAttributeString("Value", value)
        writer.WriteEndElement()
    End Sub

    Private Sub createMenu(ByVal url As String, ByVal text As String, ByVal value As String, ByVal writer As XmlTextWriter)
        writer.WriteStartElement("Menu")
        writer.WriteAttributeString("URL", url)
        writer.WriteAttributeString("Text", text)
        writer.WriteAttributeString("Value", value)
    End Sub

    Private Sub cerrarMenu(ByVal writer As XmlTextWriter)
        writer.WriteEndElement()
    End Sub

    Private Sub eliminarArchivoMenu()
        Try
            Dim MiDirPath As String = Server.MapPath("~/Menu")
            Dim MiPathAEliminar As String = String.Format("{0}\{1}", MiDirPath, "Menu.xml")
            File.Delete(MiPathAEliminar)

        Catch ex As Exception
        End Try

    End Sub

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
        Server.Transfer("index.aspx", false)
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