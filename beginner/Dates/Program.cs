namespace Dates{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dateTime  = new DateTime(2015, 1, 25);
            var now  = DateTime.Now;
            var today  = DateTime.Today;

            Console.WriteLine(dateTime);
            Console.WriteLine(now);
            Console.WriteLine(today);


            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);
            Console.WriteLine("Seconds: " + now.Second);

            //DATETIME OBJECT ARE IMMUTABLE; you can't change them but you can manupulate the data for logic purposes
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine("Tomorrow: " + tomorrow);
            Console.WriteLine("Yesterday: " + yesterday);

            //SOME DATETIME METHODS: Google `C# date time specifiers for more format methods`

            Console.WriteLine("Long Date: " + now.ToLongDateString());
            Console.WriteLine("Short Date: " + now.ToShortDateString());
            Console.WriteLine("Long Time: " + now.ToLongTimeString());
            Console.WriteLine("Short Time: " + now.ToShortTimeString());
            Console.WriteLine("Date and Time: " + now.ToString());
            Console.WriteLine("Date and Time with format: " + now.ToString("yy-MM-dd"));
            Console.WriteLine("Date and Time with format: " + now.ToString("dddd, yyyy-MMMM-dd HH:mm"));


            /* TIMESPAN: It is immutable but has some methods which can be used to maipulate it's value*/
            //Creating TimeSpan or Time Stamp
            var timeSpan = new TimeSpan(1, 2, 3);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine("TimeSpan: " + timeSpan);
            Console.WriteLine("TimeSpan 1: " + timeSpan1);
            Console.WriteLine("TimeSpan 2: " + timeSpan2);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(5);
            Console.WriteLine("Your time starts now: " + start + " and ends in 5 mins time: " + end);

            var duration = end - start;
            Console.WriteLine("Duration of this task: " + duration);

            //Properties
            System.Console.WriteLine("Minutes: " + timeSpan.Minutes);
            System.Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes); // 1 , 2, 3 i.e 1hour == 60min + 2min + 3s/60 = 0.5min = 62.05

            //Methods
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            Console.WriteLine("To String: " + timeSpan.ToString(""));
            Console.WriteLine("Converting from a String to TimeSpan (Parse): " + TimeSpan.Parse("01:02:59"));
        }
    }
}