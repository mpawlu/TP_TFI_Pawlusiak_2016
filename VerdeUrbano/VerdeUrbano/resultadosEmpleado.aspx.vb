Public Class resultadosEmpleado
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ocultarDivs()
        If Not IsPostBack Then
            CargarGrilla()
        End If
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Response.Redirect("Index.aspx")
    End Sub
    Public Sub ocultarDivs()
        Me.correcto.Visible = False
        Me.error.Visible = False
    End Sub
    Public Sub CargarGrilla()
        Dim oListaResultados As New List(Of EE.CursoAsignado)
        Dim oCursoAd As New BLL.CursoAsignado
        Dim oUsu As New Servicios.Usuario
        oUsu = DirectCast(Session("Seleccionado"), Servicios.Usuario)
        Dim oPersBLL As New BLL.Persona
        Me.gv_cursoAsignado.DataSource = oCursoAd.ConsultarCursosRealizados(oPersBLL.Consultar(oUsu.DNI))
        Me.gv_cursoAsignado.DataBind()
        For Each elemento As GridViewRow In gv_cursoAsignado.Rows
            If elemento.Cells(4).Text = "True" Then
                elemento.Cells(4).Text = "Aprobado"
                elemento.BackColor = Drawing.Color.LightGreen
            Else
                elemento.Cells(4).Text = "Desaprobado"
                elemento.BackColor = Drawing.Color.IndianRed
            End If
        Next
    End Sub
    Public Function RecuperarUsuario() As Servicios.Usuario
        Dim resultado As New Servicios.Usuario
        resultado = DirectCast(Session("Usuario"), Servicios.Usuario)
        Return resultado
    End Function

End Class