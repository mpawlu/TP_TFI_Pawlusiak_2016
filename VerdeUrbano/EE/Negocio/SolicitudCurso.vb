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
        Private _Categoria As Categoria
        Public Property Categoria() As Categoria
            Get
                Return _Categoria
            End Get
            Set(ByVal value As Categoria)
                _Categoria = value
            End Set
        End Property
        Private _Solicitante As EE.clsUsuario
        Public Property Solicitante() As EE.clsUsuario
            Get
                Return _Solicitante
            End Get
            Set(ByVal value As EE.clsUsuario)
                _Solicitante = value
            End Set
        End Property
        Private _Diseñador As EE.clsUsuario
        Public Property Diseñador() As EE.clsUsuario
            Get
                Return _Diseñador
            End Get
            Set(ByVal value As EE.clsUsuario)
                _Diseñador = value
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
        Sub New(ByVal Cat As Categoria, ByVal solicitante As EE.clsUsuario, ByVal diseñador As EE.clsUsuario, ByVal FechaLimite As Date, ByVal titulo As String, ByVal detalle As String)

        End Sub

    End Class
End Namespace