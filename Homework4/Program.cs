using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of factorials to display: ");
            string input = Console.ReadLine(); 
            int x = int.Parse(input);
            int[] factorials = new int[x];
            int tempTotal = 1;

            for (int y = x; y <= x && y > 0; y--)
            {
                for (int i = 1; i <= y; i++)
                {
                    tempTotal = tempTotal * i;
                }
                factorials[y - 1] = tempTotal;
                tempTotal = 1;
            }
            int count = 1;
            foreach (var factorial in factorials)
            {
                Console.WriteLine("{0}!   =   " + factorial, count);
                count++;
            }
            Console.ReadLine();
        }
    }
}
