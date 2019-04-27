using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grafos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosTests2
{
    public class GrafoNaoDirigidoBuilder
    {
        private Grafo grafo;
        public GrafoNaoDirigidoBuilder()
        {

        }

        public GrafoNaoDirigidoBuilder GrafoEuleriano()
        {
            this.grafo = LeituraArquivo.GrafoNaoDirigido(@"C:\Temp\Grafo\Grafo1.txt");
            return this;
        }

        public GrafoNaoDirigido Build()
        {
            return new GrafoNaoDirigido(grafo.vertices);
        }


    }
}
