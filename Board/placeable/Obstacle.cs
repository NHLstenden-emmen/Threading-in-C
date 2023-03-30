using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Threading_in_C.Board.placeable
{
    public class Obstacle : InMovable
    {
        [XmlElement("type")]
        public String type;
        public Obstacle(String type)
        {
            this.type = type;
        }
        public Obstacle()
        {
        }

        public override string getDrawAble()
        {
            return this.type;
        }
    }
}
