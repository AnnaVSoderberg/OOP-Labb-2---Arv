using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_Labb_2___Arv
{
    internal class Cat : Djur
    {
        protected int _happiness;

        public Cat(string name, int age, int numberOfLegs, string origin, bool hasFur, int happiness)
            : base(name, age, numberOfLegs, origin, hasFur) 
        {
            _happiness = happiness;
        }

        public void HappyCat() 
        {
            if(_happiness >= 6) 
            {
                Console.WriteLine("Denna katt är glad");
            }
            else
            { 
                Console.WriteLine("Denna katt behöver muntras upp");
            }
        }

        public override void MakeSound()
        {
            Console.WriteLine("Katten låter Mjau! Mjau!");
        }

        public void printInfo()
        {
            Console.WriteLine("Den här katten heter {0} och är {1} år gammal.", _name, _age);
            Console.WriteLine("Den här hunden har {0} ben", _numberOfLegs);
        }
    }
}
