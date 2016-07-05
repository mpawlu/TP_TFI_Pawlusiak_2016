Imports EE
Namespace MPP

    Public Class clsLocalidad

        Public Function ListarLocalidades() As List(Of EE.clsLocalidad)
            Dim oDatos As New DAL.Datos
            Dim Ds As New DataSet
            Dim listlocalidades As New List(Of EE.clsLocalidad)

            Ds = oDatos.Leer("s_Localidades_Listar", Nothing)

            If Ds.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In Ds.Tables(0).Rows
                    Dim oLoca As New EE.clsLocalidad
                    oLoca.Id = Item(0)
                    oLoca.Descripcion = Item(1)
                    listlocalidades.Add(oLoca)
                Next

                Return listlocalidades
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace


