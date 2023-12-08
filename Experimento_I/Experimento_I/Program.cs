using Experimento_III;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
namespace ExperimentoIII
{
    class Principal
    {

        public static string comandos;
        public static List<ConsolaDeMesa> PS1productos()
        {
            List<ConsolaDeMesa> ProductoPS = new List<ConsolaDeMesa>();
            ConsolaDeMesa ps1 = new ConsolaDeMesa("PlayStation 1", 20);
            ConsolaDeMesa ps2 = new ConsolaDeMesa("PlayStation 1", 20);
            ConsolaDeMesa ps3 = new ConsolaDeMesa("PlayStation 1", 20);
            ConsolaDeMesa ps4 = new ConsolaDeMesa("PlayStation 1", 20);
            ConsolaDeMesa ps5 = new ConsolaDeMesa("PlayStation 1", 20);
            ConsolaDeMesa ps6 = new ConsolaDeMesa("PlayStation 1", 20);
            ConsolaDeMesa ps7 = new ConsolaDeMesa("PlayStation 1", 20);
            ConsolaDeMesa ps8 = new ConsolaDeMesa("PlayStation 1", 20);
            ProductoPS.Add(ps1);
            ProductoPS.Add(ps2);
            ProductoPS.Add(ps3);
            ProductoPS.Add(ps4);
            ProductoPS.Add(ps5);
            ProductoPS.Add(ps6);
            ProductoPS.Add(ps7);
            ProductoPS.Add(ps8);

            return ProductoPS;
        }
        public static void ConfigurarVentana(int ancho, int altura)
        {
            Ventana LongitudDeLaVentana = new Ventana(ancho, altura);
        }
        public static void DibujarPresentacion()
        {
            Interfaz marcoDeLaVentana = new Interfaz(new Point(4,2), new Point(172,50));
            marcoDeLaVentana.DibujarCuadrado();
            Console.SetCursorPosition(70,26);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bienvenido a la tienda \"Consolas Epicas\" ");
        }
        public static void DibujarPrimerMenu()
        {
            Interfaz marcoDeLaVentana = new Interfaz(new Point(4, 2), new Point(172, 50));
            Interfaz Contenedor = new Interfaz(new Point(9,9), new Point(167,25));
            Interfaz titulo1 = new Interfaz(new Point(14, 14), new Point(54, 20));
            Interfaz titulo2 = new Interfaz(new Point(58, 14), new Point(108, 20));
            Interfaz titulo3 = new Interfaz(new Point(112, 14), new Point(162, 20));
            marcoDeLaVentana.DibujarCuadrado();
            Contenedor.DibujarCuadrado();
            titulo1.DibujarCuadrado();
            titulo2.DibujarCuadrado();
            titulo3.DibujarCuadrado();
            Console.SetCursorPosition(8, 8);
            Console.WriteLine("----------Consolas Epicas----------");
            Console.SetCursorPosition(30, 17);
            Console.WriteLine("PLAYSTATION");
            Console.SetCursorPosition(80, 17);
            Console.WriteLine("XBOX");
            Console.SetCursorPosition(133, 17);
            Console.WriteLine("NINTENDO");
            Console.SetCursorPosition(9,30);
            for (int i = Contenedor.EsquinaSuperiorIzquierda.X; i<=Contenedor.EsquinaInferiorDerecha.X-79;i++)
            {
                Console.Write("═");
            }
            Console.SetCursorPosition(9, 31);
            Console.WriteLine("Ingrese su marca preferida: ");
            Console.SetCursorPosition(9, 33);
            comandos = Console.ReadLine().ToLower();
        }//Usa por primera vez la variable comandos
        public static void DibujarSegundoMenu()
        {
            Interfaz marcoDeLaVentana = new Interfaz(new Point(4, 2), new Point(172, 50));
            Interfaz tituloDeLaMarca = new Interfaz(new Point(6, 4), new Point(30, 7));
            Interfaz listaDeItem = new Interfaz(new Point(20, 10), new Point(70, 40));
            Interfaz listaDeItem2 = new Interfaz(new Point(95, 10), new Point(140, 40));
            marcoDeLaVentana.DibujarCuadrado();
            tituloDeLaMarca.DibujarCuadrado();
            listaDeItem.DibujarCuadrado();
            listaDeItem2.DibujarCuadrado();
            Console.SetCursorPosition(140, 4);
            Console.Write("Ingrese una opción: ");
            Console.SetCursorPosition(140, 5);
            Console.Write("Añadir(si)(no): ");
            switch (comandos)
            {

            }
        }
        public static void EscribirItems(List<ConsolaDeMesa> items)
        {
            Console.SetCursorPosition(40, 9);
            Console.WriteLine("Consolas");
            Console.SetCursorPosition(114, 9);
            Console.WriteLine("Portatiles");
            int y = 12;
            for (int i = 0; i < (items.Count / 2); i++)
            {
                Console.SetCursorPosition(17, y);
                Console.WriteLine((i + 1) + ") " + items[i].Nombre + "Precio: " + items[i].Precio);
                y += 6;
            }
            y = 12;
            for (int i = (items.Count / 2); i < items.Count; i++)
            {
                Console.SetCursorPosition(97, y);
                Console.WriteLine((i + 1) + ") " + items[i].Nombre + "Precio: " + items[i].Precio);
                y += 6;
            }
        }
        public static void Main()
        {
            List<ConsolaDeMesa> productosDePlayStation = PS1productos();
            ConfigurarVentana(100, 42);
            //DibujarPresentacion();
            //DibujarPrimerMenu();
            //DibujarSegundoMenu();
            //Console.Clear();
            EscribirItems(productosDePlayStation);
           
            
            Console.ReadKey();

        }
    }
}
