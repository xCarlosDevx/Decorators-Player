using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Player.Childrens
{
    public class Elf : Decorator_Player.Classes.Player
    {
        public override string Name => "Leonidas";
        public override string Race => "Elf";
        public override double Health => 10;
    }
}
