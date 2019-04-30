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
            this.grafo = LeituraArquivo.GrafoNaoDirigido(@"..\..\txts\NaoDirigido\Conexo,Completo,Euleriano,Unicursal.txt");
            return this;
        }

        public GrafoNaoDirigidoBuilder GrafoNaoEuleriano()
        {
            this.grafo = LeituraArquivo.GrafoNaoDirigido(@"..\..\txts\NaoDirigido\Conexo,NaoCompleto,NaoEuleriano,Unicursal.txt");
            return this;
        }

        public GrafoNaoDirigidoBuilder GrafoCompleto()
        {
            this.grafo = LeituraArquivo.GrafoNaoDirigido(@"..\..\txts\NaoDirigido\Conexo,Completo,NaoEuleriano,NaoUnicursal.txt");
            return this;
        }

        public GrafoNaoDirigidoBuilder GrafoNaoCompleto()
        {
            this.grafo = LeituraArquivo.GrafoNaoDirigido(@"..\..\txts\NaoDirigido\Conexo,NaoCompleto,NaoEuleriano,Unicursal.txt");
            return this;
            
        }

        public GrafoNaoDirigidoBuilder GrafoConexo()
        {
            this.grafo = LeituraArquivo.GrafoNaoDirigido(@"..\..\txts\NaoDirigido\Conexo,Completo,NaoEuleriano,NaoUnicursal.txt");
            return this;
        }

        public GrafoNaoDirigidoBuilder GrafoNaoConexo()
        {
            this.grafo = LeituraArquivo.GrafoNaoDirigido(@"..\..\txts\NaoDirigido\NaoConexo.txt");
            return this;
        }

        public GrafoNaoDirigidoBuilder GrafoNaoUnicursal()
        {
            this.grafo = LeituraArquivo.GrafoNaoDirigido(@"..\..\txts\NaoDirigido\Conexo,Completo,NaoEuleriano,NaoUnicursal.txt");
            return this;
        }

        public GrafoNaoDirigidoBuilder GrafoUnicursal()
        {
            this.grafo = LeituraArquivo.GrafoNaoDirigido(@"..\..\txts\NaoDirigido\Conexo,NaoCompleto,NaoEuleriano,Unicursal.txt");
            return this;
        }

        public GrafoNaoDirigidoBuilder GrafoComplementar()
        {
            this.grafo = LeituraArquivo.GrafoNaoDirigido(@"..\..\txts\NaoDirigido\Complementar.txt");
            return this;
        }


        public GrafoNaoDirigido Build()
        {
            return new GrafoNaoDirigido(grafo.vertices);
        }


    }
}
