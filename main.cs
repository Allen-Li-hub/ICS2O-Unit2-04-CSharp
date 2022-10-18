// Created by: Allen
// Created on: Oct 2022
//
// This program calculates area of a triangle

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        int baseOfTriangle;
        int heightOfTriangle;
        int areaOfTriangle;

        Console.WriteLine("This program calculates the area of a triangle.");
        Console.WriteLine("");

        Console.Write("Enter the base (cm): ");
        baseOfTriangle = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the height (cm): ");
        heightOfTriangle = Convert.ToInt32(Console.ReadLine());

        areaOfTriangle = (baseOfTriangle * heightOfTriangle) / 2;

        Console.WriteLine("");
        Console.WriteLine("The area is: " + areaOfTriangle + " cm². ");

        Console.WriteLine("\nDone.");
    }
}
