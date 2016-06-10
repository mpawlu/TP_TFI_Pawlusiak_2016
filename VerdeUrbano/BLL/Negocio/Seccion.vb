Public Class Seccion
    Public Sub GuardarSeccion(ByVal QueSeccion As EE.Informativa)

    End Sub

    Public Sub AgregarSlide(ByVal QueSeccion As EE.Informativa, ByVal QueSlide As EE.Slide)
        QueSeccion.Slides.Add(QueSlide)
    End Sub
    Public Function ConsultarSeccion(ByVal QueSeccion As EE.Informativa) As EE.Informativa

    End Function
    Public Function ConsultarSlide(ByVal QueSeccion As EE.Informativa, ByVal QueSlide As Integer) As EE.Slide

    End Function
    Public Function MostrarSiguienteSlide() As EE.Slide
    End Function
    Public Function MostrarSlideAnterior() As EE.Slide
    End Function
End Class
