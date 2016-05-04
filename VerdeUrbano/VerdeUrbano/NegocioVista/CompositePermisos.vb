Public Class CompositePermisos
    Public Shared Sub chequearTreeView(ByVal _permiso As Servicios.PermisoCompuesto, ByRef _tree As TreeView)
        For Each _node As TreeNode In _tree.Nodes
            If _node.Text = _permiso.Descripcion Then
                _node.Checked = True
            End If
        Next
    End Sub

    Public Shared Sub armarTreeView(ByVal _listapermisos As List(Of Servicios.PermisoBase), ByRef _tree As TreeView)
        Try
            For Each _per As Servicios.PermisoBase In _listapermisos
                _tree.Nodes.Add(New TreeNode(_per.Descripcion))
                _tree.Nodes(_tree.Nodes.Count - 1).ShowCheckBox = True
                If _per.TieneHijos = True Then
                    agregarNodoHijo(_per, _tree.Nodes(_tree.Nodes.Count - 1))
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Shared Sub agregarNodoHijo(ByVal _listaCompuesto As Servicios.PermisoCompuesto, ByRef _treenodo As TreeNode)
        For Each _per As Servicios.PermisoBase In _listaCompuesto.ListaPermisos
            _treenodo.ChildNodes.Add(New TreeNode(_per.Descripcion))
            If Not _per.Url = Nothing And _listaCompuesto.Url <> Nothing Then
                _treenodo.ChildNodes(_treenodo.ChildNodes.Count - 1).ShowCheckBox = True
            End If
            If _per.TieneHijos = True Then
                agregarNodoHijo(_per, _treenodo.ChildNodes(_treenodo.ChildNodes.Count - 1))
            End If
        Next
    End Sub

    Public Shared Function retornarIndice(ByVal _listapermisos As List(Of Servicios.PermisoBase), ByVal _nombre As String) As Integer
        For Each _per As Servicios.PermisoBase In _listapermisos
            If _per.Descripcion = _nombre Then
                Return _listapermisos.IndexOf(_per)
            End If
        Next
        Return 0
    End Function

    Public Shared Function revisarLista(ByVal _per As Servicios.PermisoBase, _listaper As List(Of Servicios.PermisoBase)) As Boolean
        If _listaper.Contains(_per) Then
            Return False
        Else
            Return True
        End If
    End Function

End Class
