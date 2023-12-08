using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Experimento_III
{
    internal class Interfaz
    {
        public Point EsquinaSuperiorIzquierda {  get; set; }//5,5
        public Point EsquinaInferiorDerecha { get; set; }//10,10
        public Interfaz(Point esquina1, Point esquina2)
        {
            EsquinaSuperiorIzquierda = esquina1;
            EsquinaInferiorDerecha = esquina2;
        }
        public void DibujarCuadrado()
        {
            for (int i = EsquinaSuperiorIzquierda.X; i<=EsquinaInferiorDerecha.X; i++)
            {

                Console.SetCursorPosition(i,EsquinaSuperiorIzquierda.Y);
                Console.WriteLine( "═" );
                Console.SetCursorPosition(i, EsquinaInferiorDerecha.Y);
                Console.WriteLine( "═" );
            }
            for(int i = EsquinaSuperiorIzquierda.Y; i <= EsquinaInferiorDerecha.Y; i++)
            {
                Console.SetCursorPosition(EsquinaSuperiorIzquierda.X,i) ;
                Console.WriteLine( "║" );
                Console.SetCursorPosition(EsquinaInferiorDerecha.X, i);
                Console.WriteLine( "║" );
            }
            Console.SetCursorPosition(EsquinaSuperiorIzquierda.X,EsquinaSuperiorIzquierda.Y);
            Console.WriteLine("╔");
            Console.SetCursorPosition(EsquinaInferiorDerecha.X, EsquinaInferiorDerecha.Y);
            Console.WriteLine("╝");
            Console.SetCursorPosition(EsquinaSuperiorIzquierda.X, EsquinaInferiorDerecha.Y);
            Console.WriteLine("╚");
            Console.SetCursorPosition(EsquinaInferiorDerecha.X, EsquinaSuperiorIzquierda.Y);
            Console.WriteLine("╗");
        }

    }
    internal class Ventana
    {
        public int Ancho { get; set; }
        public int Alto { get; set; }

        public Ventana(int ancho, int alto) 
        {
            Ancho = ancho; Alto = alto;
            Init();
        }
        public void Init()
        {
            Console.SetWindowSize(Ancho, Alto);
        }
    }
}
