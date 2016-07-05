Namespace MPP
    Public Class OpcionPregEval
        Public Function Guardar(ByVal _opcion As EE.Opcion_PregCurso, ByRef _pregunta As EE.Pregunta) As Boolean
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@ID_Pregunta", _pregunta.ID)
            hdatos.Add("@Texto", _opcion.Texto)
            hdatos.Add("@Correcta", _opcion.Correcta)

            resultado = oDatos.Escribir("s_Opcion_Crear", hdatos)

            Return resultado

        End Function
        Public Function Consultar(ByVal _preg As EE.Pregunta) As List(Of EE.Opcion_PregCurso)
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oOpc As EE.Opcion_PregCurso
            Dim oListaOpciones As New List(Of EE.Opcion_PregCurso)
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Pregunta", _preg.ID)
            DS = oDatos.Leer("s_Opcion_ListarXPreg", hdatos)
            If DS.Tables(0).Rows.Count > 0 Then
                For Each Item As DataRow In DS.Tables(0).Rows
                    oOpc = New EE.Opcion_PregCurso
                    oOpc.ID = Item("ID_Opcion")
                    oOpc.Texto = Item("Texto")
                    oOpc.Correcta = Item("Correcta")
                    oListaOpciones.Add(oOpc)
                Next
                Return oListaOpciones
            Else
                Return Nothing
            End If
        End Function
        Public Function Consultar(ByVal _opcion As EE.Opcion_PregCurso) As EE.Opcion_PregCurso
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oOpc As EE.Opcion_PregCurso
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Opcion", _opcion.ID)
            DS = oDatos.Leer("s_Opcion_Consultar", hdatos)
            If DS.Tables(0).Rows.Count > 0 Then
                For Each Item As DataRow In DS.Tables(0).Rows
                    oOpc = New EE.Opcion_PregCurso
                    oOpc.ID = Item("ID_Opcion")
                    oOpc.Texto = Item("Texto")
                    oOpc.Correcta = Item("Correcta")
                    Return oOpc
                Next

            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace

