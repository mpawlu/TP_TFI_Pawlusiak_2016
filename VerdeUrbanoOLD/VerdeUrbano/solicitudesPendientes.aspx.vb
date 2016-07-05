Public Class solicitudesPendientes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarGrilla()
        End If
    End Sub
    Private Function ListarCursosPendientes() As List(Of EE.SolicitudCurso)
        Dim ListaSolPen As New List(Of EE.SolicitudCurso)
        Dim oBLL As New BLL.SolicitudCurso
        Dim _usuSesion As New Servicios.Usuario
        _usuSesion = DirectCast(Session("Usuario"), Servicios.Usuario)
        ListaSolPen = oBLL.ListarSolicitudesPendientes(_usuSesion)
        Return ListaSolPen
    End Function
    Public Sub CargarGrilla()
        Me.gv_solicitudes.DataSource = ListarCursosPendientes()
        Me.gv_solicitudes.DataBind()
    End Sub
    Protected Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Try
            If validarCheckBox() = True Then
                Session("Solicitud") = Me.Seleccionado
                Response.Redirect("crearCurso.aspx")
            Else
                Throw New Servicios.clsExcepcionCamposIncompletos
            End If
        Catch ex As servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub

    Public Function RecuperarUsuario() As Servicios.Usuario
        Dim resultado As New Servicios.Usuario
        resultado = DirectCast(Session("Usuario"), Servicios.Usuario)
        Return resultado
    End Function

    Public Function Seleccionado() As EE.SolicitudCurso
        Dim _usuSesion As New Servicios.Usuario
        _usuSesion = DirectCast(Session("Usuario"), Servicios.Usuario)
        Dim oBLL As New BLL.SolicitudCurso
        Dim indice As Integer
        Dim cont As Integer
        indice = 0
        cont = 0
        For Each row As GridViewRow In gv_solicitudes.Rows
            Dim checkbox As System.Web.UI.WebControls.CheckBox = DirectCast(row.FindControl("chk_sel"), System.Web.UI.WebControls.CheckBox)

            If checkbox.Checked = True Then
                indice = cont
            End If
            cont += 1
        Next
        Dim oca As New EE.SolicitudCurso
        oca = oBLL.ListarSolicitudesPendientes(_usuSesion)(indice)
        Return oca
    End Function


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
End Class