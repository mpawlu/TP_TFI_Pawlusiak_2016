﻿Public Class agregarUsuario
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If validaciones.validarPagina(Me) = False Then
            Response.Redirect("error.aspx")
        End If
        If Not IsPostBack Then
            CargarDDLIdioma()
            CargarDDLPerfil()
        End If
        Me.correcto.Visible = False
    End Sub

    Protected Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        Try
            validaciones.validarSubmit(Me, Me.error, Me.lbl_TituloError)
            If txtPass.Text = txtRepetirPass.Text Then
                If txtPass.Text.Length >= 6 Then
                    ''-----AGREGADO PARA PERSONA-----
                    Dim NuevaPersona As New EE.Persona
                    'NuevaPersona.Nombres '= txtnombres
                    'NuevaPersona.Apellido '= txtap
                    'NuevaPersona.Telefono ' = txttel
                    'NuevaPersona.Empresa '= comboEmpresa.value
                    NuevaPersona.DNI = txtDNI.Text
                    'NuevaPersona.Email '= txtEmail
                    Dim NuevoUsuario As New Servicios.Usuario
                    NuevoUsuario.NombreUsuario = txtNombre.Text
                    NuevoUsuario.Password = txtPass.Text
                    NuevoUsuario.DNI = CInt(txtDNI.Text)
                    Dim p As New Servicios.PermisoCompuesto
                    Dim usuBLL As New BLL.clsUsuario
                    p.ID = Me.ddl_Perfil.SelectedValue
                    NuevoUsuario.Perfil = p
                    'NuevoUsuario.Bloqueado = bloqueado.Checked
                    NuevoUsuario.FechaAlta = Today
                    NuevoUsuario.Editable = True
                    Dim I As New Servicios.clsIdioma
                    I.ID = ddl_idioma.SelectedValue
                    NuevoUsuario.Idioma = I
                    If usuBLL.chequearUsuario(NuevoUsuario) = False Then
                        NuevaPersona.Usuario = NuevoUsuario
                        Dim PerBLL As New BLL.Persona
                        If PerBLL.Guardar(NuevaPersona) = True Then
                            usuBLL.CrearUsuario(NuevoUsuario)
                            Me.correcto.Visible = True
                        End If
                    Else
                        Throw New Servicios.clsExcepcionUsuarioDuplicado
                    End If
                Else
                    Throw New Servicios.clsExcepcionPasswordCorto
                End If
            Else
                Throw New Servicios.clsExcepcionPasswordDiferentes
            End If
        Catch ex As Servicios.clsExcepcionCamposIncompletos
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Servicios.clsExcepcionPasswordDiferentes
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Servicios.clsExcepcionPasswordCorto
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Servicios.clsExcepcionUsuarioDuplicado
            Me.error.Visible = True
            Me.lbl_TituloError.Text = BLL.ClsTraduccion.Traducir(RecuperarUsuario, ex.ObtenerID)
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub

    Public Sub CargarDDLIdioma()
        Dim oIdioma As New List(Of Servicios.clsIdioma)
        Dim oIdiomaBLL As New BLL.clsIdioma
        oIdioma = oIdiomaBLL.ListarIdiomas()
        Me.ddl_idioma.DataSource = oIdioma
        Me.ddl_idioma.DataTextField = "Descripcion"
        Me.ddl_idioma.DataValueField = "ID"
        Me.ddl_idioma.DataBind()
    End Sub
    Public Sub CargarDDLPerfil()
        Dim oPerfil As New List(Of Servicios.PermisoCompuesto)
        Dim oPerfilBLL As New BLL.clsPermiso
        oPerfil = oPerfilBLL.ListarPerfiles()
        Me.ddl_Perfil.DataSource = oPerfil
        Me.ddl_Perfil.DataTextField = "Descripcion"
        Me.ddl_Perfil.DataValueField = "ID"
        Me.ddl_Perfil.DataBind()
    End Sub

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Response.Redirect("index.aspx")
    End Sub
    Public Function RecuperarUsuario() As Servicios.Usuario
        Dim resultado As New Servicios.Usuario
        resultado = DirectCast(Session("Usuario"), Servicios.Usuario)
        Return resultado
    End Function
End Class