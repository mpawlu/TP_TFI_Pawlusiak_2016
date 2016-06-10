Namespace EE
    Public Class Pregunta
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
        Public Property Pregunta() As String
            Get
                Return _Texto
            End Get
            Set(ByVal value As String)
                _Texto = value
            End Set
        End Property


        Private _Valor As Integer
        Public Property Valor() As Integer
            Get
                Return _Valor
            End Get
            Set(ByVal value As Integer)
                _Valor = value
            End Set
        End Property

        Private _Opciones As New List(Of Opcion)
        Public Property Opciones() As List(Of Opcion)
            Get
                Return _Opciones
            End Get
            Set(ByVal value As List(Of Opcion))
                _Opciones = value
            End Set
        End Property
        Sub New(ByVal pregunta As String, ByVal valor As Integer)

        End Sub
    End Class
End Namespace

