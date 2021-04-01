using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число ");
            int number = Convert.ToInt32(Console.ReadLine());
            int del = number % 2;

            if (del == 1)
            {
                Console.WriteLine("Число не четное " );
            }
                
            else
            {
                Console.WriteLine("Число  четное " );
            }

        }
    }
}
