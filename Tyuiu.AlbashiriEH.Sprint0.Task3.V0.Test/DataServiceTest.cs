﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.AlbashiriEH.Sprint0.Task3.V0.Lib;


namespace Tyuiu.AlbashiriEH.Sprint0.Task3.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedValid()

        {
            Assert.AreEqual(10, DataService.Sum(5, 5));
        }
    }
}
