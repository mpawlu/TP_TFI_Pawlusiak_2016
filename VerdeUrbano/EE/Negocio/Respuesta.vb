Namespace EE
    Public Class Respuesta
        Private _PreguntaEncuesta As PreguntaEncuesta
        Public Property PreguntaEncuesta() As PreguntaEncuesta
            Get
                Return _PreguntaEncuesta
            End Get
            Set(ByVal value As PreguntaEncuesta)
                _PreguntaEncuesta = value
            End Set
        End Property

        Private _OpcionElegida As EE.Opcion_PregEnc
        Public Property OpcionElegida() As EE.Opcion_PregEnc
            Get
                Return _OpcionElegida
            End Get
            Set(ByVal value As EE.Opcion_PregEnc)
                _OpcionElegida = value
            End Set
        End Property

    End Class
End Namespace
