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
            ConsolaDeMesa ps1 = new ConsolaDeMesa("PlayStation 1", 25);
            ConsolaDeMesa ps2 = new ConsolaDeMesa("PlayStation 1", 30);
            ConsolaDeMesa ps3 = new ConsolaDeMesa("PlayStation 1", 100);
            ConsolaDeMesa ps4 = new ConsolaDeMesa("PlayStation 1", 240);
            ConsolaDeMesa ps5 = new ConsolaDeMesa("PlayStation 1", 600;
            ConsolaDeMesa psvita = new ConsolaDeMesa("PlayStation 1", 30);
            ConsolaDeMesa psp = new ConsolaDeMesa("PlayStation 1", 40);
            ProductoPS.Add(ps1);
            ProductoPS.Add(ps2);
            ProductoPS.Add(ps3);
            ProductoPS.Add(ps4);
            ProductoPS.Add(ps5);
            ProductoPS.Add(psvita);
            ProductoPS.Add(psp);

            return ProductoPS;
        }
         public static List<ConsolaDeMesa> XboxProducts()
        {
            List<ConsolaDeMesa> ProductoXbox = new List<ConsolaDeMesa>();
            ConsolaDeMesa xbox = new ConsolaDeMesa("Xbox", 22);
            ConsolaDeMesa xbox360 = new ConsolaDeMesa("Xbox 360 ", 50);
            ConsolaDeMesa xbox360A = new ConsolaDeMesa("Xbox 360 Arcade", 70);
            ConsolaDeMesa xboxOne = new ConsolaDeMesa("Xbox One", 100);
            ConsolaDeMesa xboxSeriesX = new ConsolaDeMesa("Xbox series x", 149);
            ConsolaDeMesa xboxSeriesS = new ConsolaDeMesa("Xbox series s", 200);
            ConsolaDeMesa xboxOneX = new ConsolaDeMesa("Xbox One x", 299);
            ConsolaDeMesa xboxOneXS = new ConsolaDeMesa("Xbox One X Slim", 499);
       
            ProductoXbox.Add(xbox);
            ProductoXbox.Add(xbox360);
            ProductoXbox.Add(xbox360A);
            ProductoXbox.Add(xboxOne);
            ProductoXbox.Add(xboxSeriesX);
            ProductoXbox.Add(xboxSeriesS);
            ProductoXbox.Add(xboxSOneX);
            ProductoXbox.Add(xboxOneXS);

             


            return ProductoXbox;
        }

        public static List<ConsolaDeMesa> NintendoProductos()
        {
            List<ConsolaDeMesa> ProductoNintendo = new List<ConsolaDeMesa>();
            
            ConsolaDeMesa GameCube = new ConsolaDeMesa("Game Cube", 10);
            ConsolaDeMesa superNintendo = new ConsolaDeMesa("Super Nintendo ", 20);
            ConsolaDeMesa Nintendo64 = new ConsolaDeMesa("Nintendo 64", 30);
            ConsolaDeMesa Wii= new ConsolaDeMesa("Wii", 60);
            ConsolaDeMesa GameBoy= new ConsolaDeMesa("Game Boy", 45);
            ConsolaDeMesa Nswitch = new ConsolaDeMesa("switch", 299);
            ConsolaDeMesa Nds= new ConsolaDeMesa("Nintendo ds", 399);
            ConsolaDeMesa NsMario= new ConsolaDeMesa("Nintendo switch edicion Mario ", 799);
            
            ProductoNintendo.Add(GameCube);
            ProductoNintendo.Add(superNintendo );  
            ProductoNintendo.Add(Nintendo64); 
            ProductoNintendo.Add(Wii);
            ProductoNintendo.Add(GameBoy);
            ProductoNintendo.Add(Nswitch);
            ProductoNintendo.Add(Nds);
             ProductoNintendo.Add(NsMario);
            
            
          
            return ProductoNintendo;
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
