﻿using System;
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
            PalavraPrima palavraPrima = new PalavraPrima("b");
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

        [Test]
        public void DeveRetornar4ParaDMinusculo()
        {
            var palavraPrima = new PalavraPrima("d");
            int resultado = palavraPrima.calculaSomaDaPalavra();
            Assert.AreEqual(4, resultado);
        }

        [Test]
        public void DeveRetornarValorCorretoParaLetraMinuscula()
        {
            var palavraPrima = new PalavraPrima("l");
            int resultado = palavraPrima.calculaSomaDaPalavra();
            Assert.AreEqual(12, resultado);

        }

        [Test]
        public void DeveRetornar27ParaAMaiusculo()
        {
            var palavraPrima = new PalavraPrima("A");
            int resultado = palavraPrima.calculaSomaDaPalavra();
            Assert.AreEqual(27,resultado);
        }

        [Test]
        public void DeveRetornar28ParaBMaiusculo()
        {
            var palavraPrima = new PalavraPrima("B");
            int resultado = palavraPrima.calculaSomaDaPalavra();
            Assert.AreEqual(28, resultado);
        }

        [Test]
        public void DeveRetornar29ParaMaiusculos()
        {
            var palavraPrima = new PalavraPrima("C");
            int resultado = palavraPrima.calculaSomaDaPalavra();
            Assert.AreEqual(29, resultado);
        }

        [Test]
        public void DeveRetornar2ParaAA()
        {
            var palavraPrima = new PalavraPrima("aa");
            int resultado = palavraPrima.calculaSomaDaPalavra();
            Assert.AreEqual(2, resultado);
        }

        [Test]
        public void DeveRetornar6ParaABC()
        {
            var palavraPrima = new PalavraPrima("abc");
            int resultado = palavraPrima.calculaSomaDaPalavra();
            Assert.AreEqual(6, resultado);
        }

        [Test]
        public void DeveRetornar10ParaABCD()
        {
            var palavraPrima = new PalavraPrima("abcd");
            int resultado = palavraPrima.calculaSomaDaPalavra();
            Assert.AreEqual(10, resultado);
        }

        [Test]
        public void DeveRetornarVerdadeiroParaNumeroPrimo1()
        {
            var palavraPrima = new PalavraPrima("a");
            bool numeroPrimo = palavraPrima.verificaNumeroPrimo();
            Assert.AreEqual(true, numeroPrimo);
        }

        [Test]
        public void DeveRetornarVerdadeiroParanNumeroPrimo2()
        {
            var palavraPrima = new PalavraPrima("b");
            bool numeroPrimo = palavraPrima.verificaNumeroPrimo();
            Assert.AreEqual(true, numeroPrimo);
        }

        [Test]
        public void DeveRetornarVerdadeiroParaNumeroPrimo5ComStringDeTamanhoMaiorQueUm()
        {
            var palavraPrima = new PalavraPrima("bc");
            bool numeroPrimo = palavraPrima.verificaNumeroPrimo();
            Assert.AreEqual(true, numeroPrimo);
        }

        [Test]
        public void DeveRetornarVerdadeiroParaNumero7()
        {
            var palavraPrima = new PalavraPrima("be");
            bool numeroPrimo = palavraPrima.verificaNumeroPrimo();
            Assert.AreEqual(true, numeroPrimo);
        }
    }
}
