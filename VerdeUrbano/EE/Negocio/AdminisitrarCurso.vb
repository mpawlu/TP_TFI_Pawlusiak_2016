Namespace EE
    Public Class AdministrarCurso

        Private _curso As Curso
        Public Property Curso() As Curso
            Get
                Return _curso
            End Get
            Set(ByVal value As Curso)
                _curso = value
            End Set
        End Property

        Private _Empresa As Empresa
        Public Property Empresa() As Empresa
            Get
                Return _Empresa
            End Get
            Set(ByVal value As Empresa)
                _Empresa = value
            End Set
        End Property


        Private _LicenciasCompradas As Integer
        Public Property LicenciasCompradas() As Integer
            Get
                Return _LicenciasCompradas
            End Get
            Set(ByVal value As Integer)
                _LicenciasCompradas = value
            End Set
        End Property

        Private _LicenciasDisponibles As Integer
        Public Property LicenciasDisponibles() As Integer
            Get
                Return _LicenciasDisponibles
            End Get
            Set(ByVal value As Integer)
                _LicenciasDisponibles = value
            End Set
        End Property

        Private _Asignado As New List(Of Empleado)
        Public Property AsignadoA() As List(Of Empleado)
            Get
                Return _Asignado
            End Get
            Set(ByVal value As List(Of Empleado))
                _Asignado = value
            End Set
        End Property
        Sub New(ByVal Curso As EE.Curso, ByVal empresa As EE.Empresa, ByVal licenciasCompradas As Integer)

        End Sub
    End Class
End Namespace
