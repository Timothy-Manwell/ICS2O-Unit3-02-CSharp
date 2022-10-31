// Created by: Timothy Manwell
// Created on: Oct 2022
//
// This program calculates the area of a pyramid
using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function accepts user input
        double length;
        double width;
        double height;
        double volume;

        Console.WriteLine("This program calculates the volume of a pyramid");
        Console.Write("\nEnter length a in cm: ");
        length = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nEnter width b in cm: ");
        width = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nEnter height in cm: ");
        height = Convert.ToDouble(Console.ReadLine());

        volume = (length * width * height) / 3;
        Console.WriteLine("\nThe volume is: " + volume.ToString("0.00") + " cm². ");
    }
}