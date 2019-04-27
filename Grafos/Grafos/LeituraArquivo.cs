using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    public static class LeituraArquivo
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
                s = arquivoGrafo.ReadLine();

                Vertice[] vertices = new Vertice[qtdVertices];

                int verticeX;
                int verticeY;

                while (s != null)
                {
                    aux = s.Split(';');

                    verticeX = int.Parse(aux[0]) - 1;
                    verticeY = int.Parse(aux[1]) - 1;

                    if (vertices[verticeX] == null)
                    {
                        vertices[verticeX] = new Vertice(verticeX +1);
                    }

                    if (vertices[verticeY] == null)
                    {
                        vertices[verticeY] = new Vertice(verticeY +1);
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

        }

        public static Grafo GrafoDirigido(String nomeArquivo)
        {
            String s;
            String[] aux;

            StreamReader arquivoGrafo;

            try
            {
                arquivoGrafo = new StreamReader(nomeArquivo);

                int qtdVertices = int.Parse(arquivoGrafo.ReadLine());
                s = arquivoGrafo.ReadLine();

                Vertice[] vertices = new Vertice[qtdVertices];

                int verticeX;
                int verticeY;

                while (s != null)
                {
                    aux = s.Split(';');

                    verticeX = int.Parse(aux[0]) - 1;
                    verticeY = int.Parse(aux[1]) - 1;

                    if (vertices[verticeX] == null)
                    {

                        vertices[verticeX] = new Vertice(verticeX);
                    }

                    if (vertices[verticeY] == null)
                    {

                        vertices[verticeY] = new Vertice(verticeY);
                    }

                    int adjacencia = int.Parse(aux[3]);

                    if (adjacencia > 0)
                    {
                        vertices[verticeX].AddVerticeAdjacente(vertices[verticeY], int.Parse(aux[2]));
                    }
                    else
                    {
                        vertices[verticeY].AddVerticeAdjacente(vertices[verticeX], int.Parse(aux[2]));
                    }

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

        }
    }
}
