Namespace Servicios
    Public Class PermisoCompuesto
        Inherits PermisoBase


        Private _lista As New List(Of PermisoBase)
        Public Property ListaPermisos() As List(Of PermisoBase)
            Get
                Return _lista
            End Get
            Set(ByVal value As List(Of PermisoBase))
                _lista = value
            End Set
        End Property
        Public Sub AgregarPermiso(ByVal Permiso As PermisoBase)
            Permiso.Padre = Me
            Me.ListaPermisos.Add(Permiso)
        End Sub
        Public Sub QuitarPermiso(ByVal Permiso As PermisoBase)
            Me.ListaPermisos.Remove(Permiso)
        End Sub

        Public Overrides Function TieneHijos() As Boolean
            Return True
        End Function
        Sub New()
            Dim Padre As New PermisoSimple
            Padre.ID = 0
            Padre.Descripcion = "Huerfano"
            Me.Padre = Padre
        End Sub

        Public Overrides Function ObtenerHijos() As List(Of PermisoBase)
            Return Me.ListaPermisos
        End Function
    End Class
End Namespace