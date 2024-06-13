using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_5_demo_2
{
    class Program
    {
        static void Main()
        {
            // Khởi tạo mảng số nguyên
            int[] numbers = { 5, 3, 8, 1, 9, 2, 7, 4, 6 };

            //---------------Sorting Operators:-----------------------//
            // Sắp xếp tăng dần
            var sortedAscending = numbers.OrderBy(n => n);
            Console.WriteLine("Mảng sau khi sắp xếp tăng dần:");
            foreach (var n in sortedAscending)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            // Sắp xếp giảm dần
            var sortedDescending = numbers.OrderByDescending(n => n);
            Console.WriteLine("Mảng sau khi sắp xếp giảm dần:");
            foreach (var n in sortedDescending)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            //---------------Partition Operators:---------------------//
            // Skip và Take dùng để phân trang dữ liệu
            var skipped = numbers.Skip(2); // Bỏ qua 2 phần tử đầu tiên
            Console.WriteLine("Mảng sau khi bỏ qua 2 phần tử đầu tiên:");
            foreach (var n in skipped)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();

            var taken = sortedDescending.Take(3); // Chọn 3 phần tử đầu tiên
            Console.WriteLine("3 phần tử đầu tiên của mảng:");
            foreach (var n in taken)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
        }
    }
}
