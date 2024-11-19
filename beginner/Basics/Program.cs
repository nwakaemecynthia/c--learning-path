/*
    dotnet new console -o MyProjectName

    console specifies a console application template.
    -o MyProjectName creates a new folder named MyProjectName for the project.

    Common template options:
    Console app: dotnet new console
    Web app: dotnet new webapp
    Class library: dotnet new classlib
    API: dotnet new webapi
    Build and Run: Build the project to make sure everything is set up correctly:
    dotnet build
    Then, run it with:
    dotnet run or dotnet run --launch-profile https (to run as https)
*/

namespace BasicsProgram
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            checked
            {
                int number = 254;
                number++; //this is the same as: number = number + 1; 
                Console.WriteLine(number);
            }

            float totalPrice = 20.56f;
            char character = 'A'; //if you declare char type using doublequote, e.g "A", you run into an error because char and string are different datatypes
            string myName = "Cynthia Nwakaeme"; //strings are declared with ony doublequote
            bool isValid = false;
            Console.WriteLine(character + totalPrice);
            Console.WriteLine(character + " " + myName);
            Console.WriteLine(myName + " " + isValid);
            Console.WriteLine(isValid);

            // when declaring a variable in c#, you can simplily type var and initialize the data without indicating the type and C#  compiler will automatically detect the type for you
            var number2 = 254;
            Console.WriteLine(number2);

            //FORMAT STRING
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", short.MinValue, short.MaxValue);
            Console.WriteLine("{0} {1}", decimal.MinValue, decimal.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            Console.WriteLine("{0} {1}", Int16.MinValue, Int16.MaxValue); // same as short, read your notes to understand

            //CONSTANTS
            const float pi = 3.14f;
            Console.WriteLine(pi);

            //TYPE CONVERSION
            //1) IMPLICIT TYPE CONVERSION
            byte b = 254;
            int i = b;

            //2) EXPLICIT TYPE CONVERSION: This is prone to data loss especially if the data is not well within the range of its datatype
            int e = 25;
            // byte y = e;

            //the above has an error on e so to correct this error, you will need to CAST or perform an EXPLICIT TYPE CONVERSION on e
            byte z = (byte)e;

            //e.g 2
            float f = 1.0f;
            int u = (int)f;

            //3) NON COMPARTIBLE TYPE CONVERSION
            string s = "1";
            // int c = (int)s; //WON'T COMPLIE

            //to convert the above we will use, CONVERT CLASS or PARSE METHOD to convert the classes
            string str = "1";
            Console.WriteLine(str);
            int con = Convert.ToInt32(str); //CONVERT CLASS
            int con2 = int.Parse(str); //PARSE METHOD
            Console.WriteLine(con2);

            /*
             SOME CONVERT METHOD
                ToByte() => byte
                ToInt16() => short
                ToInt32() => int
                ToInt64() => long
            */

        }
    }
}



// command dot (.); helps you convert this file to a class
// press `cw` as a shortcut to get the snippet for `Console.WriteLine()`

