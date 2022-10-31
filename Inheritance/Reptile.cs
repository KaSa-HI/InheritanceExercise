using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public bool ExternalEggs { get; set; }
        public bool IsColdBlooded { get; set; }
        public bool HasScales { get; set; }
        public bool HasBackBone { get; set; }

        public Reptile()
        {

        }
        public void AnimalStats()
        {
            Console.WriteLine("Some facts about the Reptile: ");
            Console.WriteLine("Reptiles lay external eggs");
            Console.WriteLine("Reptiles have scales");
            Console.WriteLine("Reptiles are cold blooded");
            Console.WriteLine("Reptiles have a back bone");
            Console.WriteLine("");

        }
    }
}

