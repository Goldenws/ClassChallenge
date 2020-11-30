using System;

namespace HamsterLifeCycle
{
    class Program
    {
        class Pet
        {
            string name;
            double weight;
            int age;
            int lifespan;

            public Pet(string _name)
            {
                name = _name;
                age = 0;
                weight = 0.2;
                lifespan = 10;


            }
            
            public int Age
            {
                get { return age; }
            }

            public double Weight
            {
                get { return weight; }
            }

            public int LifeSpan
            {
                get { return lifespan; }
            }


               
            public void Eating()
            {
                Console.WriteLine("nom-nom");
                weight += 0.2;
            }

            public void WorkOut()
            {
                weight -= 0.1;
                Console.WriteLine("Run Hamster Run!!");
            }

            public void LiveAYear()
            {
                age += 1;
            }


            public void ShowPetInfo()
            {
                Console.WriteLine($"Name: {name}, Age: {age}, Weight: {weight}, LifeSpan: {lifespan}");
            }


        }

        

        static void Main(string[] args)
        {
            Pet newPet = new Pet("Hamster");
            for(int i = 0; i < 10; i++) 
            {
                newPet.LiveAYear();
                newPet.Eating();
                if(newPet.Weight >= 0.7)
                {
                    newPet.WorkOut();
                }

            }
            newPet.ShowPetInfo();
            Console.WriteLine("GGWP");
        }
    }
}
