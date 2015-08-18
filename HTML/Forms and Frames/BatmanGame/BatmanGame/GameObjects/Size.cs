﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatmanGame.GameObjects
{
    public struct Size
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Size(int width,int height):this()
        {
            this.Width = width;
            this.Height = height;
        }
    }
}
