﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AlbashiriEH.Sprint0.Task4.V0.LIb;

namespace Tyuiu.AlbashiriEH.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Subtraction(15, 5));
            Console.WriteLine(DataService.Multiplication(10, 10));
            Console.WriteLine(DataService.Division(5, 5));

        }
    }
}
