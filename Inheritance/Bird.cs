using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Bird : Animal
    {
        public bool LaysEggs { get; set; }
        public bool HasBeak { get; set; }
        public bool CanFly { get; set; }
        public bool HasFeathers { get; set; }

        public Bird()
        {

        }

        public void BirdStats()
        {
            Console.WriteLine("Some facts about the Bird: ");
            Console.WriteLine("Birds lay eggs");
            Console.WriteLine("Birds have a beak");
            Console.WriteLine("Birds have feathers");
            Console.WriteLine("Birds can fly");
        }
    }

}
 
