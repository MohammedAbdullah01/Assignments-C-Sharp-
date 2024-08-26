using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Reflection.Metadata;
using System.Runtime.Serialization.Formatters;
using System.Security.Principal;
using System.Xml.Linq;
using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mohamed_Abdullah_sun_wed_8pm_C_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Assignment 4 => Part [ Arrays ]


                #region Q => 1
                // 1- Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n* n.

                //Console.Write("Enter size identity matrix: ");
                //string input = Console.ReadLine() ?? "0";

                //if (int.TryParse(input, out int num))
                //{
                //    for (int i = 0; i < num; i++)
                //    {
                //        for (int j = 0; j < num; j++)
                //        {
                //            if (i == j)
                //                Console.Write("1 ");
                //            else
                //                Console.Write("0 ");
                //        }
                //    }

                //}
                //else
                //    Console.WriteLine("Must Be Enter Integer Only"); 

                #endregion


                #region Q => 2
                // 2 - Write a program in C# Sharp to find the sum of all elements of the array.

                //Console.WriteLine("Enter size Array (Only Integer) :");

                //string input = Console.ReadLine() ?? "";

                //if (int.TryParse(input, out int sizeArray))
                //{
                //    double[] numbers = new double [sizeArray];

                //        for (int i = 0;  i < sizeArray;  i++)
                //        {
                //            Console.WriteLine($"Enter {i + 1} ");

                //            string numElement = Console.ReadLine() ?? "";

                //            if (double.TryParse(numElement , out double num))
                //            {
                //                numbers[i] = num;
                //            }
                //            else
                //            {
                //                Console.WriteLine("Must Be Enter Integer OR Floating");
                //                return;
                //            }
                //        }

                //    double sum = 0;

                //        for (int i = 0; i < numbers.Length; i++)
                //        {
                //            sum += numbers[i];
                //        }

                //    Console.WriteLine($"the sum of all elements the array {sum}");
                //}
                //else
                //{
                //    Console.WriteLine("Must Be Enter Integer Only");
                //} 
                #endregion


                #region Q => 3 
                //3 - Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.
                //Console.WriteLine($"First Enter The Size Of The First Array: ");

                //string Input_arraySize1 = Console.ReadLine() ?? "";

                //if (!int.TryParse(Input_arraySize1, out int ArraySize1) || ArraySize1 <= 0)
                //{
                //    Console.WriteLine("The size of the array must be an integer or cannot be negative");
                //    return;

                //}

                //Console.WriteLine($"Second, Enter The Elements Into The First Array");

                //string[] newArray1 = new string[ArraySize1];

                //newArray1 = convert_words_To_array(ArraySize1);

                //Console.WriteLine($"First Enter The Size Of The Second Array: ");

                //string Input_arraySize2 = Console.ReadLine() ?? "";

                //if (!int.TryParse(Input_arraySize2, out int ArraySize2) || ArraySize2 <= 0)
                //{
                //    Console.WriteLine("The size of the array must be an integer or cannot be negative");
                //    return;
                //}

                //Console.WriteLine($"Second, Enter The Elements Into The Second Array");

                //string[] newArray2 = new string[ArraySize2];

                //newArray2 = convert_words_To_array(ArraySize2);

                ////Copy elements from newArray1 AND newArray2 to =>  mergedArray
                //string[] mergedArray = new string[ArraySize2 + ArraySize1];

                //for (int i = 0; i < ArraySize1; i++)
                //{
                //    mergedArray[i] = newArray1[i];
                //}

                //for (int i = 0; i < ArraySize2; i++)
                //{
                //    mergedArray[ArraySize1 + i] = newArray2[i];
                //}

                //Array.Sort(mergedArray);

                //static string[] convert_words_To_array(int sizeArray)
                //{
                //    string[] ArrayElements_i = new string[sizeArray];

                //    for (int j = 0; j < sizeArray; j++)
                //    {
                //        Console.Write($"Enter Element {j + 1} In Array :");
                //        string Input_Element_i = Console.ReadLine() ?? "";

                //        ArrayElements_i[j] = Input_Element_i;

                //    }
                //    return ArrayElements_i;

                //}
                #endregion


                #region Q => 4 
                //4 - Write a program in C# Sharp to count the frequency of each element of an array.
                //Console.WriteLine($"First Enter The Size Of The Array: ");

                //string Input_arraySize = Console.ReadLine() ?? "";

                //if (!int.TryParse(Input_arraySize, out int ArraySize) || ArraySize <= 0)
                //{
                //    Console.WriteLine("The size of the array must be an integer and be greater than 0");
                //    return;
                //}

                //string[] array = new string[ArraySize];

                //for (int i = 0; i < ArraySize; i++)
                //{
                //    Console.Write($"Enter Element {i + 1} :");
                //    string inputElement = Console.ReadLine() ?? "";
                //    array[i] = inputElement;
                //}

                //bool[] counted = new bool[ArraySize];

                //for (int i = 0; i < ArraySize; i++)
                //{
                //    if (!counted[i])
                //    {
                //        int counter = 1;

                //        for (int j = i + 1; j < ArraySize; j++)
                //        {
                //            if (array[i] == array[j])
                //            {
                //                counter++;
                //                counted[j] = true;
                //            }
                //        }
                //        Console.WriteLine($"Element {array[i]} Repeat => {counter}");
                //    }
                //}
                #endregion


                #region Q => 5 
                //5 - Write a program in C# Sharp to find maximum and minimum element in an array

                //Console.WriteLine($"First Enter The Size Of The Array: ");

                //string Input_arraySize = Console.ReadLine() ?? "";

                //if (!int.TryParse(Input_arraySize, out int ArraySize) || ArraySize <= 0)
                //{
                //    Console.WriteLine("The size of the array must be an integer and be greater than 0");
                //    return;
                //}


                //double[] numbers = new double[ArraySize];

                //for (int i = 0; i < ArraySize; i++)
                //{
                //    Console.Write($"Enter Element {i + 1} :");
                //    string Input_Element = Console.ReadLine() ?? "";

                //    if (!double.TryParse(Input_Element, out double num))
                //    {
                //        Console.WriteLine("The Element of the array must be an integer or Float");
                //        return;
                //    }

                //    numbers[i] = num;
                //}


                //double min = numbers[0];
                //double max = numbers[0];

                //for (int i = 0; i < numbers.Length; i++)
                //{
                //    if (numbers[i] < min)
                //    {
                //        min = numbers[i];
                //    }

                //    if (numbers[i] > max)
                //    {
                //        max = numbers[i];
                //    }
                //}

                //Console.WriteLine("======================");
                //Console.WriteLine($"Max Number = {max}");
                //Console.WriteLine($"Min Number = {min}");
                //Console.WriteLine("======================"); 
                #endregion


                #region Q => 6 
                //5 - Write a program in C# Sharp to find maximum and minimum element in an array
                //Console.WriteLine($"First Enter The Size Of The Array: ");

                //string Input_arraySize = Console.ReadLine() ?? "";

                //if (!int.TryParse(Input_arraySize, out int ArraySize) || ArraySize <= 3)
                //{
                //    Console.WriteLine("The size of the array must be an integer and be greater than 3");
                //    return;
                //}


                //double[] numbers = new double[ArraySize];

                //for (int i = 0; i < ArraySize; i++)
                //{
                //    Console.Write($"Enter Element {i + 1} :");
                //    string Input_Element = Console.ReadLine() ?? "";

                //    if (!double.TryParse(Input_Element, out double num))
                //    {
                //        Console.WriteLine("The Element of the array must be an integer or Float");
                //        return;
                //    }

                //    numbers[i] = num;
                //}

                //double max = double.MinValue;

                //double secondMax = double.MinValue;

                //for (int j = 0; j < ArraySize; j++)
                //{
                //    if (numbers[j] > max)
                //    {
                //        secondMax = max;
                //        max = numbers[j];
                //    }
                //    else if (numbers[j] > secondMax && numbers[j] != max)
                //    {
                //        secondMax = numbers[j];
                //    }

                //}
                //Console.WriteLine($"second largest element \r\nin an array => {secondMax}"); 
                #endregion


                #region Q => 7 
                //7 - Consider an Array of Integer values with size N, having values as [ 7, 0, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3]
                //Console.WriteLine($"First Enter The Size Of The Array: ");

                //string Input_arraySize = Console.ReadLine() ?? "";

                //if (!int.TryParse(Input_arraySize, out int ArraySize) || ArraySize <= 2)
                //{
                //    Console.WriteLine("The size of the array must be an integer and be greater than 2");
                //    return;
                //}


                //double[] numbers = new double[ArraySize];

                //for (int i = 0; i < ArraySize; i++)
                //{
                //    Console.Write($"Enter Element {i + 1} :");
                //    string Input_Element = Console.ReadLine() ?? "";

                //    if (!double.TryParse(Input_Element, out double num))
                //    {
                //        Console.WriteLine("The Element of the array must be an integer or Float");
                //        return;
                //    }

                //    numbers[i] = num;
                //}


                //int Distance = 0;

                //for (int i = 0; i < ArraySize - 1; i++)
                //{
                //    for (int j = i + 1; j < ArraySize; j++)
                //    {
                //        if (numbers[i] == numbers[j])
                //        {
                //            if (Distance < j - i - 1)
                //            {
                //                Distance = j - i - 1;
                //            }
                //        }
                //    }
                //}

                //Console.WriteLine($"Max Distance => {Distance} ");

                #endregion


                #region Q => 8 
                //8 - Given a list of space separated words, reverse the order of the words.

                //Console.WriteLine("Enter The Words:");

                //string words = Console.ReadLine() ?? "";

                //string[] array_Words = words.Split(' ');

                //string wordReverse = String.Empty;

                //for (int i = array_Words.Length -1 ; i >= 0; i--)
                //{
                //    wordReverse += i > 0 ? $"{array_Words[i]} " : array_Words[i];
                //}

                //Console.WriteLine(wordReverse);

                #endregion


                #region Q => 9 
                //Write a program to create two multidimensional arrays of the same size. Accept value from the user and store them in the first
                //array.Now copy all the elements of the first array onto the second array and print the second array

                //Console.Write("Please Enter Count Rows: ");
                //string input_row = Console.ReadLine() ?? "";
                //if(!int.TryParse(input_row , out int rows) && rows > 0)
                //{
                //    Console.WriteLine("The Count Of Rows must be an integer and be greater than 0");
                //}
                //Console.Write("Please Enter Count Columns: ");
                //string input_column = Console.ReadLine() ?? "";
                //if (!int.TryParse(input_column, out int columns) && columns > 0)
                //{
                //    Console.WriteLine("The Count Of Columns must be an integer and be greater than 0");
                //}

                //string[,] Dim_current = new string[rows,columns];

                //for (int i = 0; i < rows; i++)
                //{
                //    for (int j = 0; j < columns; j++)
                //    {
                //        Dim_current[i, j] = $"{(j + 1) * 100}";
                //    }

                //}

                //string[,] newDim = new string[rows , columns];

                //for (int i = 0; i < rows; i++)
                //{
                //    for (int j = 0; j < columns; j++)
                //    {
                //        newDim[i, j] = Dim_current[i, j];
                //    }

                //}

                //for (int i = 0; i < rows; i++)
                //{
                //    for (int j = 0; j < columns; j++)
                //    {
                //        Console.WriteLine(newDim[i, j]);
                //    }

                //}
                #endregion


                #region Q => 10 
                //11 - Write a Program to Print One Dimensional Array in Reverse Order
                //Console.WriteLine("Enter size Array (Only Integer) :");

                //string input = Console.ReadLine() ?? "";

                //if (int.TryParse(input, out int sizeArray) && sizeArray > 0)
                //{
                //    float[] numbers = new float[sizeArray];

                //    for (int i = 0; i < sizeArray; i++)
                //    {
                //        Console.WriteLine($"Enter Element => {i + 1} : ");

                //        string numElement = Console.ReadLine() ?? "";

                //        if (float.TryParse(numElement, out float num))
                //        {
                //            numbers[i] = num;
                //        }
                //        else
                //        {
                //            Console.WriteLine("Must Be Enter Element Integer OR Floating");
                //            return;
                //        }
                //    }


                //    for (int i = 0; i < numbers.Length - 1; i++)
                //    {
                //        for (int a = 0; a < numbers.Length - 1; a++)
                //        {
                //            if (numbers[a] < numbers[a + 1])
                //            {
                //                var swap = numbers[a + 1];
                //                numbers[a + 1] = numbers[a];
                //                numbers[a] = swap;
                //            }

                //        }
                //    }

                //    foreach (var number in numbers)
                //    {
                //        Console.Write($"{number} ");
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Must Be Enter Array Integer Or Gretter Then 0");
                //    return;
                //} 
                #endregion

            #endregion



            #region Assignment 4 => Part [ General ]


                #region Q => 1 
                //1-Write a program that calculates the simple interest given the principal amount, rate of interest,
                //and time.The formula for simple interest is Interest = (principal * rate * time) / 100

                //Console.Write("Enter Principal Amount (Integer Or Float) : ");
                //string? inputPrincipalAmount = Console.ReadLine();

                //Console.Write("Enter Rate Interest (Integer Or Float) : ");
                //string? inputRateInterest = Console.ReadLine();
                //DateTime time = DateTime.Now;
                //float principalAmount, rateInterest;

                //if (float.TryParse(inputPrincipalAmount, out principalAmount) && float.TryParse(inputRateInterest, out rateInterest) && principalAmount > 0)
                //{
                //    float Interest = (principalAmount * rateInterest * time.Hour) / 100;
                //    Console.WriteLine(Math.Round(Interest , 3) );
                //}else
                //{
                //Console.WriteLine("(The Principal Amount must be an integer or Float) || (The Rate Interest must be an integer or Float) || Principal Amount > 0 ");
                //}
                #endregion


                #region Q => 2 
                // 2- Write a program that calculates the Body Mass Index(BMI) given a person's weight in kilograms and height in meters.
                // The formula for BMI is BMI = (Weight) / (Height * Height)
                //float weight, height, bmi;

                //Console.Write("Enter weight in kilograms: ");
                //string? inputWeight = Console.ReadLine();

                //Console.Write("Enter height in meters: ");
                //string? inputHeight = Console.ReadLine();

                //if(float.TryParse(inputWeight , out weight) && float.TryParse(inputHeight , out height) && weight  > 0 && height > 0)
                //{
                //     bmi = weight / (height * height);
                //     Console.WriteLine($"BMI: {bmi}");
                //}
                //else
                //{
                //    Console.WriteLine(@"
                //    1 - (The Weight must be an integer or Float)  OR
                //    2 - (The Height must be an integer or Float)  OR 
                //    3 - (The Weight must be Grater Then 0 ) OR
                //    4 - (The height must be Grater Then 0)");

                //}
                #endregion


                #region Q => 3 
                // 3- Write a program that uses the ternary operator to check if the temperature is too hot, too cold,
                // or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold",
                // above 30 degrees is "Just Hot", and anything else is "Just Good"

                //Console.WriteLine("Enter Temperature : ");

                //int temperature;
                //string? inputTemperature = Console.ReadLine();

                //if(!int.TryParse(inputTemperature , out temperature))
                //{
                //    Console.WriteLine("The Temperature must be an integer Only");
                //}

                //var result = temperature < 10 ? "Just Cold" : temperature > 30 ? "Just Hot" : "Just Good";

                //Console.WriteLine($"Weather Condition {result}"); 
                #endregion


                #region Q => 4
                /* Write a program that takes the date from the user and displays it in various formats using string interpolation.
                    Note:
                     - Today’s date : 20 , 11 , 2001
                     - Today's date : 20 / 11 / 2001
                     - Today's date : 20 – 11 – 2001
                */

                //Console.WriteLine("Enter the date (YYYY/MM/DD):");
                //string? inputDate = Console.ReadLine();

                //DateTime date;
                //if (!DateTime.TryParse(inputDate, out date))
                //{
                //    Console.WriteLine("Invalid date format. Please enter in YYYY/MM/DD format. OR Cannot Date Empty");
                //}
                //else
                //{
                //    Console.WriteLine($"Today’s date: {date.Day}, {date.Month}, {date.Year}");
                //    Console.WriteLine($"Today's date: {date.Day}/{date.Month}/{date.Year}");
                //    Console.WriteLine($"Today's date: {date.Day} - {date.Month} - {date.Year}");
                //} 
                #endregion


                #region Q => 5
                /*What is the output of the following C# code?
                DateTime date = new DateTime(2024, 6, 14);
                    Console.WriteLine($"The event is on {date:MM/dd/yyyy}");

                    a) The event is on 14/06/2024
                    b) The event is on 2024-06-14
                    c) The event is on 06/14/2024
                    d) The event is on June 14, 2024
                 */

                // output => C
                // The event is on 06/14/2024
                #endregion


            #endregion

        }
    }
}
