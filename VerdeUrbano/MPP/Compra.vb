Namespace MPP
    Public Class Compra
        Public Function ConsultarCompras(ByVal _Empresa As EE.Empresa) As List(Of EE.Compra)
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet
            Dim oComp As EE.Compra
            Dim oResultado As New List(Of EE.Compra)

            hdatos.Add("@ID_Empresa", _Empresa.ID)
            DS = oDatos.Leer("s_Compra_ConsultarXEmp", hdatos)

            If DS.Tables(0).Rows.Count > 0 Then

                For Each Item As DataRow In DS.Tables(0).Rows
                    oComp = New EE.Compra
                    Dim oCurMPP As New MPP.Curso
                    Dim oCur As New EE.Curso
                    oCur.ID = Item("ID_Curso")
                    oComp.Curso = oCurMPP.Consultar(oCur)
                    oComp.Empresa = _Empresa
                    oComp.Licencias = Item("Cant_Licencias")
                    oResultado.Add(oComp)
                Next
                Return oResultado
            Else
                Return Nothing
            End If

        End Function
    End Class
End Namespace

