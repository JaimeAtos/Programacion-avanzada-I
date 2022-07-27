using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAvanzadaI.src
{
    internal class NumbersMethods
    {
        internal static void EvenNumbers(int sinceNumber)
        {
            Console.WriteLine("Even numbers:");
            for (int i = 0; i < sinceNumber; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
        internal static void OddNumbers(int sinceNumber)
        {
            Console.WriteLine("Odd numbers:");
            for (int i = 0; i < sinceNumber; i++)
            {
                if (i % 2 == 1)
                    Console.WriteLine(i);
            }
        }

        internal static bool MultipleOf3(int number)
        {
            if (number % 3 == 0)
                return true;
            return false;
        }

    }
}
