﻿using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double length = 20;
            double width = 30;
            double height = 10;
            Console.WriteLine(("Surface: " + (length * width + length * height + width * height) * 2));
            Console.WriteLine("Volume: " + length * width * height);
            Console.Read();
        }
    }
}