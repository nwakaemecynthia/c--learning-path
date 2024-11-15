namespace ControlFlow
{
    public class IterationTest
    {
        /****************************************************************************
            1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
             Display the count on the console.
        ****************************************************************************/
        public static void IsDivisibleByThree()
        {
            var count = 0;
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0) count++;
            }
            System.Console.WriteLine("{0} numbers ar divisible by 3", count);
        }

        /****************************************************************************
           2- Write a program and continuously ask the user to enter a number or "ok" to exit.
            Calculate the sum of all the previously entered numbers and display it on the console.
        ****************************************************************************/
        public static void RandomUserInput()
        {

            while (true)
            {
                Console.Write("enter random number or type \'OK\' to exit: ");
                var userInput = Console.ReadLine();

                if (userInput.Equals("ok", StringComparison.CurrentCultureIgnoreCase))
                {
                    break;
                }
                if (!int.TryParse(userInput, out int result))
                {
                    System.Console.WriteLine("{0}, is not a valid number. Please enter a valid integer", result);
                    continue;
                }

            }

        }

        /****************************************************************************
            3- Write a program and ask the user to enter a number. 
            Compute the factorial of the number and print it on the console. 
            For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        ****************************************************************************/
        public static void Factorial()
        {
            while (true)
            {
                Console.Write("find the factorial of: ");
                var userInput = Console.ReadLine();
                if (!int.TryParse(userInput, out int result))
                {
                    System.Console.WriteLine("{0}, is not a valid number. Please enter a valid integer", result);
                    continue;
                }

                var factorial = 1;
                for (int i = 1; i <= int.Parse(userInput); i++)
                {
                    factorial *= i;
                }

                System.Console.WriteLine("the factorial of {0} is: {1}", userInput, factorial);
                break;
            }
        }

        /****************************************************************************
            4- Write a program that picks a random number between 1 and 10. 
            Give the user 4 chances to guess the number. 
            If the user guesses the number, display “You won"; otherwise, display “You lost".
            (To make sure the program is behaving correctly, you can display the secret number on the console first.)
        ****************************************************************************/
        public static void NumberGuess()
        {
            var random = new Random();
            var randomNumber = random.Next(1, 10);
            System.Console.WriteLine("THE SYSTEM GENERATED GUESS IS '{0}', THIS IS FOR TEST PURPOSE", randomNumber);
            var counter = 0;

            while (counter < 4)
            {
                Console.Write("Guess a random number between '1 to 10': ");
                var userInput = Console.ReadLine();



                if (!int.TryParse(userInput, out int result))
                {
                    System.Console.WriteLine("{0}, is not a valid number. Please enter a valid integer", result);
                }
                else
                {
                    if (int.Parse(userInput) == randomNumber)
                    {
                        System.Console.WriteLine("You won!!!!");
                        break;
                    }
                    else
                    {
                        if (counter == 3)
                        {
                            System.Console.WriteLine("You lost!!!");
                            break;
                        }
                        else System.Console.WriteLine("Wrong Guess, try ");
                    }

                }
                counter++;
                continue;
            }

        }

        /****************************************************************************
            5- Write a program and ask the user to enter a series of numbers separated by comma.
             Find the maximum of the numbers and display it on the console. 
             For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
        ****************************************************************************/
        public static void MaxNumber()
        {
            Console.Write("Enter a series of numbers separated by commas: ");
            string? input = Console.ReadLine();

            // Check if the input is null or empty
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid input. Please enter some numbers.");
                return;
            }

            try
            {
                /* // Split the input by commas and convert each part to an integer
                 int maxNumber = input.Split(',')
                                      .Select(num => int.Parse(num.Trim()))
                                      .Max();

                 // Display the maximum number
                 Console.WriteLine("The maximum number is: " + maxNumber);
                 */
                 
                // Split the input into an array of strings
                string[] numberStrings = input.Split(',');

                // Initialize a variable to track the maximum number
                int maxNumber = int.MinValue;

                // Iterate through each number in the array
                foreach (string numStr in numberStrings)
                {
                    int number = int.Parse(numStr.Trim()); // Convert to an integer
                    if (number > maxNumber) // Check if the current number is greater than maxNumber
                    {
                        maxNumber = number; // Update maxNumber
                    }
                }

                // Display the maximum number
                Console.WriteLine("The maximum number is: " + maxNumber);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please ensure all values are integers.");
            }
        }
    }
}