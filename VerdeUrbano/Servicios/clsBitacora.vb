Namespace Servicios
    Public Class clsBitacora
        Public Enum tipoOperacionBitacora
            Alta = 1
            Baja = 2
            Modificacion = 3
            Login = 4
            Logout = 5
            Errores = 6
            Bloqueo = 7
            Desbloqueo = 8
            Backup = 9
            Restore = 10
        End Enum

        Private _ID As Integer
        Public Property ID_Evento() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
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
        Private _FechaHora As DateTime
        Public Property FechaHora() As DateTime
            Get
                Return _FechaHora
            End Get
            Set(ByVal value As DateTime)
                _FechaHora = value
            End Set
        End Property

        Private _DescEvento As String
        Public Property DescripcionEvento() As String
            Get
                Return _DescEvento
            End Get
            Set(ByVal value As String)
                _DescEvento = value
            End Set
        End Property

        Private _TipoOperacion As tipoOperacionBitacora
        Public Property TipoOperacion() As tipoOperacionBitacora
            Get
                Return _TipoOperacion
            End Get
            Set(ByVal value As tipoOperacionBitacora)
                _TipoOperacion = value
            End Set
        End Property

        Sub New()

        End Sub

        Sub New(ByVal _usuario As Servicios.Usuario, ByVal _tipoOperacion As tipoOperacionBitacora, ByVal _descripcion As String)
            Me.Usuario = _usuario
            Me.TipoOperacion = _tipoOperacion
            Me.DescripcionEvento = _descripcion
            Me.FechaHora = Now
        End Sub
    End Class
End Namespace

