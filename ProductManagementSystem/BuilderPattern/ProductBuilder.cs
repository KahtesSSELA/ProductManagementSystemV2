using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagementSystem.BuilderPattern
{
    public abstract class ProductBuilder : IProductBuilder
    {
        public abstract void BuildProduct();
        Product ProdType { get; }
    }
}
