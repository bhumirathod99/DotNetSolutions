using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practical2
{
    class Program
    {
      
        static void rectangle()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        static void tringle_left()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        static void tringle_right()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 5; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }


        static void Main(string[] args)
        {
           
            rectangle();
            Console.WriteLine();
            tringle_left();
            Console.WriteLine();
            tringle_right();
            Console.Read();
        }
    }
}
