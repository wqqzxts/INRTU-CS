using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using @string;

namespace @string.Tests {

    [TestClass()]
    public class userInterfaceTests {
        [TestMethod()]
        //проверка удаления слова "dddd" и дублирования слова "ddd" с заменой букв "d" на "t", также проверка дублирования слова "ttt"
        public void firstTest() {
            string UserInput = "ddd dddd ttt";
            string Output = Logic.processText(UserInput);
            Assert.AreEqual(Output, "ttt ttt ttt ttt ");
        }

        [TestMethod()]
        //проверка замены букв "d" на "t" и дублирования слов с нечетным количеством букв
        public void secondTest() {
            string UserInput = "how old are you";
            string Output = Logic.processText(UserInput);
            Assert.AreEqual(Output, "how how olt olt are are you you ");
        }

        [TestMethod()]
        //проверка работы с не буквенными символами
        public void thirdTest() {
            string UserInput = "123 4567";
            string Output = Logic.processText(UserInput);
            Assert.AreEqual(Output, "123 123 ");
        }

        [TestMethod()]
        //все слова четные
        public void fourthTest()
        {
            string UserInput = "ddd dddd ttt";
            string Output = Logic.processText(UserInput);
            Assert.AreEqual(Output, "ttt ttt ttt ttt ");
        }
    }
}