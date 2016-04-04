Namespace EE
    Public Class Resultado
        Private _CursoRealizado As CursoAsignado
        Public Property CursoRealizado() As CursoAsignado
            Get
                Return _CursoRealizado
            End Get
            Set(ByVal value As CursoAsignado)
                _CursoRealizado = value
            End Set
        End Property


        Private _RespuestasCorrectas As Integer
        Public Property RespuestasCorrectas() As Integer
            Get
                Return _RespuestasCorrectas
            End Get
            Set(ByVal value As Integer)
                _RespuestasCorrectas = value
            End Set
        End Property
        Private _RespuestasIncorrectas As Integer
        Public Property RespuestasIncorrectas() As Integer
            Get
                Return _RespuestasIncorrectas
            End Get
            Set(ByVal value As Integer)
                _RespuestasIncorrectas = value
            End Set
        End Property

        Private _Tiempl As Double
        Public Property Tiempo() As Double
            Get
                Return _Tiempl
            End Get
            Set(ByVal value As Double)
                _Tiempl = value
            End Set
        End Property

        Private _Puntaje As Double
        Public Property Puntaje() As Double
            Get
                Return _Puntaje
            End Get
            Set(ByVal value As Double)
                _Puntaje = value
            End Set
        End Property
    End Class
End Namespace

