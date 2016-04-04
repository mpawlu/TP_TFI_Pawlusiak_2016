Namespace EE
    Public Class clsIdioma

#Region "Variables"

        Private _ID As Integer
        Private _Descripcion As String

#End Region


#Region "Propiedades"
        Public Property ID() As Integer
            Get
                Return _ID
            End Get
            Set(ByVal value As Integer)
                _ID = value
            End Set
        End Property


        Public Property Descripcion() As String
            Get
                Return _Descripcion
            End Get
            Set(ByVal value As String)
                _Descripcion = value
            End Set
        End Property
#End Region


    End Class
End Namespace
