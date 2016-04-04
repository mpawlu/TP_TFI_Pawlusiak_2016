Imports Servicios
Public Interface Observable
    Sub AgregarObservador(ByVal Observador As Servicios.Obvserver)
    Sub QuitarObservador(ByVal Observador As Servicios.Obvserver)
    Sub Notificar()

End Interface
