Namespace MPP
    Public Class Seccion
        Public Function Guardar(ByVal _Seccion As EE.Informativa, ByVal _curso As EE.Curso) As Boolean
            Dim hdatos As New Hashtable
            Dim oDatos As New DAL.Datos
            Dim Resultado As Boolean
            hdatos.Add("@ID_Curso", _curso.ID)
            hdatos.Add("@Titulo", _Seccion.Titulo)
            hdatos.Add("@Descripcion", _Seccion.Descripcion)

            Resultado = oDatos.Escribir("s_Seccion_Crear", hdatos)

            Return Resultado

        End Function
    End Class
End Namespace

