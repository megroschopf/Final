Public Class Agencia
    Private Shared _ventas As List(Of Venta)
    Shared Sub New()
        _ventas = New List(Of Venta)
    End Sub
    Public Shared Sub addVentas(venta As Venta)
        _ventas.Add(venta)
    End Sub
    Public Shared Sub Remove(Venta As Venta)
        _ventas.Remove(Venta)
    End Sub
    Public Shared Function getAllVentas() As List(Of Venta)
        Return _ventas
    End Function
End Class
