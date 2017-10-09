using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog firstDoge = new Dog();

            //firstDoge.Weight = 60.00;
            //firstDoge.Height = 3.2f;
            //firstDoge.FurLength = "Flowing mane. ";
            //firstDoge.Speed = "will fetch ... eventually. ";

            //firstDoge.Groom();
            //Console.WriteLine(firstDoge.FurLength);

            //firstDoge.Run();
            //Console.WriteLine("The dog now weighs " + firstDoge.Weight);
            //Console.WriteLine(firstDoge.Speed);

            Dog secondDoge = new Dog("fluffy ", 4.04f);
            Console.WriteLine(secondDoge.FurLength);

            secondDoge.Groom();
            Console.WriteLine(secondDoge.FurLength);

            secondDoge.Speed = "faster than lightning. ";
            Console.WriteLine(secondDoge.Speed);

            secondDoge.Run();
            Console.WriteLine(secondDoge.Speed);

            secondDoge.Weight = 78.9;
            Console.WriteLine(secondDoge.Weight);

            secondDoge.Potty();
            Console.WriteLine(secondDoge.Weight);

            secondDoge.Bark();

        }
    }
}
