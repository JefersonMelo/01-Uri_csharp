﻿using System;

namespace URI_1042
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int a, b, c;
            a = int.Parse(s[0]);
            b = int.Parse(s[1]);
            c = int.Parse(s[2]);

            if (a < b && a < c)
            {
                if (b < c) { Console.WriteLine($"{a}\n{b}\n{c}\n"); }
                else { Console.WriteLine($"{a}\n{c}\n{b}\n"); }
            }
            else if (b < a && b < c)
            {
                if (a < c) { Console.WriteLine($"{b}\n{a}\n{c}\n"); }
                else { Console.WriteLine($"{b}\n{c}\n{a}\n"); }
            }
            else if (c < a && c < b)
            {
                if (b < a) { Console.WriteLine($"{c}\n{b}\n{a}\n"); }
                else { Console.WriteLine($"{c}\n{a}\n{b}\n"); }
            }

            Console.WriteLine($"{a}\n{b}\n{c}");
        }
    }
}
