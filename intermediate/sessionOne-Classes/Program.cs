namespace SessionOne
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //  var person = new Person { FirstName = "Cynthia", LastName = "Nwakaeme", Age = 31};
            // OR
            // Person person = new Person;

            // var person = new Person();
            // person.FirstName = "Cynthia";
            // person.LastName = "Nwakaeme";
            // person.Age = 51;

            var person = new Person { FirstName = "Cynthia", LastName = "Nwakaeme", Age = 31 };

            person.IntroduceMe();
            person.IntroduceMe("Ginika");

            var newCommer = person.Parse("Berry Blings", 27);
            newCommer.IntroduceMe("Team Chevron");

        }
    }
}
