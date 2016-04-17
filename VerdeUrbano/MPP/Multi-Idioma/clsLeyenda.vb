﻿Namespace MPP
    Public Class clsLeyenda
        Public Function ListarLeyendas() As List(Of Servicios.clsLeyenda)

            Dim oDatos As New DAL.Datos
            Dim DS As New DataSet
            Dim listaLeyenda As New List(Of Servicios.clsLeyenda)
            Dim dt As New DataTable
            Dim oLey As Servicios.clsLeyenda

            DS = oDatos.Leer("s_Leyendas_Listar", Nothing)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oLey = New Servicios.clsLeyenda
                    oLey.ID = Item("IdLeyenda")
                    oLey.Leyenda = Item("Leyenda")


                    listaLeyenda.Add(oLey)
                Next

                Return listaLeyenda

            Else
                Return Nothing
            End If
        End Function
    End Class
End Namespace

