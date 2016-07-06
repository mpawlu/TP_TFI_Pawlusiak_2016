Public Class agregarSolicitudCurso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If validaciones.validarPagina(Me) = False Then
            Response.Redirect("error.aspx")
        End If
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
        Try
            If validarCheckBox() = True Then
                Dim oDisenador As New Servicios.Usuario
                Dim oSolicitante As New Servicios.Usuario
                Dim oSolicitud As New EE.SolicitudCurso
                Dim oEstadoSolicitud As New EE.Solicitado
                Dim oCurso As New EE.Curso
                Dim oEstadoCurso As New EE.EnCreacion
                Dim oUsuBLL As New BLL.clsUsuario
                Dim oCategoria As New EE.Categoria
                Dim oSolicitudBLL As New BLL.SolicitudCurso
                Dim oCursoBLL As New BLL.Curso
                oCategoria.ID = ddlCategoria.SelectedValue
                oCategoria.Descripcion = Me.ddlCategoria.SelectedItem.Text
                oSolicitante = CType(Session("Usuario"), Servicios.Usuario)
                oDisenador.ID = CInt(Me.DisenadorSeleccionado)
                oDisenador = oUsuBLL.RecuperarUsuario(oDisenador)
                oSolicitud.Disenador = oDisenador
                oSolicitud.Solicitante = oSolicitante
                oCurso.Estado = oEstadoCurso
                oCurso.Categoria = oCategoria
                oSolicitud.Titulo = Me.txtTitulo.Text
                oSolicitud.Detalle = Me.txtDetalle.Text
                oSolicitud.FechaLimiteDeCreacion = CDate(txtFechaVencimiento.Text)
                oSolicitud.FechaSolicitud = Today
                oSolicitud.Estado = oEstadoSolicitud
                If oSolicitudBLL.Guardar(oSolicitud) = True Then
                    oCurso.SolicitudCurso = oSolicitudBLL.ConsultarUltima
                    If oCursoBLL.Guardar(oCurso) = True Then
                        Me.correcto.Visible = True
                    Else
                        Throw New Servicios.clsExcepcionErrorBBDD
                    End If
                Else
                    Throw New Servicios.clsExcepcionErrorBBDD
                End If
            Else
                Throw New Servicios.clsExcepcionCamposIncompletos
            End If
        Catch ex As servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Servicios.clsExcepcionErrorBBDD
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub
    Protected Sub btnCalculador_Click(sender As Object, e As EventArgs) Handles btnCalculador.Click
        Try
            Dim _bllUsuario As New BLL.clsUsuario
            Dim _listaUsuarios As New List(Of Servicios.Usuario)
            _listaUsuarios = _bllUsuario.ObtenerDisenadores
            Dim oCategoria As New EE.Categoria
            oCategoria.ID = ddlCategoria.SelectedValue
            oCategoria.Descripcion = Me.ddlCategoria.SelectedItem.Text
            Dim oNuevaSolicitud As New EE.SolicitudCurso
            Dim oNuevoCurso As New EE.Curso
            oNuevaSolicitud.FechaLimiteDeCreacion = CDate(txtFechaVencimiento.Text)
            oNuevaSolicitud.Titulo = txtTitulo.Text
            oNuevaSolicitud.Detalle = txtDetalle.Text
            oNuevoCurso.SolicitudCurso = oNuevaSolicitud
            oNuevoCurso.Categoria = oCategoria
            Session("indice") = ddlCategoria.SelectedIndex
            Session("curso") = oNuevoCurso
            Dim ie As New BLL.CalculadoraIE
            Dim oRank As New List(Of EE.CalculadoraIE)
            oRank = ie.RankearDiseñadores(_listaUsuarios, oCategoria)
            If oRank.Count < 1 Then
                Throw New Servicios.clsExcepcionSinRanking
            Else
                Session("Ranking") = ie.RankearDiseñadores(_listaUsuarios, oCategoria)
                Response.Redirect("calculadorDisenador.aspx")
            End If

        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Servicios.clsExcepcionSinRanking
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try

    End Sub

    Private Function validarCheckBox() As Boolean
        Dim _flag As Boolean = False
        Dim _cant As Integer = 0
        For Each row As GridViewRow In Me.gv_Profesores.Rows
            Dim checkbox As System.Web.UI.WebControls.CheckBox = DirectCast(row.FindControl("chk_sel"), System.Web.UI.WebControls.CheckBox)
            If checkbox.Checked = True Then
                _flag = True
                _cant += 1
            End If
            If _cant > 1 Then
                Return False
            End If
        Next
        Return _flag
    End Function
    Public Function DisenadorSeleccionado() As Integer
        For Each row As GridViewRow In Me.gv_Profesores.Rows
            Dim checkbox As System.Web.UI.WebControls.CheckBox = DirectCast(row.FindControl("cb_Profesores"), System.Web.UI.WebControls.CheckBox)
            If checkbox.Checked = True Then
                Return gv_Profesores.Rows(row.DataItemIndex).Cells(0).Text
            End If
        Next
    End Function

    Public Function RecuperarUsuario() As Servicios.Usuario
        Dim resultado As New Servicios.Usuario
        resultado = DirectCast(Session("Usuario"), Servicios.Usuario)
        Return resultado
    End Function
End Class