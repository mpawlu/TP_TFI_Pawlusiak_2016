Public Class solicitudesFinalizadas
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarGrilla()
        End If
    End Sub
    Private Function ListarCursosPendientes() As List(Of EE.SolicitudCurso)
        Dim ListaSolFin As New List(Of EE.SolicitudCurso)
        Dim oBLL As New BLL.SolicitudCurso
        Dim oUsuario As New Servicios.Usuario
        oUsuario = DirectCast(Session("Usuario"), Servicios.Usuario)
        ListaSolFin = oBLL.ListarSolicitudesFinalizadas(oUsuario)
        Return ListaSolFin
    End Function
    Public Sub CargarGrilla()
        Me.gv_solicitudes.DataSource = ListarCursosPendientes()
        Me.gv_solicitudes.DataBind()
    End Sub

End Class