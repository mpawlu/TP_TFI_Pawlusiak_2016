Namespace MPP
    Public Class Slide
        Public Function Guardar(ByVal _Slide As EE.Slide, ByVal _Seccion As EE.Informativa) As Boolean
            Dim oDatos As New DAL.Datos
            Dim resultado As Boolean
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Seccion", _Seccion.ID)
            hdatos.Add("@Titulo", _Slide.Titulo)
            If Not _Slide.Subtitulo Like "" Then
                hdatos.Add("@Subtitulo", _Slide.Subtitulo)
            Else
                hdatos.Add("@Subtitulo", DBNull.Value)
            End If

            If _Slide.GetType() Is GetType(EE.TipoA) Then
                Dim sa As New EE.TipoA
                sa = _Slide
                hdatos.Add("@Texto", sa.Texto)
                hdatos.Add("@Tipo", "A")
                hdatos.Add("@URL_Imagen", DBNull.Value)
                hdatos.Add("@URL_Video", DBNull.Value)
                hdatos.Add("@TextoPie", DBNull.Value)
            ElseIf _Slide.GetType() Is GetType(EE.TipoB) Then
                Dim sb As New EE.TipoB
                sb = _Slide
                hdatos.Add("@Texto", DBNull.Value)
                hdatos.Add("@Tipo", "B")
                hdatos.Add("@URL_Imagen", sb.Imagen)
                hdatos.Add("@URL_Video", DBNull.Value)
                If Not sb.Pie Like "" Then
                    hdatos.Add("@TextoPie", sb.Pie)
                Else
                    hdatos.Add("@TextoPie", DBNull.Value)
                End If
            ElseIf _Slide.GetType() Is GetType(EE.TipoC) Then
                Dim sc As New EE.TipoC
                sc = _Slide
                hdatos.Add("@Texto", DBNull.Value)
                hdatos.Add("@Tipo", "C")
                hdatos.Add("@URL_Imagen", DBNull.Value)
                hdatos.Add("@URL_Video", sc.Video)
                hdatos.Add("@TextoPie", DBNull.Value)
                End If

                resultado = oDatos.Escribir("s_Slide_Crear", hdatos)

                Return resultado
        End Function
        Public Function Consultar(ByVal _seccion As EE.Informativa) As List(Of EE.Slide)
            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim dt As New DataTable
            Dim oSlides As New List(Of EE.Slide)
            Dim hdatos As New Hashtable

            hdatos.Add("ID_Seccion", _seccion.ID)
            DS = oDatos.Leer("s_Slide_ConsultarXSeccion", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then
                For Each Item As DataRow In DS.Tables(0).Rows
                    Dim oSlide As New EE.Slide
                    If Item("Tipo") = "A" Then

                    ElseIf Item("Tipo") = "B" Then

                    ElseIf Item("Tipo") = "C" Then

                    End If
                Next
            End If

        End Function
    End Class
End Namespace

