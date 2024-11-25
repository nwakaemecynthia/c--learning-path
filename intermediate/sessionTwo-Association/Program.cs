namespace SessionTwo
{
    internal class Program
    {
        /*******************************************************************************************************************
            ********************************** CLASS COUPLING
            COUPLING in software engineering is a way to measure how interconnected classes and subsystems are.

            ********************************** HOW: To ensure your class are not so tighly coupled that a change in
                                                    a class entity breaks your application, You must understand;
                1) ENCAPSULATION
                2) The relationship between classes 
                    a) Inheritance
                    b) Composition (Always favour Composition over inheritance)
                3) INTERFACES
        ********************************************************************************************************************/
        private static void Main(string[] args)
        {
            /*****************************************************************************************************************
                    **************************FAVOUR COMPOSITION OVER INHERITANCE**************************

                ************************** Problems with Inheritance
                    1) Easily abused by amature designers / developers
                    2) Large Hierarchies
                    3) Fragility
                    4) Tightly Coupled

                ************************** Advantages of Inheritance over Composition
                    Any inheritance relationship can be translated to COMPOSITION for more flexibility.
                        1) Great Flexibility
                        2) Eventual Loose Coupling
            ******************************************************************************************************************/

        }

        static void UseAssociation()
        {
            //INHERITANCE
            var text = new Text();
            text._width = 100;
            text._height = 20;
            var area = text._width * text._height;
            text.Copy();
            text.Duplicate();

            text.AddHyperlink("https://github.com/nwakaemecynthia");
            System.Console.WriteLine("Text area is: " + area);
        }

        static void UseComposition()
        {
            // METHOD 1
            var dbMigrator = new DBMigrator(new Logger());
            dbMigrator.Migrate("");

            // METHOD 2
            var logger = new Logger();
            var installer = new Installer(logger);
            installer.Install("");
        }
    }
}