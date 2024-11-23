namespace SessionOne
{

    /*****************************************************************************************************
        ********************* ACCESS MODIFIERS ***********************
        Access modifier is a way to control acces sto a class and/or it's members.

        ****** WHY DO WE NEED ACCESS MODIFIEIRS ******
        This helps to create safety/guard in our programs thereby imporving it's robustness.

        ****** TYPES OF ACCESS MODIFIEIRS ******
        *********************** PUBLIC
        *********************** PRIVATE
        *********************** PROTECTED
        *********************** INTERNAL
        *********************** PROTECTED INTERNAL

        ****************** OBJECT ORIENTED PROGRAMMING (OOP) ***************
        *********************** ENCAPSULATON / INFORMATION HIDING
        *********************** INHERITANCE
        *********************** POLYMORPHISM
    ******************************************************************************************************/

    /******************************************** 
        PROPERTIES : A property is a class member that encapsulates a getter/setter for accessing a field.

        ****** WHY DO WE NEED PROPERTIES ******
        We need a property simply for creating getter/setter with less code.

        //WE WILL IMPROVED THE CODE ON ENCAPSULATION
    *****************************************/

    public class PersonMain //CORRECT WAY
    {
        public DateTime BithDate { get; private set; }
        //With this, C# compiler will create a private field and initialise a getter and setter as seen in Encapsulation file

        
        public PersonMain(DateTime bithDate) {
            this.BithDate = bithDate;
        }

       
        public int Age
        {
            get
            {
                // var timeStamp = DateTime.Now.Years - BithDate.Years;
                var timeStamp = DateTime.Today - BithDate;
                var years = timeStamp.Days / 365;

                return years;
            }
        }
    }
}