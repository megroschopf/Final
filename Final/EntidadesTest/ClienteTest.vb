Imports Entidades
Module ClienteTest
    Sub main()
        Dim cliente1 As New Cliente(123123, "pepe", "121245331")
        Console.WriteLine("Nombre: " & cliente1.Nombre)
        Console.WriteLine("DNI: " & cliente1.DNI)
        Console.WriteLine("Cuit Cuil: " & cliente1.CuitCuil)
        For Each venta As Venta In cliente1.getAllVentas
            Console.WriteLine(venta)
        Next
        Console.ReadKey()
    End Sub
End Module
