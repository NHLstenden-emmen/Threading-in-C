using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading_in_C.Entities
{
    internal class NPC : Character
    {
        public string Backstory { get; set; }
        public List<string> Traits { get; set; }
    }
}
