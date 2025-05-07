using System;
using System.Threading;

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

        Console.WriteLine("\n¡Todos los recursos se han cargado correctamente!");

        Console.Write("\nSelecciona un mapa para iniciar: ");
        string seleccion = Console.ReadLine();

        switch (seleccion)
        {
            case "Fortaleza Sombría":
                Console.WriteLine("Has entrado a la Fortaleza Sombría. ¡Cuidado con las trampas!");
                break;
            case "Sector 9":
                Console.WriteLine("Bienvenido al Sector 9. Tecnología avanzada te espera.");
                break;
            case "Horizonte Perdido":
                Console.WriteLine("Explora el Horizonte Perdido. Misterios por descubrir.");
                break;
            default:
                Console.WriteLine("Mapa no reconocido. Por favor, selecciona uno de la lista.");
                break;
        }

        CargarRecurso("Texturas");
        CargarRecurso("Sonido");
        CargarRecurso("Modelos");
    }



    static void CargarRecurso(string nombreRecurso)
    {
        Console.Write($"Cargando {nombreRecurso}...");
        Thread.Sleep(2000); // Simula el tiempo de carga
        Console.WriteLine(" Listo");
    }

}
