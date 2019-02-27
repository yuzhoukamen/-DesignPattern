﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unikm.DP.AbstractFactoryPattern
{
    /// <summary>
    /// 
    /// </summary>
    public class Rectangle : IShape
    {
        /// <summary>
        /// 
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}