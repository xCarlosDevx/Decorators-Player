using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Player
{
    class Program
    {
        static void Main(string[] args)
        {

            Decorator_Player.Classes.Player newElf = new Decorator_Player.Childrens.Elf(); 
            Decorator_Player.Classes.Player newOgre = new Decorator_Player.Childrens.Ogre(); 
            Decorator_Player.Classes.Player newHuman = new Decorator_Player.Childrens.Human();

            Console.WriteLine("Bienvenido a la eleccion de su personaje, a continuacion marque el personaje que desea elegir: ");
            Console.WriteLine("");
            Console.WriteLine("1. "+ newElf.Name+ " Raza. "+ newElf.Race+ " Vida. "+ newElf.Health);
            Console.WriteLine("2. "+ newOgre.Name+ " Raza. "+ newOgre.Race+ " Vida. "+ newOgre.Health);
            Console.WriteLine("3. "+ newHuman.Name+ " Raza. "+newHuman.Race+ " Vida. "+ newHuman.Health);
            Console.WriteLine("");

            string opt = Console.ReadLine();

            switch (opt)
            {
                case "1":
                    Decorator_Player.Classes.Player newPlayer = newElf;  
                    Console.WriteLine("Ha elegido al " +newPlayer.Race+" con "+newPlayer.Health+ " de vida, Elija su equipamiento: ");
                    Console.WriteLine(@"
                    1. Casco
                    2. Pechera
                    ");
                    string optArm = Console.ReadLine();
                    switch (optArm)
                    {
                        case "1":
                            newPlayer = new Decorator_Player.Decorators.Helmet(newPlayer);
                            Console.WriteLine("Su personaje de tipo " + newPlayer.Race + " Ahora tiene " + newPlayer.Health + " de vida");
                            break;
                        case "2":
                            newPlayer = new Decorator_Player.Decorators.Chest(newPlayer);
                            Console.WriteLine("Su personaje de tipo " + newPlayer.Race + " Ahora tiene " + newPlayer.Health + " de vida");
                            break;
                    }
                    break;
                case "2":
                    Decorator_Player.Classes.Player newPlayer2 = newOgre;
                    Console.WriteLine("Ha elegido al "+ newPlayer2.Race+ " con "+ newPlayer2.Health+ " de vida, Elija su equipamiento: ");
                    Console.WriteLine(@"
                    1. Casco
                    2. Pechera
                    ");
                    string optArm2 = Console.ReadLine();
                    switch (optArm2)
                    {
                        case "1":
                            newPlayer2 = new Decorator_Player.Decorators.Helmet(newPlayer2);
                            Console.WriteLine("Su personaje de tipo " + newPlayer2.Race + " Ahora tiene " + newPlayer2.Health + " de vida");
                            break;
                        case "2":
                            newPlayer2 = new Decorator_Player.Decorators.Chest(newPlayer2);
                            Console.WriteLine("Su personaje de tipo " + newPlayer2.Race + " Ahora tiene " + newPlayer2.Health + " de vida");
                            break;
                    }
                    break;
                case "3":
                    Decorator_Player.Classes.Player newPlayer3 = newHuman;
                    Console.WriteLine("Ha elegido al "+ newPlayer3.Race + " con "+ newPlayer3.Health+ " de vida, Elija su equipamiento: ");
                    Console.WriteLine(@"
                    1. Casco
                    2. Pechera
                    ");
                    string optArm3 = Console.ReadLine();
                    switch (optArm3)
                    {
                        case "1":
                            newPlayer3 = new Decorator_Player.Decorators.Helmet(newPlayer3);
                            Console.WriteLine("Su personaje de tipo "+newPlayer3.Race+" Ahora tiene " + newPlayer3.Health + " de vida");
                            break;
                        case "2":
                            newPlayer3 = new Decorator_Player.Decorators.Chest(newPlayer3);
                            Console.WriteLine("Su personaje de tipo " + newPlayer3.Race + " Ahora tiene " + newPlayer3.Health + " de vida");
                            break;
                    }
                    break;
            }
             
             
            Console.ReadKey();
        }
    }
}
