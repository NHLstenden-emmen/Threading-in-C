using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Threading_in_C.Board.placeable
{
    internal class testPlayer : Moveable
    {
        string name;

        public testPlayer(string name)
        {
            this.name = name;
        }

        public string Name { get => this.name; set => this.name = value; }

        public override string getDrawAble()
        {
            return name;
        }
    }
}
