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
                If Me.PreguntaEncuesta.Es_Choice = True Then
                    _OpcionElegida = value
                Else
                    _OpcionElegida = Nothing
                    Valor = value
                End If
            End Set
        End Property

        Private _Valor As Integer
        Public Property Valor() As Integer
            Get
                Return _Valor
            End Get
            Set(ByVal value As Integer)
                _Valor = value
            End Set
        End Property


    End Class
End Namespace
