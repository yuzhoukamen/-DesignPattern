﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 
    /// </summary>
    public class Red : IColor
    {
        /// <summary>
        /// 
        /// </summary>
        public void Fill()
        {
            Console.WriteLine("Inside Red::fill() method.");
        }
    }
}
