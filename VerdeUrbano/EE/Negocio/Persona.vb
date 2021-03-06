﻿Namespace EE
    Public Class Persona
        Private _DNI As String
        Public Property DNI() As String
            Get
                Return _DNI
            End Get
            Set(ByVal value As String)
                _DNI = value
            End Set
        End Property

        Private _Nombres As String
        Public Property Nombres() As String
            Get
                Return _Nombres
            End Get
            Set(ByVal value As String)
                _Nombres = value
            End Set
        End Property

        Private _Apellido As String
        Public Property Apellido() As String
            Get
                Return _Apellido
            End Get
            Set(ByVal value As String)
                _Apellido = value
            End Set
        End Property

        Private _Tel As String
        Public Property Telefono() As String
            Get
                Return _Tel
            End Get
            Set(ByVal value As String)
                _Tel = value
            End Set
        End Property

        Private _email As String
        Public Property Email() As String
            Get
                Return _email
            End Get
            Set(ByVal value As String)
                _email = value
            End Set
        End Property

        Private _empresa As EE.Empresa
        Public Property Empresa() As EE.Empresa
            Get
                Return _empresa
            End Get
            Set(ByVal value As EE.Empresa)
                _empresa = value
            End Set
        End Property

        Private _Usuario As Servicios.Usuario
        Public Property Usuario() As Servicios.Usuario
            Get
                Return _Usuario
            End Get
            Set(ByVal value As Servicios.Usuario)
                _Usuario = value
            End Set
        End Property

        Private _imagen As String
        Public Property Imagen() As String
            Get
                Return _imagen
            End Get
            Set(ByVal value As String)
                _imagen = value
            End Set
        End Property

    End Class
End Namespace
