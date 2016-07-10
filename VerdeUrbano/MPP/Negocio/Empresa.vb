Namespace MPP
    Public Class Empresa
        Public Function Guardar(ByVal queEmpresa As EE.Empresa) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@CUIT", queEmpresa.CUIT)
            hdatos.Add("@Nombre", queEmpresa.Nombre)
            hdatos.Add("@FechaAlta", queEmpresa.FechaAlta)
            hdatos.Add("@Tel", queEmpresa.Telefono)
            hdatos.Add("@Email", queEmpresa.Email)
            hdatos.Add("@Direccion", queEmpresa.Direccion)

            resultado = oDatos.Escribir("s_Empresa_Crear", hdatos)
            Return resultado
        End Function

        Public Function Listar() As List(Of EE.Empresa)
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oEmp As EE.Empresa
            Dim oListaEmpresas As New List(Of EE.Empresa)

            DS = oDatos.Leer("s_Empresa_Listar", Nothing)

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
                    oListaEmpresas.Add(oEmp)
                Next
                Return oListaEmpresas
            Else
                Return Nothing
            End If
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

