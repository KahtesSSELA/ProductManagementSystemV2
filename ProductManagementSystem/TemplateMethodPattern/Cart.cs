using ProductManagementSystem.BuilderPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.TemplateMethodPattern
{
    public class Cart
    {
        string id,name,prodtype;
        decimal price;
        public List<Cart> products = new List<Cart>();
        public Cart(string id, string name, string prodtype, decimal price)
        {
            this.id = id;
            this.name = name;
            this.prodtype = prodtype;
            this.price = price;
            products.Add(this);
        }
        public Cart() { }
    }
}
