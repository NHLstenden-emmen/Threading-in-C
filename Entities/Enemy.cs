using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading_in_C.Entities
{
    internal class Enemy : Entity
    {
        public float CR { get; set; }
        public int Size { get; set; }
        public string Type { get; set; }
    }
}
