namespace SessionOne
{
    /**********************************************************************************************
         ******************************* FIELDS ****************************
        A Field is like a variable we declare on a class level

        Initializing Fields
            //given
                public class Order
                {
                .....................
                }
                
            // INSTEAD OF INITIALIZING A FIELD LIKE THIS AND HAVING TO SET THE CONSTRUCTOR SO AS NOT TO RUN INTO ERROR
                public class Customer
                {
                    public List<Order> Orders;
                     public Customer()
                    {
                        Orders = new List<Order>();
                    }
                }

                //DO THIS INSTEAD
                    public class Customer
                    {
                        public List<Order> Orders = new List<Order>();
                    }
        Read-Only Fields
            Declaring a field with a `readonly` modifier to make sure that your field is only assigned ones.
            by being initialized with any of the methods above. 
            Creating a field as using readonly modifier helps to create safety in our application to improve robustness
              
              //EXAMPLE
                public class Customer
                {
                    readonly List<Order> Orders = new List<Order>();
                }

    ***********************************************************************************************/
    public class Order2
    {
    }

    class Customer2
    {
        public int Id;
        public string Name;

        public readonly List<Order2> Orders = new List<Order2>();

        public Customer2(int id)
        {
            this.Id = id;
        }

        public Customer2(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            // this.Orders = new List<Order2>();
        }
    }
    /**********************************************************************************************
         ******************************* METHODS ****************************
         An Object Initializer is simply a syntax for quickly initializing an object 
         without the need to call one of the constructors.

         ****************** Signature of Methods
            The signature method consist of its name and the number and the type of its parameter
         ****************** Method Overloading
            This implies having a method with the same name but different signatures.
            Example
                public class Point
                {
                    public void Move(int x, int y){}
                    public void Move(Point newLocation){}
                    public void Move(Point newLocation, int speed){}
                }
         ****************** Params Modifier
         ****************** Ref Modifier //!!!!!!!!XXXXXXX BAD XXXXXXXXXX!!!!!!!!!!
         ****************** Out Modifier //!!!!!!!!XXXXXXX BAD XXXXXXXXXX!!!!!!!!!!

    ***********************************************************************************************/
    public class Calculator
    {
        // public int Add(int n1, int n2) { }
        // public int Add(int n1, int n2, int n3) { }
        // public int Add(int n1, int n2, int n3, int n4) { }
        //This is not sustainable as a user might send multiple numbers and it reduces the efieicncy of your program.

        //DO THIS INSTEAD
        // public int Add(int[] numbers){}


        //OR USE THIS, PARAMS MODIFIER
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }
    }

    /******************* Ref Modifier ********************/

    // public class MyClass
    // {
    //     //THIS DOESN"T ALWAYS BEHAVE AS IT SHOULD 
    //     public void MyMethod(int a)
    //     {
    //         a += 2;
    //         System.Console.WriteLine(a);
    //     }
    // }

    public class MyClass
    {
        //THIS GIVES 
        public void MyMethod(ref int a)
        {
            a += 2;
            System.Console.WriteLine("OK, I DON'T GET THIS " + a);
        }
    }

    /******************* Out Modifier ********************/
    // ALways note that ref and out modifier are similar as they have to be passed in the params and argument
    // OUT MODIFIERS returns a value to the user even when the method return type is `void`
    public class MyClass2
    {
        //THIS GIVES 
        public void MyMethod(out int result)
        {
            result = 1;
            System.Console.WriteLine("OK, I DON'T GET THIS TOO: " + result);
        }
    }

    //PRACTICAL
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y) //CONSTRUCTOR
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(int x, int y) //METHOD
        {
            this.X = x;
            this.Y = y;
        }
        public void Move(Point newLocation)
        {
            // this.X = newLocation.X;
            // this.Y = newLocation.Y;

            //OR
            //However, you need to validate the params `newlocation` as if you pass null the program throws an exception (Crashes)
            if (newLocation == null) //THIS IS AN EXAMPLE OF DEFENSIVE PROGRAMMING
            {
                throw new ArgumentNullException("newLocation cannot be null");
            }
            Move(newLocation.X, newLocation.Y);
        }
    }
}