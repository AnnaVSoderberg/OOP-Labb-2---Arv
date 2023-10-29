using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP_Labb_2___Arv
{
    internal class Dog : Djur
    {
        protected string _color;

        public Dog(string name, int age, int numberOfLegs, string origin, bool hasFur, string color)
            : base(name, age, numberOfLegs, origin, hasFur)
        {
            _color = color;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Hunden låter voff voff!");
        }

        public void printInfo()
        {
            Console.WriteLine("Den här hunden heter {0} och är {1} år gammal.", _name, _age);
            Console.WriteLine("Den här hunden har {0} ben och färgen {1}", _numberOfLegs, _color);
        }

        public void Jumps() 
        {
            if (_age <= 2)
            {
                Console.WriteLine("Den här hunden är så unga att den hoppar hela tiden");
            }
            else if (_age <= 6) 
            {
                Console.WriteLine("Den här hunden har lärt sig att inte hoppa");
            }
            else
            {
                Console.WriteLine("Den här hunden vill hoppa men är för gammal");
            }

        }

    }
}
