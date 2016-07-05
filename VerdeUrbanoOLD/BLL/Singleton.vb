Namespace BLL
    Public Class Singleton

        Shared _InstanciaSing As Singleton = Nothing
        Public Shared ReadOnly Property InstanciaSing() As Singleton
            Get
                If _InstanciaSing Is Nothing Then
                    _InstanciaSing = New Singleton
                End If
                Return _InstanciaSing
            End Get
        End Property

        Public oUsuarioSesion As New Servicios.Usuario

    End Class
End Namespace
