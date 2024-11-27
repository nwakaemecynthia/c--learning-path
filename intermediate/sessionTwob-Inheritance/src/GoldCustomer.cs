namespace PublicAccessModifier
{
    public class GoldCustomer : Customer
    {
        public void OfferVoucher()
        {
            //if CalculateRating(excludeOrders: true) has an access modifier of private, you wont see it here even if this class Inherits Customer attributes

            //however if the access modifier is changed to protected, you will be able to see it here byt
            //the problem is, if this method changes in the customer class, it will break the below code

            var rating = this.CalculateRating(excludeOrders: true);
        }
    }
}