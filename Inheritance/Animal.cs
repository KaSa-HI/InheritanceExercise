using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
        public bool Is4Legged { get; set; }
        public bool HasFur { get; set; }
        public bool IsFriendly { get; set; }
        public bool DrinksWater { get; set; }
        public string Sound { get; set; }

        public Animal()
        {

        }
        public void SoundEffects() 
        {
            Console.WriteLine($"{Sound}");
        }

    }

}