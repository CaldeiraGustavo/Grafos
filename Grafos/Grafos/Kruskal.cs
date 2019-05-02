using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Kruskal : GrafoNaoDirigido
    {
        public List<Vertice> AGM { get; set; }

        public Kruskal(Vertice[] vertices) : base(vertices)
        {

        }



        public void AdicionarLista(Vertice vertice)
        {

        }


        public void getAGMKruskal()
        {
            int numArestas = 0;
            Vertice novo = new Vertice(0);
            Vertice v;

            while (numArestas < vertices.Length - 1)
            {
                v = MenorArestaGrafo();
                Aresta aresta = v.ArestaMenorPeso();
                aresta.visitada = true;
                novo.adjacentes.Add(aresta);
                AdicionarLista(novo);

                aresta = ArestaRetorno(v, aresta.vertice);

                if (aresta != null)
                {
                    aresta.visitada = true;
                }
                numArestas++;


            }

        }

        private Vertice MenorArestaGrafo()
        {
            Vertice verPesoMin = vertices[0];
            Aresta arestaMenorPeso = vertices[0].ArestaMenorPeso();

            for (int j = 1; j < vertices.Length; j++)
            {
                if (vertices[j].ArestaMenorPeso().peso < arestaMenorPeso.peso)
                {
                    verPesoMin = vertices[j];
                }
            }

            return verPesoMin;
        }


        private Aresta ArestaRetorno(Vertice v1, Vertice v2)
        {
            foreach (Aresta a1 in v1.adjacentes)
            {
                foreach (Aresta a2 in v2.adjacentes)
                {
                    if ((!a1.visitada) && (!a2.visitada) && (a1.vertice.id == a2.vertice.id))
                    {
                        return a2;
                    }
                }
            }

            return null;
        }





    }
}
