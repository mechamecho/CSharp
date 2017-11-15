using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 7 };
            //Properties

            Console.WriteLine(arr.Length);
            //Outputs 3
            Console.WriteLine(arr.Rank);
            //Outputs 1

            //Methods
            Console.WriteLine(arr.Max());
            Console.WriteLine(arr.Min());
            Console.WriteLine(arr.Sum());

        }
    }
}
