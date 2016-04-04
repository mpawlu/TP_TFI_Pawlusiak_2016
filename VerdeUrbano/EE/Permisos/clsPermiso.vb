Namespace EE
    Public MustInherit Class clsPermiso
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
        Private _Padre As clsPermiso
        Public Property Padre() As clsPermiso
            Get
                Return _Padre
            End Get
            Set(ByVal value As clsPermiso)
                _Padre = value
            End Set
        End Property

        Public MustOverride Function TieneHijos() As Boolean

    End Class
End Namespace

