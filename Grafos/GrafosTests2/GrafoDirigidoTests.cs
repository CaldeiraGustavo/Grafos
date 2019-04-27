using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grafos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrafosTests2
{
    [TestClass()]
    public class GrafoDirigidoTests
    {
        [TestMethod()]
        public void isEulerianoTest()
        {
            GrafoDirigido grafo = new GrafoDirigidoBuilder()
                .GrafoComCiclo()
                .Build();

            Assert.Equals(grafo.hasCiclo(), true);
        }

    }
}
