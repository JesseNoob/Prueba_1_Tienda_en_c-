using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
//using Experimento_I;
namespace Experimento_I
{
    class Principal
    {
        public static void DibujarInterfaz()
        {

        }
        public static void EscribirContenido()
        {
            Console.SetCursorPosition(10, 8);
            Console.WriteLine("------------TIENDA SUPER HELLO----------------");
            Console.SetCursorPosition(30, 22);
            Console.Write("PlayStation");
            Console.SetCursorPosition(75, 22);
            Console.Write("Xbox");
            Console.SetCursorPosition(120, 22);
            Console.Write("Nintendo");
            Console.SetCursorPosition(10, 34);
            Console.Write("Ingrese su marca favorita: ");
            Console.SetCursorPosition(10, 36);
        }
        public static void EscribirPresentacion()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(70,25);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡¡Bienvenido a la tienda de consolas!!");
            Console.ResetColor();
            
        }
        public static void Main()
        {
            string opcion;
            Ventana ventana = new Ventana(180, 50);
            Cuadrados marcoDeLaVentana = new Cuadrados(new Point(2, 2), new Point(174, 50));
            Cuadrados primerMenu = new Cuadrados(new Point(10, 10), new Point(165, 30));
            Cuadrados tituloPlayStation = new Cuadrados(new Point(15, 20), new Point(55, 25));
            Cuadrados tituloXbox = new Cuadrados(new Point(60, 20), new Point(100, 25));
            Cuadrados tituloNintendo = new Cuadrados(new Point(105, 20), new Point(145, 25));
/*******************************************Primer Pantalla(Presentacion)**********************************************************/
            marcoDeLaVentana.DibujarBorde();
            EscribirPresentacion();
            Thread.Sleep(9000);
            Console.Clear();
/*******************************************Segunda Pantalla**********************************************************/
            marcoDeLaVentana.DibujarBorde();
            primerMenu.DibujarBorde();
            tituloPlayStation.DibujarBorde();
            tituloXbox.DibujarBorde();
            tituloNintendo.DibujarBorde();
            EscribirContenido();
            opcion = Console.ReadLine().ToLower();
            Console.Clear();
            Console.SetCursorPosition(80,25);
            switch (opcion)
            {
                case "playstation":

                    Console.ForegroundColor= ConsoleColor.DarkCyan;
                    Console.WriteLine("Haz elgido la primera opcion");
                    break;
                case "xbox":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Haz elgido la segunda opcion");
                    break;
                case "nintendo":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Haz elgido la tercera opcion");
                    break;
                default:
                    Console.WriteLine("No existe esa ocpcion");
                    break;
            }
            Console.ReadKey();
            
        }
    }
}
