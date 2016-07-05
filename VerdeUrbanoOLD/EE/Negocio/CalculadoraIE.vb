Namespace EE
    Public Class CalculadoraIE
        Private _Diseñador As Servicios.Usuario
        Public Property Dieseñador() As Servicios.Usuario
            Get
                Return _Diseñador
            End Get
            Set(ByVal value As Servicios.Usuario)
                _Diseñador = value
            End Set
        End Property
        Private _Cursos As List(Of EE.Curso)
        Public Property Cursos() As List(Of EE.Curso)
            Get
                Return _Cursos
            End Get
            Set(ByVal value As List(Of EE.Curso))
                _Cursos = value
            End Set
        End Property
        Private _Reproducciones As List(Of EE.CursoAsignado)
        Public Property Reproducciones() As List(Of EE.CursoAsignado)
            Get
                Return _Reproducciones
            End Get
            Set(ByVal value As List(Of EE.CursoAsignado))
                _Reproducciones = value
            End Set
        End Property

        Private _IndiceDeSatisfaccion As Double
        Public Property IndiceDeSatisfaccion() As Double
            Get
                Return _IndiceDeSatisfaccion
            End Get
            Set(ByVal value As Double)
                _IndiceDeSatisfaccion = value
            End Set
        End Property

        Sub New()

        End Sub
    End Class
End Namespace

