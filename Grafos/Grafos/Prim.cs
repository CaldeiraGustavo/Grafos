using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public static class Prim
    {        
        private static List<Vertice> verticesConhecidos = new List<Vertice>();
        private static Vertice vOrigem;

        public static Grafo execute(Vertice origem, GrafoNaoDirigido grafo)
        {
            GrafoNaoDirigido arvore = new GrafoNaoDirigido(grafo.gerarGrafoNulo());            

            vOrigem = origem;

            Aresta aresta = selecionarAresta(origem);

            while (aresta != null)
            {
                //adiciona a aresta a arvore
                arvore.adicionarAresta(vOrigem.id, aresta.vertice.id, aresta.peso);

                //seleciona a aresta de menor peso
                aresta = selecionarAresta(aresta.vertice);                
            }

            return arvore;
        }

        private static Aresta selecionarAresta(Vertice v)
        {
            v.cor = "VERDE";
            verticesConhecidos.Add(v);

            return encontrarMenorPeso();
        }

        private static Aresta encontrarMenorPeso()
        {
            int peso = 10000;

            Aresta arestaSelecionada = null;

            foreach (Vertice v in verticesConhecidos)
            {
                foreach (Aresta aresta in v.adjacentes)
                {
                    if (aresta.peso < peso && aresta.vertice.cor == "BRANCO")
                    {
                        peso = aresta.peso;
                        arestaSelecionada = aresta;
                        vOrigem = v;
                    }

                }
            }

            return arestaSelecionada;
        }
    }
}
