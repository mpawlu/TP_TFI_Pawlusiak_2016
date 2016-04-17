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
        '#Region "Metodos"
        '        Public Function CrearIdioma() As Boolean
        '            Dim oMapper As New MPP.clsIdioma
        '            Dim resultado As Boolean

        '            resultado = oMapper.CrearIdioma(Me)

        '            Return resultado

        '        End Function
        '        Public Function ListarIdiomas() As List(Of Servicios.clsIdioma)
        '            Dim oMapper As New MPP.clsIdioma
        '            Dim listaIdiomas As New List(Of Servicios.clsIdioma)

        '            listaIdiomas = oMapper.ListarIdiomas()

        '            Return listaIdiomas
        '        End Function
        '#End Region

    End Class
End Namespace

