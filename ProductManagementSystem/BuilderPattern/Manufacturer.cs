using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.BuilderPattern
{
    public class Manufacturer
    {
        public void Build(ProductBuilder builder)
        {
            builder.BuildProduct();
        }
    }
}
