Namespace MPP
    Public Class Bitacora
        Public Function CrearEvento(ByVal Bitacora As Servicios.clsBitacora) As Boolean

            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@Usuario", Bitacora.Usuario.ID)
            hdatos.Add("@FechaHora", Bitacora.FechaHora)
            hdatos.Add("@Usuario", Bitacora.DescripcionEvento)
            hdatos.Add("@DVH", "ASFDDFD")

            resultado = oDatos.Escribir("s_Bitacora_Crear", hdatos)

            Return resultado

        End Function

        Public Function ListarBitacora() As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora

            DS = oDatos.Leer("s_Bitacora_ListarTodos", Nothing)

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
        Public Function ListarBitacora(ByVal paramFecha As Date) As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora
            Dim hdatos As New Hashtable

            hdatos.Add("@Fecha", paramFecha)

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

        Public Function ListarBitacora(ByVal paramOperacion As Integer) As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora
            Dim hdatos As New Hashtable
            hdatos.Add("@Operacion", paramOperacion)

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

        Public Function ListarBitacora(ByVal paramUsuario As Servicios.Usuario) As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Usuario", paramUsuario.ID)

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

        Public Function ListarBitacora(ByVal paramFecha As Date, ByVal paramOperacion As Integer) As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora
            Dim hdatos As New Hashtable

            hdatos.Add("@Fecha", paramFecha)
            hdatos.Add("@Operacion", paramOperacion)

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

        Public Function ListarBitacora(ByVal paramUsuario As Servicios.Usuario, ByVal paramOperacion As Integer) As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Usuario", paramUsuario.ID)
            hdatos.Add("@Operacion", paramOperacion)

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

        Public Function ListarBitacora(ByVal paramUsuario As Servicios.Usuario, ByVal paramFecha As Date) As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Usuario", paramUsuario.ID)
            hdatos.Add("@Fecha", paramFecha)

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

        Public Function ListarBitacora(ByVal paramUsuario As Servicios.Usuario, ByVal paramFecha As Date, ByVal paramOperacion As Integer) As List(Of Servicios.clsBitacora)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaBitacora As New List(Of Servicios.clsBitacora)
            Dim dt As New DataTable
            Dim oBita As Servicios.clsBitacora
            Dim hdatos As New Hashtable

            hdatos.Add("@ID_Usuario", paramUsuario.ID)
            hdatos.Add("@Fecha", paramFecha)
            hdatos.Add("@Operacion", paramOperacion)
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



    End Class
End Namespace
