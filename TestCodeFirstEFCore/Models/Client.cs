using System.Collections.Generic;

namespace TestCodeFirstEFCore.Models
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
