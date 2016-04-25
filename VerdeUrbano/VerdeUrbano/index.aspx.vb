Public Class index
    Inherits System.Web.UI.Page
    Implements Servicios.Obvserver
    Dim Usuario As New Servicios.Usuario
    Dim Idiomas As New List(Of Servicios.clsIdioma)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Usuario = Me.RecuperarUsuario()
        Dim oIdBLL As New BLL.clsIdioma
        CargarDDL()
        Usuario.AgregarObservador(Me)
    End Sub

    Public Sub ActualizarIdioma() Implements Servicios.Obvserver.ActualizarIdioma
        ''Se dispara cuando el usuario cambia el idioma. Recorre todos los controles y reemplaza la propiedad text de los controles, por la que corresponda segun el idioma seleccionado.
        Dim t As Type
        t = GetType(System.Web.UI.WebControls.Menu)
        For Each x As System.Web.UI.Control In Page.Form.Controls
            If x.GetType() = t Then
                Dim m As New Menu
                m = DirectCast(x, Menu)
                For Each i As MenuItem In m.Items
                    traducirItem(i)
                Next
            Else
                Dim ctrl As New Control
                ctrl = x
                traducirControl(ctrl)

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
            If miControl.GetType() = btnActualizarIdioma.GetType() Then
                MsgBox("asddas")
            End If
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
    Private Sub CargarDDL()
        Dim oIdBLL As New BLL.clsIdioma
        Idiomas = oIdBLL.ListarIdiomas
        Me.DropDownList1.DataSource = Idiomas
        Me.DropDownList1.DataTextField = "Descripcion"
        Me.DropDownList1.DataValueField = "ID"
        Me.DropDownList1.DataBind()
    End Sub
    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles btnActualizarIdioma.Click
        Dim oUsuBLL As New BLL.clsUsuario
        Dim NuevoIdioma As New Servicios.clsIdioma
        NuevoIdioma.ID = Me.DropDownList1.SelectedValue

        Usuario.Idioma = NuevoIdioma
        oUsuBLL.ModificarUsuario(Usuario)
        Usuario.Notificar()
    End Sub
End Class