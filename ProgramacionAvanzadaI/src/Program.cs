using System;
using System.Collections.Generic;
using System.Linq;

namespace ProgramacionAvanzadaI.src
{
    internal class Program
    {
        public delegate void ListingNumbers(int sinceNumber);
        public delegate void ListingList<T>(List<T> myList);
        public delegate bool Numbers(int numberToCheck);
        public delegate void WritingText(string text);
        public delegate double StatisticsOperations(List<int> statistics);
        public delegate void RMS(List<int> numbers);

        private static void ShowText(string value)
        {
            Console.WriteLine($"The text is: {value}");
        }
        private static void RMSOperation(List<int> lst)
        {
            double result = 0;
            foreach (var number in lst)
            {
                result+=Math.Pow(number, 2);
            }
            result /= lst.Count;
            result = Math.Sqrt(result);
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            ListingNumbers Pairs = NumbersMethods.EvenNumbers, Nones = NumbersMethods.OddNumbers;
            Pairs(100);
            Nones(100);

            ListingList<string> Asc = ListMethods.Ascending, Desc = ListMethods.Descending;
            List<string> MyStringList = new List<string>() { "as", "desk", "wardrop", "bottle", "pencil", "bagpack" };

            Asc(MyStringList);
            Desc(MyStringList);

            Numbers CheckingNumber = NumbersMethods.MultipleOf3;
            Console.WriteLine(CheckingNumber(51));

            WritingText PrintingOnConsole = ShowText;
            PrintingOnConsole("this sample text lol");

            List<int> MyNumberList = new List<int>() { 1, 45, 9, 23, 420, 91, 1001 };
            StatisticsOperations Max = ListMethods.MaxValue;
            StatisticsOperations Min = ListMethods.MinValue;
            StatisticsOperations Avg = ListMethods.AverageValue;

            Console.WriteLine($"Max value: {Max(MyNumberList)}, min value: {Min(MyNumberList)} and average value: {Avg(MyNumberList)}");

            List<int> MyNumberListRMS = new List<int>() { 2, 3, 5, 6, 7 };

            RMS RootMeanSquare = RMSOperation;
            RootMeanSquare(MyNumberListRMS);

            /*Action, funct & predicate*/

            Action<string> WriteSomething = text => Console.WriteLine($"Writing text: {text}");
            Predicate<int> MoreThan18 = age => age >= 18;
            Func<int, int, int> SumUp = (x, y) => x + y;

            WriteSomething("Delegates are ez");
            Console.WriteLine(MoreThan18(14));
            Console.WriteLine(SumUp(5,7));

        }
    }
}
