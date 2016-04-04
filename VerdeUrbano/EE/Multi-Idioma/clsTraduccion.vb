
Namespace EE
    Public Class clsTraduccion
#Region "Variables"

        Private _Idioma As New clsIdioma
        Private _Leyenda As New clsLeyenda
        Private _Traduccion As String

#End Region

#Region "Propiedades"
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

        Public Sub CargarDatos(ByVal Idioma As clsIdioma, ByVal Leyenda As clsLeyenda, ByVal Traduccion As String)
            Me.Idioma = Idioma
            Me.Leyenda = Leyenda
            Me.Traduccion = Traduccion
        End Sub
    End Class

End Namespace
