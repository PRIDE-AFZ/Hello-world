using System;

namespace Условные_операторы
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());


            if (x > y && x > z)
            {
                Console.WriteLine("Наибольщее число: " + x);
                switch (x % 2)
                { case 0:
                        Console.WriteLine("Число " + x + " чётное");
                        break;
                  case 1:
                        Console.WriteLine("Число " + x + " нечётное");
                        break;
                }

                var s = x < 100 ? "Число меньше 100" : "Число больще 100";
                Console.WriteLine(s);
            }
            else if (y > x && y > z)
            {
                Console.WriteLine("Наибольщее число: " + y);
                switch (y % 2)
                {
                    case 0:
                        Console.WriteLine("Число " + y + " чётное");
                        break;
                    case 1:
                        Console.WriteLine("Число " + y + " нечётное");
                        break;
                }

                var s = y < 100 ? "Число меньше 100" : "Число больще 100";
                Console.WriteLine(s);
            }
            else
            {
                Console.WriteLine("Наибольщее число: " + z);
                switch (z % 2)
                {
                    case 0:
                        Console.WriteLine("Число " + z + " чётное");
                        break;
                    case 1:
                        Console.WriteLine("Число " + z + " нечётное");
                        break;
                }

                var s = z < 100 ? "Число меньше 100" : "Число больще 100";
                Console.WriteLine(s);
            }

            

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
