namespace Basics2
{
    public class Arrays
    {
        /*
            Definition; An array is a data structure to store a collection of variables of the same type.
        */
        public void CreateArray(int size, int[] arrayData)
        {
            int[] numbers = new int[size];

            // Copy elements from arrayData into numbers up to the length of arrayData or size, whichever is smaller
            for (int i = 0; i < size && i < arrayData.Length; i++)
            {
                numbers[i] = arrayData[i];
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}