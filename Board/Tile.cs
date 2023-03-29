using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Threading_in_C.Board.placeable;

namespace Threading_in_C.Board
{
    public class Tile
    {
        private Placeable placeable;
        private int x;
        private int y;

        public Tile(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Placeable getPlaceable()
        {
            return placeable;
        }

        public void setPlaceable(Placeable placeable)
        {
            this.placeable = placeable;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        { 
            return y;
        }
    }
}
