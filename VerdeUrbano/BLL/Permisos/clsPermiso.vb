Namespace BLL
    Public Class clsPermiso

        'Public Function ListarPerfiles() As List(Of Servicios.PermisoCompuesto)
        '    Dim ListaPerfiles As List(Of Servicios.PermisoCompuesto)
        '    For Each Perfil As Servicios.PermisoCompuesto In ListaPerfiles
        '        Perfil.AgregarPermiso(Consultar(Perfil))
        '    Next

        'End Function
        'Public Function Consultar(ByVal _permiso As Servicios.PermisoBase) As Servicios.PermisoBase
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


        Public Function ListarPerfiles() As List(Of Servicios.PermisoCompuesto)
            Try
                Dim PermisoMPP As New MPP.Permiso
                Return PermisoMPP.ListarPerfiles()
            Catch ex As Exception

            End Try
        End Function


        Public Function ListarFamilias() As List(Of Servicios.PermisoBase)
            Try
                Dim PermisoMPP As New MPP.Permiso
                Return PermisoMPP.listarFamilias()
            Catch ex As Exception

            End Try
        End Function
        Public Function ListarFamiliasDePerfiles() As List(Of Servicios.PermisoCompuesto)
            Try
                Dim PermisoMPP As New MPP.Permiso
                Dim ListaPerfiles As New List(Of Servicios.PermisoCompuesto)
                Dim FamiliasDePerfiles As New List(Of Servicios.PermisoCompuesto)
                ListaPerfiles = PermisoMPP.ListarPerfiles
                For Each p As Servicios.PermisoCompuesto In ListaPerfiles
                    FamiliasDePerfiles.Add(p)
                Next
                Return FamiliasDePerfiles
            Catch ex As Exception

            End Try
        End Function

        Public Function ListarFamilias(ByVal paramID As Integer) As Servicios.PermisoCompuesto
            Try
                Dim PermisoMPP As New MPP.Permiso
                Return PermisoMPP.listarFamilias(paramID)
            Catch ex As Exception
                'Throw New BLL.excepcionGenerica
            End Try
        End Function

        Public Sub Alta(ByVal paramPermiso As Servicios.PermisoBase)
            Try
                Dim PermisoMPP As New MPP.Permiso
                If PermisoMPP.chequearNombrePermiso(paramPermiso.Descripcion) = False Then
                    PermisoMPP.AltaPermiso(paramPermiso)
                Else
                    'Throw New PermisoDuplicadoException
                End If
                'BLL.BitacoraBLL.Alta(SesionBLL.Current.Usuario, Entidades.Bitacora.tipoPrioridadBitacora.Alta, Entidades.Bitacora.tipoOperacionBitacora.Alta, "Se dio de alta el permiso " & paramPermiso.Nombre)
            Catch ex As Exception
                'Throw New BLL.excepcionGenerica
            End Try
        End Sub


        Public Sub Modificar(ByVal paramPermiso As Servicios.PermisoBase)
            Try
                Dim PermisoMPP As New MPP.Permiso
                PermisoMPP.ModificarPermiso(paramPermiso)
                'BLL.BitacoraBLL.Alta(SesionBLL.Current.Usuario, Entidades.Bitacora.tipoPrioridadBitacora.Media, Entidades.Bitacora.tipoOperacionBitacora.Modificacion, "Se modifico el permiso " & paramPermiso.Nombre)
            Catch ex As Exception
                'Throw New BLL.excepcionGenerica
            End Try
        End Sub

        Public Sub Baja(ByVal paramID As Integer)
            Try
                Dim PermisoMPP As New MPP.Permiso
                PermisoMPP.BajaPermiso(paramID)
                'BLL.BitacoraBLL.Alta(SesionBLL.Current.Usuario, Entidades.Bitacora.tipoPrioridadBitacora.Alta, Entidades.Bitacora.tipoOperacionBitacora.Baja, "Se dio de baja el permiso " & paramID)
            Catch ex As Exception
                'Throw New BLL.excepcionGenerica
            End Try
        End Sub

        Public Shared Function obtenerIDPermiso(ByVal paramNombrePermiso As String) As Integer
            Try
                Dim PermisoMPP As New MPP.Permiso
                Return PermisoMPP.obtenerIDPermiso(paramNombrePermiso)
            Catch ex As Exception
                'Throw New BLL.excepcionGenerica
            End Try
        End Function

        Public Function chequearNombrePermiso(ByVal paramNombrePermiso As String) As Boolean
            Try
                Dim PermisoMPP As New MPP.Permiso
                Return PermisoMPP.chequearNombrePermiso(paramNombrePermiso)
            Catch ex As Exception
                'Throw New BLL.excepcionGenerica
            End Try
        End Function
    End Class
End Namespace

