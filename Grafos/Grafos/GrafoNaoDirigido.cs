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
            return false;
        }

        public int getGrau(Vertice v1)
        {
            return 0;
        }

        public bool isIsolado(Vertice v1)
        {
            return false;
        }

        public bool isPendente(Vertice v1)
        {
            return false;
        }

        public bool isRegular()
        {
            return false;
        }

        public bool isNulo()
        {
            return false;
        }

        //Sarah
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

        //Sarah
        public bool isConexo()
        {
            int componentes = 1;

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
                    VisitarDFS(vertice);
                }
            }

            vertice.cor = "PRETO";
        }

        //Sarah
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

        //Sarah
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

        //Sarah
        public Grafo getComplementar()
        {            

            Vertice[] verticesGrafoComplementar = new Vertice[NumeroVertices()];

            return null;

        }

        private Grafo GerarGrafoCompleto()
        {
            return null;
        }

        //Sarah
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
