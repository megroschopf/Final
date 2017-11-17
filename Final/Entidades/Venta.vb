Public Class Venta
    Private _fecha As Date
    Private _producto As Producto
    Private _cliente As Cliente

    Sub New()
        _fecha = Nothing
    End Sub
    Public Property Producto As Producto
        Get
            Return _producto
        End Get
        Set(value As Producto)
            _producto = value
        End Set
    End Property
    'Public Function montoTotal() As Single
    '    Return Me.Producto.Costo
    'End Function
    Public Property Cliente As Cliente
        Get
            Return _cliente
        End Get
        Set(value As Cliente)
            value.addVenta(Me)
            _cliente = value

        End Set
    End Property
    Public Property fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return Me.Cliente.Nombre & " " & Me.fecha
    End Function
End Class
