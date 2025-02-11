namespace SessionOne
{
    /**********************************************************************************************
            ******************************* OBJECT INITIALIZER ****************************
            An Object Initializer is simply a syntax for quickly initializing an object 
            without the need to call one of the constructors.

            ****************** Why do you need it?
            It is needed to avoid creating multiple constructors
           
    ***********************************************************************************************/
    // public class ObjectInitalizer
    // {

    // }
    public class Person2
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public DateTime BirthDate;

        //INDTEAD OF HAVING MULTIPLE CONSTRUCTORS LIKE THIS
        // public Person(int id){}
        // public Person(int id, string firstName){}
        // public Person(int id, string firstName, string lastName){}
        // public Person(int id, DateTime dateTime){}
    }
}
