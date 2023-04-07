using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Player.Decorators
{
    public abstract class PlayerDecorator : Decorator_Player.Classes.Player
    {
        protected Decorator_Player.Classes.Player player;
        public PlayerDecorator(Decorator_Player.Classes.Player playerSkills)
        {
            player = playerSkills;
        }

    }
}
