Namespace MPP
    Public Class Categoria
        Public Function ListarCategorias() As List(Of EE.Categoria)
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaCategoria As New List(Of EE.Categoria)
            Dim dt As New DataTable
            Dim oCat As EE.Categoria

            DS = oDatos.Leer("s_Categoria_ListarTodas", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oCat = New EE.Categoria
                    oCat.ID = Item("Id_Categoria")
                    oCat.Descripcion = Item("Descripcion")
                    listaCategoria.Add(oCat)
                    
                Next

                Return listaCategoria

            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace

