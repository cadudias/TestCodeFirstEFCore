using System.Collections.Generic;

namespace Domain
{
    public class Client
    {
        public int Id
        {
            get; set;
        }

        public string Name
        {
            get; set;
        }

        public IEnumerable<Product> Products
        {
            get; set;
        }
    }
}
