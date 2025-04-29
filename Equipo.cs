using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    internal class Equipo
    {
        public string nombre { get; set; }
        public List <Jugador> jugadores { get; set; }
        public int rondas_ganadas { get; set; }

        public void Verificar_Partida ()
        {
            Console.WriteLine($"Quedan los siguientes jugadores {jugadores}");
        }
        public void Sumar_Victoria()
        {
            Console.WriteLine($"Rondas ganadas {rondas_ganadas}");
        }
    }
}
