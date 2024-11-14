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
            int result = Calculator.Add(28, 10);
            System.Console.WriteLine(result);

            //EXAMPLE 3
            var car = new Car();
            car.Make = "Toyota";
            car.Model = "Camry";
            car.Color = "Red";

            Console.WriteLine(car.Color);
        }
    }
}