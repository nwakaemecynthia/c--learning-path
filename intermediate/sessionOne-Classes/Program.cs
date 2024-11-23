namespace SessionOne
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["ACCESS_TOKEN"] = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ.SflKxwRJSMeKKF2QT4fwpMeJf36POk6yJV_adQssw5c";
            cookie["USERTYPE"] = "ADMIN";
            System.Console.WriteLine("The saved TOKEN " + cookie["ACCESS_TOKEN"]);
            System.Console.WriteLine("Your account access type is: " + cookie["USERTYPE"]);
        }

        //COPY AND PASTE CODE SNIPPET TO UNDERSTAND LEARNING PATH
        static void UseClasses()
        {
            /**************************************************************************************
                    ******************************** CLASSES **************************
            ***************************************************************************************/
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

        static void UseObjInitilizer()
        {

            /**************************************************************************************
                   *************************** OBJECT INITIALIZER **************************
            ***************************************************************************************/
            //WE CAN SIMPLY INITIALIZE A PERSON CONSTRUCTOR LIKE THIS WITHOUT DECLARING ANY CONSTRUCTOR
            var person2 = new Person2
            {
                Id = 2,
                FirstName = "firstName",
            };


            //REF MODIFIER
            var myClass = new MyClass();
            var myClass2 = new MyClass2();
            var a = 1;
            int b;
            myClass.MyMethod(ref a);
            myClass2.MyMethod(out b);

            //PRACTICAL
            // var number = int.Parse("abc");
            int num;
            var result = int.TryParse("abc", out num); //TryParse does not throw an exception unlike Parse method. If you must use a Parse method, ensure it is in a try,catch block
            if (result)
            {
                System.Console.WriteLine(result);
            }
            else
            {
                System.Console.WriteLine("Conversion Failed");
            }
        }

        static void UseConstrustor()
        {
            /**************************************************************************************
                    ******************************** CONSTRUCTORS **************************
            ***************************************************************************************/
            var customer = new Customer(2, "John");
            System.Console.WriteLine(customer.Name);
            System.Console.WriteLine(customer.Id);

            var order = new Order();
            customer.Orders.Add(order);
        }

        static void UseParamsModify()
        {
            /**************************************************************************************
            *************************** METHODS AND FEILDS **************************
            ***************************************************************************************/
            var calculator = new Calculator();
            var result = calculator.Add(new int[] { 4, 8, 9, 5, 1, 6, 4, 8 }); //THIS WILL ALSO WORK AS PARAMS INSTANCE
            var result2 = calculator.Add(4, 8, 9, 5, 1, 6, 4, 8); //PARAMS MODIFIER INSTANCE
            System.Console.WriteLine(result);
            System.Console.WriteLine(result2);
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                System.Console.WriteLine("Point is at: ({0}, {1})", point.X, point.Y);

                point.Move(new Point(40, 60));
                System.Console.WriteLine("Point is at: ({0}, {1})", point.X, point.Y);

                point.Move(100, 400);
                System.Console.WriteLine("Point is at: ({0}, {1})", point.X, point.Y);

                point.Move(null);
                System.Console.WriteLine("Point is at: ({0}, {1})", point.X, point.Y);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("An unexpected error occured.");
            }
        }

        static void UseClassAnatomy()
        {
            var customer = new Customer2(2);
            customer.Orders.Add(new Order2());
            customer.Orders.Add(new Order2());

            customer.Promote();
            System.Console.WriteLine(customer.Orders.Count);
        }
    
        static void UseEncapsulation(){
            var person = new PersonEncap();
            person.SetBirthDate(new DateTime(1993, 10, 25));
            System.Console.WriteLine(person.GetBirthDate());
        }

        static void UseCorrectEncapsulation(){
            var person = new PersonMain(new DateTime(1993, 10, 25));
            System.Console.WriteLine("My age is: " + person.Age);
        }
    }
}