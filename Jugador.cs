using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    internal class Jugador
    {
        public string nombre {  get; set; }
        public bool estado { get; set; }
        public string arma {  get; set; }

        public void Disparar()
        {
            Console.WriteLine($"Disparo Efectuado a {nombre} con {arma}");
        }
        public void Recibir_Disparo()
        {
            Console.WriteLine($"Disparo Recibido de {nombre} con {arma}");
        }
    }
}
