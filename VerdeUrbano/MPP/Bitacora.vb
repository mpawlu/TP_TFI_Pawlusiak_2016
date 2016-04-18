Namespace MPP
    Public Class Bitacora
        Public Function CrearEvento(ByVal Bitacora As Servicios.clsBitacora) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@Usuario", Bitacora.Usuario.ID)
            hdatos.Add("@FechaHora", Bitacora.FechaHora)
            hdatos.Add("@Usuario", Bitacora.DescripcionEvento)
            hdatos.Add("@DVH", "ASFDDFD")

            resultado = oDatos.Escribir("s_Bitacora_Crear", hdatos)

            Return resultado

        End Function

        Public Function ListarBitacora() As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora

            DS = oDatos.Leer("s_Bitacora_ListarTodos", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oBita = New Servicios.clsBitacora
                    oBita.ID_Evento = Item("ID_Evento")
                    oBita.Usuario.ID = Item("ID_Usuario")

                    oBita.FechaHora = Item("Pass")
                    oBita.DescripcionEvento = Item("Evento")

                    listaBitacora.Add(oBita)
                Next

                Return listaBitacora

            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace
