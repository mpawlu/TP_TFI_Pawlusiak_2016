Namespace EE
    Public Class clsPermisoCompuesto
        Inherits clsPermiso

        Private _lista As List(Of clsPermiso)
        Public Property ListaPermisos() As List(Of clsPermiso)
            Get
                Return _lista
            End Get
            Set(ByVal value As List(Of clsPermiso))
                _lista = value
            End Set
        End Property
        Public Sub AgregarPermiso(ByVal Permiso As clsPermiso)
            Me.ListaPermisos.Add(Permiso)
        End Sub
        Public Sub QuitarPermiso(ByVal Permiso As clsPermiso)
            Me.ListaPermisos.Remove(Permiso)
        End Sub
        Public Function ListarPermisos()

        End Function

        Public Overrides Function TieneHijos() As Boolean
            Return True
        End Function
    End Class
End Namespace

