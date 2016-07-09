Public Class realizarRestore
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ocultarDivs()
        If validaciones.validarPagina(Me) = False Then
            Response.Redirect("error.aspx")
        End If
        Me.correcto.Visible = False
    End Sub

    Protected Sub btn_Agregar_Click(sender As Object, e As EventArgs) Handles btn_Agregar.Click
        Try
            Dim Resultado As Boolean
            Dim MiBackupRestoreEntidad As New Servicios.clsBackupRestore
            Dim Path As String
            Path = "D:\bkVerdeUrbano\"
            'Path = Me.fuRestore.PostedFile.FileName
            'If fuRestore.PostedFile.FileName <> "" Then
            '    Dim MiDirPath As String = Server.MapPath("~/Backup")
            '    Me.CrearDirectorio(MiDirPath)
            '    Dim MiPathAGuardar As String = String.Format("{0}\{1}", MiDirPath, _profesor.Nombre & "." & _profesor.Apellido & ".png")
            'Else
            'End If
            MiBackupRestoreEntidad.Directorio = Path & fuRestore.PostedFile.FileName
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
    Public Sub ocultarDivs()
        Me.correcto.Visible = False
        Me.error.Visible = False
    End Sub
End Class