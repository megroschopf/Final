Public Class Cliente
    Inherits Pasajero
    Private _cuit_cuil As String
    Private _ventas As List(Of Venta)
    Sub New(dni As UInteger, nombre As String, cuit_cuil As String)
        MyBase.New(dni, nombre)
        Me.CuitCuil = cuit_cuil
        _ventas = New List(Of Venta)
    End Sub
    Public Property CuitCuil As String
        Get
            Return _cuit_cuil
        End Get
        Set(value As String)
            _cuit_cuil = value
        End Set
    End Property
    Public Function getAllVentas() As List(Of Venta)
        Return _ventas
    End Function
    Friend Sub addVenta(venta As Venta)

        _ventas.Add(venta)

    End Sub
    Public Overrides Function ToString() As String
        Return Me.Nombre & " " & Me.CuitCuil
    End Function
End Class
