Namespace EE
    Public Class Resultado


        Private _SumaObtenida As Integer
        Public Property SumaObtenida() As Integer
            Get
                Return _SumaObtenida
            End Get
            Set(ByVal value As Integer)
                _SumaObtenida = value
            End Set
        End Property

        Private _SumaIdeal As Integer
        Public Property SumaIdeal() As Integer
            Get
                Return _SumaIdeal
            End Get
            Set(ByVal value As Integer)
                _SumaIdeal = value
            End Set
        End Property
        Private _ResultadoObtenido As Double
        Public Property ResultadoObtenido() As Double
            Get
                Return _ResultadoObtenido
            End Get
            Set(ByVal value As Double)
                _ResultadoObtenido = value
            End Set
        End Property

    End Class
End Namespace

