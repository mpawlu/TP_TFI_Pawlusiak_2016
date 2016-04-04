Namespace EE
    Public Class TipoB
        Inherits Slide

        Private _Imagen As String
        Public Property Imagen() As String
            Get
                Return _Imagen
            End Get
            Set(ByVal value As String)
                _Imagen = value
            End Set
        End Property

        Private _Pie As String
        Public Property Pie() As String
            Get
                Return _Pie
            End Get
            Set(ByVal value As String)
                _Pie = value
            End Set

        End Property
        Sub New(ByVal Titulo As String, ByVal subtitulo As String, ByVal pie As String, ByVal URL_Img As String)

        End Sub
    End Class
End Namespace

