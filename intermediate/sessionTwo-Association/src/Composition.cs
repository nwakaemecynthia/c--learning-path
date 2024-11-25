namespace SessionTwo
{
    /****************************************************************************************************************************
       ************************** What is Composition?
            Composition is a kind of relationship between two classes that allows one to contain the other.
            They have the following
                * Also known as, Has a relationship
                * Exmple: Car has an Engine

                EXAMPLE
                    * DB-Migrator requires logging
                    * Installer requires logging
                    To this effect, we can create a class called `Logger` that will be responsible for looging information into
                    a text file.

       ************************** What are the benefits?
            1) CODE RE-USE
            2) FLEXIBILITY
            3) A MEANS TO LOSSE-COUPLING

       ************************** UML Notation (UNIFIED MODELING LANGUAGE)
            The logger class is the lower class and both DB-Migrator and Installer both has access to this class.

       ************************** Syntax
       public class Installer
       {
            private Logger _logger;
            public Installer(Logger logger)
            {
                this._logger = logger;
            }
       }
   *****************************************************************************************************************************/
    public class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class DBMigrator
    {
        private readonly Logger _logger;
        public DBMigrator(Logger logger)
        {
            this._logger = logger;
        }
        public void Migrate(string? message)
        {
            // _logger.Log(message);
            System.Console.WriteLine("We are migrating blah blah blah..." + message);
        }
    }
    public class Installer
    {
        private readonly Logger _logger;
        public Installer(Logger logger)
        {
            this._logger = logger;
        }
        public void Install(string? message)
        {
            // _logger.Log(message);
            System.Console.WriteLine("We are installing an application" + message);
        }
    }
}