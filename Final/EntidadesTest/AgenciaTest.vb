Imports Entidades
Module AgenciaTest
    Sub main()
        Dim cliente1 As New Cliente(123123, "pepe", "121245331")
        Dim venta1 As New Venta()
        venta1.Cliente = cliente1
        Dim cliente2 As New Cliente(123123, "meme", "121245331")
        Dim venta2 As New Venta()
        venta2.Cliente = cliente2
        Agencia.addVentas(venta1)
        Agencia.addVentas(venta2)
        For Each venta As Venta In Agencia.getAllVentas
            Console.WriteLine(venta)
        Next
        Agencia.Remove(venta2)
        For Each venta As Venta In Agencia.getAllVentas
            Console.WriteLine(venta)
        Next
        Console.ReadKey()
    End Sub
End Module
