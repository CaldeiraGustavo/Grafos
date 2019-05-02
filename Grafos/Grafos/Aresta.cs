using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public class Aresta
    {
        public Vertice vertice { get; set; }
        public int peso { get; set; }
        public bool visitada { get; set; } // true indica que foi visitada/ false; não foi visitada

        public Aresta(Vertice vertice, int peso)
        {
            this.vertice = vertice;
            this.peso = peso;
        }
    }
}
