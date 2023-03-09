using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Threading_in_C.Entities
{
    public class Character : Entity
    {
        [XmlIgnore] // ignore Race for now
        public List<string> Race { get; set; }

        [XmlElement("Name")]
        public string Class { get; set; }
    }
}
