
Namespace EE
    Public Class clsLocalidad
#Region "Variables"
        Private _Id As Integer
        Private _Descripcion As String

#End Region


#Region "Propiedades"

        Public Property Id() As Integer
            Get
                Return _Id
            End Get
            Set(ByVal value As Integer)
                _Id = value
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
