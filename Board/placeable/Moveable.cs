﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading_in_C.Board.placeable
{
    public abstract class Moveable : Placeable
    {
        public Moveable() { }

        public abstract int getMovement();
    }
}