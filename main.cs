// Created by: Kenny Le
// Created on: May 2022
//
// This program performs a loop.

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function performs a loop
        int userInput;
        int counter = 1;

        // input
        Console.WriteLine("The sum of a natural numbers");

        Console.WriteLine("");
        Console.Write("Please enter a positive whole number: ");
        userInput = Convert.ToInt32(Console.ReadLine());

        // process
        if (userInput < 0)
        {
            Console.Writeline("Please input a positive whole number!");
        }
        else
        {
            for (counter = 1; counter <= userInput; counter++) {
        }

        // output
        Console.WriteLine("The answer is " + answer);
        Console.WriteLine("\nDone.");
    }
}