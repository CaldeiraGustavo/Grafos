using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public abstract class Grafo
    {

        public Grafo()
        {

        }

        public abstract bool isAdjacente(Vertice v1, Vertice v2);

        public abstract int getGrau(Vertice v1);

        public abstract bool isIsolado(Vertice v1);

        public abstract bool isPendente(Vertice v1);

        public abstract bool isRegular();

        public abstract bool isNulo();

        public abstract bool isCompleto();

        public abstract bool isConexo();

        public abstract bool isEuleriano();

        public abstract bool isUnicursal();

        public abstract Grafo getComplementar();

        public abstract Grafo getAGMPrim(Vertice v1);

        public abstract Grafo getAGMKruskal(Vertice v1);

        public abstract int getCutVertices();



    }
}
