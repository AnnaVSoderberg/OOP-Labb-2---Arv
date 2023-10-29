namespace OOP_Labb_2___Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog Hund1 = new Dog("Fido", 5, 4, "Norge", true, "brun");
            Dog Hund2 = new Dog("Vips", 2, 4, "Australien", true, "fläckig");

            Cat Katt1 = new Cat("Keso", 3, 4, "Sverige", true, 8);
            Cat Katt2 = new Cat("Missy", 2 , 4, "Nederländerna", false, 3);

            Snake Orm1 = new Snake("Sir vääs",13, 0, "Sydafrika", false, 1.5);
            Snake Orm2 = new Snake("Bubblan", 3, 0, "Kongo", false, 0.3);

            Rattlesnake ormR1 = new Rattlesnake("Konrad", 4, 0, "England", false, 0.8, true);
            Rattlesnake ormR2 = new Rattlesnake("Gny", 1, 0, "Kina", false, 0.5, false);

            Viper ormV1 = new Viper("Yngve", 25, 0, "Belgien", false, 2.87, "Syrsor");
            Viper ormV2 = new Viper("Saga", 6, 0, "Sverige", false, 3.54, "Möss");

            List<Dog> Hundar = new List<Dog>();
            Hundar.Add(Hund1);
            Hundar.Add(Hund2);

            foreach (Dog dog in Hundar)
            {

                Console.WriteLine("*************");
                dog.printInfo();
                dog.Sleep();
                dog.Home();
                dog.HasFur();
                dog.MakeSound();
                dog.Jumps();
            }


            List<Cat> Katter = new List<Cat>();
            Katter.Add(Katt1);
            Katter.Add(Katt2);

            foreach (Cat cat in Katter)
            {

                Console.WriteLine("*************");
                cat.printInfo();
                cat.Sleep();
                cat.Home();
                cat.HasFur();
                cat.MakeSound();
                cat.HappyCat();
            }

            List<Snake> Ormar = new List<Snake>();    
            Ormar.Add(Orm1);
            Ormar.Add(Orm2);

            foreach (Snake snakes in Ormar)
            {

                Console.WriteLine("*************");
                snakes.printInfo();
                snakes.Sleep();
                snakes.Home();
                snakes.HasFur();
                snakes.MakeSound();
                snakes.Grow();
            }

            List<Rattlesnake> Skallerormar = new List<Rattlesnake>();
            Skallerormar.Add(ormR1);
            Skallerormar.Add(ormR2);

            foreach (Rattlesnake skallerorm in Skallerormar)
            {
                Console.WriteLine("*************");
                skallerorm.printInfo();
                skallerorm.Sleep();
                skallerorm.Home();
                skallerorm.HasFur();
                skallerorm.MakeSound();
                skallerorm.Grow();
                skallerorm.Danger();
            }

            List<Viper> Huggormar = new List<Viper>();
            Huggormar.Add(ormV1);
            Huggormar.Add(ormV2);

            foreach (Viper Huggorm in Huggormar)
            {
                Console.WriteLine("*************");
                Huggorm.printInfo();
                Huggorm.Sleep();
                Huggorm.Home();
                Huggorm.HasFur();
                Huggorm.MakeSound();
                Huggorm.Grow();
                Huggorm.Food();
            }


        }
    }
}