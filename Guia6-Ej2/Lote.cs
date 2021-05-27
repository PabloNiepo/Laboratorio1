using System;
using System.Collections.Generic;
using System.Text;

namespace Guia6_Ej2
{
    class Lote
    {
        int numero;
        int cantidad, correctos, fallados;

        public Lote(int nroLote)
        {
            this.numero = nroLote;
        }

        public int Numero {get {return numero; } }
        public int Cantidad { get { return cantidad; } }

        public double PorcCorrectos
        {
            get
            {
                double porcor;
                porcor = correctos * 100 / cantidad;

                return porcor;
            }
        }
        public int Fallados { get { return fallados; } }

        public bool RegistrarPrueba(bool esCorrecto)
        {
            cantidad++;
            if (esCorrecto)
            {
                correctos++;
            }
            else
            {
                fallados++;
            }
            return true;
        }

       
                               
    }


}
