﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    internal class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Wuff!"); ;
        }
    }
}
