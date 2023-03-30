﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Threading_in_C.Board.placeable;
using Threading_in_C.Players;

namespace Threading_in_C.Board
{
    public class Tile
    {
        [XmlElement("Placeable")]
        public Placeable placeable;
        [XmlIgnore]
        public int x;
        [XmlElement("x")]
        public string xAsText
        {
            get { return getX().ToString(); }
            set { x = int.Parse(value); }
        }
        [XmlIgnore]
        public int y;
        [XmlElement("y")]
        public string yAsText
        {
            get { return getY().ToString(); }
            set { y = int.Parse(value); }
        }

        public Tile(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Tile()
        {
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
