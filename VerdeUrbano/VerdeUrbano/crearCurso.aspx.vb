﻿Public Class crearCurso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarGrilla()
        End If
    End Sub
    Private Sub CargarGrilla()
        Dim oSol As New EE.SolicitudCurso
        oSol = Session("Solicitud")
        Me.gv_solicitudes.DataSource = oSol
        Me.gv_solicitudes.DataBind()
    End Sub


    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim oCurso As New EE.Curso
        Dim oCursoBLL As New BLL.Curso
        Dim oSol As New EE.SolicitudCurso
        Dim oSolBLL As New BLL.SolicitudCurso
        oSol = Session("Solicitud")
        oCurso = oCursoBLL.Consultar(oSol)
        oCurso.Nombre = txtNombre.Text
        oCurso.Descripcion = txtDescripcion.Text
        oCurso.Duracion = CInt(txtDuracion.Text)
        If oCursoBLL.Modificar(oCurso) = True Then
            oSol.Estado.PasarAEnConstruccion(oSol)
            If oSolBLL.Modificar(oSol) = True Then
                correcto.Visible = True
            Else
                ''Fallo operacion
            End If
        Else
            ''Fallo operacion
        End If

    End Sub
End Class