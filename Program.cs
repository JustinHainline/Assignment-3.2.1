﻿namespace Assignment_3._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = 
            {
            { 2, 3, 4 },
            { 1, 4, 6 }
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("| " + array[i, j] + " ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}