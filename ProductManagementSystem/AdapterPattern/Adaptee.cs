using ProductManagementSystem.BridgePattern;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagementSystem.AdapterPattern
{
    public abstract class Adaptee
    {
        public abstract void request(string id, string name, string prodtype, decimal price);
    }
    public class Insert :Adaptee
    {
        //Bridge bridge = new Insert();

        public override void request(string id, string name, string prodtype, decimal price)
        {
            Bridge bridge = new _insert();
            bridge.request(id,name, prodtype, price);
        }
    }
    public class Update : Adaptee {
        public override void request(string id, string name, string prodtype, decimal price)
        {
            Bridge bridge = new _update();
            bridge.request(id, name, prodtype, price);

        }
    }
    public class Delete : Adaptee {
        public override void request(string id, string name, string prodtype, decimal price)
        {
            Bridge bridge = new _delete();
            bridge.request(id, name, prodtype, price);

        }
    }
}
   

