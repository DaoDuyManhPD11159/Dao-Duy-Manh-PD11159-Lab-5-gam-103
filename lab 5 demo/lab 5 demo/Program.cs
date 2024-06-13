using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_demo
{
    class Program
    {
        static void Main()
        {
            int[] aw = { 1, 2, 4, 6, 9, 10, 12 };

            var evenNumbers = aw.Where(n => n % 2 == 0);

            int product = evenNumbers.Aggregate(1, (acc, x) => acc * x);

            Console.WriteLine("Tích các số chia hết cho 2 là: " + product);
        }
    }
}
