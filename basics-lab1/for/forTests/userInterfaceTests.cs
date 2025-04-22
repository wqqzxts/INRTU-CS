using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using @for;

namespace @for.Tests
{
    [TestClass()]
    public class LogicTests {
        [TestMethod()]
        //проверка того, что максимальная цифра в последовательности находится левее минимальной
        public void maxAtLeft() {
            string Input = "432871";
            string Output = Logic.definePosition(Input);
            Assert.AreEqual("The maximum digit is to the left of the minimum digit", Output);
        }

        [TestMethod()]
        //проверка того, что максимальная цифра в последовательности находится правее минимальной
        public void maxAtRight() {
            string Input = "2137895";
            string Output = Logic.definePosition(Input);
            Assert.AreEqual("The maximum digit is to the right of the minimum digit", Output);
        }

        [TestMethod()]
        //проверка с повторяющимися цифрами в последовательности
        public void repeatedSymbolInSequence()
        {
            string Input = "1129";
            bool Output = Logic.inputValidation(Input);
            Assert.AreEqual(false, Output);
        }
    }
}