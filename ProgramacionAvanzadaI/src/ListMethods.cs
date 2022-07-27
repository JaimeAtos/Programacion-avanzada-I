using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAvanzadaI.src
{
    internal class ListMethods
    {
        internal static void Ascending<T>(List<T> lst)
        {
            lst.Sort();
            foreach (var element in lst)
            {
                Console.WriteLine(element);
            }
        }
        internal static void Descending<T>(List<T> lst)
        {
            var DesList = lst.OrderByDescending(x => x.ToString()).ToList();
            foreach (var element in DesList)
            {
                Console.WriteLine(element);
            }
        }
        internal static double MaxValue(List<int> lst)
        {
            return lst.Max();
        }
        internal static double MinValue(List<int> lst)
        {
            return lst.Min();
        }
        internal static double AverageValue(List<int> lst)
        {
            return lst.Average();
        }
    }
}
