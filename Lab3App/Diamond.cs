﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Diamond : Treasure
    {
        public Diamond(string description, int score)
        {
            this.Description = description;
            this.Score = score;
        }
    }
}
