Namespace EE
    Public Class CalculadoraIE
        Private _Diseñadores As List(Of Servicios.Usuario)
        Public Property Dieseñadores() As List(Of Servicios.Usuario)
            Get
                Return _Diseñadores
            End Get
            Set(ByVal value As List(Of Servicios.Usuario))
                _Diseñadores = value
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

        Private _Resultados As List(Of EE.ResultadoIE)
        Public Property Resultados() As List(Of EE.ResultadoIE)
            Get
                Return _Resultados
            End Get
            Set(ByVal value As List(Of EE.ResultadoIE))
                _Resultados = value
            End Set
        End Property


        Sub New()

        End Sub
    End Class
End Namespace

