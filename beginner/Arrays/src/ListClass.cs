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
            1) Add()        // to add an object to a list. (to the list end)
            2) AddRange()   // to add a list of objects to a list. You can add another list or an array
            3) Remove()     // to remove one object from a list
            4) RemoveAt()   // to remove an object at a given index
            5) IndexOf()    // returns the index of a given object
            6) Contains()   // tells us if the list contains a given object
            7) Count        // returns the number of objects in a list
             List can be gotten by importing it `using System.Collections.Generic;`.

             Note; IEnumerable repersents Arrays or List.
         **************************************************************************************************************/
        public static void Learning()
        {
            //Creating a list
            var list1 = new List<int>(); //DECLARING A LIST
            var list2 = new List<int>() {2, 3, 7, 9,11, 13}; //DECLARING AND INITIALISING A LIST

            var list3 = new List<int>() { 2, 3, 7, 9, 11, 13 };
            list3.Add(15);
            list3.AddRange(list2);
            list3.AddRange(new int[2] {16, 17});

            System.Console.WriteLine("Index of 15: " + list3.IndexOf(15));
            System.Console.WriteLine("Last index of 2: " + list3.LastIndexOf(2));
            System.Console.WriteLine("List3 Count: " + list3.Count);
            list3.Remove(2)
            foreach (var item in list3)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}