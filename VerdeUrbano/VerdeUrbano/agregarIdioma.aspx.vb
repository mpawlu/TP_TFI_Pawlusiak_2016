Public Class agregarIdioma
    Inherits System.Web.UI.Page
    Dim oLeyenda As New List(Of Servicios.clsLeyenda)
    Dim oLeyBLL As New BLL.clsLeyenda
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim oTrad As New List(Of Servicios.ClsTraduccion)
        Dim oIdioma As New Servicios.clsIdioma
        Dim oTradBLL As New BLL.ClsTraduccion
        oIdioma.ID = 1
        oTrad = oTradBLL.ListarTraducciones(oIdioma)
        CargarGrilla()
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim NuevoIdioma As New Servicios.clsIdioma

    End Sub
    Private Sub CargarGrilla()
        oLeyenda = oLeyBLL.ListarLeyendas
        Me.gv_Palabras.DataSource = oLeyenda
        Me.gv_Palabras.DataBind()

    End Sub
End Class