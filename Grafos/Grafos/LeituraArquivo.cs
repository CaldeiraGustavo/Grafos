using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    static class LeituraArquivo
    {
        public static Grafo GrafoNaoDirigido(String nomeArquivo)
        {
            String s;
            String[] aux;

            StreamReader arquivoGrafo;            

            try
            {
                arquivoGrafo = new StreamReader(nomeArquivo);

                int qtdVertices = int.Parse(arquivoGrafo.ReadLine());
                int vAtual = 0;
                s = arquivoGrafo.ReadLine();
                
                Vertice[] vertices = new Vertice[qtdVertices];

                int verticeX;
                int verticeY;

                while (s != null)
                {
                    aux = s.Split(';');
                    
                    verticeX = int.Parse(aux[0]) - 1;
                    verticeY = int.Parse(aux[1]) - 1;
                    
                    if (vertices[verticeX] == null) {
                        
                        vertices[verticeX] = new Vertice(verticeX);                    
                    }
                    
                    if (vertices[verticeY] == null) {
                        
                        vertices[verticeY] = new Vertice(verticeY);                    
                    }      

                    vertices[verticeX].AddVerticeAdjacente(vertices[verticeY], int.Parse(aux[2]));
                    vertices[verticeY].AddVerticeAdjacente(vertices[verticeX], int.Parse(aux[2]));
                    
                    s = arquivoGrafo.ReadLine();

                }
                
                Grafo grafo = new Grafo(vertices);

                arquivoGrafo.Close();
                
                return grafo;

            }

            catch (FileNotFoundException ex)
            {
                throw ex;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return null;
        }
    }
}
