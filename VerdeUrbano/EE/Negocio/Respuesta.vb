Namespace EE
    Public Class Respuesta

        Enum etipoRespuesta
            Excelente = 0
            Bueno = 1
            Regular = 2
            Malo = 3
            Pesimo = 4
        End Enum

        Private _PreguntaEncuesta As PreguntaEncuesta
        Public Property PreguntaEncuesta() As PreguntaEncuesta
            Get
                Return _PreguntaEncuesta
            End Get
            Set(ByVal value As PreguntaEncuesta)
                _PreguntaEncuesta = value
            End Set
        End Property

        Private _OpcionElegida As etipoRespuesta
        Public Property OpcionElegida() As etipoRespuesta
            Get
                Return _OpcionElegida
            End Get
            Set(ByVal value As etipoRespuesta)
                _OpcionElegida = value
            End Set
        End Property

    End Class
End Namespace
