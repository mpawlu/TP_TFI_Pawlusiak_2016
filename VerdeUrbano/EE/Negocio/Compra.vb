Namespace EE
    Public Class Compra

        Private _empresa As EE.Empresa
        Public Property Empresa() As EE.Empresa
            Get
                Return _empresa
            End Get
            Set(ByVal value As EE.Empresa)
                _empresa = value
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

    End Class
End Namespace
