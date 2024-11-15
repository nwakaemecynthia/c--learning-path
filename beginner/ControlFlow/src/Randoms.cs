namespace ControlFlow
{
    public class Randoms
    {
        /**************************************************************************************************************
                                      **********RANDOM CLASS**********
        **************************************************************************************************************/
        public void RandomData()
        {

            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(random.Next());
                System.Console.WriteLine(random.Next(1, 10));
            }

            //GENERATE RANDOM PASSWORD
            const int passwordLength = 10;
            for (int i = 0; i < passwordLength; i++)
            {
                System.Console.Write((char)random.Next(97, 122));
            }
            System.Console.WriteLine();

            //IMPROVE THE PASSWORD GENERATOR same as the first password generator
            var buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = ((char)('a' + random.Next(0, 26)));
            }

            var password = new string(buffer);
            System.Console.WriteLine("NEW PASSWORD IS: {0}", password);
        }
    }
}