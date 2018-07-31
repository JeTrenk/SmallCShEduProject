using System;

namespace Encapsulation
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeParams: true);
            if (rating == 0)
            {
                Console.WriteLine("Rating is 0");
            }
            else
                Console.WriteLine("Rating is not 0");
        }

        protected int CalculateRating(bool excludeParams)
        {
            return 0;
        }
    }
}
