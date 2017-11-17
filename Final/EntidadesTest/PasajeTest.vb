Imports Entidades
Module PasajeTest
    Sub Main()
        Dim ciudad1 As New Ciudad("posaadas")
        Dim ciudad2 As New Ciudad("Obera")
        Dim pasaje1 As New Pasaje("Ida", Today, 19.5, ciudad1, ciudad2)
        Console.WriteLine("Descripcion: " & pasaje1.Descripcion)
        Console.WriteLine("Fecha: " & pasaje1.Fecha)
        Console.WriteLine("Valor: " & pasaje1.Valor)
        Console.WriteLine("Origen: {0}", pasaje1.Origen)
        Console.WriteLine("Destino: {0}", pasaje1.Destino)
        Console.WriteLine(pasaje1)
        Console.ReadKey()
    End Sub

End Module
