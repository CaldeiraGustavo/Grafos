using System.Collections.Generic;

namespace Grafos
{
    public class Vertice
    {
        public int id;

        public string cor;
        
        //Lisa de vértices adjacentes (Contendo o vértice e o peso da aresta)
        public Dictionary<Vertice, int> adjacentes;

        public Vertice(int id)
        {
            this.id = id;
            this.cor = "BRANCO";
        }

        public void AddVerticeAdjacente (Vertice vertice, int peso)
        {            
            adjacentes.Add(vertice, peso);                     
        }

         


    }
}