Imports Servicios
Imports EE

Namespace EE

    Public Class clsUsuario
        Implements Observable

#Region "Variables"
        Private _Id As Integer
        Private _Nombre As String
        Private _Apellido As String
        Private _UserName As String
        Private _dni As Integer
        Private _Localidad As New clsLocalidad
        Private _Activo As Boolean
        Private _Idioma As New clsIdioma
        Private _perfil As New clsPermisoCompuesto
        Private _Contraseña As String
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

        Public Property Nombre() As String
            Get
                Return _Nombre
            End Get
            Set(ByVal value As String)
                _Nombre = value
            End Set
        End Property

        Public Property Apellido() As String
            Get
                Return _Apellido
            End Get
            Set(ByVal value As String)
                _Apellido = value
            End Set
        End Property

        Public Property UserName() As String
            Get
                Return _UserName
            End Get
            Set(ByVal value As String)
                _UserName = value
            End Set
        End Property


        Public Property DNI() As Integer
            Get
                Return _dni
            End Get
            Set(ByVal value As Integer)
                _dni = value
            End Set
        End Property


        Public Property Localidad() As clsLocalidad
            Get
                Return _Localidad
            End Get
            Set(ByVal value As clsLocalidad)
                _Localidad = value
            End Set
        End Property

        Public Property Activo() As Boolean
            Get
                Return _Activo
            End Get
            Set(ByVal value As Boolean)
                _Activo = value
            End Set
        End Property

        Public Property Idioma() As clsIdioma
            Get
                Return _Idioma
            End Get
            Set(ByVal value As clsIdioma)
                _Idioma = value
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

        Public Property Perfil() As clsPermisoCompuesto
            Get
                Return _perfil
            End Get
            Set(ByVal value As clsPermisoCompuesto)
                _perfil = value
            End Set
        End Property

        Public Property Contraseña() As String
            Get
                Return _Contraseña
            End Get
            Set(ByVal value As String)
                _Contraseña = value
            End Set
        End Property
        Private _empresa As EE.Empresa
        Public Property Empresa() As EE.Empresa
            Get
                Return _empresa
            End Get
            Set(ByVal value As EE.Empresa)
                _empresa = value
            End Set
        End Property
#End Region


        Public Sub AgregarObservador(Observador As Obvserver) Implements Observable.AgregarObservador
            Me.Observadores.Add(Observador)
        End Sub

        Public Sub Notificar() Implements Observable.Notificar
            For Each ob As Servicios.Obvserver In Me.Observadores
                ob.ActualizarIdioma()
            Next
        End Sub

        Public Sub QuitarObservador(Observador As Obvserver) Implements Observable.QuitarObservador
            Me.Observadores.Remove(Observador)
        End Sub

    End Class



End Namespace