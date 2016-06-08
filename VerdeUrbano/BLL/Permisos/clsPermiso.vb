Namespace BLL
    Public Class clsPermiso
        Public Function ListarPerfiles() As List(Of Servicios.PermisoCompuesto)
            Try
                Dim PermisoMPP As New MPP.Permiso
                Return PermisoMPP.ListarPerfiles()
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function


        Public Function ListarFamilias() As List(Of Servicios.PermisoBase)
            Try
                Dim PermisoMPP As New MPP.Permiso
                Return PermisoMPP.listarFamilias()
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function

        Public Function ListarFamilias(ByVal paramID As Integer) As Servicios.PermisoCompuesto
            Try
                Dim PermisoMPP As New MPP.Permiso
                Return PermisoMPP.listarFamilias(paramID)
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
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
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Sub

        Public Sub Baja(ByVal paramID As Integer)
            Try
                Dim PermisoMPP As New MPP.Permiso

                If PermisoMPP.BajaPermiso(paramID) = True Then
                    Dim oBitacora As Servicios.clsBitacora
                    oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, "Se dio de baja el perfil " & paramID)
                    BLL.clsBitacora.RegistrarEvento(oBitacora)
                Else
                    Dim oBitacora As Servicios.clsBitacora
                    oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, "Ocurrio un error al querer dar de baja el perfil " & paramID)
                    BLL.clsBitacora.RegistrarEvento(oBitacora)
                End If

            Catch ex As Exception
                'Throw New BLL.excepcionGenerica
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Sub

        Public Shared Function obtenerIDPermiso(ByVal paramNombrePermiso As String) As Integer
            Try
                Dim PermisoMPP As New MPP.Permiso
                Return PermisoMPP.obtenerIDPermiso(paramNombrePermiso)
            Catch ex As Exception
                'Throw New BLL.excepcionGenerica
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
            End Try
        End Function

        Public Function chequearNombrePermiso(ByVal paramNombrePermiso As String) As Boolean
            Try
                Dim PermisoMPP As New MPP.Permiso
                Return PermisoMPP.chequearNombrePermiso(paramNombrePermiso)
            Catch ex As Exception
                'Throw New BLL.excepcionGenerica
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
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

        Public Function ListarPermisos() As List(Of Servicios.PermisoSimple)
            Try
                Dim PermisoMPP As New MPP.Permiso
                Dim ListaPermisos As New List(Of Servicios.PermisoSimple)
                ListaPermisos = PermisoMPP.ListarPermisos
                Return ListaPermisos
            Catch ex As Exception

            End Try
        End Function
        Public Function ConsultarPermiso(ByVal ID As Integer) As Servicios.PermisoBase
            Dim MPP As New MPP.Permiso
            Return MPP.ConsultarPermiso(ID)
        End Function
        Public Function ObtenerPerfilDisenador() As Servicios.PermisoCompuesto

        End Function
    End Class
End Namespace

