Public Class cursosPendientes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If validaciones.validarPagina(Me) = False Then
            Response.Redirect("error.aspx")
        End If
        If Not IsPostBack Then
            CargarGrilla()
        End If

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
        Try
            If validarCheckBox() = True Then
                ''ACA en vez de llamar a evaluacion.aspx tiene que primero hacer el curso. y despues si llama a evaluacion
                Session("CursoAsignado") = Me.Seleccionado
                Response.Redirect("iniciarCurso.aspx")
            Else
                Throw New Servicios.clsExcepcionCamposIncompletos
            End If
        Catch ex As servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Titulo
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try


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


End Class