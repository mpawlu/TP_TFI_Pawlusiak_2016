Public Class realizarRestore
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Try
            Dim Resultado As Boolean
            Dim MiBackupRestoreEntidad As New Servicios.clsBackupRestore
            Dim Path As String
            Path = "E:\bkVerdeUrbano\"
            Path = Path & Me.fuRestore.FileName
            MiBackupRestoreEntidad.Directorio = Path
            Dim oBRBLL As New BLL.BackupRestore
            Resultado = oBRBLL.RealizarRestore(MiBackupRestoreEntidad)
        Catch ex As Exception

        End Try

    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Response.Redirect("index.aspx")
    End Sub
End Class