using System;

namespace Guia6_Ej2
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            Lote obj = new Lote(1);

            int resultado = rand.Next(2);
            for (int n = 1; n < 20; n++)
                obj.RegistrarPrueba(resultado == 1);

            Console.WriteLine("Cantidad de productos: {0}", obj.Cantidad);
            Console.WriteLine("Porcentaje de Correctos: {0:f2}", obj.PorcCorrectos);
            Console.WriteLine("Total de Fallados {0}", obj.Fallados);

            Console.ReadKey();

        }
    }
}
