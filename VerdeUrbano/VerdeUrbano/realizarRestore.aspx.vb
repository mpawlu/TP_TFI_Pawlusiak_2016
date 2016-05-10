Public Class realizarRestore
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.correcto.visible = False

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
            If Resultado = True Then
                Me.correcto.Visible = True
            Else
                Me.correcto.Visible = False
                Throw New Exception
            End If
        Catch ex As Exception
            Me.Error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try

    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Response.Redirect("index.aspx")
    End Sub
End Class