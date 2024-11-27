
namespace PublicAccessModifier
{
    public class Customer
    {
        public int _id { get; set; }
        public string _name { get; set; }

        public void CallMe(string name)
        {
            this._name = name;
            System.Console.WriteLine("{0} has been promoted by the power of the Holy Spirit", this._name);
        }
     
        public void Promote()
        {   
            var rating = CalculateRating(excludeOrders: true);

            if (rating == 0)
                System.Console.WriteLine("Promoted to Level 1");
            else
                System.Console.WriteLine("Promoted to level 2");
        }

        //Since the below class is only used inside of this class, it is bad to give it a modifier of `public`;
        // as it will allow the nethod to be accessible everywhere

        // public int CalculateRating()
        // {
        //     return 0;
        // }

        // private int CalculateRating(bool excludeOrders)
        // {
        //          if(excludeOrders) return 0;
                //else return 1;
        // }

        protected int CalculateRating(bool excludeOrders)
        {
            if(excludeOrders) return 0;
            else return 1;
        }
    }
}

