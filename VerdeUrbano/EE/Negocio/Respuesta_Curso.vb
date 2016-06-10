Namespace EE
    Public Class Respuesta_Curso
        Private _Pregunta As EE.Pregunta
        Public Property Pregunta() As EE.Pregunta
            Get
                Return _Pregunta
            End Get
            Set(ByVal value As EE.Pregunta)
                _Pregunta = value
            End Set
        End Property
        Private _OpcionElegida As EE.Opcion_PregCurso
        Public Property OpcionElegida() As EE.Opcion_PregCurso
            Get
                Return _OpcionElegida
            End Get
            Set(ByVal value As EE.Opcion_PregCurso)
                _OpcionElegida = value
            End Set
        End Property

    End Class
End Namespace