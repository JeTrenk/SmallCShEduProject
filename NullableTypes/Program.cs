using System;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime dt = null; ====>>>>>
            Nullable<DateTime> dt = null;

            DateTime? dt1 = null;
            //Nullable types have following methods:
            //bool HasValue
            //Value
            //GetValueOrDefault()

            DateTime? date = null;
            DateTime date1 = date ?? DateTime.Today; //NULL COALSCING OPERATOR

            //it is equalalt to the:
            if(date != null)
            {
                date1 = date.GetValueOrDefault();
            }
            else
            {
                date1 = DateTime.Today;
            }

            //or to the:
            date1 = (date != null) ? date.GetValueOrDefault() : DateTime.Today;
        }
    }
}
