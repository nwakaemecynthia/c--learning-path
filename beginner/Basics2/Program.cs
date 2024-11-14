using System.Security.Cryptography.X509Certificates;
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

            /****************************************************************************
                                            ARRAYS  
            ****************************************************************************/
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

            for (int i = names.Length - 1; i >= 0; i--)
            {
                Console.WriteLine((i + 1) + " : " + names[i]);
            }

            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine((index + 1) + " => " + names[index]);
            }

            /****************************************************************************
                                              STRINGS  
              A string is a sequence of characters; e.g "HELLO WORLD" .
              How to create string                               
            ****************************************************************************/
            // 1.
            string firstName = "Cynthia";
            string lastName = "Nwakaeme";

            // 2. String Concatination
            string namez = firstName + " " + lastName;
            //A BETTER WAY TO CONTACTINATE STRINGS IS USING STRING FORMATS
            string fullName = string.Format("My name is {0} {1}", firstName, lastName);
            System.Console.WriteLine(fullName);

            // 3. Using String join
            var newNum = new int[3] { 3, 4, 5 };
            string list = string.Join(", ", newNum);
            String list2 = string.Join(", ", newNum);
            String list3 = string.Join(", ", names);
            //'string is a datatype', 'String is a class in c# available in the System class'. 
            // Both are the same but to use `String` ensure you import System; 'using System'.

            //NB Int32 === int ; so you can declare an integr using any of them. Same applies to other types.
            Console.WriteLine(list);
            Console.WriteLine(list2);
            Console.WriteLine(list3);

            //ACCESSING STRING ELEMENT
            char firstChar = firstName[0];
            Console.WriteLine(firstChar);

            //VERBATISM STRINGS: allows you to use special character without the need to use the escape sequence and escape sequesnse can be messy
            //To write "c:\projecct\project1\folder1" 

            string path = "c:\\projecct\\project1\\folder1";
            string verbatism = @"c:\projecct\project1\folder1";
            string path2 = "Hi Cynthia,\nLook into the following paths\nc:\\projecct\\project1\\folder1"; //Very unreadable
            string verbatism1 = @"Hi Cynthia,
            Look into the following paths
            c:\projecct\project1\folder1";

            System.Console.WriteLine(path);
            System.Console.WriteLine(verbatism);
            System.Console.WriteLine(path2);
            System.Console.WriteLine(verbatism1);


            /****************************************************************************
                                                         ENUMS  
                                                 
            ****************************************************************************/
            var method1 = ShippingMethod.RegularAirMail;
            var method2 = ShippingMethod.Experss;
            var method3 = ShippingMethod.RegisteredAirMail;
            System.Console.WriteLine(method1);
            System.Console.WriteLine(method2);
            System.Console.WriteLine(method3);

            //To show the numenric value of an enum
            System.Console.WriteLine((int)method3);

            //Say you get a number from an external source and you need to convert that number to its equivalent enum
            //say we receive a number 3 from an external source to convert it to the shipping method enum
            var methodId = 3;
            System.Console.WriteLine((ShippingMethod)methodId);

            //convert an enum value to a string
            System.Console.WriteLine(method2.ToString());
            System.Console.WriteLine(method2.ToString().ToUpper());

            //convert an string to an enum
            // var method4 = "Solé";
            // var newMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), method4);

            /****************************************************************************
            there are 2 main typpes from which all datatypes are created
            1) STRUCTURES (structs) - Primitive types and Custom Structures (structs)
                Structures are refered to as VALUE types
                    * Memeroy is allocated on stack
                    * Memory allocation is done authomatically
                    * Immediately removed from the stack when out of scope
            2) Classes (class) - Non Primitive types e.g Arrays, Strings and Custom Classes (class)
                CLasses are refered to as REFERENCE types
                    * You need to allocate the memory yourself usually using the `new` operator using `Heap`
                    * Memory allocation is done on Heap
                    * Garbage collection by CLR: When an object goes out of scope from the heap, 
                        it will continue to exist in the heap for a little while. 
                        However, Garbage collection, which is done by runtime or CLR takes care of removing classes from the heap.
                    * When coppied, their memory address is copied not the value, 
                        hence  mutation on a can affect b provided they refernce same heap address in memory
            ****************************************************************************/

            //PRACTICE
            var a = 10;
            var b = a;
            b++;
            System.Console.WriteLine(string.Format("a: {0}, b: {1}", a, b)); //result a: 10, b: 11

            var arr1 = new int[3] { 2, 3, 4 };
            var arr2 = arr1;
            arr2[0] = 7;
            System.Console.WriteLine("arr1At0: {0}, arr2At0: {1}", arr1[0], arr2[0]); //result arr1At0: 7, arr2At0: 7

            // 2.
            var demo = 1;
            Increment(demo);

            var person = new Person2() {Age = 20};
            MakeOld(person);
            System.Console.WriteLine(person.Age);

        }
        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person2 person)
        {
            person.Age += 10;
        }
    }
}