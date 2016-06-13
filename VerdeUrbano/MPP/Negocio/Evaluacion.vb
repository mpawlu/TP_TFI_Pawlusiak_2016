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
    End Class
End Namespace

