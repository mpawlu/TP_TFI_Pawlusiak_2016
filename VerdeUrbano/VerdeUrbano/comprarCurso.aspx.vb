Public Class comprarCurso
    Inherits System.Web.UI.Page
    Protected mensajeConfirmacion As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            CargarDDL()
            CargarGrilla()
            mensajeConfirmacion = "¿Desea Adquirir el Producto?"
        End If
    End Sub
    Public Sub CargarDDL()

        For i As Integer = 1 To 20
            Me.ddl_lic.Items.Add(i.ToString)
        Next
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
        Return oBLL.ConsultarCursosPendientes(_usuSesion)(indice - 1)
    End Function
    Private Function ListarCursos() As List(Of EE.Curso)
        Dim ListaCursos As New List(Of EE.Curso)
        Dim oBLL As New BLL.Curso
        ListaCursos = oBLL.ListarCursos
        Return ListaCursos
    End Function
    Public Sub CargarGrilla()
        Me.gv_cursos.DataSource = ListarCursos()
        Me.gv_cursos.DataBind()
    End Sub

    Private Function validarCheckBox() As Boolean
        Dim _flag As Boolean = False
        For Each row As GridViewRow In Me.gv_cursos.Rows
            Dim checkbox As System.Web.UI.WebControls.CheckBox = DirectCast(row.FindControl("chk_sel"), System.Web.UI.WebControls.CheckBox)
            If checkbox.Checked = True Then
                Return True
            End If
        Next
        Return _flag
    End Function

    Protected Sub btnComprar_Click(sender As Object, e As EventArgs) Handles btnComprar.Click
        Try
            Me.correcto.Visible = True
            Me.formulario.Visible = False
        Catch ex As Exception

        End Try
    End Sub
End Class