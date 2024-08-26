using System;
using System.IO;

namespace Mohamed_Abdullah_sun_wed_8pm_C_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question => 1
            //1 -  Write a program that allows the user to enter a number then print it.
            //Console.Write("Please Enter Number :");
            //string InputNumber = Console.ReadLine() ?? "";

            //if(int.TryParse(InputNumber , out int number))
            //{
            //    Console.WriteLine(number);
            //} 
            #endregion

            #region Question => 2

            /* 2 - Write C# program that Assigning one value type variable to another and modifying the value
                of one variable and mention what will happen . */

            //int a = 10;
            //int b = a;

            //Console.WriteLine($"Initial value of a: {a}"); // 10
            //Console.WriteLine($"Initial value of b: {b}"); // 10

            //b = 20;

            //Console.WriteLine($"Value of a after modifying b: {a}"); // 10
            //Console.WriteLine($"Value of b after modifying b: {b}"); // 20  
            #endregion

            #region Question => 3
            /* 3 - Write C# program that Assigning one reference type variable to another and modifying the object
                through one variable and mention what will happen . */

            //Person person1 = new Person { Name = "Mohamed", Age = 30 };

            //Person person2 = person1;

            //Console.WriteLine($"Initial value of person1: {person1.Name}, Age: {person1.Age}");// Mohamed => 30
            //Console.WriteLine($"Initial value of person2: {person2.Name}, Age: {person2.Age}"); // Mohamed => 30

            //person2.Name = "Rayyan";
            //person2.Age = 25;

            //Console.WriteLine($"Value of person1 after modifying person2: {person1.Name}, Age: {person1.Age}"); // Rayyan => 25
            //Console.WriteLine($"Value of person2 after modifying person2: {person2.Name}, Age: {person2.Age}"); // Rayyan => 25
            #endregion


        }
    }

    class Person
    {
        public string? Name { get; set; }
        public int Age { get; set; }
    }
}
