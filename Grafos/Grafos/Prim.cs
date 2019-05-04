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

        public static GrafoNaoDirigido execute(Vertice origem, GrafoNaoDirigido grafo)
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
                    if (aresta.peso <= peso && aresta.vertice.cor == "BRANCO")
                    {
                        if (aresta.peso == peso)
                        {
                            Aresta arestaEscolhida = ArestasComMesmoPeso(arestaSelecionada, aresta, v);

                            peso = arestaEscolhida.peso;
                            arestaSelecionada = arestaEscolhida;
                        }
                        else
                        {
                            peso = aresta.peso;
                            arestaSelecionada = aresta;
                            vOrigem = v;
                        }                                  
                        
                    }

                }
            }

            return arestaSelecionada;
        }

        private static Aresta ArestasComMesmoPeso(Aresta arestaAtual, Aresta arestaOutra, Vertice v)
        {
            if ((vOrigem.id + arestaAtual.vertice.id) >= (v.id + arestaOutra.vertice.id))
            {                
                vOrigem = v;
                return arestaOutra;
            }
            else
            {
                if ((vOrigem.id + arestaAtual.vertice.id) == (v.id + arestaOutra.vertice.id))
                {
                    int indice1 = Math.Min(vOrigem.id, arestaAtual.vertice.id);
                    int indice2 = Math.Min(v.id, arestaOutra.vertice.id);

                    if (indice2 < indice1)
                    {
                        vOrigem = v;
                        return arestaOutra;                        
                    }
                    else
                    {
                        return arestaAtual;
                    }                       

                }

                return arestaAtual;
            }
        }
    }
}
