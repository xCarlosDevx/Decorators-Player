using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Player.Childrens
{
    class Human : Decorator_Player.Classes.Player
    {
        public override string Name => "Carlos";
        public override string Race => "Human";
        public override double Health => 8;
    }
}
