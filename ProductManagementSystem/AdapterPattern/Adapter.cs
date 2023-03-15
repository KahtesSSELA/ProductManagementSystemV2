using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.AdapterPattern
{
    public class Adapter :ITarget
    {
        private Adaptee adaptee;

        public Adapter(Adaptee adaptee)
        {
            this.adaptee = adaptee;
        }
        public void getRequest(string id, string name, string prodtype, decimal price)
        {
            adaptee.request(id,name,prodtype,price);
        }
    }
}
