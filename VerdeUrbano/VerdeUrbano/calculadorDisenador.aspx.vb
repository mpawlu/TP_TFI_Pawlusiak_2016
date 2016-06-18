Public Class calculadorDisenador
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            obtenerCategorias()

            Dim oRanking As New List(Of EE.CalculadoraIE)
            Dim oCat As New EE.Categoria
            oCat.ID = 2
            Dim _bllUsuario As New BLL.clsUsuario
            Dim _listaUsuarios As New List(Of Servicios.Usuario)
            _listaUsuarios = _bllUsuario.ObtenerDisenadores
            Dim ie As New BLL.CalculadoraIE
            oRanking = ie.RankearDiseñadores(_listaUsuarios, oCat)
            mostrarTop5(oRanking)
            setearDatos()
        End If

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
    Public Sub setearDatos()
        Dim oCurso As New EE.Curso
        oCurso = Session("curso")
        Me.ddlCategoria.SelectedIndex = CType(Session("indice"), Integer)
        Me.txtDetalle.Text = oCurso.SolicitudCurso.Detalle
        Me.txtTitulo.Text = oCurso.SolicitudCurso.Titulo
        Me.txtFechaCreacion.Text = CStr(oCurso.SolicitudCurso.FechaLimiteDeCreacion)
        Me.ddlCategoria.Enabled = False
    End Sub

    Private Sub btn_Seleccionar1_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar1.Click
        Try
            Dim oDisenador As New Servicios.Usuario
            Dim oSolicitante As New Servicios.Usuario
            Dim oSolicitud As New EE.SolicitudCurso
            Dim oEstadoSolicitud As New EE.EnConstruccion
            Dim oCurso As New EE.Curso
            Dim oEstadoCurso As New EE.EnCreacion
            Dim oUsuBLL As New BLL.clsUsuario
            Dim oSolicitudBLL As New BLL.SolicitudCurso
            Dim oCursoBLL As New BLL.Curso
            oSolicitante = CType(Session("Usuario"), Servicios.Usuario)
            ''oDisenador.ID = aca tengo que poner el ID del disenador que selecciono
            oDisenador.ID = 11  ''Y comentar esta linea
            oDisenador = oUsuBLL.RecuperarUsuario(oDisenador)
            oCurso = CType(Session("curso"), EE.Curso)
            oCurso.SolicitudCurso.Disenador = oDisenador
            oCurso.SolicitudCurso.Solicitante = oSolicitante
            oCurso.Estado = oEstadoCurso
            oCurso.SolicitudCurso.Titulo = Me.txtTitulo.Text
            oCurso.SolicitudCurso.Detalle = Me.txtDetalle.Text
            oCurso.SolicitudCurso.FechaLimiteDeCreacion = CDate(Me.txtFechaCreacion.Text)
            oCurso.SolicitudCurso.FechaSolicitud = Today
            oCurso.SolicitudCurso.Estado = oEstadoSolicitud
            If oSolicitudBLL.Guardar(oCurso.SolicitudCurso) = True Then
                oCurso.SolicitudCurso = oSolicitudBLL.ConsultarUltima
                If oCursoBLL.Guardar(oCurso) = True Then
                    ''Operacion exitossa
                    Me.correcto.Visible = True
                Else
                    Throw New Servicios.clsExcepcionErrorBBDD
                End If
            Else
                Throw New Servicios.clsExcepcionErrorBBDD
            End If
        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Titulo
        Catch ex As Servicios.clsExcepcionErrorBBDD
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Titulo
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try

    End Sub

    Private Sub btn_Seleccionar2_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar2.Click
        Try
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
        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Titulo
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try

    End Sub

    Private Sub btn_Seleccionar3_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar3.Click
        Try
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
        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Titulo
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try

    End Sub

    Private Sub btn_Seleccionar4_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar4.Click
        Try
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
        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Titulo
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try

    End Sub

    Private Sub btn_Seleccionar5_Click(sender As Object, e As EventArgs) Handles btn_Seleccionar5.Click
        Try
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
        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Titulo
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try

    End Sub



    Private Sub mostrarTop5(ByVal paramRanking As List(Of EE.CalculadoraIE))
        Dim _contador As Integer = 1
        For Each _ranking As EE.CalculadoraIE In paramRanking
            If _contador <= 5 Then
                Dim lbl_NombreDisenador As Label = calculadorEA.FindControl("lbl_NombreDisenador" & _contador)
                Dim lbl_CantidadCursosRealizado As Label = calculadorEA.FindControl("lbl_CantidadCursosRealizado" & _contador)
                Dim lbl_DetalleUltimoCurso As Label = calculadorEA.FindControl("lbl_DetalleUltimoCurso" & _contador)
                Dim lbl_rating As Label = calculadorEA.FindControl("lbl_rating" & _contador)
                lbl_NombreDisenador.Text = _ranking.Dieseñador.NombreUsuario
                lbl_CantidadCursosRealizado.Text = _ranking.Cursos.Count.ToString
                lbl_DetalleUltimoCurso.Text = _ranking.Reproducciones(_ranking.Reproducciones.Count - 1).Curso.Nombre
                lbl_rating.Text = _ranking.IndiceDeSatisfaccion.ToString
                Dim _divTop As HtmlControl = calculadorEA.FindControl("top" & _contador)
                _divTop.Visible = True
                _contador = _contador + 1
            Else
                Exit For
            End If
        Next
    End Sub

End Class