using System;
using System.Reflection.Metadata.Ecma335;

namespace exercise2c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter aircraft distance to the base (number):");
            var h = Console.ReadLine();
            if (int.TryParse(h, out int p))
            {
                Tutka(p);
            }
            else
                Console.WriteLine($"{h} is not number");
        }

        static void Tutka(int p)
        {
            int x = 0;
            while (x < 4)
            {
                if (p < 100)
                {
                    Console.WriteLine("If you don’t leave this area immediately, we will open fire on you!");
                    break;
                }
                else if ((p >= 100) && (p <= 250))
                {
                    Console.WriteLine("This is a restricted area, please turn away now.");
                    x++;
                    if (x == 3)
                    {
                        Console.WriteLine("If you don’t leave this area immediately, we will open fire on you!");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("radar activating");
                    Console.WriteLine("No enemy aircraft detected near the base");
                    break;
                }
            }return;
        }
    }
}
