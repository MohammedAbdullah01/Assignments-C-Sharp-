using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Mohamed_Abdullah_sun_wed_8pm_C_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q => 1

            // 1 - Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.

            //Console.Write("Enter  Number: ");
            //string input = Console.ReadLine();

            //int num;

            //Boolean check_number = int.TryParse(input, out num);

            //if(check_number)

            //    if((num % 3 == 0) && (num % 4 == 0))

            //        Console.WriteLine("Yes :)");
            //    else
            //        Console.WriteLine("No :(");

            //else

            //    Console.WriteLine("This is Input Cannot a String :(");

            #endregion


            #region Q => 2

            // 2- Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.

            //Console.Write("Enter  Number: ");
            //string input = Console.ReadLine();

            //int num;

            //Boolean check_number = int.TryParse(input, out num);

            //if (check_number)

            //    if (num >= 0)

            //        Console.WriteLine("positive :)");
            //    else
            //        Console.WriteLine("negative :)");

            //else

            //    Console.WriteLine("This is Input Cannot a String :(");

            #endregion


            #region Q => 3

            // 3- Write a program that takes 3 integers from the user then prints the max element and the min element. (Custom Advanced)

            //Console.WriteLine("Enter 3 integers ");

            //string input_integers = Console.ReadLine();

            //byte[] conver_input_to_ascii = Encoding.ASCII.GetBytes(input_integers);

            //input_integers = "";

            //    for (int i = 0; i < conver_input_to_ascii.Length; i++)
            //    {
            //        if (conver_input_to_ascii[i] > 57 || conver_input_to_ascii[i] < 48)
            //        {
            //            conver_input_to_ascii[i] = 44;
            //        }
            //        input_integers += Convert.ToChar(conver_input_to_ascii[i]);
            //    }


            //string[] list_string = input_integers.Split(",", StringSplitOptions.RemoveEmptyEntries);

            //int[] list_integers = new int[list_string.Length];


            //    for (int i = 0; i < list_string.Length; i++)
            //    {
            //        list_integers[i] = int.Parse(list_string[i]);
            //    }

            //int max_num = list_integers.Max();
            //int min_num = list_integers.Min();


            //Console.WriteLine($"Max Element = {max_num}\nMin Element = {min_num}");

            #endregion


            #region Q => 4

            // 4- Write a program that allows the user to insert an integer number then check If a number is even or odd.

            //Console.WriteLine("Enter Integer:");

            //string input = Console.ReadLine();
            //int num;
            //if(int.TryParse(input , out num))
            //    if((num % 2) == 0)
            //        Console.WriteLine("integer is even");
            //    else
            //       Console.WriteLine("integer is odd");

            //else
            //    Console.WriteLine("This is Input Cannot a String ");

            #endregion


            #region Q => 5

            // 5- Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant)

            //Console.WriteLine("Enter Character Only One");

            //string input = Console.ReadLine().ToLower();

            //foreach (char character in input)
            //{
            //    int asciiCode = (int) character;
            //        switch(character)
            //        {
            //            case 'a':
            //            case 'i':
            //            case 'o':
            //            case 'u':
            //            case 'e':
            //                Console.WriteLine("vowel");
            //                break;
            //            default:
            //                Console.WriteLine("consonant");
            //                break;
            //        }
            //}

            #endregion


            #region Q => 6

            // 6- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.
            //Console.WriteLine("Enter Number:");

            //string input = Console.ReadLine();

            //int num;

            //if (int.TryParse(input, out num))
            //{
            //    int[] numbers = new int[num];

            //    for (int i = 0; i < num; i++)
            //    {
            //        numbers[i] = i + 1;
            //    }

            //    string result = string.Join(",", numbers);
            //    Console.WriteLine(result);
            //}
            //else
            //    Console.WriteLine("This is Input Cannot a String");

            #endregion


            #region Q => 7

            // 7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.

            //Console.WriteLine("Enter Number:");

            //string input = Console.ReadLine();

            //int num;

            //if (int.TryParse(input, out num))
            //{
            //    int[] numbers = new int[12];

            //    for (int i = 1; i <= 12; i++)
            //    {
            //        numbers[i - 1] = i * num;
            //    }

            //    string result = string.Join(" ", numbers);
            //    Console.WriteLine(result);
            //}
            //else
            //    Console.WriteLine("This is Input Cannot a String");

            #endregion


            #region Q => 8

            // 8- Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.WriteLine("Enter Number:");

            //string input = Console.ReadLine();

            //int num;

            //if (int.TryParse(input, out num))
            //{
            //    string numbers = "";

            //    for (int i = 1; i <= num; i++)
            //    {


            //        if(i % 2 == 0 )
            //        {
            //            numbers += Convert.ToString(i) + (i < num ? " " : "");
            //        }

            //    }

            //    Console.WriteLine(numbers);
            //}
            //else
            //    Console.WriteLine("This is Input Cannot a String");

            #endregion


            #region Q => 9

            // 9- Write a program that takes two integers then prints the power.

            //Console.WriteLine("Enter Tow Number Between Space:");

            //string input = Console.ReadLine();

            //string[] numbers = input.Split(" ");

            //int num_current;
            //int num_Pow;

            //if (int.TryParse(numbers[0], out num_current) && int.TryParse(numbers[1], out num_Pow))
            //{
            //    int result = 1;

            //    for (int i = 0; i < num_Pow; i++)
            //    {
            //        result *= num_current;
            //    }

            //    Console.WriteLine(result);
            //}
            //else
            //    Console.WriteLine("This is Input Cannot a String");

            #endregion


            #region Q => 10
            // 10- Write a program to enter marks of five subjects and calculate total, average and percentage.

            //Console.WriteLine("Enter Marks of five subjects:");

            //string input = Console.ReadLine();

            //string[] numbers = input.Split(" ");

            //int total = 0;
            //double Average;
            //double Percentage;

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (int.TryParse(numbers[i], out int  num))
            //    {
            //        total += num;
            //    }
            //    else
            //        Console.WriteLine("This is Input Cannot a String");
            //}
            //Percentage = (total * 100) / (100 * numbers.Length);
            //Average = total / numbers.Length;
            //Console.WriteLine($"Total marks = {total}\nAverage Marks = {Average}\nPercentage = {Percentage}%");

            #endregion


            #region Q => 11
            // 11- Write a program to input the month number and print the number of days in that month.

            //Console.WriteLine("Enter The Month Number:");

            //string input =  Console.ReadLine() ?? "";

            //if (int.TryParse(input, out int num_month))
            //{
            //    string result = "Days in Month:";
            //    switch(num_month)
            //    {
            //           case 1:
            //           case 3:
            //           case 5:
            //           case 7:
            //           case 8:
            //           case 10:
            //           case 12:
            //            Console.WriteLine(result + 31);
            //                break;
            //            case 2:
            //            Console.WriteLine(result + 28);
            //                break;
            //            case 4:
            //            case 6:
            //            case 9:
            //            case 11:
            //            Console.WriteLine(result + 30);
            //            break;
            //        default:
            //            Console.WriteLine("Not Found Num Month");
            //            break;
            //        }
            //    }
            //else
            //    Console.WriteLine("This is Input Cannot a String");

            #endregion


            #region Q => 12
            // 12- Write a program to create a Simple Calculator.

            //Console.WriteLine("Please Enter First Number\n---------------------------");

            //string input_num_one = Console.ReadLine() ?? "0";

            //Console.WriteLine("Please Enter The Operation ( [+] OR [-] OR [*] OR [/] OR [%] )\n---------------------------");

            //string input_operator = Console.ReadLine() ?? "";

            //Console.WriteLine("Please Enter Second Number\n---------------------------");

            //string input_num_tow = Console.ReadLine() ?? "0";

            //Console.WriteLine("---------------------------");

            //double first_num, second_num, result;

            //if (double.TryParse(input_num_one, out first_num) && double.TryParse(input_num_tow, out second_num))
            //{
            //      switch(input_operator)
            //        {
            //            case "+":
            //                result =  first_num + second_num;
            //                Console.WriteLine($"{first_num} + {second_num} =  {result}\n---------------------------");
            //                break;
            //            case "-":
            //                result = first_num - second_num;
            //                Console.WriteLine($"{first_num} - {second_num} =  {result}\n---------------------------");
            //                break;
            //            case "*":
            //                result = first_num * second_num;
            //                Console.WriteLine($"{first_num} * {second_num} =  {result}\n---------------------------");
            //                break;
            //            case "/":
            //                result = first_num / second_num;
            //                Console.WriteLine($"{first_num} / {second_num} =  {result}\n---------------------------");
            //                break;
            //            case "%":
            //                result = first_num % second_num;
            //                Console.WriteLine($"{first_num} % {second_num} =  {result}\n---------------------------");
            //                break;
            //                default : 
            //                    Console.WriteLine($"This Is Operator Not Found {input_operator} :(");
            //                break;
            //        }
            //}
            //else
            //{
            //    Console.WriteLine("The Entry Must Be a Number  a [ First Number OR Second Number ]");

            //}
            #endregion


            #region Q => 13
            // 13- Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.WriteLine("Please Enter a String To Convert It To a Reverse String\n--------------------------------------------------------");

            //string input = Console.ReadLine() ?? "";

            //string result = "";

            //if(input.Length > 0)
            //{
            //    for (int i = input.Length - 1; i >= 0; i--)
            //    {

            //        result += input[i];
            //    }

            //    Console.WriteLine($"Reversing a String = {result}");

            //}
            //else
            //{
            //    Console.WriteLine("The String Cannot Be Empty :(");
            //}

            #endregion


            #region Q => 14
            // 14- Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.WriteLine("Please Enter a Integer To Convert It To a Reverse Integer\n--------------------------------------------------------");

            //string input = Console.ReadLine() ?? "";

            //if(int.TryParse(input , out int num))
            //{
            //    string result = "";

            //    if (input.Length > 0)
            //    {
            //        for (int i = input.Length - 1; i >= 0; i--)
            //        {

            //            result += input[i];
            //        }
            //        Console.WriteLine($"Reversing a Integer = {result} =>  {Convert.ToInt32(result).GetType()}");

            //    }
            //    else
            //    {
            //        Console.WriteLine("The Integer Cannot Be Empty :(");
            //    }

            //}

            #endregion


            #region Q => 15
            // 15- Write a program in C# Sharp to find prime numbers within a range of numbers.

            ////Input starting number of range: 1
            //    Console.WriteLine("Input starting number of range:");
            //    string input_start_num = Console.ReadLine() ?? "";

            ////Input ending number of range: 50
            //    Console.WriteLine("Input ending number of range:");
            //    string input_end_num = Console.ReadLine() ?? "";

            //if (int.TryParse(input_start_num , out int start_num) && int.TryParse(input_end_num , out int end_num))
            //{
            //    for (int i = start_num; i <= end_num; i++)
            //    {
            //        int counter = 0;
            //        for (int j = 2; j <= i / 2; j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                counter++;
            //                break;
            //            }
            //        }

            //        if (counter == 0 && i != 1)
            //        {
            //            Console.Write("{0} ", i);
            //        }
            //    }
            //}

            #endregion


            #region Q => 16
            // 16- Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.WriteLine("Enter a number to convert:");
            //    string input = Console.ReadLine() ?? "";

            //if(decimal.TryParse(input , out decimal result))
            //{
            //    long decimalAsLong = (long)result;
            //    string binary = Convert.ToString(decimalAsLong, 2);
            //Console.WriteLine($"The Binary of {decimalAsLong} is = > {binary}");

            //}else
            //{
            // Console.WriteLine("Cannot Be Write String");
            //}


            #endregion


            #region Q => 17
            // 17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.


            // Console.WriteLine("Enter three points input only numeric => (x1, y1), (x2, y2), (x3, y3):");

            // Console.Write("Please Enter x1:");
            // string x1 = Console.ReadLine() ?? "";

            // Console.Write("Please Enter y1:");
            // string y1 = Console.ReadLine() ?? "";

            // Console.Write("Please Enter x2:");
            // string x2 = Console.ReadLine() ?? "";

            // Console.Write("Please Enter y2:");
            // string y2 = Console.ReadLine() ?? "";

            // Console.Write("Please Enter x3:");
            // string x3 = Console.ReadLine() ?? "";

            // Console.Write("Please Enter y3:");
            // string y3 = Console.ReadLine() ?? "";

            // Console.WriteLine("-------------------------------------------------------");

            //if ( double.TryParse(x1,out double _X1) && 
            //     double.TryParse(x2, out double _X2) && 
            //     double.TryParse(x3, out double _X3) &&
            //     double.TryParse(y1, out double _Y1) && 
            //     double.TryParse(y2, out double _Y2) &&
            //     double.TryParse(y3, out double _Y3)
            //   )

            // {
            //     double result  = _X1 * (_Y2 - _Y3) + _X2 * (_Y1 - _Y2) + _X3 * (_Y3 - _Y1);

            //     if(result == 0)
            //         Console.WriteLine("Yes these points lie on a single straight line");

            //     else
            //         Console.WriteLine("These points do not lie on a single straight line");
            // }

            // else
            //     Console.WriteLine("Cannot Be Write (String OR Empty)");

            // Console.WriteLine("-------------------------------------------------------");

            #endregion


            #region Q => 18
            /* Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
                - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
                - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
                - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
                - If the worker takes more than 5 hours, they are required to leave the company. 
            To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
             */

            //Console.Write("Enter The Time It Took For The Worker To Complete The Task (Time => Hours): ");

            //string input = Console.ReadLine() ?? "";


            //if (double.TryParse(input, out double time))
            //{
            //    if(time >= 2 && time <= 3)
            //        Console.WriteLine("The Worker Is Highly Efficient.");

            //    else if(time > 3 && time <= 4)
            //        Console.WriteLine("The Worker Needs To Increase Their Speed.");

            //    else if (time > 4 && time <= 5)
            //        Console.WriteLine("The Worker Needs Training To Improve Their Speed.");

            //    else if (time > 5)
            //        Console.WriteLine("The Worker Is Required To Leave The Company.");

            //}
            //else
            //    Console.WriteLine("Cannot Be Write (String OR Empty)");

            #endregion

        }
    }
}