using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grafos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosTests2
{
    public class GrafoDirigidoBuilder
    {
        private Grafo grafo;
        public GrafoDirigidoBuilder()
        {

        }

        public GrafoDirigidoBuilder GrafoComCiclo()
        {
            this.grafo = LeituraArquivo.GrafoNaoDirigido(@"C:\Temp\Grafo\Grafo2.txt");
            return this;
        }

        public GrafoDirigido Build()
        {
            return new GrafoDirigido(grafo.vertices);
        }


    }
}
