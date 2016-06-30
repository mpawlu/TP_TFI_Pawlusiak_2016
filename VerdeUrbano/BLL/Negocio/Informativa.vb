Namespace BLL
    Public Class Informativa
        Public Function GuardarSeccion(ByVal QueSeccion As EE.Informativa, ByVal QueCurso As EE.Curso) As Boolean
            Dim oMPP As New MPP.Seccion
            Return oMPP.Guardar(QueSeccion, QueCurso)
        End Function

        Public Function AgregarSlide(ByVal QueSeccion As EE.Informativa, ByVal QueSlide As EE.Slide) As Boolean
            Dim oMPP As New MPP.Slide
                Return oMPP.Guardar(QueSlide, QueSeccion)
        End Function
        Public Function ConsultarUltima() As EE.Informativa
            Dim oMPP As New MPP.Seccion
            Return oMPP.ConsultarUltima
        End Function
        Public Function ConsultarSlide(ByVal QueSeccion As EE.Informativa, ByVal QueSlide As Integer) As EE.Slide

        End Function
        Public Function MostrarSiguienteSlide() As EE.Slide
        End Function
        Public Function MostrarSlideAnterior() As EE.Slide
        End Function
        Public Function ConsultarSeccion(ByVal QueSeccion As EE.Informativa) As EE.Informativa
            Dim oMPP As New MPP.Seccion
            Return oMPP.Consultar(QueSeccion)
        End Function



    End Class
End Namespace

