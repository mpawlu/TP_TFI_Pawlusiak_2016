Public Class solicitudesFinalizadas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.ocultarDivs()
        If validaciones.validarPagina(Me) = False Then
            Response.Redirect("error.aspx")
        End If
        If Not IsPostBack Then
            Dim oUsu As New Servicios.Usuario
            oUsu = RecuperarUsuario()
            If oUsu.Perfil.ID = 30 Then
                CargarGrillaDirector()
            Else
                Me.btnAprobar.Visible = False
                Me.CargarGrillaDisenador()
            End If
        End If
    End Sub
    Private Function ListarCursosPendientesDeAprobacion() As List(Of EE.SolicitudCurso)
        Dim ListaSolFin As New List(Of EE.SolicitudCurso)
        Dim oBLL As New BLL.SolicitudCurso
        Dim oUsuario As New Servicios.Usuario
        oUsuario = DirectCast(Session("Usuario"), Servicios.Usuario)
        ListaSolFin = oBLL.ListarSolicitudesFinalizadas(oUsuario)
        Return ListaSolFin
    End Function
    Private Function ListarSolicitudesFinalizadas() As List(Of EE.SolicitudCurso)
        Dim ListaSolFin As New List(Of EE.SolicitudCurso)
        Dim oBLL As New BLL.SolicitudCurso
        Dim oUsuario As New Servicios.Usuario
        oUsuario = DirectCast(Session("Usuario"), Servicios.Usuario)
        ListaSolFin = oBLL.ListarMisFinalizadas(oUsuario)
        Return ListaSolFin
    End Function
    Public Sub CargarGrillaDirector()
        Me.gv_solicitudes.DataSource = ListarCursosPendientesDeAprobacion()
        Me.gv_solicitudes.DataBind()
    End Sub
    Public Sub CargarGrillaDisenador()
        Me.gv_solicitudes_dis.DataSource = ListarSolicitudesFinalizadas()
        Me.gv_solicitudes_dis.DataBind()
    End Sub

    Private Sub btnAprobar_Click(sender As Object, e As EventArgs) Handles btnAprobar.Click
        Try
            If validarCheckBox() = True Then
                Dim oSolicitud As New EE.SolicitudCurso
                oSolicitud = Me.Seleccionado
                Dim oSolBLL As New BLL.SolicitudCurso
                If oSolBLL.AprobarCurso(oSolicitud) = True Then
                    Me.correcto.Visible = True
                    Me.limpiarGrilla()
                    Me.CargarGrillaDirector()
                Else
                    Throw New Servicios.clsExcepcionErrorBBDD
                End If
            Else
                Throw New Servicios.clsExcepcionCamposIncompletos
            End If

        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Servicios.clsExcepcionErrorBBDD
            Me.error.Visible = True
            lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Exception

        End Try
    End Sub
    Private Function validarCheckBox() As Boolean
        Dim _flag As Boolean = False
        For Each row As GridViewRow In Me.gv_solicitudes.Rows
            Dim checkbox As System.Web.UI.WebControls.CheckBox = DirectCast(row.FindControl("chk_sel"), System.Web.UI.WebControls.CheckBox)
            If checkbox.Checked = True Then
                Return True
            End If
        Next
        Return _flag
    End Function
    Public Function Seleccionado() As EE.SolicitudCurso
        Dim indice As Integer
        Dim cont As Integer
        indice = 0
        cont = 0
        For Each row As GridViewRow In gv_solicitudes.Rows
            Dim checkbox As System.Web.UI.WebControls.CheckBox = DirectCast(row.FindControl("chk_sel"), System.Web.UI.WebControls.CheckBox)
            cont += 1
            If checkbox.Checked = True Then
                indice = cont
            End If
        Next
        Dim oca As New EE.CursoAsignado
        Return Me.ListarCursosPendientesDeAprobacion()(indice - 1)
    End Function
    Public Sub limpiarGrilla()
        Me.gv_solicitudes.DataSource = Nothing
        Me.gv_solicitudes.DataBind()
    End Sub
    Public Function RecuperarUsuario() As Servicios.Usuario
        Dim resultado As New Servicios.Usuario
        resultado = DirectCast(Session("Usuario"), Servicios.Usuario)
        Return resultado
    End Function

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Response.Redirect("Index.aspx")
    End Sub
    Public Sub ocultarDivs()
        Me.correcto.Visible = False
        Me.error.Visible = False
    End Sub
End Class