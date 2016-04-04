Namespace EE
    Public Class TipoP
        Inherits Slide

        Private _Pregunta As Pregunta
        Public Property Pregunta() As Pregunta
            Get
                Return _Pregunta
            End Get
            Set(ByVal value As Pregunta)
                _Pregunta = value
            End Set
        End Property
        Sub New(ByVal pregunta As Pregunta)

        End Sub
    End Class
End Namespace
