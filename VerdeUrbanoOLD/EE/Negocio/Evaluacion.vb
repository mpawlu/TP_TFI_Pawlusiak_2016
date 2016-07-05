Namespace EE
    Public Class Evaluacion
        Private _ID As Integer
        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property

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

        Private _preguntas As New List(Of EE.Pregunta)
        Public Property Preguntas() As List(Of EE.Pregunta)
            Get
                Return _preguntas
            End Get
            Set(ByVal value As List(Of EE.Pregunta))
                _preguntas = value
            End Set
        End Property

        Sub New()

        End Sub

        Sub New(ByVal Titulo As String, ByVal Descripcion As String)
            
        End Sub


    End Class
End Namespace