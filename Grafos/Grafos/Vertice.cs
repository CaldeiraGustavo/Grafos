using System.Collections.Generic;

namespace Grafos
{
    public class Vertice
    {
        public int id { get; set; }

        public string cor { get; set; }

        //Lisa de vértices adjacentes (Contendo o vértice e o peso da aresta)
        public List<Aresta> adjacentes { get; set; }

        public Vertice(int id)
        {
            this.id = id;
            this.adjacentes = new List<Aresta>();
        }

        public void AddVerticeAdjacente(Vertice vertice, int peso)
        {
            adjacentes.Add(new Aresta(vertice, peso));
        }





    }
}