Imports System.IO
Public Class realizarBackup
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.txtDirectorio.ReadOnly = True
        Me.txtDirectorio.Text = "E:\bkVerdeUrbano"
    End Sub

    Public Sub CrearDirectorio(ByVal paramPath As String)
        Dim MiDirectorio As DirectoryInfo = New DirectoryInfo(paramPath)
        If Not MiDirectorio.Exists Then
            MiDirectorio.Create()
        End If
    End Sub

    Protected Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Try
            Dim MiBackupRestoreBLL As New BLL.BackupRestore
            Dim MiBackupRestoreEntidad As New Servicios.clsBackupRestore
            MiBackupRestoreEntidad.Directorio = txtDirectorio.Text
            Me.CrearDirectorio(txtDirectorio.Text)
            MiBackupRestoreEntidad.Nombre = txtnombre.Text
            Dim Resu As Boolean = MiBackupRestoreBLL.RealizarBackup(MiBackupRestoreEntidad)
        Catch ex As Exception

        End Try
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Response.Redirect("index.aspx")
    End Sub
End Class