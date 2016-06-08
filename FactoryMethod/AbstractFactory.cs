using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class AbstractFactory
    {
        protected abstract AbstractProduct CreateProduct(string owner);

        protected abstract void RegisterProduct(AbstractProduct product);

        public AbstractProduct Create(string owner)
        {
            AbstractProduct product = this.CreateProduct(owner);
            this.RegisterProduct(product);
            return product;
        }
    }
}
