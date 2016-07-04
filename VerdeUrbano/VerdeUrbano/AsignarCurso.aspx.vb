﻿Public Class AsignarCurso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            inicializar()
        End If

    End Sub
    Public Sub inicializar()
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
        Me.cargarDDL(CursosDisponibles)
        Session("Compras") = CursosDisponibles
    End Sub
    Public Sub cargarDDL(ByVal _compras As List(Of EE.Compra))
        Dim listaCursos As New List(Of EE.Curso)
        For Each c As EE.Compra In _compras
            listaCursos.Add(c.Curso)
        Next
        Me.ddlCurso.DataSource = listaCursos
        Me.ddlCurso.DataSource = listaCursos
        Me.ddlCurso.DataTextField = "Nombre"
        Me.ddlCurso.DataValueField = "ID"
        Me.ddlCurso.DataBind()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim oCompras As New List(Of EE.Compra)
        Dim CompraElegida As New EE.Compra
        oCompras = DirectCast(Session("Compras"), List(Of EE.Compra))
        For Each Comp As EE.Compra In oCompras
            If Comp.Curso.ID = Me.ddlCurso.SelectedValue Then
                CompraElegida = Comp
                Session("CursoAsignar") = CompraElegida
            End If
        Next
        Response.Redirect("asignarAEmpleado.aspx")
    End Sub
End Class