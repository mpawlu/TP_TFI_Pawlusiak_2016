Imports System.IO
Public Class realizarBackup
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If validaciones.validarPagina(Me) = False Then
            Response.Redirect("error.aspx")
        End If
        If Not IsPostBack Then
           
        End If
        Me.correcto.Visible = False
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
            If Resu = True Then
                Me.correcto.Visible = True
            Else
                Me.correcto.Visible = False
                Throw New Exception
            End If
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Response.Redirect("index.aspx")
    End Sub
End Class