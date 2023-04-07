using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Player.Decorators
{
    public class Helmet : PlayerDecorator
    {
        public Helmet(Decorator_Player.Classes.Player playerSkills) : base(playerSkills) { }
        public override double Health => player.Health + 3;
        public override string Name => player.Name;
        public override string Race => player.Race;
    }
}
