
using System;
using System.Collections.Generic;

namespace VariablesAndDatatypes
{
    class Program
    {
        static void Main()
        {
            // ---- Task 1: variables and interpolated strings ----

            string userName = "Surendra";
            int luckyNumber = 7;

            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");

            // ---- Task 2: constants ----

            Circle circle = new Circle();

            Console.WriteLine($"PI = {Circle.PI}");
            Console.WriteLine($"Area = {circle.Area(5)}");
            Console.WriteLine($"Perimeter = {circle.Perimeter(5)}");

            // ---- Task 3: data types and type conversion ----

            byte tiny = 200;
            short small = 30000;

            int number = 50000;
            long bigNumber = 9000000000L;
            float temperature = 36.5f;
            double price = 99.99;
            decimal salary = 25000.50m;
            char grade = 'A';
            bool isPassed = true;

            string numberText = 42.ToString();
            double convertedNumber = double.Parse("3.14");

            Console.WriteLine($"byte   = {tiny} (type: byte)");
            Console.WriteLine($"short  = {small} (type: short)");
            Console.WriteLine($"int    = {number} (type: int)");
            Console.WriteLine($"long   = {bigNumber} (type: long)");
            Console.WriteLine($"float  = {temperature} (type: float)");
            Console.WriteLine($"double = {price} (type: double)");
            Console.WriteLine($"decimal = {salary} (type: decimal)");
            Console.WriteLine($"char   = {grade} (type: char)");
            Console.WriteLine($"bool   = {isPassed} (type: bool)");
            Console.WriteLine($"string = {numberText} (converted from int)");
            Console.WriteLine($"double = {convertedNumber} (converted from string)");

            // ---- Task 4: arrays and Array methods ----

            int[] numbers = { 42, 7, 19, 3, 88 };

            Console.WriteLine("Original : " + string.Join(", ", numbers));

            Array.Sort(numbers);

            Console.WriteLine("Sorted   : " + string.Join(", ", numbers));

            Array.Reverse(numbers);

            Console.WriteLine("Reversed : " + string.Join(", ", numbers));

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"  [{i}] = {numbers[i]}");
            }

            int position = Array.IndexOf(numbers, 19);
            Console.WriteLine($"IndexOf(19)  = {position}");

            int missingPosition = Array.IndexOf(numbers, 100);
            Console.WriteLine($"IndexOf(100) = {missingPosition}");

            // ---- Task 5: DateTime and TimeSpan ----

            DateTime birthDate = new DateTime(2004, 3, 15);

            DateTime today = DateTime.Now;

            TimeSpan ageSpan = today - birthDate;

            int years = (int)(ageSpan.TotalDays / 365.25);

            Console.WriteLine($"Birth date : {birthDate:yyyy-MM-dd}");
            Console.WriteLine($"Today      : {today:yyyy-MM-dd}");
            Console.WriteLine($"Total days : {ageSpan.TotalDays:F0}");
            Console.WriteLine($"Age        : {years} years");
            Console.WriteLine($"Birth + 10 days : {birthDate.AddDays(10):yyyy-MM-dd}");

            // ---- Task 6: List<T> and Dictionary<K,V> ----

            List<string> fruits = new() { "Apple", "Mango", "Banana" };

            fruits.Add("Orange");

            fruits.Remove("Mango");

            foreach (string fruit in fruits)
            {
                Console.WriteLine("  " + fruit);
            }

            Dictionary<int, string> byId = new Dictionary<int, string>()
            {
                { 1, "Apple" },
                { 2, "Mango" },
                { 3, "Banana" }
            };

            byId.Add(4, "Orange");

            foreach (KeyValuePair<int, string> item in byId)
            {
                Console.WriteLine($"  {item.Key} -> {item.Value}");
            }
        }
    }
}