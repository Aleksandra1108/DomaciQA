using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci
{
    class BasicStats
    {
        public int GetLowest(List<int> numbers)
        {
            return numbers.Min();

        }
        public int GetHighest(List<int> numbers)
        {
            return numbers.Max();

        }
        public int GetAverage(List<int> numbers)
        {
            return (int)numbers.Average();

        }
        public int GetSum(List<int> numbers)
        {
            return numbers.Sum();

        }


    }
}
