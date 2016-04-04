Namespace EE
    Public Class clsLeyenda
#Region "Variables"

        Private _ID As String
        Private _Leyenda As String

#End Region

#Region "Propiedades"
        Public Property ID() As String
            Get
                Return _ID
            End Get
            Set(ByVal value As String)
                _ID = value
            End Set
        End Property

        Public Property Leyenda() As String
            Get
                Return _Leyenda
            End Get
            Set(ByVal value As String)
                _Leyenda = value
            End Set
        End Property

#End Region

    End Class
End Namespace
