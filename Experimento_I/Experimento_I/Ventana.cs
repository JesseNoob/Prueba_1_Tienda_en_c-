using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experimento_I
{
    internal class Ventana
    {
        public int Altura { get; set; }
        public int Anchura { get; set; }
        public Ventana(int ancho, int alto) { 
            Altura = alto;
            Anchura = ancho;
            Init();
        }    
        public void Init()
        {
            Console.SetWindowSize(Anchura, Altura);
        }
    }
}
