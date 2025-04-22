using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using @if;
namespace @if.Tests
{
    [TestClass()]
    public class LogicTests
    {
        [TestMethod()]
        //проверка с тройкой сторон правильного прямоугольного треугольника целочисленные
        public void intRightTriangle() {        
            double a = 3; double b = 4; double c = 5;
            string Output = Logic.checkTriangle(a, b, c);
            Assert.AreEqual("Triangle is exist & right", Output);
        }

        [TestMethod()]
        //проверка с тройкой сторон правильного прямоугольного треугольника вещественные
        public void doubleRightTriangle() {        
            double a = 5.5; double b = 2.4; double c = 6.00083;
            string Output = Logic.checkTriangle(a, b, c);
            Assert.AreEqual("Triangle is exist & right", Output);
        }

        [TestMethod()]
        //проверка с тройкой сторон правильного треугольника целочисленные
        public void intExistTriangle() {        
            double a = 7; double b = 8; double c = 10;
            string Output = Logic.checkTriangle(a, b, c);
            Assert.AreEqual("Triangle is exist", Output);
        }

        [TestMethod()]
        //проверка с тройкой сторон правильного треугольника вещественные
        public void doubleExistTriangle() {
            double a = 4.5; double b = 7.5; double c = 10;
            string Output = Logic.checkTriangle(a, b, c);
            Assert.AreEqual("Triangle is exist", Output);
        }

        [TestMethod()]
        //проверка с тройкой сторон несуществующего треугольника целочисленные
        public void intUnexistTriangle () {
            double a = 2; double b = 3; double c = 6;
            string Output = Logic.checkTriangle(a, b, c);
            Assert.AreEqual("Triangle is not exist", Output);
        }

        [TestMethod()]
        //проверка с тройкой сторон несуществующего треугольника вещественные
        public void doubleUnexistTriangle() {
            double a = 1; double b = 2.5; double c = 4;
            string Output = Logic.checkTriangle(a, b, c);
            Assert.AreEqual("Triangle is not exist", Output);
        }
    }
}