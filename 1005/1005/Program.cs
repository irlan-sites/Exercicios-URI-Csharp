﻿using System.Globalization;

namespace _1005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, m;

            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());

            m = (A * 3.5 + B * 7.5) / 11;

            Console.WriteLine($"MEDIA = {m.ToString("F5", CultureInfo.InvariantCulture)}");
        }
    }
}
