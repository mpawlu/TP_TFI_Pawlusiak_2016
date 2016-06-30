Namespace EE
    Public Class Informativa
        Private _ID As Integer
        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property

        Private _Titulo As String
        Public Property Titulo() As String
            Get
                Return _Titulo
            End Get
            Set(ByVal value As String)
                _Titulo = value
            End Set
        End Property

        Private _Descripcion As String
        Public Property Descripcion() As String
            Get
                Return _Descripcion
            End Get
            Set(ByVal value As String)
                _Descripcion = value
            End Set
        End Property

        Private _Slides As List(Of Slide)
        Public Property Slides() As List(Of Slide)
            Get
                Return _Slides
            End Get
            Set(ByVal value As List(Of Slide))
                _Slides = value
            End Set
        End Property
        Sub New(ByVal Titulo As String, ByVal Descripcion As String)
            Me.Titulo = Titulo
            Me.Descripcion = Descripcion

        End Sub
        Sub New()

        End Sub
    End Class
End Namespace

