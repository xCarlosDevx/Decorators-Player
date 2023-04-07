using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Player.Decorators
{
    class Chest : PlayerDecorator
    {
        public Chest(Decorator_Player.Classes.Player playerSkills) : base(playerSkills) { }
        public override double Health => player.Health + 5;
        public override string Name => player.Name;
        public override string Race => player.Race;
    }
}
