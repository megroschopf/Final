Imports Entidades
Module VentaTest
    Sub main()
        Dim cliente1 As New Cliente(123123, "pepe", "121245331")
        Dim venta1 As New Venta()
        venta1.Cliente = cliente1

        'Console.WriteLine("Monto Total: " & venta1.montoTotal)
        Console.WriteLine("Cliente:" & venta1.Cliente.Nombre)
        Console.WriteLine(venta1)
        Console.WriteLine("Nombre: " & cliente1.Nombre)
        Console.WriteLine("DNI: " & cliente1.DNI)
        Console.WriteLine("Cuit Cuil: " & cliente1.CuitCuil)
        For Each venta As Venta In cliente1.getAllVentas
            Console.WriteLine(venta)
        Next
        Console.ReadKey()
    End Sub
End Module
