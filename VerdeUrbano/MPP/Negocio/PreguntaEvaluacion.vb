Namespace MPP
    Public Class PreguntaEvaluacion
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

    End Class
End Namespace

