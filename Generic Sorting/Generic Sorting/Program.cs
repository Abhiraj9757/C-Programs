using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {

            List<object> numbers = new List<object>() { 1, 8, 7, 3, 5, 2, 6 };
            Console.WriteLine("Numbers before sorting");
            foreach (object number in numbers)
            {
                Console.WriteLine(number);
            }
            numbers.Sort();
            Console.WriteLine("Numbers After sorting");
            foreach (object number in numbers)
            {
                Console.WriteLine(number);
            }
            List<object> Twins = new List<object>() { 1.23, 3.45, 55.01, 2.34, 3.11, 4.05, 9.45, 6.66 };
            Console.WriteLine("Double before sorting");
            foreach (object Twin in Twins)
            {
                Console.WriteLine(Twin);
            }
            Twins.Sort();
            Console.WriteLine("Double After sorting");
            foreach (object Twin in Twins)
            {
                Console.WriteLine(Twin);
            }
            List<object> alphabets= new List<object>() {"I","L","V","E" ,"A","T"}  ;
            Console.WriteLine("Alphabets before sorting");
            foreach (object alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
            }
            alphabets.Sort();
            Console.WriteLine("Alphabets After sorting");
            foreach (object alphabet in alphabets)
            {
                Console.WriteLine(alphabet);
                
            }
            Console.ReadLine();
        }
    }
}
