Public Class Pasajero
    Protected _dni As UInteger
    Protected _nombre As String
    'Sub New()
    '    _dni = 0
    '    _nombre = Nothing
    'End Sub
    Sub New(dni As UInteger, nombre As String)
        Me.DNI = dni
        Me.Nombre = nombre
    End Sub
    Public Property DNI As UInteger
        Get
            Return _dni
        End Get
        Set(value As UInteger)
            _dni = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Me.Nombre & " " & Me.DNI
    End Function
End Class
