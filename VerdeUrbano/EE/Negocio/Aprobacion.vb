
Namespace EE
    Public Class Aprobacion
        Private _curso As EE.Curso
        Public Property Curso() As EE.Curso
            Get
                Return _curso
            End Get
            Set(ByVal value As EE.Curso)
                _curso = value
            End Set
        End Property


        Private _Aprobador As Servicios.Usuario
        Public Property Aprobador() As Servicios.Usuario
            Get
                Return _Aprobador
            End Get
            Set(ByVal value As Servicios.Usuario)
                _Aprobador = value
            End Set
        End Property


        Private _FechaAp As Date
        Public Property FechaAprobacion() As Date
            Get
                Return _FechaAp
            End Get
            Set(ByVal value As Date)
                _FechaAp = value
            End Set
        End Property
        Private _Resultado As Boolean
        Public Property Resultado() As Boolean
            Get
                Return _Resultado
            End Get
            Set(ByVal value As Boolean)
                _Resultado = value
            End Set
        End Property

        Private _Observ As String
        Public Property Observaciones() As String
            Get
                Return _Observ
            End Get
            Set(ByVal value As String)
                _Observ = value
            End Set
        End Property
        Sub New(ByVal QueCueso As EE.Curso, ByVal Aprobador As Servicios.Usuario, ByVal Observaciones As String)

        End Sub
    End Class
End Namespace