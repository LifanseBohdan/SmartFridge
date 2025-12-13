using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartFridge
{
    public class Product
    {
        public string Name { get; }
        public DateTime ExpirationDate { get; }

        public Product(string name, DateTime expirationDate)
        {
            Name = name;
            ExpirationDate = expirationDate;
        }
    }
}
