using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P517_extentions.Extentions
{
    public static class ListExtentions
    {
        public static double AverageNumber(this List<int> numbers)
        {
            if (numbers.Count == 0 || numbers ==null)
            {
                throw new ArgumentException("Duzgun list daxil et");
            }
            return (double)numbers.Sum() / numbers.Count;
        }
    }
}
