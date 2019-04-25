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

            Grafo grafo = new Grafo();

            try
            {
                arquivoGrafo = new StreamReader(nomeArquivo);

                int qtdVertices = int.Parse(arquivoGrafo.ReadLine());
                s = arquivoGrafo.ReadLine();

                Vertice verticeX;
                Vertice verticeY;

                for (int i = 0; i < qtdVertices; i++)
                {
                    aux = s.Split(';');

                    verticeX = new Vertice(int.Parse(aux[0]));
                    verticeY = new Vertice(int.Parse(aux[1]));

                    verticeX.AddVerticeAdjacente(verticeY, int.Parse(aux[2]));
                    verticeY.AddVerticeAdjacente(verticeX, int.Parse(aux[2]));

                    grafo.addVertice(verticeX);

                }

                arquivoGrafo.Close();

            }

            catch (FileNotFoundException ex)
            {
                throw ex;
            }

            catch (Exception ex)
            {
                throw ex;
            }

            return grafo;
        }
    }
}
