using System.Collections.Generic;

namespace SessionOne
{
    /*****************************************************************************************************
        ********************* INDEXER ***********************
        Indexer is a way to access elements in a class that represents a list of values.
        EXAMPLE
        var array = new int[5] { 1, 2, 3, 4, 5 };
        array[0] = 1; //[0] is an indexer
        var list = new List<int>() { 1, 2, 3, 4, 5 };
        list[0] = 1;

        ********************* WHY DO WE NEED TO DEFINE AN INDEXER IN A CLASS
        Sometimes we have classes that have collection semantics

        EXAMPLE
        var cookie = new HttpCookie();
        cookie.Expire = DateTime.Now.AddDays(5);

        //SAME CODE
        cookie["name"] = "Mosh"; //YOU CAN USE AN INDEXER
        cookie.SetItem("name", "Mosh); //OR, YOU CAN USE A METHOD

        //SAME CODE
        var name = cookie["name"];
        var name = cookie.GetItem("name");

        This example is to highlight case study of when a class does not have methods like SetCookie;
        You may either use an indexer or createa  method that can do per time what is required of the 
        application you are building.

        ********************* HOW TO DECLARE AN INDEXER
        An indexer is nothing but a class PROPERTY.
        EXAMPLE
            public class HttpCookie
            {
                public string this[string key]
                {
                    get { return key; }
                    set { key = value; }
                }
            }
    *****************************************************************************************************/

    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }


        public HttpCookie()
        {
            _dictionary = new Dictionary<string,string>();
        }

        /*****************************************************************************************************
            if you don't want to use a constructor like the above. Just do this
                private readonly Dictionary<string, string> _dictionary =  new Dictionary<string,string>();

            that way you DON'T NEED THE BELOW CODE BLOCK
                public HttpCookie()
                {
                    _dictionary = new Dictionary<string,string>();
                }
        ***********************************************************************************************************/

        //DECLARING AN INDEXER
        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}


