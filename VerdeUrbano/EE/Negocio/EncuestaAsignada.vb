Namespace EE
    Public Class EncuestaAsignada
        Private _Encuesta As Encuesta
        Public Property Encuesta() As Encuesta
            Get
                Return _Encuesta
            End Get
            Set(ByVal value As Encuesta)
                _Encuesta = value
            End Set
        End Property

        Private _Empleado As EE.clsUsuario
        Public Property Empleado() As EE.clsUsuario
            Get
                Return _Empleado
            End Get
            Set(ByVal value As EE.clsUsuario)
                _Empleado = value
            End Set
        End Property

        Private _Respuestas As New List(Of Respuesta)
        Public Property Respuestas() As List(Of Respuesta)
            Get
                Return _Respuestas
            End Get
            Set(ByVal value As List(Of Respuesta))
                _Respuestas = value
            End Set
        End Property
        Private _Utilidad As Double
        Public Property Utilidad() As Double
            Get
                Return _Utilidad
            End Get
            Set(ByVal value As Double)
                _Utilidad = value
            End Set
        End Property
        Private _Dificultad As Double
        Public Property Dificultad() As Double
            Get
                Return _Dificultad
            End Get
            Set(ByVal value As Double)
                _Dificultad = value
            End Set
        End Property

    End Class


End Namespace
