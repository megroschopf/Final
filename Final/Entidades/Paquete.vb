Imports Entidades

Public Class Paquete
    Implements Producto
    Private _descripcion As String
    Private _fecha As Date
    Private _fechafinal As Date
    Private _productos As List(Of Producto)
    Private _pasajeros As List(Of Pasajero)
    'Sub New()
    '    _descripcion = Nothing
    '    _fecha = Nothing
    '    _fechafinal = Nothing
    '    _pasajeros = New List(Of Pasajero)
    'End Sub
    Sub New(descripcion As String, fecha As Date, fechafinal As Date)
        Me.Descripcion = descripcion
        Me.Fecha = fecha
        Me.FechaFinal = fechafinal
        _pasajeros = New List(Of Pasajero)
        _productos = New List(Of Producto)
    End Sub
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
            If value <= Today Then
                Throw New ArgumentException("La fecha debe ser mayor de hoy")
            End If
            _fecha = value
        End Set
    End Property
    Public Property FechaFinal As Date
        Get
            Return _fechafinal
        End Get
        Set(value As Date)
            If value <= Me.Fecha Then
                Throw New ArgumentException(" la Fecha debe ser mayor a la inicial")
            End If
            _fechafinal = value
        End Set
    End Property
    Public ReadOnly Property NumeroDias As UShort
        Get
            Return DateDiff(DateInterval.Day, Me.Fecha, Me.FechaFinal)
        End Get
    End Property
    Public ReadOnly Property NumeroPasajeros As UShort
        Get
            Return _pasajeros.Count
        End Get
    End Property
    Public Function Costo() As Single Implements Producto.Costo
        Dim suma_costos As Single
        For Each servicio As Producto In getAllProductos()
            suma_costos += servicio.Costo
        Next
        Return suma_costos
    End Function
    Public Sub addPasajero(pasajero As Pasajero)
        _pasajeros.Add(pasajero)
    End Sub
    Public Function getAllPasajeros() As List(Of Pasajero)
        Return _pasajeros
    End Function
    Public Sub removePasajero(pasajero)
        _pasajeros.Remove(pasajero)
    End Sub
    Public Sub addProducto(producto As Producto)
        _productos.Add(producto)
    End Sub
    Public Function getAllProductos() As List(Of Producto)
        Return _productos
    End Function
    Public Sub removeProducto(Producto)
        _productos.Remove(Producto)
    End Sub
End Class
