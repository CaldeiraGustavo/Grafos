using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Prim
    {
        private Grafo arvore;
        private List<Vertice> vertices = new List<Vertice>();

        public Grafo execute(Vertice origem, Grafo grafo) {

            arvore = grafo.gerarGrafoNulo();

            Vertice vertice = origem;

            Aresta aresta = selecionarAresta(origem);

            while (vertices.Count() < grafo.NumeroVertices()) {

            }
        }

        private Aresta selecionarAresta(Vertice v) {

            v.cor = "VERDE";
            adjacentes.add(v);

            return encontrarMenorPeso();
        }

        private Aresta encontrarMenorPeso() {

            Integer peso = new Integer(Max.Value);

            Aresta arestaSelecionada = null;

            foreach(Vertice v in vertices){
                foreach (Aresta aresta in v.adjacentes)
            {
                if (aresta.peso < peso && aresta.vertice.cor == "BRANCO") {
                    peso = aresta.peso;
                    arestaSelecionada = aresta;
                }
                
            }
            }

            

            return arestaSelecionada;
        }



    }
    
    }
