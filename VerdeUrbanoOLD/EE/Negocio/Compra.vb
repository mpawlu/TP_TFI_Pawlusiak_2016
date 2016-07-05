Namespace EE
    Public Class Compra
        Private _CodCompra As Integer
        Public Property CodigoCompra() As Integer
            Get
                Return _CodCompra
            End Get
            Set(ByVal value As Integer)
                _CodCompra = value
            End Set
        End Property

        Private _empresa As EE.Empresa
        Public Property Empresa() As EE.Empresa
            Get
                Return _empresa
            End Get
            Set(ByVal value As EE.Empresa)
                _empresa = value
            End Set
        End Property

        Private _Usuario As Servicios.Usuario
        Public Property Usuario() As Servicios.Usuario
            Get
                Return _Usuario
            End Get
            Set(ByVal value As Servicios.Usuario)
                _Usuario = value
            End Set
        End Property


        Private _Curso As EE.Curso
        Public Property Curso() As EE.Curso
            Get
                Return _Curso
            End Get
            Set(ByVal value As EE.Curso)
                _Curso = value
            End Set
        End Property

        Private _licencias As Integer
        Public Property Licencias() As Integer
            Get
                Return _licencias
            End Get
            Set(ByVal value As Integer)
                _licencias = value
            End Set
        End Property


        Private _Total As Double
        Public Property Total() As Double
            Get
                Return _Total
            End Get
            Set(ByVal value As Double)
                _Total = value
            End Set
        End Property
    End Class
End Namespace
