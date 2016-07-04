Namespace MPP
    Public Class Evaluacion
        Public Function Consultar(ByVal _curso As EE.Curso) As EE.Evaluacion
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oEva As New EE.Evaluacion
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Curso", _curso.ID)
            DS = oDatos.Leer("s_Curso_ConsultarEvaluacion", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then
                For Each Item As DataRow In DS.Tables(0).Rows
                    oEva.ID = Item("ID_Evaluacion")
                    oEva.Titulo = Item("Titulo")
                    If IsDBNull(Item("Subtitulo")) = True Then
                        oEva.Subtitulo = Nothing
                    Else
                        oEva.Subtitulo = Item("Subtitulo")
                    End If
                    Dim oPregMPP As New MPP.PreguntaEvaluacion
                    oEva.Preguntas = oPregMPP.Consultar(oEva)
                Next
                Return oEva
            Else
                Return Nothing
            End If
        End Function
        Public Function Guardar(ByVal _curso As EE.Curso) As Boolean
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean
            Dim oPregMPP As New MPP.PreguntaEvaluacion
            hdatos.Add("@Titulo", _curso.Evaluacion.Titulo)
            If Not _curso.Evaluacion.Subtitulo Is Nothing Then
                hdatos.Add("@Subtitulo", _curso.Evaluacion.Subtitulo)
            Else
                hdatos.Add("@Subtitulo", DBNull.Value)
            End If
            resultado = oDatos.Escribir("s_Evaluacion_Crear", hdatos)
            If resultado = True Then
                Dim oEval As EE.Evaluacion
                Dim oEvalMPP As New MPP.Evaluacion
                oEval = oEvalMPP.ConsultarUltima()
                For Each p As EE.Pregunta In _curso.Evaluacion.Preguntas
                    If oPregMPP.Guardar(p, oEval) = True Then
                        resultado = True
                    Else
                        resultado = False
                        Exit For
                    End If
                Next
            End If
            Return resultado

        End Function
        Public Function ConsultarUltima() As EE.Evaluacion
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oEva As New EE.Evaluacion

            DS = oDatos.Leer("s_Evaluacion_ConsultarUltima", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then
                For Each Item As DataRow In DS.Tables(0).Rows
                    oEva.ID = Item("ID_Evaluacion")
                    oEva.Titulo = Item("Titulo")
                    If IsDBNull(Item("Subtitulo")) = True Then
                        oEva.Subtitulo = Nothing
                    Else
                        oEva.Subtitulo = Item("Subtitulo")
                    End If
                    Dim oPregMPP As New MPP.PreguntaEvaluacion
                    oEva.Preguntas = oPregMPP.Consultar(oEva)
                Next
                Return oEva
            End If
        End Function
    End Class
End Namespace

