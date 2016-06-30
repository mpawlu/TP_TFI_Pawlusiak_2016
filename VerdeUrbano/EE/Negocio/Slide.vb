Namespace EE
    Public Class Slide
        Private _titulo As String
        Public Property Titulo() As String
            Get
                Return _titulo
            End Get
            Set(ByVal value As String)
                _titulo = value
            End Set
        End Property

        Private _Subtitulo As String
        Public Property Subtitulo() As String
            Get
                Return _Subtitulo
            End Get
            Set(ByVal value As String)
                _Subtitulo = value
            End Set
        End Property
        Private _tipo As String
        Public Property Tipo() As String
            Get
                Return _tipo
            End Get
            Set(ByVal value As String)
                _tipo = value
            End Set
        End Property
    End Class

End Namespace

