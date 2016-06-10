Namespace EE
    Public Class TipoP
        Inherits Slide

        Private _Preguntas As New List(Of EE.Pregunta)
        Public Property Preguntas() As List(Of EE.Pregunta)
            Get
                Return _Preguntas
            End Get
            Set(ByVal value As List(Of EE.Pregunta))
                _Preguntas = value
            End Set
        End Property

    End Class
End Namespace
