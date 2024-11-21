using System.IO;

namespace Files
{
    public class Test
    {
        /****************************************************************************
          1- Write a program that reads a text file and displays the number of words.
        ****************************************************************************/
        public static void FileCount(string filePath)
        {
            try
            {

                // Read all text from the file
                string text = File.ReadAllText(filePath);

                // Split the text into words using whitespace as the delimiter
                // StringSplitOptions.RemoveEmptyEntries ensures no empty strings are counted
                string[] words = text.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

                // Display the word count
                Console.WriteLine($"The file contains {words.Length} words.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found. Please check the file path and try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        /****************************************************************************
           2- Write a program that reads a text file and displays the longest word in the file.
        ****************************************************************************/
        public static void MaxLengthText(string filePath)
        {
            try
            {
                // Read all text from the file
                string text = File.ReadAllText(filePath);

                // Split the text into words using whitespace and punctuation as delimiters
                char[] delimiters = { ' ', '\t', '\n', '\r', ',', '.', '!', '?', ';', ':' };
                string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                // Find the longest word
                string longestWord = "";
                foreach (string word in words)
                {
                    if (word.Length > longestWord.Length)
                    {
                        longestWord = word;
                    }
                }

                // Display the longest word
                Console.WriteLine($"The longest word in the file is: {longestWord}");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found. Please check the file path and try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}