Imports Entidades

Public Class Pasaje
    Implements Producto
    Private _descripcion As String
    Private _fecha As Date
    Private _valor As Single
    Private _origen As Ciudad
    Private _destino As Ciudad
    Sub New(descripcion As String, fecha As Date, valor As Single, origen As Ciudad, destino As Ciudad)
        Me.Descripcion = descripcion
        Me.Fecha = fecha
        Me.Valor = valor
        Me.Origen = origen
        Me.Destino = destino
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
            _fecha = value
        End Set
    End Property
    Public Property Valor As Single
        Get
            Return _valor
        End Get
        Set(value As Single)
            _valor = value
        End Set
    End Property
    Public Property Origen As Ciudad
        Get
            Return _origen
        End Get
        Set(value As Ciudad)
            _origen = value
        End Set
    End Property
    Public Property Destino As Ciudad
        Get
            Return _destino
        End Get
        Set(value As Ciudad)
            _destino = value
        End Set
    End Property
    Public Function Costo() As Single Implements Producto.Costo
        Return Me.Valor
    End Function
    Public Overrides Function ToString() As String
        Return "Descripcion: " & Me.Descripcion & " Origen: " & Me.Origen.Nombre & " Destino: " & Me.Destino.Nombre
    End Function
End Class
