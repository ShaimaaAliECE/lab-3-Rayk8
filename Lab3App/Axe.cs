﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Axe : Tool
    {
        public Axe(string description)
        {
            this.Description = description;
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is Used");
        }
    }
}
