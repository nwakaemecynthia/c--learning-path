namespace Basics2
{
    /****************************************************************************
                                         ENUMS  
         Enums represent a set of name/value pairs (constants) , a number of relatable constants.
        By default, enums are integer but if you want to specify a data type, say byte , do it like below else no need to add the `: datatype`
       ****************************************************************************/
    public enum ShippingMethod: byte
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Experss = 3,
    }
    
    public enum Method
    {
        RegularAirMail, //this will auotmatoally take 0 as its value . subsequent methods will have an increment of 1 but for best practices always assign values to your enums
        RegisteredAirMail,
        Experss,
    }

}