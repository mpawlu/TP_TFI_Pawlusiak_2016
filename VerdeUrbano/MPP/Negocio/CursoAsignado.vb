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
                    Dim oEncAsigMPP As New MPP.EncuestaAsignada
                    oCurAsig.EncuestaAsignada = oEncAsigMPP.Consultar(oCurAsig)
                    resultado.Add(oCurAsig)
                Next
                Return resultado
            Else
            End If
        End Function
        Public Function Modificar(ByVal _CursoAsignado As EE.CursoAsignado) As Boolean
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@ID_Curso", _CursoAsignado.Curso.ID)
            hdatos.Add("@ID_Usuario", _CursoAsignado.Empleado.ID)
            hdatos.Add("@ID_Estado", _CursoAsignado.Estado.ID)
            hdatos.Add("@Fecha_Asignacion", _CursoAsignado.FechaAsignacion)
            hdatos.Add("@Fecha_Vencimiento", _CursoAsignado.FechaVencimiento)
            hdatos.Add("@Progreso", _CursoAsignado.Progreso)
            hdatos.Add("@Intento", _CursoAsignado.Intentos)
            hdatos.Add("@Resultado", _CursoAsignado.ResultadoObtenido)
            hdatos.Add("@Aprobado", _CursoAsignado.Aprobado)

            resultado = oDatos.Escribir("s_Curso_Asignado_Modificar", hdatos)

            Return resultado

        End Function
    End Class
End Namespace

