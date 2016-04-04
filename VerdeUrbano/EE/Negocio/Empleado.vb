Namespace EE
    Public Class Empleado

        Private _legajo As String
        Public Property Legajo() As String
            Get
                Return _legajo
            End Get
            Set(ByVal value As String)
                _legajo = value
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

        Private _Telefono As Telefono
        Public Property Telefono() As Telefono
            Get
                Return _Telefono
            End Get
            Set(ByVal value As Telefono)
                _Telefono = value
            End Set
        End Property
    End Class
End Namespace
