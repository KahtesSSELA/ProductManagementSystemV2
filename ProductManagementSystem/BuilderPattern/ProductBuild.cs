    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data;
using System.Data.SqlClient;
using ProductManagementSystem.AdapterPattern;

namespace ProductManagementSystem.BuilderPattern
{
   
    public class KiloProduct : ProductBuilder
    {
        
        Product product;
       
        public string id, name;
        public decimal price;

        public string ProductType = "Kilo Product";
        
        public KiloProduct(string id,string name,decimal price) {

            this.id = id;
            this.name = name;
            this.price = price;
        }
        public KiloProduct() { }
        public override void BuildProduct()
        {
            this.product = new Product(ProductType);

            MessageBox.Show("ToDo : "+ProductType +"ID :"+ id  + "Name :" +name+ "Price :"+price);
            Adaptee adaptee = new Insert();
            ITarget target = new Adapter(adaptee);
            target.getRequest(id, name, ProductType, price);


        }
        public Product ProdType { get { return product; } }
    }
    public class LiquidProduct : ProductBuilder
    {
        Product product;
        public string id, name;
        public decimal price;


        public string ProductType = "Liquid Product";

        public LiquidProduct(string id, string name, decimal price)
        {
            this.id = id;
            this.name = name;
            this.price = price;

        }
        public LiquidProduct(){}
        public override void BuildProduct()
        {
            this.product = new Product(ProductType);
            MessageBox.Show("ToDo : " + ProductType + "ID :" + id + "Name :" + name + "Price :" + price);
            Adaptee adaptee = new Insert();
            ITarget target = new Adapter(adaptee);
            target.getRequest(id, name, ProductType, price);
        }
        public Product ProdType { get { return product; } }
    }
}
