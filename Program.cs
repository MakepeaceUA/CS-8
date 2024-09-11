using System;
using System.Drawing;
using System.Xml.Linq;
using static ConsoleApp3.Program;

namespace ConsoleApp3
{
    internal class Program
    { 
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5 };
            MyArray arr = new MyArray(num);

            arr.Show();
            arr.Show("Test array.");

            arr.Max();
            arr.Min();
            Console.WriteLine($"Arithmetic mean: {arr.Avg()}");
            Console.WriteLine($"Search: {arr.Search(3)}");
            Console.WriteLine();

            arr.SortAsc();
            arr.Show();
           
            arr.SortDesc();
            arr.Show();
          
            arr.SortByParam(true);
            arr.Show();
           
            arr.SortByParam(false);
            arr.Show();

        }
    }
}