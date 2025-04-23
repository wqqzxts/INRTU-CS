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

            temperature = new Temperature(72, Type.Fa);
            Assert.AreEqual("72 по Фаренгейту", temperature.Verbose());
        }

        [TestMethod()]
        public void AddValueTest() {
            var temperature = new Temperature(12.4, Type.K);
            temperature += 7.6;
            Assert.AreEqual("20 по Кельвину", temperature.Verbose());
        }

        [TestMethod()]
        public void SubstractValueTest() {
            var temperature = new Temperature(12.4, Type.C);
            temperature -= 2.4;
            Assert.AreEqual("10 по Цельсию", temperature.Verbose());
        }

        [TestMethod()]
        public void MultiplyValueTest() {
            var temperature = new Temperature(12.4, Type.Ra);
            temperature *= 2;
            Assert.AreEqual("24.8 по Ранкину", temperature.Verbose());
        }

        [TestMethod()]
        public void DivideValueTest() {
            var temperature = new Temperature(12.4, Type.Fa);
            temperature /= 2;
            Assert.AreEqual("6.2 по Фаренгейту", temperature.Verbose());
        }

        [TestMethod()]
        public void To_SameType_ReturnsSameValue() {
            var temperature = new Temperature(100, Type.C);
            var result = temperature.To(Type.C);            
            Assert.AreEqual("100 по Цельсию", result.Verbose());
        }

        [TestMethod()]
        public void To_CelsiusToFahrenheit() {
            var temperature = new Temperature(0, Type.C);
            var result = temperature.To(Type.Fa);
            Assert.AreEqual("32 по Фаренгейту", result.Verbose());
        }

        [TestMethod()]
        public void To_FahrenheitToCelsius() {
            var temperature = new Temperature(32, Type.Fa);
            var result = temperature.To(Type.C);
            Assert.AreEqual("0 по Цельсию", result.Verbose());
        }

        [TestMethod()]
        public void To_CelsiusToKelvin() {
            var temperature = new Temperature(0, Type.C);
            var result = temperature.To(Type.K);
            Assert.AreEqual("273.15 по Кельвину", result.Verbose());
        }

        [TestMethod()]
        public void To_KelvinToCelsius() {
            var temperature = new Temperature(273.15, Type.K);
            var result = temperature.To(Type.C);
            Assert.AreEqual("0 по Цельсию", result.Verbose());
        }

        [TestMethod()]
        public void To_RankineToKelvin() {
            var temperature = new Temperature(491.67, Type.Ra);
            var result = temperature.To(Type.K);
            Assert.AreEqual("273.15 по Кельвину", result.Verbose());
        }

        [TestMethod()]
        public void To_KelvinToRankine() {
            var temperature = new Temperature(273.15, Type.K);
            var result = temperature.To(Type.Ra);
            Assert.AreEqual("491.67 по Ранкину", result.Verbose());
        }

        [TestMethod()]
        public void To_FahrenheitToRankine() {
            var temperature = new Temperature(32, Type.Fa);
            var result = temperature.To(Type.Ra);
            Assert.AreEqual("491.67 по Ранкину", result.Verbose());
        }

        [TestMethod()]
        public void To_RankineToFahrenheit() {
            var temperature = new Temperature(491.67, Type.Ra);
            var result = temperature.To(Type.Fa);
            Assert.AreEqual("32 по Фаренгейту", result.Verbose());
        }

        [TestMethod()]
        public void To_AbsoluteZeroKelvinToCelsius() {
            var temperature = new Temperature(0, Type.K);
            var result = temperature.To(Type.C);
            Assert.AreEqual("-273.15 по Цельсию", result.Verbose());
        }

        [TestMethod()]
        public void To_AbsoluteZeroKelvinToFahrenheit() {
            var temperature = new Temperature(0, Type.K);
            var result = temperature.To(Type.Fa);
            Assert.AreEqual("-459.67 по Фаренгейту", result.Verbose());
        }

        [TestMethod()]
        public void To_AbsoluteZeroKelvinToRankine() {
            var temperature = new Temperature(0, Type.K);
            var result = temperature.To(Type.Ra);
            Assert.AreEqual("0 по Ранкину", result.Verbose());
        }

        [TestMethod()]
        public void To_BoilingWaterCelsiusToFahrenheit() {
            var temperature = new Temperature(100, Type.C);
            var result = temperature.To(Type.Fa);
            Assert.AreEqual("212 по Фаренгейту", result.Verbose());
        }

        [TestMethod()]
        public void To_FreezingWaterFahrenheitToRankine() {
            var temperature = new Temperature(32, Type.Fa);
            var result = temperature.To(Type.Ra);
            Assert.AreEqual("491.67 по Ранкину", result.Verbose());
        }
    }
}