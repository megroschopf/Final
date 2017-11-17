Imports Entidades
Module PaqueteTest
    Sub main()


        Dim pasajero2 As New Pasajero(45345234, "Pepe")
        Dim pasajero3 As New Pasajero(4534, "qwqweqweq")
        Dim ciudad1 As New Ciudad("Posadas")
        Dim ciudad2 As New Ciudad("Candelaria")
        Dim hotel1 As New Hotel("super", Today, ciudad1, 4, 50.5)
        Dim pasaje1 As New Pasaje("Ida", Today, 19.5, ciudad1, ciudad2)
        Dim paquete1 As Paquete
        Try
            paquete1 = New Paquete("ultra", Today, Today.AddDays(50))
        Catch
        End Try
        Try
                paquete1.addPasajero(pasajero2)
                paquete1.addPasajero(pasajero3)
                paquete1.addProducto(hotel1)
                paquete1.addProducto(pasaje1)
                Console.WriteLine("Numero Dias: " & paquete1.NumeroDias)
                Console.WriteLine("Numero Pasajeros: " & paquete1.NumeroPasajeros)
                Console.WriteLine("Monto: " & paquete1.Costo)
                For Each pasajero As Pasajero In paquete1.getAllPasajeros
                    Console.WriteLine(pasajero)
                Next
                For Each Producto As Producto In paquete1.getAllProductos
                    Console.WriteLine(Producto)
                Next
                paquete1.removePasajero(pasajero2)
                paquete1.removeProducto(hotel1)
                Console.WriteLine("Numero Pasajeros: " & paquete1.NumeroPasajeros)
                Console.WriteLine("Monto: " & paquete1.Costo)
                For Each pasajero As Pasajero In paquete1.getAllPasajeros
                    Console.WriteLine(pasajero)
                Next
                For Each Producto As Producto In paquete1.getAllProductos
                    Console.WriteLine(Producto)
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message)
        End Try
        Try
            Dim paquete1 As New Paquete("ultra", Today.AddDays(1), Today.AddDays(1))
            paquete1.addPasajero(pasajero2)
            paquete1.addPasajero(pasajero3)
            paquete1.addProducto(hotel1)
            paquete1.addProducto(pasaje1)
            Console.WriteLine("Numero Dias: " & paquete1.NumeroDias)
            Console.WriteLine("Numero Pasajeros: " & paquete1.NumeroPasajeros)
            Console.WriteLine("Monto: " & paquete1.Costo)
            For Each pasajero As Pasajero In paquete1.getAllPasajeros
                Console.WriteLine(pasajero)
            Next
            For Each Producto As Producto In paquete1.getAllProductos
                Console.WriteLine(Producto)
            Next
            paquete1.removePasajero(pasajero2)
            paquete1.removeProducto(hotel1)
            Console.WriteLine("Numero Pasajeros: " & paquete1.NumeroPasajeros)
            Console.WriteLine("Monto: " & paquete1.Costo)
            For Each pasajero As Pasajero In paquete1.getAllPasajeros
                Console.WriteLine(pasajero)
            Next
            For Each Producto As Producto In paquete1.getAllProductos
                Console.WriteLine(Producto)
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Try
            Dim paquete1 As New Paquete("ultra", Today.AddDays(1), Today.AddDays(50))
            paquete1.addPasajero(pasajero2)
            paquete1.addPasajero(pasajero3)
            paquete1.addProducto(hotel1)
            paquete1.addProducto(pasaje1)
            Console.WriteLine("Numero Dias: " & paquete1.NumeroDias)
            Console.WriteLine("Numero Pasajeros: " & paquete1.NumeroPasajeros)
            Console.WriteLine("Monto: " & paquete1.Costo)
            For Each pasajero As Pasajero In paquete1.getAllPasajeros
                Console.WriteLine(pasajero)
            Next
            For Each Producto As Producto In paquete1.getAllProductos
                Console.WriteLine(Producto)
            Next
            paquete1.removePasajero(pasajero2)
            paquete1.removeProducto(hotel1)
            Console.WriteLine("Numero Pasajeros: " & paquete1.NumeroPasajeros)
            Console.WriteLine("Monto: " & paquete1.Costo)
            For Each pasajero As Pasajero In paquete1.getAllPasajeros
                Console.WriteLine(pasajero)
            Next
            For Each Producto As Producto In paquete1.getAllProductos
                Console.WriteLine(Producto)
            Next
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Console.ReadKey()
    End Sub
End Module
