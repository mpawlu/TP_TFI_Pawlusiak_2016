Namespace EE
    Public Class TipoC
        Inherits Slide

        Private _Video As String
        Public Property Video() As String
            Get
                Return _Video
            End Get
            Set(ByVal value As String)
                _Video = value
            End Set
        End Property
        Sub New(ByVal Titulo As String, ByVal subtitulo As String, ByVal URL_Video As String)
            Me.Titulo = Titulo
            Me.Subtitulo = subtitulo
            Me.Video = URL_Video
        End Sub
        Sub New()

        End Sub
    End Class

End Namespace

