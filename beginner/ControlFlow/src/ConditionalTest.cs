namespace ControlFlow
{
    public class ConditionalTest
    {
        /****************************************************************************
            1- Write a program and ask the user to enter a number. 
            The number should be between 1 to 10. If the user enters a valid number,
            display "Valid" on the console. Otherwise, display "Invalid". 
            (This logic is used a lot in applications where values entered into input boxes need to be validated.)
        ****************************************************************************/
        public void IsValidNumber()
        {
            Console.Write("Enter any number: ");
            int num = int.Parse(Console.ReadLine());
            string result = (num > 0 && num <= 10) ? "Valid" : "Invalid";
            System.Console.WriteLine(result);
        }

        /****************************************************************************
            2- Write a program which takes two numbers from the console and displays the maximum of the two.
        ****************************************************************************/
        public void MaxNumber()
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            string result = (num1 > num2) ? num1.ToString() : num2.ToString();
            System.Console.WriteLine(result);
        }

        /****************************************************************************
            3- Write a program and ask the user to enter the width and height of an image. 
            Then tell if the image is landscape or portrait.
         ****************************************************************************/
        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }
        public void ImageOrentation()
        {
            Console.Write("Enter width of image: ");
            int width = int.Parse(Console.ReadLine());
            Console.Write("Enter height of image: ");
            int height = int.Parse(Console.ReadLine());
            var orientation = (width > height) ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            System.Console.WriteLine(orientation);
        }

        /****************************************************************************
            4- Your job is to write a program for a speed camera. 
            For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
                Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
                If the user enters a value less than the speed limit, program should display Ok on the console. 
                If the value is above the speed limit, the program should calculate the number of demerit points. 
                For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console. 
                If the number of demerit points is above 12, the program should display License Suspended.
         ****************************************************************************/
        public void SpeedCamera()
        {
            // // Ask user to enter the speed limit
            // Console.Write("Enter the speed limit: ");

            // string? speedLimitInput = Console.ReadLine();
            // if (!int.TryParse(speedLimitInput, out int speedLimit))
            // {
            //     Console.WriteLine("Invalid speed limit input.");
            //     return;
            // }

            // // Ask user to enter the car's speed
            // Console.Write("Enter the speed of the car: ");

            // string? carSpeedInput = Console.ReadLine();
            // if (!int.TryParse(carSpeedInput, out int carSpeed))
            // {
            //     Console.WriteLine("Invalid car speed input.");
            //     return;
            // }

            // if (carSpeed <= speedLimit)
            // {
            //     Console.WriteLine("Ok");
            // }
            // else
            // {
            //     // Calculate demerit points
            //     int demeritPoints = (carSpeed - speedLimit) / 5;

            //     Console.WriteLine("Demerit Points: " + demeritPoints);

            //     // Check if demerit points exceed 12
            //     if (demeritPoints > 12)
            //     {
            //         Console.WriteLine("License Suspended");
            //     }
            // }
            Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;
                var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Demerit points: " + demeritPoints);
            }
        }
    }
}