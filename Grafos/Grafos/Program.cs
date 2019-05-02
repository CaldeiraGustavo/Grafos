using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Program
    {
        static void Main(string[] args)
        {

            GrafoNaoDirigido g = LeituraArquivo.GrafoNaoDirigido(@"..\..\..\GrafosTests2\txts\NaoDirigido\PrimEsperado.txt");

            g.Imprimir();

            Console.ReadKey();

        }
    }
}
