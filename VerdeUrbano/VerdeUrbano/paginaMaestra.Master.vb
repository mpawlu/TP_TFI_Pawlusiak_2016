Public Class paginaMaestra
    Inherits System.Web.UI.MasterPage
    Implements Servicios.Obvserver

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            cargarMenuEstatico()
      
        End If
        Dim miusuario As New Servicios.Usuario
        miusuario = RecuperarUsuario()
        If Not IsNothing(miusuario) Then
            miusuario.AgregarObservador(Me)
        End If

    End Sub


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
    Public Sub ActualizarIdioma() Implements Servicios.Obvserver.ActualizarIdioma
        Try
            Dim miusuario As New Servicios.Usuario
            miusuario = RecuperarUsuario()

            If Not IsNothing(miusuario) Then
                'Traduce el menú principal
                Dim MiMenuP As Menu
                MiMenuP = Me.FindControl("menuPrincipal")
                For Each MiMenuItem As MenuItem In MiMenuP.Items
                    traducirItem(MiMenuItem)
                    If MiMenuItem.ChildItems.Count > 0 Then
                        For Each MiMenuItemHijo As MenuItem In MiMenuItem.ChildItems
                            traducirItem(MiMenuItemHijo)
                        Next
                    End If
                Next

                'Recorro los controles de la página
                Dim mpContentPlaceHolder As New ContentPlaceHolder
                mpContentPlaceHolder = Me.FindControl("contenidoPagina")
                traducirControl(mpContentPlaceHolder.Controls)
            End If

            ' ''Se dispara cuando el usuario cambia el idioma. Recorre todos los controles y reemplaza la propiedad text de los controles, por la que corresponda segun el idioma seleccionado.
            'For Each x As Control In Page.Form.Controls
            '    If x.GetType() = Me.menuPrincipal.GetType() Then
            '        Dim m As New Menu
            '        m = DirectCast(x, Menu)
            '        For Each i As MenuItem In m.Items
            '            traducirItem(i)
            '        Next
            '    Else
            '        traducirControl(x)
            '    End If
            'Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub


    ''' <summary>
    ''' Traduce cada control de la página
    ''' </summary>
    ''' <param name="paramListaControl">Espera una control collection.</param>
    Private Sub traducirControl(ByVal paramListaControl As ControlCollection)
        For Each miControl As Control In paramListaControl
            If TypeOf miControl Is Button Then
                traducirControl(DirectCast(miControl, Button))
            ElseIf TypeOf miControl Is CheckBox Then
                traducirControl(DirectCast(miControl, CheckBox))
            ElseIf TypeOf miControl Is RadioButton Then
                traducirControl(DirectCast(miControl, RadioButton))
            ElseIf TypeOf miControl Is Label Then
                traducirControl(DirectCast(miControl, Label))
            ElseIf TypeOf miControl Is ImageButton Then
                traducirControl(DirectCast(miControl, ImageButton))
            ElseIf TypeOf miControl Is HtmlGenericControl Then
                traducirControl(miControl.Controls)
            End If
        Next
    End Sub

    Private Sub traducirItem(ByVal menuItem As MenuItem)
        Dim UsuarioActual As Servicios.Usuario = RecuperarUsuario()
        Dim oTradBLL As New BLL.ClsTraduccion
        Dim oTraducciones As List(Of Servicios.ClsTraduccion)
        oTraducciones = oTradBLL.ListarTraducciones(UsuarioActual.Idioma)
        For Each Trad As Servicios.ClsTraduccion In oTraducciones
            If menuItem.Value = Trad.Leyenda.ID Then
                menuItem.Text = Trad.Traduccion.ToString
                menuItem.GetType.GetProperty("Text").SetValue(menuItem, Trad.Traduccion, Nothing)
            End If
            If menuItem.ChildItems.Count > 0 Then
                For Each menuItemChild As MenuItem In menuItem.ChildItems
                    traducirItem(menuItemChild)
                Next
            End If
        Next
    End Sub

    Private Sub traducirControl(ByVal miControl As Control)
        Dim UsuarioActual As Servicios.Usuario = RecuperarUsuario()
        Dim oTradBLL As New BLL.ClsTraduccion
        Dim oTraducciones As List(Of Servicios.ClsTraduccion)
        oTraducciones = oTradBLL.ListarTraducciones(UsuarioActual.Idioma)
        For Each Trad As Servicios.ClsTraduccion In oTraducciones
            If Trad.Leyenda.ID = miControl.ID Then
                miControl.GetType.GetProperty("Text").SetValue(miControl, Trad.Traduccion, Nothing)
                'miControl.GetType.GetProperty("imageURL").SetValue(miControl, Trad.Traduccion, Nothing)
            End If
        Next

    End Sub

    Private Sub traducir(ByVal miButton As Button)
        MsgBox("soy boton")
    End Sub


    Public Sub InicializarUsuario()
        Dim UsuarioActual As New Servicios.Usuario
        Dim usuarioBLL As New BLL.clsUsuario
        'Le pongo el ID = 2 para traer un usuario de prueba
        UsuarioActual.Id = 2
        UsuarioActual = usuarioBLL.ListarUsuario(UsuarioActual)
        UsuarioActual.AgregarObservador(Me)
        Me.GuardarUsuario(UsuarioActual)

        UsuarioActual.Notificar()
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
    Private Function TieneHijos(ByVal hijo As MenuItem) As Boolean
        If hijo.ChildItems.Count > 0 Then
            Return True
        Else
            Return False
        End If
    End Function
End Class