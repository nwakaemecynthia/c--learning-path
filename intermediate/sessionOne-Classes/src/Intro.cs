namespace SessionOne
{
    /*********************************************************************************
               ************** WHAT IS A CLASSE
                  This is a building block of an application.

               ************** ANATOMY OF A CLASS
                  1) Data: (repersented by feilds or properties of a class)
                  2) Behaviour: (repersented by methods/functions of a class)

               ************** WHAT IS AN OBJECT
                  An object is an instance of a class that resides in memory.
                 

               ************** CLASS MEMBERS 
                In C# we have 2 types of class members
                    1) Instance: These are accessible from an OBJECT.
                            var person = new Person();
                            person.FirstName = "Cynthia";
                    2) Static: These are accessible from a CLASS.
                            Console.WriteLine();
                        Why use static members; They are used to create one and only one concept of that instance into memory.
                            a) To represent oncepts of Singleton
                            b) DateTime.Now;
                            c) Console.WriteLine();
                        To declare a member as static we use the `static` keyword:
                            public static int PeopleCout = 0;
                        You can use `static` on any member of a class be it the properties or methods.
          *********************************************************************************/
    //Declaring a class
    public class Person
    {
        public string? FirstName;
        public string? LastName;
        public byte? Age;
        public void IntroduceMe(string to = "Dear")
        {
            System.Console.WriteLine("Hi {0}; My name is {1} {2} and I am {3} years old", to, FirstName, LastName, Age);
        }

        public Person Parse(string fullName, byte age)
        {
            var person = new Person();
            var fullNameArr = fullName.Split(' ');
            person.Age = age;
            person.FirstName = fullNameArr[0];
            person.LastName = fullNameArr[1];

            return person;
        }
    }
}