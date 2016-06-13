Namespace MPP
    Public Class PreguntaEncuesta
        Public Function ConsultarPreguntas() As List(Of EE.PreguntaEncuesta)
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oPreg As EE.PreguntaEncuesta
            Dim oListaPreg As New List(Of EE.PreguntaEncuesta)

            DS = oDatos.Leer("s_PreguntaEncuesta_Listar", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oPreg = New EE.PreguntaEncuesta
                    oPreg.ID_Pregunta = Item("ID_Pregunta")
                    oPreg.Pregunta = Item("Texto")

                    If IsDBNull(Item("Valor")) = True Then
                        oPreg.Valor = Nothing
                    Else
                        oPreg.Valor = Item("Valor")
                    End If
                    oPreg.Es_Choice = Item("EsChoice")
                    oListaPreg.Add(oPreg)

                Next
                Return oListaPreg

            End If
            Return Nothing

        End Function

        Public Function Consultar(ByVal _preg As EE.PreguntaEncuesta) As EE.PreguntaEncuesta
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oPreg As EE.PreguntaEncuesta
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Pregunta_Encuesta", _preg.ID_Pregunta)
            DS = oDatos.Leer("s_PreguntaEncuesta_Consultar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oPreg = New EE.PreguntaEncuesta
                    oPreg.ID_Pregunta = Item("ID_Pregunta")
                    oPreg.Pregunta = Item("Texto")

                    If IsDBNull(Item("Valor")) = True Then
                        oPreg.Valor = Nothing
                    Else
                        oPreg.Valor = Item("Valor")
                    End If
                    oPreg.Es_Choice = Item("EsChoice")
                    Return oPreg
                Next
            End If
            Return Nothing

        End Function
    End Class
End Namespace

