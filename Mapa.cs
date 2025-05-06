using System;

internal class Mapa
{
    static void Main()
    {
        string[] mapas = { "Fortaleza Sombría", "Sector 9", "Horizonte Perdido" };

        Console.WriteLine("Lista de mapas:");
        foreach (string mapa in mapas)
        {
            Console.WriteLine(mapa);
        }
    }
}