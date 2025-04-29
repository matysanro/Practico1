using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    internal class Arma
    {
        public string nombre { get; set; }
        public int daño { get; set; }
        public int municion { get; set; }

        public void Disparar()
        {
            Console.WriteLine($"Disparo Efectuado con {nombre}");
        }
        public void Recargar()
        {
            Console.WriteLine($"Cargador lleno con {municion}");
        }
    }
}
