Namespace Servicios
    Public MustInherit Class clsExcepcionPersonalizada


        Inherits System.Exception
        Private _Titulo As String
        Public Property Titulo() As String
            Get
                Return _Titulo
            End Get
            Set(ByVal value As String)
                _Titulo = value
            End Set
        End Property
        MustOverride Function Mensaje() As String



    End Class
End Namespace
