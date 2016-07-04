Public Class AsignarCurso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim CursosDisponibles As New List(Of EE.Compra)
        Dim Empleados As New List(Of EE.Persona)
        Dim oCompraBLL As New BLL.Compra
        Dim oPerBLL As New BLL.Persona
        Dim oUsSes As New Servicios.Usuario
        oUsSes = DirectCast(Session("Usuario"), Servicios.Usuario)
        Dim oManager As New EE.Persona
        Dim oPersonaBLL As New BLL.Persona
        oManager = oPersonaBLL.Consultar(oUsSes.DNI)
        CursosDisponibles = oCompraBLL.ConsultarCompras(oManager.Empresa)
        Empleados = oPerBLL.Listar(oManager.Empresa)
    End Sub

End Class