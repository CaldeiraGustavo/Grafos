using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public abstract class Grafo
    {       
        private List<Vertice> vertices;

        public Grafo()
        {          
              
        }

        public void addVertice (Vertice vertice)
        {
            this.vertices.Add(vertice);
        }

        public abstract bool isAdjacente(Vertice v1, Vertice v2);

        public abstract int getGrau(Vertice v1);

        public abstract bool isIsolado(Vertice v1);

        public abstract bool isPendente(Vertice v1);

        public abstract bool isRegular();

        public abstract bool isNulo();

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

            //Faz uma busca em profundidade para descobrir a quantidade de componentes conexos;
            foreach (Vertice vertice in vertices)
            {
                if (vertice.cor == "BRANCO")
                {
                    Visitar(vertice);
                    componentes++;
                }
            }

            return componentes > 1;
        }

        //Metodo Visitar da busca em profundidade
        private void Visitar(Vertice vertice)
        {
            vertice.cor = "CINZA";

            foreach (var vert in vertice.adjacentes)
            {
                if (vert.Key.cor == "BRANCO")
                {
                    Visitar(vertice);
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
            Grafo grafo = new Grafo();

            return grafo;

        }

        //Sarah
        public abstract Grafo getAGMPrim(Vertice v1);


        public abstract Grafo getAGMKruskal(Vertice v1);


        public abstract int getCutVertices();

        public bool hasLoops()
        {
            return false;
        }



    }
}
