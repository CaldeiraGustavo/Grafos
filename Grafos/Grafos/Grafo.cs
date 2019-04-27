using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public abstract class Grafo
    {       
        public Vertice[] vertices { get; set; }

        public Grafo(Vertice[] vertices)
        {
            this.vertices = vertices;
        }

        protected void LimparCorVertices()
        {
            foreach (Vertice vertice in vertices)
            {
                vertice.cor = "BRANCO";
            }

        }

        public int NumeroVertices()
        {
            return this.vertices.Length;
        }       


    }
}
