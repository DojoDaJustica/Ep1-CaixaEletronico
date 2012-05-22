using DojoTJ_Episodio1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Collections.Generic;

namespace DojoTJ_Episodio1Tests
{


    /// <summary>
    ///This is a test class for CaixaTest and is intended
    ///to contain all CaixaTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CaixaTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Saque
        ///</summary>
        [TestMethod()]
        public void SaqueDe100Test()
        {
            Caixa target = new Caixa(); // TODO: Initialize to an appropriate value
            long valor = 100; // TODO: Initialize to an appropriate value
            // TODO: Initialize to an appropriate value
            List<Nota> notas;

            //if (notas.Count != 1)
            //    Assert.Fail("O número de notas para o saque de cem reais foi diferente do esperado.");7

            //if (notas.Single().Nota != NotaDisponivel.CemReais)
            //    Assert.Fail("A nota retornada não é de cem reais.");

            //Assert.AreEqual(notas.Single().Nota, NotaDisponivel.CemReais);
        }




        /// <summary>
        ///A test for Caixa Constructor
        ///</summary>
        [TestMethod()]
        public void TesteNotaValida()
        {
            Caixa teste = new Caixa();
            bool expected = true;
            Assert.AreEqual(expected, teste.SaqueValido(235));
        }


    }
}
