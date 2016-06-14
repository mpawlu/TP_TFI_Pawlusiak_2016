Namespace MPP
    Public Class Empresa
        Public Function Listar() As List(Of EE.Empresa)

        End Function
        Public Function Consultar(ByVal _empresa As EE.Empresa) As EE.Empresa
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oEmp As EE.Empresa

            hdatos.Add("@ID_Empresa", _empresa.ID)

            DS = oDatos.Leer("s_Empresa_Consultar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oEmp = New EE.Empresa
                    oEmp.ID = Item("ID_Empresa")
                    oEmp.Nombre = Item("Nombre")
                    oEmp.FechaAlta = Item("Fecha_Ata")
                    oEmp.CUIT = Item("CUIT")
                    oEmp.Telefono = Item("Telefono")
                    oEmp.Direccion = Item("Direccion")
                    oEmp.Email = Item("Email")
                    Return oEmp
                Next
            Else
                Return Nothing
            End If

        End Function
    End Class
End Namespace

