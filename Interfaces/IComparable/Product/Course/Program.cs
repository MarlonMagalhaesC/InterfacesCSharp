using Course.Entities;
using Course.Service;
using System;
using System.Globalization;
using System.Numerics;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter name and price of Product: ");

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(",");

                list.Add(new Product(vect[0], double.Parse(vect[1])));
            }

            CalculationService calculationService = new CalculationService();

            Console.Write("Max: " + calculationService.Max(list));
        }
    }
}