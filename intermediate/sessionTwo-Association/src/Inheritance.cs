namespace SessionTwo
{
    /****************************************************************************************************************************
        ************************** What is Inheritance?
            Inheritance is simply a kind of relationship between two classes that allows one to inherit code from the other.

        ************************** What are the benefits?
            1) CODE RE-USE
            2) POLYMORPHIC BEHAVIOUR

        ************************** UML Notation (UNIFIED MODELING LANGUAGE)
               The UML refers to The PARENT / BASE /SUPER Class; is the class which has the common property which are inheritable
            The CHILD / DERIVED / SUB class; is the class that accepts properties from  the parent

        ************************** Syntax
            //PARENT
                public class Car
                {
                    //Common attributes of a car
                }
            
            //CHILD
                public class Venza : Car
                {
                    //Specific attribute of a Venza
                }
    *****************************************************************************************************************************/
    public class PresentationObject
    {
        public int _width { get; set; }
        public int _height { get; set; }

        public void Copy()
        {
            System.Console.WriteLine("Object copied to your clipboard");
        }
        public void Duplicate()
        {
            System.Console.WriteLine("Object was duplicated");
        }

    }

    public class Text : PresentationObject
    {
        public int? _fontSize { get; set; }
        public string? _fontName { get; set; }

        public void AddHyperlink(string url)
        {
            System.Console.WriteLine("We added a link to {0}", url);
        }
    }
}