using Microsoft.VisualStudio.TestTools.UnitTesting;
using class_lab3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_lab3.Tests {
    [TestClass()]
    public class TemperatureTests {
        [TestMethod()]
        public void VerboseTest() {
            var temperature = new Temperature(12.4, Type.K);
            Assert.AreEqual("12.4 по Кельвину", temperature.Verbose());

            temperature = new Temperature(25.2, Type.C);
            Assert.AreEqual("25.2 по Цельсию", temperature.Verbose());

            temperature = new Temperature(671.67, Type.Ra);
            Assert.AreEqual("671.67 по Ранкину", temperature.Verbose());
        }

        [TestMethod()]
        public void AddValueTest() {
            var temperature = new Temperature(12.4, Type.K);
            temperature += 7.6;
            Assert.AreEqual("20 по Кельвину", temperature.Verbose());
        }
    }
}