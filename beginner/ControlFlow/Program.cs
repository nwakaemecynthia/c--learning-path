namespace ControlFlow
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /**************************************************************************************************************
                                     **********CONDITIONAL STATEMENTS**********
            **************************************************************************************************************/
            /****************************************************************************
                **IF STATEMENT**
            ****************************************************************************/
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                System.Console.WriteLine("It's Morning!");
            }
            else if (hour >= 12 && hour < 18)
            {
                System.Console.WriteLine("It's Afternoon!");
            }
            else if (hour >= 18 && hour <= 24)
            {
                System.Console.WriteLine("It's Evening!");
            }
            else
            {
                System.Console.WriteLine("This is beyound the time range of 24 hours!");
            }

            /****************************************************************************
                **SWITCH-CASE STATEMENT**
            ****************************************************************************/
            var currentSeason = Season.Spring;

            switch (currentSeason)
            {
                case Season.Autumn:
                    System.Console.WriteLine("It's autumn and a beautiful season");
                    break;
                case Season.Summer:
                case Season.Spring:
                    System.Console.WriteLine("It's a perfect time to go to the beach");
                    break;
                default:
                    System.Console.WriteLine("I don't understad the season");
                    break;
            }

            /****************************************************************************
                **CONDITIONAL / TERNARY OPERATOR**
            ****************************************************************************/
            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            System.Console.WriteLine(price);

            /*EXERCISE*/
            // ConditionalTest conditionals = new ConditionalTest();
            // conditionals.IsValidNumber();
            // conditionals.IsValidNumber();
            // conditionals.MaxNumber();
            // conditionals.ImageOrentation();
            // conditionals.SpeedCamera();

            /**************************************************************************************************************
                                        **********ITERATION STATEMENTS**********
            **************************************************************************************************************/
            /****************************************************************************
                **FOR LOOPS**
            ****************************************************************************/
            for (byte i = 0; i < 10; i++)
            {
                //where 
                // byte i = 0 is the INITILIZATION CLAUSE;
                // i < 10 is the CONDITION CLAUSE
                // i++ is the ITERATION CLAUSE
                if (i != 0 && i % 2 == 0)
                {
                    Console.WriteLine(string.Format("{0} is an even number", i));
                }
            }

            //reverse for loop
            for (byte i = 10; i >= 1; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(string.Format("{0} is an odd number", i));
                }
            }

            var name = "Cynthia Berry";
            for (int i = 0; i < name.Length; i++)
            {
                System.Console.WriteLine(name[i]);
            }

            /****************************************************************************
                **FOR-EACH LOOPS**
                this is used to iterate over ENUMERABLE OBJECT.
                An enumerable object are anything that has some sort of list or array nature. (strings, array)
            ****************************************************************************/
            //List can be written as
            var collection = new List<string>() { "Bags", "Shoes", "Clothes", "Make-up Kit" };
            _ = new string[4] { "Bags", "Shoes", "Clothes", "Make-up Kit" }; // the _ as variabe represent discard (since it is not in use).

            foreach (var item in collection)
            {
                //where
                //item: local or temporary variable
                // collection: The list or object we are iterating
                System.Console.WriteLine(item);
            }
            foreach (var @char in name)
            {
                System.Console.WriteLine(@char);
            }
            /****************************************************************************
                **WHILE LOOPS**
            ****************************************************************************/
            var j = -2;
            var num = 0;

            while (j < 10)
            {
                j++;
                System.Console.WriteLine(j);
            }
            while (num <= 10)
            {
                if (num != 0 && num % 2 == 0) Console.WriteLine(string.Format("{0} is an even number", num));
                num++;
            }

            while (true)
            {
                Console.Write("Type your name: ");
                var userInput = Console.ReadLine();
                // if (userInput == null || String.IsNullOrWhiteSpace(userInput)) 
                //     break; //note the condition means the same thing so use either of them in real life and not both
                if (!(userInput == null || String.IsNullOrWhiteSpace(userInput)))
                {
                    System.Console.WriteLine("@Echo: ", userInput); //note the condition means the same thing so use either of them in real life and not both
                    continue;
                }


                break;
            }
            /****************************************************************************
                **DO-WHILE LOOPS**
            ****************************************************************************/
            do
            {
                if (num % 2 != 0) Console.WriteLine(string.Format("{0} is an odd number", num));
                num++;
            } while (num < 10);

            /*EXERCISE*/
            var iterator = new IterationTest();
            // iterator.IsDivisibleByThree();
            // iterator.randomUserInput();
            iterator.numberFactorial();
            // iterator.ImageOrentation();
            // iterator.SpeedCamera();



            /*
                NOTE
                break: Jumps out of a loop.
                continue: Jumps to the next iteration.
            */

            /**************************************************************************************************************
                                               **********RANDOM CLASS**********
            **************************************************************************************************************/

            // var random = new Random();
            // for (int i = 0; i < 10; i++)
            // {
            //     System.Console.WriteLine(random.Next());
            //     System.Console.WriteLine(random.Next(1, 10));
            // }

            // //GENERATE RANDOM PASSWORD
            // const int passwordLength = 10;
            // for (int i = 0; i < passwordLength; i++)
            // {
            //     System.Console.Write((char)random.Next(97, 122));
            // }
            // System.Console.WriteLine();

            // //IMPROVE THE PASSWORD GENERATOR same as the first password generator
            // var buffer =  new char[passwordLength];
            // for (int i = 0; i < passwordLength; i++)
            // {
            //     buffer[i] = ((char)('a' + random.Next(0, 26)));
            // }

            // var password = new string(buffer);
            // System.Console.WriteLine("NEW PASSWORD IS: {0}", password);
        }
    }
}