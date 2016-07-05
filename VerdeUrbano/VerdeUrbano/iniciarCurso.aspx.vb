Public Class iniciarCurso
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If validaciones.validarPagina(Me) = False Then
        '    Response.Redirect("error.aspx")
        '  End If
        If Not IsPostBack Then
            Response.Redirect("encuestaSatisfaccion.aspx")
            Dim oCursoAs As New EE.CursoAsignado
            oCursoAs = DirectCast(Session("CursoAsignado"), EE.CursoAsignado)
            Me.lblValorNombre.Text = oCursoAs.Curso.Nombre
            Me.descripcion.Text = oCursoAs.Curso.Descripcion
            Me.lblValorDuracion.Text = oCursoAs.Curso.Duracion
            CargarGrilla()
        End If
    End Sub
    Public Sub CargarGrilla()
        Try
            Dim oCursoAs As New EE.CursoAsignado
            oCursoAs = DirectCast(Session("CursoAsignado"), EE.CursoAsignado)
            Dim oCurso As New EE.Curso
            oCurso = oCursoAs.Curso
            Me.gv_Secciones.DataSource = oCurso.Secciones
            Me.gv_Secciones.DataBind()
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub btnComenzar_Click(sender As Object, e As EventArgs) Handles btnComenzar.Click
        Try
            Dim oCursoAs As New EE.CursoAsignado
            oCursoAs = DirectCast(Session("CursoAsignado"), EE.CursoAsignado)
            If oCursoAs.Curso.Secciones.Count > 0 Then
                Session("UltimaSeccionValor") = 0
                Dim oSeccion As EE.Informativa
                oSeccion = oCursoAs.Curso.Secciones.Item(CInt(Session("UltimaSeccionValor")))
                Session("SeccionSeleccion") = oSeccion
                If oSeccion.Slides.Count > 0 Then
                    Session("UltimoSlideValor") = 0
                    Dim oSlide As EE.Slide
                    oSlide = oSeccion.Slides.Item(CInt(Session("UltimoSlideValor")))
                    Session("SlideSeleccion") = oSlide
                    If oSlide.Tipo = "A" Then
                        Response.Redirect("slideTexto.aspx")
                    End If
                    If oSlide.Tipo = "B" Then
                        Response.Redirect("slideImagen.aspx")
                    End If
                    If oSlide.Tipo = "C" Then
                        Response.Redirect("slideVideo.aspx")
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class