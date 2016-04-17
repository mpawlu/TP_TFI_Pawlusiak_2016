Namespace Servicios
    Public Class clsLeyenda
#Region "Propiedades"
        Private _ID As String

        Public Property ID() As String
            Get
                Return _ID
            End Get
            Set(ByVal value As String)
                _ID = value
            End Set
        End Property
        Private _Leyenda As String
        Public Property Leyenda() As String
            Get
                Return _Leyenda
            End Get
            Set(ByVal value As String)
                _Leyenda = value
            End Set
        End Property
#End Region
        '#Region "Metodos"
        '        Public Function ListarLeyendas() As List(Of Servicios.clsLeyenda)
        '            Dim resultado As New List(Of Servicios.clsLeyenda)
        '            Dim Mapper As New MPP.clsLeyenda

        '            resultado = Mapper.ListarLeyendas()

        '            Return resultado
        '        End Function
        '#End Region


    End Class
End Namespace

