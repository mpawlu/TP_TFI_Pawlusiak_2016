Public Class paginaMaestra
    Inherits System.Web.UI.MasterPage

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarMenuEstatico()
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

End Class