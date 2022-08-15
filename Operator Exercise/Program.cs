﻿using System;

namespace Operator_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Greetings. Today, we will evaluate the division and modulus of two assigned numeric variables.");
            var a = 17;
            var b = 4;
            var div = a / b;
            var mod = a % b;
            Console.WriteLine($"{a}/{b} is {div} remainder {mod}.");
            Console.WriteLine("");

            Console.WriteLine("Now, we will determine what the two dimensional area of a circle, with a radius of 20, is.");
            var r = 20;
            var pi = Math.PI;
            var areaOfCircle = pi * (r * r);
            Console.WriteLine($"The area of a circle with a radius of {r} is {areaOfCircle}.");
            Console.WriteLine("");

            Console.WriteLine("If you had a circle, what would its radius be?");
            var radius = double.Parse(Console.ReadLine());
            var areaOfCircle1 = pi * (radius * radius);
            Console.WriteLine($"The area of a circle with a radius of {radius} would be {areaOfCircle1}.");
            Console.WriteLine("");

            Console.WriteLine("Going back to the beginning of this script, let's have you choose the two numbers which we can divide and 'modulate'.");
            Console.WriteLine($"What is your first number?");
            var c = Single.Parse(Console.ReadLine());
            Console.WriteLine($"What is your second number?");
            var d = Single.Parse(Console.ReadLine());
            var div1 = c / d;
            var mod1 = c % d;
            Console.WriteLine($"{c}/{d} is {div1} remainder {mod1}.");
        }
    }
}
