Namespace EE
    Public Class Empresa
        Private _ID As Integer
        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property

        Private _CUIT As String
        Public Property CUIT() As String
            Get
                Return _CUIT
            End Get
            Set(ByVal value As String)
                _CUIT = value
            End Set
        End Property

        Private _Nomb As String
        Public Property Nombre() As String
            Get
                Return _Nomb
            End Get
            Set(ByVal value As String)
                _Nomb = value
            End Set
        End Property

        Private _FechaAlta As Date
        Public Property FechaAlta() As Date
            Get
                Return _FechaAlta
            End Get
            Set(ByVal value As Date)
                _FechaAlta = value
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

        Private _Direccion As String
        Public Property Direccion() As String
            Get
                Return _Direccion
            End Get
            Set(ByVal value As String)
                _Direccion = value
            End Set
        End Property


        Private _Empleados As List(Of Servicios.Usuario)
        Public Property Empleados() As List(Of Servicios.Usuario)
            Get
                Return _Empleados
            End Get
            Set(ByVal value As List(Of Servicios.Usuario))
                _Empleados = value
            End Set
        End Property


    End Class
End Namespace

