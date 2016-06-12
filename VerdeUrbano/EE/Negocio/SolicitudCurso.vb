Namespace EE
    Public Class SolicitudCurso
        Private _id As Integer
        Public Property ID() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property

        Private _Solicitante As Servicios.Usuario
        Public Property Solicitante() As Servicios.Usuario
            Get
                Return _Solicitante
            End Get
            Set(ByVal value As Servicios.Usuario)
                _Solicitante = value
            End Set
        End Property
        Private _Disenador As Servicios.Usuario
        Public Property Disenador() As Servicios.Usuario
            Get
                Return _Disenador
            End Get
            Set(ByVal value As Servicios.Usuario)
                _Disenador = value
            End Set
        End Property
        Private _Titulo As String
        Public Property Titulo() As String
            Get
                Return _Titulo
            End Get
            Set(ByVal value As String)
                _Titulo = value
            End Set
        End Property
        Private _Detalle As String
        Public Property Detalle() As String
            Get
                Return _Detalle
            End Get
            Set(ByVal value As String)
                _Detalle = value
            End Set
        End Property
        Private _FechaSolicitud As Date
        Public Property FechaSolicitud() As Date
            Get
                Return _FechaSolicitud
            End Get
            Set(ByVal value As Date)
                _FechaSolicitud = value
            End Set
        End Property
        Private _FechaLimiteDeCreacion As String
        Public Property FechaLimiteDeCreacion() As Date
            Get
                Return _FechaLimiteDeCreacion
            End Get
            Set(ByVal value As Date)
                _FechaLimiteDeCreacion = value
            End Set
        End Property
        Private _Estas As EE.SolicitudCurso_State
        Public Property Estado() As EE.SolicitudCurso_State
            Get
                Return _Estas
            End Get
            Set(ByVal value As EE.SolicitudCurso_State)
                _Estas = value
            End Set
        End Property


        Sub New()

        End Sub
        Sub New(ByVal Cat As Categoria, ByVal solicitante As Servicios.Usuario, ByVal diseñador As Servicios.Usuario, ByVal FechaLimite As Date, ByVal titulo As String, ByVal detalle As String)

        End Sub

    End Class
End Namespace