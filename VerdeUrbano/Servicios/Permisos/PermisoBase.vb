Namespace Servicios
    Public MustInherit Class PermisoBase
        Private _ID As Integer
        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property
        Private _Descripcion As String
        Public Property Descripcion() As String
            Get
                Return _Descripcion
            End Get
            Set(ByVal value As String)
                _Descripcion = value
            End Set
        End Property
        Private _padre As PermisoBase
        Public Property Padre() As PermisoBase
            Get
                Return _padre
            End Get
            Set(ByVal value As PermisoBase)
                _padre = value
            End Set
        End Property
        Private _url As String
        Public Property Url() As String
            Get
                Return _url
            End Get
            Set(ByVal value As String)
                _url = value
            End Set
        End Property
        Private _Accion As String
        Public Property Accion() As String
            Get
                Return _Accion
            End Get
            Set(ByVal value As String)
                _Accion = value
            End Set
        End Property


        Public MustOverride Function TieneHijos() As Boolean
    End Class
End Namespace