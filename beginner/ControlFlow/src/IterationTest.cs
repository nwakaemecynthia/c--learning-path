namespace ControlFlow
{
    public class IterationTest
    {
        /****************************************************************************
            1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
             Display the count on the console.
        ****************************************************************************/
        public void IsDivisibleByThree()
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
        public void randomUserInput()
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
        public void numberFactorial()
        {
            while (true)
            {
                Console.Write("find the factorial of, ");
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
    }
}