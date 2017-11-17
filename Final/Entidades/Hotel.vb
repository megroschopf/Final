Imports Entidades

Public Class Hotel
    Implements Producto
    Private _descripcion As String
    Private _fecha As Date
    Private _montodiaria As Single
    Private _habitaciones As Byte
    Private _noches As Byte
    Private _ciudad As Ciudad
    Sub New(descripcion As String, fecha As Date, ciudad As Ciudad, noches As Byte, montodiario As Single)
        Me.Descripcion = descripcion
        Me.Fecha = fecha
        Me.Ciuidad = ciudad
        Me.Noches = noches
        Me.MontoDiario = montodiario
    End Sub
    Public Property Ciuidad As Ciudad
        Get
            Return _ciudad
        End Get
        Set(value As Ciudad)
            _ciudad = value
        End Set
    End Property
    Public Property MontoDiario As Single
        Get
            Return _montodiaria
        End Get
        Set(value As Single)
            _montodiaria = value
        End Set
    End Property
    Public Property Habitaciones As Byte
        Get
            Return _habitaciones
        End Get
        Set(value As Byte)
            _habitaciones = value
        End Set
    End Property
    Public Property Noches As Byte
        Get
            Return _noches
        End Get
        Set(value As Byte)
            _noches = value
        End Set
    End Property
    Public Property Descripcion As String Implements Producto.Descripcion
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Fecha As Date Implements Producto.Fecha
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Function Costo() As Single Implements Producto.Costo
        Return Me.MontoDiario
    End Function
End Class
