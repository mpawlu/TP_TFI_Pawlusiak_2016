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
        Public Function ConsultarUltima() As EE.Informativa
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oInf As New EE.Informativa

            DS = oDatos.Leer("s_Seccion_ConsultarUltimo", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then
                For Each Item As DataRow In DS.Tables(0).Rows
                    oInf.ID = Item("ID_Seccion")
                    oInf.Titulo = Item("Titulo")
                    oInf.Descripcion = Item("Descripcion")
                Next
                Return oInf
            Else
                Return Nothing
            End If
        End Function
        Public Function Consultar(ByVal _seccion As EE.Informativa) As EE.Informativa
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oInf As New EE.Informativa
            Dim hdatos As New Hashtable

            hdatos.Add("ID_Seccion", _seccion.ID)
            DS = oDatos.Leer("s_Seccion_Consultar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then
                For Each Item As DataRow In DS.Tables(0).Rows
                    oInf.ID = Item("ID_Seccion")
                    oInf.Titulo = Item("Titulo")
                    oInf.Descripcion = Item("Descripcion")
                    Dim oSlides As New List(Of EE.Slide)
                    Dim oSlideMPP As New MPP.Slide
                    oSlides = oSlideMPP.Consultar(oInf)
                    oInf.Slides = oSlides
                Next
                Return oInf
            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace

