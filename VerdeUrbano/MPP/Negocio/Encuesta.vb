Namespace MPP
    Public Class Encuesta
        Public Function Consultar(ByVal _Curso As EE.Curso) As EE.Encuesta
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oEnc As EE.Encuesta
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Curso", _Curso.ID)

            DS = oDatos.Leer("s_Encuesta_Consultar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oEnc = New EE.Encuesta
                    Dim oCursoMPP As New MPP.Curso
                    Dim oCurso As New EE.Curso
                    oCurso.ID = _Curso.ID
                    oEnc.Curso = oCursoMPP.Consultar(oCurso)

                    Dim oPregMPP As New MPP.PreguntaEncuesta
                    oEnc.Preguntas = oPregMPP.ConsultarPreguntas
                    Dim oCur As New EE.Curso

                Next
            End If

        End Function
    End Class
End Namespace

