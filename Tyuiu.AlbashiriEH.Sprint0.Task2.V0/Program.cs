﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AlbashiriEH.Sprint0.Task2.V0.Lib;

namespace Tyuiu.AlbashiriEH.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Эмад"));
            Console.ReadKey();
        }
    }
}
