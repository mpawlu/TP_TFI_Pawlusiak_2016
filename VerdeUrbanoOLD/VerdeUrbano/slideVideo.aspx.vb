﻿Public Class slideVideo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            cargarDatosSlide()
        End If
    End Sub

    Private Sub cargarDatosSlide()
        Dim oSlide As EE.TipoC = DirectCast(Session("SlideSeleccion"), EE.TipoC)
        Me.lblTitulo.Text = oSlide.Titulo
        If oSlide.Subtitulo <> "" Then
            Me.subtitulo.visible = True
            Me.lblSubTitulo.Text = oSlide.Subtitulo
        End If
        Me.videoMaterial.Src = "http://www.youtube.com/embed/" & oSlide.Video
        If esUltimoSlide() = True And esUltimaSeccion() = True Then
            Me.siguiente.Visible = False
            Me.final.Visible = True
        Else
            Me.siguiente.Visible = True
            Me.final.Visible = False
        End If
    End Sub


    Private Function esUltimoSlide() As Boolean
        Dim oSeccion As EE.Informativa = DirectCast(Session("SeccionSeleccion"), EE.Informativa)
        Dim ultimoSlide As Integer = CInt(Session("UltimoSlideValor"))
        If oSeccion.Slides.Count - 1 = ultimoSlide Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function esUltimaSeccion() As Boolean
        Dim _flag As Boolean = False
        Dim oCursoAs As New EE.CursoAsignado
        oCursoAs = DirectCast(Session("CursoAsignado"), EE.CursoAsignado)
        Dim ultimoSeccion As Integer = CInt(Session("UltimaSeccionValor"))
        If (oCursoAs.Curso.Secciones.Count - 1 = ultimoSeccion) Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Function obtenerProximoSlide() As EE.Slide
        If esUltimoSlide() = False Then
            Dim _NumproximoSlide As Integer = CInt(Session("UltimoSlideValor")) + 1
            Dim oCursoAs As New EE.CursoAsignado
            oCursoAs = DirectCast(Session("CursoAsignado"), EE.CursoAsignado)
            Dim _seccion As EE.Informativa = oCursoAs.Curso.Secciones.Item(CInt(Session("UltimaSeccionValor")))
            Dim _proximoSlide As EE.Slide = _seccion.Slides.Item(_NumproximoSlide)
            Session("UltimoSlideValor") = _NumproximoSlide
            Session("SlideSeleccion") = _proximoSlide
            If _proximoSlide.Tipo = "A" Then
                Response.Redirect("slideTexto.aspx")
            End If
            If _proximoSlide.Tipo = "B" Then
                Response.Redirect("slideImagen.aspx")
            End If
            If _proximoSlide.Tipo = "C" Then
                Response.Redirect("slideVideo.aspx")
            End If
        Else
            Dim _numproxSeccion As Integer = CInt(Session("UltimaSeccionValor")) + 1
            Dim oCursoAs As New EE.CursoAsignado
            oCursoAs = DirectCast(Session("CursoAsignado"), EE.CursoAsignado)
            Dim _seccion As EE.Informativa = oCursoAs.Curso.Secciones.Item(_numproxSeccion)
            Session("UltimaSeccionValor") = _numproxSeccion
            Session("SeccionSeleccion") = _seccion
            If _seccion.Slides.Count > 0 Then
                Session("UltimoSlideValor") = 0
                Dim oSlide As EE.Slide
                oSlide = _seccion.Slides.Item(CInt(Session("UltimoSlideValor")))
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
    End Function

    Protected Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        obtenerProximoSlide()
    End Sub
End Class