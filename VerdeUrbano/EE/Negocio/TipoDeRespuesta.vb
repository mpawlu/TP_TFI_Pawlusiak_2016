Namespace EE
    Public Class TipoDeRespuesta
        Private ID As Integer
        Public Property ID_Tipo() As Integer
            Get
                Return ID
            End Get
            Set(ByVal value As Integer)
                ID = value
            End Set
        End Property

        Private _desc As String
        Public Property Descripcion() As String
            Get
                Return _desc
            End Get
            Set(ByVal value As String)
                _desc = value
            End Set
        End Property

        Private _Opciones As List(Of String)
        Public Property Opciones() As List(Of String)
            Get
                Return _Opciones
            End Get
            Set(ByVal value As List(Of String))
                _Opciones = value
            End Set
        End Property
    End Class
End Namespace

