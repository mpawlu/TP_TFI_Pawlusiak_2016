Namespace Servicios
    Public Class clsIdioma
#Region "Propiedades"
        Private _ID As Integer

        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
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
        Private _DVH As String
        Public Property DVH() As String
            Get
                Return _DVH
            End Get
            Set(ByVal value As String)
                _DVH = value
            End Set
        End Property

#End Region


    End Class
End Namespace

