using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimento_III
{
    internal class ConsolaDeMesa
    {
        public string Nombre {  get; set; }
        public double Precio { get; set; }

        public ConsolaDeMesa(string nombre, double precio)
        { 
            Nombre= nombre;
            Precio= precio;
        }
    }
}
