﻿Public Class agregarSolicitudCurso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            obtenerUsuarios()
            obtenerCategorias()
        End If
    End Sub

    Private Sub obtenerUsuarios()
        Try
            Dim _bllUsuario As New BLL.clsUsuario
            Dim _listaUsuarios As New List(Of Servicios.Usuario)
            _listaUsuarios = _bllUsuario.ObtenerDisenadores
            Me.gv_Profesores.DataSource = _listaUsuarios
            Me.gv_Profesores.DataBind()
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub
    Private Sub obtenerCategorias()
        Dim oCatBLL As New BLL.Categoria

        Dim oCategoria As New List(Of EE.Categoria)
        oCategoria = oCatBLL.ListarCategorias()
        Me.ddlCategoria.DataSource = oCategoria
        Me.ddlCategoria.DataTextField = "Descripcion"
        Me.ddlCategoria.DataValueField = "ID"
        Me.ddlCategoria.DataBind()

    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Dim oDisenador As New Servicios.Usuario
        Dim oSolicitante As New Servicios.Usuario
        Dim oSolicitud As New EE.SolicitudCurso
        Dim oEstadoSolicitud As New EE.EnConstruccion
        Dim oCurso As New EE.Curso
        Dim oEstadoCurso As New EE.EnCreacion
        Dim oUsuBLL As New BLL.clsUsuario
        Dim oCategoria As New EE.Categoria
        Dim oSolicitudBLL As New BLL.SolicitudCurso
        Dim oCursoBLL As New BLL.Curso
        oCategoria.ID = ddlCategoria.SelectedValue
        oCategoria.Descripcion = Me.ddlCategoria.SelectedItem.Text
        oSolicitante = CType(Session("Usuario"), Servicios.Usuario)
        ''oDisenador.ID = aca tengo que poner el ID del disenador que selecciono
        oDisenador.ID = 11  ''Y comentar esta linea
        oDisenador = oUsuBLL.RecuperarUsuario(oDisenador)
        oSolicitud.Disenador = oDisenador
        oSolicitud.Solicitante = oSolicitante
        oCurso.Estado = oEstadoCurso
        oCurso.Categoria = oCategoria
        oSolicitud.Titulo = Me.txtTitulo.Text
        oSolicitud.Detalle = Me.txtDetalle.Text
        oSolicitud.FechaLimiteDeCreacion = Today
        oSolicitud.FechaSolicitud = Today
        oSolicitud.Estado = oEstadoSolicitud
        If oSolicitudBLL.Guardar(oSolicitud) = True Then
            oCurso.SolicitudCurso = oSolicitudBLL.ConsultarUltima
            If oCursoBLL.Guardar(oCurso) = True Then
                ''Operacion exitossa
            Else
                ''FALLO Operacion
            End If
        Else
            ''Fallo operacion
        End If

    End Sub
    Protected Sub btnCalculador_Click(sender As Object, e As EventArgs) Handles btnCalculador.Click
        Response.Redirect("calculadorDisenador.aspx")
    End Sub
End Class