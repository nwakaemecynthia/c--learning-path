namespace ControlFlow
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /**************************************************************************************************************
                                     **********CONDITIONALS**********
            **************************************************************************************************************/
            /****************************************************************************
                **IF STATEMENT**
            ****************************************************************************/
            int hour = 10;

            if (hour > 0 && hour < 12)
            {
                System.Console.WriteLine("It's Morning!");
            }
            else if (hour >= 12 && hour < 18)
            {
                System.Console.WriteLine("It's Afternoon!");
            }
            else if (hour >= 18 && hour <= 24)
            {
                System.Console.WriteLine("It's Evening!");
            }
            else
            {
                System.Console.WriteLine("This is beyound the time range of 24 hours!");
            }

            /****************************************************************************
                **SWITCH-CASE STATEMENT**
            ****************************************************************************/
            var currentSeason = Season.Autumn;

            switch (currentSeason)
            {
                case Season.Autumn:
                    System.Console.WriteLine("It's autumn and a beautiful season");
                    break;
                case Season.Summer:
                    System.Console.WriteLine("It's summer and a perfect time to go to the beach");
                    break;
                default:
                    System.Console.WriteLine("I don't understad the season");
                    break;
            }

            /****************************************************************************
                **CONDITIONAL / TERNARY OPERATOR**
            ****************************************************************************/
            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            System.Console.WriteLine(price);

            /**************************************************************************************************************
                                        **********LOOPS**********
            **************************************************************************************************************/
            /****************************************************************************
                **FOR LOOPS**
            ****************************************************************************/

            /****************************************************************************
                **FOR-EACH LOOPS**
            ****************************************************************************/
            /****************************************************************************
                88WHILE LOOPS**
            ****************************************************************************/
        }
    }
}
