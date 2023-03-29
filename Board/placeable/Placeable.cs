using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Threading_in_C.Players;

namespace Threading_in_C.Board.placeable
{
    [XmlInclude(typeof(Player))]
    [XmlInclude(typeof(Obstacle))]
    public abstract class Placeable {

        [XmlElement("name")]
        private string name;

        public abstract string getDrawAble();
    }
}
