﻿Namespace EE
    Public Class Curso
        Private _Codigo As Integer
        Public Property Codigo() As Integer
            Get
                Return _Codigo
            End Get
            Set(ByVal value As Integer)
                _Codigo = value
            End Set
        End Property


        Private _Nombre As String
        Public Property Nombre() As String
            Get
                Return _Nombre
            End Get
            Set(ByVal value As String)
                _Nombre = value
            End Set
        End Property


        Private _Descripcion As String
        Public Property Descripcion() As String
            Get
                Return _Descripcion
            End Get
            Set(ByVal value As String)
                _Descripcion = value
            End Set
        End Property


        Private _Duracion As Integer
        Public Property Duracion() As Integer
            Get
                Return _Duracion
            End Get
            Set(ByVal value As Integer)
                _Duracion = value
            End Set
        End Property


        Private _Valor As Integer
        Public Property Valor() As Integer
            Get
                Return _Valor
            End Get
            Set(ByVal value As Integer)
                _Valor = value
            End Set
        End Property


        Private _Correlatividades As List(Of EE.Curso)
        Public Property Correlatividades() As List(Of EE.Curso)
            Get
                Return _Correlatividades
            End Get
            Set(ByVal value As List(Of EE.Curso))
                _Correlatividades = value
            End Set
        End Property


        Private _SecAct As Integer
        Public Property SeccionActual() As Integer
            Get
                Return _SecAct
            End Get
            Set(ByVal value As Integer)
                _SecAct = value
            End Set
        End Property

        Private _SolAsociada As SolicitudCurso
        Public Property SolicitudCurso() As SolicitudCurso
            Get
                Return _SolAsociada
            End Get
            Set(ByVal value As SolicitudCurso)
                _SolAsociada = value
            End Set
        End Property


        Private _estado As Curso_State
        Public Property Estado() As Curso_State
            Get
                Return _estado
            End Get
            Set(ByVal value As Curso_State)
                _estado = value
            End Set
        End Property


        Private _Seccion As List(Of Seccion)
        Public Property Secciones() As List(Of Seccion)
            Get
                Return _Seccion
            End Get
            Set(ByVal value As List(Of Seccion))
                _Seccion = value
            End Set
        End Property
        Private _Diseñador As EE.clsUsuario
        Public Property Diseñador() As EE.clsUsuario
            Get
                Return _Diseñador
            End Get
            Set(ByVal value As EE.clsUsuario)
                _Diseñador = value
            End Set
        End Property

        Sub New(ByVal Nombre As String, ByVal Descripcion As String, ByVal Duracion As Double)

        End Sub
    End Class
End Namespace
