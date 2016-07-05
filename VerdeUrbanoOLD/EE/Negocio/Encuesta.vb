Namespace EE
    Public Class Encuesta
        Private _Curso As Curso
        Public Property Curso() As Curso
            Get
                Return _Curso
            End Get
            Set(ByVal value As Curso)
                _Curso = value
            End Set
        End Property

        Private _Preguntas As List(Of PreguntaEncuesta)
        Public Property Preguntas() As List(Of PreguntaEncuesta)
            Get
                Return _Preguntas
            End Get
            Set(ByVal value As List(Of PreguntaEncuesta))
                _Preguntas = value
            End Set
        End Property
    End Class
End Namespace

