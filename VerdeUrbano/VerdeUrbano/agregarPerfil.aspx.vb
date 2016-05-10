Public Class agregarPerfil
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Me.CargarTreeView()
        End If

    End Sub


    Private Sub CargarTreeView()
        Try
            Dim _listapermisos As New List(Of Servicios.PermisoBase)
            Dim _perfiles As New List(Of Servicios.PermisoCompuesto)
            Dim _bllPermiso As New BLL.clsPermiso
            _perfiles = _bllPermiso.ListarFamiliasDePerfiles
            For Each _perfil As Servicios.PermisoCompuesto In _perfiles
                armarTreeView(_perfil, Me.treeviewPermisos)
            Next
        Catch ex As Exception
            Me.error.Visible = True
            Me.lbl_TituloError.Text = ex.Message
        End Try
    End Sub


    Public Shared Sub chequearTreeView(ByVal _permiso As Servicios.PermisoCompuesto, ByRef _tree As TreeView)
        Try
            For Each _node As TreeNode In _tree.Nodes
                If _node.Text = _permiso.Descripcion Then
                    _node.Checked = True
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Public Shared Sub armarTreeView(ByVal _perfil As Servicios.PermisoCompuesto, ByRef _tree As TreeView)
        Try
            _tree.Nodes.Add(New TreeNode(_perfil.Descripcion))
            If _tree.Nodes.Count > 0 Then
                ' For Each _per As Servicios.PermisoBase In _perfil.ListaPermisos
                '  _tree.Nodes.Add(New TreeNode(_per.Descripcion))
                '  _tree.Nodes(_tree.Nodes.Count - 1).ShowCheckBox = True
                If _perfil.TieneHijos = True Then
                    agregarNodoHijo(_perfil, _tree.Nodes(_tree.Nodes.Count - 1))
                End If
                '  Next
            End If
        
        Catch ex As Exception
            Throw ex
        End Try
    End Sub



    Public Shared Sub agregarNodoHijo(ByVal _listaCompuesto As Servicios.PermisoCompuesto, ByRef _treenodo As TreeNode)
        Try
            For Each _per As Servicios.PermisoBase In _listaCompuesto.ListaPermisos
                _treenodo.ChildNodes.Add(New TreeNode(_per.Descripcion))
                If Not _per.Url = Nothing And _listaCompuesto.Url <> Nothing Then
                    '  _treenodo.ChildNodes(_treenodo.ChildNodes.Count - 1).ShowCheckBox = True
                End If
                If _per.TieneHijos = True Then
                    agregarNodoHijo(_per, _treenodo.ChildNodes(_treenodo.ChildNodes.Count - 1))
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Function retornarIndice(ByVal _listapermisos As List(Of Servicios.PermisoBase), ByVal _nombre As String) As Integer
        Try
            For Each _per As Servicios.PermisoBase In _listapermisos
                If _per.Descripcion = _nombre Then
                    Return _listapermisos.IndexOf(_per)
                End If
            Next
            Return 0
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Shared Function revisarLista(ByVal _per As Servicios.PermisoBase, _listaper As List(Of Servicios.PermisoBase)) As Boolean
        Try
            If _listaper.Contains(_per) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Public Function RecuperarUsuario() As Servicios.Usuario
        Dim resultado As New Servicios.Usuario
        resultado = DirectCast(Session("Usuario"), Servicios.Usuario)
        Return resultado
    End Function

    Protected Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Response.Redirect("index.aspx")
    End Sub
End Class