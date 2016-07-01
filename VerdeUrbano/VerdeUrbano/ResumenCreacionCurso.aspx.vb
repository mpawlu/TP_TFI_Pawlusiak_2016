Public Class ResumenCreacionCurso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim oCurso As New EE.Curso
            Dim oCursoBLL As New BLL.Curso
            Dim oSol As New EE.SolicitudCurso
            oSol = DirectCast(Session("Solicitud"), EE.SolicitudCurso)
            oCurso = oCursoBLL.Consultar(oSol)
            Me.lblValorNombre.Text = oCurso.Nombre
            Me.lblValordescripcion.Text = oCurso.Descripcion
            CargarGrilla()
        End If
    End Sub

    Private Sub btnFinalizarCurso_Click(sender As Object, e As EventArgs) Handles btnFinalizarCurso.Click
        Dim oCurso As New EE.Curso
        Dim oCursoBLL As New BLL.Curso
        Dim oSol As New EE.SolicitudCurso
        oSol = DirectCast(Session("Solicitud"), EE.SolicitudCurso)
        oCurso = oCursoBLL.Consultar(oSol)
        oCursoBLL.FinalizarCreacion(oCurso)
        If oCursoBLL.Modificar(oCurso) = True Then
            Dim oSolBLL As New BLL.SolicitudCurso
            If oSolBLL.Modificar(oCurso.SolicitudCurso) = True Then
                Me.correcto.Visible = True
            Else
                Me.error.Visible = True
            End If
        Else
            Me.error.Visible = True
        End If

    End Sub
    Public Sub CargarGrilla()
        Dim oCurso As New EE.Curso
        Dim oCursoBLL As New BLL.Curso
        Dim oSol As New EE.SolicitudCurso
        oSol = DirectCast(Session("Solicitud"), EE.SolicitudCurso)
        oCurso = oCursoBLL.Consultar(oSol)
        Me.gv_Secciones.DataSource = oCurso.Secciones
        Me.gv_Secciones.DataBind()
    End Sub
End Class