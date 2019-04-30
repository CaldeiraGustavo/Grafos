using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class GrafoNaoDirigido : Grafo
    {
        public GrafoNaoDirigido(Vertice[] vertices) : base(vertices)
        {

        }

        public bool isAdjacente(Vertice v1, Vertice v2)
        {
            foreach (Vertice vertice in vertices)
            {
                if (vertice == v1)
                {
                    foreach (Aresta a in v1.adjacentes)
                    {
                        if (a.vertice == v2) { return true; }
                    }
                }
            }
            return false;
        }


        public int getGrau(Vertice v1)
        {
            return v1.adjacentes.Count();
        }

        public bool isIsolado(Vertice v1)
        {
            return v1.adjacentes.Count() == 0;
        }
        // Pendentes são vertices que possuem somente uma aresta adjacente
        public bool isPendente(Vertice v1)
        {
            return v1.adjacentes.Count() == 1;
            
        }

        // Vertice Regular -> Todos os vétices tem o mesmo grau
        public bool isRegular()
        {
            int grau = vertices[0].adjacentes.Count();

            foreach (Vertice vertice in vertices)
            {
                if (grau != vertice.adjacentes.Count()) { return false; }
            }
            return true;
        }

        public bool isNulo()
        {
            foreach (Vertice vertice in vertices)
            {
                if (vertice.adjacentes.Count() != 0) { return false; }
            }
            return true;
        }

        public bool isCompleto()
        {
            int numeroVertices = vertices.Count();

            foreach (Vertice vertice in vertices)
            {
                if (getGrau(vertice) < numeroVertices - 1)
                {
                    return false;
                }
            }

            return true;
        }

        public bool isConexo()
        {
            int componentes = 0;

            this.LimparCorVertices();

            //Faz uma busca em profundidade para descobrir a quantidade de componentes conexos;
            foreach (Vertice vertice in vertices)
            {
                if (vertice.cor == "BRANCO")
                {
                    VisitarDFS(vertice);
                    componentes++;
                }
            }

            return componentes == 1;
        }

        //Metodo Visitar da busca em profundidade
        private void VisitarDFS(Vertice vertice)
        {
            vertice.cor = "CINZA";

            foreach (var aresta in vertice.adjacentes)
            {
                if (aresta.vertice.cor == "BRANCO")
                {
                    VisitarDFS(aresta.vertice);
                }
            }

            vertice.cor = "PRETO";
        }

        public bool isEuleriano()
        {
            //Um grafo que não é conexo não pode ser Euleriano
            if (!isConexo())
            {
                return false;
            }

            foreach (Vertice vertice in vertices)
            {
                //Verifica se todos os vertices possuem grau par, caso contráio o mesmo não é euleriano
                if ((getGrau(vertice) % 2) != 0)
                {
                    return false;
                }
            }

            //Significa que todos os vertices tem grau par 
            return true;

        }

        public bool isUnicursal()
        {
            //Um grafo que não é conexo não pode ser Unicursal
            if (!isConexo())
            {
                return false;
            }

            int verticesGrauImpar = 0;

            foreach (Vertice vertice in vertices)
            {
                //Verifica quantos vértices possuem grau par
                if ((getGrau(vertice) % 2) != 0)
                {
                    verticesGrauImpar++;
                }
            }

            //O grafo é Unicursal se 2k vértices possuem grau impar
            if (verticesGrauImpar % 2 == 0)
            {
                return true;
            }
            else { return false; }
        }

        public Grafo getComplementar()
        {
            //Gera um grafo completo
            Grafo grafoComplementar = this.GerarGrafoCompleto();

            //Percorre todos os vertices e retira do grafo completo as arestas que existem no grafo original,
            //Resultando em seu grafo complementar.
            for (int i = 0; i < vertices.Length; i++)
            {
                foreach (var aresta in vertices[i].adjacentes)
                {
                    grafoComplementar.vertices[i].RemoveVerticeAdjacente(aresta.vertice.id);
                }
            }

            return grafoComplementar;
        }

        private Grafo GerarGrafoCompleto()
        {
            Vertice[] verts = new Vertice[NumeroVertices()];

            for (int i = 0; i < verts.Length; i++)
            {
                verts[i] = new Vertice(i + 1);
            }

            for (int i = 0; i < verts.Length; i++)
            {
                for (int j = 0; j < verts.Length; j++)
                {
                    if (i != j)
                    {
                        verts[i].AddVerticeAdjacente(verts[j], 1);
                    }
                }

            }

            return new GrafoNaoDirigido(verts);
        }

        //Aguardando a disponibilação do slide
        public Grafo getAGMPrim(Vertice v1)
        {
            return null;
        }

        public Grafo getAGMKruskal(Vertice v1)
        {
            return null;
        }

        public int getCutVertices()
        {
            return 0;
        }        

    }
}
