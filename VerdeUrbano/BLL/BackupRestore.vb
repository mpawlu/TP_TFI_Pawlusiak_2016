﻿Namespace BLL
    Public Class BackupRestore
        Dim _mpp As New MPP.BackupRestore


        Public Function RealizarBackup(ByVal paramBackupRestoreEntidad As Servicios.clsBackupRestore) As Boolean
            Try
                Dim MiResultado As Boolean
                MiResultado = _mpp.RealizarBackup(paramBackupRestoreEntidad)
                Return MiResultado
                'BLL.BitacoraBLL.Alta(SesionBLL.Current.Usuario, Entidades.Bitacora.tipoPrioridadBitacora.Alta, Entidades.Bitacora.tipoOperacionBitacora.Backup, "Backup Correcto")
            Catch ex As Exception
                'BLL.BitacoraBLL.Alta(SesionBLL.Current.Usuario, Entidades.Bitacora.tipoPrioridadBitacora.Alta, Entidades.Bitacora.tipoOperacionBitacora.Backup, "Backup Inorrecto")
                Return False
            End Try
        End Function

        Public Function RealizarRestore(ByVal paramBackupRestoreEntidad As Servicios.clsBackupRestore) As Boolean
            Try
                Dim MiResultado As Boolean
                MiResultado = _mpp.RealizarRestore(paramBackupRestoreEntidad)
                Return MiResultado
                'BLL.BitacoraBLL.Alta(SesionBLL.Current.Usuario, Entidades.Bitacora.tipoPrioridadBitacora.Alta, Entidades.Bitacora.tipoOperacionBitacora.Restore, "Restore Correcto")
            Catch ex As Exception
                'BLL.BitacoraBLL.Alta(SesionBLL.Current.Usuario, Entidades.Bitacora.tipoPrioridadBitacora.Alta, Entidades.Bitacora.tipoOperacionBitacora.Restore, "Restore Inorrecto")
                Return False
            End Try
        End Function
    End Class
End Namespace

