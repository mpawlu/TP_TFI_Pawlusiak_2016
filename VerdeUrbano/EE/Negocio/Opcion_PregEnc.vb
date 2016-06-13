Namespace EE
    Public Class Opcion_PregEnc
        Private _ID As Integer
        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property

        Private _Texto As String
        Public Property Texto() As String
            Get
                Return _Texto
            End Get
            Set(ByVal value As String)
                _Texto = value
            End Set
        End Property

        Sub New(ByVal texto As String, ByVal EsCorrecta As Boolean)

        End Sub
        Sub New()


        End Sub

    End Class
End Namespace

