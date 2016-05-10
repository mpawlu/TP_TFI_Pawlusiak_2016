Namespace BLL
    Public Class BackupRestore
        Dim _mpp As New MPP.BackupRestore


        Public Function RealizarBackup(ByVal paramBackupRestoreEntidad As Servicios.clsBackupRestore) As Boolean
            Try
                Dim MiResultado As Boolean
                MiResultado = _mpp.RealizarBackup(paramBackupRestoreEntidad)

                If MiResultado = True Then
                    Dim oBitacora As Servicios.clsBitacora
                    oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, "Se genero correctamente el Backup de la base de datos")
                    BLL.clsBitacora.RegistrarEvento(oBitacora)
                Else
                    Dim oBitacora As Servicios.clsBitacora
                    oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, "Ocurrio un error al intentar realizar un backup de la base de datos")
                    BLL.clsBitacora.RegistrarEvento(oBitacora)
                End If
                Return MiResultado
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
                Return False
            End Try

        End Function

        Public Function RealizarRestore(ByVal paramBackupRestoreEntidad As Servicios.clsBackupRestore) As Boolean
            Try
                Dim MiResultado As Boolean
                MiResultado = _mpp.RealizarRestore(paramBackupRestoreEntidad)
                If MiResultado = True Then
                    Dim oBitacora As Servicios.clsBitacora
                    oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, "Se restauro correctamente la base de datos")
                    BLL.clsBitacora.RegistrarEvento(oBitacora)
                Else
                    Dim oBitacora As Servicios.clsBitacora
                    oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, "Ocurrio un error al intentar restaurar la base de datos")
                    BLL.clsBitacora.RegistrarEvento(oBitacora)
                End If
                Return MiResultado
            Catch ex As Exception
                Dim oBitacora As Servicios.clsBitacora
                oBitacora = New Servicios.clsBitacora(BLL.Singleton.InstanciaSing.oUsuarioSesion, Servicios.clsBitacora.tipoOperacionBitacora.Errores, ex.Message)
                BLL.clsBitacora.RegistrarEvento(oBitacora)
                Return False
            End Try
        End Function
    End Class
End Namespace

