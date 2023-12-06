using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Experimento_I
{
    internal class Cuadrados
    {
        //1) Para dibujar los cuadrados se necesitan dos cosas, las coordenadas de su esquina superior izquierda y las de su esquina inferior derecha
        //   apartir de ahi, un método dibujara los bordes
        public Point EsquinaSuperiorIzquierda { get; set;} //Esta propiedad recibe dos valores, (x) e (y), no hacer caso al get o al set... Eso es para otra cosa
        public Point EsquinaInferiorDerecha { get; set;}
        //2) Para recibir los datos se emplea la función constructora que define el estado inicial de los objetos (Manipula las propiedades)
        public Cuadrados(Point esquinaSuperiorIzquierda, Point esquinInferiorDerecha)//Utilizo parametros para almacenar los valores que ingresaria desde otra clase mientras hago algun objeto
        {
            EsquinaSuperiorIzquierda = esquinaSuperiorIzquierda;//Esos valores se terminan guardando en la propiedades que defini arriba
            EsquinaInferiorDerecha = esquinInferiorDerecha;//De este modo podré acceder a su valores
        }
        public void DibujarBorde()
        {
            //Dibujando en el eje x
            for(int i = EsquinaSuperiorIzquierda.X; i <= EsquinaInferiorDerecha.X; i++)
            {
                Console.SetCursorPosition(i, EsquinaSuperiorIzquierda.Y);
                Console.Write("═");//Alt + 205
                Console.SetCursorPosition(i, EsquinaInferiorDerecha.Y);
                Console.Write("═");//Alt + 205
            }
            //Dibujando en el Y
            for (int i = EsquinaSuperiorIzquierda.Y; i <= EsquinaInferiorDerecha.Y; i++)
            {
                Console.SetCursorPosition(EsquinaSuperiorIzquierda.X, i);
                Console.Write("║");//Alt + 186
                Console.SetCursorPosition(EsquinaInferiorDerecha.X, i);
                Console.Write("║");//Alt + 186
            }
            Console.SetCursorPosition(EsquinaSuperiorIzquierda.X, EsquinaSuperiorIzquierda.Y);
            Console.Write("╔");//Alt + 201
            Console.SetCursorPosition(EsquinaSuperiorIzquierda.X, EsquinaInferiorDerecha.Y);
            Console.Write("╚");//Alt + 200
            Console.SetCursorPosition(EsquinaInferiorDerecha.X, EsquinaSuperiorIzquierda.Y);
            Console.Write("╗");//Alt + 187
            Console.SetCursorPosition(EsquinaInferiorDerecha.X, EsquinaInferiorDerecha.Y);
            Console.Write("╝");//Alt + 188
        }




    }
}
