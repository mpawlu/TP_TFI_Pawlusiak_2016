Public Class cursosPendientes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        CargarGrilla()

    End Sub
    Private Function ListarCursosPendientes() As List(Of EE.CursoAsignado)
        Dim ListaCursosAsignados As New List(Of EE.CursoAsignado)
        Dim oBLL As New BLL.CursoAsignado
        Dim _usuSesion As New Servicios.Usuario
        _usuSesion = DirectCast(Session("Usuario"), Servicios.Usuario)
        ListaCursosAsignados = oBLL.ConsultarCursosPendientes(_usuSesion)
        Return ListaCursosAsignados
    End Function
    Public Sub CargarGrilla()
        Me.gv_cursos.DataSource = ListarCursosPendientes()
        Me.gv_cursos.DataBind()
    End Sub

    Protected Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        Session("CursoAsignado") = Me.Seleccionado
        Response.Redirect("evaluacion.aspx")
    End Sub
    Public Function Seleccionado() As EE.CursoAsignado
        Dim _usuSesion As New Servicios.Usuario
        _usuSesion = DirectCast(Session("Usuario"), Servicios.Usuario)
        Dim oBLL As New BLL.CursoAsignado
        Dim indice As Integer
        Dim cont As Integer
        indice = 0
        cont = 0
        For Each row As GridViewRow In gv_cursos.Rows
            Dim checkbox As System.Web.UI.WebControls.CheckBox = DirectCast(row.FindControl("chk_sel"), System.Web.UI.WebControls.CheckBox)
            cont += 1
            If checkbox.Checked = True Then
                indice = cont
            End If
        Next
        Dim oca As New EE.CursoAsignado
        Return oBLL.ConsultarCursosPendientes(_usuSesion)(indice)
    End Function
End Class