Namespace MPP
    Public Class Bitacora
        Public Function CrearEvento(ByVal Bitacora As Servicios.clsBitacora) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@ID_Usuario", Bitacora.Usuario.ID)
            hdatos.Add("@TipoOperacion", CInt(Bitacora.TipoOperacion))
            hdatos.Add("@FechaHora", Bitacora.FechaHora)
            hdatos.Add("@Descripcion", Bitacora.DescripcionEvento)
            hdatos.Add("@DVH", MPP.DigitoVerificador.CalcularDVH(Bitacora.StringDVH))

            resultado = oDatos.Escribir("s_Bitacora_Crear", hdatos)


            Return resultado

        End Function

        Public Function ListarBitacora(ByVal pDesde As Integer) As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora
            Dim hdatos As New Hashtable

            hdatos.Add("@Desde", pDesde)

            DS = oDatos.Leer("s_Bitacora_ListarTodos", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oBita = New Servicios.clsBitacora
                    oBita.ID_Evento = Item("ID_Evento")
                    Dim oUsu As New MPP.clsUsuario
                    Dim oUsuServ As New Servicios.Usuario
                    oUsuServ.ID = Item("ID_Usuario")
                    oBita.Usuario = oUsu.ConsultarUsuario(oUsuServ)
                    oBita.TipoOperacion = Item("TipoOperacion")
                    oBita.FechaHora = Item("FechaHora")
                    oBita.DescripcionEvento = Item("DescripcionEvento")

                    listaBitacora.Add(oBita)
                Next

                Return listaBitacora

            Else
                Return Nothing
            End If
        End Function

#Region "Filtros de Bitacora"
        Public Function ListarBitacora(ByVal paramFecha As Date, ByVal pDesde As Integer) As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora
            Dim hdatos As New Hashtable

            hdatos.Add("@Fecha", paramFecha)
            hdatos.Add("@Desde", pDesde)

            DS = oDatos.Leer("s_Bitacora_ListarFecha", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oBita = New Servicios.clsBitacora
                    oBita.ID_Evento = Item("ID_Evento")
                    Dim oUsu As New MPP.clsUsuario
                    Dim oUsuServ As New Servicios.Usuario
                    oUsuServ.ID = Item("ID_Usuario")
                    oBita.Usuario = oUsu.ConsultarUsuario(oUsuServ)
                    oBita.TipoOperacion = Item("TipoOperacion")
                    oBita.FechaHora = Item("FechaHora")
                    oBita.DescripcionEvento = Item("DescripcionEvento")

                    listaBitacora.Add(oBita)
                Next

                Return listaBitacora

            Else
                Return Nothing
            End If
        End Function

        Public Function ListarBitacora(ByVal paramOperacion As Integer, ByVal pDesde As Integer) As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora
            Dim hdatos As New Hashtable
            hdatos.Add("@Operacion", paramOperacion)
            hdatos.Add("@Desde", pDesde)

            DS = oDatos.Leer("s_Bitacora_ListarOperacion", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oBita = New Servicios.clsBitacora
                    oBita.ID_Evento = Item("ID_Evento")
                    Dim oUsu As New MPP.clsUsuario
                    Dim oUsuServ As New Servicios.Usuario
                    oUsuServ.ID = Item("ID_Usuario")
                    oBita.Usuario = oUsu.ConsultarUsuario(oUsuServ)
                    oBita.TipoOperacion = Item("TipoOperacion")
                    oBita.FechaHora = Item("FechaHora")
                    oBita.DescripcionEvento = Item("DescripcionEvento")

                    listaBitacora.Add(oBita)
                Next

                Return listaBitacora

            Else
                Return Nothing
            End If
        End Function

        Public Function ListarBitacora(ByVal paramUsuario As Servicios.Usuario, ByVal pDesde As Integer) As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Usuario", paramUsuario.ID)
            hdatos.Add("@Desde", pDesde)

            DS = oDatos.Leer("s_Bitacora_ListarUsuario", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oBita = New Servicios.clsBitacora
                    oBita.ID_Evento = Item("ID_Evento")
                    Dim oUsu As New MPP.clsUsuario
                    Dim oUsuServ As New Servicios.Usuario
                    oUsuServ.ID = Item("ID_Usuario")
                    oBita.Usuario = oUsu.ConsultarUsuario(oUsuServ)
                    oBita.TipoOperacion = Item("TipoOperacion")
                    oBita.FechaHora = Item("FechaHora")
                    oBita.DescripcionEvento = Item("DescripcionEvento")

                    listaBitacora.Add(oBita)
                Next

                Return listaBitacora

            Else
                Return Nothing
            End If
        End Function

        Public Function ListarBitacora(ByVal paramFecha As Date, ByVal paramOperacion As Integer, ByVal pDesde As Integer) As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora
            Dim hdatos As New Hashtable

            hdatos.Add("@Fecha", paramFecha)
            hdatos.Add("@Operacion", paramOperacion)
            hdatos.Add("@Desde", pDesde)

            DS = oDatos.Leer("s_Bitacora_ListarFechaOperacion", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oBita = New Servicios.clsBitacora
                    oBita.ID_Evento = Item("ID_Evento")
                    Dim oUsu As New MPP.clsUsuario
                    Dim oUsuServ As New Servicios.Usuario
                    oUsuServ.ID = Item("ID_Usuario")
                    oBita.Usuario = oUsu.ConsultarUsuario(oUsuServ)
                    oBita.TipoOperacion = Item("TipoOperacion")
                    oBita.FechaHora = Item("FechaHora")
                    oBita.DescripcionEvento = Item("DescripcionEvento")

                    listaBitacora.Add(oBita)
                Next

                Return listaBitacora

            Else
                Return Nothing
            End If
        End Function

        Public Function ListarBitacora(ByVal paramUsuario As Servicios.Usuario, ByVal paramOperacion As Integer, ByVal pDesde As Integer) As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Usuario", paramUsuario.ID)
            hdatos.Add("@Operacion", paramOperacion)
            hdatos.Add("@Desde", pDesde)

            DS = oDatos.Leer("s_Bitacora_ListarUsuarioOperacion", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oBita = New Servicios.clsBitacora
                    oBita.ID_Evento = Item("ID_Evento")
                    Dim oUsu As New MPP.clsUsuario
                    Dim oUsuServ As New Servicios.Usuario
                    oUsuServ.ID = Item("ID_Usuario")
                    oBita.Usuario = oUsu.ConsultarUsuario(oUsuServ)
                    oBita.TipoOperacion = Item("TipoOperacion")
                    oBita.FechaHora = Item("FechaHora")
                    oBita.DescripcionEvento = Item("DescripcionEvento")

                    listaBitacora.Add(oBita)
                Next

                Return listaBitacora

            Else
                Return Nothing
            End If
        End Function

        Public Function ListarBitacora(ByVal paramUsuario As Servicios.Usuario, ByVal paramFecha As Date, ByVal pDesde As Integer) As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Usuario", paramUsuario.ID)
            hdatos.Add("@Fecha", paramFecha)
            hdatos.Add("@Desde", pDesde)

            DS = oDatos.Leer("s_Bitacora_ListarUsuarioFecha", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oBita = New Servicios.clsBitacora
                    oBita.ID_Evento = Item("ID_Evento")
                    Dim oUsu As New MPP.clsUsuario
                    Dim oUsuServ As New Servicios.Usuario
                    oUsuServ.ID = Item("ID_Usuario")
                    oBita.Usuario = oUsu.ConsultarUsuario(oUsuServ)
                    oBita.TipoOperacion = Item("TipoOperacion")
                    oBita.FechaHora = Item("FechaHora")
                    oBita.DescripcionEvento = Item("DescripcionEvento")

                    listaBitacora.Add(oBita)
                Next

                Return listaBitacora

            Else
                Return Nothing
            End If
        End Function

        Public Function ListarBitacora(ByVal paramUsuario As Servicios.Usuario, ByVal paramFecha As Date, ByVal paramOperacion As Integer, ByVal pDesde As Integer) As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Usuario", paramUsuario.ID)
            hdatos.Add("@Fecha", paramFecha)
            hdatos.Add("@Operacion", paramOperacion)
            hdatos.Add("@Desde", pDesde)

            DS = oDatos.Leer("s_Bitacora_ListarUsuarioFechaOperacion", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oBita = New Servicios.clsBitacora
                    oBita.ID_Evento = Item("ID_Evento")
                    Dim oUsu As New MPP.clsUsuario
                    Dim oUsuServ As New Servicios.Usuario
                    oUsuServ.ID = Item("ID_Usuario")
                    oBita.Usuario = oUsu.ConsultarUsuario(oUsuServ)
                    oBita.TipoOperacion = Item("TipoOperacion")
                    oBita.FechaHora = Item("FechaHora")
                    oBita.DescripcionEvento = Item("DescripcionEvento")

                    listaBitacora.Add(oBita)
                Next

                Return listaBitacora

            Else
                Return Nothing
            End If
        End Function
#End Region
        Public Function UltimoID() As Integer

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora


            DS = oDatos.Leer("s_Bitacora_ConsultarUltimoID", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                Return oBita.ID_Evento = DS.Tables(0).Rows(0).Item("ID_Evento")

            Else
                    Return Nothing
            End If
        End Function



    End Class
End Namespace
