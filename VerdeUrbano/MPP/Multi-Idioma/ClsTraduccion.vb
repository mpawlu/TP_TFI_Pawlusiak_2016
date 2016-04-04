Imports EE

Namespace MPP
    Public Class ClsTraduccion
        Public Function CrearTraduccion(ByVal traduccion As EE.clsTraduccion) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@ID_Idioma", traduccion.Idioma.ID)
            hdatos.Add("@ID_leyenda", traduccion.Leyenda.ID)
            hdatos.Add("@ID_Traduccion", traduccion.Traduccion)


            resultado = oDatos.Escribir("s_Traduccion_Crear", hdatos)

            Return resultado

        End Function
        Public Function ConsultarTraduccion(ByVal oTraduccion As EE.clsTraduccion) As EE.clsTraduccion
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oTrad As New EE.clsTraduccion


            hdatos.Add("@ID_Idioma", oTraduccion.Idioma.ID)
            hdatos.Add("@ID_Leyenda", oTraduccion.Leyenda.ID)

            '   If DS.Tables(0).Rows.Count > 0 Then

            DS = oDatos.Leer("s_Traduccion_Listar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oTrad = New EE.clsTraduccion
                    oTrad.Idioma.ID = Item("ID_Idioma")
                    oTrad.Idioma.Descripcion = Item("Descripcion")
                    oTrad.Leyenda.ID = Item("ID_Leyenda")
                    oTrad.Leyenda.Leyenda = Item("Leyenda")
                    oTrad.Traduccion = Item("Traduccion")

                Next
                Return oTrad
            Else
                Return Nothing
            End If
        End Function

        Public Function ListarTraducciones(ByVal Idioma As EE.clsIdioma) As List(Of EE.clsTraduccion)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim hdatos As New Hashtable
            Dim listaTraducciones As New List(Of EE.clsTraduccion)
            Dim dt As New DataTable
            Dim oTrad As EE.clsTraduccion

            hdatos.Add("@ID_Idioma", Idioma.ID)
            DS = oDatos.Leer("s_TraduccionesPorIdioma_Listar", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oTrad = New EE.clsTraduccion
                    oTrad.Idioma.ID = Item("ID_Idioma")
                    oTrad.Idioma.Descripcion = Item("Descripcion")
                    oTrad.Leyenda.ID = Item("ID_Leyenda")
                    oTrad.Leyenda.Leyenda = Item("Leyenda")
                    oTrad.Traduccion = Item("Traduccion")

                    listaTraducciones.Add(oTrad)
                Next

                Return listaTraducciones

            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace

