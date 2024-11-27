using PublicAccessModifier;

namespace SessionTwoB
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /****************************************************************************************************************************
                ************************* ACCESS MODIFIERS *************************
                Access modifiers are used to control the visibilty of a class, field, methods or function.

                ************************* Why access modifiers are important
                ************************* Black box metaphor
                    This metaphor is used in designing concept in OOP. It helps you imagin a closed black box where one can't see what is 
                    inside. This analogy helps you understand the concept of isolating changes so when building, 
                    the more a class reveals its internals or its implementation the more risky it is. 
                    (Always limit the visibilty of a class from the outside therefore, making the cclass look like a black box).

                    e.g
                    Look at a DVD player, you cant see the chips and wires from the outside, the outside view can be refered to as its
                    PUBLIC INTERFACE

                ************************* C# access modifiers
                    ****** TYPES OF ACCESS MODIFIEIRS ******

                        *********************** PUBLIC
                            Accessible from everywhere.

                            EXAMPLE
                                public class Customer
                                {
                                    public void Promote()
                                    {
                                        ...
                                    }
                                }

                                //YOU CAN CALL THE BELOW FROM ANYWHERE IN YOUR APPLICATION BY IMPORTING T
                                    HEM IF NOT IN USE WITHIN ClASSESS WITH SIMILAR NAMESPCE.

                                var customer = new Customer();
                                customer.Promote();

                        *********************** PRIVATE
                            Accessible only from the class.

                            EXAMPLE
                                public class Customer
                                {
                                    private int CalculateRate()
                                    {
                                        ...
                                    }
                                }

                                //YOU CAN CALL THE BELOW FROM ANYWHERE IN YOUR APPLICATION BY IMPORTING THEM
                                     IF NOT IN USE WITHIN ClASSESS WITH SIMILAR NAMESPCE.
                                    
                                var customer = new Customer();
                                customer.CalculateRate(); //THIS CANNOT BE SEEN WHEN DECLARING, THEREFORE AN ERROR

                        *********************** PROTECTED
                            Accessible only from the class and its derived classes.

                                EXAMPLE
                                    public class Customer
                                    {
                                        protected int CalculateRate()
                                        {
                                            ...
                                        }
                                    }

                                //YOU CANNOT ACCESS THE METHOD OUTSIDE OF IT"S CLASS OR OUTSIDE OF CLASSES DERIVED FROM the 
                                `CUSTOMER` class.
                                        
                                    var customer = new Customer();
                                    customer.CalculateRate(); //THIS CANNOT BE SEEN WHEN DECLARING, THEREFORE AN ERROR

                        *********************** INTERNAL
                            Accessible only from the same assembly.

                                EXAMPLE
                                    internal class RateCalculate
                                    {
                                    }

                                    //WORKS WELL WITHIN THE SAME ASSEMBLY
                                    var calc = new RateCalculate();
                                        
                                    //IT SHOWS ERROR IN ANOTHER ASSEMBLY (YOU CAN"T ACCESS IT)
                                    var calc = new RateCalculate();

                        *********************** PROTECTED INTERNAL
                             Accessible only from the same assembly or derived classes.

                                EXAMPLE
                                    public class Customer
                                    {
                                        protected internal void Weirdo()
                                        {
                                        }
                                    }

                                    //WORKS WELL WITHIN THE SAME ASSEMBLY
                                    var calc = new RateCalculate();
                                        
                                    //IT SHOWS ERROR IN ANOTHER ASSEMBLY (YOU CAN"T ACCESS IT)
                                    var calc = new RateCalculate();

                                    //PS: PROTECTED INTERNAL IS REALLY BAD AND SHOULD BE AVOIDED AT ALL COST.
              
            *****************************************************************************************************************************/
            //PublicAccessModifier
            var cusomer = new Customer();
            cusomer._name = "Cynthia";
            System.Console.WriteLine(cusomer._name);
            cusomer.CallMe("Berry");
            System.Console.WriteLine(cusomer._name); //PUBLIC IDETIFIER CAUSED THE NAME PROPERTY TO BE UPDATED ON THE CallMe METHOD
            cusomer.Promote();

        }
    }
}