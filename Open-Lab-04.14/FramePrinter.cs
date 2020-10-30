using NUnit.Framework;
using System;

namespace Open_Lab_04._14
{
    public class FramePrinter
    {
        public void Print(string[] strings)
        {
            int a = 0;
            for (int l = 0; l < strings.Length; l++)
            {
                if (strings[l].Length > a)
                {
                    a = strings[l].Length;
                }
            }
            for (int i = 1; i < a + 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write("* " + strings[i]);

                for (int s = 0; s < a - strings[i].Length; s++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(" *");
            }
            for (int i = 1; i < a + 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("*");
        }
    }
} 
           