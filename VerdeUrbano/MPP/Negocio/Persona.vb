﻿Namespace MPP
    Public Class Persona
        Public Function Listar(ByVal _empresa As EE.Empresa) As List(Of EE.Persona)

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oPer As EE.Persona
            Dim oListaEmpleados As New List(Of EE.Persona)

            hdatos.Add("@ID_Empresa", _empresa.ID)

            DS = oDatos.Leer("s_Persona_ConsultarXEmpresa", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oPer = New EE.Persona
                    oPer.DNI = Item("DNI")
                    oPer.Nombres = Item("Nombres")
                    oPer.Telefono = Item("Tel")
                    oPer.Apellido = Item("Apellido")

                    Dim oUsuMPP As New MPP.clsUsuario
                    Dim oUsu As New Servicios.Usuario
                    oUsu.DNI = Item("DNI")
                    oPer.Usuario = oUsuMPP.ConsultarUsuarioporDNI(oUsu)

                    Dim oEmpMPP As New MPP.Empresa
                    Dim oEmp As New EE.Empresa
                    oEmp.ID = Item("ID_Empresa")
                    oPer.Empresa = oEmpMPP.Consultar(oEmp)

                    oListaEmpleados.Add(oPer)
                Next
                Return oListaEmpleados
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace

