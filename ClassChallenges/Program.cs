using System;

namespace ClassChallenges
{
    class Program
    {
        class Cat
        {
            string  name;
            string color;
            double hunger;

            public Cat(string _name, string _color)
            {
                name = _name;
                color = _color;
                hunger = 0;

            }

            public string Name
            {
                get { return name; }
            }

            public string Color
            {
                get { return color; }
            }

            public double Hunger
            {
                get { return hunger; }
            }

            public void Sleep()
            {
                hunger += 0.2;
            }

        }

       
       
        static void Main(string[] args)
        {
            Cat newCat = new Cat("kitty", "black");
            Console.WriteLine("You have A Cat!");
            while (newCat.Hunger != 0)
            {
               
            }

            newCat.Sleep();
            if (newCat.Hunger != 1)
            {
                Console.WriteLine("Meow");
            }


        }
    }
}
