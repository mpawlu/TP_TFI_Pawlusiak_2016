Public Class administrarUsuarios
    Inherits System.Web.UI.Page
    Protected mensajeConfirmacion As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        mensajeConfirmacion = "Desea Eliminarlo?" 'esto va traducido
        obtenerUsuarios()

    End Sub

    Private Sub obtenerUsuarios()
        Dim _bllUsuario As New BLL.clsUsuario
        Dim _listaUsuarios As New List(Of Servicios.Usuario)
        _listaUsuarios = _bllUsuario.ListarUsuarios
        Me.gv_Usuarios.DataSource = _listaUsuarios
        Me.gv_Usuarios.DataBind()
    End Sub


    Protected Sub btn_Bloqueo_Command(sender As Object, e As CommandEventArgs)
        Dim bll As New BLL.clsUsuario
        Dim _usu As New Servicios.Usuario
        _usu.ID = CInt(e.CommandArgument)
        _usu = bll.RecuperarUsuario(_usu)
        bll.BloquearUsuario(_usu)
        Response.Redirect("administrarUsuarios.aspx")
    End Sub

    Protected Sub btn_desBloqueo_Command(sender As Object, e As CommandEventArgs)
        Dim bll As New BLL.clsUsuario
        Dim _usu As New Servicios.Usuario
        _usu.ID = CInt(e.CommandArgument)
        _usu = bll.RecuperarUsuario(_usu)
        bll.desbloquearUsuario(_usu)
        Response.Redirect("administrarUsuarios.aspx")
    End Sub

    Protected Sub btn_Editar_Command(sender As Object, e As CommandEventArgs)

    End Sub

    Protected Sub btn_Eliminar_Click(sender As Object, e As ImageClickEventArgs)
        Dim bll As New BLL.clsUsuario
        Dim _usu As New Servicios.Usuario
        _usu.ID = CInt(sender.CommandArgument)
        _usu = bll.RecuperarUsuario(_usu)
        bll.EliminarUsuario(_usu)
        Response.Redirect("administrarUsuarios.aspx")
    End Sub

    Private Sub gv_Usuarios_DataBound(sender As Object, e As EventArgs) Handles gv_Usuarios.DataBound
        For Each row As GridViewRow In gv_Usuarios.Rows
            If Not row.Cells(3).Text = "" Then
                If CBool(row.Cells(3).Text) = True Then
                    row.Cells(3).Text = "Bloqueado"
                    Dim imagen As System.Web.UI.WebControls.ImageButton = DirectCast(row.FindControl("btn_Bloqueo"), System.Web.UI.WebControls.ImageButton)
                    imagen.Visible = False
                    Dim imagen2 As System.Web.UI.WebControls.ImageButton = DirectCast(row.FindControl("btn_desBloqueo"), System.Web.UI.WebControls.ImageButton)
                    imagen2.Visible = True
                Else
                    row.Cells(3).Text = "Activo"
                    Dim imagen As System.Web.UI.WebControls.ImageButton = DirectCast(row.FindControl("btn_desBloqueo"), System.Web.UI.WebControls.ImageButton)
                    imagen.Visible = False
                    Dim imagen2 As System.Web.UI.WebControls.ImageButton = DirectCast(row.FindControl("btn_Bloqueo"), System.Web.UI.WebControls.ImageButton)
                    imagen2.Visible = True
                End If
            End If

            If Not row.Cells(5).Text = "" Then
                If CBool(row.Cells(5).Text) = False Then
                    Dim imagenBloqueo As System.Web.UI.WebControls.ImageButton = DirectCast(row.FindControl("btn_Bloqueo"), System.Web.UI.WebControls.ImageButton)
                    imagenBloqueo.Visible = False
                    Dim imageneliminar As System.Web.UI.WebControls.ImageButton = DirectCast(row.FindControl("btn_Editar"), System.Web.UI.WebControls.ImageButton)
                    imageneliminar.Visible = False
                    Dim imagenEditar As System.Web.UI.WebControls.ImageButton = DirectCast(row.FindControl("btn_Eliminar"), System.Web.UI.WebControls.ImageButton)
                    imagenEditar.Visible = False
                End If
            End If

            gv_Usuarios.Columns(5).Visible = False
        Next
    End Sub
End Class