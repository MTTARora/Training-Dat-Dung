﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varriable
{
    class Program
    {
        static void Main(string[] args)
        {
            short a;
            int b;
            double c;
            a = 10;
            b = 30;
            c = a + b;
            Console.WriteLine("a = {0}  \nb = {1}  \nc = {2}", a, b, c);
            Console.ReadKey();
        }
    }
}