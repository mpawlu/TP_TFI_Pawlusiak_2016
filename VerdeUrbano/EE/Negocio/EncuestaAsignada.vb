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

        Private _Empleado As Servicios.Usuario
        Public Property Empleado() As Servicios.Usuario
            Get
                Return _Empleado
            End Get
            Set(ByVal value As Servicios.Usuario)
                _Empleado = value
            End Set
        End Property

        Private _Respuestas As List(Of EE.Respuesta)
        Public Property Respuestas() As List(Of EE.Respuesta)
            Get
                Return _Respuestas
            End Get
            Set(ByVal value As List(Of EE.Respuesta))
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
        Private _Estado As EE.EncuestaAsignada_State
        Public Property Estado() As EE.EncuestaAsignada_State
            Get
                Return _Estado
            End Get
            Set(ByVal value As EE.EncuestaAsignada_State)
                _Estado = value
            End Set
        End Property

    End Class


End Namespace
