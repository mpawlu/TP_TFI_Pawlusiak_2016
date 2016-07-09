﻿Public Class administrarUsuarios
    Inherits System.Web.UI.Page
    Protected mensajeConfirmacion As String

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If validaciones.validarPagina(Me) = False Then
            Response.Redirect("error.aspx")
        End If
        If Not IsPostBack Then
            mensajeConfirmacion = BLL.ClsTraduccion.Traducir(RecuperarUsuario, "msg_ConfirmarEliminacion")
            obtenerUsuarios()
        End If
        Me.error.Visible = False
        Me.lbl_TituloError.Text = ""
        ocultarDivs()

    End Sub

    Private Sub obtenerUsuarios()
        Try
            Dim _bllUsuario As New BLL.clsUsuario
            Dim _listaUsuarios As New List(Of Servicios.Usuario)
            _listaUsuarios = _bllUsuario.ListarUsuarios
            Me.gv_Usuarios.DataSource = _listaUsuarios
            Me.gv_Usuarios.DataBind()
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub


    Protected Sub btn_Bloqueo_Command(sender As Object, e As CommandEventArgs)
        Try
            Dim bll As New BLL.clsUsuario
            Dim _usu As New Servicios.Usuario
            _usu.ID = CInt(e.CommandArgument)
            _usu = bll.RecuperarUsuario(_usu)
            bll.BloquearUsuario(_usu)
            Response.Redirect("administrarUsuarios.aspx")
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub

    Protected Sub btn_desBloqueo_Command(sender As Object, e As CommandEventArgs)
        Try
            Dim bll As New BLL.clsUsuario
            Dim _usu As New Servicios.Usuario
            _usu.ID = CInt(e.CommandArgument)
            _usu = bll.RecuperarUsuario(_usu)
            bll.desbloquearUsuario(_usu)
            Response.Redirect("administrarUsuarios.aspx")
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try

    End Sub

    Protected Sub btn_Editar_Command(sender As Object, e As CommandEventArgs)
        Try
            Dim bll As New BLL.clsUsuario
            Dim _usu As New Servicios.Usuario
            _usu.ID = CInt(sender.CommandArgument)
            _usu = bll.RecuperarUsuario(_usu)
            Session("EditarUsuario") = _usu
            Response.Redirect("editarUsuario.aspx")
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try

    End Sub

    Protected Sub btn_Eliminar_Click(sender As Object, e As ImageClickEventArgs)
        Try
            Dim bll As New BLL.clsUsuario
            Dim _usu As New Servicios.Usuario
            _usu.ID = CInt(sender.CommandArgument)
            _usu = bll.RecuperarUsuario(_usu)
            bll.EliminarUsuario(_usu)
            Response.Redirect("administrarUsuarios.aspx")
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
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
    Public Function RecuperarUsuario() As Servicios.Usuario
        Dim resultado As New Servicios.Usuario
        resultado = DirectCast(Session("Usuario"), Servicios.Usuario)
        Return resultado
    End Function
    Public Sub ocultarDivs()
        Me.correcto.Visible = False
        Me.error.Visible = False
    End Sub
End Class