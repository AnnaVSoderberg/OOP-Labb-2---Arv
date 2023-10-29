using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_2___Arv
{
    internal class Snake : Djur
    {
        protected double _length;

        public Snake(string name, int age, int numberOfLegs, string origin, bool hasFur, double length)
            : base(name, age, numberOfLegs, origin, hasFur)
        {
            _length = length;
        }

        public override void MakeSound()
        {
            Console.WriteLine("Ormen låter ingenting");
        }

        public void Grow()
        {
            double newLengt = _length * 1.1;

           Console.WriteLine("Den här ormen har växt och är nu " + newLengt + " cm");
        }
        public void printInfo()
        {
            Console.WriteLine("Den här ormen heter {0} och är {1} år gammal.", _name, _age);
            Console.WriteLine("Den här hunden har {0} ben och längden {1} m ", _numberOfLegs, _length);
        }
    }
}
