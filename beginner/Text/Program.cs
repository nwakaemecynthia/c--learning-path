using System.Text;

namespace Text
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /***************************************************************************************************************
                1) Useful String methods
                2) Converting Strings to Numbers
                3) Converting Numbers to Strings
                
                //METHODS
                var name = new string "sAsSy";
                var nickName =  new string"     sassy berry    ";

            
                  name.ToLower() // "sassy"
                  name.ToUpper() // "SASSY"
                  nickName.Trim() // "sassy berry"

                  name.IndexOf("a") // "1"
                  name.LastIndexOf("s") // "3"

                  name.Substring(startIndex)
                  name.Substring(startIndex, length)

                  Replace('a', '!')
                  nickName.Replace("berry", "diva")

                  //NULLCHECKER
                  String.IsNullorEmpty(name)
                  String.IsNullorWhiteSpace(name)

                  nickName.Split(' ')

                  //Converting STRINGS to NUMBERS
                  string s = "1234";
                  int i = int.Parse(s);
                  int j = Convert.ToInt32(s); //PREFERRD BECAUSE IT THROW 0 instead of error

                  //Converting NUMBERS to STRINGS
                  int k = 1234;
                  string t = k.ToString(); //1234
                  string u = k.ToString("C"); //$1,234.00
                  string v = k.ToString("CO"); //$1,234

                  FOMART STRING
                     Fomart specifiers     |       Description       |                Example
                  _________________________________________________________________________________________________
                     c or C                |      Currency           |       123456(C) => $123,456
                  _________________________________________________________________________________________________
                     d or D                |      Decimal            |       1234(D6) => 001234
                  _________________________________________________________________________________________________
                     e or E                |      Exponential        |        1052.0329112756(E) => 1.052033E+003
                  _________________________________________________________________________________________________
                     f or F                |      Fixed Point        |        1234.567(F1) => 1234.5
                  _________________________________________________________________________________________________
                     x or X                |      Hexadecimal        |         255(X) => FF
                  _________________________________________________________________________________________________

            ******************************************************************************************************************/
            var fullName = "Cynthia Nwakaeme     ";
            System.Console.WriteLine(fullName);
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("To Uppercase: '{0}'", fullName.Trim().ToUpper());
            Console.WriteLine("To Lowercase: '{0}'", fullName.Trim().ToLower());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1).Trim();
            Console.WriteLine("First Name: '{0}'", firstName);
            Console.WriteLine("Last Name: '{0}'", lastName);

            var names = fullName.Trim().Split(' ');
            Console.WriteLine("First Name: '{0}'", names[0]);
            Console.WriteLine("Last Name: '{0}'", names[names.Length - 1]);

            Console.WriteLine("My Full Name is; {0} ", fullName.Replace("Cynthia", "Cynthia Ebere"));
            Console.WriteLine("My Full Name is; {0} ", fullName.Replace('a', 'A'));

            var sentence = "This is going to be a really really long text to help you better understand me. Says string as if it knows what it is doing. Mituwahhhhhh";
            var summary = StringUtility.TextTruncate(sentence, 30);
            System.Console.WriteLine(summary);

            /*******************************************************
                STRING BUILDER: This is a class defined in `System.Text`. it is mutable text.
                It is easy and fast o create and manipulate.

                Unlink the `String` class, it is not optimised for search. so you can't do any of the String methods like
                IndexOf(), LastIndexOf(), Contains(), Startsith()...

                STRING BUILDER MANIPULATION METHODS
                Append()
                Insert()
                Remove()
                Replace()
                Clear()
            *********************************************************/
            var builder = new StringBuilder();
            builder.Append('-', 30);
            builder.AppendLine();
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 30);

            builder.Replace('-', '+');
            builder.Remove(0, 10);

            builder.Insert(0, new  string('-', 30));
            System.Console.WriteLine(builder);
            System.Console.WriteLine("Builder's first char: " + builder[0]);

            //OR
            builder
                .Append('-', 30)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 30).Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new string('-', 30));
        }
    }
}