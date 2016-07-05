Public Class agregarSeccion
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If validaciones.validarPagina(Me) = False Then
            '    Response.Redirect("error.aspx")
        End If
        If Not IsPostBack Then
            Dim oCurso As New EE.Curso
            oCurso = DirectCast(Session("Curso"), EE.Curso)
            Me.lbl_nombreCurso.Text = oCurso.Nombre
        End If
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnAgregarSlide.Click
        Try
            validaciones.validarSubmit(Me, Me.error, Me.lbl_TituloError)
            Dim oCurso As New EE.Curso
            Dim oCursoBLL As New BLL.Curso
            oCurso = DirectCast(Session("Curso"), EE.Curso)
            Dim oSeccion As New EE.Informativa(Me.txtTitulo.Text, Me.txtDescripcion.Text)
            Dim oSecBLL As New BLL.Informativa
            If oCursoBLL.AgregarSeccion(oCurso, oSeccion) = True Then
                Dim oSec As New EE.Informativa
                oSec = oSecBLL.ConsultarUltima
                Session("Seccion") = oSec
                'Me.correcto.Visible = True
                Response.Redirect("agregarSlide.aspx")
            End If
        Catch ex As Servicios.clsExcepcionCamposIncompletos
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
End Class