Namespace Servicios
    Public Class clsBackupRestore
        Sub New(ByVal Directorio As String, ByVal Nombre As String, ByVal desc As String)
            Me.Directorio = Directorio
            Me.Nombre = Nombre
        End Sub

        Sub New()

        End Sub

        Sub New(ByVal Directorio As String)
            Me.Directorio = Directorio
        End Sub

        Private _Directorio As String
        Public Property Directorio() As String
            Get
                Return _Directorio
            End Get
            Set(ByVal value As String)
                _Directorio = value
            End Set
        End Property
        Private _descripcion As String
        Public Property Descripcion() As String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As String)
                _descripcion = value
            End Set
        End Property



        Private _Nombre As String
        Public Property Nombre() As String
            Get
                Return _Nombre
            End Get
            Set(ByVal value As String)
                _Nombre = value
            End Set
        End Property

      

    End Class
End Namespace

