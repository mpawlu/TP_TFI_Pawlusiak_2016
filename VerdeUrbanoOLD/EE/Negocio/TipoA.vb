Namespace EE
    Public Class TipoA
        Inherits Slide
        Private _Texto As String
        Public Property Texto() As String
            Get
                Return _Texto
            End Get
            Set(ByVal value As String)
                _Texto = value
            End Set
        End Property
        Sub New(ByVal Titulo As String, ByVal subtitulo As String, ByVal texto As String)
            Me.Titulo = Titulo
            Me.Subtitulo = subtitulo
            Me.Texto = texto
        End Sub
        Sub New()

        End Sub
    End Class
End Namespace

