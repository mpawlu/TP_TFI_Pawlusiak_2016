Namespace EE
    Public Class Empleado
        Private _DNI As String
        Public Property DNI() As String
            Get
                Return _DNI
            End Get
            Set(ByVal value As String)
                _DNI = value
            End Set
        End Property


        Private _nomb As String
        Public Property Nombre() As String
            Get
                Return _nomb
            End Get
            Set(ByVal value As String)
                _nomb = value
            End Set
        End Property

        Private _Ap As String
        Public Property Apellido() As String
            Get
                Return _Ap
            End Get
            Set(ByVal value As String)
                _Ap = value
            End Set
        End Property

        Private _Email As String
        Public Property Email() As String
            Get
                Return _Email
            End Get
            Set(ByVal value As String)
                _Email = value
            End Set
        End Property

        Private _Telefono As String
        Public Property Telefono() As String
            Get
                Return _Telefono
            End Get
            Set(ByVal value As String)
                _Telefono = value
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

    End Class
End Namespace
