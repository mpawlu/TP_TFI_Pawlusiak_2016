Public Class iniciarCurso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim oCursoAs As New EE.CursoAsignado
            oCursoAs = DirectCast(Session("CursoAsignado"), EE.CursoAsignado)
            Me.lblValorNombre.Text = oCursoAs.Curso.Nombre
            Me.lblValordescripcion.Text = oCursoAs.Curso.Descripcion
            Me.lblValorDuracion.Text = oCursoAs.Curso.Duracion
            CargarGrilla()
        End If
    End Sub
    Public Sub CargarGrilla()
        Dim oCursoAs As New EE.CursoAsignado
        oCursoAs = DirectCast(Session("CursoAsignado"), EE.CursoAsignado)
        Dim oCurso As New EE.Curso
        oCurso = oCursoAs.Curso
        Me.gv_Secciones.DataSource = oCurso.Secciones
        Me.gv_Secciones.DataBind()
    End Sub
End Class