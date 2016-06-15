Public Class seleccionarSatisfaccion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cargarGrid()

    End Sub
    Public Sub cargarGrid()
        Dim oEmpBLL As New BLL.Empresa
        Dim oClientes As New List(Of EE.Empresa)
        oClientes = oEmpBLL.ListarClientes
        Me.gv_Clientes.DataSource = oClientes
        Me.gv_Clientes.DataBind()
    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles btnSeleccionar.Click
        Dim oCliente As New EE.Empresa
        oCliente.ID = 1
        Dim oClieBLL As New BLL.Empresa
        oCliente = oClieBLL.

    End Sub


End Class