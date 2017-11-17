Imports Entidades
Module HotelTest
    Sub main()
        Dim ciudad1 As New Ciudad("Posadas")
        Dim hotel1 As New Hotel("super", Today, ciudad1, 4, 50.5)
        hotel1.Habitaciones = 5
        Console.WriteLine("Descipcion: " & hotel1.Descripcion)
        Console.WriteLine("Fecha: " & hotel1.Fecha)
        Console.WriteLine("Ciudad: " & hotel1.Ciuidad.Nombre)
        Console.WriteLine("Noches: " & hotel1.Noches)
        Console.WriteLine("Monto Diario: " & hotel1.MontoDiario)
        Console.WriteLine("Habitaciones: " & hotel1.Habitaciones)

        Console.WriteLine(hotel1.Costo)
        Console.ReadKey()
    End Sub
End Module
