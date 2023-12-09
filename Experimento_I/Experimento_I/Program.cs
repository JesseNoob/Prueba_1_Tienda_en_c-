using Experimento_III;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
namespace ExperimentoIII
{
    class Principal
    {

        public static string comandos;
        public static void InteraccionConElUsuario(string marca)
        {

            List<ConsolaDeMesa> carrito = new List<ConsolaDeMesa>();
            List<ConsolaDeMesa> ps = PSproductos();
            List<ConsolaDeMesa> xbox = XBXproductos();
            List<ConsolaDeMesa> nintendo = NINproductos();
            double resultado = 0;
            
            marca = comandos;
            if (marca == "playstation") {
                int opcion;
                do
                {
                    //Ingrese la opcion
                    Console.SetCursorPosition(160, 4);
                    opcion = int.Parse(Console.ReadLine());
                    if (opcion <= 0 && opcion > 8)
                    {
                        //Console.WriteLine("Dato erroneo");
                        continue;
                    }
                    //Agregar?
                    Console.SetCursorPosition(150, 5);
                    comandos = Console.ReadLine().ToLower();
                    if (VerificarComandos(comandos) == false)
                    {
                        //Console.Write("comando erroneo");
                        continue;
                    }

                    switch (comandos)
                    {
                        // "agregar", "comprar", "salir", "eliminar"
                        case "agregar":
                            carrito.Add(ps[opcion - 1]);
                            break;
                        case "borrar":
                            if (carrito.Count <= 0)
                            {
                                //Console.WriteLine("Accion imposible de hacer");
                                continue;
                            } else
                            {
                                carrito.Remove(ps[(opcion - 1) - 1]);
                                break;
                            }
                        case "comprar":
                            Console.Clear();
                            Console.WriteLine("Productos comprados: \n");
                            foreach (var producto in carrito)
                            {
                                Console.WriteLine(producto.Nombre + " precio: " + producto.Precio);
                            }
                            for (int i = 0; i<carrito.Count; i++)
                            {
                                resultado = resultado + carrito[i].Precio;
                            }
                            Console.WriteLine("Total a pagar: \n "+resultado);

                            break;

                        case "salir":
                            continue;
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("opcion no encontrada");
                            break;

                    }

                } while (comandos != "salir");
            }/*else if (marca == "xbox")
            {
                int opcion;
                do
                {
                    //Ingrese la opcion
                    Console.SetCursorPosition(160, 4);
                    opcion = int.Parse(Console.ReadLine());
                    if (opcion <= 0 && opcion > 8)
                    {
                        //Console.WriteLine("Dato erroneo");
                        continue;
                    }
                    //Agregar?
                    Console.SetCursorPosition(150, 5);
                    comandos = Console.ReadLine().ToLower();
                    if (VerificarComandos(comandos) == false)
                    {
                        //Console.Write("comando erroneo");
                        continue;
                    }

                    switch (comandos)
                    {
                        // "agregar", "comprar", "salir", "eliminar"
                        case "agregar":
                            carrito.Add(xbox[opcion - 1]);
                            break;

                    }
                } while (comandos != "salir");

            }
            else if (marca=="nintendo")
            {
                int opcion;
                do
                {
                    //Ingrese la opcion
                    Console.SetCursorPosition(160, 4);
                    opcion = int.Parse(Console.ReadLine());
                    if (opcion <= 0 && opcion > 8)
                    {
                        //Console.WriteLine("Dato erroneo");
                        continue;
                    }
                    //Agregar?
                    Console.SetCursorPosition(150, 5);
                    comandos = Console.ReadLine().ToLower();
                    if (VerificarComandos(comandos) == false)
                    {
                        //Console.Write("comando erroneo");
                        continue;
                    }

                    switch (comandos)
                    {
                        // "agregar", "comprar", "salir", "eliminar"
                        case "agregar":
                            carrito.Add(nintendo[opcion - 1]);
                            break;

                    }
                } while (comandos != "salir");

            }*/




        }  
        
        public static List<ConsolaDeMesa> PSproductos()
        {
            //Ejemplo
            List<ConsolaDeMesa> ProductoPS = new List<ConsolaDeMesa>();
            ConsolaDeMesa ps1 = new ConsolaDeMesa("PlayStation 1", 30);
            ConsolaDeMesa ps2 = new ConsolaDeMesa("PlayStation 2", 40);
            ConsolaDeMesa ps3 = new ConsolaDeMesa("PlayStation 3", 100);
            ConsolaDeMesa ps4 = new ConsolaDeMesa("PlayStation 4", 240);
            ConsolaDeMesa psvitaSlim = new ConsolaDeMesa("PlayStation Vita Slim", 100);
            ConsolaDeMesa psvita = new ConsolaDeMesa("psvita", 30);
            ConsolaDeMesa psp = new ConsolaDeMesa("psp", 40);
            ConsolaDeMesa pspGold = new ConsolaDeMesa("pspGold", 300);
            ProductoPS.Add(ps1);
            ProductoPS.Add(ps2);
            ProductoPS.Add(ps3);
            ProductoPS.Add(ps4);
            ProductoPS.Add(psvitaSlim);
            ProductoPS.Add(psvita);
            ProductoPS.Add(psp);
            ProductoPS.Add(pspGold);
            return ProductoPS;
        }
        public static List<ConsolaDeMesa> XBXproductos()
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
            ProductoXbox.Add(xboxOneX);
            ProductoXbox.Add(xboxOneXS);
            return ProductoXbox;
        }
        public static List<ConsolaDeMesa> NINproductos()
        {
            List<ConsolaDeMesa> ProductoNintendo = new List<ConsolaDeMesa>();

            ConsolaDeMesa GameCube = new ConsolaDeMesa("Game Cube", 10);
            ConsolaDeMesa superNintendo = new ConsolaDeMesa("Super Nintendo ", 20);
            ConsolaDeMesa Nintendo64 = new ConsolaDeMesa("Nintendo 64", 30);
            ConsolaDeMesa Wii = new ConsolaDeMesa("Wii", 60);
            ConsolaDeMesa marioSwitch = new ConsolaDeMesa("Mario Switch", 90);
            ConsolaDeMesa GameBoy = new ConsolaDeMesa("Game Boy", 45);
            ConsolaDeMesa Nswitch = new ConsolaDeMesa("switch", 299);
            ConsolaDeMesa Nds = new ConsolaDeMesa("Nintendo ds", 399);

            ProductoNintendo.Add(GameCube);
            ProductoNintendo.Add(superNintendo);
            ProductoNintendo.Add(Nintendo64);
            ProductoNintendo.Add(Wii);
            ProductoNintendo.Add(marioSwitch);
            ProductoNintendo.Add(GameBoy);
            ProductoNintendo.Add(Nswitch);
            ProductoNintendo.Add(Nds);



            return ProductoNintendo;
        }
        public static void ConfigurarVentana(int ancho, int altura)
        {
            Ventana LongitudDeLaVentana = new Ventana(ancho, altura);
        }
        public static void DibujarPresentacion()
        {
            Interfaz marcoDeLaVentana = new Interfaz(new Point(4, 2), new Point(172, 50));
            marcoDeLaVentana.DibujarCuadrado();
            Console.SetCursorPosition(70, 26);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Bienvenido a la tienda \"Consolas Epicas\" ");
            Console.ResetColor();
            
        }
        public static void DibujarPrimerMenu()
        {
            Interfaz marcoDeLaVentana = new Interfaz(new Point(4, 2), new Point(172, 50));
            Interfaz Contenedor = new Interfaz(new Point(9, 9), new Point(167, 25));
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
            Console.SetCursorPosition(9, 30);
            for (int i = Contenedor.EsquinaSuperiorIzquierda.X; i <= Contenedor.EsquinaInferiorDerecha.X - 79; i++)
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
            List<ConsolaDeMesa> productosDePlayStation = PSproductos();
            List<ConsolaDeMesa> productosDeXbox = XBXproductos();
            List<ConsolaDeMesa> productosDeNintendo = NINproductos();


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
            Console.Write("Comando: ");
            if (comandos=="playstation")
            {
                EscribirItems(productosDePlayStation);
                InteraccionConElUsuario(comandos);//Tiene una marca
            }else if (comandos=="xbox")
            {
                EscribirItems(productosDeXbox);
                InteraccionConElUsuario(comandos);//Tiene una marca
            }
            else if(comandos=="nintendo")
            {
                EscribirItems(productosDeNintendo);
                InteraccionConElUsuario(comandos);//Tiene una marca
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
                Console.SetCursorPosition(27, y);
                Console.WriteLine((i + 1) + ") " + items[i].Nombre);
                Console.SetCursorPosition(30, y+1);
                Console.WriteLine("• Precio: " + items[i].Precio + "$");
                y--;
                y += 6;
            }
            y = 12;
            for (int i = (items.Count / 2); i < items.Count; i++)
            {
                Console.SetCursorPosition(97, y);
                Console.WriteLine((i + 1) + ") " + items[i].Nombre);
                Console.SetCursorPosition(100, y + 1);
                Console.WriteLine("• Precio: " + items[i].Precio + "$");
                y--;
                y += 6;
            }
        }
        public static void Main()
        {
            
            ConfigurarVentana(180, 52);
            DibujarPresentacion();
            Thread.Sleep(5000);
            Console.Clear();
            DibujarPrimerMenu();
            Console.Clear();
            DibujarSegundoMenu();
            Console.ReadKey();

        }
    }
}
