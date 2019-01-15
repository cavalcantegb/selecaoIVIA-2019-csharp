using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Dominio;

namespace Dominio.Tests
{
    class PalavrasPrimasTest
    {
        [Test]
        public void DeveRetornar1ParaAMinusculo()
        {
            var palavraPrima = new PalavraPrima("a");
            int resultado = palavraPrima.calculaSomaDaPalavra();
            Assert.AreEqual(1, resultado);
        }
    }
}
