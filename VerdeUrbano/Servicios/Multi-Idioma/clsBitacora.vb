Namespace Servicios
    Public Class clsBitacora
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


    End Class
End Namespace

