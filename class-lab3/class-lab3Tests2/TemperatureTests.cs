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
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideOnZeroTest() {
            var temperature = new Temperature(12.4, Type.Fa);
            temperature /= 0;            
        }

        [TestMethod()]
        public void ConvertSameType() {
            var temperature = new Temperature(100, Type.C);
            var result = temperature.To(Type.C);
            Assert.AreEqual("100 по Цельсию", result.Verbose());
        }

        [TestMethod()]
        public void ConvertCelsiusToCFahrenheit() {
            var temperature = new Temperature(0, Type.C);
            var result = temperature.To(Type.Fa);
            Assert.AreEqual("32 по Фаренгейту", result.Verbose());
        }

        [TestMethod()]
        public void ConvertFahrenheitToCelsius() {
            var temperature = new Temperature(32, Type.Fa);
            var result = temperature.To(Type.C);
            Assert.AreEqual("0 по Цельсию", result.Verbose());
        }

        [TestMethod()]
        public void ConvertCelsiusToKelvin() {
            var temperature = new Temperature(0, Type.C);
            var result = temperature.To(Type.K);
            Assert.AreEqual("273.15 по Кельвину", result.Verbose());
        }

        [TestMethod()]
        public void ConvertKelvinToCelsius() {
            var temperature = new Temperature(273.15, Type.K);
            var result = temperature.To(Type.C);
            Assert.AreEqual("0 по Цельсию", result.Verbose());
        }

        [TestMethod()]
        public void ConvertRankineToKelvin() {
            var temperature = new Temperature(491.67, Type.Ra);
            var result = temperature.To(Type.K);
            Assert.AreEqual("273.15 по Кельвину", result.Verbose());
        }

        [TestMethod()]
        public void ConvertKelvinToRankine() {
            var temperature = new Temperature(273.15, Type.K);
            var result = temperature.To(Type.Ra);
            Assert.AreEqual("491.67 по Ранкину", result.Verbose());
        }

        [TestMethod()]
        public void ConvertFarenheitToRankine() {
            var temperature = new Temperature(32, Type.Fa);
            var result = temperature.To(Type.Ra);
            Assert.AreEqual("491.67 по Ранкину", result.Verbose());
        }

        [TestMethod()]
        public void ConvertRankineToFarenheit() {
            var temperature = new Temperature(491.67, Type.Ra);
            var result = temperature.To(Type.Fa);
            Assert.AreEqual("32 по Фаренгейту", result.Verbose());
        }

        [TestMethod()]
        public void ConvertKelvinToCelsiusAbsoluteZero() {
            var temperature = new Temperature(0, Type.K);
            var result = temperature.To(Type.C);
            Assert.AreEqual("-273.15 по Цельсию", result.Verbose());
        }

        [TestMethod()]
        public void ConvertKelvinToFarenheitAbsoluteZero() {
            var temperature = new Temperature(0, Type.K);
            var result = temperature.To(Type.Fa);
            Assert.AreEqual("-459.67 по Фаренгейту", result.Verbose());
        }

        [TestMethod()]
        public void ConvertKelvinToRankineAbsoluteZero() {
            var temperature = new Temperature(0, Type.K);
            var result = temperature.To(Type.Ra);
            Assert.AreEqual("0 по Ранкину", result.Verbose());
        }

        [TestMethod()]
        public void ConvertCelsiusToFarenheitBoilWater() {
            var temperature = new Temperature(100, Type.C);
            var result = temperature.To(Type.Fa);
            Assert.AreEqual("212 по Фаренгейту", result.Verbose());
        }

        [TestMethod()]
        public void ConvertFarenheitToRankineFreezeWater() {
            var temperature = new Temperature(32, Type.Fa);
            var result = temperature.To(Type.Ra);
            Assert.AreEqual("491.67 по Ранкину", result.Verbose());
        }


        [TestMethod()]
        public void AddCelsiusToFarenheit() {
            var c = new Temperature(3, Type.C);
            var fa = new Temperature(72, Type.Fa);
            Assert.AreEqual("25.22 по Цельсию", (c + fa).Verbose());
        }

        [TestMethod()]
        public void AddKelvinToRankine() {
            var k = new Temperature(300, Type.K);
            var r = new Temperature(180, Type.Ra);
            Assert.AreEqual("400 по Кельвину", (k + r).Verbose());
        }

        public void SubtractFahrenheitFromCelsius() {
            var c = new Temperature(30, Type.C);
            var f = new Temperature(68, Type.Fa);
            Assert.AreEqual("10 по Цельсию", (c - f).Verbose());
        }

        [TestMethod()]
        public void SubtractRankineFromKelvin() {
            var k = new Temperature(400, Type.K);
            var r = new Temperature(180, Type.Ra);
            Assert.AreEqual("300 по Кельвину", (k - r).Verbose());
        }

        [TestMethod()]
        public void MultiplyCelsiusByFahrenheit() {
            var c = new Temperature(10, Type.C);
            var f = new Temperature(41, Type.Fa);
            Assert.AreEqual("50 по Цельсию", (c * f).Verbose());
        }

        [TestMethod()]
        public void MultiplyKelvinByRankine() {
            var k = new Temperature(2, Type.K);
            var r = new Temperature(540, Type.Ra);
            Assert.AreEqual("600 по Кельвину", (k * r).Verbose());
        }

        [TestMethod()]
        public void DivideCelsiusByFahrenheit() {
            var c = new Temperature(100, Type.C);
            var f = new Temperature(122, Type.Fa);
            Assert.AreEqual("2 по Цельсию", (c / f).Verbose());
        }

        [TestMethod()]
        public void DivideKelvinByRankine() {
            var k = new Temperature(400, Type.K);
            var r = new Temperature(360, Type.Ra);
            Assert.AreEqual("2 по Кельвину", (k / r).Verbose());
        }

        [TestMethod()]
        public void AddAbsoluteZeroToCelsius() {
            var c = new Temperature(20, Type.C);
            var k = new Temperature(0, Type.K);
            Assert.AreEqual("-253.15 по Цельсию", (c + k).Verbose());
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivideByZeroTemperature() {
            var c = new Temperature(10, Type.C);
            var zero = new Temperature(0, Type.K);
            var result = c / zero;
        }

        [TestMethod()]
        public void PrecisionTest_FahrenheitToCelsiusAddition() {
            var c = new Temperature(0.01, Type.C);
            var f = new Temperature(32.018, Type.Fa);
            Assert.AreEqual("0.02 по Цельсию", (c + f).Verbose());
        }
    }
}