namespace Mohamed_Abdullah_sun_wed_8pm_C_05
{

    #region Q => 1 [ enum => WeekDays ]
    //enum WeekDays
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday

    //} 
    #endregion


    #region Q => 2 [ enum => Season ]
    //enum Season
    //{
    //    Spring,
    //    Summer,
    //    Autumn,
    //    Winter,
    //} 
    #endregion


    #region Q => 3 [enum => Permmision]
    //[Flags]
    //enum Permissions : byte
    //{
    //    write = 8 ,
    //    read = 4 , 
    //    execute = 2 , 
    //    delete = 1,
    //}
    #endregion


    #region Q => 4 [enum => Colors]
    //enum Colors : byte
    //{
    //    red , 
    //    green ,
    //    blue ,
    //}
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q => 1
            /* 1 - Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
                Then, write a C# program that prints out all the days of the week using this enum.
            */

            //Console.WriteLine("WeekDays:");
            //int i = 1;
            //foreach (var day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine($" {i++} - {day}");
            //} 
            #endregion


            #region Q => 2 
            /*
             *  Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
             *  Write a C# program that takes a season name as input from the user and displays the corresponding month
             *  range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
             */


            //Console.Write("please enter season name choose => (spring, summer, autumn, winter) : ");

            //string inputSeason = Console.ReadLine() ?? "";

            //string rangeSeasons = inputSeason.ToLower()  switch
            //{
            //    "spring" => "March To May",
            //    "summer" => "June To August",
            //    "autumn" => "September To November",
            //    "winter" => "December To February",
            //    _        => $"Season Not Found With This Name ( {inputSeason} )"
            //};

            //Console.WriteLine( Enum.TryParse(inputSeason , true , out Season season) ? $"the months for {season} = {rangeSeasons}" : $"{rangeSeasons}" );
            #endregion


            #region Q => 3 
            /*
               3- Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.
                Create Variable from previous Enum to Add and Remove Permission from variable, 
                check if specific Permission is existed inside variable
             */

            //Permissions myP = Permissions.read;
            //Console.WriteLine("Display Permissions");
            //Console.WriteLine($"{myP}\n"); // read

            ////Add Permission => write
            //myP ^= Permissions.write;

            //Console.WriteLine("Add Permissions");
            //Console.WriteLine($"{myP}\n"); // read , write


            ////check Permission 
            //if ((myP & Permissions.read) ==  Permissions.read)

            //    Console.WriteLine($"Found Permission : {Permissions.read}\n"); // success
            //else
            //    Console.WriteLine("Not Found Permission\n");

            ////Remove Permission
            //myP ^= Permissions.read;

            //Console.WriteLine("Remove Permissions");
            //Console.WriteLine($"{myP}\n"); // write

            #endregion


            #region Q => 4 
            /*
              4. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
                 * Write a C# program that takes a color name as input from the user and displays a message 
                 * indicating whether the input color is a primary color or not.
             */

            //Console.Write("Enter Please Color Name : ");
            //string? inputColor = Console.ReadLine() ;
            //if(inputColor?.Length > 0)

            //    if (Enum.TryParse(inputColor.ToLower(),out Colors color))

            //        Console.WriteLine($"{color} => a Primary Color");

            //    else
            //        Console.WriteLine($"{inputColor} => Not a Primary Color ");
            //else
            //    Console.WriteLine("Must Be Enter Please Color Name");
            #endregion
        }
    }
}
