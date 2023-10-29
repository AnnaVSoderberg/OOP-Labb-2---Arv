using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_2___Arv
{
    internal class Viper : Snake
    {
       protected string _favoritFood;
        
        public Viper(string name, int age, int numberOfLegs, string origin, bool hasFur, double length, string favoritFood)
            :base(name, age, numberOfLegs, origin, hasFur, length)
        {
            _favoritFood = favoritFood;
        }

        public void Food() 
        {
            if (_favoritFood == "Möss")
            {
                Console.WriteLine("Den här ormen älskar möss");
            }
            else 
            {
                Console.WriteLine("Den här ormen får inte sin favorit mat");
            }
        }
        public override void MakeSound()
        {
            Console.WriteLine("Huggormen väsen");
        }
    }
}
