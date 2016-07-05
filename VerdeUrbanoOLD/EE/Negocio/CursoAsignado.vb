Namespace EE
    Public Class CursoAsignado
        Private _Empleado As Servicios.Usuario
        Public Property Empleado() As Servicios.Usuario
            Get
                Return _Empleado
            End Get
            Set(ByVal value As Servicios.Usuario)
                _Empleado = value
            End Set
        End Property


        Private _Curso As Curso
        Public Property Curso() As Curso
            Get
                Return _Curso
            End Get
            Set(ByVal value As Curso)
                _Curso = value
            End Set
        End Property


        Private _Estado As CursoAsignado_State
        Public Property Estado() As CursoAsignado_State
            Get
                Return _Estado
            End Get
            Set(ByVal value As CursoAsignado_State)
                _Estado = value
            End Set
        End Property

        Private _FechaAsignacion As Date
        Public Property FechaAsignacion() As Date
            Get
                Return _FechaAsignacion
            End Get
            Set(ByVal value As Date)
                _FechaAsignacion = value
            End Set
        End Property


        Private _FechaVencimiento As Date
        Public Property FechaVencimiento() As Date
            Get
                Return _FechaVencimiento
            End Get
            Set(ByVal value As Date)
                _FechaVencimiento = value
            End Set
        End Property

        Private _progreso As Integer
        Public Property Progreso() As Integer
            Get
                Return _progreso
            End Get
            Set(ByVal value As Integer)
                _progreso = value
            End Set
        End Property

        Private _Intentos As Integer
        Public Property Intentos() As Integer
            Get
                Return _Intentos
            End Get
            Set(ByVal value As Integer)
                _Intentos = value
            End Set
        End Property


        Private _respuestas As New List(Of EE.Respuesta_Curso)

        Public Property Respuestas() As List(Of EE.Respuesta_Curso)
            Get
                Return _respuestas
            End Get
            Set(ByVal value As List(Of EE.Respuesta_Curso))
                _respuestas = value
            End Set
        End Property

        Private _ResultadoObtenido As Double
        Public Property ResultadoObtenido() As Double
            Get
                Return _ResultadoObtenido
            End Get
            Set(ByVal value As Double)
                _ResultadoObtenido = value
            End Set
        End Property

        Private _aprobado As Boolean
        Public Property Aprobado() As Boolean
            Get
                Return _aprobado
            End Get
            Set(ByVal value As Boolean)
                _aprobado = value
            End Set
        End Property

        Private _EncuestaAsignada As EE.EncuestaAsignada
        Public Property EncuestaAsignada() As EE.EncuestaAsignada
            Get
                Return _EncuestaAsignada
            End Get
            Set(ByVal value As EE.EncuestaAsignada)
                _EncuestaAsignada = value
            End Set
        End Property
        Sub New(ByVal QueEmpleado As Servicios.Usuario, ByVal QueCurso As EE.Curso)

        End Sub
        Sub New()

        End Sub

    End Class
End Namespace