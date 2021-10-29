using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ExpressoesMatematicas.UnitTest
{
    [TestClass]
    public class CalculadoraTests
    {
        Calculadora calculadora;
        public CalculadoraTests()
        {
            calculadora = new Calculadora();
        }

        [TestMethod]
        public void deveCalcularSomaEmParenteses()
        {
            //arrange
            string valoresParaCalcular = "1 + ( 1 + 1 )";
            //act
            double resultado = calculadora.Calcular(valoresParaCalcular);
            //assert
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void deveCalcularSomar()
        {
            //arrange
            string valoresParaCalcular = "1 + 1 ";
            //act
            double resultado = calculadora.Calcular(valoresParaCalcular);
            //assert
            Assert.AreEqual(2, resultado);
        }
    }
}
