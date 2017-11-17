Imports Entidades
Module PasajeroTest
    Sub main()
        'Dim pasajero1 As New Pasajero
        'pasajero1.DNI = 234234234
        'pasajero1.Nombre = "Matias"
        'Console.WriteLine("Nombre: {0}", pasajero1.Nombre)
        'Console.WriteLine("DNI: {0}", pasajero1.DNI)
        'Console.WriteLine(pasajero1)
        Dim pasajero2 As New Pasajero(45345234, "Pepe")
        Console.WriteLine("Nombre: {0}", pasajero2.Nombre)
        Console.WriteLine("DNI: {0}", pasajero2.DNI)
        Console.WriteLine(pasajero2)
        Console.ReadKey()
    End Sub
End Module
