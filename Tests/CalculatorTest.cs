using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CItest;

namespace Tests
{
    /// <summary>
    /// Сводное описание для CalculatorTest
    /// </summary>
    [TestClass]
    public class CalculatorTest
    {
        static Calculator calc;

        public CalculatorTest()
        {
            
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Получает или устанавливает контекст теста, в котором предоставляются
        ///сведения о текущем тестовом запуске и обеспечивается его функциональность.
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

        #region Дополнительные атрибуты тестирования
        //
        // При написании тестов можно использовать следующие дополнительные атрибуты:
        //
         //ClassInitialize используется для выполнения кода до запуска первого теста в классе
         [ClassInitialize()]
         public static void MyClassInitialize(TestContext testContext) 
         {
             calc = new Calculator();
         }
        
        // ClassCleanup используется для выполнения кода после завершения работы всех тестов в классе
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // TestInitialize используется для выполнения кода перед запуском каждого теста 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // TestCleanup используется для выполнения кода после завершения каждого теста
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestCalculatorAdd()
        {
            Assert.AreEqual(9, calc.Eval(5, 4, Operations.Add));
            Assert.AreEqual(1, calc.Eval(5, -4, Operations.Add));
            Assert.AreEqual<double>(0.1d, calc.Eval(4.1d, -4d, Operations.Add));
        }

        [TestMethod]
        public void TestCalculatorSub()
        {
            Assert.AreEqual(1, calc.Eval(5, 4, Operations.Sub));
            Assert.AreEqual(9, calc.Eval(5, -4, Operations.Sub));
            Assert.AreEqual(6.3, calc.Eval(2.3, -4, Operations.Sub));
        }

        [TestMethod]
        public void TestCalculatorDiv()
        {
            Assert.AreEqual(5, calc.Eval(20, 4, Operations.Div));
            Assert.AreEqual(-3, calc.Eval(15, -5, Operations.Div));
            Assert.AreEqual(0.3, calc.Eval(2.1, 7, Operations.Div));
        }

        [TestMethod]
        public void TestCalculatorMul()
        {
            Assert.AreEqual(16, calc.Eval(4, 4, Operations.Mul));
            Assert.AreEqual(12, calc.Eval(4, 3, Operations.Mul));
        }
    }
}
