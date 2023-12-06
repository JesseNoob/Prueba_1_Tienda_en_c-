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

        public static void EscribirItems(string[]arr)
        {
            Console.SetCursorPosition(40, 9);
            Console.WriteLine("Consolas");
            Console.SetCursorPosition(114, 9);
            Console.WriteLine("Portatiles");
            int y = 12;
            for(int i = 0; i <(arr.Length/2); i++)
            {
                Console.SetCursorPosition(17, y);
                Console.WriteLine((i+1)+") "+arr[i]);
                y += 6;
            }
            y = 12;
            for (int i = (arr.Length/2); i <arr.Length; i++)
            {
                Console.SetCursorPosition(97, y);
                Console.WriteLine((i+1)+") "+arr[i]);
                y += 6;
            }
        }
        public static void DibujarInterfaz()
        {
            Cuadrados marcoDeLaVentana = new Cuadrados(new Point(2, 2), new Point(174, 50));
            Cuadrados tituloDeLaMarca = new Cuadrados(new Point(4,4),new Point(30,7));
            Cuadrados listaDeItem = new Cuadrados(new Point(15,10), new Point(70,40));
            Cuadrados listaDeItem2 = new Cuadrados(new Point(95, 10), new Point(140, 40));
            marcoDeLaVentana.DibujarBorde();
            tituloDeLaMarca.DibujarBorde();
            listaDeItem.DibujarBorde();
            listaDeItem2.DibujarBorde();
            Console.SetCursorPosition(140,4);
            Console.Write("Ingrese una opción: ");
            Console.SetCursorPosition(140, 5);
            Console.Write("Añadir(si)(no): ");

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
            Console.SetCursorPosition(70,25);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("¡¡Bienvenido a la tienda de consolas!!");
            Console.ResetColor();
            
        }
        public static void Main()
        {
            List<ConsolasDeMesa> productos = new List<ConsolasDeMesa>();
            string[] psp = { "PlayStation 1", "PlayStation 2", "PlayStation 3", "PlayStation 4", "PlayStation Vita", "PlayStation Vita Slim", "PlayStation PSP", "PSPP" };
            string[] xbox = { "Xbox", "Xbox 360", "xbox one", "Xbox series S" };
            string[] nin = { "NES", "Game Cube", "Super Nintendo", "Nintendo 64" };
            Console.Title = "Consolas Epicas - Tienda";
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
            Thread.Sleep(2000);
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
/*******************************************Tercera Pantalla**********************************************************/
            DibujarInterfaz();
            switch (opcion)
            {
                case "playstation":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    //EscribirItems(psp);
                    Console.SetCursorPosition(160, 4);
                    break;
                case "xbox":
                    Console.ForegroundColor = ConsoleColor.Green;
                    //EscribirItems(xbox);
                    break;
                case "nintendo":
                    Console.ForegroundColor = ConsoleColor.Red;
                    //EscribirItems(nin);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("No existe esa opcion");
                    break;
            }
            Console.ReadKey();


        }
    }
}
