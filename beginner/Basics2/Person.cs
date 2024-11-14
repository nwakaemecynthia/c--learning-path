// Define the Person class outside of the Main method

namespace Basics2 // Replace "Basics2" with your actual project namespace if different
{
    public class Person
    {
        // public is an ACCESS MODIFIER: This determines who can access the class
        // class: is a keyword and a blueprint used in creating Object
        // Person is an IDENTIFIER
        public string? FirstName;
        public string? LastName;
        // public string Name = string.Empty; SAME AS ABOVE

        public void IntroduceMe()
        {
            Console.WriteLine("Hi, my name is " + FirstName + " " + LastName);
        }
    }
    public class Person2{
        public int? Age;
    }
}