Namespace BLL
    Public Class Categoria
        Public Function ListarCategorias() As List(Of EE.Categoria)
            Dim mpp As New MPP.Categoria
            Return mpp.ListarCategorias()

        End Function
        Public Function ConsultarPorNombre(ByVal Nombre As String) As EE.Categoria

        End Function
        Public Sub Guardar(ByVal NuevaCat As EE.Categoria)

        End Sub
        Public Sub Modificar(ByVal NuevaCat As EE.Categoria)

        End Sub
        Sub New()

        End Sub


    End Class
End Namespace
