Namespace MPP
    Public Class CursoAsignado
        Function ConsultarRepFinalizadas(ByVal _curso As EE.Curso) As List(Of EE.CursoAsignado)
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim resultado As New List(Of EE.CursoAsignado)
            Dim oCurAsig As EE.CursoAsignado
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Curso", _curso.ID)

            DS = oDatos.Leer("s_CursoAsignado_RepFinalizadas", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oCurAsig = New EE.CursoAsignado
                    oCurAsig.Curso = _curso

                    Dim oUsuMPP As New MPP.clsUsuario
                    Dim oEmp As New Servicios.Usuario
                    oEmp.ID = Item("ID_Empleado")
                    oCurAsig.Empleado = oUsuMPP.ConsultarUsuario(oEmp)

                    Select Case Item("ID_Estado")
                        Case 1
                            oCurAsig.Estado = New EE.EnCurso
                        Case 2
                            oCurAsig.Estado = New EE.EnCursoVencido
                        Case 3
                            oCurAsig.Estado = New EE.Finalizado
                        Case 4
                            oCurAsig.Estado = New EE.Pendiente
                        Case 5
                            oCurAsig.Estado = New EE.PendienteVencido
                    End Select

                    oCurAsig.FechaAsignacion = Item("Fecha_Asignacion")
                    oCurAsig.FechaVencimiento = Item("Fecha_Vencimiento")
                    oCurAsig.Intentos = Item("Intento")
                    oCurAsig.ResultadoObtenido = Item("Resultado")
                    oCurAsig.Aprobado = Item("Aprobado")
                    resultado.Add(oCurAsig)
                Next
                Return resultado
            Else
            End If

        End Function
    End Class
End Namespace

