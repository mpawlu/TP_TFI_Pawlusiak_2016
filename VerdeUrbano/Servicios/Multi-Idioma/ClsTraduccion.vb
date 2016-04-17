Namespace Servicios
    Public Class ClsTraduccion
#Region "Propiedades"

        Private _Idioma As New clsIdioma
        Private _Leyenda As New clsLeyenda
        Private _Traduccion As String
        Public Property Idioma() As clsIdioma
            Get
                Return _Idioma
            End Get
            Set(ByVal value As clsIdioma)
                _Idioma = value
            End Set
        End Property

        Public Property Leyenda() As clsLeyenda
            Get
                Return _Leyenda
            End Get
            Set(ByVal value As clsLeyenda)
                _Leyenda = value
            End Set
        End Property

        Public Property Traduccion() As String
            Get
                Return _Traduccion
            End Get
            Set(ByVal value As String)
                _Traduccion = value
            End Set
        End Property
#End Region

        '#Region "Metodos"
        '        Public Function CrearTraduccion() As Boolean
        '            Dim oMapper As New MPP.ClsTraduccion
        '            Dim resultado As Boolean

        '            resultado = oMapper.CrearTraduccion(Me)

        '            Return resultado

        '        End Function
        '        Public Function ConsultarTraduccion() As Servicios.ClsTraduccion

        '            Dim resultado As New Servicios.ClsTraduccion
        '            Dim Mapper As New MPP.ClsTraduccion

        '            resultado = Mapper.ConsultarTraduccion(Me)

        '            Return resultado
        '        End Function
        '        Public Function ListarTraducciones(ByVal Idioma As Servicios.clsIdioma) As List(Of Servicios.ClsTraduccion)
        '            Dim resultado As New List(Of Servicios.ClsTraduccion)
        '            Dim Mapper As New MPP.ClsTraduccion

        '            resultado = Mapper.ListarTraducciones(Idioma)

        '            Return resultado

        '        End Function
        '#End Region

    End Class
End Namespace
