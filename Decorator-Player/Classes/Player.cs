using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Player.Classes
{
    public abstract class Player
    {
        public abstract string Name { get; }
        public abstract string Race { get; }
        public abstract double Health { get; }
    }
}
