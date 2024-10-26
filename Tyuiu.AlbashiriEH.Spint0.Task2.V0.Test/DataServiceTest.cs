using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AlbashiriEH.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AlbashiriEH.Spint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания метадов тестирования, метадов из библиотеки
            var name = "Эмад";
            var res = DataService.GetMessage(name);

            //Вызывает класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Эмад", res);
        }
    }
}
