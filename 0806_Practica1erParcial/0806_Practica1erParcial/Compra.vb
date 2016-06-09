Public Class Compra
    Private _ImporteCompra As Integer
    Public Property ImporteCompra() As Integer
        Get
            Return _ImporteCompra
        End Get
        Set(ByVal value As Integer)
            _ImporteCompra = value
        End Set
    End Property

    Public ReadOnly Property Envio() As Double
        Get
            Return 150
        End Get
    End Property

    Public ReadOnly Property Impuesto() As Double
        Get
            Return 50
        End Get
    End Property
    Private _PCIA As String
    Public Property Provincia() As String
        Get
            Return _PCIA
        End Get
        Set(ByVal value As String)
            _PCIA = value
        End Set
    End Property
    Private _ImporteFinal As Double
    Public Property ImporteFinal() As Double
        Get
            Return _ImporteFinal
        End Get
        Set(ByVal value As Double)
            _ImporteFinal = value
        End Set
    End Property


    Private _Vendedor As String
    Public Property Vendedor() As String
        Get
            Return _Vendedor
        End Get
        Set(ByVal value As String)
            _Vendedor = value
        End Set
    End Property


    Private _estrategia As EstrategiaGenerica
    Sub New(ByVal ImporteCompras As Integer, ByVal Pcia As String)
        Me.ImporteCompra = ImporteCompras
        Me.Provincia = Pcia
        If Me.Provincia = "Cordoba" Then
            Me._estrategia = New EstrategiaCordoba
        ElseIf Me.Provincia = "Tucuman" Then
            Me._estrategia = New EstrategiaTucuman
        ElseIf Me.Provincia = "Neuquen" Then
            Me._estrategia = New EstrategiaNeuquen
        End If
        Me.CalcularImporteFinal()
        Me.AsignarVendedor()
    End Sub
    Public Sub CalcularImporteFinal()
        Me.ImporteFinal = _estrategia.CalcularPrecio(Me)
    End Sub
    Public Sub AsignarVendedor()
        Dim h1 As New Menor2000
        Dim h2 As New Entre2000y3000
        Dim h3 As New Mayor3000
        h1.ProximoHandler = h2
        h2.ProximoHandler = h3

        h1.AsignarVendedor(Me)
    End Sub

End Class
