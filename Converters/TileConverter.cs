using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Threading_in_C.Board;

namespace Threading_in_C.Converters
{
    public class TileConverter
    {
        [XmlRoot("TileList")]
        public class TileList
        {
            [XmlElement("Tile")]
            public List<Tile> Tiles { get; set; }
        }
    }
}
