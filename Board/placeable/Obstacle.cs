using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading_in_C.Board.placeable
{
    internal class Obstacle : InMovable
    {
        public String type;
        public Obstacle(String type)
        {
            this.type = type;
        }

        public override string getDrawAble()
        {
            return this.type;
        }
    }
}
