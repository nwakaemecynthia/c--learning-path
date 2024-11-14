using Basics2.Math; //Importing namespace that is differnt from the main namespace

/*************************************
    `namespace` removes the hassel of importing differnt classes using the `using` keyword hence it is a normal convention to use same `namespae` across your project
    If you dont want to use the same namespace for obvious reason of seperation of concerns, you can group classes into folders,
        have the same namespace name across grouped classes in a folder, then import using the `using` keyword
*****************************************/

/**************************************************
    NB: YOU CANNOT DEFINE CLASSES WITHIN THE `Main` METHOD IN C# (IT IS NOT ALLOWED).

   NON PRIMITIVE DATA TYPES
   1) CLASS: This is a type or a blueprint used in creating an object.
   An Object is an instance of a class.
   
**************************************************/

namespace Basics2 // Use the same namespace as Person.cs and Calculator.cs
{
    public class Car
    {
        public string? Make;
        public string? Model;
        public string? Color;
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Try-Catch Block
            try
            {
                var str = "1234";
                byte number = Convert.ToByte(str);
                Console.WriteLine(number);

                string @string = "true";
                bool isData = Convert.ToBoolean(@string);
                Console.WriteLine(isData);
            }
            catch (Exception)
            {
                Console.WriteLine("Number cannot be converted to a byte as it exceeds the range");
            }

            //EXAMPLE 1
            // Creating an Object
            var cynthia = new Person();
            cynthia.FirstName = "Cynthia";
            cynthia.LastName = "Nwakaeme";
            cynthia.IntroduceMe();


            //EXAMPLE 2
            /*
                HOW TO ACCESS THE CLASS WHEN STATIC MODIFIER IS ADDED TO THE CLASS. 
                    STATIC MODIFIER IS USED TO CREATE A CONCEPTE WHERE ONE AND ONLY ONE
                     INSTANCE OF THE CLASSES WILL BE NEEDED, THERE BY CREATING ONLY ONE REFERENCE IN MEMORY, WHICH IS THE CLASS ITSELF AND NOT AN OBJECT
                You do not have to create an Object like the commented one above when `Static` modifier is added to the class
            */
            // You can also create a Calculator object and use it if needed
            // Calculator calc = new Calculator();
            // Console.WriteLine("Sum: " + calc.Add(5, 3));
            int result = Calculator.Add(28);
            int result2 = Calculator.Add(28, 10);
            System.Console.WriteLine(result);

            //EXAMPLE 3
            var car = new Car();
            car.Make = "Toyota";
            car.Model = "Camry";
            car.Color = "Red";

            Console.WriteLine(car.Color);

            //ARRAYS
            /*
                Definition; An array is a data structure to store a collection of variables of the same type.
            */
            //instead of this


            //Do this (Go to your note to read up on this)
            int[] numbers = new int[3];

            numbers[0] = 2;
            numbers[1] = 3;
            numbers[2] = 5;

            Console.WriteLine(numbers);
            // Optional: Print array elements to verify
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            //or 

            int[] numberz = new int[3] { 1, 2, 3 };
            Console.WriteLine(numberz[1]);

            //THE ABOVE ARRAY IS SUMMERIZED IN THE CLASS ARRAYS, BY DYNAMICALLY CREATING AN ARRAY WHEN SIZE AND THE ARRAY IS GIVEN 
            var array = new Arrays();
            array.CreateArray(5, new int[] { 1, 2, 3 });

            //EXAMPLE 2
            var names = new string[6] { "Tina", "Cynthia", "Jennifer", "Juliet", "Vera", "Stella" };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            for (int i = names.Length - 1; i >= 0 ; i--)
            {
                Console.WriteLine((i + 1) + " : " + names[i]);
            }

            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine((index + 1) + " => " + names[index]);
            }
        }
    }
}