using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AlbashiriEH.Sprint0.Task2.V0.LIb;


namespace Tyuiu.AlbashiriEH.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()

        {
            var name = "Эмад";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет, Эмад", res);
        }
    }
}
