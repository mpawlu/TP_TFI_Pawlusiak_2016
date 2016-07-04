Namespace MPP
    Public Class PreguntaEvaluacion
        Public Function Guardar(ByVal _pregunta As EE.Pregunta, ByVal _Eval As EE.Evaluacion) As Boolean
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@ID_Evaluacion", _Eval.ID)
            hdatos.Add("@Texto", _pregunta.Pregunta)
            hdatos.Add("@Valor", _pregunta.Valor)

            resultado = oDatos.Escribir("s_PreguntaEval_Crear", hdatos)

            If resultado = True Then
                Dim oPreg As New EE.Pregunta
                oPreg = Me.ConsultarUltima
                Dim oOpMPP As New MPP.OpcionPregEval
                For Each op As EE.Opcion_PregCurso In _pregunta.Opciones
                    If oOpMPP.Guardar(op, oPreg) = True Then
                        resultado = True
                    Else
                        resultado = False
                        Exit For
                    End If
                Next
            End If
            Return resultado
        End Function
        Public Function Consultar(ByVal _evaluacion As EE.Evaluacion) As List(Of EE.Pregunta)
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oPreg As EE.Pregunta
            Dim oPreguntas As New List(Of EE.Pregunta)
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Evaluacion", _evaluacion.ID)
            DS = oDatos.Leer("s_Pregunta_ListarXEval", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then
                For Each Item As DataRow In DS.Tables(0).Rows
                    oPreg = New EE.Pregunta
                    oPreg.ID = Item("ID_Pregunta")
                    oPreg.Pregunta = Item("Texto")
                    oPreg.Valor = Item("Valor")
                    Dim oOpcMPP As New MPP.OpcionPregEval
                    oPreg.Opciones = oOpcMPP.Consultar(oPreg)
                    oPreguntas.Add(oPreg)
                Next
                Return oPreguntas
            Else
                Return Nothing
            End If

        End Function

        Public Function Consultar(ByVal _preg As EE.Pregunta) As EE.Pregunta
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oPreg As EE.Pregunta
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Pregunta", _preg.ID)
            DS = oDatos.Leer("s_Pregunta_Consultar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then
                For Each Item As DataRow In DS.Tables(0).Rows
                    oPreg = New EE.Pregunta
                    oPreg.ID = Item("ID_Pregunta")
                    oPreg.Pregunta = Item("Texto")
                    oPreg.Valor = Item("Valor")
                    Dim oOpcMPP As New MPP.OpcionPregEval
                    oPreg.Opciones = oOpcMPP.Consultar(oPreg)
                    Return oPreg
                Next
            Else
                Return Nothing
            End If

        End Function
        Public Function ConsultarUltima() As EE.Pregunta
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oPreg As EE.Pregunta

            DS = oDatos.Leer("s_Pregunta_ConsultarUltima", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then
                For Each Item As DataRow In DS.Tables(0).Rows
                    oPreg = New EE.Pregunta
                    oPreg.ID = Item("ID_Pregunta")
                    oPreg.Pregunta = Item("Texto")
                    oPreg.Valor = Item("Valor")
                    Dim oOpcMPP As New MPP.OpcionPregEval
                    oPreg.Opciones = oOpcMPP.Consultar(oPreg)
                    Return oPreg
                Next
            Else
                Return Nothing
            End If
        End Function

    End Class
End Namespace

