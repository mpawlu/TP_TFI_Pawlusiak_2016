Namespace BLL
    Public Class Seccion
        Public Function GuardarSeccion(ByVal QueSeccion As EE.Informativa, ByVal QueCurso As EE.Curso) As Boolean
            Dim oMPP As New MPP.Seccion
            Return oMPP.Guardar(QueSeccion, QueCurso)
        End Function

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
End Namespace


