﻿using Submodule1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubmoduleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Submodule();
            s.WriteLine();
            Console.ReadKey();
        }
    }
}
