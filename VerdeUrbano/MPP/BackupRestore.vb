Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data
Imports System.Text
Namespace MPP
    Public Class BackupRestore
        Public Function RealizarBackup(ByVal paramBackupRestoreEntidad As Servicios.clsBackupRestore) As Boolean
            Dim MiDirectorio As String
            If paramBackupRestoreEntidad.Directorio.Length <> 3 Then
                MiDirectorio = paramBackupRestoreEntidad.Directorio & "\" & paramBackupRestoreEntidad.Nombre & ".bak"
            Else
                MiDirectorio = paramBackupRestoreEntidad.Directorio & paramBackupRestoreEntidad.Nombre & ".bak"
            End If

            Using MiConectionMaster = DAL.Datos.retornaConexionMaestra()
                Try
                    Dim MiStringBuilder As New StringBuilder
                    MiStringBuilder.Append("BACKUP DATABASE [VerdeUrbano] TO DISK = '" & MiDirectorio & "' ")
                    MiStringBuilder.Append("WITH DESCRIPTION = 'Backup IETDB', NOFORMAT, NOINIT, ")
                    MiStringBuilder.Append("NAME = '" & paramBackupRestoreEntidad.Nombre & "', SKIP, NOREWIND, NOUNLOAD, STATS = 10")
                    Dim MiComando As New SqlCommand(MiStringBuilder.ToString, MiConectionMaster)
                    Dim oDatos As New DAL.Datos
                    If oDatos.BackupRestore(MiComando, MiConectionMaster) = True Then
                        'MiConectionMaster.Open()
                        'MiComando.ExecuteNonQuery()
                        Return True
                    End If
                Catch ex As Exception
                    Return False
                Finally
                    MiConectionMaster.Close()
                End Try
            End Using
        End Function

        Public Function RealizarRestore(ByVal paramBackupRestoreEntidad As Servicios.clsBackupRestore) As Boolean
            Dim MiConectionMaster As SqlConnection
            Try
                MiConectionMaster = DAL.Datos.retornaConexionMaestra()
                Dim Strcomando As String = " ALTER DATABASE [VerdeUrbano] SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE [VerdeUrbano] FROM DISK = '" & paramBackupRestoreEntidad.Directorio & "'  With Replace ALTER DATABASE [VerdeUrbano] SET MULTI_USER "
                Dim MiComando As New SqlCommand(Strcomando, MiConectionMaster)
                Dim oDatos As New DAL.Datos
                If oDatos.BackupRestore(MiComando, MiConectionMaster) = True Then
                    'MiConectionMaster.Open()
                    'MiComando.ExecuteNonQuery()
                    Return True
                End If
            Catch ex As Exception
                Return False
            Finally
                MiConectionMaster.Close()
            End Try
        End Function
    End Class
End Namespace
