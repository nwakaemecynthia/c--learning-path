namespace SessionOne
{
    /************************************************************************************************
        ENCAPSULATON / INFORMATION HIDING; 
            Bundling data (fields) and methods (functions) that operate on the data into a 
            single unit called a class. Access is restricted to control changes.

            In practice, to use ENCAPSULATON
                1) We define fields as private
                2) We use getter/setter method as public
    *************************************************************************************************/
    public class Encapsulation
    {

    }
    public class PersonEncap
    {
        private DateTime _birthDate;

        public void SetBirthDate(DateTime date)
        {
           this._birthDate = date;
        }
        public DateTime GetBirthDate()
        {
            return this._birthDate;
        }
    }
}
