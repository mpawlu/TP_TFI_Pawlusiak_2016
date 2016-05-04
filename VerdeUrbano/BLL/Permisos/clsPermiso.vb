Public Class clsPermiso
    Public Function CrearPerfil(ByVal Perfil As EE.clsPermiso) As Boolean

    End Function
    Public Function ListarPerfiles() As List(Of Servicios.PermisoCompuesto)
        'Para los Perfiles
        Dim ListaPerfiles As List(Of Servicios.PermisoCompuesto)
        For Each Perfil As Servicios.PermisoCompuesto In ListaPerfiles
            ' esAccion = True
            '       Perfil.AgregarPermiso(Consultar(Perfil))
        Next

    End Function


    'Public Function Consultar(ByVal _permiso As Servicios.PermisoBase) As Servicios.PermisoBase
    '    'Estos pueden ser Permisos Simples o Compuestos

    '    Dim permMPP As New MPP.Permiso
    '    _permiso = permMPP.ConsultarPermiso(_permiso)
    '    If _permiso.TieneHijos = True Then
    '        _permiso = New Servicios.PermisoCompuesto
    '        DirectCast(_permiso, Servicios.PermisoCompuesto).ListaPermisos = permMPP.ConsultarHijos(_permiso)
    '        For Each p As Servicios.PermisoBase In DirectCast(_permiso, Servicios.PermisoCompuesto).ListaPermisos
    '            CType(_permiso, Servicios.PermisoCompuesto).ListaPermisos.Add(p)
    '            If p.TieneHijos = True Then
    '                Consultar(p)
    '            End If
    '        Next
    '        Return _permiso
    '    Else
    '        Return CType(_permiso, Servicios.PermisoSimple)
    '    End If
    'End Function


    Public Function Listar(ByVal _usuario As Servicios.Usuario) As Servicios.PermisoBase


    End Function
End Class
