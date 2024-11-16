namespace Arrays
{
    public class ArrayClass
    {
        /**************************************************************************************************************
             1) Array Review
             2) Types of Arrays in C#
             3) Array Methods

             Array is a collection of fixed number of variables of the same type.
             We have 2 types of Arrays
                 1) Single Dimentional Array (1 x 1)    
                 2) Multi Dimentional Array (n x m) where n,m are positive integer; It is like a Matrix
                     there are 2 types of multi dimentional array in C#
                         a) Rectangular Arrays: each row has the exact same number of columns 
                                 3 x 5 
                                 ___0______1____2____5_____6_____                          
                                 ___11____18____3____5_____9_____                          
                                 ___40____12____23___15____16_____                          
                         b) Jagged Array: The number of columns in each row can be different, e.g an array of arrays
                                 ___0______1____2____5____                          
                                 ___11____18____3____6_____7____                       
                                 ___11____18____3____                         
                                 ___40____12____23___15____16____ 
             Array in C# is a class. it has some properties like 'Length' and 
             it has some methods like

                 1)Clear();
                 2)Copy();
                 3)IndexOf();
                 4)Reverse();
                 4)Sort();
         **************************************************************************************************************/
        public static void Learning()
        {
            //Single Dimentional Array
            var arr1 = new int[5]; //DECLARING SINGLE DIMENTIONAL ARRAY
            var arr2 = new int[5] { 1, 2, 3, 4, 5 }; //DECLARING AND INITIALIZING A SINGLE DIMENTIONAL ARRAY
            //TO ACCESS ELEMENT FROM THE ARRAY
            var element1 = arr2[0];

            //RECTANGULAR ARRAY
            var arr3 = new int[3, 5];  //DECLARING RECTANGULAR MULTI DIMENTIONAL ARRAY
            var arr4 = new int[3, 5] { //DECLARING AND INITIALIZING RECTANGULAR MULTI DIMENTIONAL ARRAY
                { 0, 1, 2, 5, 6},
                { 11, 18, 3, 5, 9},
                { 40, 12, 23, 15, 16},
            };
            //TO ACCESS ELEMENT FROM THE ARRAY
            var element2 = arr4[1, 4]; //result is 9 (ie from row 2 column 5)

            //JAGGED ARRAY
            int[][] arr5 = new int[4][];

            arr5[0] = new int[4];
            arr5[1] = new int[5];
            arr5[2] = new int[3];
            arr5[3] = new int[5];
            System.Console.WriteLine(arr5.Length);

            //TO ACCESS ELEMENT FROM THE ARRAY
            var element3 = arr5[1][2]; //result is 7 (ie from row 2 column 5)


            /*************** SOME ARRAY METHODS *****************/
            //EXAMPLE
            var array1 = new int[6] { 3, 7, 9, 2, 14, 6 };

            //LENGTH PROPERTIY: Returns the size of the array
            System.Console.WriteLine("Length: {0}", array1.Length);

            //INDEXOF() METHOD: Returns the index of an array element
            var index = Array.IndexOf(array1, 9);
            System.Console.WriteLine("The index of 9: {0}", index);

            //CLEAR() METHOD: Returns the index of an array element
            Array.Clear(array1, 0, 2); //0 is the STARTING INDEX, 2 is the number of element you would want to clear (clear means setting the element to 0)
            foreach (var item in array1)
            {
                System.Console.WriteLine("The elements in array1 => " + item);
            }

            //COPY()
            int[] array2 = new int[3];
            Array.Copy(array1, array2, 3); //The first parameter is THE SOURCE ARRAY, 
                                           // the second parameter is THE DESTINATION, the third parameter is THE NUMBER OF ELEMENT WE WANT TO COPY
            foreach (var item in array2)
            {
                System.Console.WriteLine("The new array, array2 element => " + item);
            }
            //SORT()
            Array.Sort(array1);
            foreach (var item in array1)
            {
                System.Console.WriteLine("The elements in array1 => " + item);
            }

            //REVERSE()
            Array.Reverse(array1);
            foreach (var item in array1)
            {
                System.Console.WriteLine("The elements in array1 => " + item);
            }
        }
    }
}