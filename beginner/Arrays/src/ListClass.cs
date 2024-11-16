using System.Collection.;
namespace Arrays
{
    public class ListClass
    {
        /**************************************************************************************************************
                                                ** LIST / GENERIC LIST **
             LIST is a generic type
             Arrays have a fixed size (ones you create it, they cannot be changed) but LIST helps with working with Objects/arrays
             where you are not sure ahead what the size would be.

             A list is similar to an array in a sense that its a data structure for storing a number of objects of the same type.
             DIFFERENCES BETWEEN ARRAY AND LIST
                * Array: FIXED SIZE
                * List: DYNAMIC SIZE

            SOME USEFUL METHODS
            1) Add()        // to add an object to a list
            2) AddRange()   // to add a list of objects to a list. You can add another list or an array
            3) Remove()     // to remove one object from a list
            4) RemoveAt()   // to remove an object at a given index
            5) IndexOf()    // returns the index of a given object
            6) Contains()   // tells us if the list contains a given object
            7) Count        // returns the number of objects in a list
             
         **************************************************************************************************************/
        public static void Learning()
        {
            //Creating a list
            var list1 = new List<int>(); //DECLARING A LIST
            var list2 = new List<int>() {2, 3, 7, 9,11, 13}; //DECLARING AND INITIALISING A LIST

            var list3 = new List<int>() { 2, 3, 7, 9, 11, 13 };
        }
    }
}