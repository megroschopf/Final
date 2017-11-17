Imports Entidades
Module CiudadTest
    Sub main()
        Dim ciudad1 As New Ciudad("Posadas")
        Console.WriteLine(ciudad1.Nombre)
        Console.WriteLine(ciudad1)
        Console.ReadKey()
    End Sub
End Module
