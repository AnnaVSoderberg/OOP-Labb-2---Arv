using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_2___Arv
{
    internal class Rattlesnake : Snake
    {
        protected bool _poisonous;

        public Rattlesnake(string name, int age, int numberOfLegs, string origin, bool hasFur, double length, bool poisonous)
            : base(name, age, numberOfLegs, origin, hasFur, length) 
        {
            _poisonous = poisonous;
        }

        public void Danger() 
        {
            if (_poisonous)
            {
                Console.WriteLine("Den här ormen är giftig");
            }
            else
            {
                Console.WriteLine("Den här ormen är inte giftig");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Skallerormen låter skaller skaller");
        }
    }    
}
