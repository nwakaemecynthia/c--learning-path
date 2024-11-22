using System.Collections.Generic;

namespace SessionOne
{
    /**************************************************************************************
              *************************************** CONSTRUCTORS ****************************
              A constructor is a method that is called when an instance of a class is created.
                  *************************************************************************

              Why do you need a constructor?
              The Intention is to put an object in an early state.
              i.e to initialise some of the feilds in the class

              How to declare a constructor?
              e.g 
              public class Customer
              {
                  public Customer() {...} // CONSTUCTOR. 
              }

              A CONSTRUCTOR HAS THE SAME NAME AS THE CLASS AND THIS IS A REQUIRMENT.
              A CONSTRUCTOR DOES NOT HAVE A RETURN TYPE.

              CONSTRUCTOR OVERLOADING
              Overloading means having a method by the same name but differnt signatures.
              A signature is what uniquely identifies a method that has its return type, its name and its types and numbers of its parameters.
              We cannot have more than one constructor with the exact same signature.
              e.g
                public class Customer
              {
                  public Customer() {...} // CONSTUCTOR.
                  public Customer(string name) {...} // CONSTUCTOR. 
                  public Customer(int id, string name) {...} // CONSTUCTOR. 
              }

              Why do we need to overload constructors?
              The reason is to make initialization of the class easier; 
              so we may use any conctructor that best suit our application current need/use case.

          ****************************************************************************************/
    public class Customer
    {
        //CONCEPT OF CONSTRUCTOR OVERLOADING
        public int? Id; //In real world applications, we do not create properties with `public` access modifiers
        public string? Name;
        public List<Order> Orders;

        public Customer()
        {
            //If you dont add this , you will get a null reference exception
            // The reason is because since you didnt initialize the order, you can't manipulate a  List of null.
            Orders = new List<Order>();
        }
        public Customer(string name) 
            : this() //Instead of duplicating the order feom the default constructor (the one with no params), we use this()
        {
            this.Name = name; // `THIS` is a keyword that references the current object.
        }

        public Customer(int id) 
            : this() //Instead of duplicating the order feom the default constructor (the one with no params), we use this()

        {
            this.Id = id;
        }
        public Customer(int id, string name) 
            : this(id) //Also, this calls the constructor that takes ID params which inturn has called the default constructor to take up Orders initializaed
            // !!!!!!!!!!!!!!!!!!THIS IS NOT CONSIDERED A GOOD PRACTICE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        {
            this.Id = id;
            this.Name = name;
        }
    }

    public class Order
    {
        //CONCEPT OF AVOIDING CONSTRUCTOR OVERLOADING

    }
}