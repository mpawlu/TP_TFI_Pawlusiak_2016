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
        MiMenuInstitucional.NavigateUrl = "#"
        MiMenuInstitucional.Text = "Institucional"
        MiMenuInstitucional.Value = "Institucional"

        Dim MiMenuServicios As New MenuItem
        MiMenuServicios.NavigateUrl = "#"
        MiMenuServicios.Text = "Servicios"
        MiMenuServicios.Value = "Servicios"

        menuPrincipal.Items.Add(MiMenuInicio)
        menuPrincipal.Items.Add(MiMenuInstitucional)
        menuPrincipal.Items.Add(MiMenuServicios)

    End Sub

End Class