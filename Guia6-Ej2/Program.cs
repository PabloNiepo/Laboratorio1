using System;
using System.Threading;

namespace Guia6_Ej2
{
    class Program
    {
        static void menu()
        {
            Console.Clear();
            Console.CursorTop = 0;
            Console.Write("╔");
            for (int x = 1; x <= 50; x++)
                Console.Write("═");
            Console.Write("╗");
            Console.CursorTop = 9;
            Console.CursorLeft = 0;
            Console.Write("╚");
            for (int x = 1; x <= 50; x++)
                Console.Write("═");
            Console.Write("╝");
            Console.CursorLeft = 0;
            for (int y = 1; y <= 8; y++)
            {
                Console.CursorLeft = 0;
                Console.CursorTop = y;
                string nada = " ";
                Console.Write("║" + nada.PadLeft(50) + "║");
            }
        }
            static Random rand = new Random();



        static void Main(string[] args)
        {
            int nrolote;
            int opcion =0;
            Console.WriteLine("Ingrese un numero de lote");
            nrolote = Convert.ToInt16(Console.ReadLine());
            Lote obj = new Lote(nrolote);
            while (opcion != -1)
            {
                //menu();
                Console.SetCursorPosition(0, 1);
                Console.Clear();
                Console.WriteLine("*** Ingrese una opcion ***");
                Console.WriteLine("__________________________");
                Console.WriteLine(" 1 - Medicion correcta     ");
                Console.WriteLine(" 2 - Medicion incorrecta   ");
                Console.WriteLine("--------------------------");
                Console.WriteLine("-1 - Para salir");
                opcion = Convert.ToInt16((Console.ReadLine()));

                switch (opcion)
                {
                    case 1:
                        obj.RegistrarPrueba(true);
                        Console.WriteLine("Ingreso 1");                       
                        Thread.Sleep(10);
                        break;
                    case 2:
                        obj.RegistrarPrueba(false);
                        Console.WriteLine("Ingreso 2");
                        Thread.Sleep(10);
                        break;
                    case -1:
                        Console.WriteLine(" Fin de lote");
                        Thread.Sleep(10);
                        break;
                    default:
                        Console.WriteLine("...Opcion invalida.");
                        Thread.Sleep(20);
                        break;
                }
            }

            //int resultado = rand.Next(2);
            //for (int n = 1; n < 20; n++)           
            //obj.RegistrarPrueba(resultado == 1);

            Console.WriteLine("Cantidad de productos: {0}", obj.Cantidad);
            Console.WriteLine("Porcentaje de Correctos: {0:f2}", obj.PorcCorrectos);
            Console.WriteLine("Total de Fallados {0}", obj.Fallados);

            Console.ReadKey();

        }
    }
}
