using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb_2___Arv
{
    internal class Djur
    {
        //string _name;
        //int _age;
        //bool _fur;
        //decimal _happiness;
        //int _legs;

        //public Djur(string name, int age, bool fur, decimal happiness, int legs)
        //{
        //    _name = name;
        //    _age = age;
        //    _fur = fur;
        //    _happiness = happiness;
        //    _legs = legs;

        //}

        //public void HasFur()
        //{
        //    if (_fur)
        //    {
        //        Console.WriteLine("Det här djuret har päls");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Det här djuret har ingen päls");
        //    }
        //}

        //public void NumberOfLegs()
        //{
        //    Console.WriteLine("Det här djuret har " + _legs + " ben");
        //}

        //public void sleep()
        //{
        //    if (_age % 2 == 0)
        //    {
        //        Console.WriteLine("Det här djuret sover på dagen");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Det här djuret sover på natten");
        //    }
        //}

        ////public virtual void PrintInfo() 
        ////{
        ////    Console.WriteLine("Name : {0}\n Ålder: {1}", _name, _age);
        ////    HasFur();


        ////}

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////


        protected string _name;
        protected int _age;
        protected int _numberOfLegs;
        protected string _origin;
        protected bool _hasFur;

        public Djur(string name, int age, int numberOfLegs, string origin, bool hasFur)
        {
            _name = name;
            _age = age;
            _numberOfLegs = numberOfLegs;
            _origin = origin;
            _hasFur = hasFur;
        }

        public void HasFur()
        {
            if (_hasFur) 
            {
                Console.WriteLine("Djuret har päls");
            }
            else
            {
                Console.WriteLine("Djuret har inte päls");

            }
        }

        public void Home() 
        {
            Console.WriteLine("Det här djuret kommer från " + _origin);
        }

        public void Sleep() 
        {
            if (_age % 2 == 0) 
            {
                Console.WriteLine("Djuret sover!");
            }
            else
            { 
                Console.WriteLine("Djuret är vaket");
            }
        }

        public virtual void MakeSound()
        {
            Console.WriteLine("Inget ljud angivet");
        }



    }
}
