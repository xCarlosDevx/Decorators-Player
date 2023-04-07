using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Player.Childrens
{
    class Ogre : Decorator_Player.Classes.Player
    {
        public override string Name => "Ragnar";
        public override string Race => "Ogre";
        public override double Health => 15;
    }
}
