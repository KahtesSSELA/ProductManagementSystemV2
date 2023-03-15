using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.AdapterPattern
{
    public interface ITarget
    {
        void getRequest(string id, string name, string prodtype, decimal price);
    }
}
