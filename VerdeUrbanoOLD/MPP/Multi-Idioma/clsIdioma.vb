Namespace MPP
    Public Class clsIdioma
        Public Function CrearIdioma(ByVal idioma As Servicios.clsIdioma) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@Descripcion", idioma.Descripcion)
            hdatos.Add("@DVH", "asd")


            resultado = oDatos.Escribir("s_Idioma_Crear", hdatos)

            Return resultado

        End Function
        Public Function ListarIdiomas() As List(Of Servicios.clsIdioma)
            Dim oDatos As New DAL.Datos
            Dim Ds As New DataSet
            Dim listIdiomas As New List(Of Servicios.clsIdioma)

            Ds = oDatos.Leer("s_Idioma_ListarTodos", Nothing)

            If Ds.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In Ds.Tables(0).Rows
                    Dim oIdioma As New Servicios.clsIdioma
                    oIdioma.ID = Item(0)
                    oIdioma.Descripcion = Item(1)
                    oIdioma.DVH = "asdasd"
                    listIdiomas.Add(oIdioma)
                Next

                Return listIdiomas
            Else
                Return Nothing
            End If
        End Function
        Public Function ConsultarIdioma(ByVal oIdioma As Servicios.clsIdioma) As Servicios.clsIdioma

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oId As New Servicios.clsIdioma

            hdatos.Add("@ID_Idioma", oIdioma.ID)

            DS = oDatos.Leer("s_Idioma_Consultar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oId.ID = Item("ID_Idioma")
                    oId.Descripcion = Item("Descripcion")

                Next
                Return oId
            Else
                Return Nothing
            End If
        End Function
        Public Function ConsultarIdioma(ByVal oNombreIdioma As String) As Servicios.clsIdioma

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oId As New Servicios.clsIdioma

            hdatos.Add("@Descripcion", oNombreIdioma)

            DS = oDatos.Leer("s_Idioma_ConsultarPorNombre", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oId.ID = Item("ID_Idioma")
                    oId.Descripcion = Item("Descripcion")

                Next
                Return oId
            Else
                Return Nothing
            End If
        End Function
        Public Function chequearNombre(ByVal oNombre As String) As Boolean
            Try
                Dim oDatos As New DAL.Datos
                Dim hdatos As New Hashtable
                Dim DS As New DataSet
                Dim oUsu As New servicios.Usuario
                hdatos.Add("@NombreIdioma", oNombre)
                DS = oDatos.Leer("s_Idioma_ChequearNombre", hdatos)
                If DS.Tables(0).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception

            End Try
        End Function
    End Class
End Namespace

