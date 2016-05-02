Imports DAL
Imports System.Security.Cryptography
Imports System.Text
Imports System.Data.SqlClient
Imports System.Configuration
Namespace MPP
    Public Class DigitoVerificador
        Public Shared Function CalcularDVH(ByRef Fila As String) As String
            Try
                Dim UE As New UnicodeEncoding
                Dim bHash As Byte()
                Dim bCadena() As Byte = UE.GetBytes(Fila)
                Dim s1Service As New SHA1CryptoServiceProvider
                bHash = s1Service.ComputeHash(bCadena)
                Dim Resumen As String
                Resumen = Convert.ToBase64String(bHash)
                Return Resumen
            Catch ex As Exception
                Throw ex
            End Try

        End Function
        Public Shared Function CalcularDVV(ByRef NombreTabla As String) As Boolean
            Try
                Dim oDatos As New DAL.Datos
                Dim hdatos As New Hashtable
                Dim DS As New DataSet


                Dim fila As String
                For Each dr As DataRow In RecorrerTabla(NombreTabla).Rows
                    fila = fila & dr.Item("DVH")
                Next

                Dim DVV As String
                DVV = CalcularDVH(Fila)

                DS = oDatos.Leer("s_DVV_Listar", Nothing)
                If DS.Tables(0).Rows.Count = 1 Then
                    Return ModificarRegistro(NombreTabla, DVV)
                Else
                    Return GuardarRegistro(NombreTabla, DVV)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Public Function VerificarIntegridad() As DataTable
        '    Try
        '        Dim Command As SqlCommand = Acceso.MiComando("Select * from Digito_Verificador_Vertical")
        '        Dim DataTabla = Acceso.Lectura(Command)
        '        Return DataTabla
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        'Public Function ProbarConectividad() As Boolean
        '    Try
        '        Dim MiConecction As New SqlCommand
        '        MiConecction.Connection = Acceso.MiConexion
        '        MiConecction.Connection.Open()
        '        If MiConecction.Connection.State = ConnectionState.Open Then
        '            MiConecction.Connection.Close()
        '            Return True
        '        Else
        '            Return False
        '        End If
        '    Catch ex As Exception
        '        Return False
        '    End Try
        'End Function
        Private Shared Function GuardarRegistro(ByVal pTabla As String, ByVal pDVV As String) As Boolean
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@Tabla", pTabla)
            hdatos.Add("@DVV", pDVV)
            'Dim Resumen As String
            'Resumen = CalcularDVH(pDVV)

            resultado = oDatos.Escribir("s_DVV_Alta", hdatos)
            Return resultado
        End Function
        Private Shared Function ModificarRegistro(ByVal pTabla As String, ByVal pDVV As String) As Boolean
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim resultado As Boolean

            hdatos.Add("@Tabla", pTabla)
            hdatos.Add("@DVV", pDVV)
            'Dim Resumen As String
            'Resumen = CalcularDVH(pDVV)

            resultado = oDatos.Escribir("s_DVV_Modificar", hdatos)
            Return resultado
        End Function
        Public Shared Function RecorrerTabla(ByVal pNombreTabla As String) As DataTable
            Dim oDatos As New DAL.Datos
            Dim hdatos As New Hashtable
            Dim DS As New DataSet

            hdatos.Add("@NombreTabla", pNombreTabla)
            DS = oDatos.Leer("s_ConsultarTabla", hdatos)
            Return DS.Tables(0)
        End Function

        Public Function ListarDVV() As DataTable
            Dim oDatos As New DAL.Datos
            Dim ds As New DataSet

            ds = oDatos.Leer("s_DVV_Listar", Nothing)
            Return ds.Tables(0)

        End Function
    End Class
End Namespace
