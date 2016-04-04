
Public Class clsBackupRestore
    Sub New(ByVal Directorio As String, ByVal Nombre As String, ByVal desc As String)
        Me.Directorio = Directorio
        Me.Nombre = Nombre
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

    Public Function RealizarBackup() As Boolean
        Try
            Dim Resultado As Boolean
            Dim ad As New DAL.Datos
            Resultado = ad.crear_backup(Me.Directorio, Me.Nombre, Descripcion)
            'Bitacora.Guardar(Sesion.Current.Usuario, 6, True, "Se realizo un Backup de la Base de Datos")
            Return Resultado
        Catch ex As Exception
            'Bitacora.Guardar(Sesion.Current.Usuario, 5, True, "El Metodo" & ex.TargetSite.ToString & "genero el Mensaje " & ex.Message)
            Return False
        End Try
    End Function

    Public Function RealizarRestore()
        Try
            Dim Resultado As Boolean
            Dim ad As New DAL.Datos
            Resultado = ad.crear_restore(Directorio)

            'Bitacora.Guardar(Sesion.Current.Usuario, 7, True, "Se realizo un Restore de la Base de Datos")
            Return Resultado
        Catch ex As Exception
            'Bitacora.Guardar(Sesion.Current.Usuario, 5, True, "El Metodo" & ex.TargetSite.ToString & "genero el Mensaje " & ex.Message)
            Return False
        End Try
    End Function
End Class
