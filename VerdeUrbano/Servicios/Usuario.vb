Namespace Servicios
    Public Class Usuario
        Implements Observable

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
        Private _NombreUsuario As String
        Public Property NombreUsuario() As String
            Get
                Return _NombreUsuario
            End Get
            Set(ByVal value As String)
                _NombreUsuario = value
            End Set
        End Property
        Private _Pass As String
        Public Property Password() As String
            Get
                Return _Pass
            End Get
            Set(ByVal value As String)
                _Pass = value
            End Set
        End Property
        Private _DNI As Integer
        Public Property DNI() As Integer
            Get
                Return _DNI
            End Get
            Set(ByVal value As Integer)
                _DNI = value
            End Set
        End Property
        Private _Activo As Boolean
        Public Property Activo() As Boolean
            Get
                Return _Activo
            End Get
            Set(ByVal value As Boolean)
                _Activo = value
            End Set
        End Property
        Private _perfil As PermisoCompuesto
        Public Property Perfil() As PermisoCompuesto
            Get
                Return _perfil
            End Get
            Set(ByVal value As PermisoCompuesto)
                _perfil = value
            End Set
        End Property
        Private _Bloqueado As Boolean
        Public Property Bloqueado() As Boolean
            Get
                Return _Bloqueado
            End Get
            Set(ByVal value As Boolean)
                _Bloqueado = value
            End Set
        End Property
        Private _FechaAlta As Date
        Public Property FechaAlta() As Date
            Get
                Return _FechaAlta
            End Get
            Set(ByVal value As Date)
                _FechaAlta = value
            End Set
        End Property
        Private _Editable As Boolean
        Public Property Editable() As Boolean
            Get
                Return _Editable
            End Get
            Set(ByVal value As Boolean)
                _Editable = value
            End Set
        End Property
        Private _Intentos As Integer
        Public Property Intentos() As Integer
            Get
                Return _Intentos
            End Get
            Set(ByVal value As Integer)
                _Intentos = value
            End Set
        End Property
        Private _Idioma As Servicios.clsIdioma
        Public Property Idioma() As Servicios.clsIdioma
            Get
                Return _Idioma
            End Get
            Set(ByVal value As Servicios.clsIdioma)
                _Idioma = value
            End Set
        End Property
        Private _DVH As String
        Public Property NewProperty() As String
            Get
                Return _DVH
            End Get
            Set(ByVal value As String)
                _DVH = value
            End Set
        End Property

        Private _Observadores As New List(Of Servicios.Obvserver)
        Public Property Observadores() As List(Of Servicios.Obvserver)
            Get
                Return _Observadores
            End Get
            Set(ByVal value As List(Of Servicios.Obvserver))
                _Observadores = value
            End Set
        End Property
#End Region

#Region "Metods"
        Public Sub Notificar() Implements Observable.Notificar
            Try
                For Each ob As Servicios.Obvserver In Me.Observadores
                    ob.ActualizarIdioma()
                Next
            Catch ex As Exception
            End Try

        End Sub



        Public Sub AgregarObservador(Observador As Servicios.Obvserver) Implements Observable.AgregarObservador
            Try
                Me.Observadores.Add(Observador)
            Catch ex As Exception
            End Try
        End Sub

        Public Sub QuitarObservador(Observador As Servicios.Obvserver) Implements Observable.QuitarObservador
            Try
                Me.Observadores.Remove(Observador)
            Catch ex As Exception
            End Try
        End Sub
#End Region

    End Class
End Namespace
