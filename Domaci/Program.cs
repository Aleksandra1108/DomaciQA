using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            list.Add(number);
            Console.WriteLine("Enter another number");
            number = Convert.ToInt32(Console.ReadLine());
            list.Add(number);
            Console.WriteLine("Enter another number");
            number = Convert.ToInt32(Console.ReadLine());
            list.Add(number);
            BasicStats bStats = new BasicStats();

            Console.WriteLine("The average is {0}", bStats.GetAverage(list));
            Console.WriteLine("The highest is {0}", bStats.GetHighest(list));
            Console.WriteLine("The lowest is {0}", bStats.GetLowest(list));
            Console.WriteLine("The sum is {0}", bStats.GetSum(list));

            Console.ReadKey();
        }
    }
}
