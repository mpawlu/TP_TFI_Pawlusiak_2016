Namespace EE
    Public Class PreguntaEncuesta
        Private _id As Integer
        Public Property ID_Pregunta() As Integer
            Get
                Return _id
            End Get
            Set(ByVal value As Integer)
                _id = value
            End Set
        End Property

        Private _pregunta As String
        Public Property Pregunta() As String
            Get
                Return _pregunta
            End Get
            Set(ByVal value As String)
                _pregunta = value
            End Set
        End Property


        Private _tipoResp As TipoDeRespuesta
        Public Property TipoDeRespuesta() As TipoDeRespuesta
            Get
                Return _tipoResp
            End Get
            Set(ByVal value As TipoDeRespuesta)
                _tipoResp = value
            End Set
        End Property

        Private _Valor As Double
        Public Property Valor() As Double
            Get
                Return _Valor
            End Get
            Set(ByVal value As Double)
                _Valor = value
            End Set
        End Property
    End Class
End Namespace

