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

        [Test]
        public void DeveRetornar2ParaBMinusculo()
        {
            var palavraPrima = new PalavraPrima("b");
            int resultado = palavraPrima.calculaSomaDaPalavra();
            Assert.AreEqual(2, resultado);
        }

        [Test]
        public void DeveRetornar3ParaCMinusculo()
        {
            var palavraPrima = new PalavraPrima("c");
            int resultado = palavraPrima.calculaSomaDaPalavra();
            Assert.AreEqual(3, resultado);
        }
    }
}
